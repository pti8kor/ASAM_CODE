namespace RB.ROCustomerInterface {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.BMW.issue_v3_1_0_sl", typeof(global::RB.ROCustomerInterface.Schema.BMW.issue_v3_1_0_sl))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM", typeof(global::RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM))]
    public sealed class RB_RO_BMW310_ISSUE_IMF_MAP : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1 userCSharp"" version=""1.0"" xmlns:s1=""http://www.asam.net/schemas/issue/issue310"" xmlns:s0=""http://www.w3.org/XML/1998/namespace"" xmlns:ns0=""http://RB.ROCustomerInterface.RB"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" indent=""yes"" version=""1.0"" method=""xml"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:MSR-ISSUE"" />
  </xsl:template>
  <xsl:template match=""/s1:MSR-ISSUE"">
    <xsl:variable name=""var:v17"" select=""userCSharp:StringConcat(&quot;PRO_1&quot;)"" />
    <xsl:variable name=""var:v18"" select=""userCSharp:StringConcat(&quot;0&quot;)"" />
    <xsl:variable name=""var:v19"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
    <xsl:variable name=""var:v20"" select=""userCSharp:StringConcat(&quot;REL_1&quot;)"" />
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
            <xsl:variable name=""var:v4"" select=""userCSharp:Concat($var:v3)"" />
            <OEMWORKFLOW>
              <xsl:value-of select=""$var:v4"" />
            </OEMWORKFLOW>
          </VALEX_CONTROLINFO>
        </xsl:for-each>
      </RT_VALEX_CONTROLINFO>
      <RT_CONTACT xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"">
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
          <xsl:variable name=""var:v7"" select=""string(s1:CATEGORY/text())"" />
          <xsl:variable name=""var:v13"" select=""userCSharp:StringConcat(&quot;New Requirement&quot;)"" />
          <xsl:variable name=""var:v14"" select=""userCSharp:StringConcat(&quot;No&quot;)"" />
          <xsl:variable name=""var:v16"" select=""userCSharp:StringConcat(&quot; - ExchangeProtocol: &lt;XPROT&gt;&quot;)"" />
          <ISSUE>
            <xsl:attribute name=""ID"">
              <xsl:value-of select=""$var:v5"" />
            </xsl:attribute>
            <DBID>
              <xsl:value-of select=""$var:v6"" />
            </DBID>
            <RB_ID xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"" ACTION=""IGNORE"">

  <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:RELATED-ISSUES/ns0:RELATED-ISSUE"">
    <xsl:if test=""ns0:COMPANY-DATA-REF/. != 'BMW'"">
      <xsl:if test=""ns0:ISSUE-RELATION/. = 'PARENT'"">
<xsl:choose>
     <xsl:when test=""ns0:ISSUE-REF/. = '' or normalize-space(ns0:ISSUE-REF)=''"">
              <xsl:text>0</xsl:text>
     </xsl:when>
       <xsl:otherwise>
           <xsl:value-of select=""ns0:ISSUE-REF/."" />
         </xsl:otherwise>
</xsl:choose>         
      </xsl:if>  
    </xsl:if>
  </xsl:for-each>
</RB_ID>
            <ID>
              <xsl:value-of select=""$var:v6"" />
            </ID>
            <TITLE>
              <xsl:value-of select=""s1:LONG-NAME/text()"" />
            </TITLE>
            <DESCRIPTION xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"">
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
  </DESCRIPTION>
            <BELONGSTOPROJECT>
              <xsl:value-of select=""$var:v6"" />
            </BELONGSTOPROJECT>
            <TYPE xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"" ACTION=""INIT"">
  <xsl:text>Issue SW</xsl:text>	
</TYPE>
            <DOMAIN xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"" ACTION=""INIT"">
  <xsl:text>Software</xsl:text>      
</DOMAIN>
            <SCOPE xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"" ACTION=""INIT"">
  <xsl:text>External</xsl:text>      
</SCOPE>
            <xsl:variable name=""var:v8"" select=""userCSharp:MyConcat($var:v7)"" />
            <CATEGORY>
              <xsl:value-of select=""$var:v8"" />
            </CATEGORY>
            <ISSUE_CATEGORY_FROM_CUSTOMER>
              <xsl:value-of select=""s1:CATEGORY/text()"" />
            </ISSUE_CATEGORY_FROM_CUSTOMER>
            <EXTERNAL_ID xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"">
  <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:RELATED-ISSUES/ns0:RELATED-ISSUE"">
    <xsl:if test=""ns0:COMPANY-DATA-REF/. = 'BMW'"">
      <xsl:if test=""ns0:ISSUE-RELATION/. = 'PARENT'"">
        <xsl:value-of select=""ns0:ISSUE-REF/."" />
      </xsl:if>
    </xsl:if>
  </xsl:for-each>
</EXTERNAL_ID>
            <EXTERNALTITLE>
              <xsl:value-of select=""s1:LONG-NAME/text()"" />
            </EXTERNALTITLE>
            <EXTERNALSTATE_PARALLEL1>
              <xsl:value-of select=""$var:v6"" />
            </EXTERNALSTATE_PARALLEL1>
            <EXTERNALSTATE_PARALLEL2>
              <xsl:value-of select=""$var:v6"" />
            </EXTERNALSTATE_PARALLEL2>
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
            <xsl:for-each select=""s1:COMPANY-ISSUE-INFOS/s1:COMPANY-ISSUE-INFO"">
              <EXTERNALASSIGNEE>
                <xsl:if test=""s1:TEAM-MEMBER-REF/@ID-REF"">
                  <xsl:attribute name=""ID-REF"">
                    <xsl:value-of select=""s1:TEAM-MEMBER-REF/@ID-REF"" />
                  </xsl:attribute>
                </xsl:if>
              </EXTERNALASSIGNEE>
            </xsl:for-each>
            <EXTERNALORGANISATION>
              <xsl:value-of select=""../../s1:COMPANY-DATAS/s1:COMPANY-DATA/s1:SHORT-NAME/text()"" />
            </EXTERNALORGANISATION>
            <EXTERNALREVIEW>
              <xsl:value-of select=""$var:v6"" />
            </EXTERNALREVIEW>
            <EXTERNALTAGS>
              <EXTERNALTAG>
                <P>
                  <xsl:value-of select=""$var:v6"" />
                </P>
              </EXTERNALTAG>
            </EXTERNALTAGS>
            <EXTERNALDESCRIPTION xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"">
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
            <EXTERNALCONVERSATION>
              <P>
                <xsl:value-of select=""$var:v6"" />
              </P>
            </EXTERNALCONVERSATION>
            <xsl:variable name=""var:v9"" select=""userCSharp:Concat($var:v7)"" />
            <EXTERNALEXCHANGEWORKFLOW>
              <xsl:value-of select=""$var:v9"" />
            </EXTERNALEXCHANGEWORKFLOW>
            <EXTERNALLASTEXPORTEDDATE>
              <xsl:value-of select=""$var:v6"" />
            </EXTERNALLASTEXPORTEDDATE>
            <xsl:variable name=""var:v10"" select=""userCSharp:GetDateInFormat()"" />
            <EXTERNALLASTIMPORTEDDATE>
              <xsl:value-of select=""$var:v10"" />
            </EXTERNALLASTIMPORTEDDATE>
            <xsl:variable name=""var:v11"" select=""userCSharp:GetDateInFormat()"" />
            <xsl:call-template name=""GetAttachmentsList"">
              <xsl:with-param name=""param1"" select=""string($var:v11)"" />
            </xsl:call-template>
            <xsl:variable name=""var:v12"" select=""userCSharp:GetDateInFormat()"" />
            <xsl:call-template name=""GetExternalAttachmentData"">
              <xsl:with-param name=""param1"" select=""string($var:v12)"" />
            </xsl:call-template>
            <COMMERCIALCLASSIFICATION>
              <xsl:value-of select=""$var:v13"" />
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
              <xsl:value-of select=""$var:v14"" />
            </COMMERCIALQUOTATIONREQ>
            <OCCURRENCE xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"">
 <xsl:if test=""//ns0:MSR-ISSUE/ns0:ISSUES/ns0:ISSUE/ns0:CATEGORY/. = 'PROBLEM-REPORT'"">
  <xsl:variable name=""smallcase"" select=""'abcdefghijklmnopqrstuvwxyz'"" />
  <xsl:variable name=""uppercase"" select=""'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"" />
  <xsl:variable name=""ShortLabel"">
    <xsl:value-of select=""/ns0:MSR-ISSUE/ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-ENVIRONMENT/ns0:ENGINEERING-OBJECTS/ns0:ENGINEERING-OBJECT[ns0:CATEGORY='FREQUENCY']/ns0:SHORT-LABEL"" />
  </xsl:variable>
 
  <xsl:choose>
    <xsl:when test=""translate($ShortLabel,$smallcase,$uppercase)='REPRODUZIERBAR' or translate($ShortLabel,$smallcase,$uppercase)='HäUFIG'"">
      <xsl:text>Reproducible</xsl:text>
    </xsl:when>
    <xsl:when test=""translate($ShortLabel,$smallcase,$uppercase)='SPORADISCH'"">
      <xsl:text>Sporadic</xsl:text>
    </xsl:when>
    <xsl:when test=""translate($ShortLabel,$smallcase,$uppercase)='EINMAL'"">
      <xsl:text>Once</xsl:text>
    </xsl:when>
    <xsl:otherwise></xsl:otherwise>
  </xsl:choose>
  </xsl:if>
</OCCURRENCE>
            <SEVERITY xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"">
 <xsl:if test=""//ns0:MSR-ISSUE/ns0:ISSUES/ns0:ISSUE/ns0:CATEGORY/. = 'PROBLEM-REPORT'"">
  <xsl:variable name=""ShortLabel"">
    <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-ENVIRONMENT/ns0:ENGINEERING-OBJECTS/ns0:ENGINEERING-OBJECT[ns0:CATEGORY='BI']/ns0:SHORT-LABEL"" />
  </xsl:variable>
 
  <xsl:choose>
    <xsl:when test=""contains($ShortLabel,'BI1') or contains($ShortLabel,'BI2') or contains($ShortLabel,'BI3') or contains($ShortLabel,'BI4')"">
      <xsl:text>High</xsl:text>
    </xsl:when>
    <xsl:when test=""contains($ShortLabel,'BI5')"">
      <xsl:text>Medium</xsl:text>
    </xsl:when>
    <xsl:when test=""contains($ShortLabel,'BI6') or contains($ShortLabel,'BI7') or contains($ShortLabel,'BI8') or contains($ShortLabel,'BI9')"">
      <xsl:text>Low</xsl:text>
    </xsl:when>
    <xsl:otherwise></xsl:otherwise>
  </xsl:choose>
  </xsl:if>
</SEVERITY>
            <xsl:variable name=""var:v15"" select=""userCSharp:GetDateInFormat()"" />
            <xsl:call-template name=""SetExternalHistory"">
              <xsl:with-param name=""param1"" select=""string($var:v15)"" />
              <xsl:with-param name=""param2"" select=""string($var:v16)"" />
            </xsl:call-template>
            <AFFECTEDISSUE_EXTERNAL xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"">
  <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:RELATED-ISSUES/ns0:RELATED-ISSUE"">
                <xsl:choose>
                  <xsl:when test=""ns0:ISSUE-RELATION/. = 'PREDECESSOR'"">                  
                  <xsl:value-of select=""ns0:ISSUE-REF/."" />                
                  </xsl:when>
                <xsl:otherwise />     
                </xsl:choose>
</xsl:for-each>
</AFFECTEDISSUE_EXTERNAL>
            <xsl:call-template name=""GetLCS"" />
            <OPERATIONMODE xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"">
<xsl:text>ASAM-IMPORT</xsl:text>
</OPERATIONMODE>
            <OPERATIONCONTEXT xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"">
<xsl:text>BizTalk</xsl:text>
</OPERATIONCONTEXT>
            <TAGS ACTION=""MERGE"">
	<TAGS>
		<xsl:text>&lt;AlgorithmsToReview_ChangeComment&gt;Contents-Required-Despite-AlgorithToReview-Did-Not-Change&lt;/AlgorithmsToReview_ChangeComment&gt;</xsl:text>			   
	</TAGS>
</TAGS>
          </ISSUE>
        </xsl:for-each>
      </RT_ISSUES>
      <RT_PROJECTS>
        <PROJECT>
          <xsl:attribute name=""ID"">
            <xsl:value-of select=""$var:v17"" />
          </xsl:attribute>
          <ID>
            <xsl:value-of select=""$var:v18"" />
          </ID>
          <DBID>
            <xsl:value-of select=""$var:v18"" />
          </DBID>
          <RB_ID xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"" ACTION=""IGNORE"">
  <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO"">
    <xsl:if test=""ns0:COMPANY-DATA-REF/.!= 'BMW'"">
      <xsl:choose>
        <xsl:when test=""ns0:PROJECT-ID/@SI = '' or normalize-space(ns0:PROJECT-ID/@SI) = ''"">
          <xsl:text>0</xsl:text>
        </xsl:when>
        <xsl:otherwise>
          <xsl:value-of select=""ns0:PROJECT-ID/@SI"" />
        </xsl:otherwise>
      </xsl:choose>
    </xsl:if>
  </xsl:for-each>
</RB_ID>
          <DOMAIN xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"" ACTION=""INIT"">
  <xsl:text>Software</xsl:text>      
</DOMAIN>
          <TYPE xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"" ACTION=""INIT"">
  <xsl:text>CustPrj</xsl:text>      
</TYPE>
          <TITLE xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"" ACTION=""INIT"">
  <xsl:text>BMWSubProject</xsl:text>      
</TITLE>
          <SCOPE xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"" ACTION=""INIT"">
  <xsl:text>External</xsl:text>      
</SCOPE>
          <EXTERNAL_ID xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"">
 <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO"">
      <xsl:if test=""ns0:COMPANY-DATA-REF/.= 'BMW'"">
          <xsl:value-of select=""ns0:PROJECT-ID/@SI"" />
  </xsl:if>
</xsl:for-each>
</EXTERNAL_ID>
          <EXTERNALTITLE xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"">
 <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO"">
      <xsl:if test=""ns0:COMPANY-DATA-REF/.= 'BMW'"">
        <xsl:value-of select=""ns0:PROJECT-ID"" />
  </xsl:if>
</xsl:for-each>
</EXTERNALTITLE>
          <BELONGSTOPOOLPROJECT>
            <xsl:value-of select=""$var:v19"" />
          </BELONGSTOPOOLPROJECT>
          <OPERATIONMODE xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"">
<xsl:text>ASAM-IMPORT</xsl:text>
</OPERATIONMODE>
          <OPERATIONCONTEXT xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"">
<xsl:text>BizTalk</xsl:text>
</OPERATIONCONTEXT>
        </PROJECT>
      </RT_PROJECTS>
      <RT_RELEASES>
        <RELEASE>
          <xsl:attribute name=""ID"">
            <xsl:value-of select=""$var:v20"" />
          </xsl:attribute>
          <DBID>
            <xsl:value-of select=""$var:v19"" />
          </DBID>
          <RB_ID xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"" ACTION=""IGNORE"">
  <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE"">
    <xsl:if test=""ns0:COMPANY-DATA-REF/.!= 'BMW'"">
      <xsl:choose>
        <xsl:when test=""ns0:SHORT-LABEL/@SI = '' or normalize-space(ns0:SHORT-LABEL/@SI) = ''"">
          <xsl:text>0</xsl:text>
        </xsl:when>
        <xsl:otherwise>
          <xsl:value-of select=""ns0:SHORT-LABEL/@SI"" />
        </xsl:otherwise>
      </xsl:choose>
    </xsl:if>
  </xsl:for-each>
</RB_ID>
          <ID>
            <xsl:value-of select=""$var:v19"" />
          </ID>
          <DOMAIN xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"" ACTION=""INIT"">
  <xsl:text>Software</xsl:text>      
</DOMAIN>
          <TYPE xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"" ACTION=""INIT"">
  <xsl:text>PVER</xsl:text>      
</TYPE>
          <SCOPE xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"" ACTION=""INIT"">
  <xsl:text>External</xsl:text>      
</SCOPE>
          <TITLE xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"">
  <xsl:if test=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:COMPANY-DATA-REF/. = 'BMW'"">
    <xsl:choose>
      <xsl:when test=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL/@SI='' or normalize-space(//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL/@SI)=''"">
        <xsl:text>PST_unknown</xsl:text>
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select=""concat('PVER : ', //ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL)"" />
      </xsl:otherwise>
    </xsl:choose>
  </xsl:if>
</TITLE>
          <EXTERNAL_ID xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"">
  <xsl:if test=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:COMPANY-DATA-REF/. = 'BMW'"">
    <xsl:choose>
      <xsl:when test=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL/@SI='' or normalize-space(//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL/@SI)=''"">
        <xsl:text>PST_unknown</xsl:text>
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL/@SI/."" />
      </xsl:otherwise>
    </xsl:choose>
  </xsl:if>
</EXTERNAL_ID>
          <PLANNEDDATE>
            <xsl:value-of select=""$var:v19"" />
          </PLANNEDDATE>
          <EXTERNALTITLE xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"">
  <xsl:if test=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:COMPANY-DATA-REF/. = 'BMW'"">
    <xsl:choose>
      <xsl:when test=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL/@SI='' or normalize-space(//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL/@SI)=''"">
        <xsl:text>PST_unknown</xsl:text>
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL/."" />
      </xsl:otherwise>
    </xsl:choose>
  </xsl:if>
</EXTERNALTITLE>
          <BELONGSTOPROJECT>
            <xsl:attribute name=""ID-REF"">
              <xsl:value-of select=""$var:v17"" />
            </xsl:attribute>
          </BELONGSTOPROJECT>
          <CATEGORY ACTION=""INIT"" xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"">
  <xsl:if test=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:COMPANY-DATA-REF/. = 'BMW'"">
    <xsl:choose>
      <xsl:when test=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL/@SI='' or normalize-space(//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL/@SI)=''"">
        <xsl:text>Collection</xsl:text>
      </xsl:when>
      <xsl:otherwise>
        <xsl:text>SW-Version</xsl:text>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:if>
</CATEGORY>
          <xsl:call-template name=""GetRleaseLCS"" />
          <OPERATIONMODE xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"">
<xsl:text>ASAM-IMPORT</xsl:text>
</OPERATIONMODE>
          <OPERATIONCONTEXT xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"">
<xsl:text>BizTalk</xsl:text>
</OPERATIONCONTEXT>
        </RELEASE>
      </RT_RELEASES>
      <xsl:for-each select=""s1:ADMIN-DATA/s1:DOC-REVISIONS/s1:DOC-REVISION"">
        <xsl:variable name=""var:v21"" select=""userCSharp:Concat(string(../../../s1:ISSUES/s1:ISSUE/s1:CATEGORY/text()))"" />
        <xsl:variable name=""var:v22"" select=""userCSharp:GetDateInFormat()"" />
        <xsl:call-template name=""GetIRMAPSData"">
          <xsl:with-param name=""AdminDate"" select=""string(s1:DATE/text())"" />
          <xsl:with-param name=""EXTERNALEXCHANGEWORKFLOW"" select=""string($var:v21)"" />
          <xsl:with-param name=""AnnotationDate"" select=""string(../../../s1:ISSUES/s1:ISSUE/s1:ISSUE-ANNOTATIONS/s1:ISSUE-ANNOTATION/s1:DATE/text())"" />
          <xsl:with-param name=""param1"" select=""string($var:v22)"" />
          <xsl:with-param name=""IDREF"" select=""string(../../../s1:ISSUES/s1:ISSUE/s1:COMPANY-ISSUE-INFOS/s1:COMPANY-ISSUE-INFO/s1:TEAM-MEMBER-REF/@ID-REF)"" />
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




public string MyConcat(string param1)
{
string strToReturn="" "";

if(param1 == ""CHANGE-REQUEST"")
{
strToReturn = ""Requirement"";
}
else
{
strToReturn = ""Defect"";
}


	return strToReturn; 
}




public string Concat(string param1)
{
string strToReturn = "" "";
if(param1 ==""CHANGE-REQUEST"")
{
strToReturn =""BMW_ASAM310_CP"";
}
else
{
strToReturn =""BMW_ASAM310_PR"";
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
  <xsl:template name=""SetExternalConversation"">
  <xsl:param name=""Date"" />
<EXTERNALCONVERSATION xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"" ACTION=""APPEND""> 
    <P>### <xsl:value-of select=""$Date"" />#<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" /># <xsl:value-of select=""//ns0:TEAM-MEMBER-REF/@ID-REF"" /> ###</P>
<P></P>
    <xsl:for-each select=""//ns0:ANNOTATION-TEXT/ns0:P"">
      <P><xsl:value-of select=""."" /></P>
    </xsl:for-each>
  </EXTERNALCONVERSATION>
</xsl:template>
  <xsl:template name=""GetExternalAttachmentData"">
  <xsl:param name=""param1"" />
  <EXTERNALEXCHANGEDATTACH xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"" ACTION=""APPEND"">
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

     	<xsl:for-each select=""//ns0:ISSUE-SOLUTION[child::ns0:CATEGORY='PROPOSAL' or child::ns0:CATEGORY='SOLUTION' or child::ns0:CATEGORY='TESTSPECIFICATION' or child::ns0:CATEGORY='CALIBRATION-DATA']/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT[child::ns0:URL!='' and normalize-space(child::ns0:URL)!='' and not(ns0:URL = preceding-sibling::ns0:ISSUE-RELATED-DOCUMENT/ns0:URL) and not(ns0:URL = //ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)and not(ns0:URL = preceding::ns0:ISSUE-SOLUTION[child::ns0:CATEGORY='PROPOSAL' or child::ns0:CATEGORY='SOLUTION' &#xD;&#xA;  or child::ns0:CATEGORY='TESTSPECIFICATION' or child::ns0:CATEGORY='CALIBRATION-DATA']/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)]"">
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
  <xsl:template name=""GetExternalTags"">
  <xsl:param name=""param1"" />
  <EXTERNALTAG xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"" ACTION=""APPEND"">
    <P>
      <xsl:text>&lt;DATE-CUSTOMER  STATE= ""</xsl:text>     <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" /><xsl:text>""&gt;</xsl:text><xsl:value-of select=""$param1"" />     <xsl:text>&lt;/DATE-CUSTOMER&gt;</xsl:text>
    </P>
    <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-ENVIRONMENT/ns0:ENGINEERING-OBJECTS/ns0:ENGINEERING-OBJECT"">
      <P>
     <xsl:text>&lt;</xsl:text><xsl:value-of select=""ns0:CATEGORY/."" /> <xsl:text>DATE="" </xsl:text><xsl:value-of select=""$param1"" /><xsl:text>""</xsl:text> <xsl:text>REVISION=""</xsl:text><xsl:value-of select=""ns0:REVISION-LABELS/ns0:REVISION-LABEL/."" /><xsl:text>""</xsl:text><xsl:text>&gt;</xsl:text>        <xsl:value-of select=""ns0:SHORT-LABEL/."" />   <xsl:text>&lt;/</xsl:text><xsl:value-of select=""ns0:CATEGORY/."" /><xsl:text>&gt;</xsl:text>
      </P>
    </xsl:for-each>
  </EXTERNALTAG>
</xsl:template>
  <xsl:template name=""GetIRMAPSData"">
  <xsl:param name=""AdminDate"" />
  <xsl:param name=""EXTERNALEXCHANGEWORKFLOW"" />
  <xsl:param name=""AnnotationDate"" />
  <xsl:param name=""param1"" />
  <xsl:param name=""IDREF"" />
  <RT_IRMAPS xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"">
    <xsl:variable name=""idx"" select=""position()"" />
    <xsl:for-each select=""//ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO"">
      <xsl:if test=""ns0:COMPANY-DATA-REF/. = 'BMW'"">
        <IRMAP>
          <DBID>
          </DBID>
          <RB_ID ACTION=""IGNORE"">
            <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO"">
              <xsl:if test=""ns0:COMPANY-DATA-REF/.!= 'BMW'"">
                <xsl:choose>
                  <xsl:when test=""ns0:ISSUE-ID/. = '' or normalize-space(ns0:ISSUE-ID) =''"">
                    <xsl:text>0</xsl:text>
                  </xsl:when>
                  <xsl:otherwise>
                    <xsl:value-of select=""ns0:ISSUE-ID/."" />
                  </xsl:otherwise>
                </xsl:choose>
              </xsl:if>
            </xsl:for-each>
          </RB_ID>
          <SCOPE ACTION=""INIT"">
            <xsl:text>External</xsl:text>
          </SCOPE>
          <HASMAPPEDISSUE ID-REF=""ISS_1""></HASMAPPEDISSUE>
          <HASMAPPEDRELEASE ID-REF=""REL_1""> </HASMAPPEDRELEASE>
          <EXTERNALNEXTSTATE></EXTERNALNEXTSTATE>
          <EXTERNALTAGS ACTION=""MERGE"">
            <EXTERNALTAG>
              <!--><P>
                <xsl:text>&lt;CreationDate&gt;</xsl:text>
                <xsl:value-of select=""$AdminDate"" />
                <xsl:text>&lt;/CreationDate&gt;</xsl:text>
              </P>-->
              <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES//ns0:DELIVERY-MILESTONES"">
                <P>
                  <xsl:text>&lt;Delivery-Milestone Date=""</xsl:text>
                  <xsl:value-of select=""$AdminDate"" />
                  <xsl:text>""&gt;</xsl:text>
                  <xsl:value-of select=""ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL/."" />
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
                    <xsl:text> </xsl:text>
                    <xsl:text>DATE=""</xsl:text>
                    <xsl:value-of select=""$AdminDate"" />
                    <xsl:text>""</xsl:text>
                    <xsl:text> </xsl:text>
                    <xsl:text>REVISION=""</xsl:text>
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
              <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:RELATED-ISSUES/ns0:RELATED-ISSUE"">
                <xsl:choose>
                  <xsl:when test=""ns0:ISSUE-RELATION/. = 'PREDECESSOR'"">
                    <P>
                      <xsl:text>&lt;PREDECESSOR</xsl:text>
                      <xsl:text>&gt;</xsl:text>
                      <xsl:value-of select=""ns0:ISSUE-REF/."" />
                      <xsl:text>&lt;/PREDECESSOR</xsl:text>
                      <xsl:text>&gt;</xsl:text>
                    </P>
                  </xsl:when>
                  <xsl:when test=""ns0:ISSUE-RELATION/. = 'SUCCESSOR'"">
                    <P>
                      <xsl:text>&lt;SUCCESSOR</xsl:text>
                      <xsl:text>&gt;</xsl:text>
                      <xsl:value-of select=""ns0:ISSUE-REF/."" />
                      <xsl:text>&lt;/SUCCESSOR</xsl:text>
                      <xsl:text>&gt;</xsl:text>
                    </P>
                  </xsl:when>
                  <xsl:otherwise>
                  </xsl:otherwise>
                </xsl:choose>
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
          <EXTERNALEXCHANGEWORKFLOW>
            <xsl:value-of select=""$EXTERNALEXCHANGEWORKFLOW"" />
          </EXTERNALEXCHANGEWORKFLOW>
          <EXTERNAL_ID>
            <xsl:choose>
              <xsl:when test=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO/ns0:COMPANY-DATA-REF/. = 'BMW'"">
                <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO/ns0:ISSUE-ID/."" />
              </xsl:when>
              <xsl:otherwise>
              </xsl:otherwise>
            </xsl:choose>
          </EXTERNAL_ID>
          <EXTERNALTITLE>
            <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:LONG-NAME/."" />
          </EXTERNALTITLE>
          <EXTERNALSTATE_PARALLEL1>
            <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" />
          </EXTERNALSTATE_PARALLEL1>
          <EXTERNALCONVERSATION ACTION=""APPEND"">
            <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-ANNOTATIONS/ns0:ISSUE-ANNOTATION"">
              <P>
                <xsl:text>### </xsl:text>
                <xsl:value-of select=""ns0:DATE/."" />
                <xsl:text># </xsl:text>
                <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" />
                <xsl:text># </xsl:text>
                <xsl:value-of select=""ns0:TEAM-MEMBER-REF/@ID-REF"" />
                <xsl:text> ###</xsl:text>
              </P>
              <P></P>
              <xsl:for-each select=""ns0:ANNOTATION-TEXT/ns0:P"">
                <P>
                  <xsl:value-of select=""."" />
                </P>
                <P></P>
              </xsl:for-each>
            </xsl:for-each>
          </EXTERNALCONVERSATION>
          <EXTERNALLASTIMPORTEDDATE>
            <xsl:value-of select=""$param1"" />
          </EXTERNALLASTIMPORTEDDATE>
          <TAGS ACTION=""MERGE"">
            <TAGS>
              <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO"">
                <xsl:if test=""ns0:COMPANY-DATA-REF/. ='BMW'"">
              <xsl:variable name=""UpperCaseValue"">
                      <xsl:call-template name=""ToUpper"">
                        <xsl:with-param name=""inputString"" select=""ns0:PROJECT-ID/@C"" />
                      </xsl:call-template>
                    </xsl:variable>
                    <xsl:choose>
                      <xsl:when test=""$UpperCaseValue ='LEAD'"">
                        <xsl:text>&lt;Commercial-Pilot&gt;Yes&lt;/Commercial-Pilot&gt;</xsl:text>
                      </xsl:when>
                      <xsl:otherwise>
                        <xsl:text>&lt;Commercial-Pilot&gt;No&lt;/Commercial-Pilot&gt;</xsl:text>
                      </xsl:otherwise>
                    </xsl:choose>  
                 
                </xsl:if>
                </xsl:for-each>
            </TAGS>
          </TAGS>
		  <LIFECYCLESTATE></LIFECYCLESTATE>
		  <EXTERNALASSIGNEE>
			<xsl:attribute name=""ID-REF"">
				<xsl:value-of select=""$IDREF"" />
			</xsl:attribute>
		  </EXTERNALASSIGNEE>
		  <OPERATIONMODE><xsl:text>ASAM-IMPORT</xsl:text></OPERATIONMODE>
		  <OPERATIONCONTEXT><xsl:text>BizTalk</xsl:text></OPERATIONCONTEXT>
        </IRMAP>
      </xsl:if>
    </xsl:for-each>
  </RT_IRMAPS>
</xsl:template>
  <xsl:template name=""ToUpper"">
  <xsl:param name=""inputString"" />
  <xsl:variable name=""smallCase"" select=""'abcdefghijklmnopqrstuvwxyz'"" />
  <xsl:variable name=""upperCase"" select=""'ABCDEFGHIJKLMNOPQRSTUVWXYZ'"" />
<xsl:if test=""$inputString !='' and normalize-space($inputString)!=''"">
    <xsl:value-of select=""translate($inputString,$smallCase,$upperCase)"" />
  </xsl:if>
</xsl:template>
  <xsl:template name=""GetAttachmentsList"">
  <xsl:param name=""param1"" />
  <ATTACHMENTS xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"" TYPE=""ATTACHMENT""> 

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
      <xsl:for-each select=""//ns0:ISSUE-SOLUTION[child::ns0:CATEGORY='PROPOSAL' or child::ns0:CATEGORY='SOLUTION'or child::ns0:CATEGORY='TESTSPECIFICATION' or child::ns0:CATEGORY='CALIBRATION-DATA']/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT[child::ns0:URL!='' and  normalize-space(child::ns0:URL)!='' and not(ns0:URL = preceding-sibling::ns0:ISSUE-RELATED-DOCUMENT/ns0:URL) and not(ns0:URL = //ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)and not(ns0:URL = preceding::ns0:ISSUE-SOLUTION[child::ns0:CATEGORY='PROPOSAL' or child::ns0:CATEGORY='SOLUTION' &#xD;&#xA;			or child::ns0:CATEGORY='TESTSPECIFICATION' or child::ns0:CATEGORY='CALIBRATION-DATA']/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)]"">

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
  <EXTERNALHISTORY ACTION=""APPEND"" xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"">
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
  <xsl:template name=""GetLCS"">  
  <LIFECYCLESTATE xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"" ACTION=""IGNORE"">
<xsl:text></xsl:text>      
  </LIFECYCLESTATE>
</xsl:template>
  <xsl:template name=""GetRleaseLCS"">  
  <LIFECYCLESTATE xmlns:ns0=""http://www.asam.net/schemas/issue/issue310"" ACTION=""IGNORE"">
<xsl:text></xsl:text>      
  </LIFECYCLESTATE>
</xsl:template>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"RB.ROCustomerInterface.Schema.BMW.issue_v3_1_0_sl";
        
        private const global::RB.ROCustomerInterface.Schema.BMW.issue_v3_1_0_sl _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"RB.ROCustomerInterface.Schema.BMW.issue_v3_1_0_sl";
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
