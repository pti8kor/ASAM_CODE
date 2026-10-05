namespace RB.ROCustomerInterface {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.DAIMLER.MessageAcknowledge+MESSAGE_ACKNOWLEDGE", typeof(global::RB.ROCustomerInterface.Schema.DAIMLER.MessageAcknowledge.MESSAGE_ACKNOWLEDGE))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM", typeof(global::RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM))]
    public sealed class RB_RO_DAIMLER320_ISSUE_IMF_MSGACK : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://RB.ROCustomerInterface.RB"" xmlns:s0=""http://www.asam.net/schemas/issue/messageacknowledgement"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" indent=""yes"" version=""1.0"" method=""xml"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:MESSAGE-ACKNOWLEDGE"" />
  </xsl:template>
  <xsl:template match=""/s0:MESSAGE-ACKNOWLEDGE"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;IGNORE&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;MESSAGE-ACKNOWLEDGE&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;DAI_ASAM320_SWRQ&quot;)"" />
    <ns0:ASAMISSUE_EXTRACT>
      <RT_VALEX_CONTROLINFO>
        <VALEX_CONTROLINFO>
          <xsl:attribute name=""ACTION"">
            <xsl:value-of select=""$var:v1"" />
          </xsl:attribute>
          <OEMEXTERNALSTATE>
            <xsl:value-of select=""$var:v2"" />
          </OEMEXTERNALSTATE>
          <OEMWORKFLOW>
            <xsl:value-of select=""$var:v3"" />
          </OEMWORKFLOW>
        </VALEX_CONTROLINFO>
      </RT_VALEX_CONTROLINFO>
      <xsl:variable name=""var:v4"" select=""userCSharp:GetDateInFormat()"" />
      <xsl:call-template name=""SetIRMAPS"">
        <xsl:with-param name=""DateTime"" select=""string($var:v4)"" />
      </xsl:call-template>
    </ns0:ASAMISSUE_EXTRACT>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string GetDateInFormat()
{
      
       // strDate = System.DateTime.Parse(DateTime.Today.ToString()).ToString(""yyyyMMdd"");
          System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo(""de-DE"");
           string strFormatedDateTime = System.DateTime.Parse(DateTime.Now.ToString()).ToString(""dd.MM.yyyy HH:mm:ss"", culture);
           return strFormatedDateTime;
}


public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
  <xsl:template name=""SetIRMAPS"">
	<xsl:param name=""DateTime"" />
	<RT_IRMAPS xmlns:ns0=""http://www.asam.net/schemas/issue/messageacknowledgement"">
		<IRMAP>
			<DBID>
				<xsl:value-of select=""substring-after(substring-before(/ns0:MESSAGE-ACKNOWLEDGE/ns0:TRANSACTION-ID,'-'),'IRM')"" />
			</DBID>
			<ERRORCODE>
				<xsl:for-each select=""/ns0:MESSAGE-ACKNOWLEDGE/ns0:ERROR-CODES/ns0:ERROR-CODE"">
					<P>
						<xsl:value-of select=""."" />
					</P>
				</xsl:for-each>
			</ERRORCODE>
			<TRANSACTIONID>
				<xsl:value-of select=""/ns0:MESSAGE-ACKNOWLEDGE/ns0:TRANSACTION-ID"" />
			</TRANSACTIONID>
			<EXTERNALCONVERSATION ACTION=""APPEND"">
				<P>
					<xsl:value-of select=""concat('### ',translate($DateTime,'.','-'),' #MSG-ACKNOWLEDGE### ')"" />
				</P>
				<P>
					<xsl:value-of select=""concat('[TRANSACTION-ID=',/ns0:MESSAGE-ACKNOWLEDGE/ns0:TRANSACTION-ID,']')"" />
				</P>
				<xsl:for-each select=""/ns0:MESSAGE-ACKNOWLEDGE/ns0:ERROR-CODES/ns0:ERROR-CODE"">
					<P>
						<xsl:value-of select=""."" />
					</P>
				</xsl:for-each>					
			</EXTERNALCONVERSATION>
			<xsl:variable name=""ErrorCode"">
				<xsl:for-each select=""/ns0:MESSAGE-ACKNOWLEDGE/ns0:ERROR-CODES/ns0:ERROR-CODE"">
					<xsl:value-of select=""."" />
				</xsl:for-each>
			</xsl:variable>
			<xsl:if test=""normalize-space($ErrorCode)!=''"">
				<LIFECYCLESTATE>Conflicted</LIFECYCLESTATE>
				<LIFECYCLESTATECOMMENT>					
					<xsl:for-each select=""/ns0:MESSAGE-ACKNOWLEDGE/ns0:ERROR-CODES/ns0:ERROR-CODE"">
						<xsl:choose>
							<xsl:when test=""position()=1"">
								<P><xsl:text>DDMan error message for last export to Daimler: </xsl:text><xsl:value-of select=""."" /></P>
							</xsl:when>
							<xsl:otherwise>
								<P><xsl:value-of select=""."" /></P>
							</xsl:otherwise>
						</xsl:choose>											
					</xsl:for-each>
				</LIFECYCLESTATECOMMENT>
				<WORKFLOWSTATUS>Waiting</WORKFLOWSTATUS>
			</xsl:if>
			<OPERATIONMODE><xsl:text>ASAM-IMPORT</xsl:text></OPERATIONMODE>
		    <OPERATIONCONTEXT><xsl:text>BizTalk</xsl:text></OPERATIONCONTEXT>
		</IRMAP>
	</RT_IRMAPS>
</xsl:template>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"RB.ROCustomerInterface.Schema.DAIMLER.MessageAcknowledge+MESSAGE_ACKNOWLEDGE";
        
        private const global::RB.ROCustomerInterface.Schema.DAIMLER.MessageAcknowledge.MESSAGE_ACKNOWLEDGE _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM";
        
        private const global::RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"RB.ROCustomerInterface.Schema.DAIMLER.MessageAcknowledge+MESSAGE_ACKNOWLEDGE";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM";
                return _TrgSchemas;
            }
        }
    }
}
