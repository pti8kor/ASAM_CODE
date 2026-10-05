namespace RB.ROCustomerInterface {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.HISMapperIN", typeof(global::RB.ROCustomerInterface.Schema.HISMapperIN))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.vwid2ttn_vwid2ttn_webservices_his_bosch_com+vwId2ttn", typeof(global::RB.ROCustomerInterface.vwid2ttn_vwid2ttn_webservices_his_bosch_com.vwId2ttn))]
    public sealed class Transform_HISInToWebReq : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://v2.vwid2ttn.webservices.his.bosch.com/"" xmlns:s0=""http://HISMapperIN.Schema"">
  <xsl:output omit-xml-declaration=""yes"" indent=""yes"" version=""1.0"" method=""xml"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:vwId2ttn"" />
  </xsl:template>
  <xsl:template match=""/s0:vwId2ttn"">
    <ns0:vwId2ttn>
      <xsl:for-each select=""KTNARG"">
        <KTNARG>
          <KTN>
            <xsl:value-of select=""KTN/text()"" />
          </KTN>
          <xsl:value-of select=""./text()"" />
        </KTNARG>
      </xsl:for-each>
      <xsl:value-of select=""./text()"" />
    </ns0:vwId2ttn>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"RB.ROCustomerInterface.Schema.HISMapperIN";
        
        private const global::RB.ROCustomerInterface.Schema.HISMapperIN _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"RB.ROCustomerInterface.vwid2ttn_vwid2ttn_webservices_his_bosch_com+vwId2ttn";
        
        private const global::RB.ROCustomerInterface.vwid2ttn_vwid2ttn_webservices_his_bosch_com.vwId2ttn _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"RB.ROCustomerInterface.Schema.HISMapperIN";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"RB.ROCustomerInterface.vwid2ttn_vwid2ttn_webservices_his_bosch_com+vwId2ttn";
                return _TrgSchemas;
            }
        }
    }
}
