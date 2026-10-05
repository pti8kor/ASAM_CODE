namespace RB.ROCustomerInterface.Map {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.Transfer.TransferResultInformation", typeof(global::RB.ROCustomerInterface.Schema.Transfer.TransferResultInformation))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.Transfer.SingleFileTransferResultOld", typeof(global::RB.ROCustomerInterface.Schema.Transfer.SingleFileTransferResultOld))]
    public sealed class SinglefileImport : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://FTPIssueTransfer.FTPFileInformation"" xmlns:ns0=""http://RB.ROCustomerInterface.SingleFileTransferResult"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:TransferResult"" />
  </xsl:template>
  <xsl:template match=""/s0:TransferResult"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
    <ns0:SingleFileTransferResult>
      <RQ1System>
        <xsl:value-of select=""RQ1System/text()"" />
      </RQ1System>
      <XProtID>
        <xsl:value-of select=""XProtID/text()"" />
      </XProtID>
      <InterfaceName>
        <xsl:value-of select=""InterfaceName/text()"" />
      </InterfaceName>
      <DownloadTargetHost>
        <xsl:value-of select=""DownloadTargetHost/text()"" />
      </DownloadTargetHost>
      <DownloadTargetPath>
        <xsl:value-of select=""DownloadTargetPath/text()"" />
      </DownloadTargetPath>
      <DownloadTime>
        <xsl:value-of select=""DownloadTime/text()"" />
      </DownloadTime>
      <FileName>
        <xsl:value-of select=""$var:v1"" />
      </FileName>
      <Status>
        <xsl:value-of select=""$var:v1"" />
      </Status>
      <StatusInfo>
        <xsl:value-of select=""$var:v1"" />
      </StatusInfo>
      <TransactionID>
        <xsl:value-of select=""$var:v1"" />
      </TransactionID>
      <Mode>
        <xsl:value-of select=""Mode/text()"" />
      </Mode>
      <Category>
        <xsl:value-of select=""$var:v1"" />
      </Category>
    </ns0:SingleFileTransferResult>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"RB.ROCustomerInterface.Schema.Transfer.TransferResultInformation";
        
        private const global::RB.ROCustomerInterface.Schema.Transfer.TransferResultInformation _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"RB.ROCustomerInterface.Schema.Transfer.SingleFileTransferResultOld";
        
        private const global::RB.ROCustomerInterface.Schema.Transfer.SingleFileTransferResultOld _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltEngine {
            get {
                return _xsltEngine;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"RB.ROCustomerInterface.Schema.Transfer.TransferResultInformation";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"RB.ROCustomerInterface.Schema.Transfer.SingleFileTransferResultOld";
                return _TrgSchemas;
            }
        }
    }
}
