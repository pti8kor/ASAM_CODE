namespace RB.ROCustomerInterface {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.ASAM.issue_v3_0_0_sl", typeof(global::RB.ROCustomerInterface.Schema.ASAM.issue_v3_0_0_sl))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM", typeof(global::RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM))]
    public sealed class RB_RO_AUDIHW_ISSUE_IMF_MAP : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1 userCSharp"" version=""1.0"" xmlns:s1=""http://www.asam.net/schemas/issue/issue300"" xmlns:s0=""http://www.w3.org/XML/1998/namespace"" xmlns:ns0=""http://RB.ROCustomerInterface.RB"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" indent=""yes"" version=""1.0"" method=""xml"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:MSR-ISSUE"" />
  </xsl:template>
  <xsl:template match=""/s1:MSR-ISSUE"">
    <ns0:ASAMISSUE_EXTRACT>
      <RT_VALEX_CONTROLINFO>
        <xsl:for-each select=""s1:ISSUES/s1:ISSUE"">
          <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;IGNORE&quot;)"" />
          <VALEX_CONTROLINFO>
            <xsl:attribute name=""ACTION"">
              <xsl:value-of select=""$var:v1"" />
            </xsl:attribute>
            <OEMEXTERNALSTATE>
              <xsl:value-of select=""s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/text()"" />
            </OEMEXTERNALSTATE>
            <xsl:variable name=""var:v2"" select=""userCSharp:SetExternalExchangeWorkflow(string(s1:CATEGORY/@SI))"" />
            <OEMWORKFLOW>
              <xsl:value-of select=""$var:v2"" />
            </OEMWORKFLOW>
          </VALEX_CONTROLINFO>
        </xsl:for-each>
      </RT_VALEX_CONTROLINFO>
      <RT_CONTACT xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">  	  
     <xsl:for-each select=""//ns0:COMPANY-DATAS/ns0:COMPANY-DATA"">     
		<xsl:if test=""ns0:SHORT-NAME/. = 'Audi' or ns0:SHORT-NAME/. = 'VW' or ns0:SHORT-NAME/. = 'Porsche' or ns0:SHORT-NAME/. = 'Bentley' or ns0:SHORT-NAME/. = 'Bugatti' or ns0:SHORT-NAME/. = 'Lamborghini' or ns0:SHORT-NAME/. = 'Skoda'"">
		<xsl:choose>
			<xsl:when test=""ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:EMAIL/. = ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[2]/ns0:EMAIL/."">
				<CONTACT>
				  <xsl:attribute name=""ID"">
					<xsl:value-of select=""ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/@ID"" />
				  </xsl:attribute>
				  <DBID>0</DBID>
				  <EMAIL>
					<xsl:value-of select=""ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:EMAIL/."" />
				  </EMAIL>
				  <LASTNAME>
					<xsl:value-of select=""normalize-space(substring-before(ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:LONG-NAME/., ','))"" />					
				  </LASTNAME>
				  <FIRSTNAME>
					<xsl:value-of select=""normalize-space(substring-after(ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:LONG-NAME/., ','))"" />					
				  </FIRSTNAME>
				  <PHONENUMBERS>
					<xsl:value-of select=""ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:PHONE/."" />
				  </PHONENUMBERS>
				  <DEPARTMENT>
					<xsl:value-of select=""ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:DEPARTMENT/."" />
				  </DEPARTMENT>
				  <ORGANIZATION>
					 <xsl:value-of select=""ns0:SHORT-NAME/."" />
				  </ORGANIZATION>
				  <ROLE>Ersteller, Aenderungsspezifikateur</ROLE>				  		  
				  <DESCRIPTION />
				  <OPERATIONMODE><xsl:text>ASAM-IMPORT</xsl:text></OPERATIONMODE>
				  <OPERATIONCONTEXT><xsl:text>BizTalk</xsl:text></OPERATIONCONTEXT>
				</CONTACT>
		    </xsl:when>
		   <xsl:otherwise>
			    
			  <xsl:for-each select=""ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER"">
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
						<xsl:value-of select=""ns0:PHONE/."" />
					</PHONENUMBERS>
					<DEPARTMENT>
						<xsl:value-of select=""ns0:DEPARTMENT/."" />
					</DEPARTMENT>
					<ORGANIZATION>
					  <xsl:value-of select=""ancestor::ns0:COMPANY-DATA/ns0:SHORT-NAME/."" />
					</ORGANIZATION>
					<ROLE>
					  <xsl:value-of select=""ns0:ROLES/ns0:ROLE/."" />
					</ROLE>
					<DESCRIPTION />
					<OPERATIONMODE><xsl:text>ASAM-IMPORT</xsl:text></OPERATIONMODE>
					<OPERATIONCONTEXT><xsl:text>BizTalk</xsl:text></OPERATIONCONTEXT>
				 </CONTACT>
			 </xsl:for-each>
		 </xsl:otherwise>
		 </xsl:choose>  
		</xsl:if>		 
    </xsl:for-each>    
</RT_CONTACT>
      <RT_ISSUES>
        <xsl:for-each select=""s1:ISSUES/s1:ISSUE"">
          <xsl:for-each select=""s1:ISSUE-SOLUTIONS"">
            <xsl:for-each select=""s1:ISSUE-SOLUTION"">
              <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;ISS_1&quot;)"" />
              <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
              <ISSUE>
                <xsl:attribute name=""ID"">
                  <xsl:value-of select=""$var:v3"" />
                </xsl:attribute>
                <DBID>
                  <xsl:value-of select=""$var:v4"" />
                </DBID>
                <ID>
                  <xsl:value-of select=""$var:v4"" />
                </ID>
                <TITLE xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
<xsl:variable name=""IssueId"" select=""string-length(normalize-space(//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF = 'Audi' or ns0:COMPANY-DATA-REF ='Bentley' or ns0:COMPANY-DATA-REF ='Bugatti' or ns0:COMPANY-DATA-REF = 'VW' or ns0:COMPANY-DATA-REF = 'Porsche' or ns0:COMPANY-DATA-REF = 'Lamborghini' or ns0:COMPANY-DATA-REF = 'Skoda' ]/ns0:ISSUE-ID))"" />
	<xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO"">  
		<xsl:if test=""ns0:COMPANY-DATA-REF/. = 'Audi' or ns0:COMPANY-DATA-REF/. = 'VW' or ns0:COMPANY-DATA-REF/. ='Porsche' or ns0:COMPANY-DATA-REF/. = 'Bentley' or ns0:COMPANY-DATA-REF/. = 'Bugatti' or ns0:COMPANY-DATA-REF/. = 'Lamborghini' or ns0:COMPANY-DATA-REF/. = 'Skoda' "">
		<P>
			<xsl:choose>								
				<xsl:when test=""$IssueId &lt; 7"">						    						
					<xsl:value-of select=""ns0:COMPANY-DATA-REF/ancestor::ns0:ISSUE/ns0:LONG-NAME"" />								
				</xsl:when>
				
				<xsl:when test=""$IssueId &gt;= 7"">
					<xsl:text>##</xsl:text>
					<xsl:value-of select=""ns0:COMPANY-DATA-REF/ancestor::ns0:ISSUE/ns0:LONG-NAME"" />
					<xsl:text>#</xsl:text>
					<xsl:value-of select=""ns0:COMPANY-DATA-REF/ancestor::ns0:ISSUE/ns0:SHORT-NAME"" />
				</xsl:when>
			</xsl:choose>
		</P>			
		</xsl:if>
		
	</xsl:for-each>
</TITLE>
                <DESCRIPTION xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
    <xsl:variable name=""IssueDescriptions"">
		<P>		
			<xsl:text>----------------------------------------------------------------------------------
For the original OEM-Description refer to ExternalDescription field.
----------------------------------------------------------------------------------
			</xsl:text>
		</P>
    </xsl:variable>
	<xsl:if test=""$IssueDescriptions and not($IssueDescriptions = '')"">
		<P>
			<xsl:value-of select=""$IssueDescriptions"" />
		</P>
	</xsl:if>
</DESCRIPTION>
                <BELONGSTOPROJECT xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
  <xsl:choose>
    <xsl:when test=""//ns0:PRMS/ns0:PRM/ns0:SHORT-NAME ='SG Typ'"">
      <xsl:if test=""//ns0:PRMS/ns0:PRM[child::ns0:SHORT-NAME='SG Typ']/ns0:PRM-CHAR/ns0:TEXT !='' and normalize-space(//ns0:PRMS/ns0:PRM[child::ns0:SHORT-NAME='SG Typ']/ns0:PRM-CHAR/ns0:TEXT)!=''"">
        <xsl:attribute name=""ID-REF"">
          <xsl:text>PRO_1</xsl:text>
        </xsl:attribute>
      </xsl:if>
    </xsl:when>
    <xsl:otherwise></xsl:otherwise>
  </xsl:choose>
</BELONGSTOPROJECT>
                <TYPE xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"" ACTION=""INIT"">
<xsl:choose>		
		<xsl:when test=""//ns0:ISSUES/ns0:ISSUE/ns0:CATEGORY/@SI"">		
			<xsl:choose>
			<xsl:when test=""//ns0:ISSUES/ns0:ISSUE/ns0:CATEGORY/@SI='HARDWARE'"">		
				<xsl:text>Issue HW-ECU</xsl:text>		
			</xsl:when>
			<xsl:otherwise>			
				<xsl:text>Issue SW</xsl:text>		
			</xsl:otherwise>   
		</xsl:choose>	
		</xsl:when>
		<xsl:otherwise>
		<xsl:text>Issue SW</xsl:text>
		</xsl:otherwise>
	</xsl:choose>
</TYPE>
                <DOMAIN xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"" ACTION=""INIT"">	
	<xsl:choose>		
		<xsl:when test=""//ns0:ISSUES/ns0:ISSUE/ns0:CATEGORY/@SI"">		
			<xsl:choose>
			<xsl:when test=""//ns0:ISSUES/ns0:ISSUE/ns0:CATEGORY/@SI='HARDWARE'"">		
				<xsl:text>Hardware</xsl:text>		
			</xsl:when>
			<xsl:otherwise>			
				<xsl:text>Software</xsl:text>		
			</xsl:otherwise>   
		</xsl:choose>	
		</xsl:when>
		<xsl:otherwise>
		<xsl:text>Software</xsl:text>
		</xsl:otherwise>
	</xsl:choose>
</DOMAIN>
                <SCOPE xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"" ACTION=""INIT"">
  <xsl:text>External</xsl:text>      
</SCOPE>
                <xsl:variable name=""var:v5"" select=""userCSharp:SetCategory(string(../../s1:CATEGORY/text()))"" />
                <CATEGORY>
                  <xsl:value-of select=""$var:v5"" />
                </CATEGORY>
                <ISSUE_CATEGORY_FROM_CUSTOMER>
                  <xsl:value-of select=""../../s1:CATEGORY/text()"" />
                </ISSUE_CATEGORY_FROM_CUSTOMER>
                <EXTERNAL_ID xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
 <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF = 'Audi' or ns0:COMPANY-DATA-REF ='Bentley' or ns0:COMPANY-DATA-REF ='Bugatti' or ns0:COMPANY-DATA-REF = 'VW' or ns0:COMPANY-DATA-REF = 'Porsche' or ns0:COMPANY-DATA-REF = 'Skoda' or ns0:COMPANY-DATA-REF = 'Lamborghini' ]/ns0:ISSUE-ID"" />
</EXTERNAL_ID>
                <EXTERNALTITLE>
                  <xsl:value-of select=""../../s1:LONG-NAME/text()"" />
                </EXTERNALTITLE>
                <EXTERNALSTATE_PARALLEL1>
                  <xsl:value-of select=""../../s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/text()"" />
                </EXTERNALSTATE_PARALLEL1>
                <EXTERNALSTATE_PARALLEL2>
                  <xsl:value-of select=""$var:v4"" />
                </EXTERNALSTATE_PARALLEL2>
                <EXTERNALCOMMENT>
                  <xsl:value-of select=""$var:v4"" />
                </EXTERNALCOMMENT>
                <EXTERNALSUBMITTER xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
<xsl:variable name=""IssueId"" select=""string-length(normalize-space(//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF = 'Audi' or ns0:COMPANY-DATA-REF ='Bentley' or ns0:COMPANY-DATA-REF ='Bugatti' or ns0:COMPANY-DATA-REF = 'VW' or ns0:COMPANY-DATA-REF = 'Porsche' or ns0:COMPANY-DATA-REF = 'Skoda' or ns0:COMPANY-DATA-REF = 'Lamborghini' ]/ns0:ISSUE-ID))"" />
<xsl:attribute name=""ID-REF"">
	<xsl:for-each select=""//ns0:COMPANY-DATAS/ns0:COMPANY-DATA"">  
		<xsl:if test=""ns0:SHORT-NAME/. = 'Audi' or ns0:SHORT-NAME/. = 'VW' or ns0:SHORT-NAME/. ='Porsche' or ns0:SHORT-NAME/. = 'Bentley' or ns0:SHORT-NAME/. = 'Bugatti' or ns0:SHORT-NAME/. = 'Lamborghini' or ns0:SHORT-NAME/. = 'Skoda' "">
			<xsl:choose>
				<xsl:when test=""ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:EMAIL/. = ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[2]/ns0:EMAIL/."">
				  <xsl:value-of select=""ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/@ID"" /> 
				</xsl:when>
				<xsl:otherwise>
					<xsl:choose>
						<xsl:when test=""$IssueId &lt; 7"">						    						
							<xsl:value-of select=""ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER/ns0:ROLES/ns0:ROLE[text() = 'Ersteller']/ancestor::ns0:TEAM-MEMBER/@ID"" />								
						</xsl:when>
						
						<xsl:when test=""$IssueId &gt;= 7"">							
							<xsl:value-of select=""ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER/ns0:ROLES/ns0:ROLE[text() = 'Change Responsible']/ancestor::ns0:TEAM-MEMBER/@ID"" />							
						 </xsl:when>
					</xsl:choose>
				</xsl:otherwise>
			  </xsl:choose>
		</xsl:if>
	</xsl:for-each>
</xsl:attribute>
</EXTERNALSUBMITTER>
                <EXTERNALASSIGNEE xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
<xsl:variable name=""IssueId"" select=""string-length(normalize-space(//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF = 'Audi' or ns0:COMPANY-DATA-REF ='Bentley' or ns0:COMPANY-DATA-REF ='Bugatti' or ns0:COMPANY-DATA-REF = 'VW' or ns0:COMPANY-DATA-REF = 'Porsche' or ns0:COMPANY-DATA-REF = 'Skoda' or ns0:COMPANY-DATA-REF = 'Lamborghini' ]/ns0:ISSUE-ID))"" />
<xsl:attribute name=""ID-REF"">
	<xsl:for-each select=""//ns0:COMPANY-DATAS/ns0:COMPANY-DATA"">  
		<xsl:if test=""ns0:SHORT-NAME/. = 'Audi' or ns0:SHORT-NAME/. = 'VW' or ns0:SHORT-NAME/. ='Porsche' or ns0:SHORT-NAME/. = 'Bentley' or ns0:SHORT-NAME/. = 'Bugatti' or ns0:SHORT-NAME/. = 'Skoda' or ns0:SHORT-NAME/. = 'Lamborghini' "">
			<xsl:choose>
				<xsl:when test=""ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:EMAIL/. = ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[2]/ns0:EMAIL/."">
				  <xsl:value-of select=""ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/@ID"" /> 
				</xsl:when>
				<xsl:otherwise>
					<xsl:choose>
						<xsl:when test=""$IssueId &lt; 7"">						    						
							<xsl:value-of select=""ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER/ns0:ROLES/ns0:ROLE[text() = 'Aenderungsspezifikateur']/ancestor::ns0:TEAM-MEMBER/@ID"" />								
						</xsl:when>
						
						<xsl:when test=""$IssueId &gt;= 7"">							
							<xsl:value-of select=""ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER/ns0:ROLES/ns0:ROLE[text() = 'Specifier']/ancestor::ns0:TEAM-MEMBER/@ID"" />							
						 </xsl:when>
					</xsl:choose>
				</xsl:otherwise>
			  </xsl:choose>
		</xsl:if>
	</xsl:for-each>
</xsl:attribute>
</EXTERNALASSIGNEE>
                <EXTERNALORGANISATION>
                  <xsl:value-of select=""../../../../s1:COMPANY-DATAS/s1:COMPANY-DATA/s1:SHORT-NAME/text()"" />
                </EXTERNALORGANISATION>
                <xsl:variable name=""var:v6"" select=""userCSharp:SetExternalReview(string(s1:CATEGORY/text()))"" />
                <EXTERNALREVIEW>
                  <xsl:value-of select=""$var:v6"" />
                </EXTERNALREVIEW>
                <EXTERNALTAGS>
                  <xsl:call-template name=""GETEXTERNALTAG"" />
                </EXTERNALTAGS>
                <EXTERNALDESCRIPTION xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
<P>DESCRIPTION: </P>
    <xsl:for-each select=""//ns0:ISSUE-DESC/ns0:P"">
        <xsl:if test=""position() != 4"">
             <P><xsl:value-of select=""."" /></P>
          </xsl:if>
      </xsl:for-each>
<P></P>
<P>SOLUTION DESCRIPTION: </P>
   <xsl:for-each select=""//ns0:ISSUE-SOLUTIONS/ns0:ISSUE-SOLUTION/ns0:ISSUE-SOLUTION-DESC/ns0:P"">
         <P><xsl:value-of select=""."" /></P>
      </xsl:for-each>
</EXTERNALDESCRIPTION>
                <xsl:call-template name=""GETEXTERNALMILESTONES"" />
                <xsl:variable name=""var:v7"" select=""userCSharp:GetDateInFormat()"" />
                <xsl:call-template name=""ExternalConversation"">
                  <xsl:with-param name=""param1"" select=""string($var:v7)"" />
                </xsl:call-template>
                <xsl:variable name=""var:v8"" select=""userCSharp:SetExternalExchangeWorkflow(string(../../s1:CATEGORY/@SI))"" />
                <EXTERNALEXCHANGEWORKFLOW>
                  <xsl:value-of select=""$var:v8"" />
                </EXTERNALEXCHANGEWORKFLOW>
                <EXTERNALLASTEXPORTEDDATE>
                  <xsl:value-of select=""$var:v4"" />
                </EXTERNALLASTEXPORTEDDATE>
                <xsl:variable name=""var:v9"" select=""userCSharp:GetDateInFormat()"" />
                <EXTERNALLASTIMPORTEDDATE>
                  <xsl:value-of select=""$var:v9"" />
                </EXTERNALLASTIMPORTEDDATE>
                <xsl:variable name=""var:v10"" select=""userCSharp:GetDateInFormat()"" />
                <xsl:call-template name=""GetAttachmentData"">
                  <xsl:with-param name=""param1"" select=""string($var:v10)"" />
                </xsl:call-template>
                <xsl:variable name=""var:v11"" select=""userCSharp:GetDateInFormat()"" />
                <xsl:call-template name=""GetExternalAttachmentData"">
                  <xsl:with-param name=""param1"" select=""string($var:v11)"" />
                </xsl:call-template>
                <COMMERCIALAMOUNT>
                  <xsl:value-of select=""s1:ISSUE-EFFORT/s1:AMOUNT/text()"" />
                </COMMERCIALAMOUNT>
                <COMMERCIALAMOUNTCONFIRMED>
                  <xsl:value-of select=""$var:v4"" />
                </COMMERCIALAMOUNTCONFIRMED>
                <COMMERCIALORIGSOLUTIONACC>
                  <xsl:value-of select=""$var:v4"" />
                </COMMERCIALORIGSOLUTIONACC>
                <xsl:for-each select=""s1:ISSUE-EFFORT"">
                  <xsl:variable name=""var:v12"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
                  <COMMERCIALCOMMENT>
                    <P>
                      <xsl:value-of select=""$var:v12"" />
                    </P>
                    <xsl:value-of select=""s1:AMOUNT/text()"" />
                  </COMMERCIALCOMMENT>
                </xsl:for-each>
                <COMMERCIALCONVERSATION>
                  <xsl:for-each select=""s1:ISSUE-EFFORT"">
                    <P>
                      <xsl:value-of select=""s1:AMOUNT/text()"" />
                    </P>
                  </xsl:for-each>
                </COMMERCIALCONVERSATION>
                <xsl:if test=""../../s1:ISSUE-PROPERTIES/s1:ISSUE-SEVERITY"">
                  <SEVERITY>
                    <xsl:value-of select=""../../s1:ISSUE-PROPERTIES/s1:ISSUE-SEVERITY/text()"" />
                  </SEVERITY>
                </xsl:if>
                <xsl:for-each select=""../../s1:ISSUE-PROPERTIES"">
                  <xsl:variable name=""var:v13"" select=""userCSharp:StringConcat(&quot;APPEND&quot;)"" />
                  <EXTERNALHISTORY>
                    <xsl:attribute name=""ACTION"">
                      <xsl:value-of select=""$var:v13"" />
                    </xsl:attribute>
                    <xsl:variable name=""var:v14"" select=""userCSharp:GetDateInFormat()"" />
                    <xsl:variable name=""var:v15"" select=""userCSharp:StringConcat(string(s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/text()) , &quot; - &quot; , string($var:v14) , &quot; - ExchangeProtocol: &lt;XPROT&gt;&quot;)"" />
                    <xsl:value-of select=""$var:v15"" />
                  </EXTERNALHISTORY>
                </xsl:for-each>
                <xsl:if test=""../../s1:CATEGORY/@SI"">
                  <OEMWORKFLOWTYPE>
                    <xsl:value-of select=""../../s1:CATEGORY/@SI"" />
                  </OEMWORKFLOWTYPE>
                </xsl:if>
                <BELONGSTOPROJECT_TITLE xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
  <xsl:choose>
    <xsl:when test=""//ns0:PRMS/ns0:PRM/ns0:SHORT-NAME ='SG Typ'"">
      <xsl:if test=""//ns0:PRMS/ns0:PRM[child::ns0:SHORT-NAME='SG Typ']/ns0:PRM-CHAR/ns0:TEXT !='' and normalize-space(//ns0:PRMS/ns0:PRM[child::ns0:SHORT-NAME='SG Typ']/ns0:PRM-CHAR/ns0:TEXT) !=''"">
        <xsl:text>ECU-</xsl:text>
        <xsl:value-of select=""//ns0:PRMS/ns0:PRM[child::ns0:SHORT-NAME='SG Typ']/ns0:PRM-CHAR/ns0:TEXT"" />
      </xsl:if>
    </xsl:when>
    <xsl:otherwise></xsl:otherwise>
    </xsl:choose>
</BELONGSTOPROJECT_TITLE>
                <OPERATIONMODE xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
<xsl:text>ASAM-IMPORT</xsl:text>
</OPERATIONMODE>
                <OPERATIONCONTEXT xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
<xsl:text>BizTalk</xsl:text>
</OPERATIONCONTEXT>
                <TAGS ACTION=""MERGE"">
	<TAGS>
		<xsl:text>&lt;AlgorithmsToReview_ChangeComment&gt;Contents-Required-Despite-AlgorithToReview-Did-Not-Change&lt;/AlgorithmsToReview_ChangeComment&gt;</xsl:text>			   
	</TAGS>
</TAGS>
              </ISSUE>
            </xsl:for-each>
          </xsl:for-each>
        </xsl:for-each>
      </RT_ISSUES>
      <RT_PROJECTS xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
  <xsl:choose>
    <xsl:when test=""//ns0:PRMS/ns0:PRM/ns0:SHORT-NAME ='SG Typ'"">
      <xsl:if test=""//ns0:PRMS/ns0:PRM[child::ns0:SHORT-NAME='SG Typ']/ns0:PRM-CHAR/ns0:TEXT !='' and normalize-space(//ns0:PRMS/ns0:PRM[child::ns0:SHORT-NAME='SG Typ']/ns0:PRM-CHAR/ns0:TEXT) !=''"">
        <PROJECT>
          <xsl:attribute name=""ACTION"">
            <xsl:text>IGNORE</xsl:text>
          </xsl:attribute>
          <xsl:attribute name=""ID"">
            <xsl:text>PRO_1</xsl:text>
          </xsl:attribute>
          <DBID>0</DBID>
          <ID>0</ID>
          <DOMAIN>
            <xsl:text>Hardware</xsl:text>
          </DOMAIN>
          <TYPE>
            <xsl:text>Customer Project</xsl:text>
          </TYPE>
          <TITLE>
            <xsl:text>ECU-</xsl:text>
            <xsl:value-of select=""//ns0:PRMS/ns0:PRM[child::ns0:SHORT-NAME='SG Typ']/ns0:PRM-CHAR/ns0:TEXT"" />
          </TITLE>
          <SCOPE>
            <xsl:text>External</xsl:text>
          </SCOPE>
          <CUSTOMER>
            <xsl:text>VW Group</xsl:text>
          </CUSTOMER>
		  <OPERATIONMODE><xsl:text>ASAM-IMPORT</xsl:text></OPERATIONMODE>
		  <OPERATIONCONTEXT><xsl:text>BizTalk</xsl:text></OPERATIONCONTEXT>
        </PROJECT>
      </xsl:if>
    </xsl:when>
    <xsl:otherwise></xsl:otherwise>
  </xsl:choose>
</RT_PROJECTS>
      <RT_RELEASES xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">

  <xsl:variable name=""sgtyp"">
   <xsl:if test=""//ns0:PRMS/ns0:PRM[child::ns0:SHORT-NAME='SG Typ']/ns0:PRM-CHAR/ns0:TEXT !='' and normalize-space(//ns0:PRMS/ns0:PRM[child::ns0:SHORT-NAME='SG Typ']/ns0:PRM-CHAR/ns0:TEXT) !=''"">
    <xsl:value-of select=""//ns0:PRMS/ns0:PRM[child::ns0:SHORT-NAME!='' and child::ns0:SHORT-NAME='SG Typ']/ns0:PRM-CHAR/ns0:TEXT"" />
	</xsl:if>
  </xsl:variable>

  <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-ENVIRONMENT/ns0:ENGINEERING-OBJECTS/ns0:ENGINEERING-OBJECT[@SI='VARIANT' and child::ns0:REVISION-LABELS/ns0:REVISION-LABEL[@SI='TEILENUMMER' or @SI='Partnumber'] != '' and normalize-space(child::ns0:REVISION-LABELS/ns0:REVISION-LABEL[@SI='TEILENUMMER' or @SI='Partnumber'])!='' and not(child::ns0:REVISION-LABELS/ns0:REVISION-LABEL[@SI='TEILENUMMER' or @SI='Partnumber'] = preceding-sibling::ns0:ENGINEERING-OBJECT[@SI='VARIANT']/ns0:REVISION-LABELS/ns0:REVISION-LABEL[@SI='TEILENUMMER' or @SI='Partnumber'])]"">
    <RELEASE>
      <xsl:attribute name=""ID"">
        <xsl:text>REL_</xsl:text>
        <xsl:value-of select=""position()"" />
      </xsl:attribute>
      <DBID>0</DBID>
      <ID>0</ID>
      <DOMAIN ACTION=""INIT"">
        <xsl:text>Hardware</xsl:text>
      </DOMAIN>
      <TYPE ACTION=""INIT"">
        <xsl:text>HW-ECU</xsl:text>
      </TYPE>
      <SCOPE ACTION=""INIT"">
        <xsl:text>External</xsl:text>
      </SCOPE>
      <TITLE>
        <xsl:value-of select=""$sgtyp"" />
      </TITLE>
      <EXTERNAL_ID />
      <PLANNEDDATE />
      <EXTERNALTITLE>
        <xsl:value-of select=""$sgtyp"" />
      </EXTERNALTITLE>
      <BELONGSTOPROJECT>
      </BELONGSTOPROJECT>
      <CATEGORY>
        <xsl:text>Collection</xsl:text>
      </CATEGORY>
	  <OPERATIONMODE><xsl:text>ASAM-IMPORT</xsl:text></OPERATIONMODE>
	  <OPERATIONCONTEXT><xsl:text>BizTalk</xsl:text></OPERATIONCONTEXT>
    </RELEASE>
  </xsl:for-each>

</RT_RELEASES>
      <xsl:for-each select=""s1:ISSUES/s1:ISSUE"">
        <xsl:variable name=""var:v16"" select=""string(s1:CATEGORY/text())"" />
        <xsl:variable name=""var:v17"" select=""userCSharp:SetExternalExchangeWorkflowRT($var:v16)"" />
        <xsl:call-template name=""GetIRMAPSData"">
          <xsl:with-param name=""param1"" select=""string($var:v17)"" />
        </xsl:call-template>
      </xsl:for-each>
    </ns0:ASAMISSUE_EXTRACT>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}


///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

public string SetExternalReview(string param1)
{
	if (param1 == ""Y"")
	{
	    return ""Required"";
	}	
	else
	{
	   return ""Not Required"";
	} 
}


//Setting Category value based on input
// ASAM-Value  --> RQ1 Value
//   CHANGE-REQUEST --> Requirement
//   BUG-REPORT --> Defect
public string SetCategory(string param1)
{
    string sCat = """";
    if (param1.ToUpper() == ""CHANGE-REQUEST"")
   {
           sCat = ""Requirement"";
   }
   else  if (param1.ToUpper() == ""BUG-REPORT"")
   {
       sCat = ""Defect"";   
   }
   else
  { 
       sCat = ""Requirement"";
  }
  return sCat;
}


//Setting Category value based on input
// ASAM-Value  --> RQ1 Value
//   CHANGE-REQUEST --> Requirement
//   BUG-REPORT --> Defect

public string SetExternalExchangeWorkflow(string param1)
{
    string sCat = """";
	if(param1 == ""HARDWARE"")
	{
		sCat = ""VAG_ASAM300_HWRQ"";
	}

  return sCat;
}

public string GetDateInFormat()
{
       // strDate = System.DateTime.Parse(DateTime.Today.ToString()).ToString(""yyyyMMdd"");
          System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo(""de-DE"");
           string strFormatedDateTime = System.DateTime.Parse(DateTime.Now.ToString()).ToString(""dd.MM.yyyy HH:mm:ss"", culture);
           return strFormatedDateTime;
}


public string StringConcat(string param0, string param1, string param2, string param3)
{
   return param0 + param1 + param2 + param3;
}



public string GetAttName(string param1)
{  
    string strAttName=param1;
  string strExtension="""";
     if (strAttName.Length > 50)
    {
         strExtension = strAttName.Substring(strAttName.Length - 4, 4);
         strAttName = strAttName.Substring(0, 45) + ""~"" + strExtension;
    }
     return strAttName;
}



//Setting Category value based on input
// ASAM-Value  --> RQ1 Value
//   CHANGE-REQUEST --> Requirement
//   BUG-REPORT --> Defect
public string SetExternalExchangeWorkflowRT(string param1)
{
    string sCat = """";

       if (param1.ToUpper() == ""CHANGE-REQUEST"")
        {
           sCat =""VAG_ASAM300_FAE"";
        }
        else  if (param1.ToUpper() == ""BUG-REPORT"")
        {
            sCat = ""VAG_ASAM300_BUG"";   
        }
        else
        { 
           sCat = ""VAG_ASAM300_FAE"";
        }
    
  return sCat;
}


]]></msxsl:script>
  <xsl:template name=""ExternalConversation"">
<xsl:param name=""param1"" />
<EXTERNALCONVERSATION xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"" ACTION=""APPEND"">
    <P>### <xsl:value-of select=""$param1"" /> # <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" /> # <xsl:if test=""//ns0:COMPANY-DATA/ns0:SHORT-NAME/. = 'Audi' or //ns0:COMPANY-DATA/ns0:SHORT-NAME/. = 'VW' or //ns0:COMPANY-DATA/ns0:SHORT-NAME/. = 'Porsche' or //ns0:COMPANY-DATA/ns0:SHORT-NAME = 'Bentley' or //ns0:COMPANY-DATA/ns0:SHORT-NAME = 'Bugatti' or //ns0:COMPANY-DATA/ns0:SHORT-NAME = 'Lamborghini' or //ns0:COMPANY-DATA/ns0:SHORT-NAME = 'Skoda' "">
        <xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:EMAIL/."" />
      </xsl:if> ###</P>
    <!-- Copy 4th P NODE to ExternalConversation  -->
    <xsl:for-each select=""//ns0:ISSUE-DESC/ns0:P"">
        <xsl:if test=""position() = 4"">
             <P><xsl:value-of select=""."" /></P>
          </xsl:if>
      </xsl:for-each>
</EXTERNALCONVERSATION>

</xsl:template>
  <xsl:template name=""GETEXTERNALTAG"">
  <EXTERNALTAG xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
  <xsl:variable name=""IssueId"" select=""string-length(normalize-space(//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF = 'Audi' or ns0:COMPANY-DATA-REF ='Bentley' or ns0:COMPANY-DATA-REF ='Bugatti' or ns0:COMPANY-DATA-REF = 'VW' or ns0:COMPANY-DATA-REF = 'Skoda' or ns0:COMPANY-DATA-REF = 'Porsche' or ns0:COMPANY-DATA-REF = 'Lamborghini' ]/ns0:ISSUE-ID))"" />
  
    <xsl:for-each select=""//ns0:PRM"">
      <P>
        <xsl:variable name=""ReplacedValue"">
          <xsl:call-template name=""replaceString"">
            <xsl:with-param name=""text"" select=""ns0:SHORT-NAME/."" />
            <xsl:with-param name=""replace"" select=""':Freitext'"" />
            <xsl:with-param name=""with"" select=""''"" />
          </xsl:call-template>
        </xsl:variable>
        <xsl:value-of select=""$ReplacedValue"" /><xsl:text>:</xsl:text><xsl:value-of select=""ns0:PRM-CHAR/ns0:TEXT/."" />
      </P>
    </xsl:for-each>
    <P>
      <xsl:text>F/P Creation:</xsl:text><xsl:value-of select=""//ns0:DATE/."" />
    </P>
    <xsl:for-each select=""//ns0:COMPANY-DATAS/ns0:COMPANY-DATA"">
      <xsl:choose>
        <xsl:when test=""ns0:SHORT-NAME/. = 'Audi'""></xsl:when>
<xsl:when test=""ns0:SHORT-NAME/. = 'Skoda'""></xsl:when>
        <xsl:when test=""ns0:SHORT-NAME/. = 'VW'""></xsl:when>
		<xsl:when test=""ns0:SHORT-NAME/. = 'Porsche'""></xsl:when>
        <xsl:when test=""ns0:SHORT-NAME = 'Bentley'""></xsl:when>
        <xsl:when test=""ns0:SHORT-NAME = 'Bugatti'""></xsl:when>
		<xsl:when test=""ns0:SHORT-NAME/. = 'Lamborghini'""></xsl:when>
        <xsl:when test=""ns0:SHORT-NAME/. = 'Bosch' or  ns0:SHORT-NAME/. = 'Continental' or ns0:SHORT-NAME/. = 'Delphi' or ns0:SHORT-NAME/. = 'Marelli' "">
          <P>
            <xsl:text>Supplier:</xsl:text><xsl:value-of select=""ns0:SHORT-NAME/."" />
          </P>
        </xsl:when>
        <xsl:otherwise>
        </xsl:otherwise>
      </xsl:choose>
    </xsl:for-each>

	<xsl:for-each select=""//ns0:RELATED-ISSUES/ns0:RELATED-ISSUE"">
		<xsl:if test=""ns0:ISSUE-REF != '' and normalize-space(ns0:ISSUE-REF)!=''"">
		  <P>
			<xsl:text>Related Issue:</xsl:text>
			<xsl:value-of select=""ns0:ISSUE-REF"" />
			<xsl:if test=""$IssueId = 7"">
				<xsl:text>(</xsl:text>
				<xsl:value-of select=""ns0:ISSUE-RELATION"" />
				<xsl:text>)</xsl:text>
			</xsl:if>
		  </P>
		</xsl:if>
	</xsl:for-each>
  </EXTERNALTAG>
</xsl:template>
  <xsl:template name=""replaceString"">
  <xsl:param name=""text"" />
  <xsl:param name=""replace"" />
  <xsl:param name=""with"" />
  <xsl:choose>
    <xsl:when test=""contains($text,$replace)"">
      <xsl:value-of select=""substring-before($text,$replace)"" />
      <xsl:value-of select=""$with"" />
      <xsl:call-template name=""replaceString"">
        <xsl:with-param name=""text"" select=""substring-after($text,$replace)"" />
        <xsl:with-param name=""replace"" select=""$replace"" />
        <xsl:with-param name=""with"" select=""$with"" />
      </xsl:call-template>
    </xsl:when>
    <xsl:otherwise>
      <xsl:value-of select=""$text"" />
    </xsl:otherwise>
  </xsl:choose>
</xsl:template>
  <xsl:template name=""GetIRMAPSData"">
  <xsl:param name=""param1"" />

  <RT_IRMAPS xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
    <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-ENVIRONMENT/ns0:ENGINEERING-OBJECTS/ns0:ENGINEERING-OBJECT[@SI='VARIANT' and not(child::ns0:REVISION-LABELS/ns0:REVISION-LABEL[@SI='TEILENUMMER' or @SI='Partnumber'] = preceding-sibling::ns0:ENGINEERING-OBJECT[@SI='VARIANT']/ns0:REVISION-LABELS/ns0:REVISION-LABEL[@SI='TEILENUMMER' or @SI='Partnumber'])]"">
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
        <ISPILOT>
        </ISPILOT>
        <EXTERNALNEXTSTATE></EXTERNALNEXTSTATE>
        <EXTERNALTAGS>
        </EXTERNALTAGS>
        <EXTERNALEXCHANGEWORKFLOW>
          <xsl:text>VAG_ASAM300_HWRQ</xsl:text>
        </EXTERNALEXCHANGEWORKFLOW>
        <EXTERNALREVIEW>
        </EXTERNALREVIEW>
        <EXTERNAL_ID />
        <EXTERNALTITLE />
        <EXTERNALSTATE_PARALLEL1 />
        <EXTERNALCONVERSATION ACTION=""APPEND"">
          <P />
        </EXTERNALCONVERSATION>
        <MAPPINGTODERIVATIVES>
          <xsl:if test=""//ns0:ISSUES/ns0:ISSUE/ns0:CATEGORY/@SI = 'HARDWARE'"">
            <P>
              <xsl:value-of select=""ns0:REVISION-LABELS/ns0:REVISION-LABEL[@SI='TEILENUMMER' or @SI='Partnumber']"" />
            </P>
          </xsl:if>
        </MAPPINGTODERIVATIVES>
        <LIFECYCLESTATE>
          <xsl:text>New</xsl:text>
        </LIFECYCLESTATE>
		<OPERATIONMODE><xsl:text>ASAM-IMPORT</xsl:text></OPERATIONMODE>
		<OPERATIONCONTEXT><xsl:text>BizTalk</xsl:text></OPERATIONCONTEXT>
      </IRMAP>
    </xsl:for-each>
  </RT_IRMAPS>
</xsl:template>
  <xsl:template name=""GetExternalAttachmentData"">
  <xsl:param name=""param1"" />
  <xsl:variable name=""index"" select=""0"" />
  <EXTERNALEXCHANGEDATTACH xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"" ACTION=""APPEND"">
    <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT[child::ns0:URL !='' and normalize-space(child::ns0:URL)!='' and not(ns0:URL = preceding-sibling::ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)]"">
      <xsl:if test=""position() = 1"">
        <P>
          <xsl:text>### </xsl:text><xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" /><xsl:text> </xsl:text><xsl:value-of select=""$param1"" /><xsl:text> ###</xsl:text></P>
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
  </EXTERNALEXCHANGEDATTACH>
</xsl:template>
  <xsl:template name=""GETEXTERNALMILESTONES"">
  <EXTERNALMILESTONES xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
    <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-ENVIRONMENT/ns0:ENGINEERING-OBJECTS/ns0:ENGINEERING-OBJECT[@SI='VARIANT' and child::ns0:REVISION-LABELS/ns0:REVISION-LABEL[@SI='TEILENUMMER' or @SI='Partnumber'] != '' and normalize-space(child::ns0:REVISION-LABELS/ns0:REVISION-LABEL[@SI='TEILENUMMER' or @SI='Partnumber'])!='' and not(child::ns0:REVISION-LABELS/ns0:REVISION-LABEL[@SI='TEILENUMMER' or @SI='Partnumber'] = preceding-sibling::ns0:ENGINEERING-OBJECT[@SI='VARIANT']/ns0:REVISION-LABELS/ns0:REVISION-LABEL[@SI='TEILENUMMER' or @SI='Partnumber'])]"">
      <xsl:if test=""position() = 1"">
        <P>
          <xsl:text>PartN-Base:ReqDate:PartN-New:Comment</xsl:text>
        </P>
      </xsl:if>
      <P>
        <xsl:value-of select=""ns0:REVISION-LABELS/ns0:REVISION-LABEL[@SI='TEILENUMMER' or @SI='Partnumber']"" />
        <xsl:text>:</xsl:text>
        <xsl:value-of select=""ns0:REVISION-LABELS/ns0:REVISION-LABEL[@SI='DATUM' or @SI='Date']"" />
        <xsl:text>:</xsl:text>
        <xsl:value-of select=""ns0:REVISION-LABELS/ns0:REVISION-LABEL[@SI='TEILENUMMERNEU' or @SI='Partnumber (new)']"" />
        <xsl:text>:</xsl:text>
        <xsl:value-of select=""ns0:REVISION-LABELS/ns0:REVISION-LABEL[@SI='KOMMENTAR' or @SI='Comment']"" />
      </P>
    </xsl:for-each>
  </EXTERNALMILESTONES>
</xsl:template>
  <xsl:template name=""GetAttachmentData"">
 <xsl:param name=""param1"" />
<ATTACHMENTS xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"" TYPE=""ATTACHMENT"">
  <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT[child::ns0:URL!='' and normalize-space(child::ns0:URL)!='' and not(ns0:URL = preceding-sibling::ns0:ISSUE-RELATED-DOCUMENT/ns0:URL)]"">
<ATTACHMENT>
      <NAME><xsl:value-of select=""ns0:URL/."" /></NAME>
<DESCRIPTION>
 <xsl:if test=""not(position()&gt;9)"">
      <P><xsl:text>OrgReqDoc - </xsl:text>ATT00<xsl:value-of select=""position()"" />:<xsl:value-of select=""$param1"" /></P> 
    </xsl:if>
	 <xsl:if test=""position()&gt;9"">
      <P><xsl:text>OrgReqDoc - </xsl:text>ATT0<xsl:value-of select=""position()"" />:<xsl:value-of select=""$param1"" /></P> 
    </xsl:if>
	</DESCRIPTION>
<FULL_NAME>
<xsl:value-of select=""ns0:URL/."" />
</FULL_NAME>
</ATTACHMENT>
    </xsl:for-each>
</ATTACHMENTS>
</xsl:template>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"RB.ROCustomerInterface.Schema.ASAM.issue_v3_0_0_sl";
        
        private const global::RB.ROCustomerInterface.Schema.ASAM.issue_v3_0_0_sl _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"RB.ROCustomerInterface.Schema.ASAM.issue_v3_0_0_sl";
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
