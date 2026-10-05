using System;
using RB.ROCustomerInterfaceExportLibrary;
using Xunit;

namespace RB.ROCustomerIntefaceLibrary.Tests
{
    /// <summary>
    /// Unit tests for LifeTokenManager covering all public methods and edge cases.
    /// </summary>
    public class LifeTokenManagerTests
    {
        #region Initialize

        [Fact]
        public void Initialize_ParsesTokensCorrectly()
        {
            var mgr = new LifeTokenManager();
            mgr.Initialize("REC1: Issue::In Progress||||REC2: Issue::Done||||");

            Assert.NotNull(mgr.GetLifeToken("REC1"));
            Assert.NotNull(mgr.GetLifeToken("REC2"));
        }

        [Fact]
        public void Initialize_EmptyString_DoesNotThrow()
        {
            var mgr = new LifeTokenManager();
            mgr.Initialize("");
            Assert.Null(mgr.GetLifeToken("anything"));
        }

        [Fact]
        public void Initialize_NullString_DoesNotThrow()
        {
            var mgr = new LifeTokenManager();
            mgr.Initialize(null);
            Assert.Null(mgr.GetLifeToken("anything"));
        }

        [Fact]
        public void Initialize_WhitespaceOnly_DoesNotThrow()
        {
            var mgr = new LifeTokenManager();
            mgr.Initialize("   ");
            Assert.Null(mgr.GetLifeToken("anything"));
        }

        [Fact]
        public void Initialize_SingleToken_Parsed()
        {
            var mgr = new LifeTokenManager();
            mgr.Initialize("REC1: Issue::Pending||||");
            Assert.Contains("REC1", mgr.GetLifeToken("REC1"));
        }

        #endregion

        #region UpdateSuccess

        [Fact]
        public void UpdateSuccess_ChangesStatusToSuccess()
        {
            var mgr = new LifeTokenManager();
            mgr.Initialize("REC1: Issue::In Progress||||");
            mgr.UpdateSuccess("REC1");

            string token = mgr.GetLifeToken("REC1");
            Assert.Contains("Success", token);
        }

        [Fact]
        public void UpdateSuccess_NonExistentKey_DoesNotThrow()
        {
            var mgr = new LifeTokenManager();
            mgr.Initialize("REC1: Issue::In Progress||||");
            mgr.UpdateSuccess("NONEXISTENT"); // should not throw
        }

        #endregion

        #region UpdateFailure

        [Fact]
        public void UpdateFailure_ChangesStatusToFailure()
        {
            var mgr = new LifeTokenManager();
            mgr.Initialize("REC1: Issue::In Progress||||");
            mgr.UpdateFailure("REC1", "timeout error");

            string token = mgr.GetLifeToken("REC1");
            Assert.Contains("Failure", token);
            Assert.Contains("timeout error", token);
        }

        [Fact]
        public void UpdateFailure_NonExistentKey_DoesNotThrow()
        {
            var mgr = new LifeTokenManager();
            mgr.Initialize("REC1: Issue::In Progress||||");
            mgr.UpdateFailure("NONEXISTENT", "err");
        }

        #endregion

        #region GetLifeToken

        [Fact]
        public void GetLifeToken_ExistingKey_ReturnsToken()
        {
            var mgr = new LifeTokenManager();
            mgr.Initialize("REC1: Issue::In Progress||||");
            Assert.NotNull(mgr.GetLifeToken("REC1"));
        }

        [Fact]
        public void GetLifeToken_NonExistentKey_ReturnsNull()
        {
            var mgr = new LifeTokenManager();
            mgr.Initialize("REC1: Issue::In Progress||||");
            Assert.Null(mgr.GetLifeToken("NOPE"));
        }

        #endregion

        #region UpdateLifeToken4FilesString

        [Fact]
        public void UpdateLifeToken4FilesString_ReplacesUpdatedTokens()
        {
            var mgr = new LifeTokenManager();
            string original = "REC1: Issue::In Progress||||REC2: Issue::In Progress||||";
            mgr.Initialize(original);
            mgr.UpdateSuccess("REC1");
            mgr.UpdateFailure("REC2", "error");

            string result = mgr.UpdateLifeToken4FilesString(original);

            Assert.Contains("Success", result);
            Assert.Contains("Failure", result);
        }

        [Fact]
        public void UpdateLifeToken4FilesString_EmptyInput_ReturnsEmpty()
        {
            var mgr = new LifeTokenManager();
            string result = mgr.UpdateLifeToken4FilesString("");
            Assert.Equal("", result);
        }

        [Fact]
        public void UpdateLifeToken4FilesString_NullInput_ReturnsNull()
        {
            var mgr = new LifeTokenManager();
            string result = mgr.UpdateLifeToken4FilesString(null);
            Assert.Null(result);
        }

        [Fact]
        public void UpdateLifeToken4FilesString_NoUpdates_ReturnsSameTokens()
        {
            var mgr = new LifeTokenManager();
            string original = "REC1: Issue::In Progress||||";
            mgr.Initialize(original);

            // No updates made
            string result = mgr.UpdateLifeToken4FilesString(original);

            Assert.Contains("REC1", result);
        }

        #endregion
    }
}
