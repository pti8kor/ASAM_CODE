namespace RB.ROCustomerInterface {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.BMW.issue_v3_2_0_sl", typeof(global::RB.ROCustomerInterface.Schema.BMW.issue_v3_2_0_sl))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM", typeof(global::RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM))]
    public sealed class RB_RO_BMW320_ISSUE_IMF_PROSPR_CLOSED : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1 userCSharp"" version=""1.0"" xmlns:s0=""http://www.w3.org/XML/1998/namespace"" xmlns:ns0=""http://RB.ROCustomerInterface.RB"" xmlns:s1=""http://www.asam.net/schemas/issue/issue320"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" indent=""yes"" version=""1.0"" method=""xml"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:MSR-ISSUE"" />
  </xsl:template>
  <xsl:template match=""/s1:MSR-ISSUE"">
    <ns0:ASAMISSUE_EXTRACT>
      <RT_VALEX_CONTROLINFO>
        <xsl:for-each select=""s1:ISSUES/s1:ISSUE"">
          <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;IGNORE&quot;)"" />
          <xsl:variable name=""var:v3"" select=""string(s1:CATEGORY/text())"" />
          <VALEX_CONTROLINFO>
            <xsl:attribute name=""ACTION"">
              <xsl:value-of select=""$var:v1"" />
            </xsl:attribute>
            <xsl:variable name=""var:v2"" select=""userCSharp:SetOEMState(string(s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/text()) , string(s1:CATEGORY/text()))"" />
            <OEMEXTERNALSTATE>
              <xsl:value-of select=""$var:v2"" />
            </OEMEXTERNALSTATE>
            <xsl:variable name=""var:v4"" select=""userCSharp:Concat($var:v3 , string(../../s1:CATEGORY/text()) , string(s1:ISSUE-PROPERTIES/s1:ISSUE-INITIATOR/s1:COMPANY-DATA-REF/text()))"" />
            <OEMWORKFLOW>
              <xsl:value-of select=""$var:v4"" />
            </OEMWORKFLOW>
          </VALEX_CONTROLINFO>
        </xsl:for-each>
      </RT_VALEX_CONTROLINFO>
      <RT_CONTACT xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
	<xsl:if test=""//ns0:COMPANY-DATA/ns0:SHORT-NAME/. = 'BMW'"">
		<xsl:choose>
			<xsl:when test=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='BMW']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:EMAIL/. = //ns0:COMPANY-DATA/ns0:SHORT-NAME[.='BMW']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[2]/ns0:EMAIL/."">
				<CONTACT>             
					<xsl:attribute name=""ID"">
						<xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='BMW']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/@ID"" />
					</xsl:attribute>
					<DBID>0</DBID>
					<EMAIL>
						<xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='BMW']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:EMAIL/."" />
					</EMAIL>
					<LASTNAME>
						<xsl:value-of select=""normalize-space(substring-before(//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='BMW']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:LONG-NAME/., ','))"" />                   
					</LASTNAME>
					<FIRSTNAME>
						<xsl:value-of select=""normalize-space(substring-after(//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='BMW']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:LONG-NAME/., ','))"" />             
					</FIRSTNAME>
					<PHONENUMBERS>
						<p>Phone:<xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='BMW']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:PHONE/."" /></p>
						<p>Fax:<xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='BMW']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:FAX/."" /></p>                
					</PHONENUMBERS>
					<DEPARTMENT>
						<xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='BMW']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:DEPARTMENT/."" />                
					</DEPARTMENT>
					<ORGANIZATION>                
						<xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='BMW']/."" />
					</ORGANIZATION>
					<ROLE></ROLE>
					<DESCRIPTION>
						<xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='BMW']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/@ID"" />
					</DESCRIPTION>
					<OPERATIONMODE><xsl:text>ASAM-IMPORT</xsl:text></OPERATIONMODE>
					<OPERATIONCONTEXT><xsl:text>BizTalk</xsl:text></OPERATIONCONTEXT>
				</CONTACT>
			</xsl:when>
			<xsl:otherwise>
				<xsl:for-each select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='BMW']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER"">
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
							<xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='BMW']/."" />
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
          <xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(&quot;ISS_1&quot;)"" />
          <xsl:variable name=""var:v6"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
          <xsl:variable name=""var:v8"" select=""string(s1:CATEGORY/text())"" />
          <xsl:variable name=""var:v9"" select=""string(../../s1:CATEGORY/text())"" />
          <xsl:variable name=""var:v10"" select=""string(s1:ISSUE-PROPERTIES/s1:ISSUE-INITIATOR/s1:COMPANY-DATA-REF/text())"" />
          <xsl:variable name=""var:v15"" select=""userCSharp:StringConcat(&quot;New Requirement&quot;)"" />
          <xsl:variable name=""var:v16"" select=""userCSharp:StringConcat(&quot;No&quot;)"" />
          <xsl:variable name=""var:v18"" select=""userCSharp:StringConcat(&quot; - ExchangeProtocol: &lt;XPROT&gt;&quot;)"" />
          <ISSUE>
            <xsl:attribute name=""ID"">
              <xsl:value-of select=""$var:v5"" />
            </xsl:attribute>
            <DBID>
              <xsl:value-of select=""$var:v6"" />
            </DBID>
            <RB_ID>
              <xsl:value-of select=""$var:v6"" />
            </RB_ID>
            <ID>
              <xsl:value-of select=""$var:v6"" />
            </ID>
            <TITLE>
              <xsl:value-of select=""$var:v6"" />
            </TITLE>
            <DESCRIPTION>
              <xsl:value-of select=""$var:v6"" />
            </DESCRIPTION>
            <BELONGSTOPROJECT>
              <xsl:value-of select=""$var:v6"" />
            </BELONGSTOPROJECT>
            <TYPE xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"" ACTION=""INIT"">
  <xsl:text>Issue SW</xsl:text>	
</TYPE>
            <DOMAIN xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"" ACTION=""INIT"">
  <xsl:text>Software</xsl:text>      
</DOMAIN>
            <SCOPE xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"" ACTION=""INIT"">
  <xsl:text>External</xsl:text>      
</SCOPE>
            <ISSUE_CATEGORY_FROM_CUSTOMER>
              <xsl:value-of select=""s1:CATEGORY/text()"" />
            </ISSUE_CATEGORY_FROM_CUSTOMER>
            <EXTERNAL_ID xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
	<xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:RELATED-ISSUES/ns0:RELATED-ISSUE"">
		<xsl:if test=""ns0:COMPANY-DATA-REF/. = 'BMW'"">
			<xsl:if test=""ns0:ISSUE-RELATION/. = 'PARENT'"">
				<xsl:value-of select=""ns0:ISSUE-REF/."" />
			</xsl:if>
		</xsl:if>
	</xsl:for-each>
</EXTERNAL_ID>
            <EXTERNALTITLE xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
   <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:LONG-NAME/."" />
</EXTERNALTITLE>
            <EXTERNALSTATE_PARALLEL1>
              <xsl:value-of select=""$var:v6"" />
            </EXTERNALSTATE_PARALLEL1>
            <EXTERNALSTATE_PARALLEL2>
              <xsl:value-of select=""$var:v6"" />
            </EXTERNALSTATE_PARALLEL2>
            <EXTERNALNEXTSTATE>
              <xsl:value-of select=""$var:v6"" />
            </EXTERNALNEXTSTATE>
            <EXTERNALCOMMENT>
              <xsl:value-of select=""$var:v6"" />
            </EXTERNALCOMMENT>
            <EXTERNALSUBMITTER>
              <xsl:if test=""s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:TEAM-MEMBER-REF/@ID-REF"">
                <xsl:attribute name=""ID-REF"">
                  <xsl:value-of select=""s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:TEAM-MEMBER-REF/@ID-REF"" />
                </xsl:attribute>
              </xsl:if>
            </EXTERNALSUBMITTER>
            <EXTERNALASSIGNEE xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
  <xsl:attribute name=""ID-REF"">    
  <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO"">
      <xsl:if test=""ns0:COMPANY-DATA-REF/.= 'BMW'"">
        <xsl:value-of select=""ns0:TEAM-MEMBER-REF/@ID-REF"" />
      </xsl:if>
    

  </xsl:for-each>
  </xsl:attribute>
</EXTERNALASSIGNEE>
            <EXTERNALORGANISATION>
              <xsl:value-of select=""../../s1:COMPANY-DATAS/s1:COMPANY-DATA/s1:SHORT-NAME/text()"" />
            </EXTERNALORGANISATION>
            <EXTERNALREVIEW>
              <xsl:value-of select=""$var:v6"" />
            </EXTERNALREVIEW>
            <xsl:for-each select=""../../s1:ADMIN-DATA/s1:DOC-REVISIONS/s1:DOC-REVISION"">
              <xsl:call-template name=""SetExtTags"">
                <xsl:with-param name=""AdminDate"" select=""string(s1:DATE/text())"" />
              </xsl:call-template>
            </xsl:for-each>
            <EXTERNALDESCRIPTION xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
	<P>
		<xsl:text>DESCRIPTION:</xsl:text>
	</P>
	<xsl:for-each select=""//ns0:ISSUE-DESC/ns0:P"">
		<P>
			<xsl:value-of select=""."" />
		</P>
	</xsl:for-each>
	<P></P>
	<xsl:for-each select=""//ns0:ISSUE-SOLUTIONS/ns0:ISSUE-SOLUTION"">
		<P>
			<xsl:value-of select=""ns0:CATEGORY/."" />
			<xsl:text>:</xsl:text>
		</P>
		<xsl:choose>
			<xsl:when test=""ns0:ISSUE-SOLUTION-DESC"">
				<xsl:for-each select=""ns0:ISSUE-SOLUTION-DESC/ns0:P"">
					<P>
						<xsl:value-of select=""."" />
					</P>
				</xsl:for-each>
			</xsl:when>
			<xsl:otherwise>
				<P></P>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:for-each>
</EXTERNALDESCRIPTION>
            <EXTERNALMILESTONES>
              <P>
                <xsl:value-of select=""$var:v6"" />
              </P>
            </EXTERNALMILESTONES>
            <xsl:variable name=""var:v7"" select=""userCSharp:GetDateInFormat()"" />
            <xsl:call-template name=""GetExternalConversion"">
              <xsl:with-param name=""param1"" select=""string($var:v7)"" />
            </xsl:call-template>
            <xsl:variable name=""var:v11"" select=""userCSharp:Concat($var:v8 , $var:v9 , $var:v10)"" />
            <EXTERNALEXCHANGEWORKFLOW>
              <xsl:value-of select=""$var:v11"" />
            </EXTERNALEXCHANGEWORKFLOW>
            <EXTERNALLASTEXPORTEDDATE>
              <xsl:value-of select=""$var:v6"" />
            </EXTERNALLASTEXPORTEDDATE>
            <xsl:variable name=""var:v12"" select=""userCSharp:GetDateInFormat()"" />
            <EXTERNALLASTIMPORTEDDATE>
              <xsl:value-of select=""$var:v12"" />
            </EXTERNALLASTIMPORTEDDATE>
            <xsl:variable name=""var:v13"" select=""userCSharp:GetDateInFormat()"" />
            <xsl:call-template name=""GetAttachmentsList"">
              <xsl:with-param name=""param1"" select=""string($var:v13)"" />
            </xsl:call-template>
            <xsl:variable name=""var:v14"" select=""userCSharp:GetDateInFormat()"" />
            <xsl:call-template name=""GetExternalAttachmentData"">
              <xsl:with-param name=""param1"" select=""string($var:v14)"" />
            </xsl:call-template>
            <COMMERCIALCLASSIFICATION>
              <xsl:value-of select=""$var:v15"" />
            </COMMERCIALCLASSIFICATION>
            <COMMERCIALAMOUNT>
              <xsl:value-of select=""$var:v6"" />
            </COMMERCIALAMOUNT>
            <COMMERCIALAMOUNTCONFIRMED>
              <xsl:value-of select=""$var:v6"" />
            </COMMERCIALAMOUNTCONFIRMED>
            <COMMERCIALCOMMENT>
              <P>
                <xsl:value-of select=""$var:v6"" />
              </P>
            </COMMERCIALCOMMENT>
            <COMMERCIALCONVERSATION>
              <P>
                <xsl:value-of select=""$var:v6"" />
              </P>
            </COMMERCIALCONVERSATION>
            <COMMERCIALQUOTATIONREQ>
              <xsl:value-of select=""$var:v16"" />
            </COMMERCIALQUOTATIONREQ>
            <OCCURRENCE xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
 <xsl:if test=""//ns0:ISSUES/ns0:ISSUE/ns0:CATEGORY/. = 'PROBLEM-REPORT'"">
  <xsl:variable name=""smallcase"" select=""'abcdefghijklmnopqrstuvwxyz'"" />
  <xsl:variable name=""uppercase"" select=""'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"" />
  <xsl:variable name=""ShortLabel"">
    <xsl:value-of select=""/ns0:MSR-ISSUE/ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-ENVIRONMENT/ns0:ENGINEERING-OBJECTS/ns0:ENGINEERING-OBJECT[ns0:CATEGORY='FREQUENCY']/ns0:SHORT-LABEL"" />
  </xsl:variable>
 
  <xsl:choose>
    <xsl:when test=""contains($ShortLabel,'03-highly intermitend') or contains($ShortLabel,'03-highly intermittent') or contains($ShortLabel,'04-reproducable')"">
      <xsl:text>Reproducible</xsl:text>
    </xsl:when>
    <xsl:when test=""contains($ShortLabel,'02-sporadic')"">
      <xsl:text>Sporadic</xsl:text>
    </xsl:when>
    <xsl:when test=""contains($ShortLabel,'01-single event')"">
      <xsl:text>Once</xsl:text>
    </xsl:when>
    <xsl:otherwise></xsl:otherwise>
  </xsl:choose>
  </xsl:if>
</OCCURRENCE>
            <SEVERITY xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
 <xsl:if test=""//ns0:ISSUES/ns0:ISSUE/ns0:CATEGORY/. = 'PROBLEM-REPORT'"">
  <xsl:variable name=""ShortLabel"">
    <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-ENVIRONMENT/ns0:ENGINEERING-OBJECTS/ns0:ENGINEERING-OBJECT[ns0:CATEGORY='BI']/ns0:SHORT-LABEL"" />
  </xsl:variable>
 
  <xsl:choose>
    <xsl:when test=""contains($ShortLabel,'01-safety relevant') or contains($ShortLabel,'02-breakdown occurs') or contains($ShortLabel,'03-permanent unsatisfactory') or contains($ShortLabel,'04-deficient')"">
      <xsl:text>High</xsl:text>
    </xsl:when>
    <xsl:when test=""contains($ShortLabel,'05-unsatisfactory')"">
      <xsl:text>Medium</xsl:text>
    </xsl:when>
    <xsl:when test=""contains($ShortLabel,'06-customer irritated') or contains($ShortLabel,'07-customer noticed') or contains($ShortLabel,'08-good') or contains($ShortLabel,'09-excellent') or contains($ShortLabel,'10-outstanding')or contains($ShortLabel,'90-undefined')"">
      <xsl:text>Low</xsl:text>
    </xsl:when>
    <xsl:otherwise></xsl:otherwise>
  </xsl:choose>
  </xsl:if>
</SEVERITY>
            <xsl:variable name=""var:v17"" select=""userCSharp:GetDateInFormat()"" />
            <xsl:call-template name=""SetExternalHistory"">
              <xsl:with-param name=""param1"" select=""string($var:v17)"" />
              <xsl:with-param name=""param2"" select=""string($var:v18)"" />
            </xsl:call-template>
            <LIFECYCLESTATE xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"" ACTION=""IGNORE"">
<xsl:text></xsl:text>      
</LIFECYCLESTATE>
            <OPERATIONMODE xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
<xsl:text>ASAM-IMPORT</xsl:text>
</OPERATIONMODE>
            <OPERATIONCONTEXT xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
<xsl:text>BizTalk</xsl:text>
</OPERATIONCONTEXT>
            <EXTERNALUPDATEVERSION xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
	<xsl:choose>
		<xsl:when test=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE = 'INFORMATIONAL-UPDATE'""> 
			<xsl:text>BMW</xsl:text>
			<xsl:choose>
				<xsl:when test=""number(//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@EXPORT-COUNTER-OEM) &lt; 10"">
					<xsl:value-of select=""concat('0', //ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@EXPORT-COUNTER-OEM)"" />
				</xsl:when>
				<xsl:otherwise>
					<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@EXPORT-COUNTER-OEM"" />
				</xsl:otherwise>
			</xsl:choose>
			<xsl:text>#RB</xsl:text>
			<xsl:choose>
				<xsl:when test=""number(//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@EXPORT-COUNTER-SUPPLIER) &lt; 10"">
					<xsl:value-of select=""concat('0', //ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@EXPORT-COUNTER-SUPPLIER)"" />
				</xsl:when>
				<xsl:otherwise>
					<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@EXPORT-COUNTER-SUPPLIER"" />
				</xsl:otherwise>
			</xsl:choose>					
		</xsl:when>
		<xsl:otherwise>
			<xsl:text>BMW00#RB00</xsl:text>
		</xsl:otherwise>
	</xsl:choose>
</EXTERNALUPDATEVERSION>
            <EXPORT_COUNTER_OEM xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
<xsl:if test=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE = 'INFORMATIONAL-UPDATE'""> 
<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@EXPORT-COUNTER-OEM"" />
</xsl:if>
</EXPORT_COUNTER_OEM>
            <EXPORT_COUNTER_SUPPLIER xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
<xsl:if test=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE = 'INFORMATIONAL-UPDATE'""> 
<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@EXPORT-COUNTER-SUPPLIER"" />
</xsl:if>
</EXPORT_COUNTER_SUPPLIER>
            <OEMORIGINATINGSTATE xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
<xsl:if test=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE = 'INFORMATIONAL-UPDATE'""> 
<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@ORIGIN"" />
</xsl:if>
</OEMORIGINATINGSTATE>
            <TAGS ACTION=""MERGE"">
	<TAGS>
		<xsl:text>&lt;AlgorithmsToReview_ChangeComment&gt;Contents-Required-Despite-AlgorithToReview-Did-Not-Change&lt;/AlgorithmsToReview_ChangeComment&gt;</xsl:text>			   
	</TAGS>
</TAGS>
          </ISSUE>
        </xsl:for-each>
      </RT_ISSUES>
      <RT_PROJECTS xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
  <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE"">
    <PROJECT>
      <xsl:attribute name=""ID"">
	  <xsl:text>PRO_</xsl:text><xsl:value-of select=""position()"" />
	  </xsl:attribute> 
	  <ID>
	  <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF='BOSCH']/ns0:PROJECT-ID/@SI"" />
	  </ID>	  
      <DBID>0</DBID>
      <RBID />
      <DOMAIN ACTION=""INIT"">
        <xsl:text>Software</xsl:text>
      </DOMAIN>
      <TYPE ACTION=""INIT"">
        <xsl:text>CustPrj</xsl:text>      
      </TYPE>
	  <TITLE>
		<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF='BOSCH']/ns0:PROJECT-ID/."" />
	  </TITLE>
      <SCOPE ACTION=""INIT"">
        <xsl:text>External</xsl:text>
      </SCOPE>
      <EXTERNAL_ID>
		<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF='BMW']/ns0:PROJECT-ID/@SI"" />
      </EXTERNAL_ID>
      <EXTERNALTITLE>
		<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF='BMW']/ns0:PROJECT-ID/."" />
      </EXTERNALTITLE>
      <BELONGSTOPOOLPROJECT />
	  <OPERATIONMODE>
		<xsl:text>ASAM-IMPORT</xsl:text>
	  </OPERATIONMODE>
      <OPERATIONCONTEXT>
		<xsl:text>BizTalk</xsl:text>
	  </OPERATIONCONTEXT>
    </PROJECT>
  </xsl:for-each>
</RT_PROJECTS>
      <RT_RELEASES xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
	<xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF = 'BMW']"">
		<RELEASE>
			<xsl:attribute name=""ID"">
				<xsl:text>REL_</xsl:text>
				<xsl:value-of select=""position()"" />
			</xsl:attribute>
			<DBID />
			<RBID />
			<ID />
			<DOMAIN ACTION=""INIT"">
				<xsl:text>Software</xsl:text>
			</DOMAIN>
			<TYPE ACTION=""INIT"">
				<xsl:text>PVER</xsl:text>
			</TYPE>
			<SCOPE ACTION=""INIT"">
				<xsl:text>External</xsl:text>
			</SCOPE>
			<TITLE>
				<xsl:choose>
					<xsl:when test=""(ns0:SHORT-LABEL/@SI='' or normalize-space(ns0:SHORT-LABEL/@SI)='') and (ns0:SHORT-LABEL='' or normalize-space(ns0:SHORT-LABEL)='') and ns0:CATEGORY='RESTRICTED'"">
						<xsl:value-of select=""concat('PVER : ', @C ,'_RESTRICTED')"" />
					</xsl:when>
					<xsl:otherwise>
						<xsl:value-of select=""concat('PVER : ', ns0:SHORT-LABEL)"" />
					</xsl:otherwise>
				</xsl:choose>
			</TITLE>
	<!--		<EXTERNAL_ID>
				<xsl:choose>
					<xsl:when test=""(ns0:SHORT-LABEL/@SI='' or normalize-space(ns0:SHORT-LABEL/@SI)='') and (ns0:SHORT-LABEL='' or normalize-space(ns0:SHORT-LABEL)='') and ns0:CATEGORY='RESTRICTED'"">
						<xsl:value-of select=""concat(@C,'_RESTRICTED')""/>
					</xsl:when>
					<xsl:otherwise>
						<xsl:value-of select=""ns0:SHORT-LABEL/@SI""/>
					</xsl:otherwise>
				</xsl:choose>
			</EXTERNAL_ID> -->
			<EXTERNAL_ID></EXTERNAL_ID>
			<EXTERNALTAGS>
				<xsl:text>&lt;FixVersion&gt;</xsl:text>
					<xsl:choose>
						<xsl:when test=""(ns0:SHORT-LABEL/@SI='' or normalize-space(ns0:SHORT-LABEL/@SI)='') and (ns0:SHORT-LABEL='' or normalize-space(ns0:SHORT-LABEL)='') and ns0:CATEGORY='RESTRICTED'"">
							<xsl:value-of select=""concat(@C,'_RESTRICTED')"" />
						</xsl:when>
						<xsl:otherwise>
							<xsl:value-of select=""ns0:SHORT-LABEL/@SI"" />
						</xsl:otherwise>
					</xsl:choose>
				<xsl:text>&lt;/FixVersion&gt;</xsl:text>
			</EXTERNALTAGS>
			<PLANNEDDATE />
			<EXTERNALTITLE>
				<xsl:choose>
					<xsl:when test=""(ns0:SHORT-LABEL/@SI='' or normalize-space(ns0:SHORT-LABEL/@SI)='') and (ns0:SHORT-LABEL='' or normalize-space(ns0:SHORT-LABEL)='') and ns0:CATEGORY='RESTRICTED'"">
						<xsl:value-of select=""concat(@C,'_RESTRICTED')"" />
					</xsl:when>
					<xsl:otherwise>
						<xsl:value-of select=""ns0:SHORT-LABEL"" />
					</xsl:otherwise>
				</xsl:choose>
			</EXTERNALTITLE>
			<BELONGSTOPROJECT>
				<xsl:attribute name=""ID-REF"">
					<xsl:value-of select=""concat('PRO_', position())"" />
				</xsl:attribute>
			</BELONGSTOPROJECT>
			<!--<CATEGORY>
				<xsl:choose>
					<xsl:when test=""ns0:SHORT-LABEL/@SI='' or normalize-space(ns0:SHORT-LABEL/@SI)=''"">
						<xsl:text>Collection</xsl:text>
					</xsl:when>
					<xsl:otherwise>
						<xsl:text>SW-Version</xsl:text>
					</xsl:otherwise>
				</xsl:choose>
			</CATEGORY>-->
			<CATEGORY>
				<xsl:text>Collection</xsl:text>
			</CATEGORY>
			<LIFECYCLESTATE ACTION=""IGNORE"" />
			<OPERATIONMODE>
				<xsl:text>ASAM-IMPORT</xsl:text>
			</OPERATIONMODE>
			<OPERATIONCONTEXT>
				<xsl:text>BizTalk</xsl:text>
			</OPERATIONCONTEXT>
			<PVER_CATEGORY>
				<xsl:value-of select=""ns0:CATEGORY"" />
			</PVER_CATEGORY>
			<MAPPEDISSUE ID-REF=""ISS_1"" />
		</RELEASE>
	</xsl:for-each>
</RT_RELEASES>
      <xsl:for-each select=""s1:ISSUES/s1:ISSUE"">
        <xsl:variable name=""var:v19"" select=""string(s1:CATEGORY/text())"" />
        <xsl:variable name=""var:v20"" select=""string(../../s1:CATEGORY/text())"" />
        <xsl:variable name=""var:v21"" select=""string(s1:ISSUE-PROPERTIES/s1:ISSUE-INITIATOR/s1:COMPANY-DATA-REF/text())"" />
        <xsl:variable name=""var:v22"" select=""userCSharp:Concat($var:v19 , $var:v20 , $var:v21)"" />
        <xsl:variable name=""var:v23"" select=""userCSharp:GetDateInFormat()"" />
        <xsl:call-template name=""GetIRMAPSData"">
          <xsl:with-param name=""EXTERNALEXCHANGEWORKFLOW"" select=""string($var:v22)"" />
          <xsl:with-param name=""param1"" select=""string($var:v23)"" />
        </xsl:call-template>
      </xsl:for-each>
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


public string Concat(string param1, string  param2,string param3)
{
string strToReturn = "" "";
if(param2 == ""BMW-PROSPR"")
{
if(param3 ==  ""BOSCH"")
               {
               strToReturn = ""BMW_PROSPR_SPL"";
               }
else if(param1 == ""CHANGE-REQUEST"")
	{
	strToReturn = ""BMW_PROSPR_REQ"";
	}
else 
	{
    strToReturn = ""BMW_PROSPR_DEF"";  
     }
}
else if(param2 == ""BMW-CC-PROSPR"")
{
if(param3 ==  ""BOSCH"")
               {
               strToReturn = ""BMW_PROSPR-CC_SPL"";
               }
else if(param1 == ""CHANGE-REQUEST"")
	{
	strToReturn = ""BMW_PROSPR-CC_REQ"";
	}
else 
	{
    strToReturn = ""BMW_PROSPR-CC_DEF"";  
     }
}
return strToReturn; 

}

public string SetOEMState(string param1,string param2)
{
   string strReturn = "" "";	
   if(param1.ToUpper() == ""ACCEPTED"")
   {
       if(param2.ToUpper() == ""CHANGE-REQUEST"")
      {
       strReturn = param1+""_CP"";
       }
       else
       {
        strReturn = param1+""_PR"";       
       }
    }
    else
     {
        strReturn = param1;
     }
  return strReturn;
}


public string StringUpperCase(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.ToUpper(System.Globalization.CultureInfo.InvariantCulture);
}



]]></msxsl:script>
  <xsl:template name=""GetExternalAttachmentData"">
  <xsl:param name=""param1"" />
  <EXTERNALEXCHANGEDATTACH xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"" ACTION=""APPEND"">
    <xsl:variable name=""counter"" select=""count(//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT[child::ns0:URL!='' and normalize-space(child::ns0:URL)!=''  and not(ns0:URL = preceding-sibling::ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)])"" />
    <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT[child::ns0:URL!='' and normalize-space(child::ns0:URL)!=''  and not(ns0:URL = preceding-sibling::ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)]"">
      <xsl:if test=""position() = 1"">
        <P>
          <xsl:text>### </xsl:text><xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" /><xsl:text> </xsl:text><xsl:value-of select=""$param1"" /><xsl:text> ###</xsl:text>
        </P>
      </xsl:if>
	   <xsl:if test=""not(position()&gt;9)"">
               <P>
        <xsl:text>ATT00</xsl:text><xsl:value-of select=""position()"" />:<xsl:value-of select=""$param1"" /><xsl:text> - </xsl:text><xsl:value-of select=""ns0:URL/."" />
      </P>
			   </xsl:if>
			    <xsl:if test=""position()&gt;9"">
              <P>
        <xsl:text>ATT0</xsl:text><xsl:value-of select=""position()"" />:<xsl:value-of select=""$param1"" /><xsl:text> - </xsl:text><xsl:value-of select=""ns0:URL/."" />
      </P>
			   </xsl:if>
      
    </xsl:for-each>
    <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-SOLUTIONS"">

     	<xsl:for-each select=""//ns0:ISSUE-SOLUTION[child::ns0:CATEGORY='PROPOSAL' or child::ns0:CATEGORY='REQUIREMENT-SPEC' or child::ns0:CATEGORY='TESTSPECIFICATION' or child::ns0:CATEGORY='CALIBRATION-DATA']/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT[child::ns0:URL!='' and normalize-space(child::ns0:URL)!='' and not(ns0:URL = preceding-sibling::ns0:ISSUE-RELATED-DOCUMENT/ns0:URL) and not(ns0:URL = //ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)and not(ns0:URL = preceding::ns0:ISSUE-SOLUTION[child::ns0:CATEGORY='PROPOSAL' or child::ns0:CATEGORY='REQUIREMENT-SPEC' &#xD;&#xA;  or child::ns0:CATEGORY='TESTSPECIFICATION' or child::ns0:CATEGORY='CALIBRATION-DATA']/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)]"">
            <xsl:if test=""$counter+position() = 1"">	
          <P>
            <xsl:text>### </xsl:text><xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" /><xsl:text> </xsl:text><xsl:value-of select=""$param1"" /><xsl:text> ###</xsl:text>
          </P>
        </xsl:if>
		 <xsl:if test=""not($counter+position()&gt;9)"">
               <P>
          <xsl:text>ATT00</xsl:text><xsl:value-of select=""$counter+position()"" />:<xsl:value-of select=""$param1"" /><xsl:text> - </xsl:text><xsl:value-of select=""ns0:URL/."" />
        </P>
        
			   </xsl:if>
			    <xsl:if test=""$counter+position()&gt;9"">
              <P>
          <xsl:text>ATT0</xsl:text><xsl:value-of select=""$counter+position()"" />:<xsl:value-of select=""$param1"" /><xsl:text> - </xsl:text><xsl:value-of select=""ns0:URL/."" />
        </P>
        
			   </xsl:if>
       
      </xsl:for-each>
    </xsl:for-each>
  </EXTERNALEXCHANGEDATTACH>
</xsl:template>
  <xsl:template name=""GetIRMAPSData"">
	<xsl:param name=""EXTERNALEXCHANGEWORKFLOW"" />
	<xsl:param name=""param1"" />
	<RT_IRMAPS xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
		<xsl:variable name=""idx"" select=""position()"" />
		<xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE"">
			<IRMAP>
				<ID>
				<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF='BOSCH']/ns0:ISSUE-ID/."" />
				</ID>
				<DBID>		
				</DBID>
				<RB_ID ACTION=""IGNORE"">
				</RB_ID>
				<SCOPE ACTION=""INIT"">
					<xsl:text>External</xsl:text>
				</SCOPE>
				<HASMAPPEDISSUE ID-REF=""ISS_1"" />
				<HASMAPPEDRELEASE>
					<xsl:attribute name=""ID-REF"">
						<xsl:text>REL_</xsl:text>
						<xsl:value-of select=""position()"" />
					</xsl:attribute>
				</HASMAPPEDRELEASE>         
				<EXTERNALEXCHANGEWORKFLOW>
					<xsl:value-of select=""$EXTERNALEXCHANGEWORKFLOW"" />
				</EXTERNALEXCHANGEWORKFLOW>							
				<EXTERNAL_ID>
				<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF='BMW']/ns0:ISSUE-ID/."" />
				</EXTERNAL_ID>
				<EXTERNALTITLE>
					<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:LONG-NAME/."" />
				</EXTERNALTITLE>
				<EXTERNALLASTIMPORTEDDATE>
					<xsl:value-of select=""$param1"" />
				</EXTERNALLASTIMPORTEDDATE>
				<EXTERNALASSIGNEE>
					<xsl:attribute name=""ID-REF"">
						<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF='BMW']/ns0:TEAM-MEMBER-REF/@ID-REF"" />
					</xsl:attribute>
				</EXTERNALASSIGNEE>
				<EXTERNALSTATE_PARALLEL1>
					<xsl:variable name=""IssueState"">
						<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" />
					</xsl:variable>
					<xsl:choose>
						<xsl:when test=""$IssueState='CLOSED-OK'"">
							<xsl:text>CLOSED</xsl:text>
						</xsl:when>
						<xsl:otherwise>
							<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" />
						</xsl:otherwise>
					</xsl:choose>	
				</EXTERNALSTATE_PARALLEL1>
				<EXTERNALCONVERSATION ACTION=""APPEND"">
					<P>
						<xsl:text>### </xsl:text>
						<xsl:value-of select=""$param1"" />
						<xsl:text> # </xsl:text>
						<xsl:variable name=""IssueState"">
						<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" />
						</xsl:variable>
						<xsl:choose>
						<xsl:when test=""$IssueState='CLOSED-OK'"">
							<xsl:text>CLOSED</xsl:text>
						</xsl:when>
						<xsl:otherwise>
							<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" />
						</xsl:otherwise>
						</xsl:choose>	
						<xsl:text> # </xsl:text><xsl:if test=""//ns0:COMPANY-DATA/ns0:SHORT-NAME = 'BMW' "">
        <xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:EMAIL/."" /></xsl:if>
						<xsl:text> ###</xsl:text>
					</P>										
				</EXTERNALCONVERSATION>
				<TAGS ACTION=""MERGE"">
					<TAGS>
						<xsl:choose>
							<xsl:when test=""ns0:CATEGORY = 'COMMERCIAL-LEAD'"">
								<xsl:text>&lt;Commercial-Pilot&gt;Yes&lt;/Commercial-Pilot&gt;</xsl:text>
							</xsl:when>
							<xsl:when test=""(ns0:CATEGORY = 'RESTRICTED') or (ns0:CATEGORY = 'REQUESTED')"">
								<xsl:text>&lt;Commercial-Pilot&gt;No&lt;/Commercial-Pilot&gt;</xsl:text>			   
							</xsl:when>
							<xsl:otherwise>
							</xsl:otherwise>
						</xsl:choose>
					</TAGS>
				</TAGS>
				
				<OPERATIONMODE>ASAM-IMPORT</OPERATIONMODE>
				<OPERATIONCONTEXT>BizTalk</OPERATIONCONTEXT>
				
			</IRMAP>
		</xsl:for-each>
	</RT_IRMAPS>
</xsl:template>
  <xsl:template name=""GetAttachmentsList"">
  <xsl:param name=""param1"" />
  <ATTACHMENTS xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"" TYPE=""ATTACHMENT""> 

    <xsl:variable name=""counter"" select=""count(//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT[child::ns0:URL!='' and normalize-space(child::ns0:URL)!=''  and not(ns0:URL = preceding-sibling::ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)])"" />
    <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT[child::ns0:URL!='' and normalize-space(child::ns0:URL)!=''  and not(ns0:URL = preceding-sibling::ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)]"">
      <ATTACHMENT>
        <NAME>
          <xsl:value-of select=""ns0:URL/."" />
        </NAME>
        <DESCRIPTION>
          <xsl:if test=""not(position()&gt;9)"">
            <P>
              <xsl:text>OrgReqDoc - </xsl:text>ATT00<xsl:value-of select=""position()"" />:<xsl:value-of select=""$param1"" />
            </P>
          </xsl:if>
          <xsl:if test=""position()&gt;9"">
            <P>
              <xsl:text>OrgReqDoc - </xsl:text>ATT0<xsl:value-of select=""position()"" />:<xsl:value-of select=""$param1"" />
            </P>
          </xsl:if>
        </DESCRIPTION>
        <FULL_NAME>
          <xsl:value-of select=""ns0:URL/."" />
        </FULL_NAME>
      </ATTACHMENT>
    </xsl:for-each>
    <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-SOLUTIONS"">
      <xsl:for-each select=""//ns0:ISSUE-SOLUTION[child::ns0:CATEGORY='PROPOSAL' or child::ns0:CATEGORY='REQUIREMENT-SPEC'or child::ns0:CATEGORY='TESTSPECIFICATION' or child::ns0:CATEGORY='CALIBRATION-DATA']/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT[child::ns0:URL!='' and  normalize-space(child::ns0:URL)!='' and not(ns0:URL = preceding-sibling::ns0:ISSUE-RELATED-DOCUMENT/ns0:URL) and not(ns0:URL = //ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)and not(ns0:URL = preceding::ns0:ISSUE-SOLUTION[child::ns0:CATEGORY='PROPOSAL' or child::ns0:CATEGORY='REQUIREMENT-SPEC' &#xD;&#xA;			or child::ns0:CATEGORY='TESTSPECIFICATION' or child::ns0:CATEGORY='CALIBRATION-DATA']/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)]"">

        <ATTACHMENT>		
          <NAME>
            <xsl:value-of select=""ns0:URL/."" />
          </NAME>
          <DESCRIPTION>
            <xsl:if test=""not($counter+position()&gt;9)"">
              <P>
                <xsl:text>OrgReqDoc - </xsl:text>ATT00<xsl:value-of select=""$counter+position()"" />:<xsl:value-of select=""$param1"" />
              </P>
            </xsl:if>
            <xsl:if test=""$counter+position()&gt;9"">
              <P>
                <xsl:text>OrgReqDoc - </xsl:text>ATT0<xsl:value-of select=""$counter+position()"" />:<xsl:value-of select=""$param1"" />
              </P>
            </xsl:if>

          </DESCRIPTION>
          <FULL_NAME>
            <xsl:value-of select=""ns0:URL/."" />
          </FULL_NAME>
        </ATTACHMENT>

      </xsl:for-each>
    </xsl:for-each>
  </ATTACHMENTS>
</xsl:template>
  <xsl:template name=""SetExternalHistory"">
  <xsl:param name=""param1"" />
  <xsl:param name=""param2"" />
  <EXTERNALHISTORY ACTION=""APPEND"" xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
    <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" />
    <xsl:text> - </xsl:text>
    <xsl:value-of select=""$param1"" />
    <xsl:value-of select=""$param2"" />
    <xsl:text> - </xsl:text>
    <xsl:choose>
      <xsl:when test=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO/ns0:COMPANY-DATA-REF/. = 'BMW'"">
        <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO/ns0:ISSUE-ID/."" />
      </xsl:when>
      <xsl:otherwise>
      </xsl:otherwise>
    </xsl:choose>
  </EXTERNALHISTORY>
</xsl:template>
  <xsl:template name=""GetExternalConversion"">
	<xsl:param name=""param1"" />	
	<xsl:variable name=""digit"" select=""'!@#$% .*()_-+=%^{}|[]\;:,?/'"" />		
	<xsl:variable name=""lower"" select=""'abcdefghijklmnopqrstuvwxyz'"" />
    <xsl:variable name=""upper"" select=""'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"" />
	<xsl:variable name=""quote"">'</xsl:variable>
	<xsl:variable name=""apos"">""</xsl:variable>
	<EXTERNALCONVERSATION ACTION=""APPEND"" xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
		<P>
			<xsl:text>### </xsl:text>
			<xsl:value-of select=""$param1"" />
			<xsl:text> # </xsl:text>
			<xsl:variable name=""IssueState"">
			<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" />
			</xsl:variable>
			<xsl:choose>
			<xsl:when test=""$IssueState='CLOSED-OK'"">
				<xsl:text>CLOSED</xsl:text>
			</xsl:when>
			<xsl:otherwise>
				<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" />
			</xsl:otherwise>
			</xsl:choose>
			<xsl:text> # </xsl:text><xsl:if test=""//ns0:COMPANY-DATA/ns0:SHORT-NAME = 'BMW' "">
        <xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:EMAIL/."" /></xsl:if> ###
		</P>
		<xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-ANNOTATIONS/ns0:ISSUE-ANNOTATION[not(ns0:TEAM-MEMBER-REF/@ID-REF = 'efaPUNKTsupport_bmw_de')]"">
        <xsl:sort select=""ns0:DATE"" order=""descending"" />
		<xsl:variable name=""sival"" select=""@SI"" />
		<P>
		<xsl:text>[:</xsl:text>
		<xsl:choose>
			<xsl:when test=""translate($sival, translate($sival, concat($upper, $lower, $digit), ''), '') or contains($sival, $quote) or contains($sival, $apos)"">
			  <xsl:text>invalid_text</xsl:text>
			</xsl:when>
			<xsl:when test=""$sival!= ''"">
			   <xsl:value-of select=""$sival"" />
			</xsl:when>
			<xsl:otherwise>
				<xsl:text>invalid_text</xsl:text>
			</xsl:otherwise>
		</xsl:choose>
		<xsl:text>:›</xsl:text>
		</P>
        <P>		  
          <xsl:text>Comment from </xsl:text>
          <xsl:value-of select=""ns0:TEAM-MEMBER-REF/@ID-REF"" />
          <xsl:text> on </xsl:text>
          <xsl:value-of select=""translate(ns0:DATE,'T',' ')"" />
          <xsl:text>:</xsl:text>
        </P>
        <xsl:for-each select=""ns0:ANNOTATION-TEXT/ns0:P"">
          <P>
            <xsl:value-of select=""."" />
          </P>
        </xsl:for-each>
		<P>
		<xsl:text>‹:</xsl:text>
		<xsl:choose>
			<xsl:when test=""translate($sival, translate($sival, concat($upper, $lower, $digit), ''), '') or contains($sival, $quote) or contains($sival, $apos)"">
			  <xsl:text>invalid_text</xsl:text>
			</xsl:when>
			<xsl:when test=""$sival!= ''"">
			   <xsl:value-of select=""$sival"" />
			</xsl:when>
			<xsl:otherwise>
				<xsl:text>invalid_text</xsl:text>
			</xsl:otherwise>
		</xsl:choose>
		<xsl:text>:]</xsl:text>
		</P>
		</xsl:for-each>
		<P />
	</EXTERNALCONVERSATION>
</xsl:template>
  <xsl:template name=""SetExtTags"">
	<xsl:param name=""AdminDate"" />
	<EXTERNALTAGS xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"" ACTION=""MERGE"">
		<EXTERNALTAG>
			<xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE"">
				<P>
					<xsl:text>&lt;Delivery-Milestone Date=""</xsl:text>
					<xsl:value-of select=""$AdminDate"" />
					<xsl:text>""&gt;</xsl:text>
					<xsl:value-of select=""ns0:SHORT-LABEL/."" />
					<xsl:text>&lt;/Delivery-Milestone&gt;</xsl:text>
				</P>
			</xsl:for-each>
			<P>
				<xsl:text>&lt;CUSTOMER-DATE  STATE= ""</xsl:text>
				<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" />
				<xsl:text>""&gt;</xsl:text>
				<xsl:value-of select=""$AdminDate"" />
				<xsl:text>&lt;/CUSTOMER-DATE&gt;</xsl:text>
			</P>
			<xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-ENVIRONMENT/ns0:ENGINEERING-OBJECTS/ns0:ENGINEERING-OBJECT"">
				<xsl:if test=""ns0:CATEGORY/. != '' and normalize-space(ns0:CATEGORY)!=''"">
					<P>
						<xsl:text>&lt;</xsl:text>
						<xsl:value-of select=""ns0:CATEGORY/."" />
						<xsl:text />
						<xsl:text> DATE=""</xsl:text>
						<xsl:value-of select=""$AdminDate"" />
						<xsl:text>""</xsl:text>
						<xsl:text />
						<xsl:text> REVISION=""</xsl:text>
						<xsl:value-of select=""ns0:REVISION-LABELS/ns0:REVISION-LABEL/."" />
						<xsl:text>""</xsl:text>
						<xsl:text>&gt;</xsl:text>
						<xsl:value-of select=""ns0:SHORT-LABEL/."" />
						<xsl:text>&lt;/</xsl:text>
						<xsl:value-of select=""ns0:CATEGORY/."" />
						<xsl:text>&gt;</xsl:text>
					</P>
				</xsl:if>
			</xsl:for-each>
			<P>
				<xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:RELATED-ISSUES/ns0:RELATED-ISSUE[ns0:ISSUE-RELATION/. = 'SIMILAR']"">
					<xsl:if test=""(position() = 1)"">
						<xsl:text>&lt;SIMILAR</xsl:text>
						<xsl:text>&gt;</xsl:text>
					</xsl:if>
					<xsl:value-of select=""ns0:ISSUE-REF/."" />
					<xsl:if test=""not(position() = last())"">,</xsl:if>
					<xsl:if test=""(position() = last())"">
						<xsl:text>&lt;/SIMILAR</xsl:text>
						<xsl:text>&gt;</xsl:text>
					</xsl:if>
				</xsl:for-each>
			</P>
		</EXTERNALTAG>
	</EXTERNALTAGS>
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
