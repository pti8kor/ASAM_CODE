namespace FTPIssueTransfer {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"FTPIssueTransfer.InitialTransmitterRequestSchema", typeof(global::FTPIssueTransfer.InitialTransmitterRequestSchema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"FTPIssueTransfer.TransmitterRef.Reference+transmitterRequest", typeof(global::FTPIssueTransfer.TransmitterRef.Reference.transmitterRequest))]
    public sealed class TransformTransmitterRequestMessage : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://FTPIssueTransfer.InitialTransmitterRequestSchema"" xmlns:ns0=""http://www.bosch.com/edexas/asam/transmitter/services"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:transmitterRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:transmitterRequest"">
    <ns0:transmitterRequest>
      <xsl:if test=""transferBinary"">
        <transferBinary>
          <xsl:value-of select=""transferBinary/text()"" />
        </transferBinary>
      </xsl:if>
      <xsl:if test=""transferData"">
        <transferData>
          <xsl:value-of select=""transferData/text()"" />
        </transferData>
      </xsl:if>
      <xsl:if test=""transferFile"">
        <transferFile>
          <xsl:value-of select=""transferFile/text()"" />
        </transferFile>
      </xsl:if>
      <xsl:if test=""transferType"">
        <transferType>
          <xsl:value-of select=""transferType/text()"" />
        </transferType>
      </xsl:if>
    </ns0:transmitterRequest>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"FTPIssueTransfer.InitialTransmitterRequestSchema";
        
        private const global::FTPIssueTransfer.InitialTransmitterRequestSchema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"FTPIssueTransfer.TransmitterRef.Reference+transmitterRequest";
        
        private const global::FTPIssueTransfer.TransmitterRef.Reference.transmitterRequest _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"FTPIssueTransfer.InitialTransmitterRequestSchema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"FTPIssueTransfer.TransmitterRef.Reference+transmitterRequest";
                return _TrgSchemas;
            }
        }
    }
}
