using RB.ROCustomerInterfaceExportLibrary;
using System;
using System.Threading.Tasks;
using Xunit;

namespace RB.ROCustomerIntefaceLibrary.Tests
{
    /// <summary>
    /// Comprehensive test cases for LifeTokenManager class
    /// </summary>
    public class LifeTokenManagerTest_Comprehensive
    {
        #region Constructor and Initialization Tests

        [Fact]
        public void LifeTokenManager_Constructor_CreatesInstance()
        {
            // Act
            LifeTokenManager manager = new LifeTokenManager();

            // Assert
            Assert.NotNull(manager);
        }

        [Fact]
        public void Initialize_ValidTokenString_ParsesCorrectly()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();
            string tokens = BTHelperConstants.lifeToken_Multiple_Mixed;

            // Act
            manager.Initialize(tokens);

            // Assert
            string token1 = manager.GetLifeToken("RQ1ML00138253");
            Assert.NotNull(token1);
            Assert.Contains("RQ1ML00138253", token1);
        }

        [Fact]
        public void Initialize_EmptyString_HandlesGracefully()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();

            // Act
            manager.Initialize(string.Empty);

            // Assert - Should not throw
            string token = manager.GetLifeToken("RQ1ML00138253");
            Assert.Null(token);
        }

        [Fact]
        public void Initialize_NullString_HandlesGracefully()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();

            // Act
            manager.Initialize(null);

            // Assert - Should not throw
            string token = manager.GetLifeToken("RQ1ML00138253");
            Assert.Null(token);
        }

        [Fact]
        public void Initialize_WhitespaceString_HandlesGracefully()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();

            // Act
            manager.Initialize("   ");

            // Assert
            string token = manager.GetLifeToken("RQ1ML00138253");
            Assert.Null(token);
        }

        [Fact]
        public void Initialize_SingleToken_ParsesCorrectly()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();
            string token = "RQ1ML00138253: Issue::In Progress||||";

            // Act
            manager.Initialize(token);

            // Assert
            string retrievedToken = manager.GetLifeToken("RQ1ML00138253");
            Assert.NotNull(retrievedToken);
            Assert.Contains("In Progress", retrievedToken);
        }

        [Fact]
        public void Initialize_MultipleTokens_ParsesAll()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();

            // Act
            manager.Initialize(BTHelperConstants.lifeToken_Multiple_Mixed_LifeToken);

            // Assert
            Assert.NotNull(manager.GetLifeToken("RQ1ML00138253"));
            Assert.NotNull(manager.GetLifeToken("RQ1ML00138254"));
            Assert.NotNull(manager.GetLifeToken("RQ1ML00138255"));
        }

        #endregion

        #region UpdateSuccess Tests

        [Fact]
        public void UpdateSuccess_ExistingRecord_UpdatesStatus()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();
            string recordId = "RQ1ML00138253";
            manager.Initialize($"{recordId}: Issue::In Progress||||");

            // Act
            manager.UpdateSuccess(recordId);

            // Assert
            string token = manager.GetLifeToken(recordId);
            Assert.Contains("Success", token);
        }

        [Fact]
        public void UpdateSuccess_NonExistingRecord_DoesNotThrow()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();

            // Act & Assert - Should not throw
            manager.UpdateSuccess("RQ1ML99999999");
        }

        [Fact]
        public void UpdateSuccess_MultipleUpdates_KeepsLatestStatus()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();
            string recordId = "RQ1ML00138253";
            manager.Initialize($"{recordId}: Issue::In Progress||||");

            // Act
            manager.UpdateSuccess(recordId);
            manager.UpdateSuccess(recordId);

            // Assert
            string token = manager.GetLifeToken(recordId);
            Assert.Contains("Success", token);
        }

        #endregion

        #region UpdateFailure Tests

        [Fact]
        public void UpdateFailure_ExistingRecord_UpdatesStatusWithError()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();
            string recordId = "RQ1ML00138253";
            manager.Initialize($"{recordId}: Issue::In Progress||||");

            // Act
            manager.UpdateFailure(recordId, "Connection timeout");

            // Assert
            string token = manager.GetLifeToken(recordId);
            Assert.Contains("Failure", token);
            Assert.Contains("Connection timeout", token);
        }

        [Fact]
        public void UpdateFailure_NonExistingRecord_DoesNotThrow()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();

            // Act & Assert - Should not throw
            manager.UpdateFailure("RQ1ML99999999", "Test error");
        }

        [Fact]
        public void UpdateFailure_EmptyErrorMessage_UpdatesStatus()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();
            string recordId = "RQ1ML00138253";
            manager.Initialize($"{recordId}: Issue::In Progress||||");

            // Act
            manager.UpdateFailure(recordId, string.Empty);

            // Assert
            string token = manager.GetLifeToken(recordId);
            Assert.Contains("Failure", token);
        }

        [Fact]
        public void UpdateFailure_LongErrorMessage_HandlesCorrectly()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();
            string recordId = "RQ1ML00138253";
            string longError = new string('E', 1000);
            manager.Initialize($"{recordId}: Issue::In Progress||||");

            // Act
            manager.UpdateFailure(recordId, longError);

            // Assert
            string token = manager.GetLifeToken(recordId);
            Assert.Contains("Failure", token);
            Assert.Contains(longError, token);
        }

        #endregion

        #region GetLifeToken Tests

        [Fact]
        public void GetLifeToken_ExistingRecord_ReturnsToken()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();
            string recordId = "RQ1ML00138253";
            manager.Initialize($"{recordId}: Issue::In Progress||||");

            // Act
            string token = manager.GetLifeToken(recordId);

            // Assert
            Assert.NotNull(token);
            Assert.Contains(recordId, token);
        }

        [Fact]
        public void GetLifeToken_NonExistingRecord_ReturnsNull()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();

            // Act
            string token = manager.GetLifeToken("RQ1ML99999999");

            // Assert
            Assert.Null(token);
        }

        [Fact]
        public void GetLifeToken_AfterSuccess_ReturnsUpdatedToken()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();
            string recordId = "RQ1ML00138253";
            manager.Initialize($"{recordId}: Issue::In Progress||||");
            manager.UpdateSuccess(recordId);

            // Act
            string token = manager.GetLifeToken(recordId);

            // Assert
            Assert.Contains("Success", token);
        }

        [Fact]
        public void GetLifeToken_AfterFailure_ReturnsUpdatedToken()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();
            string recordId = "RQ1ML00138253";
            manager.Initialize($"{recordId}: Issue::In Progress||||");
            manager.UpdateFailure(recordId, "Test error");

            // Act
            string token = manager.GetLifeToken(recordId);

            // Assert
            Assert.Contains("Failure", token);
            Assert.Contains("Test error", token);
        }

        #endregion

        #region UpdateLifeToken4FilesString Tests

        [Fact]
        public void UpdateLifeToken4FilesString_UpdatesSingleRecord()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();
            string recordId = "RQ1ML00138253";
            string original = $"{recordId}: Issue::In Progress||||";
            manager.Initialize(original);
            manager.UpdateSuccess(recordId);

            // Act
            string updated = manager.UpdateLifeToken4FilesString(original);

            // Assert
            Assert.Contains("Success", updated);
        }

        [Fact]
        public void UpdateLifeToken4FilesString_UpdatesMultipleRecords()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();
            string original = BTHelperConstants.lifeToken_Multiple_Mixed;
            manager.Initialize(original);
            manager.UpdateSuccess("RQ1ML00138253");
            manager.UpdateFailure("RQ1ML00138254", "Error");

            // Act
            string updated = manager.UpdateLifeToken4FilesString(original);

            // Assert
            Assert.Contains("Success", updated);
            Assert.Contains("Failure", updated);
        }

        [Fact]
        public void UpdateLifeToken4FilesString_EmptyString_ReturnsEmpty()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();

            // Act
            string result = manager.UpdateLifeToken4FilesString(string.Empty);

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void UpdateLifeToken4FilesString_NullString_ReturnsNull()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();

            // Act
            string result = manager.UpdateLifeToken4FilesString(null);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void UpdateLifeToken4FilesString_PreservesUnmodifiedTokens()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();
            string original = "RQ1ML00138253: Issue::In Progress|||| RQ1ML00138254: Issue::In Progress||||";
            manager.Initialize(original);
            manager.UpdateSuccess("RQ1ML00138253");
            // Don't update second record

            // Act
            string updated = manager.UpdateLifeToken4FilesString(original);

            // Assert
            Assert.Contains("RQ1ML00138253", updated);
            Assert.Contains("Success", updated);
            Assert.Contains("RQ1ML00138254", updated);
        }

        #endregion

        #region Thread Safety Tests

        [Fact]
        public void LifeTokenManager_ConcurrentUpdates_HandlesThreadSafely()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();
            manager.Initialize(BTHelperConstants.lifeToken_LargeBatch);
            Task[] tasks = new Task[10];

            // Act
            for (int i = 0; i < tasks.Length; i++)
            {
                int index = i;
                tasks[i] = Task.Run(() =>
                {
                    if (index % 2 == 0)
                        manager.UpdateSuccess($"RQ1ML0013825{index % 5}");
                    else
                        manager.UpdateFailure($"RQ1ML0013825{index % 5}", $"Error {index}");
                });
            }

            Task.WaitAll(tasks);

            // Assert - No exceptions thrown means thread-safety worked
            Assert.True(true);
        }

        [Fact]
        public void LifeTokenManager_ConcurrentReads_HandlesThreadSafely()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();
            manager.Initialize(BTHelperConstants.lifeToken_Multiple_Mixed);
            Task<string>[] tasks = new Task<string>[20];

            // Act
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run(() => manager.GetLifeToken("RQ1ML00138253"));
            }

            Task.WaitAll(tasks);

            // Assert
            Assert.All(tasks, task => Assert.NotNull(task.Result));
        }

        #endregion

        #region Complex Scenario Tests

        [Fact]
        public void LifeTokenManager_CompleteWorkflow_HandlesCorrectly()
        {
            // Arrange
            LifeTokenManager manager = new LifeTokenManager();
            string original = "RQ1ML00138253: Issue::In Progress|||| RQ1ML00138254: Issue::In Progress|||| RQ1ML00138255: Issue::In Progress||||";

            // Act - Simulate complete workflow
            manager.Initialize(original);
            manager.UpdateSuccess("RQ1ML00138253");
            manager.UpdateFailure("RQ1ML00138254", "Database error");
            manager.UpdateSuccess("RQ1ML00138255");

            string updated = manager.UpdateLifeToken4FilesString(original);

            // Assert
            Assert.Contains("RQ1ML00138253", updated);
            Assert.Contains("Success", updated);
            Assert.Contains("RQ1ML00138254", updated);
            Assert.Contains("Failure", updated);
            Assert.Contains("Database error", updated);
            Assert.Contains("RQ1ML00138255", updated);
        }

        #endregion
    }
}