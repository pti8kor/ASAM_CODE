namespace RB.ROCustomerInterface {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.vwid2ttn_vwid2ttn_webservices_his_bosch_com+vwId2ttnResponse", typeof(global::RB.ROCustomerInterface.vwid2ttn_vwid2ttn_webservices_his_bosch_com.vwId2ttnResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.HISMapperOUT", typeof(global::RB.ROCustomerInterface.Schema.HISMapperOUT))]
    public sealed class WebResponse2HISOut : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://v2.vwid2ttn.webservices.his.bosch.com/"" xmlns:ns0=""http://HISMapperOUT.Schema"">
  <xsl:output omit-xml-declaration=""yes"" indent=""yes"" version=""1.0"" method=""xml"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:vwId2ttnResponse"" />
  </xsl:template>
  <xsl:template match=""/s0:vwId2ttnResponse"">
    <ns0:vwId2ttnResponse>
      <xsl:for-each select=""VwAsamMappingOutputKtn"">
        <VwAsamMappingOutputKtn>
          <xsl:if test=""KTN"">
            <KTN>
              <xsl:value-of select=""KTN/text()"" />
            </KTN>
          </xsl:if>
          <xsl:for-each select=""mapping"">
            <mapping>
              <xsl:if test=""RBTTN"">
                <RBTTN>
                  <xsl:value-of select=""RBTTN/text()"" />
                </RBTTN>
              </xsl:if>
              <xsl:if test=""RBTYPE"">
                <RBTYPE>
                  <xsl:value-of select=""RBTYPE/text()"" />
                </RBTYPE>
              </xsl:if>
              <xsl:if test=""RBSGBZ"">
                <RBSGBZ>
                  <xsl:value-of select=""RBSGBZ/text()"" />
                </RBSGBZ>
              </xsl:if>
              <xsl:value-of select=""./text()"" />
            </mapping>
          </xsl:for-each>
          <xsl:if test=""resultStatus"">
            <resultStatus>
              <xsl:value-of select=""resultStatus/text()"" />
            </resultStatus>
          </xsl:if>
          <xsl:if test=""resultMessage"">
            <resultMessage>
              <xsl:value-of select=""resultMessage/text()"" />
            </resultMessage>
          </xsl:if>
          <xsl:value-of select=""./text()"" />
        </VwAsamMappingOutputKtn>
      </xsl:for-each>
      <xsl:value-of select=""./text()"" />
    </ns0:vwId2ttnResponse>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"RB.ROCustomerInterface.vwid2ttn_vwid2ttn_webservices_his_bosch_com+vwId2ttnResponse";
        
        private const global::RB.ROCustomerInterface.vwid2ttn_vwid2ttn_webservices_his_bosch_com.vwId2ttnResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"RB.ROCustomerInterface.Schema.HISMapperOUT";
        
        private const global::RB.ROCustomerInterface.Schema.HISMapperOUT _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"RB.ROCustomerInterface.vwid2ttn_vwid2ttn_webservices_his_bosch_com+vwId2ttnResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"RB.ROCustomerInterface.Schema.HISMapperOUT";
                return _TrgSchemas;
            }
        }
    }
}
