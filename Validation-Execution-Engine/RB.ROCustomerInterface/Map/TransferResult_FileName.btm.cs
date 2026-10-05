namespace RB.ROCustomerInterface.Map {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.Transfer.TransferResultInformation", typeof(global::RB.ROCustomerInterface.Schema.Transfer.TransferResultInformation))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.Transfer.TransferResultInformation", typeof(global::RB.ROCustomerInterface.Schema.Transfer.TransferResultInformation))]
    public sealed class TransferResult_FileName : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://FTPIssueTransfer.FTPFileInformation"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:TransferResult"" />
  </xsl:template>
  <xsl:template match=""/ns0:TransferResult"">
    <ns0:TransferResult>
      <RQ1System>
        <xsl:value-of select=""RQ1System/text()"" />
      </RQ1System>
      <XProtID>
        <xsl:value-of select=""XProtID/text()"" />
      </XProtID>
      <InterfaceName>
        <xsl:value-of select=""InterfaceName/text()"" />
      </InterfaceName>
      <xsl:for-each select=""TargetProjects"">
        <TargetProjects>
          <xsl:for-each select=""TargetProject"">
            <TargetProject>
              <ProjectID>
                <xsl:value-of select=""ProjectID/text()"" />
              </ProjectID>
              <ProjectDomain>
                <xsl:value-of select=""ProjectDomain/text()"" />
              </ProjectDomain>
              <xsl:value-of select=""./text()"" />
            </TargetProject>
          </xsl:for-each>
          <xsl:value-of select=""./text()"" />
        </TargetProjects>
      </xsl:for-each>
      <DownloadTargetHost>
        <xsl:value-of select=""DownloadTargetHost/text()"" />
      </DownloadTargetHost>
      <DownloadTargetPath>
        <xsl:value-of select=""DownloadTargetPath/text()"" />
      </DownloadTargetPath>
      <DownloadTime>
        <xsl:value-of select=""DownloadTime/text()"" />
      </DownloadTime>
      <LifeToken4XProt>
        <xsl:value-of select=""LifeToken4XProt/text()"" />
      </LifeToken4XProt>
      <LifeToken4Files>
        <xsl:value-of select=""LifeToken4Files/text()"" />
      </LifeToken4Files>
      <Mode>
        <xsl:value-of select=""Mode/text()"" />
      </Mode>
    </ns0:TransferResult>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"RB.ROCustomerInterface.Schema.Transfer.TransferResultInformation";
        
        private const global::RB.ROCustomerInterface.Schema.Transfer.TransferResultInformation _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"RB.ROCustomerInterface.Schema.Transfer.TransferResultInformation";
        
        private const global::RB.ROCustomerInterface.Schema.Transfer.TransferResultInformation _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"RB.ROCustomerInterface.Schema.Transfer.TransferResultInformation";
                return _TrgSchemas;
            }
        }
    }
}
