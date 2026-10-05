namespace RB.ROCustomerInterface {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.BMW.issue_v3_2_0_sl", typeof(global::RB.ROCustomerInterface.Schema.BMW.issue_v3_2_0_sl))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM", typeof(global::RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM))]
    public sealed class RB_RO_DAIMLER320_ISSUE_IMF_INFOUPDATE : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1 userCSharp"" version=""1.0"" xmlns:s0=""http://www.w3.org/XML/1998/namespace"" xmlns:ns0=""http://RB.ROCustomerInterface.RB"" xmlns:s1=""http://www.asam.net/schemas/issue/issue320"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" indent=""yes"" version=""1.0"" method=""xml"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:MSR-ISSUE"" />
  </xsl:template>
  <xsl:template match=""/s1:MSR-ISSUE"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;IGNORE&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;ISS_1&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(&quot; - ExchangeProtocol: &lt;XPROT&gt;&quot;)"" />
    <ns0:ASAMISSUE_EXTRACT>
      <RT_VALEX_CONTROLINFO>
        <VALEX_CONTROLINFO>
          <xsl:attribute name=""ACTION"">
            <xsl:value-of select=""$var:v1"" />
          </xsl:attribute>
          <OEMEXTERNALSTATE xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">   
        <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE"" />  
</OEMEXTERNALSTATE>
          <OEMWORKFLOW xmlns:ns0=""http://www.asam.net/schemas/issue/issue320""> 
  <xsl:choose>
       <xsl:when test=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='CHANGE-REQUEST']]/ns0:ISSUE-PROPERTIES/ns0:ISSUE-INITIATOR/ns0:COMPANY-DATA-REF[@ID-REF='RB']"">        
  <xsl:text>DAI_ASAM320_SWSP</xsl:text>
        </xsl:when>
       <xsl:otherwise>
          <xsl:text>DAI_ASAM320_SWRQ</xsl:text>
        </xsl:otherwise>
     </xsl:choose>
</OEMWORKFLOW>
        </VALEX_CONTROLINFO>
      </RT_VALEX_CONTROLINFO>
      <RT_CONTACT xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
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
        <ISSUE>
          <xsl:attribute name=""ID"">
            <xsl:value-of select=""$var:v2"" />
          </xsl:attribute>
          <DBID>
            <xsl:value-of select=""$var:v3"" />
          </DBID>
          <RB_ID xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
  <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO"">
    <xsl:if test=""ns0:COMPANY-DATA-REF/. ='RB'"">
      <xsl:choose>
        <xsl:when test=""ns0:ISSUE-ID/. = '' or normalize-space(ns0:ISSUE-ID) = ''"">
          <xsl:text>0</xsl:text>
        </xsl:when>
        <xsl:otherwise>
          <xsl:variable name=""input"" select=""ns0:ISSUE-ID/."" />
          <xsl:variable name=""IRMPID"">
            <xsl:value-of select=""translate($input,'IRM','')"" />
          </xsl:variable>
          <xsl:value-of select=""$IRMPID"" />
        </xsl:otherwise>
      </xsl:choose>
    </xsl:if>
  </xsl:for-each>
</RB_ID>
          <ID>
            <xsl:value-of select=""$var:v3"" />
          </ID>
          <BELONGSTOPROJECT>
            <xsl:value-of select=""$var:v3"" />
          </BELONGSTOPROJECT>
          <TYPE ACTION=""INIT"">
  <xsl:text>Issue SW</xsl:text>	
</TYPE>
          <DOMAIN ACTION=""INIT"">
  <xsl:text>Software</xsl:text>      
</DOMAIN>
          <SCOPE ACTION=""INIT"">
  <xsl:text>External</xsl:text>      
</SCOPE>
          <EXTERNAL_ID xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">

  <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF='DAIMLER']/ns0:ISSUE-ID/."" />

</EXTERNAL_ID>
          <EXTERNALTITLE ACTION=""IGNORE"" xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">

  <xsl:value-of select=""/ns0:MSR-ISSUE/ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:SHORT-NAME"" />

</EXTERNALTITLE>
          <EXTERNALSUBMITTER xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
<xsl:attribute name=""ID-REF"">
          <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='CHANGE-REQUEST']]/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF='DAIMLER']/ns0:TEAM-MEMBER-REF/@ID-REF"" />
        </xsl:attribute>
</EXTERNALSUBMITTER>
          <EXTERNALASSIGNEE xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
<xsl:attribute name=""ID-REF"">   
        <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='CHANGE-REQUEST']]/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:TEAM-MEMBER-REF/@ID-REF"" />     
  </xsl:attribute> 
</EXTERNALASSIGNEE>
          <PVER-EXTERNALTITLE xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"" ACTION=""IGNORE"">
  <xsl:variable name=""unique-list"" select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='DAIMLER' and ns0:CATEGORY='RELEASE' and not(ns0:SHORT-LABEL = preceding-sibling::ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='DAIMLER' and ns0:CATEGORY='RELEASE']/ns0:SHORT-LABEL)]/ns0:SHORT-LABEL"" />
  <xsl:for-each select=""$unique-list"">
    <xsl:value-of select=""."" />
  </xsl:for-each>
</PVER-EXTERNALTITLE>
          <OPERATIONMODE>
<xsl:text>ASAM-IMPORT</xsl:text>
</OPERATIONMODE>
          <OPERATIONCONTEXT>
<xsl:text>BizTalk</xsl:text>
</OPERATIONCONTEXT>
        </ISSUE>
      </RT_ISSUES>
      <RT_RELEASES xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">

  <xsl:variable name=""unique-list"" select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='DAIMLER' and ns0:CATEGORY='RELEASE']/ns0:SHORT-LABEL"" />
  <xsl:for-each select=""$unique-list"">
    <RELEASE>
      <xsl:attribute name=""ID"">
        <xsl:text>REL_</xsl:text>
        <xsl:value-of select=""position()"" />
      </xsl:attribute>
      <DBID>0</DBID>
      <ID ACTION=""IGNORE"">
        <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='RB' and ns0:CATEGORY='RELEASE']/ns0:SHORT-LABEL/@SI"" />
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
        <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='DAIMLER' and ns0:CATEGORY='RELEASE']/ns0:SHORT-LABEL/@SI"" />
      </EXTERNAL_ID>
      <PLANNEDDATE />
      <EXTERNALTITLE ACTION=""IGNORE"">
        <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='DAIMLER' and ns0:CATEGORY='RELEASE']/ns0:SHORT-LABEL"" />
      </EXTERNALTITLE>
      <TITLE ACTION=""IGNORE"">
        <xsl:value-of select=""concat('PVER : ',//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='RB'and ns0:CATEGORY='RELEASE']/ns0:SHORT-LABEL)"" />
      </TITLE>
      <BELONGSTOPROJECT>
      </BELONGSTOPROJECT>
      <OPERATIONMODE>
        <xsl:text>ASAM-IMPORT</xsl:text>
      </OPERATIONMODE>
      <OPERATIONCONTEXT>
        <xsl:text>BizTalk</xsl:text>
      </OPERATIONCONTEXT>
    </RELEASE>
  </xsl:for-each>

</RT_RELEASES>
      <xsl:variable name=""var:v4"" select=""userCSharp:GetDateInFormat()"" />
      <xsl:variable name=""var:v6"" select=""userCSharp:GetDateInFormat()"" />
      <xsl:call-template name=""SetIRMAPS"">
        <xsl:with-param name=""DateTime"" select=""string($var:v4)"" />
        <xsl:with-param name=""Xprot"" select=""string($var:v5)"" />
        <xsl:with-param name=""DateTime2"" select=""string($var:v6)"" />
      </xsl:call-template>
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


public string GetDateInFormat()
{
       // strDate = System.DateTime.Parse(DateTime.Today.ToString()).ToString(""yyyyMMdd"");
          System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo(""de-DE"");
           string strFormatedDateTime = System.DateTime.Parse(DateTime.Now.ToString()).ToString(""dd.MM.yyyy HH:mm:ss"", culture);
           return strFormatedDateTime;
}



]]></msxsl:script>
  <xsl:template name=""SetIRMAPS"">
  <xsl:param name=""DateTime"" />
  <xsl:param name=""Xprot"" />
  <xsl:param name=""DateTime2"" />
  <RT_IRMAPS xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
    <xsl:variable name=""unique-list"" select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='DAIMLER']/ns0:SHORT-LABEL"" />
    <xsl:variable name=""versionnumber"">
      <xsl:choose>
        <xsl:when test=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE = 'INFORMATIONAL-UPDATE'"">
          <xsl:text>DAI</xsl:text>
          <xsl:choose>
            <xsl:when test=""number(//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@EXPORT-COUNTER-OEM) &lt; 10"">
              <xsl:value-of select=""concat('0', //ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@EXPORT-COUNTER-OEM)"" />
            </xsl:when>
            <xsl:otherwise>
              <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@EXPORT-COUNTER-OEM"" />
            </xsl:otherwise>
          </xsl:choose>
          <xsl:text>#RB</xsl:text>
          <xsl:choose>
            <xsl:when test=""number(//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@EXPORT-COUNTER-SUPPLIER) &lt; 10"">
              <xsl:value-of select=""concat('0', //ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@EXPORT-COUNTER-SUPPLIER)"" />
            </xsl:when>
            <xsl:otherwise>
              <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@EXPORT-COUNTER-SUPPLIER"" />
            </xsl:otherwise>
          </xsl:choose>
        </xsl:when>
        <xsl:otherwise>
          <xsl:text>DAI00#RB00</xsl:text>
        </xsl:otherwise>
      </xsl:choose>
    </xsl:variable>
    <xsl:for-each select=""$unique-list"">
	<xsl:variable name=""ExportCounterOEM"">
	<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@EXPORT-COUNTER-OEM"" />
	</xsl:variable>
	<xsl:variable name=""ExportCounterSupplier"">
	<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@EXPORT-COUNTER-SUPPLIER"" />
	</xsl:variable>
	<xsl:variable name=""OriginTxt"">
	<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@ORIGIN"" />
	</xsl:variable>
	<xsl:variable name=""WorkFlowId"">
	<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='CHANGE-REQUEST']]/ns0:ISSUE-PROPERTIES/ns0:ISSUE-INITIATOR/ns0:COMPANY-DATA-REF/@ID-REF"" />
	</xsl:variable>
	<xsl:variable name=""annotationText"">
	<xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-ANNOTATIONS/ns0:ISSUE-ANNOTATION"">
            
			<xsl:for-each select=""ns0:ANNOTATION-TEXT/ns0:P"">
              <P>
                <xsl:value-of select=""normalize-space(.)"" />
              </P>
            </xsl:for-each>
			
          </xsl:for-each>
	</xsl:variable>
      <xsl:variable name=""idx"" select=""position()"" />
      <IRMAP>
        <DBID>
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
              &lt;IMPORT STATE=""INFORMATIONAL-UPDATE"" TIME=""<xsl:value-of select=""translate($DateTime,'-T','. ')"" />""/&gt;
            </P>
          </EXTERNALTAG>
        </EXTERNALTAGS>
        <EXPORT_COUNTER_OEM>
          <xsl:if test=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE = 'INFORMATIONAL-UPDATE'"">
            <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@EXPORT-COUNTER-OEM"" />
          </xsl:if>
        </EXPORT_COUNTER_OEM>
        <EXTERNALUPDATEVERSION>
          <xsl:value-of select=""$versionnumber"" />
        </EXTERNALUPDATEVERSION>
        <EXTERNALCONVERSATION ACTION=""APPEND"">
          <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-ANNOTATIONS/ns0:ISSUE-ANNOTATION[@SI='INFORMATIONAL-UPDATE']"">
            <P>
              <xsl:text>### </xsl:text>
              <xsl:value-of select=""$DateTime"" />
              <xsl:text> # </xsl:text>
              <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE"" />
              <xsl:text> # </xsl:text>
              <xsl:value-of select=""translate($versionnumber,'#','-')"" />
              <xsl:text> # </xsl:text>
              <xsl:value-of select=""ns0:TEAM-MEMBER-REF/@ID-REF"" />
              <xsl:text> ### </xsl:text>
            </P>
            <xsl:for-each select=""ns0:ANNOTATION-TEXT/ns0:P"">
              <P>
                <xsl:value-of select=""normalize-space(.)"" />
              </P>
            </xsl:for-each>
          </xsl:for-each>
        </EXTERNALCONVERSATION>
        <EXTERNALLASTIMPORTEDDATE>
          <xsl:value-of select=""$DateTime2"" />
        </EXTERNALLASTIMPORTEDDATE>
        <WORKFLOWSTATUS>Waiting</WORKFLOWSTATUS>
        <EXTERNALNEXTSTATE ACTION=""DELETE"">
          <xsl:text></xsl:text>
        </EXTERNALNEXTSTATE>
        <OPERATIONMODE>
          <xsl:text>ASAM-IMPORT</xsl:text>
        </OPERATIONMODE>
        <OPERATIONCONTEXT>
          <xsl:text>BizTalk</xsl:text>
        </OPERATIONCONTEXT>
		
		<EXTERNALHISTORY ACTION=""APPEND"">
			<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" />
            <xsl:text> - </xsl:text>
            <xsl:value-of select=""$DateTime"" />
            <xsl:value-of select=""$Xprot"" />
            <xsl:text> - </xsl:text>
            <xsl:choose>
            <xsl:when test=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO/ns0:COMPANY-DATA-REF/. = 'DAIMLER'"">
            <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO/ns0:ISSUE-ID/."" />
            </xsl:when>
            <xsl:otherwise>
            </xsl:otherwise>
            </xsl:choose>
        </EXTERNALHISTORY>
		<EXTERNALSTATE_PARALLEL1>
		<xsl:choose>
			<xsl:when test=""$annotationText = 'Neuer ÄA für einen von RB initiierten Zulieferer-Datensatz' and $ExportCounterSupplier = '0' and $ExportCounterOEM = '1' and $OriginTxt ='PROPOSED' and $WorkFlowId ='RB'"">
				<xsl:text>PROPOSED</xsl:text>
			</xsl:when>
			
		</xsl:choose>
</EXTERNALSTATE_PARALLEL1>
      </IRMAP>
    </xsl:for-each>
  </RT_IRMAPS>

</xsl:template>
  <xsl:template name=""SetExternalHistory"">
  <xsl:param name=""param1"" />
  <xsl:param name=""param2"" />
  <EXTERNALHISTORY ACTION=""APPEND"" xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
    <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" />
    <xsl:text> - </xsl:text>
    <xsl:value-of select=""$param1"" />
    <xsl:value-of select=""$param2"" />
    <xsl:text> - </xsl:text>
    <xsl:choose>
      <xsl:when test=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO/ns0:COMPANY-DATA-REF/. = 'DAIMLER'"">
        <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO/ns0:ISSUE-ID/."" />
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
        
        private const string _strSrcSchemasList0 = @"RB.ROCustomerInterface.Schema.BMW.issue_v3_2_0_sl";
        
        private const global::RB.ROCustomerInterface.Schema.BMW.issue_v3_2_0_sl _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"RB.ROCustomerInterface.Schema.BMW.issue_v3_2_0_sl";
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
