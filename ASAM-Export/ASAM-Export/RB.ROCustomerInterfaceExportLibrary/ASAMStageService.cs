using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace RB.ROCustomerInterfaceExportLibrary
{
    public class ASAMStageService
    {
        private readonly string _connectionString;

        public ASAMStageService(string connectionString)
        {
            _connectionString = connectionString;
        }

        #region DB Helper Methods

        private object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteScalar();
                }
            }
        }

        private int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion

        public bool IsInProgress(string asamId)
        {
            try
            {
                string query = @"
            SELECT COUNT(1) 
            FROM AsamStage 
            WHERE AsamId LIKE @asamId + ':%'";

                var result = ExecuteScalar(query,
                    new SqlParameter("@asamId", asamId));

                return Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error checking in-progress for AsamId={asamId}", ex);
            }
        }

        // ✅ Create Stage (LOCK)
        public bool TryCreateStage(string processId, string xprotId, string asamId)
        {
            try
            {
                string query = @"
                    INSERT INTO AsamStage (ProcessId, XprotId, AsamId, Stage)
                    VALUES (@processId, @xprotId, @asamId, 'IN_PROGRESS')";

                ExecuteNonQuery(query,
                    new SqlParameter("@processId", processId),
                    new SqlParameter("@xprotId", xprotId),
                    new SqlParameter("@asamId", asamId));

                return true;
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                // Duplicate → already processing
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating stage for AsamId={asamId}", ex);
            }
        }

        public string GetXprotIdByAsamId(string asamId)
        {
            {
                try
                {
                    string query = @"
            SELECT TOP 1 XprotId 
            FROM AsamStage 
            WHERE AsamId LIKE @asamId + ':%'";

                    var result = ExecuteScalar(query,
                        new SqlParameter("@asamId", asamId));

                    return result?.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error fetching XprotId for AsamId={asamId}", ex);
                }
            }
        }

        // ✅ Wait for Stage (Equivalent to Java waitForStage)
        public async Task WaitForStageAsync(
            string processId,
            string expectedStage,
            AsyncLogger logger)
        {
            int maxRetry = 10;
            int retry = 0;
            int delayMs = 5000;

            try
            {
                while (true)
                {
                    string query = @"
                        SELECT Stage FROM AsamStage WHERE ProcessId = @processId";

                    var result = ExecuteScalar(query,
                        new SqlParameter("@processId", processId));

                    string currentStage = result?.ToString();


                    if (string.Equals(currentStage, expectedStage, StringComparison.OrdinalIgnoreCase))
                        return;

                    if (string.Equals(currentStage, "FAILED", StringComparison.OrdinalIgnoreCase))
                        throw new Exception("Process failed in downstream system");

                    if (retry >= maxRetry)
                        throw new TimeoutException("Expected stage not reached within retry limit");

                    retry++;

                    await Task.Delay(delayMs);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error waiting for stage for ProcessId={processId}", ex);
            }
        }

        // ✅ Update Stage
        public void UpdateStage(string processId, string newStage, string finalChange = null)
        {
            try
            {
                string query = @"
                    UPDATE AsamStage
                    SET Stage = @stage,
                        FinalChange = @finalChange,
                        UpdatedAt = GETDATE()
                    WHERE ProcessId = @processId";

                ExecuteNonQuery(query,
                    new SqlParameter("@stage", newStage),
                    new SqlParameter("@finalChange", finalChange ?? ""),
                    new SqlParameter("@processId", processId));
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating stage for ProcessId={processId}", ex);
            }
        }

        

        public void DeleteByXprot(string xprotId)
        {
            try
            {
                string query = "DELETE FROM AsamStage WHERE XprotId = @xprotId";

                ExecuteNonQuery(query,
                    new SqlParameter("@xprotId", xprotId));
            }
            

            catch (Exception ex)
            {
                throw new Exception($"Error deleting stage for ProcessId={xprotId}", ex);
            }
        }
    }
}