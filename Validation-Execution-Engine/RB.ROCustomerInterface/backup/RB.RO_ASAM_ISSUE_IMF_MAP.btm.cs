namespace RB.ROCustomerInterface {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.ASAM.issue_v3_0_0_sl", typeof(global::RB.ROCustomerInterface.Schema.ASAM.issue_v3_0_0_sl))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM", typeof(global::RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM))]
    public sealed class RB_RO_ASAM_ISSUE_IMF_MAP : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1 userCSharp ScriptNS0"" version=""1.0"" xmlns:s1=""http://www.asam.net/schemas/issue/issue300"" xmlns:s0=""http://www.w3.org/XML/1998/namespace"" xmlns:ns0=""http://RB.ROCustomerInterface.RB"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:MSR-ISSUE"" />
  </xsl:template>
  <xsl:template match=""/s1:MSR-ISSUE"">
    <ns0:ASAMISSUE_EXTRACT>
      <RT_CONTACT xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
        
        <xsl:choose>
          <xsl:when test=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='Audi']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:EMAIL/. = //ns0:COMPANY-DATA/ns0:SHORT-NAME[.='Audi']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[2]/ns0:EMAIL/."">
            <CONTACT>             
 <xsl:attribute name=""ID"">
                <xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='Audi']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/@ID"" />
              </xsl:attribute>
              <DBID>0</DBID>
              <EMAIL>
                <xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='Audi']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:EMAIL/."" />
              </EMAIL>
              <LASTNAME>
                       <xsl:value-of select=""normalize-space(substring-before(//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='Audi']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:LONG-NAME/., ','))"" />
                       <!--<xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='Audi']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:LONG-NAME/.""/>-->
              </LASTNAME>
              <FIRSTNAME>
                   <xsl:value-of select=""normalize-space(substring-after(//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='Audi']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:LONG-NAME/., ','))"" />
                   <!--<xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='Audi']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:SHORT-NAME/.""/>-->
              </FIRSTNAME>
              <PHONENUMBERS>
                <xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='Audi']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:PHONE/."" />                
              </PHONENUMBERS>
              <DEPARTMENT>
                <xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='Audi']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:DEPARTMENT/."" />                
              </DEPARTMENT>
              <ORGANIZATION>                
                <xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='Audi']/."" />
              </ORGANIZATION>
              <ROLE>Ersteller, Aenderungsspezifikateur</ROLE>
              <DESCRIPTION />
            </CONTACT>
          </xsl:when>
          <xsl:otherwise>

             <xsl:for-each select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='Audi']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER"">
              <CONTACT>
                  <xsl:attribute name=""ID"">
                   <xsl:value-of select=""@ID"" />
                </xsl:attribute>
                <DBID>0</DBID>
                <EMAIL>
                  <xsl:value-of select=""ns0:EMAIL/."" />
                </EMAIL>
                <LASTNAME>
                    <xsl:value-of select=""normalize-space(substring-after(ns0:LONG-NAME/., ','))"" />
                  <!--<xsl:value-of select=""ns0:LONG-NAME/.""/>-->
                </LASTNAME>
                <FIRSTNAME>
                    <xsl:value-of select=""normalize-space(substring-before(ns0:LONG-NAME/., ','))"" />
                  <!--<xsl:value-of select=""ns0:SHORT-NAME/.""/>-->
                </FIRSTNAME>
                <PHONENUMBERS>
                  <xsl:value-of select=""ns0:PHONE/."" />
                </PHONENUMBERS>
                <DEPARTMENT>
                  <xsl:value-of select=""ns0:DEPARTMENT/."" />
                </DEPARTMENT>
                <ORGANIZATION>
                  <xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='Audi']/."" />
                </ORGANIZATION>
                <ROLE>
                  <xsl:value-of select=""ns0:ROLES/ns0:ROLE/."" />
                </ROLE>
                <DESCRIPTION />
              </CONTACT>
            </xsl:for-each>
            
          </xsl:otherwise>
        </xsl:choose>
      </RT_CONTACT>
      <RT_ISSUES>
        <xsl:for-each select=""s1:ISSUES/s1:ISSUE"">
          <xsl:for-each select=""s1:COMPANY-ISSUE-INFOS/s1:COMPANY-ISSUE-INFO"">
            <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;ISS_1&quot;)"" />
            <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
            <xsl:variable name=""var:v4"" select=""userCSharp:StringUpperCase(string(s1:COMPANY-DATA-REF/text()))"" />
            <xsl:variable name=""var:v5"" select=""userCSharp:LogicalNe(string($var:v4) , &quot;BOSCH&quot;)"" />
            <xsl:variable name=""var:v7"" select=""userCSharp:StringConcat(&quot;Audi&quot;)"" />
            <xsl:variable name=""var:v10"" select=""string(../../s1:CATEGORY/text())"" />
            <xsl:variable name=""var:v12"" select=""userCSharp:DateCurrentDateTime()"" />
            <ISSUE>
              <xsl:attribute name=""ID"">
                <xsl:value-of select=""$var:v1"" />
              </xsl:attribute>
              <DBID>
                <xsl:value-of select=""$var:v2"" />
              </DBID>
              <ID>
                <xsl:value-of select=""$var:v2"" />
              </ID>
              <TITLE>
                <xsl:value-of select=""../../s1:LONG-NAME/text()"" />
              </TITLE>
              <DESCRIPTION xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
    <xsl:for-each select=""//ns0:ISSUE-DESC/ns0:P"">
        <xsl:if test=""position() != 4"">
             <P><xsl:value-of select=""."" /> </P>
          </xsl:if>
      </xsl:for-each>
</DESCRIPTION>
              <BELONGSTOPROJECT>
                <xsl:value-of select=""$var:v2"" />
              </BELONGSTOPROJECT>
              <TYPE>
                <xsl:value-of select=""$var:v2"" />
              </TYPE>
              <DOMAIN>
                <xsl:value-of select=""$var:v2"" />
              </DOMAIN>
              <SCOPE>
                <xsl:value-of select=""$var:v2"" />
              </SCOPE>
              <xsl:variable name=""var:v3"" select=""userCSharp:SetCategory(string(../../s1:CATEGORY/text()))"" />
              <CATEGORY>
                <xsl:value-of select=""$var:v3"" />
              </CATEGORY>
              <ISSUE_CATEGORY_FROM_CUSTOMER>
                <xsl:value-of select=""../../s1:CATEGORY/text()"" />
              </ISSUE_CATEGORY_FROM_CUSTOMER>
              <ISSUETAGS>
                <ISSUETAG>
                  <P>
                    <xsl:value-of select=""$var:v2"" />
                  </P>
                </ISSUETAG>
              </ISSUETAGS>
              <xsl:if test=""string($var:v5)='true'"">
                <xsl:variable name=""var:v6"" select=""s1:ISSUE-ID/text()"" />
                <EXTERNAL_ID>
                  <xsl:value-of select=""$var:v6"" />
                </EXTERNAL_ID>
              </xsl:if>
              <EXTERNALTITLE>
                <xsl:value-of select=""../../s1:LONG-NAME/text()"" />
              </EXTERNALTITLE>
              <EXTERNALSTATE_PARALLEL1>
                <xsl:value-of select=""../../s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/text()"" />
              </EXTERNALSTATE_PARALLEL1>
              <EXTERNALSTATE_PARALLEL2>
                <xsl:value-of select=""$var:v2"" />
              </EXTERNALSTATE_PARALLEL2>
              <EXTERNALCOMMENT>
                <xsl:value-of select=""$var:v2"" />
              </EXTERNALCOMMENT>
              <EXTERNALSUBMITTER xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
<xsl:attribute name=""ID-REF"">
<xsl:choose>
        <xsl:when test=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='Audi']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:EMAIL/. = //ns0:COMPANY-DATA/ns0:SHORT-NAME[.='Audi']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[2]/ns0:EMAIL/."">

          <xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='Audi']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/@ID"" /> 

        </xsl:when>
        <xsl:otherwise>

            <xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='Audi']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER/ns0:ROLES/ns0:ROLE[.='Ersteller']/../../@ID"" />

        </xsl:otherwise>
      </xsl:choose>
</xsl:attribute>
</EXTERNALSUBMITTER>
              <EXTERNALASSIGNEE xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
<xsl:attribute name=""ID-REF"">
        <xsl:choose>
          <xsl:when test=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='Audi']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/ns0:EMAIL/. = //ns0:COMPANY-DATA/ns0:SHORT-NAME[.='Audi']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[2]/ns0:EMAIL/."">

            <xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='Audi']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER[1]/@ID"" />

          </xsl:when>
          <xsl:otherwise>

            <xsl:value-of select=""//ns0:COMPANY-DATA/ns0:SHORT-NAME[.='Audi']/following-sibling::ns0:TEAM-MEMBERS/ns0:TEAM-MEMBER/ns0:ROLES/ns0:ROLE[.='Aenderungsspezifikateur']/../../@ID"" />

          </xsl:otherwise>
        </xsl:choose>
</xsl:attribute>
      </EXTERNALASSIGNEE>
              <EXTERNALORGANIZATION>
                <xsl:value-of select=""$var:v7"" />
              </EXTERNALORGANIZATION>
              <xsl:variable name=""var:v8"" select=""userCSharp:SetExternalReview(string(../../s1:ISSUE-SOLUTIONS/s1:ISSUE-SOLUTION/s1:CATEGORY/text()))"" />
              <EXTERNALREVIEW>
                <xsl:value-of select=""$var:v8"" />
              </EXTERNALREVIEW>
              <EXTERNALTAGS>
                <EXTERNALTAG xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
  <P>Issue-Priority: <xsl:value-of select=""//ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-PRIORITY/."" /></P>
  <P>Tags: <xsl:value-of select=""//ns0:ISSUE/ns0:LONG-NAME/."" /></P>
   <xsl:for-each select=""//ns0:PRM-CHAR"">
       <P><xsl:value-of select=""../ns0:SHORT-NAME/."" />: <xsl:value-of select=""ns0:TEXT/."" /></P>
   </xsl:for-each>
   <P>F/P Creation: <xsl:value-of select=""//ns0:DATE/."" /></P>
   <xsl:for-each select=""//ns0:COMPANY-DATAS/ns0:COMPANY-DATA"">
       <xsl:choose>
             <xsl:when test=""ns0:SHORT-NAME/. = 'Audi'""></xsl:when>
             <xsl:when test=""ns0:SHORT-NAME/. = 'Bosch' or  ns0:SHORT-NAME/. = 'Continental' or ns0:SHORT-NAME/. = 'Delphi' or ns0:SHORT-NAME/. = 'Marelli' "">
                         <P>Supplier: <xsl:value-of select=""ns0:SHORT-NAME/."" /></P> 
             </xsl:when>
            <xsl:otherwise>
            </xsl:otherwise>
       </xsl:choose>
</xsl:for-each>
</EXTERNALTAG>
              </EXTERNALTAGS>
              <EXTERNALDESCRIPTION xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
    <xsl:for-each select=""//ns0:ISSUE-DESC/ns0:P"">
        <xsl:if test=""position() != 4"">
             <P><xsl:value-of select=""."" /></P>
          </xsl:if>
      </xsl:for-each>
</EXTERNALDESCRIPTION>
              <EXTERNALMILESTONES>
                <xsl:for-each select=""../../s1:ISSUE-PROPERTIES"">
                  <xsl:for-each select=""s1:DELIVERY-MILESTONES"">
                    <xsl:for-each select=""s1:DELIVERY-MILESTONE"">
                      <P>
                        <xsl:value-of select=""s1:SHORT-LABEL/text()"" />
                      </P>
                    </xsl:for-each>
                  </xsl:for-each>
                </xsl:for-each>
              </EXTERNALMILESTONES>
              <xsl:variable name=""var:v9"" select=""userCSharp:GetDateInFormat()"" />
              <xsl:call-template name=""ExternalConversation"">
                <xsl:with-param name=""param1"" select=""string($var:v9)"" />
              </xsl:call-template>
              <xsl:variable name=""var:v11"" select=""userCSharp:SetExternalExchangeWorkflow($var:v10)"" />
              <EXTERNALEXCHANGEWORKFLOW>
                <xsl:value-of select=""$var:v11"" />
              </EXTERNALEXCHANGEWORKFLOW>
              <EXTERNALLASTEXPORTEDDATE>
                <xsl:value-of select=""$var:v2"" />
              </EXTERNALLASTEXPORTEDDATE>
              <EXTERNALLASTIMPORTEDDATE>
                <xsl:value-of select=""$var:v12"" />
              </EXTERNALLASTIMPORTEDDATE>
              <xsl:variable name=""var:v13"" select=""ScriptNS0:GetOrchestrationVaraibles(&quot;ExchangeProtocolID&quot;)"" />
              <xsl:variable name=""var:v14"" select=""userCSharp:StringConcat(string(../../s1:ISSUE-PROPERTIES/s1:ISSUE-CURRENT-STATE/s1:ISSUE-STATE/text()) , &quot; - ExchangeProtocol: &quot; , string($var:v13))"" />
              <EXTERNALHISTORY>
                <xsl:value-of select=""$var:v14"" />
              </EXTERNALHISTORY>
              <ATTACHMENTS>
                <xsl:attribute name=""TYPE"">
                  <xsl:text>Attachment</xsl:text>
                </xsl:attribute>
                <xsl:for-each select=""../../s1:ISSUE-RELATED-DOCUMENTS"">
                  <xsl:for-each select=""s1:ISSUE-RELATED-DOCUMENT"">
                    <ATTACHMENT>
                      <PATH>
                        <xsl:value-of select=""s1:URL/text()"" />
                      </PATH>
                      <xsl:if test=""s1:LABEL"">
                        <LABEL>
                          <xsl:value-of select=""s1:LABEL/text()"" />
                        </LABEL>
                      </xsl:if>
                    </ATTACHMENT>
                  </xsl:for-each>
                </xsl:for-each>
              </ATTACHMENTS>
              <xsl:variable name=""var:v15"" select=""userCSharp:GetDateInFormat()"" />
              <xsl:call-template name=""GetExternalAttachmentData"">
                <xsl:with-param name=""param1"" select=""string($var:v15)"" />
              </xsl:call-template>
              <COMMERCIALAMOUNT>
                <xsl:value-of select=""../../s1:ISSUE-SOLUTIONS/s1:ISSUE-SOLUTION/s1:ISSUE-EFFORT/s1:AMOUNT/text()"" />
              </COMMERCIALAMOUNT>
              <COMMERCIALAMOUNTCONFIRMED>
                <xsl:value-of select=""$var:v2"" />
              </COMMERCIALAMOUNTCONFIRMED>
              <COMMERCIALORIGSOLUTIONACC>
                <xsl:value-of select=""$var:v2"" />
              </COMMERCIALORIGSOLUTIONACC>
              <xsl:for-each select=""../../s1:ISSUE-SOLUTIONS"">
                <xsl:for-each select=""s1:ISSUE-SOLUTION"">
                  <xsl:for-each select=""s1:ISSUE-EFFORT"">
                    <xsl:variable name=""var:v16"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
                    <COMMERCIALCOMMENT>
                      <P>
                        <xsl:value-of select=""$var:v16"" />
                      </P>
                      <xsl:value-of select=""s1:AMOUNT/text()"" />
                    </COMMERCIALCOMMENT>
                  </xsl:for-each>
                </xsl:for-each>
              </xsl:for-each>
              <COMMERCIALCONVERSATION>
                <xsl:for-each select=""../../s1:ISSUE-SOLUTIONS"">
                  <xsl:for-each select=""s1:ISSUE-SOLUTION"">
                    <xsl:for-each select=""s1:ISSUE-EFFORT"">
                      <P>
                        <xsl:value-of select=""s1:AMOUNT/text()"" />
                      </P>
                    </xsl:for-each>
                  </xsl:for-each>
                </xsl:for-each>
              </COMMERCIALCONVERSATION>
              <OCCURANCE>
                <xsl:value-of select=""$var:v2"" />
              </OCCURANCE>
              <xsl:if test=""../../s1:ISSUE-PROPERTIES/s1:ISSUE-SEVERITY"">
                <SEVERITY>
                  <xsl:value-of select=""../../s1:ISSUE-PROPERTIES/s1:ISSUE-SEVERITY/text()"" />
                </SEVERITY>
              </xsl:if>
            </ISSUE>
          </xsl:for-each>
        </xsl:for-each>
      </RT_ISSUES>
      <RT_RELEASES xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">

          <xsl:variable name=""unique-list"" select=""//ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL[not(.=following::ns0:SHORT-LABEL)]"" />
          <xsl:for-each select=""$unique-list"">
            <RELEASE>
              <xsl:attribute name=""ID"">
                <xsl:text>REL_</xsl:text>
                <xsl:value-of select=""position()"" />
              </xsl:attribute>
              <DBID>0</DBID>
              <ID>0</ID>
              <TITLE>
                <xsl:value-of select=""."" />
              </TITLE>
              <PLANNEDDATE />
              <EXTERNAL_ID />
              <EXTERNALTITILE />
            </RELEASE>
          </xsl:for-each>
        
      </RT_RELEASES>
      <RT_IRMAPS xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"">
<xsl:variable name=""unique-list"" select=""//ns0:DELIVERY-MILESTONES/ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL[not(.=following::ns0:SHORT-LABEL)]"" />
            <xsl:for-each select=""$unique-list"">
              <xsl:variable name=""idx"" select=""position()"" />
              <IRMAP>
                  <DBID>
                    <xsl:value-of select=""//ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL[.=$unique-list[$idx]]"" />
                  </DBID>
                  <HASMAPPEDISSUE ID-REF=""ISS_1""></HASMAPPEDISSUE>
                  <HASMAPPEDRELEASE>
                    <xsl:attribute name=""ID-REF"">
                      <xsl:text>REL_</xsl:text>
                      <xsl:value-of select=""position()"" />
                    </xsl:attribute>
                  </HASMAPPEDRELEASE>
                  <ISPILOT>
                    <xsl:choose>
<xsl:when test=""(//ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL[.=$unique-list[$idx]/.]/following-sibling::ns0:CATEGORY/.='pilot') or  (//ns0:DELIVERY-MILESTONE/ns0:SHORT-LABEL[.=$unique-list[$idx]]/following-sibling::ns0:CATEGORY/.='pilot-critical')"">Yes</xsl:when>
                      <xsl:otherwise>No</xsl:otherwise>
                    </xsl:choose>
                  </ISPILOT>
                  <EXTERNALNEXTSTATE></EXTERNALNEXTSTATE>
                  <EXTERNALTAGS>
                    <EXTERNALTAG ACTION=""APPEND"">
                      <P></P>
                    </EXTERNALTAG>
                  </EXTERNALTAGS>
                  <EXCHANGEWORKFLOW />
                  <EXTERNAL_ID />
                  <EXTERNALTITLE />
                  <EXTERNALSTATE_PARALLEL1 />
                  <EXTERNALCONVERSATION ACTION=""APPEND"">
                    <P />
                  </EXTERNALCONVERSATION>
                </IRMAP>              
          </xsl:for-each>
      </RT_IRMAPS>
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


public string StringUpperCase(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.ToUpper(System.Globalization.CultureInfo.InvariantCulture);
}


public bool LogicalNe(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 != d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) != 0;
	}
	return ret;
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
    if (param1.ToUpper() == ""CHANGE-REQUEST"")
   {
           sCat = ""VAG_ASAM310_FAE"";
   }
   else  if (param1.ToUpper() == ""BUG-REPORT"")
   {
       sCat = ""VAG_ASAM310_BUG"";   
   }
   else
  { 
       sCat = ""VAG_ASAM310_FAE"";
  }
  return sCat;
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
         string strDate;
         strDate = System.DateTime.Parse(DateTime.Today.ToString()).ToString(""yyyyMMdd"");
        return strDate;
}


public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
  <xsl:template name=""ExternalConversation"">
<xsl:param name=""param1"" />
<EXTERNALCONVERSATION xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"" ACTION=""APPEND"">
    <P>### <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" /> <xsl:value-of select=""$param1"" /> ###</P>
    <!-- Copy 4th P NODE to ExternalConversation  -->
    <xsl:for-each select=""//ns0:ISSUE-DESC/ns0:P"">
        <xsl:if test=""position() = 4"">
             <P><xsl:value-of select=""."" /></P>
          </xsl:if>
      </xsl:for-each>

     <!-- Copy   ANNOTATION-TEXT Reason for muliple when clause is to accomodate seperate text if any in future-->
     <xsl:for-each select=""//ns0:ISSUE-ANNOTATION""> 
        <xsl:choose>
            <xsl:when test=""@SI ='project_restriction'"">
               <P><xsl:value-of select=""@SI"" />: <xsl:value-of select=""ns0:ANNOTATION-TEXT/ns0:P/."" /></P>
           </xsl:when>
           <xsl:when test=""@SI ='critical_milestone'"">
                <P><xsl:value-of select=""@SI"" />: <xsl:value-of select=""ns0:ANNOTATION-TEXT/ns0:P/."" /></P>
           </xsl:when>
           <xsl:when test=""@SI ='reject_estimated'"">
                 <P><xsl:value-of select=""@SI"" />: <xsl:value-of select=""ns0:ANNOTATION-TEXT/ns0:P/."" /></P>
            </xsl:when>
            <xsl:when test=""@SI ='closed_not_ok_delivered'""> 
                 <P><xsl:value-of select=""@SI"" />: <xsl:value-of select=""ns0:ANNOTATION-TEXT/ns0:P/."" /></P>
             </xsl:when>
             <xsl:when test=""@SI ='cancelled'"">
                 <P><xsl:value-of select=""@SI"" />: <xsl:value-of select=""ns0:ANNOTATION-TEXT/ns0:P/."" /></P>
             </xsl:when>
             <xsl:otherwise>
                    <P>Issue Annotation has different value for SI: <xsl:value-of select=""@SI"" />: <xsl:value-of select=""ns0:ANNOTATION-TEXT/ns0:P/."" /></P>
            </xsl:otherwise>
     </xsl:choose>
   </xsl:for-each>
     
   <!-- Copy Delivery category only from first node-->         
     <P>Delivery Milestone Category: <xsl:value-of select=""//ns0:DELIVERY-MILESTONE[1]/ns0:CATEGORY/. "" /></P> 

    <P>ProjectID for PILOT: <xsl:value-of select=""//ns0:COMPANY-DATA-REF[.='Audi']/following-sibling::ns0:PROJECT-ID[@SI='PILOT']/."" /></P>  
         
</EXTERNALCONVERSATION>

</xsl:template>
  <xsl:template name=""GetExternalAttachmentData"">
<xsl:param name=""param1"" />

<EXTERNALEXCHANGEDATTACH xmlns:ns0=""http://www.asam.net/schemas/issue/issue300"" ACTION=""APPEND"">
        <P>### <xsl:value-of select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-PROPERTIES/ns0:ISSUE-CURRENT-STATE/ns0:ISSUE-STATE/."" /> <xsl:value-of select=""$param1"" /> ###</P>
         <xsl:for-each select=""//ns0:ISSUES/ns0:ISSUE/ns0:ISSUE-RELATED-DOCUMENTS/ns0:ISSUE-RELATED-DOCUMENT"">           
             <P> <xsl:value-of select=""ns0:URL/."" /></P>
       </xsl:for-each>
</EXTERNALEXCHANGEDATTACH>

</xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""RB.ROCustomerIntefaceLibrary, Version=1.0.2.3, Culture=neutral, PublicKeyToken=55495bc4c1159231"" ClassName=""RB.ROCustomerIntefaceLibrary.BTHelper"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"RB.ROCustomerInterface.Schema.ASAM.issue_v3_0_0_sl";
        
        private const string _strTrgSchemasList0 = @"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM";
        
        public override string XmlContent {
            get {
                return _strMap;
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
