namespace FTPIssueTransfer {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"FTPIssueTransfer.StartExportRequest", typeof(global::FTPIssueTransfer.StartExportRequest))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"FTPIssueTransfer.TransferResultInformation", typeof(global::FTPIssueTransfer.TransferResultInformation))]
    public sealed class Map2TransferResultExp : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://FTPIssueTransfer.FTPFileInformation"" xmlns:s0=""http://FTPIssueTransfer.StartExportRequest"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:ExportRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:ExportRequest"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
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
      <TargetProjects>
        <TargetProject>
          <ProjectID>
            <xsl:value-of select=""TargetedProjects/TargetedProject/ProjectID/text()"" />
          </ProjectID>
          <ProjectDomain>
            <xsl:value-of select=""TargetedProjects/TargetedProject/ProjectDomain/text()"" />
          </ProjectDomain>
          <xsl:value-of select=""TargetedProjects/TargetedProject/text()"" />
        </TargetProject>
      </TargetProjects>
      <LifeToken4XProt>
        <xsl:value-of select=""$var:v1"" />
      </LifeToken4XProt>
      <LifeToken4Files>
        <xsl:value-of select=""$var:v1"" />
      </LifeToken4Files>
      <Mode>
        <xsl:value-of select=""$var:v1"" />
      </Mode>
    </ns0:TransferResult>
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
        
        private const string _strSrcSchemasList0 = @"FTPIssueTransfer.StartExportRequest";
        
        private const global::FTPIssueTransfer.StartExportRequest _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"FTPIssueTransfer.TransferResultInformation";
        
        private const global::FTPIssueTransfer.TransferResultInformation _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"FTPIssueTransfer.StartExportRequest";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"FTPIssueTransfer.TransferResultInformation";
                return _TrgSchemas;
            }
        }
    }
}
