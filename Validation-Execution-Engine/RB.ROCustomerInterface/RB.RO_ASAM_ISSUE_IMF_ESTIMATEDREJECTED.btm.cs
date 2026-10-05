namespace RB.ROCustomerInterface {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.ASAM.issue_v3_0_0_sl", typeof(global::RB.ROCustomerInterface.Schema.ASAM.issue_v3_0_0_sl))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM", typeof(global::RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM))]
    public sealed class RB_RO_ASAM_ISSUE_IMF_ESTIMATEDREJECTED : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1 userCSharp"" version=""1.0"" xmlns:s1=""http://www.asam.net/schemas/issue/issue300"" xmlns:s0=""http://www.w3.org/XML/1998/namespace"" xmlns:ns0=""http://RB.ROCustomerInterface.RB"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" indent=""yes"" version=""1.0"" method=""xml"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:MSR-ISSUE"" />
  </xsl:template>
  <xsl:template match=""/s1:MSR-ISSUE"">
    <xsl:variable name=""var:v17"" select=""userCSharp:StringConcat(&quot;COM001&quot;)"" />
    <xsl:variable name=""var:v18"" select=""userCSharp:StringConcat(&quot;ISS_1&quot;)"" />
    <xsl:variable name=""var:v21"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
    <ns0:ASAMISSUE_EXTRACT>
      <RT_VALEX_CONTROLINFO>
        <xsl:for-each select=""s1:ISSUES/s1:ISSUE"">
          <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;IGNORE&quot;)"" />
          <VALEX_CONTROLINFO>
            <xsl:attribute name=""ACTION"">
              <xsl:value-of select=""$var:v1"" />
            </xsl:attribute>
            <xsl:variable name=""var:v2"" select=""userCSharp:SetExternalExchangeParallel1(string(s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/text()) , string(s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/@SI))"" />
            <OEMEXTERNALSTATE>
              <xsl:value-of select=""$var:v2"" />
            </OEMEXTERNALSTATE>
            <xsl:variable name=""var:v3"" select=""userCSharp:SetOEMWorkflow(string(s1:CATEGORY/text()) , string(s1:CATEGORY/@SI))"" />
            <OEMWORKFLOW>
              <xsl:value-of select=""$var:v3"" />
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
          <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;ISS_1&quot;)"" />
          <xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
          <xsl:variable name=""var:v6"" select=""string(s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/text())"" />
          <xsl:variable name=""var:v7"" select=""string(s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/@SI)"" />
          <xsl:variable name=""var:v13"" select=""userCSharp:StringConcat(&quot;APPEND&quot;)"" />
          <ISSUE>
            <xsl:attribute name=""ID"">
              <xsl:value-of select=""$var:v4"" />
            </xsl:attribute>
            <DBID>
              <xsl:value-of select=""$var:v5"" />
            </DBID>
            <RB_ID xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"" ACTION=""IGNORE"">
  <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO"">


    <xsl:if test=""ns0:COMPANY-DATA-REF/. = 'Continental' or ns0:COMPANY-DATA-REF/. = 'Bosch' or ns0:COMPANY-DATA-REF/.= 'Delphi' or ns0:COMPANY-DATA-REF/. = 'Marelli' "">
      <xsl:choose>
        <xsl:when test=""ns0:ISSUE-ID/. = '' or normalize-space(ns0:ISSUE-ID/.) = ''"">
          <xsl:text>0</xsl:text>
        </xsl:when>
        <xsl:otherwise>
          <xsl:value-of select=""ns0:ISSUE-ID/."" />
        </xsl:otherwise>
      </xsl:choose>
    </xsl:if>


  </xsl:for-each>
</RB_ID>
            <ID>
              <xsl:value-of select=""$var:v5"" />
            </ID>
            <TITLE>
              <xsl:value-of select=""$var:v5"" />
            </TITLE>
            <DESCRIPTION>
              <xsl:value-of select=""$var:v5"" />
            </DESCRIPTION>
            <BELONGSTOPROJECT>
              <xsl:value-of select=""$var:v5"" />
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
			<xsl:when test=""//ns0:ISSUES/ns0:ISSUE/ns0:CATEGORY/@SI='Hardware'"">		
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
            <ISSUE_CATEGORY_FROM_CUSTOMER>
              <xsl:value-of select=""$var:v5"" />
            </ISSUE_CATEGORY_FROM_CUSTOMER>
            <EXTERNAL_ID>
              <xsl:value-of select=""s1:SHORT-NAME/text()"" />
            </EXTERNAL_ID>
            <EXTERNALTITLE>
              <xsl:value-of select=""$var:v5"" />
            </EXTERNALTITLE>
            <xsl:variable name=""var:v8"" select=""userCSharp:SetExternalExchangeParallel1($var:v6 , $var:v7)"" />
            <EXTERNALSTATE_PARALLEL1>
              <xsl:value-of select=""$var:v8"" />
            </EXTERNALSTATE_PARALLEL1>
            <EXTERNALCOMMENT>
              <xsl:value-of select=""$var:v5"" />
            </EXTERNALCOMMENT>
            <EXTERNALSUBMITTER xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
<xsl:variable name=""IssueId"" select=""string-length(normalize-space(//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF = 'Audi' or ns0:COMPANY-DATA-REF ='Bentley' or ns0:COMPANY-DATA-REF ='Bugatti' or ns0:COMPANY-DATA-REF = 'VW' or ns0:COMPANY-DATA-REF = 'Skoda' or ns0:COMPANY-DATA-REF = 'Porsche' or ns0:COMPANY-DATA-REF = 'Lamborghini' ]/ns0:ISSUE-ID))"" />
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
<xsl:variable name=""IssueId"" select=""string-length(normalize-space(//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO[ns0:COMPANY-DATA-REF = 'Audi' or ns0:COMPANY-DATA-REF ='Bentley' or ns0:COMPANY-DATA-REF ='Bugatti' or ns0:COMPANY-DATA-REF = 'VW' or ns0:COMPANY-DATA-REF = 'Skoda' or ns0:COMPANY-DATA-REF = 'Porsche' or ns0:COMPANY-DATA-REF = 'Lamborghini' ]/ns0:ISSUE-ID))"" />
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
            <EXTERNALREVIEW>
              <xsl:value-of select=""$var:v5"" />
            </EXTERNALREVIEW>
            <EXTERNALTAGS>
              <xsl:value-of select=""$var:v5"" />
            </EXTERNALTAGS>
            <EXTERNALDESCRIPTION>
              <xsl:value-of select=""$var:v5"" />
            </EXTERNALDESCRIPTION>
            <EXTERNALMILESTONES>
              <xsl:value-of select=""$var:v5"" />
            </EXTERNALMILESTONES>
            <P>
              <xsl:value-of select=""$var:v5"" />
            </P>
            <xsl:variable name=""var:v9"" select=""userCSharp:GetDateInFormat()"" />
            <xsl:variable name=""var:v10"" select=""userCSharp:SetExternalExchangeParallel1($var:v6 , $var:v7)"" />
            <xsl:call-template name=""ExternalConversation"">
              <xsl:with-param name=""param1"" select=""string($var:v9)"" />
              <xsl:with-param name=""param2"" select=""string($var:v10)"" />
            </xsl:call-template>
            <EXTERNALLASTEXPORTEDDATE>
              <xsl:value-of select=""$var:v5"" />
            </EXTERNALLASTEXPORTEDDATE>
            <xsl:variable name=""var:v11"" select=""userCSharp:GetDateInFormat()"" />
            <EXTERNALLASTIMPORTEDDATE>
              <xsl:value-of select=""$var:v11"" />
            </EXTERNALLASTIMPORTEDDATE>
            <ATTACHMENTS>
              <xsl:value-of select=""$var:v5"" />
            </ATTACHMENTS>
            <EXTERNALEXCHANGEDATTACH>
              <xsl:value-of select=""$var:v5"" />
            </EXTERNALEXCHANGEDATTACH>
            <COMMERCIALAMOUNT>
              <xsl:value-of select=""$var:v5"" />
            </COMMERCIALAMOUNT>
            <COMMERCIALAMOUNTCONFIRMED>
              <xsl:value-of select=""$var:v5"" />
            </COMMERCIALAMOUNTCONFIRMED>
            <COMMERCIALORIGSOLUTIONACC>
              <xsl:value-of select=""$var:v5"" />
            </COMMERCIALORIGSOLUTIONACC>
            <COMMERCIALCONVERSATION>
              <xsl:value-of select=""$var:v5"" />
            </COMMERCIALCONVERSATION>
            <xsl:variable name=""var:v12"" select=""userCSharp:CommercialQuoteReq($var:v7)"" />
            <COMMERCIALQUOTATIONREQ>
              <xsl:value-of select=""$var:v12"" />
            </COMMERCIALQUOTATIONREQ>
            <EXTERNALHISTORY>
              <xsl:attribute name=""ACTION"">
                <xsl:value-of select=""$var:v13"" />
              </xsl:attribute>
              <xsl:variable name=""var:v14"" select=""userCSharp:SetExternalExchangeParallel1($var:v6 , $var:v7)"" />
              <xsl:variable name=""var:v15"" select=""userCSharp:GetDateInFormat()"" />
              <xsl:variable name=""var:v16"" select=""userCSharp:StringConcat(string($var:v14) , &quot; - &quot; , string($var:v15) , &quot; - ExchangeProtocol: &lt;XPROT&gt;&quot;)"" />
              <xsl:value-of select=""$var:v16"" />
            </EXTERNALHISTORY>
            <xsl:if test=""s1:CATEGORY/@SI"">
              <OEMWORKFLOWTYPE>
                <xsl:value-of select=""s1:CATEGORY/@SI"" />
              </OEMWORKFLOWTYPE>
            </xsl:if>
            <OPERATIONMODE xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
<xsl:text>ASAM-IMPORT</xsl:text>
</OPERATIONMODE>
            <OPERATIONCONTEXT xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
<xsl:text>BizTalk</xsl:text>
</OPERATIONCONTEXT>
          </ISSUE>
        </xsl:for-each>
      </RT_ISSUES>
      <RT_COMMERCIALS>
        <COMMERCIAL>
          <xsl:attribute name=""ID"">
            <xsl:value-of select=""$var:v17"" />
          </xsl:attribute>
          <BELONGSTOISSUE>
            <xsl:attribute name=""ID-REF"">
              <xsl:value-of select=""$var:v18"" />
            </xsl:attribute>
          </BELONGSTOISSUE>
          <xsl:for-each select=""s1:ISSUES/s1:ISSUE"">
            <xsl:for-each select=""s1:ISSUE-ANNOTATIONS"">
              <xsl:for-each select=""s1:ISSUE-ANNOTATION"">
                <xsl:for-each select=""s1:ANNOTATION-TEXT/s1:P"">
                  <xsl:variable name=""var:v19"" select=""userCSharp:SetExternalExchangeParallel1(string(../../../../s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/text()) , string(../../../../s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/@SI))"" />
                  <xsl:variable name=""var:v20"" select=""userCSharp:GetDateInFormat()"" />
                  <xsl:call-template name=""CommercialConversation"">
                    <xsl:with-param name=""param1"" select=""string($var:v19)"" />
                    <xsl:with-param name=""param2"" select=""string($var:v20)"" />
                    <xsl:with-param name=""param3"" select=""string(./text())"" />
                  </xsl:call-template>
                </xsl:for-each>
              </xsl:for-each>
            </xsl:for-each>
          </xsl:for-each>
          <DBID>
            <xsl:value-of select=""$var:v21"" />
          </DBID>
        </COMMERCIAL>
      </RT_COMMERCIALS>
    </ns0:ASAMISSUE_EXTRACT>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



public string SetExternalExchangeParallel1(string param1,string param2)
{
    string strToReturn = """";	
	
	if(!(string.IsNullOrEmpty(param2)))
	{
		if(param2.ToUpper() == ""ZLK-PI"")
		{		
			strToReturn = ""ESTIMATED-PI_REJECTED"";
		}
		else if(param2.ToUpper() == ""ZLK-OF"")
		{
			strToReturn = ""ESTIMATED-OF_REJECTED"";
		}		
		else
		{
			strToReturn = ""ERROR_STATE"";
		}
	}
	else
	{		
		if (param1.ToUpper() == ""REJECTED"")
		{
			strToReturn = ""ESTIMATED_REJECTED"";
		}
	}	  
  return strToReturn ;
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


public string StringConcat(string param0, string param1, string param2, string param3)
{
   return param0 + param1 + param2 + param3;
}


public string CommercialQuoteReq(string param1)
{
    string strToReturn = """";
	
	if(!(string.IsNullOrEmpty(param1)))	
	{		
	    if(param1.ToUpper() == ""ZLK-PI"")
		{		
			strToReturn = ""Declined"";
		}
		 if(param1.ToUpper() == ""ZLK-OF"")
		{		
			strToReturn = ""Declined"";
		}		
	}
	  else
                 {
                 strToReturn = ""Declined"";
                 }
  return strToReturn ;
}

///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

public string SetOEMWorkflow(string param1,string si)
{
    string sCat = """";

 if(si == ""HARDWARE"")
{
              sCat = ""VAG_ASAM300_HWRQ"";
}
else
{  
        
               sCat = ""VAG_ASAM300_FAE"";
          
	
}
  return sCat;
}




]]></msxsl:script>
  <xsl:template name=""CommercialConversation"">
<xsl:param name=""param1"" />
<xsl:param name=""param2"" />
<xsl:param name=""param3"" />

<COMMERCIALCONVERSATION ACTION=""APPEND"">
    <P>### <xsl:value-of select=""$param1"" /> <xsl:value-of select=""$param2"" /> ###</P>
<P></P>
 <P><xsl:value-of select=""$param3"" /></P>
</COMMERCIALCONVERSATION>
</xsl:template>
  <xsl:template name=""ExternalConversation"">
  <xsl:param name=""param1"" />
  <xsl:param name=""param2"" />
  <EXTERNALCONVERSATION xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"" ACTION=""APPEND"">
    <P>
      ### <xsl:value-of select=""$param1"" /> # <xsl:value-of select=""$param2"" /> # <xsl:if test=""//ns0:COMPANY-DATA/ns0:SHORT-NAME/. = 'Audi' or //ns0:COMPANY-DATA/ns0:SHORT-NAME/. = 'VW' or //ns0:COMPANY-DATA/ns0:SHORT-NAME/. = 'Porsche' or //ns0:COMPANY-DATA/ns0:SHORT-NAME = 'Bentley' or //ns0:COMPANY-DATA/ns0:SHORT-NAME = 'Bugatti' or //ns0:COMPANY-DATA/ns0:SHORT-NAME = 'Lamborghini' or //ns0:COMPANY-DATA/ns0:SHORT-NAME = 'Skoda' "">
        <xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:EMAIL/."" />
      </xsl:if> ###
    </P>
    <!-- Copy 4th P NODE to ExternalConversation  -->
    <xsl:for-each select=""//ns0:ISSUE-DESC/ns0:P"">
      <xsl:if test=""position() = 4"">
        <P>
          <xsl:value-of select=""."" />
        </P>
      </xsl:if>
    </xsl:for-each>  
  </EXTERNALCONVERSATION>

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
