namespace RB.ROCustomerInterface {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.ASAM.issue_v3_0_0_sl", typeof(global::RB.ROCustomerInterface.Schema.ASAM.issue_v3_0_0_sl))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM", typeof(global::RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM))]
    public sealed class RB_RO_ASAM_ISSUE_IMF_ESTIMATEDPILOTREJECTED : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
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
          <xsl:for-each select=""s1:ISSUE-ANNOTATIONS"">
            <xsl:for-each select=""s1:ISSUE-ANNOTATION"">
              <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;IGNORE&quot;)"" />
              <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;VAG_ASAM300_FAE&quot;)"" />
              <VALEX_CONTROLINFO>
                <xsl:attribute name=""ACTION"">
                  <xsl:value-of select=""$var:v1"" />
                </xsl:attribute>
                <xsl:variable name=""var:v2"" select=""userCSharp:SetExternalExchangeParallel1(string(../../s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/text()) , string(@SI))"" />
                <OEMEXTERNALSTATE>
                  <xsl:value-of select=""$var:v2"" />
                </OEMEXTERNALSTATE>
                <OEMWORKFLOW>
                  <xsl:value-of select=""$var:v3"" />
                </OEMWORKFLOW>
              </VALEX_CONTROLINFO>
            </xsl:for-each>
          </xsl:for-each>
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
            <EXTERNAL_ID>
              <xsl:value-of select=""s1:SHORT-NAME/text()"" />
            </EXTERNAL_ID>
            <xsl:for-each select=""s1:ISSUE-ANNOTATIONS"">
              <xsl:for-each select=""s1:ISSUE-ANNOTATION"">
                <xsl:variable name=""var:v6"" select=""userCSharp:StringConcat(&quot;APPEND&quot;)"" />
                <xsl:variable name=""var:v7"" select=""string(../../s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/text())"" />
                <xsl:variable name=""var:v8"" select=""string(@SI)"" />
                <EXTERNALHISTORY>
                  <xsl:attribute name=""ACTION"">
                    <xsl:value-of select=""$var:v6"" />
                  </xsl:attribute>
                  <xsl:variable name=""var:v9"" select=""userCSharp:SetExternalExchangeParallel1($var:v7 , $var:v8)"" />
                  <xsl:variable name=""var:v10"" select=""userCSharp:GetDateInFormat()"" />
                  <xsl:variable name=""var:v11"" select=""userCSharp:StringConcat(string($var:v9) , &quot; - &quot; , string($var:v10) , &quot; - ExchangeProtocol: &lt;XPROT&gt;&quot;)"" />
                  <xsl:value-of select=""$var:v11"" />
                </EXTERNALHISTORY>
              </xsl:for-each>
            </xsl:for-each>
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
      <RT_IRMAPS>
        <xsl:for-each select=""s1:ISSUES/s1:ISSUE"">
          <xsl:for-each select=""s1:ISSUE-ANNOTATIONS"">
            <xsl:for-each select=""s1:ISSUE-ANNOTATION"">
              <xsl:variable name=""var:v12"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
              <xsl:variable name=""var:v13"" select=""userCSharp:StringConcat(&quot;ISS_1&quot;)"" />
              <xsl:variable name=""var:v14"" select=""string(../../s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/text())"" />
              <xsl:variable name=""var:v15"" select=""string(@SI)"" />
              <IRMAP>
                <DBID>
                  <xsl:value-of select=""$var:v12"" />
                </DBID>
                <SCOPE xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"" ACTION=""INIT"">
  <xsl:text>External</xsl:text>      
</SCOPE>
                <HASMAPPEDISSUE>
                  <xsl:attribute name=""ID-REF"">
                    <xsl:value-of select=""$var:v13"" />
                  </xsl:attribute>
                </HASMAPPEDISSUE>
                <ISPILOT xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
<xsl:if test=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO/ns0:PROJECT-ID[@SI='pilot']"">
<xsl:text>Yes</xsl:text>
</xsl:if>
</ISPILOT>
                <EXTERNALTAGS>
                  <xsl:value-of select=""$var:v12"" />
                </EXTERNALTAGS>
                <xsl:variable name=""var:v16"" select=""userCSharp:SetExternalExchangeParallel1($var:v14 , $var:v15)"" />
                <EXTERNALSTATE_PARALLEL1>
                  <xsl:value-of select=""$var:v16"" />
                </EXTERNALSTATE_PARALLEL1>
                <xsl:variable name=""var:v17"" select=""userCSharp:SetExternalExchangeParallel1($var:v14 , $var:v15)"" />
                <xsl:variable name=""var:v18"" select=""userCSharp:GetDateInFormat()"" />
                <xsl:call-template name=""SetExternalConversation"">
                  <xsl:with-param name=""Date"" select=""string($var:v17)"" />
                  <xsl:with-param name=""State"" select=""string($var:v18)"" />
                </xsl:call-template>
                <xsl:variable name=""var:v19"" select=""userCSharp:GetDateInFormat()"" />
                <EXTERNALLASTIMPORTEDDATE>
                  <xsl:value-of select=""$var:v19"" />
                </EXTERNALLASTIMPORTEDDATE>
                <OPERATIONMODE xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
<xsl:text>ASAM-IMPORT</xsl:text>
</OPERATIONMODE>
                <OPERATIONCONTEXT xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
<xsl:text>BizTalk</xsl:text>
</OPERATIONCONTEXT>
              </IRMAP>
            </xsl:for-each>
          </xsl:for-each>
        </xsl:for-each>
      </RT_IRMAPS>
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


public string SetExternalExchangeParallel1(string param1,string param2)
{
    string strToReturn = """";
    if (param1.ToUpper() == ""REJECTED"")
   {
     if(param2 == ""reject_estimated"")
      {
          strToReturn = ""ESTIMATED_PILOT_REJECTED"";
       }
   }  
   else
  { 
       strToReturn = """";
  }
  return strToReturn ;
}

public string StringConcat(string param0, string param1, string param2, string param3)
{
   return param0 + param1 + param2 + param3;
}


//   param1 > CATEGORY 
public string SetExternalExchangeWorkflow(string param1)
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
  <xsl:template name=""SetExternalConversation"">
  <xsl:param name=""Date"" />
  <xsl:param name=""State"" />
  <EXTERNALCONVERSATION xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"" ACTION=""APPEND"">
    <P>
      ### <xsl:value-of select=""$Date"" /> # <xsl:value-of select=""$State"" /> # <xsl:if test=""//ns0:COMPANY-DATA/ns0:SHORT-NAME/. = 'Audi' or //ns0:COMPANY-DATA/ns0:SHORT-NAME/. = 'VW' or //ns0:COMPANY-DATA/ns0:SHORT-NAME/. = 'Porsche' or //ns0:COMPANY-DATA/ns0:SHORT-NAME = 'Bentley' or //ns0:COMPANY-DATA/ns0:SHORT-NAME = 'Bugatti' or //ns0:COMPANY-DATA/ns0:SHORT-NAME = 'Lamborghini' ""><xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:EMAIL/."" /></xsl:if> ###
    </P>
    <P></P>
    <xsl:for-each select=""//ns0:ANNOTATION-TEXT/ns0:P"">
      <P>
        <xsl:value-of select=""."" />
      </P>
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
