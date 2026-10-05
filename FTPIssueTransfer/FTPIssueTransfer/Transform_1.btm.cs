namespace FTPIssueTransfer {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"FTPIssueTransfer.TransmitterRef.Reference+transmitterResponse", typeof(global::FTPIssueTransfer.TransmitterRef.Reference.transmitterResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"FTPIssueTransfer.TransmitterRef.Reference+transmitterResponse", typeof(global::FTPIssueTransfer.TransmitterRef.Reference.transmitterResponse))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://www.bosch.com/edexas/asam/transmitter/services"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:transmitterResponse"" />
  </xsl:template>
  <xsl:template match=""/ns0:transmitterResponse"">
    <ns0:transmitterResponse>
      <failure>
        <xsl:value-of select=""failure/text()"" />
      </failure>
      <xsl:if test=""result"">
        <result>
          <xsl:value-of select=""result/text()"" />
        </result>
      </xsl:if>
      <xsl:value-of select=""./text()"" />
    </ns0:transmitterResponse>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"FTPIssueTransfer.TransmitterRef.Reference+transmitterResponse";
        
        private const global::FTPIssueTransfer.TransmitterRef.Reference.transmitterResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"FTPIssueTransfer.TransmitterRef.Reference+transmitterResponse";
        
        private const global::FTPIssueTransfer.TransmitterRef.Reference.transmitterResponse _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"FTPIssueTransfer.TransmitterRef.Reference+transmitterResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"FTPIssueTransfer.TransmitterRef.Reference+transmitterResponse";
                return _TrgSchemas;
            }
        }
    }
}
