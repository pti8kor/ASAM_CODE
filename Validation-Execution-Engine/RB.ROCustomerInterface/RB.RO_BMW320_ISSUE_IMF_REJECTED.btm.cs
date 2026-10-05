namespace RB.ROCustomerInterface {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.BMW.issue_v3_2_0_sl", typeof(global::RB.ROCustomerInterface.Schema.BMW.issue_v3_2_0_sl))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM", typeof(global::RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM))]
    public sealed class RB_RO_BMW320_ISSUE_IMF_REJECTED : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
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
          <VALEX_CONTROLINFO>
            <xsl:attribute name=""ACTION"">
              <xsl:value-of select=""$var:v1"" />
            </xsl:attribute>
            <OEMEXTERNALSTATE>
              <xsl:value-of select=""s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/text()"" />
            </OEMEXTERNALSTATE>
            <xsl:variable name=""var:v2"" select=""userCSharp:Concat(string(s1:CATEGORY/text()) , string(s1:CATEGORY/@LEVEL) , string(../../s1:CATEGORY/text()))"" />
            <OEMWORKFLOW>
              <xsl:value-of select=""$var:v2"" />
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
          <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;ISS_1&quot;)"" />
          <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
          <xsl:variable name=""var:v6"" select=""string(s1:CATEGORY/text())"" />
          <xsl:variable name=""var:v7"" select=""string(s1:CATEGORY/@LEVEL)"" />
          <xsl:variable name=""var:v8"" select=""string(../../s1:CATEGORY/text())"" />
          <xsl:variable name=""var:v12"" select=""userCSharp:StringConcat(&quot; - ExchangeProtocol: &lt;XPROT&gt;&quot;)"" />
          <ISSUE>
            <xsl:attribute name=""ID"">
              <xsl:value-of select=""$var:v3"" />
            </xsl:attribute>
            <DBID>
              <xsl:value-of select=""$var:v4"" />
            </DBID>
            <RB_ID xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
 <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO"">
      <xsl:if test=""ns0:COMPANY-DATA-REF/.= 'BOSCH'"">
          <xsl:value-of select=""ns0:ISSUE-ID/."" />
  </xsl:if>
</xsl:for-each>
</RB_ID>
            <ID>
              <xsl:value-of select=""$var:v4"" />
            </ID>
            <DESCRIPTION xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
	<xsl:if test=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE = 'ACCEPTED'""> 
		<P>
			<xsl:text>DESCRIPTION:</xsl:text>
		</P>
		<xsl:for-each select=""//ns0:ISSUE-DESC/ns0:P"">
			<P>	
				<xsl:text>----------------------------------------------------------------------------------
For the original OEM-Description refer to ExternalDescription field.
----------------------------------------------------------------------------------
				</xsl:text>
			</P>
		</xsl:for-each>
		<P />
		<xsl:for-each select=""//ns0:ISSUE-ENVIRONMENT/ns0:ENGINEERING-OBJECTS/ns0:ENGINEERING-OBJECT[ns0:CATEGORY='SAFETY_CONCEPT_RELEVANT' or ns0:CATEGORY='BN_RELEVANT' or ns0:CATEGORY='LAYERRELEVANCE']"">
			<P>
				<xsl:value-of select=""ns0:CATEGORY"" />			
				<xsl:choose>
					<xsl:when test=""ns0:DOMAIN"">										
						<xsl:text>(Domain=</xsl:text>						
						<xsl:value-of select=""concat(substring(ns0:DOMAIN, 1, 1), translate(substring(ns0:DOMAIN, 2), 'ABCDEFGHIJKLMNOPQRSTUVWXYZ', 'abcdefghijklmnopqrstuvwxyz'))"" />
						<xsl:text>)</xsl:text>										
					</xsl:when>
					<xsl:otherwise>					
					</xsl:otherwise>
				</xsl:choose>
				<xsl:text>:</xsl:text>
				<xsl:value-of select=""ns0:SHORT-LABEL"" />
			</P>
		</xsl:for-each>
	</xsl:if>
</DESCRIPTION>
            <BELONGSTOPROJECT>
              <xsl:value-of select=""$var:v4"" />
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
            <EXTERNAL_ID xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
 <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:COMPANY-ISSUE-INFOS/ns0:COMPANY-ISSUE-INFO"">
      <xsl:if test=""ns0:COMPANY-DATA-REF/.= 'BMW'"">
          <xsl:value-of select=""ns0:ISSUE-ID/."" />
  </xsl:if>
</xsl:for-each>
</EXTERNAL_ID>
            <EXTERNALSTATE_PARALLEL1 xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
	<xsl:choose>
		<xsl:when test=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@ORIGIN"">
			<xsl:value-of select=""concat(//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@ORIGIN,'-',//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE)"" />
		</xsl:when>
		<xsl:otherwise>
			<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE"" />
		</xsl:otherwise>
	</xsl:choose>
</EXTERNALSTATE_PARALLEL1>
            <EXTERNALSTATE_PARALLEL2>
              <xsl:value-of select=""$var:v4"" />
            </EXTERNALSTATE_PARALLEL2>
            <EXTERNALNEXTSTATE>
              <xsl:value-of select=""$var:v4"" />
            </EXTERNALNEXTSTATE>
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
            <EXTERNALDESCRIPTION xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
 <xsl:if test=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE = 'ACCEPTED'""> 
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
 </xsl:if>
</EXTERNALDESCRIPTION>
            <xsl:variable name=""var:v5"" select=""userCSharp:GetDateInFormat()"" />
            <xsl:call-template name=""GetExternalConversion"">
              <xsl:with-param name=""param1"" select=""string($var:v5)"" />
            </xsl:call-template>
            <xsl:variable name=""var:v9"" select=""userCSharp:Concat($var:v6 , $var:v7 , $var:v8)"" />
            <EXTERNALEXCHANGEWORKFLOW>
              <xsl:value-of select=""$var:v9"" />
            </EXTERNALEXCHANGEWORKFLOW>
            <xsl:variable name=""var:v10"" select=""userCSharp:GetDateInFormat()"" />
            <EXTERNALLASTIMPORTEDDATE>
              <xsl:value-of select=""$var:v10"" />
            </EXTERNALLASTIMPORTEDDATE>
            <xsl:variable name=""var:v11"" select=""userCSharp:GetDateInFormat()"" />
            <xsl:call-template name=""SetExternalHistory"">
              <xsl:with-param name=""param1"" select=""string($var:v11)"" />
              <xsl:with-param name=""param2"" select=""string($var:v12)"" />
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
            <OEMORIGINATINGSTATE xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
	<xsl:if test=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@ORIGIN"">
		<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@ORIGIN"" />
	</xsl:if>
</OEMORIGINATINGSTATE>
          </ISSUE>
        </xsl:for-each>
      </RT_ISSUES>
    </ns0:ASAMISSUE_EXTRACT>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}




public string Concat(string param1, string param2, string  param3)
{
string strToReturn = "" "";
if(param3 ==""BMW-PROSPR"")
{
if(param1 ==""CHANGE-REQUEST"")
	{
	strToReturn =""BMW_PROSPR_REQ"";
	}
else {
    strToReturn =""BMW_PROSPR_DEF"";  
     }
}
     
else if(param1 ==""CHANGE-REQUEST"")
{
      if(param2 == ""CP"")
     {
         strToReturn =""BMW_ASAM320_CO"";
     }
     else
     {
          strToReturn =""BMW_ASAM310_CP"";
     }
}
else
{
strToReturn =""BMW_ASAM310_PR"";
}
	return strToReturn; 

}


public string GetDateInFormat()
{
      
       // strDate = System.DateTime.Parse(DateTime.Today.ToString()).ToString(""yyyyMMdd"");
          System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo(""de-DE"");
           string strFormatedDateTime = System.DateTime.Parse(DateTime.Now.ToString()).ToString(""dd.MM.yyyy HH:mm:ss"", culture);
           return strFormatedDateTime;
}



]]></msxsl:script>
  <xsl:template name=""GetExternalConversion"">
	<xsl:param name=""param1"" />
	<EXTERNALCONVERSATION ACTION=""APPEND"" xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
		<P>
			<xsl:text>### </xsl:text>
			<xsl:value-of select=""$param1"" />
			<xsl:text> # </xsl:text>
			<xsl:choose>
				<xsl:when test=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@ORIGIN"">
					<xsl:value-of select=""concat(//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@ORIGIN,'-',//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE)"" />
				</xsl:when>
				<xsl:otherwise>
					<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE"" />
				</xsl:otherwise>
			</xsl:choose>
			<xsl:text> # </xsl:text><xsl:if test=""//ns0:COMPANY-DATA/ns0:SHORT-NAME = 'BMW' "">
        <xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:EMAIL/."" /></xsl:if> ###
		</P>
		<xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-ANNOTATIONS/ns0:ISSUE-ANNOTATION[@SI='LAST' and not(ns0:TEAM-MEMBER-REF/@ID-REF = 'efaPUNKTsupport_bmw_de')]"">	
		 <xsl:sort select=""ns0:DATE"" order=""descending"" />                   
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
		</xsl:for-each>
		<P />
	</EXTERNALCONVERSATION>
</xsl:template>
  <xsl:template name=""SetExternalHistory"">
  <xsl:param name=""param1"" />
  <xsl:param name=""param2"" />
  <EXTERNALHISTORY ACTION=""APPEND"" xmlns:ns0=""http://www.asam.net/schemas/issue/issue320"">
    <xsl:choose>
		<xsl:when test=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@ORIGIN"">
			<xsl:value-of select=""concat(//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/@ORIGIN,'-',//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE)"" />
		</xsl:when>
		<xsl:otherwise>
			<xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE"" />
		</xsl:otherwise>
	</xsl:choose>
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
