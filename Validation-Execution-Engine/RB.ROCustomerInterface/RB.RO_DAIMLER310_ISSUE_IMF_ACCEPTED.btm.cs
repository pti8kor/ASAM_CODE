namespace RB.ROCustomerInterface {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.DAIMLER.issue_v3_1_0_DaiModV1_sl", typeof(global::RB.ROCustomerInterface.Schema.DAIMLER.issue_v3_1_0_DaiModV1_sl))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM", typeof(global::RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM))]
    public sealed class RB_RO_DAIMLER310_ISSUE_IMF_ACCEPTED : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1 userCSharp"" version=""1.0"" xmlns:s1=""http://www.asam.net/schemas/issue/issue310-DaiModV1"" xmlns:s0=""http://www.w3.org/XML/1998/namespace"" xmlns:ns0=""http://RB.ROCustomerInterface.RB"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" indent=""yes"" version=""1.0"" method=""xml"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:MSR-ISSUE"" />
  </xsl:template>
  <xsl:template match=""/s1:MSR-ISSUE"">
    <ns0:ASAMISSUE_EXTRACT>
      <RT_VALEX_CONTROLINFO>
        <xsl:for-each select=""s1:ISSUES/s1:ISSUE"">
          <VALEX_CONTROLINFO>
            <OEMEXTERNALSTATE xmlns:ns0=""http://www.asam.net/schemas/issue/issue310-DaiModV1"">   
        <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE"" />  
</OEMEXTERNALSTATE>
            <xsl:variable name=""var:v1"" select=""userCSharp:SetOEMWorkflow(string(s1:CATEGORY/text()) , string(s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/text()) , string(s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/@SI) , string(s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/@C))"" />
            <OEMWORKFLOW>
              <xsl:value-of select=""$var:v1"" />
            </OEMWORKFLOW>
          </VALEX_CONTROLINFO>
        </xsl:for-each>
      </RT_VALEX_CONTROLINFO>
      <RT_CONTACT xmlns:ns0=""http://www.asam.net/schemas/issue/issue310-DaiModV1"">
	<xsl:if test=""//ns0:COMPANY-DATA/ns0:SHORT-NAME/. = 'DAIMLER'"">
		<xsl:choose>
			<xsl:when test=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='DAIMLER']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:EMAIL/. = //ns0:COMPANY-DATA/ns0:SHORT-NAME[.='DAIMLER']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[2]/ns0:EMAIL/."">
				<CONTACT>             
					<xsl:attribute name=""ID"">
						<xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='DAIMLER']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/@ID"" />
					</xsl:attribute>
					<DBID>0</DBID>
					<EMAIL>
						<xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='DAIMLER']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:EMAIL/."" />
					</EMAIL>
					<LASTNAME>
						<xsl:value-of select=""normalize-space(substring-before(//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='DAIMLER']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:LONG-NAME/., ','))"" />                   
					</LASTNAME>
					<FIRSTNAME>
						<xsl:value-of select=""normalize-space(substring-after(//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='DAIMLER']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:LONG-NAME/., ','))"" />             
					</FIRSTNAME>
					<PHONENUMBERS>
						<p>Phone:<xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='DAIMLER']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:PHONE/."" /></p>
						<p>Fax:<xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='DAIMLER']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:FAX/."" /></p>                
					</PHONENUMBERS>
					<DEPARTMENT>
						<xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='DAIMLER']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:DEPARTMENT/."" />                
					</DEPARTMENT>
					<ORGANIZATION>                
						<xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='DAIMLER']/."" />
					</ORGANIZATION>
					<ROLE></ROLE>
					<DESCRIPTION>
						<xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='DAIMLER']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/@ID"" />
					</DESCRIPTION>
					<OPERATIONMODE><xsl:text>ASAM-IMPORT</xsl:text></OPERATIONMODE>
					<OPERATIONCONTEXT><xsl:text>BizTalk</xsl:text></OPERATIONCONTEXT>
				</CONTACT>
			</xsl:when>
			<xsl:otherwise>
				<xsl:for-each select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='DAIMLER']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER"">
					<CONTACT>
						<xsl:attribute name=""ID"">
							<xsl:value-of select=""@ID"" />
						</xsl:attribute>
						<DBID>0</DBID>
						<EMAIL>
							<xsl:value-of select=""ns0:EMAIL/."" />
						</EMAIL>
						<LASTNAME>
							<xsl:value-of select=""normalize-space(substring-before(ns0:LONG-NAME/., ','))"" />                
						</LASTNAME>
						<FIRSTNAME>
							<xsl:value-of select=""normalize-space(substring-after(ns0:LONG-NAME/., ','))"" />                 
						</FIRSTNAME>
						<PHONENUMBERS>
							<p>Phone:<xsl:value-of select=""ns0:PHONE/."" /></p>
							<p>Fax:<xsl:value-of select=""ns0:FAX/."" /></p>
						</PHONENUMBERS>
						<DEPARTMENT>
							<xsl:value-of select=""ns0:DEPARTMENT/."" />
						</DEPARTMENT>
						<ORGANIZATION>
							<xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='DAIMLER']/."" />
						</ORGANIZATION>                
						<ROLE></ROLE>
						<DESCRIPTION>
							<xsl:value-of select=""@ID"" />
						</DESCRIPTION>
						<OPERATIONMODE><xsl:text>ASAM-IMPORT</xsl:text></OPERATIONMODE>
						<OPERATIONCONTEXT><xsl:text>BizTalk</xsl:text></OPERATIONCONTEXT>
					</CONTACT>
				</xsl:for-each>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:if>
</RT_CONTACT>
      <RT_ISSUES>
        <xsl:for-each select=""s1:ISSUES/s1:ISSUE"">
          <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;ISS_1&quot;)"" />
          <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
          <xsl:variable name=""var:v4"" select=""string(s1:CATEGORY/text())"" />
          <xsl:variable name=""var:v5"" select=""string(s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/text())"" />
          <xsl:variable name=""var:v6"" select=""string(s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/@SI)"" />
          <xsl:variable name=""var:v7"" select=""string(s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/@C)"" />
          <xsl:variable name=""var:v9"" select=""userCSharp:DateCurrentDateTime()"" />
          <xsl:variable name=""var:v10"" select=""userCSharp:StringConcat(&quot; - ExchangeProtocol: &lt;XPROT&gt;&quot;)"" />
          <ISSUE>
            <xsl:attribute name=""ID"">
              <xsl:value-of select=""$var:v2"" />
            </xsl:attribute>
            <DBID>
              <xsl:value-of select=""$var:v3"" />
            </DBID>
            <RB_ID xmlns:ns0=""http://www.asam.net/schemas/issue/issue310-DaiModV1"">
	<xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY='CHANGE-REQUEST']/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO"">
        <xsl:if test=""ns0:COMPANY-DATA-REF/. ='RB'"">
		<xsl:choose>
			<xsl:when test=""ns0:ISSUE-ID/. = ''"">
				<xsl:text>0</xsl:text>
			</xsl:when>
			<xsl:otherwise>
				<xsl:variable name=""input"" select=""ns0:ISSUE-ID/."" />			
				<xsl:variable name=""IRMPID""><xsl:value-of select=""translate($input,'IRM','')"" /></xsl:variable> 
				<xsl:value-of select=""$IRMPID"" />
			</xsl:otherwise>
		</xsl:choose>			
         </xsl:if>
    </xsl:for-each>
</RB_ID>
            <ID>
              <xsl:value-of select=""$var:v3"" />
            </ID>
            <TITLE>
              <xsl:value-of select=""$var:v3"" />
            </TITLE>
            <DESCRIPTION>
              <P>
                <xsl:value-of select=""$var:v3"" />
              </P>
            </DESCRIPTION>
            <BELONGSTOPROJECT>
              <xsl:value-of select=""$var:v3"" />
            </BELONGSTOPROJECT>
            <TYPE xmlns:ns0=""http://www.asam.net/schemas/issue/issue310-DaiModV1"" ACTION=""INIT"">
  <xsl:text>Issue SW</xsl:text>	
</TYPE>
            <DOMAIN xmlns:ns0=""http://www.asam.net/schemas/issue/issue310-DaiModV1"" ACTION=""INIT"">
  <xsl:text>Software</xsl:text>      
</DOMAIN>
            <SCOPE xmlns:ns0=""http://www.asam.net/schemas/issue/issue310-DaiModV1"" ACTION=""INIT"">
  <xsl:text>External</xsl:text>      
</SCOPE>
            <EXTERNAL_ID xmlns:ns0=""http://www.asam.net/schemas/issue/issue310-DaiModV1"">

  <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY='CHANGE-REQUEST']/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF='DAIMLER']/ns0:ISSUE-ID/."" />

</EXTERNAL_ID>
            <EXTERNALTITLE ACTION=""IGNORE"" xmlns:ns0=""http://www.asam.net/schemas/issue/issue310-DaiModV1"">

  <xsl:value-of select=""/ns0:MSR-ISSUE/ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY='CHANGE-REQUEST']/ns0:SHORT-NAME"" />

</EXTERNALTITLE>
            <EXTERNALSTATE_PARALLEL1>
              <xsl:value-of select=""$var:v3"" />
            </EXTERNALSTATE_PARALLEL1>
            <EXTERNALSTATE_PARALLEL2>
              <xsl:value-of select=""$var:v3"" />
            </EXTERNALSTATE_PARALLEL2>
            <EXTERNALCOMMENT>
              <xsl:value-of select=""$var:v3"" />
            </EXTERNALCOMMENT>
            <EXTERNALORGANISATION>
              <xsl:value-of select=""$var:v3"" />
            </EXTERNALORGANISATION>
            <EXTERNALREVIEW>
              <xsl:value-of select=""$var:v3"" />
            </EXTERNALREVIEW>
            <EXTERNALTAGS>
              <EXTERNALTAG>
                <P>
                  <xsl:value-of select=""$var:v3"" />
                </P>
              </EXTERNALTAG>
            </EXTERNALTAGS>
            <EXTERNALMILESTONES>
              <P>
                <xsl:value-of select=""$var:v3"" />
              </P>
            </EXTERNALMILESTONES>
            <xsl:variable name=""var:v8"" select=""userCSharp:SetOEMWorkflow($var:v4 , $var:v5 , $var:v6 , $var:v7)"" />
            <EXTERNALEXCHANGEWORKFLOW>
              <xsl:value-of select=""$var:v8"" />
            </EXTERNALEXCHANGEWORKFLOW>
            <EXTERNALLASTEXPORTEDDATE>
              <xsl:value-of select=""$var:v3"" />
            </EXTERNALLASTEXPORTEDDATE>
            <xsl:call-template name=""SetExternalHistory"">
              <xsl:with-param name=""param1"" select=""string($var:v9)"" />
              <xsl:with-param name=""param2"" select=""string($var:v10)"" />
            </xsl:call-template>
            <PVER-EXTERNALTITLE xmlns:ns0=""http://www.asam.net/schemas/issue/issue310-DaiModV1"" ACTION=""IGNORE"">
  <xsl:variable name=""unique-list"" select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='DAIMLER' and ns0:CATEGORY='RELEASE' and not(ns0:SHORT-LABEL = preceding-sibling::ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='DAIMLER' and ns0:CATEGORY='RELEASE']/ns0:SHORT-LABEL)]/ns0:SHORT-LABEL"" />
  <xsl:for-each select=""$unique-list"">
    <xsl:value-of select=""//ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL"" />
  </xsl:for-each>
</PVER-EXTERNALTITLE>
          </ISSUE>
        </xsl:for-each>
      </RT_ISSUES>
      <RT_RELEASES xmlns:ns0=""http://www.asam.net/schemas/issue/issue310-DaiModV1"">

  <xsl:variable name=""unique-list"" select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='DAIMLER' and ns0:CATEGORY='RELEASE']/ns0:SHORT-LABEL"" />
  <xsl:for-each select=""$unique-list"">
    <RELEASE>
      <xsl:attribute name=""ID"">
        <xsl:text>REL_</xsl:text>
        <xsl:value-of select=""position()"" />
      </xsl:attribute>
      <DBID>0</DBID>
      <ID ACTION=""IGNORE"">
        <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='RB' and ns0:CATEGORY='RELEASE']/ns0:SHORT-LABEL/@SI"" />
      </ID>
      <DOMAIN ACTION=""INIT"">
        <xsl:text>Software</xsl:text>
      </DOMAIN>
      <TYPE ACTION=""INIT"">
        <xsl:text>PVER</xsl:text>
      </TYPE>
      <SCOPE ACTION=""INIT"">
        <xsl:text>External</xsl:text>
      </SCOPE>
      <EXTERNAL_ID ACTION=""IGNORE"">
        <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='DAIMLER' and ns0:CATEGORY='RELEASE']/ns0:SHORT-LABEL/@SI"" />
      </EXTERNAL_ID>
      <PLANNEDDATE />
      <EXTERNALTITLE ACTION=""IGNORE"">
        <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='DAIMLER' and ns0:CATEGORY='RELEASE']/ns0:SHORT-LABEL"" />
      </EXTERNALTITLE>
      <TITLE ACTION=""IGNORE"">
        <xsl:value-of select=""concat('PVER : ',//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='RB'and ns0:CATEGORY='RELEASE']/ns0:SHORT-LABEL)"" />
      </TITLE>
      <BELONGSTOPROJECT>
      </BELONGSTOPROJECT>
    </RELEASE>
  </xsl:for-each>

</RT_RELEASES>
      <xsl:for-each select=""s1:ISSUES/s1:ISSUE"">
        <xsl:variable name=""var:v11"" select=""userCSharp:DateCurrentDateTime()"" />
        <xsl:variable name=""var:v12"" select=""string(s1:CATEGORY/text())"" />
        <xsl:variable name=""var:v13"" select=""string(s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/text())"" />
        <xsl:variable name=""var:v14"" select=""string(s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/@SI)"" />
        <xsl:variable name=""var:v15"" select=""string(s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/@C)"" />
        <xsl:variable name=""var:v16"" select=""userCSharp:SetOEMWorkflow($var:v12 , $var:v13 , $var:v14 , $var:v15)"" />
        <xsl:call-template name=""SetIRMAPS"">
          <xsl:with-param name=""DateTime"" select=""string($var:v11)"" />
          <xsl:with-param name=""param1"" select=""string($var:v16)"" />
        </xsl:call-template>
      </xsl:for-each>
    </ns0:ASAMISSUE_EXTRACT>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}


public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
}


public string SetOEMWorkflow(string param1,string param2,string param3,string param4)
{
   string strReturn = "" "";	
   if(param1.ToUpper() == ""CHANGE-REQUEST"")
   {
      if(param2.ToUpper() == ""ACCEPTED"")
      {
		if(param4.ToUpper() == ""DELIVERER-INIT"")
		{
			strReturn = ""DAI_ASAM31M_SWRB"";
		}
		else
		{
		strReturn = ""DAI_ASAM31M_SWRQ"";
		}
      }
       else
       {
        strReturn = ""DAI_ASAM31M_SWRQ"";       
       }
        
    }
   
   
  return strReturn;
}


]]></msxsl:script>
  <xsl:template name=""SetIRMAPS"">
  <xsl:param name=""DateTime"" />
  <xsl:param name=""param1"" />



  <RT_IRMAPS xmlns:ns0=""http://www.asam.net/schemas/issue/issue310-DaiModV1"">
    <xsl:variable name=""unique-list"" select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='DAIMLER']/ns0:SHORT-LABEL"" />
    <xsl:for-each select=""$unique-list"">
      <xsl:variable name=""idx"" select=""position()"" />
      <IRMAP>
        <DBID>
          <xsl:variable name=""DBIDtemp"" select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY='CHANGE-REQUEST']/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF='RB']/ns0:ISSUE-ID/."" />
          <xsl:value-of select=""substring-after($DBIDtemp,'IRM')"" />
        </DBID>
        <SCOPE ACTION=""INIT"">
          <xsl:text>External</xsl:text>
        </SCOPE>
        <HASMAPPEDISSUE ID-REF=""ISS_1""></HASMAPPEDISSUE>
        <HASMAPPEDRELEASE>
          <xsl:attribute name=""ID-REF"">
            <xsl:text>REL_</xsl:text>
            <xsl:value-of select=""position()"" />
          </xsl:attribute>
        </HASMAPPEDRELEASE>

        <EXTERNALTAGS ACTION=""APPEND"">
          <EXTERNALTAG>
            <P>
              &lt;IMPORT STATE=""ACCEPTED"" TIME=""<xsl:value-of select=""translate($DateTime,'-T','. ')"" />""/&gt;
            </P>
          </EXTERNALTAG>
        </EXTERNALTAGS>
        <EXTERNALEXCHANGEWORKFLOW>
          <xsl:value-of select=""$param1"" />
        </EXTERNALEXCHANGEWORKFLOW>

        <EXTERNALSTATE_PARALLEL1>
          <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE[@SI='ESTIMATED']"" />
        </EXTERNALSTATE_PARALLEL1>

        <EXTERNALCONVERSATION ACTION=""APPEND"">
          <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY='CHANGE-REQUEST']/ns0:ISSUE-ANNOTATIONS/ns0:ISSUE-ANNOTATION"">
            <P>
              <xsl:text>### </xsl:text>
              <xsl:value-of select=""ns0:DATE/."" />
              <xsl:text># </xsl:text>
              <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE[@SI='ESTIMATED']/."" />
              <xsl:text># </xsl:text>
              <xsl:value-of select=""ns0:TEAM-MEMBER-REF/@ID-REF"" />
              <xsl:text> ###</xsl:text>
            </P>
            <xsl:for-each select=""ns0:ANNOTATION-TEXT/ns0:P"">
              <P>
                <xsl:value-of select=""normalize-space(.)"" />
              </P>
            </xsl:for-each>
          </xsl:for-each>
        </EXTERNALCONVERSATION>

        <EXTERNALLASTIMPORTEDDATE>
          <xsl:value-of select=""$DateTime"" />
        </EXTERNALLASTIMPORTEDDATE>

      </IRMAP>
    </xsl:for-each>
  </RT_IRMAPS>

</xsl:template>
  <xsl:template name=""SetExternalHistory"">
  <xsl:param name=""param1"" />
  <xsl:param name=""param2"" />
  <EXTERNALHISTORY ACTION=""APPEND"" xmlns:ns0=""http://www.asam.net/schemas/issue/issue310-DaiModV1"">
    <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE[@SI='ESTIMATED']/."" />
    <xsl:text> - </xsl:text>
    <xsl:value-of select=""$param1"" />
    <xsl:value-of select=""$param2"" />
    <xsl:text> - </xsl:text>
    <xsl:choose>
      <xsl:when test=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY='CHANGE-REQUEST']/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO/ns0:COMPANY-DATA-REF/. = 'DAIMLER'"">
        <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY='CHANGE-REQUEST']/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO/ns0:ISSUE-ID/."" />
      </xsl:when>
      <xsl:otherwise>
      </xsl:otherwise>
    </xsl:choose>
  </EXTERNALHISTORY>
</xsl:template>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"RB.ROCustomerInterface.Schema.DAIMLER.issue_v3_1_0_DaiModV1_sl";
        
        private const global::RB.ROCustomerInterface.Schema.DAIMLER.issue_v3_1_0_DaiModV1_sl _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"RB.ROCustomerInterface.Schema.DAIMLER.issue_v3_1_0_DaiModV1_sl";
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
