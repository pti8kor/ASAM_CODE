namespace RB.ROCustomerInterface {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.BMW.issue_v3_2_0_sl", typeof(global::RB.ROCustomerInterface.Schema.BMW.issue_v3_2_0_sl))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM", typeof(global::RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM))]
    public sealed class RB_RO_DAIMLER320_ISSUE_IMF_REQUESTED : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
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
    <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;Requirement&quot;)"" />
    <xsl:variable name=""var:v9"" select=""userCSharp:StringConcat(&quot;No&quot;)"" />
    <xsl:variable name=""var:v10"" select=""userCSharp:StringConcat(&quot;ASAM-IMPORT&quot;)"" />
    <xsl:variable name=""var:v11"" select=""userCSharp:StringConcat(&quot;BizTalk&quot;)"" />
    <xsl:variable name=""var:v12"" select=""userCSharp:StringConcat(&quot;INIT&quot;)"" />
    <xsl:variable name=""var:v14"" select=""userCSharp:StringConcat(&quot; - ExchangeProtocol: &lt;XPROT&gt;&quot;)"" />
    <ns0:ASAMISSUE_EXTRACT>
      <RT_VALEX_CONTROLINFO>
        <VALEX_CONTROLINFO>
          <xsl:attribute name=""ACTION"">
            <xsl:value-of select=""$var:v1"" />
          </xsl:attribute>
          <OEMEXTERNALSTATE xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">   
	<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='CHANGE-REQUEST']]/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE"" />  
</OEMEXTERNALSTATE>
          <OEMWORKFLOW xmlns:ns0=""http://www.asam.net/schemas/issue/issue320""> 
  <xsl:choose>
       <xsl:when test=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='CHANGE-REQUEST']]/ns0:ISSUE-PROPERTIES/ns0:ISSUE-INITIATOR/ns0:COMPANY-DATA-REF[@ID-REF='RB'] "">        
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
          <TITLE xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
  <xsl:text>A</xsl:text>
  <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='CHANGE-REQUEST']]/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF='DAIMLER']/ns0:ISSUE-ID"" />
  <xsl:text> - </xsl:text>
  <xsl:value-of select=""//ns0:ISSUE[ns0:CATEGORY[@LEVEL='CHANGE-REQUEST']]/ns0:SHORT-NAME"" />
</TITLE>
          <xsl:call-template name=""SetDescription"" />
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
          <CATEGORY>
            <xsl:value-of select=""$var:v4"" />
          </CATEGORY>
          <EXTERNAL_ID xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
  <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='CHANGE-REQUEST']]/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO"">
    <xsl:if test=""ns0:COMPANY-DATA-REF = 'DAIMLER'"">     
        <xsl:value-of select=""ns0:ISSUE-ID"" />
    </xsl:if>
  </xsl:for-each>
</EXTERNAL_ID>
          <EXTERNALTITLE xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">   
	  <xsl:value-of select=""//ns0:ISSUE[ns0:CATEGORY[@LEVEL='CHANGE-REQUEST']]/ns0:SHORT-NAME"" />      	
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
          <EXTERNALORGANISATION xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">   
   <xsl:for-each select=""//ns0:COMPANY-DATAS/ns0:COMPANY-DATA[@ID='DAIMLER']/ns0:SHORT-NAME"">
        <xsl:value-of select=""."" />   
    </xsl:for-each>
</EXTERNALORGANISATION>
          <xsl:variable name=""var:v5"" select=""userCSharp:GetDateInFormat()"" />
          <xsl:call-template name=""SetExternalDescription"">
            <xsl:with-param name=""param1"" select=""string($var:v5)"" />
          </xsl:call-template>
          <EXTERNALEXCHANGEWORKFLOW xmlns:ns0=""http://www.asam.net/schemas/issue/issue320""> 
    <xsl:choose>
       <xsl:when test=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='CHANGE-REQUEST']]/ns0:ISSUE-PROPERTIES/ns0:ISSUE-INITIATOR/ns0:COMPANY-DATA-REF[@ID-REF='RB'] "">        
  <xsl:text>DAI_ASAM320_SWSP</xsl:text>
        </xsl:when>
       <xsl:otherwise>
         <xsl:text>DAI_ASAM320_SWRQ</xsl:text>
        </xsl:otherwise>
     </xsl:choose>
</EXTERNALEXCHANGEWORKFLOW>
          <xsl:variable name=""var:v6"" select=""userCSharp:GetDateInFormat()"" />
          <EXTERNALLASTIMPORTEDDATE>
            <xsl:value-of select=""$var:v6"" />
          </EXTERNALLASTIMPORTEDDATE>
          <xsl:variable name=""var:v7"" select=""userCSharp:GetDateInFormat()"" />
          <xsl:call-template name=""GetAttachmentsList"">
            <xsl:with-param name=""param1"" select=""string($var:v7)"" />
          </xsl:call-template>
          <xsl:variable name=""var:v8"" select=""userCSharp:GetDateInFormat()"" />
          <xsl:call-template name=""GetExternalAttachmentData"">
            <xsl:with-param name=""param1"" select=""string($var:v8)"" />
          </xsl:call-template>
          <COMMERCIALQUOTATIONREQ>
            <xsl:value-of select=""$var:v9"" />
          </COMMERCIALQUOTATIONREQ>
          <ASILCLASSIFICATION xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"" ACTION=""INIT"">

        <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='CHANGE-REQUEST']]/ns0:ISSUE-PROPERTIES/ns0:PRMS/ns0:PRM[ns0:SHORT-NAME='ASIL-CLASSIFICATION']/ns0:PRM-CHAR/ns0:TEXT"" />     

</ASILCLASSIFICATION>
          <PVER-EXTERNALTITLE xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"" ACTION=""IGNORE"">
  <xsl:variable name=""unique-list"" select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='DAIMLER' and ns0:CATEGORY='RELEASE' and not(ns0:SHORT-LABEL = preceding-sibling::ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='DAIMLER' and ns0:CATEGORY='RELEASE']/ns0:SHORT-LABEL)]/ns0:SHORT-LABEL"" />
  <xsl:for-each select=""$unique-list"">    
        <xsl:value-of select=""//ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL"" />  
  </xsl:for-each>
</PVER-EXTERNALTITLE>
          <INTERNALCOMMENT xmlns:ns0=""http://www.asam.net/schemas/issue/issue320""> 
	<xsl:variable name=""release-list"" select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='DAIMLER' and ns0:CATEGORY='RELEASE' and not(ns0:SHORT-LABEL = preceding-sibling::ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='DAIMLER' and ns0:CATEGORY='RELEASE']/ns0:SHORT-LABEL)]/ns0:SHORT-LABEL"" />
		<xsl:for-each select=""$release-list"">
			<xsl:choose>			
				<xsl:when test=""contains(translate(//ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL, 'abcdefghijklmnopqrstuvwxyz',  'ABCDEFGHIJKLMNOPQRSTUVWXYZ'), 'EVO')"">        
					<xsl:text>&gt;&gt;Attention! New rule: Implementation efforts can only be billed after the ISW is set to Committed! When the ISW isn't yet Committed - please only document the estimated effort  in IFD but &gt;&gt;do not start implementing!

Reason: Mercedes wants to have more control about costs and it might be that a change request will not be ordered after our estimation. In this case we must not have caused implementation efforts for issues that won't be paid by Mercedes.
 
 Please be aware of all these 3 topics (SIL, InMA, AFP):
 ----------------------------------------------------------------------------------
 S I L:
 &gt;&gt; SiL vVeh available!
 There is a released SiL vVeh for productive testing available.
 The SiL vVeh rollout targets to replace HiL and Vehicle testing for requirements-based testing (mainly SwQT).

 -&gt; Released SiL vVeh configuration available with predecessor PVER via SDOM!

  Infos:
 - SiL vVeh for Fn-D
 https://inside-docupedia.bosch.com/confluence/x/NWg9rg 
 ----------------------------------------------------------------------------------
 I n M a:
 InMa supported project. Please use InMa to process this requirement. InMa will automatically generate a Test-PVER during the development phase, which you can use for testing.
 https://rb-wam-ap.bosch.com/method-store/#/method-store/documents/documents/1923/view/ 
 ----------------------------------------------------------------------------------
 A F P - Workflow:
 For all I-FD’s linked to this I-SW ensure that AFP workflow is applied and followed
 ----------------------------------------------------------------------------------
</xsl:text>
				</xsl:when>
				<xsl:otherwise>
					<xsl:text>testing</xsl:text>
				</xsl:otherwise>
			</xsl:choose>
		</xsl:for-each>
</INTERNALCOMMENT>
          <HASPREDECESSOR xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
  <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:RELATED-ISSUES/ns0:RELATED-ISSUE"">
                <xsl:choose>
                  <xsl:when test=""ns0:ISSUE-RELATION/. = 'PREDECESSOR'"">                                        
                      <xsl:value-of select=""ns0:ISSUE-REF/."" />                     
                  </xsl:when>                 
                  <xsl:otherwise>
                  </xsl:otherwise>
                </xsl:choose>
              </xsl:for-each>
</HASPREDECESSOR>
          <OPERATIONMODE>
            <xsl:value-of select=""$var:v10"" />
          </OPERATIONMODE>
          <OPERATIONCONTEXT>
            <xsl:value-of select=""$var:v11"" />
          </OPERATIONCONTEXT>
          <TAGS ACTION=""MERGE"">
	<TAGS>
		<xsl:text>&lt;AlgorithmsToReview_ChangeComment&gt;Contents-Required-Despite-AlgorithToReview-Did-Not-Change&lt;/AlgorithmsToReview_ChangeComment&gt;</xsl:text>			   
	</TAGS>
</TAGS>
          <ASSIGNEE>
            <xsl:attribute name=""ACTION"">
              <xsl:value-of select=""$var:v12"" />
            </xsl:attribute>
          </ASSIGNEE>
        </ISSUE>
      </RT_ISSUES>
      <RT_RELEASES xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
  <xsl:variable name=""unique-list"" select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='DAIMLER' and ns0:CATEGORY='RELEASE' and not(ns0:SHORT-LABEL = preceding-sibling::ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='DAIMLER' and ns0:CATEGORY='RELEASE']/ns0:SHORT-LABEL)]/ns0:SHORT-LABEL"" />
  <xsl:for-each select=""$unique-list"">
    <RELEASE>
      <xsl:attribute name=""ID"">
        <xsl:text>REL_</xsl:text>
        <xsl:value-of select=""position()"" />
      </xsl:attribute>
      <DBID>0</DBID>
      <ID>0</ID>
      <DOMAIN ACTION=""INIT"">
        <xsl:text>Software</xsl:text>
      </DOMAIN>
      <TYPE ACTION=""INIT"">
        <xsl:text>PVER</xsl:text>
      </TYPE>
      <SCOPE ACTION=""INIT"">
        <xsl:text>External</xsl:text>
      </SCOPE>
      <EXTERNAL_ID>
        <xsl:value-of select=""//ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL/@SI"" />
      </EXTERNAL_ID>
      <PLANNEDDATE />
      <EXTERNALTITLE>
        <xsl:value-of select=""//ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL"" />
      </EXTERNALTITLE>
      <BELONGSTOPROJECT>
      </BELONGSTOPROJECT> 
	  <OPERATIONMODE><xsl:text>ASAM-IMPORT</xsl:text></OPERATIONMODE>
	  <OPERATIONCONTEXT><xsl:text>BizTalk</xsl:text></OPERATIONCONTEXT>
    </RELEASE>
  </xsl:for-each>
</RT_RELEASES>
      <xsl:variable name=""var:v13"" select=""userCSharp:GetDateInFormat()"" />
      <xsl:call-template name=""SetIRMAPS"">
        <xsl:with-param name=""DateTime"" select=""string($var:v13)"" />
        <xsl:with-param name=""Xprot"" select=""string($var:v14)"" />
      </xsl:call-template>
    </ns0:ASAMISSUE_EXTRACT>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}


public string GetDateInFormat()
{
      
       // strDate = System.DateTime.Parse(DateTime.Today.ToString()).ToString(""yyyyMMdd"");
          System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo(""de-DE"");
           string strFormatedDateTime = System.DateTime.Parse(DateTime.Now.ToString()).ToString(""dd.MM.yyyy HH:mm:ss"", culture);
           return strFormatedDateTime;
}



]]></msxsl:script>
  <xsl:template name=""GetAttachmentsList"">
  <xsl:param name=""param1"" />
  
  <ATTACHMENTS xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"" TYPE=""ATTACHMENT"">
    <xsl:variable name=""CRattcounter"" select=""count(//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT[child::ns0:URL!='' and normalize-space(child::ns0:URL)!='' and not(ns0:URL = preceding-sibling::ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)])"" />
    <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT[child::ns0:URL!='' and normalize-space(child::ns0:URL)!='' and not(ns0:URL = preceding-sibling::ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)]"">
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
    
    <xsl:variable name=""COattcounter"" select=""count(//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='COMPONENT-ORDER']/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT[child::ns0:URL!='' and normalize-space(child::ns0:URL)!='' and not(ns0:URL = preceding-sibling::ns0:ISSUE-RELATED-DOCUMENT/ns0:URL) and not(ns0:URL = //ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT/ns0:URL) and not(ns0:URL = ancestor::ns0:ISSUE[ns0:CATEGORY/@LEVEL='COMPONENT-ORDER'][1]/preceding-sibling::ns0:ISSUE[ns0:CATEGORY/@LEVEL='COMPONENT-ORDER']/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)])"" />		
    <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='COMPONENT-ORDER']/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT[child::ns0:URL!='' and normalize-space(child::ns0:URL)!='' and not(ns0:URL = preceding-sibling::ns0:ISSUE-RELATED-DOCUMENT/ns0:URL) and not(ns0:URL = //ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT/ns0:URL) and not(ns0:URL = ancestor::ns0:ISSUE[ns0:CATEGORY/@LEVEL='COMPONENT-ORDER'][1]/preceding-sibling::ns0:ISSUE[ns0:CATEGORY/@LEVEL='COMPONENT-ORDER']/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)]"">
      <ATTACHMENT>
        <NAME>
          <xsl:value-of select=""ns0:URL/."" />
        </NAME>
        <DESCRIPTION>
          <xsl:if test=""not(($CRattcounter+position())&gt;9)"">
            <P>
              <xsl:text>OrgReqDoc - </xsl:text>ATT00<xsl:value-of select=""$CRattcounter+position()"" />:<xsl:value-of select=""$param1"" />
            </P>
          </xsl:if>
          <xsl:if test=""($CRattcounter+position())&gt;9"">
            <P>
              <xsl:text>OrgReqDoc - </xsl:text>ATT0<xsl:value-of select=""$CRattcounter+position()"" />:<xsl:value-of select=""$param1"" />
            </P>
          </xsl:if>
        </DESCRIPTION>
        <FULL_NAME>
          <xsl:value-of select=""ns0:URL/."" />
        </FULL_NAME>
      </ATTACHMENT>
    </xsl:for-each>
    
   <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='MODULE-ORDER']/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT[child::ns0:URL!='' and normalize-space(child::ns0:URL)!='' and not(ns0:URL = preceding-sibling::ns0:ISSUE-RELATED-DOCUMENT/ns0:URL) and not(ns0:URL = //ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST' or ns0:CATEGORY/@LEVEL='COMPONENT-ORDER']/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT/ns0:URL) and not(ns0:URL = ancestor::ns0:ISSUE[ns0:CATEGORY/@LEVEL='MODULE-ORDER'][1]/preceding-sibling::ns0:ISSUE[ns0:CATEGORY/@LEVEL='MODULE-ORDER']/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)]"">
      <ATTACHMENT>
        <NAME>
          <xsl:value-of select=""ns0:URL/."" />
        </NAME>
        <DESCRIPTION>
          <xsl:if test=""not(($CRattcounter+$COattcounter+position())&gt;9)"">
            <P>
              <xsl:text>OrgReqDoc - </xsl:text>ATT00<xsl:value-of select=""$CRattcounter+$COattcounter+position()"" />:<xsl:value-of select=""$param1"" />
            </P>
          </xsl:if>
          <xsl:if test=""($CRattcounter+$COattcounter+position())&gt;9"">
            <P>
              <xsl:text>OrgReqDoc - </xsl:text>ATT0<xsl:value-of select=""$CRattcounter+$COattcounter+position()"" />:<xsl:value-of select=""$param1"" />
            </P>
          </xsl:if>
        </DESCRIPTION>
        <FULL_NAME>
          <xsl:value-of select=""ns0:URL/."" />
        </FULL_NAME>
      </ATTACHMENT>
    </xsl:for-each>

  </ATTACHMENTS>
</xsl:template>
  <xsl:template name=""GetExternalAttachmentData"">
  <xsl:param name=""param1"" />
  <EXTERNALEXCHANGEDATTACH xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"" ACTION=""APPEND"">
    <xsl:variable name=""CRattcounter"" select=""count(//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='CHANGE-REQUEST']]/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT[child::ns0:URL!='' and normalize-space(child::ns0:URL)!='' and not(ns0:URL = preceding-sibling::ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)])"" />
    <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='CHANGE-REQUEST']]/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT[child::ns0:URL!='' and normalize-space(child::ns0:URL)!='' and not(ns0:URL = preceding-sibling::ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)]"">
      <xsl:if test=""position() = 1"">
        <P>
          <xsl:text>### </xsl:text>
          <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='CHANGE-REQUEST']]/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" />
          <xsl:text> </xsl:text>
          <xsl:value-of select=""$param1"" />
          <xsl:text> ###</xsl:text>
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

    <xsl:variable name=""COattcounter"" select=""count(//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='COMPONENT-ORDER']]/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT[child::ns0:URL!='' and normalize-space(child::ns0:URL)!='' and not(ns0:URL = preceding-sibling::ns0:ISSUE-RELATED-DOCUMENT/ns0:URL) and not(ns0:URL = //ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='CHANGE-REQUEST']]/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT/ns0:URL) and not(ns0:URL = ancestor::ns0:ISSUE[ns0:CATEGORY[@LEVEL='COMPONENT-ORDER']][1]/preceding-sibling::ns0:ISSUE[ns0:CATEGORY[@LEVEL='COMPONENT-ORDER']]/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)])"" />		
    <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='COMPONENT-ORDER']]/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT[child::ns0:URL!='' and normalize-space(child::ns0:URL)!='' and not(ns0:URL = preceding-sibling::ns0:ISSUE-RELATED-DOCUMENT/ns0:URL) and not(ns0:URL = //ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='CHANGE-REQUEST']]/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT/ns0:URL) and not(ns0:URL = ancestor::ns0:ISSUE[ns0:CATEGORY[@LEVEL='COMPONENT-ORDER']][1]/preceding-sibling::ns0:ISSUE[ns0:CATEGORY[@LEVEL='COMPONENT-ORDER']]/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)]"">

      <xsl:if test=""$CRattcounter+position() = 1"">
        <P>
          <xsl:text>### </xsl:text>
          <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='COMPONENT-ORDER']]/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" />
          <xsl:text> </xsl:text>
          <xsl:value-of select=""$param1"" />
          <xsl:text> ###</xsl:text>
        </P>
      </xsl:if>
      <xsl:if test=""not($CRattcounter+position()&gt;9)"">
        <P>
          <xsl:text>ATT00</xsl:text><xsl:value-of select=""$CRattcounter+position()"" />:<xsl:value-of select=""$param1"" /><xsl:text> - </xsl:text><xsl:value-of select=""ns0:URL/."" />
        </P>

      </xsl:if>
      <xsl:if test=""$CRattcounter+position()&gt;9"">
        <P>
          <xsl:text>ATT0</xsl:text><xsl:value-of select=""$CRattcounter+position()"" />:<xsl:value-of select=""$param1"" /><xsl:text> - </xsl:text><xsl:value-of select=""ns0:URL/."" />
        </P>

      </xsl:if>

    </xsl:for-each>

    <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='MODULE-ORDER']]/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT[child::ns0:URL!='' and normalize-space(child::ns0:URL)!='' and not(ns0:URL = preceding-sibling::ns0:ISSUE-RELATED-DOCUMENT/ns0:URL) and not(ns0:URL = //ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='CHANGE-REQUEST'] or ns0:CATEGORY[@LEVEL='COMPONENT-ORDER']]/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT/ns0:URL) and not(ns0:URL = ancestor::ns0:ISSUE[ns0:CATEGORY[@LEVEL='MODULE-ORDER']][1]/preceding-sibling::ns0:ISSUE[ns0:CATEGORY[@LEVEL='MODULE-ORDER']]/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)]"">

      <xsl:if test=""$CRattcounter+$COattcounter+position() = 1"">
        <P>
          <xsl:text>### </xsl:text>
          <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='MODULE-ORDER']]/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" />
          <xsl:text> </xsl:text>
          <xsl:value-of select=""$param1"" />
          <xsl:text> ###</xsl:text>
        </P>
      </xsl:if>
      <xsl:if test=""not($CRattcounter+$COattcounter+position()&gt;9)"">
        <P>
          <xsl:text>ATT00</xsl:text><xsl:value-of select=""$CRattcounter+$COattcounter+position()"" />:<xsl:value-of select=""$param1"" /><xsl:text> - </xsl:text><xsl:value-of select=""ns0:URL/."" />
        </P>

      </xsl:if>
      <xsl:if test=""$CRattcounter+$COattcounter+position()&gt;9"">
        <P>
          <xsl:text>ATT0</xsl:text><xsl:value-of select=""$CRattcounter+$COattcounter+position()"" />:<xsl:value-of select=""$param1"" /><xsl:text> - </xsl:text><xsl:value-of select=""ns0:URL/."" />
        </P>

      </xsl:if>

    </xsl:for-each>

  </EXTERNALEXCHANGEDATTACH>
</xsl:template>
  <xsl:template name=""SetExternalHistory"">
  <xsl:param name=""param1"" />
  <xsl:param name=""param2"" />
  <EXTERNALHISTORY ACTION=""APPEND"" xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
    <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" />
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
  <xsl:template name=""SetIRMAPS"">
    <xsl:param name=""DateTime"" />  
    <xsl:param name=""Xprot"" />


    <RT_IRMAPS xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
        <xsl:variable name=""unique-list"" select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='DAIMLER' and ns0:CATEGORY='RELEASE' and not(ns0:SHORT-LABEL = preceding-sibling::ns0:DELIVERY-MILESTONE[ns0:COMPANY-DATA-REF='DAIMLER' and ns0:CATEGORY='RELEASE']/ns0:SHORT-LABEL)]/ns0:SHORT-LABEL"" />
        <xsl:for-each select=""$unique-list"">
            <xsl:variable name=""idx"" select=""position()"" />
            <IRMAP>
                <DBID>
                </DBID>
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

               <EXTERNALTAGS ACTION=""APPEND"">
                    <EXTERNALTAG>
                        <P>
              &lt;IMPORT STATE=""REQUESTED"" TIME=""<xsl:value-of select=""translate($DateTime,'-T','. ')"" />""&gt;
                        </P>
                        <P>
                            <xsl:text>&lt;APSKS&gt;</xsl:text>
                        </P>
                        <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='COMPONENT-ORDER']"">
                            <xsl:variable name=""APSKid"">
                                <xsl:value-of select=""ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF='DAIMLER']/ns0:ISSUE-ID"" />
                            </xsl:variable>
                            <P>
                                <xsl:text />
                                <xsl:text>&lt;APSK ID=""</xsl:text>
                                <xsl:value-of select=""ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF='DAIMLER']/ns0:ISSUE-ID"" />
                                <xsl:text>""&gt;</xsl:text>
                            </P>
                            <P>
                                <xsl:text />
                                <xsl:text>&lt;STATE&gt;</xsl:text>
                                <xsl:value-of select=""ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE"" />
                                <xsl:text>&lt;/STATE&gt;</xsl:text>
                            </P>
                            <P>
                                <xsl:text />
                                <xsl:text>&lt;NAME&gt;</xsl:text>
                                <xsl:value-of select=""ns0:SHORT-NAME"" />
                                <xsl:text>&lt;/NAME&gt;</xsl:text>
                            </P>
                            <P>
                                <xsl:text />
                                <xsl:text>&lt;ASIL&gt;</xsl:text>
                                <xsl:value-of select=""ns0:ISSUE-PROPERTIES/ns0:PRMS/ns0:PRM[ns0:SHORT-NAME='ASIL-CLASSIFICATION']/ns0:PRM-CHAR/ns0:TEXT"" />
                                <xsl:text>&lt;/ASIL&gt;</xsl:text>
                            </P>
                            <P>
                                <xsl:text />
                                <xsl:text>&lt;RESPONSIBLE&gt;</xsl:text>
                                <xsl:variable name=""Responsibletemp"" select=""ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:TEAM-MEMBER-REF/@ID-REF"" />
                                <xsl:value-of select=""//ns0:COMPANY-DATAS/ns0:COMPANY-DATA/ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[@ID= $Responsibletemp]/ns0:LONG-NAME"" />
                                <xsl:text>&lt;/RESPONSIBLE&gt;</xsl:text>
                            </P>
                            <P>
                                <xsl:text />
                                <xsl:text>&lt;COMMENT&gt;</xsl:text>
                                <xsl:for-each select=""ns0:ISSUE-ANNOTATIONS/ns0:ISSUE-ANNOTATION/ns0:ANNOTATION-TEXT/ns0:P"">
                                    <xsl:text>&lt;P&gt;</xsl:text>
                                    <xsl:value-of select=""."" />
                                    <xsl:text>&lt;/P&gt;</xsl:text>
                                </xsl:for-each>
                                <xsl:text>&lt;/COMMENT&gt;</xsl:text>
                            </P>
                            <P>
                                <xsl:text />
                                <xsl:text>&lt;CLARIFICATION-STATUS&gt;</xsl:text>
                                <xsl:text>&lt;/CLARIFICATION-STATUS&gt;</xsl:text>
                            </P>
                            <P>
                                <xsl:text />
                                <xsl:text>&lt;APSMS&gt;</xsl:text>
                            </P>
                            <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='MODULE-ORDER' and normalize-space(ns0:RELATED-ISSUES/ns0:RELATED-ISSUE[ns0:ISSUE-RELATION='PARENT']/ns0:ISSUE-REF) = $APSKid]"">
                                <P>
                                    <xsl:text />
                                    <xsl:text>&lt;APSM ID=""</xsl:text>
                                    <xsl:value-of select=""ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF='DAIMLER']/ns0:ISSUE-ID"" />
                                    <xsl:text>""&gt;</xsl:text>
                                </P>
                                <P>
                                    <xsl:text />
                                    <xsl:text>&lt;STATE&gt;</xsl:text>
                                    <xsl:value-of select=""ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE"" />
                                    <xsl:text>&lt;/STATE&gt;</xsl:text>
                                </P>
                                <P>
                                    <xsl:text />
                                    <xsl:text>&lt;NAME&gt;</xsl:text>
                                    <xsl:value-of select=""ns0:SHORT-NAME"" />
                                    <xsl:text>&lt;/NAME&gt;</xsl:text>
                                </P>
                                <P>
                                    <xsl:text />
                                    <xsl:text>&lt;ASIL&gt;</xsl:text>
                                    <xsl:value-of select=""ns0:ISSUE-PROPERTIES/ns0:PRMS/ns0:PRM[ns0:SHORT-NAME='ASIL-CLASSIFICATION']/ns0:PRM-CHAR/ns0:TEXT"" />
                                    <xsl:text>&lt;/ASIL&gt;</xsl:text>
                                </P>
                                <P>
                                    <xsl:text />
                                    <xsl:text>&lt;RESPONSIBLE&gt;</xsl:text>
                                    <xsl:variable name=""Responsibletemp"" select=""ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:TEAM-MEMBER-REF/@ID-REF"" />
                                    <xsl:value-of select=""//ns0:COMPANY-DATAS/ns0:COMPANY-DATA/ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[@ID= $Responsibletemp]/ns0:LONG-NAME"" />
                                    <xsl:text>&lt;/RESPONSIBLE&gt;</xsl:text>
                                </P>
                                <P>
                                    <xsl:text />
                                    <xsl:text>&lt;COMMENT&gt;</xsl:text>
                                    <xsl:for-each select=""ns0:ISSUE-ANNOTATIONS/ns0:ISSUE-ANNOTATION/ns0:ANNOTATION-TEXT/ns0:P"">
                                        <xsl:text>&lt;P&gt;</xsl:text>
                                        <xsl:value-of select=""."" />
                                        <xsl:text>&lt;/P&gt;</xsl:text>
                                    </xsl:for-each>
                                    <xsl:text>&lt;/COMMENT&gt;</xsl:text>
                                </P>
                                <P>
                                    <xsl:text />
                                    <xsl:text>&lt;CLARIFICATION-STATUS&gt;</xsl:text>
                                    <xsl:text>&lt;/CLARIFICATION-STATUS&gt;</xsl:text>
                                </P>
                                <P>
                                    <xsl:text />
                                    <xsl:text>&lt;/APSM&gt;</xsl:text>
                                </P>
                            </xsl:for-each>
                            <P>
                                <xsl:text />
                                <xsl:text>&lt;/APSMS&gt;</xsl:text>
                            </P>
                            <P>
                                <xsl:text />
                                <xsl:text>&lt;/APSK&gt;</xsl:text>
                            </P>
                        </xsl:for-each>
                        <P>
                            <xsl:text>&lt;/APSKS&gt;</xsl:text>
                        </P>
                        <P>
                            <xsl:text>&lt;/IMPORT&gt;</xsl:text>
                        </P>
                    </EXTERNALTAG>
                </EXTERNALTAGS>


                <EXTERNALEXCHANGEWORKFLOW>
                    <xsl:choose>
                        <xsl:when test=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-INITIATOR/ns0:COMPANY-DATA-REF[@ID-REF='RB'] "">        
                            <xsl:text>DAI_ASAM320_SWSP</xsl:text>
                        </xsl:when>
                        <xsl:otherwise><xsl:text>DAI_ASAM320_SWRQ</xsl:text></xsl:otherwise>
                    </xsl:choose>
                </EXTERNALEXCHANGEWORKFLOW>

               <EXTERNALSTATE_PARALLEL1>
                    <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE"" />
                </EXTERNALSTATE_PARALLEL1>
               

               <EXTERNALCONVERSATION ACTION=""APPEND"">

                   <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-ANNOTATIONS/ns0:ISSUE-ANNOTATION"">
                        <xsl:variable name=""SIattr"" select=""@SI"" />
                        <xsl:choose>
                            <xsl:when test=""@SI"">
                                <xsl:if test=""@SI= 'LINKSTAND-KOMMENTAR' or @SI='AUTO-GENERATED'"">
                                    <P>
                                        <xsl:text>### </xsl:text>
                                        <xsl:value-of select=""$DateTime"" />
                                        <xsl:text> # </xsl:text>
                                        <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE"" />
                                        <xsl:text> # </xsl:text>
                                        <xsl:value-of select=""ns0:TEAM-MEMBER-REF/@ID-REF"" />
                                        <xsl:text> ###</xsl:text>
                                    </P>
                                    <xsl:variable name=""counter"" select=""count(ns0:ANNOTATION-TEXT/ns0:P)"" />
                                    <xsl:if test=""$counter=0 and $SIattr='AUTO-GENERATED'"">
                                        <P>
                                            <xsl:text>AUTO-GENERATED:: </xsl:text>
                                        </P>
                                    </xsl:if>
                                    <xsl:if test=""not($counter=0)"">
                                        <xsl:for-each select=""ns0:ANNOTATION-TEXT/ns0:P"">
                                            <xsl:choose>
                                                <xsl:when test=""$SIattr='AUTO-GENERATED' and position()=1"">
                                                    <P>
                                                        <xsl:text>AUTO-GENERATED:: </xsl:text>
                                                        <xsl:value-of select=""normalize-space(.)"" />
                                                    </P>
                                                </xsl:when>
                                                <xsl:otherwise>
                                                    <P>
                                                        <xsl:value-of select=""normalize-space(.)"" />
                                                    </P>
                                                </xsl:otherwise>
                                            </xsl:choose>
                                        </xsl:for-each>
                                    </xsl:if>

                               </xsl:if>
                            </xsl:when>
                            <xsl:otherwise>
                                <P>
                                    <xsl:text>### </xsl:text>
                                    <xsl:value-of select=""$DateTime"" />
                                    <xsl:text> # </xsl:text>
                                    <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='CHANGE-REQUEST']/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE"" />
                                    <xsl:text> # </xsl:text>
                                    <xsl:value-of select=""ns0:TEAM-MEMBER-REF/@ID-REF"" />
                                    <xsl:text> ###</xsl:text>
                                </P>
                                <xsl:for-each select=""ns0:ANNOTATION-TEXT/ns0:P"">
                                    <P>
                                        <xsl:value-of select=""normalize-space(.)"" />
                                    </P>
                                </xsl:for-each>
                            </xsl:otherwise>
                        </xsl:choose>
                    </xsl:for-each>

               </EXTERNALCONVERSATION>

               <QUALIFICATIONSTATUS>
                    <xsl:text>Not Required</xsl:text>
                </QUALIFICATIONSTATUS>

               <EXTERNALUPDATEVERSION>
                    <xsl:text>DAI00#RB00</xsl:text>
                </EXTERNALUPDATEVERSION>
                <WORKFLOWSTATUS>Waiting</WORKFLOWSTATUS>
                <EXTERNALNEXTSTATE ACTION=""DELETE"">
                    <xsl:text />
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
            </IRMAP>
        </xsl:for-each>
    </RT_IRMAPS>

</xsl:template>
  <xsl:template name=""SetExternalDescription"">
<xsl:param name=""param1"" />
<EXTERNALDESCRIPTION xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">	
	<xsl:variable name=""IssueDescriptions"">
		<P>		
			<xsl:value-of select=""concat('&lt;OEM-DESCRIPTION DATE=&quot;',$param1,'&quot;&gt;&#xD;&#xA;')"" />				
		</P>
		<xsl:for-each select=""//ns0:ISSUE[ns0:CATEGORY[@LEVEL='CHANGE-REQUEST']]/ns0:ISSUE-DESC/ns0:P"">    
			<P>
				<xsl:value-of select="".&#xD;&#xA;"" />		
			</P> 	 	
		</xsl:for-each>
		<P>		
			<xsl:text>
&lt;/OEM-DESCRIPTION&gt;
</xsl:text>
		</P>
    </xsl:variable>
	
	<xsl:variable name=""InternalComments"">
	
	 <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE"">
	 
	 <xsl:if test=""(ns0:CATEGORY/@LEVEL='COMPONENT-ORDER') "">
			
		<xsl:variable name=""IssueID"" select=""ns0:ISSUE-ID"" />
		<xsl:variable name=""IssueDescription"" select=""ns0:ISSUE-DESC"" />
		<xsl:variable name=""IssuePosition"" select=""position()"" />

		<xsl:variable name=""MatchedIssueIDs"">
		  <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY/@LEVEL='COMPONENT-ORDER']"">
			<xsl:if test=""(position()&lt;$IssuePosition and ns0:ISSUE-DESC=$IssueDescription) "">
			  <xsl:value-of select=""ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF = 'DAIMLER']/ns0:ISSUE-ID"" />
			  <xsl:text>,</xsl:text>
			</xsl:if>
		  </xsl:for-each>
		</xsl:variable>

		<xsl:variable name=""FirstMatchedIssueID"">
		  <xsl:value-of select=""substring-before($MatchedIssueIDs,',')"" />
		</xsl:variable>

		<xsl:variable name=""Responsibletemp"" select=""ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:TEAM-MEMBER-REF/@ID-REF"" />
		<P>
		  <xsl:text>

BC : </xsl:text>
		  <xsl:value-of select=""ns0:SHORT-NAME"" />
		  <xsl:text> ---------------------------------------------------------------------------------------------</xsl:text>
		</P>
		<P>
		  <xsl:text>
Responsible: ""</xsl:text>
		  <xsl:value-of select=""//ns0:COMPANY-DATAS/ns0:COMPANY-DATA/ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[@ID= $Responsibletemp]/ns0:LONG-NAME"" />
		  <xsl:text>""</xsl:text>
		</P>

		<xsl:choose>
		  <xsl:when test=""not(ns0:ISSUE-DESC = preceding-sibling::ns0:ISSUE[ns0:CATEGORY/@LEVEL='COMPONENT-ORDER']/ns0:ISSUE-DESC)"">

			<xsl:variable name=""counter"" select=""count(ns0:ISSUE-DESC/ns0:P)"" />
			<xsl:for-each select=""ns0:ISSUE-DESC/ns0:P"">
			  <xsl:choose>
				<xsl:when test=""$counter=1"">
				  <P>
					<xsl:text>
Description: </xsl:text>
					<xsl:text>""</xsl:text>
					<xsl:value-of select=""."" />
					<xsl:text>""</xsl:text>
				  </P>
				</xsl:when>
				<xsl:when test=""position()=1"">
				  <P>
					<xsl:text>
Description: </xsl:text>
					<xsl:text>""</xsl:text>
					<xsl:value-of select=""."" />
				  </P>
				</xsl:when>
				<xsl:when test=""position()=$counter"">
				  <P>
					<xsl:value-of select=""."" />
					<xsl:text>""</xsl:text>
				  </P>
				</xsl:when>
				<xsl:otherwise>
				  <P>
					<xsl:value-of select=""."" />
				  </P>
				</xsl:otherwise>
			  </xsl:choose>
			</xsl:for-each>

		  </xsl:when>
		  <xsl:otherwise>
			<P>
			  <xsl:text>
Description: </xsl:text>
			  <xsl:text>""siehe BC: </xsl:text>
			  <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF = 'DAIMLER']/ns0:ISSUE-ID=$FirstMatchedIssueID ]/ns0:SHORT-NAME"" />
			  <xsl:text>""</xsl:text>
			</P>
		  </xsl:otherwise>
		</xsl:choose>			
			
	 </xsl:if>	

	<xsl:if test=""(ns0:CATEGORY/@LEVEL='MODULE-ORDER') "">
	
	<xsl:variable name=""IssueDescription"" select=""ns0:ISSUE-DESC"" />
		<xsl:variable name=""IssuePosition"" select=""position()"" />

		<xsl:variable name=""MatchedIssueIDs"">
		  <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='COMPONENT-ORDER']]"">
			<xsl:if test=""(ns0:ISSUE-DESC=$IssueDescription) "">
			  <xsl:value-of select=""ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF ='DAIMLER']/ns0:ISSUE-ID"" />
			  <xsl:text>,</xsl:text>
			</xsl:if>
		  </xsl:for-each>
		  <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE[ns0:CATEGORY[@LEVEL='MODULE-ORDER']]"">
			<xsl:if test=""(position()&lt;$IssuePosition and ns0:ISSUE-DESC=$IssueDescription) "">
			  <xsl:value-of select=""ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF ='DAIMLER']/ns0:ISSUE-ID"" />
			  <xsl:text>,</xsl:text>
			</xsl:if>
		  </xsl:for-each>
		</xsl:variable>

		<xsl:variable name=""FirstMatchedIssueID"">
		  <xsl:value-of select=""substring-before($MatchedIssueIDs,',')"" />
		</xsl:variable>


		<xsl:variable name=""Responsibletemp"" select=""ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:TEAM-MEMBER-REF/@ID-REF"" />
		<P>
		  <xsl:text>

FC : </xsl:text>
		  <xsl:value-of select=""ns0:SHORT-NAME"" />
		  <xsl:text> ---------------------------------------------------------------------------------------------</xsl:text>
		</P>
		<P>
		  <xsl:text>
Responsible: ""</xsl:text>
		  <xsl:value-of select=""//ns0:COMPANY-DATAS/ns0:COMPANY-DATA/ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[@ID= $Responsibletemp]/ns0:LONG-NAME"" />
		  <xsl:text>""</xsl:text>
		</P>

		<xsl:choose>
		  <xsl:when test=""not(ns0:ISSUE-DESC = preceding-sibling::ns0:ISSUE[not(ns0:CATEGORY/@LEVEL='CHANGE-REQUEST')]/ns0:ISSUE-DESC)"">
			<xsl:variable name=""counter"" select=""count(ns0:ISSUE-DESC/ns0:P)"" />
			<xsl:for-each select=""ns0:ISSUE-DESC/ns0:P"">
			  <xsl:choose>
				<xsl:when test=""$counter=1"">
				  <P>
				    <xsl:text>
Description: </xsl:text>
					<xsl:text>""</xsl:text>
					<xsl:value-of select=""."" />
					<xsl:text>""</xsl:text>
				  </P>
				</xsl:when>
				<xsl:when test=""position()=1"">
				  <P>
				    <xsl:text>
Description: </xsl:text>
					<xsl:text>""</xsl:text>
					<xsl:value-of select=""."" />
				  </P>
				</xsl:when>
				<xsl:when test=""position()=$counter"">
				  <P>
					<xsl:value-of select=""."" />
					<xsl:text>""</xsl:text>
				  </P>
				</xsl:when>
				<xsl:otherwise>
				  <P>
					<xsl:value-of select=""."" />
				  </P>
				</xsl:otherwise>
			  </xsl:choose>
			</xsl:for-each>

		  </xsl:when>
		  <xsl:otherwise>
			<P>
			  <xsl:text>
Description: </xsl:text>
			  <xsl:choose>
				<xsl:when test=""//ns0:ISSUES/ns0:ISSUE[ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF = 'DAIMLER']/ns0:ISSUE-ID=$FirstMatchedIssueID]/ns0:CATEGORY/@LEVEL ='COMPONENT-ORDER'"">
				  <xsl:text>""siehe BC: </xsl:text>
				</xsl:when>
				<xsl:otherwise>
				  <xsl:text>""siehe FC: </xsl:text>
				</xsl:otherwise>
			  </xsl:choose>
			  <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE[ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF = 'DAIMLER']/ns0:ISSUE-ID=$FirstMatchedIssueID ]/ns0:SHORT-NAME"" />
			  <xsl:text>""</xsl:text>
			</P>
		  </xsl:otherwise>
		</xsl:choose>
	
	</xsl:if>

	 
	 </xsl:for-each>  
  </xsl:variable>
   
  <xsl:if test=""$IssueDescriptions and not($IssueDescriptions = '')"">
	<P>
	<xsl:value-of select=""$IssueDescriptions"" />
	</P>
	<P>
	<xsl:value-of select=""$InternalComments"" />
	</P>
  </xsl:if>
</EXTERNALDESCRIPTION>
</xsl:template>
  <xsl:template name=""SetDescription"">
  <DESCRIPTION xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"" ACTION=""MERGE"">   
	<xsl:variable name=""IssueDescription"">
		<xsl:for-each select=""//ns0:ISSUE[ns0:CATEGORY[@LEVEL='CHANGE-REQUEST']]/ns0:ISSUE-DESC/ns0:P""> 	
			<P>	
				<xsl:text>----------------------------------------------------------------------------------
For the original OEM-Description refer to ExternalDescription field.
----------------------------------------------------------------------------------
				</xsl:text>
			</P> 	 	
		</xsl:for-each>
	</xsl:variable>
	<xsl:if test=""$IssueDescription and not($IssueDescription = '')"">
		<P>
			<xsl:value-of select=""$IssueDescription"" />
		</P>
	
	</xsl:if>
  </DESCRIPTION>
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
