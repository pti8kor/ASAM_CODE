using System;
using System.Xml;
using RB.ROCustomerInterfaceExportLibrary;
using Xunit;

namespace RB.ROCustomerIntefaceLibrary.Tests
{
    /// <summary>
    /// Unit tests for the TestInput helper and ROConfigurationManager.
    /// </summary>
    public class ConfigAndInputTests
    {
        #region TestInput.FromXml

        [Fact]
        public void TestInput_FromXml_ParsesAllFields()
        {
            string xml = @"<Root xmlns:ns0='http://FTPIssueTransfer.FTPFileInformation'>
                             <ns0:XProtID>12345</ns0:XProtID>
                             <ns0:InterfaceName>RO-ASAM-AUDI</ns0:InterfaceName>
                             <ns0:RQ1System>CDG_DEV</ns0:RQ1System>
                             <ns0:LifeToken4Files>REC1: Issue::Pending||||</ns0:LifeToken4Files>
                             <ns0:LifeToken4XProt>XP-Token</ns0:LifeToken4XProt>
                           </Root>";

            var input = TestInput.FromXml(xml);

            Assert.Equal("12345", input.XProtID);
            Assert.Equal("RO-ASAM-AUDI", input.InterfaceName);
            Assert.Equal("CDG_DEV", input.RQ1System);
            Assert.Equal("REC1: Issue::Pending||||", input.LifeTokenForFiles);
            Assert.Equal("XP-Token", input.LifeTokenForXProt);
        }

        [Fact]
        public void TestInput_FromXml_MissingNodes_ReturnsNulls()
        {
            string xml = @"<Root xmlns:ns0='http://FTPIssueTransfer.FTPFileInformation'>
                             <ns0:XProtID>12345</ns0:XProtID>
                           </Root>";

            var input = TestInput.FromXml(xml);

            Assert.Equal("12345", input.XProtID);
            Assert.Null(input.InterfaceName);
            Assert.Null(input.RQ1System);
        }

        #endregion

        #region ROConfigurationManager

        [Fact]
        public void ROConfigurationManager_EmptyPath_ReturnsNull()
        {
            var mgr = new ROConfigurationManager("", new Logger(System.IO.Path.GetTempFileName()));
            var result = mgr.LoadConfigurationXML();
            Assert.Null(result);
        }

        [Fact]
        public void ROConfigurationManager_NonExistentFile_ReturnsNull()
        {
            var mgr = new ROConfigurationManager(@"C:\nonexistent_file_xyz.xml", new Logger(System.IO.Path.GetTempFileName()));
            var result = mgr.LoadConfigurationXML();
            Assert.Null(result);
        }

        [Fact]
        public void ROConfigurationManager_DefaultConstructor_DoesNotThrow()
        {
            var mgr = new ROConfigurationManager();
            Assert.NotNull(mgr);
        }

        #endregion

        #region ROExceptionManager - Custom Exceptions

        [Fact]
        public void InterfaceConfigNotFoundException_MessageRoundTrip()
        {
            var ex = new InterfaceConfigNotFoundException("config missing");
            Assert.Equal("config missing", ex.Message);
        }

        [Fact]
        public void InterfaceConfigNotFoundException_InnerException()
        {
            var inner = new Exception("inner");
            var ex = new InterfaceConfigNotFoundException("outer", inner);
            Assert.Equal("outer", ex.Message);
            Assert.Same(inner, ex.InnerException);
        }

        [Fact]
        public void CQLoginException_MessageRoundTrip()
        {
            var ex = new CQLoginExcption("login failed");
            Assert.Equal("login failed", ex.Message);
        }

        [Fact]
        public void InvalidExchangeFormatException_MessageRoundTrip()
        {
            var ex = new InvalidExchangeFormatException("bad format");
            Assert.Equal("bad format", ex.Message);
        }

        [Fact]
        public void IMFRulesFileNotFoundFileException_DefaultConstructor()
        {
            var ex = new IMFRulesFileNotFoundFileException();
            Assert.NotNull(ex);
        }

        [Fact]
        public void ProcessAllRulesException_InnerException()
        {
            var inner = new Exception("inner");
            var ex = new ProcessAllRulesException("rules error", inner);
            Assert.Same(inner, ex.InnerException);
        }

        [Fact]
        public void ProcessCommonRulesException_Message()
        {
            var ex = new ProcessCommonRulesException("common rules");
            Assert.Equal("common rules", ex.Message);
        }

        [Fact]
        public void ProcessIMFRuleException_Message()
        {
            var ex = new ProcessIMFRuleException("imf rule");
            Assert.Equal("imf rule", ex.Message);
        }

        [Fact]
        public void InvalidRORecordtypeException_Message()
        {
            var ex = new InvalidRORecordtypeException("bad type");
            Assert.Equal("bad type", ex.Message);
        }

        [Fact]
        public void IMFXPATHMissingException_Message()
        {
            var ex = new IMFXPATHMissingException("xpath missing");
            Assert.Equal("xpath missing", ex.Message);
        }

        [Fact]
        public void OperatorNotImplementedException_Message()
        {
            var ex = new OperatorNotImplementedException("op not impl");
            Assert.Equal("op not impl", ex.Message);
        }

        [Fact]
        public void KeyNotFoundInConfigFileException_Message()
        {
            var ex = new KeyNotFoundInConfigFileException("key not found");
            Assert.Equal("key not found", ex.Message);
        }

        [Fact]
        public void ExternalIDMissingException_Message()
        {
            var ex = new ExternalIDMissingException("ext id missing");
            Assert.Equal("ext id missing", ex.Message);
        }

        [Fact]
        public void LockRecordException_Message()
        {
            var ex = new LockRecordException("lock error");
            Assert.Equal("lock error", ex.Message);
        }

        [Fact]
        public void IMRuleFileLoadingException_Message()
        {
            var ex = new IMRuleFileLoadingException("load error");
            Assert.Equal("load error", ex.Message);
        }

        #endregion
    }
}
