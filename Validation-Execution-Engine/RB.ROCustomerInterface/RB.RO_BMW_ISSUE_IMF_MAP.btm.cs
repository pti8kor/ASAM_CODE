namespace RB.ROCustomerInterface {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.BMW.ASAM_ISSUE_V3_0_1_proposed", typeof(global::RB.ROCustomerInterface.Schema.BMW.ASAM_ISSUE_V3_0_1_proposed))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM", typeof(global::RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM))]
    public sealed class RB_RO_BMW_ISSUE_IMF_MAP : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://RB.ROCustomerInterface.RB"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" indent=""yes"" version=""1.0"" method=""xml"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/MSR-ISSUE"" />
  </xsl:template>
  <xsl:template match=""/MSR-ISSUE"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;ISS_1&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:StringConcat(&quot;APPEND&quot;)"" />
    <xsl:variable name=""var:v11"" select=""userCSharp:StringConcat(string(ISSUES/ISSUE/ISSUE-PLANNING-INFOS/ISSUE-CURRENT-STATE/ISSUE-STATE/text()) , &quot;301&quot;)"" />
    <xsl:variable name=""var:v12"" select=""userCSharp:StringConcat(&quot;PRO_1&quot;)"" />
    <xsl:variable name=""var:v13"" select=""userCSharp:StringConcat(&quot;0&quot;)"" />
    <xsl:variable name=""var:v18"" select=""userCSharp:StringConcat(&quot;REL_1&quot;)"" />
    <xsl:variable name=""var:v19"" select=""userCSharp:StringConcat(&quot;No&quot;)"" />
    <ns0:ASAMISSUE_EXTRACT>
      <RT_CONTACT>
	<xsl:if test=""//COMPANY/SHORT-NAME/. = 'BMW'"">
		<xsl:choose>
			<xsl:when test=""COMPANY/SHORT-NAME[.='BMW']/following-sibling::TEAM-MEMBERS/TEAM-MEMBER[1]/EMAIL/. = //COMPANY/SHORT-NAME[.='BMW']/following-sibling::TEAM-MEMBERS/TEAM-MEMBER[2]/EMAIL/."">
				<CONTACT>
					<xsl:attribute name=""ID"">
						<xsl:value-of select=""//COMPANY/SHORT-NAME[.='BMW']/following-sibling::TEAM-MEMBERS/TEAM-MEMBER[1]/@ID"" />
					</xsl:attribute>
					<DBID>0</DBID>
					<EMAIL>
						<xsl:value-of select=""//COMPANY/SHORT-NAME[.='BMW']/following-sibling::TEAM-MEMBERS/TEAM-MEMBER[1]/EMAIL/."" />
					</EMAIL>
					<LASTNAME>
						<xsl:value-of select=""normalize-space(substring-before(//COMPANY/SHORT-NAME[.='BMW']/following-sibling::TEAM-MEMBERS/TEAM-MEMBER[1]/LONG-NAME/., ','))"" />
						<!--<xsl:value-of select=""//COMPANY/SHORT-NAME[.='BMW']/following-sibling::TEAM-MEMBERS/TEAM-MEMBER[1]/LONG-NAME/.""/>-->
					</LASTNAME>
					<FIRSTNAME>
						<xsl:value-of select=""normalize-space(substring-after(//COMPANY/SHORT-NAME[.='BMW']/following-sibling::TEAM-MEMBERS/TEAM-MEMBER[1]/LONG-NAME/., ','))"" />
						<!--<xsl:value-of select=""//COMPANY/SHORT-NAME[.='BMW']/following-sibling::TEAM-MEMBERS/TEAM-MEMBER[1]/SHORT-NAME/.""/>-->
					</FIRSTNAME>
					<PHONENUMBERS>
						<p>Phone: <xsl:value-of select=""//COMPANY/SHORT-NAME[.='BMW']/following-sibling::TEAM-MEMBERS/TEAM-MEMBER[1]/PHONE/."" /></p>
						<p>Fax: <xsl:value-of select=""//COMPANY/SHORT-NAME[.='BMW']/following-sibling::TEAM-MEMBERS/TEAM-MEMBER[1]/FAX/."" /></p>
					</PHONENUMBERS>
					<DEPARTMENT>
						<xsl:value-of select=""//COMPANY/SHORT-NAME[.='BMW']/following-sibling::TEAM-MEMBERS/TEAM-MEMBER[1]/DEPARTMENT/."" />
					</DEPARTMENT>
					<ORGANIZATION>
						<xsl:value-of select=""//COMPANY/SHORT-NAME[.='BMW']/."" />
					</ORGANIZATION>
					<ROLE />
					<DESCRIPTION>
						<xsl:value-of select=""//TEAM-MEMBER/@ID"" />
					</DESCRIPTION>
					<OPERATIONMODE><xsl:text>ASAM-IMPORT</xsl:text></OPERATIONMODE>
					<OPERATIONCONTEXT><xsl:text>BizTalk</xsl:text></OPERATIONCONTEXT>
				</CONTACT>
			</xsl:when>
			<xsl:otherwise>
				<xsl:for-each select=""//COMPANY/SHORT-NAME[.='BMW']/following-sibling::TEAM-MEMBERS/TEAM-MEMBER"">
					<CONTACT>
						<xsl:attribute name=""ID"">
							<xsl:value-of select=""@ID"" />
						</xsl:attribute>
						<DBID>0</DBID>
						<EMAIL>
							<xsl:value-of select=""EMAIL/."" />
						</EMAIL>
						<LASTNAME>
							<xsl:value-of select=""normalize-space(substring-before(LONG-NAME/., ','))"" />            
							<!--<xsl:value-of select=""LONG-NAME/.""/>-->
						</LASTNAME>
						<FIRSTNAME>
							<xsl:value-of select=""normalize-space(substring-after(LONG-NAME/., ','))"" />
							<!--<xsl:value-of select=""SHORT-NAME/.""/>-->
						</FIRSTNAME>
						<PHONENUMBERS>
							<p>Phone: <xsl:value-of select=""PHONE/."" /></p>
							<p>Fax: <xsl:value-of select=""FAX/."" /></p>
						</PHONENUMBERS>
						<DEPARTMENT>
							<xsl:value-of select=""DEPARTMENT/."" />
						</DEPARTMENT>
						<ORGANIZATION>
							<xsl:value-of select=""//COMPANY/SHORT-NAME[.='BMW']/."" />
						</ORGANIZATION>
						<ROLE />
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
            <xsl:value-of select=""$var:v1"" />
          </xsl:attribute>
          <DBID>
            <xsl:value-of select=""$var:v2"" />
          </DBID>
          <ID>
            <xsl:value-of select=""$var:v2"" />
          </ID>
          <TITLE>
            <xsl:value-of select=""ISSUES/ISSUE/LONG-NAME/text()"" />
          </TITLE>
          <DESCRIPTION>
            <P>DESCRIPTION: </P>
            <xsl:for-each select=""//ISSUE-DESC/P"">
  <P><xsl:value-of select=""."" /></P>
</xsl:for-each>
            <xsl:for-each select=""//ISSUE-SOLUTIONS/ISSUE-SOLUTION"">
  <xsl:choose>
    <xsl:when test=""CATEGORY/. = 'PROPOSAL'"">
      <P>PROPOSAL:</P>
      <P><xsl:value-of select=""ISSUE-SOLUTION-DESC/."" /></P>
    </xsl:when>
    <xsl:when test=""CATEGORY/. = 'SOLUTION'"">
      <P>SOLUTION:</P>
      <P><xsl:value-of select=""ISSUE-SOLUTION-DESC/."" /></P>
    </xsl:when>
    <xsl:when test=""CATEGORY/. = 'TESTSPECIFICATION'"">
      <P>TESTSPECIFICATION:</P>
      <P><xsl:value-of select=""ISSUE-SOLUTION-DESC/."" /></P>
    </xsl:when>
    <xsl:otherwise>
    </xsl:otherwise>
  </xsl:choose>
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
          <CATEGORY>
  <xsl:choose>
    <xsl:when test=""//RELATED-ISSUE/ISSUE-RELATION/.='CP'"">
      Requirement
    </xsl:when>
    <xsl:when test=""//RELATED-ISSUE/ISSUE-RELATION/.='PR'"">
      Defect
    </xsl:when>
  </xsl:choose>
</CATEGORY>
          <ISSUE_CATEGORY_FROM_CUSTOMER>
            <xsl:value-of select=""ISSUES/ISSUE/CATEGORY/text()"" />
          </ISSUE_CATEGORY_FROM_CUSTOMER>
          <EXTERNAL_ID>
  <xsl:choose>
    <xsl:when test=""//RELATED-ISSUE/ISSUE-RELATION/.='CP'"">
      <xsl:value-of select=""normalize-space(substring-after(//ISSUE-REF/., '_'))"" />
    </xsl:when>
    <xsl:when test=""//RELATED-ISSUE/ISSUE-RELATION/.='PR'"">
      <xsl:value-of select=""normalize-space(substring-after(//ISSUE-REF/., '_'))"" />
    </xsl:when>
  </xsl:choose>
</EXTERNAL_ID>
          <EXTERNALTITLE>
            <xsl:value-of select=""ISSUES/ISSUE/LONG-NAME/text()"" />
          </EXTERNALTITLE>
          <EXTERNALSTATE_PARALLEL2>
            <xsl:value-of select=""$var:v2"" />
          </EXTERNALSTATE_PARALLEL2>
          <EXTERNALCOMMENT>
            <xsl:value-of select=""$var:v2"" />
          </EXTERNALCOMMENT>
          <EXTERNALSUBMITTER>
  <xsl:attribute name=""ID-REF"">    
        <xsl:value-of select=""//ISSUE-PLANNING-INFOS/ISSUE-CURRENT-STATE/TEAM-MEMBER-REF/@ID-REF"" />
  </xsl:attribute>
</EXTERNALSUBMITTER>
          <EXTERNALASSIGNEE>
  <xsl:attribute name=""ID-REF"">    
        <xsl:value-of select=""//COMPANY-ISSUE-INFO/TEAM-MEMBER-REF/@ID-REF"" />
  </xsl:attribute>
</EXTERNALASSIGNEE>
          <EXTERNALORGANIZATION>
  <xsl:value-of select=""//COMPANY/SHORT-NAME/."" />
</EXTERNALORGANIZATION>
          <EXTERNALREVIEW>
            <xsl:value-of select=""$var:v2"" />
          </EXTERNALREVIEW>
          <EXTERNALTAGS>
            <EXTERNALTAG>
              <P>
                <xsl:value-of select=""$var:v2"" />
              </P>
            </EXTERNALTAG>
          </EXTERNALTAGS>
          <EXTERNALDESCRIPTION>
            <P>DESCRIPTION: </P>
            <xsl:for-each select=""//ISSUE-DESC/P"">
  <P><xsl:value-of select=""."" /></P>
</xsl:for-each>
            <xsl:for-each select=""//ISSUE-SOLUTIONS/ISSUE-SOLUTION"">
  <xsl:choose>
    <xsl:when test=""CATEGORY/. = 'PROPOSAL'"">
      <P>PROPOSAL:</P>
      <P><xsl:value-of select=""ISSUE-SOLUTION-DESC/."" /></P>
    </xsl:when>
    <xsl:when test=""CATEGORY/. = 'SOLUTION'"">
      <P>SOLUTION:</P>
      <P><xsl:value-of select=""ISSUE-SOLUTION-DESC/."" /></P>
    </xsl:when>
    <xsl:when test=""CATEGORY/. = 'TESTSPECIFICATION'"">
      <P>TESTSPECIFICATION:</P>
      <P><xsl:value-of select=""ISSUE-SOLUTION-DESC/."" /></P>
    </xsl:when>
    <xsl:otherwise>
    </xsl:otherwise>
  </xsl:choose>
</xsl:for-each>
          </EXTERNALDESCRIPTION>
          <EXTERNALMILESTONES>
            <P>
              <xsl:value-of select=""$var:v2"" />
            </P>
          </EXTERNALMILESTONES>
          <EXTERNALCONVERSATION>
            <P>
              <xsl:value-of select=""$var:v2"" />
            </P>
          </EXTERNALCONVERSATION>
          <EXTERNALEXCHANGEWORKFLOW>
  <xsl:for-each select=""//RELATED-ISSUE/ISSUE-RELATION"">
    <xsl:choose>
      <xsl:when test="". = 'CP'"">BMW_ASAM301_CP</xsl:when>
    <xsl:when test="". = 'PR'"">BMW_ASAM301_PR</xsl:when>
    </xsl:choose>
  </xsl:for-each>
</EXTERNALEXCHANGEWORKFLOW>
          <EXTERNALLASTEXPORTEDDATE>
            <xsl:value-of select=""$var:v2"" />
          </EXTERNALLASTEXPORTEDDATE>
          <xsl:variable name=""var:v3"" select=""userCSharp:GetDateInFormat()"" />
          <EXTERNALLASTIMPORTEDDATE>
            <xsl:value-of select=""$var:v3"" />
          </EXTERNALLASTIMPORTEDDATE>
          <xsl:variable name=""var:v4"" select=""userCSharp:GetDateInFormat()"" />
          <xsl:call-template name=""GetAttachments"">
            <xsl:with-param name=""param1"" select=""string($var:v4)"" />
          </xsl:call-template>
          <xsl:variable name=""var:v5"" select=""userCSharp:GetDateInFormat()"" />
          <xsl:call-template name=""GetExternalAttachmentData"">
            <xsl:with-param name=""param1"" select=""string($var:v5)"" />
          </xsl:call-template>
          <COMMERCIALAMOUNT>
            <xsl:value-of select=""$var:v2"" />
          </COMMERCIALAMOUNT>
          <COMMERCIALAMOUNTCONFIRMED>
            <xsl:value-of select=""$var:v2"" />
          </COMMERCIALAMOUNTCONFIRMED>
          <COMMERCIALORIGSOLUTIONACC>
            <xsl:value-of select=""$var:v2"" />
          </COMMERCIALORIGSOLUTIONACC>
          <COMMERCIALCOMMENT>
            <P>
              <xsl:value-of select=""$var:v2"" />
            </P>
          </COMMERCIALCOMMENT>
          <COMMERCIALCONVERSATION>
            <P>
              <xsl:value-of select=""$var:v2"" />
            </P>
          </COMMERCIALCONVERSATION>
          <EXTERNALHISTORY>
            <xsl:attribute name=""ACTION"">
              <xsl:value-of select=""$var:v6"" />
            </xsl:attribute>
            <xsl:for-each select=""ISSUES/ISSUE/COMPANY-ISSUE-INFOS/COMPANY-ISSUE-INFO"">
              <xsl:variable name=""var:v7"" select=""userCSharp:StringUpperCase(string(COMPANY-REF/text()))"" />
              <xsl:variable name=""var:v8"" select=""userCSharp:LogicalNe(string($var:v7) , &quot;BOSCH&quot;)"" />
              <xsl:if test=""string($var:v8)='true'"">
                <xsl:variable name=""var:v9"" select=""ISSUE-ID/text()"" />
                <xsl:variable name=""var:v10"" select=""userCSharp:StringConcat(string(../../ISSUE-PLANNING-INFOS/ISSUE-CURRENT-STATE/ISSUE-STATE/text()) , &quot; - ExchangeProtocol: &lt;XPROT&gt;&quot; , &quot;- &quot; , string($var:v9))"" />
                <xsl:value-of select=""$var:v10"" />
              </xsl:if>
            </xsl:for-each>
          </EXTERNALHISTORY>
          <OEMEXTERNALSTATE>
            <xsl:value-of select=""$var:v11"" />
          </OEMEXTERNALSTATE>
        </ISSUE>
      </RT_ISSUES>
      <RT_PROJECTS>
        <PROJECT>
          <xsl:attribute name=""ID"">
            <xsl:value-of select=""$var:v12"" />
          </xsl:attribute>
          <ID>
            <xsl:value-of select=""$var:v13"" />
          </ID>
          <DBID>
            <xsl:value-of select=""$var:v13"" />
          </DBID>
          <EXTERNALTITLE>
 <xsl:for-each select=""//ENGINEERING-OBJECT"">
        <xsl:choose>
          <xsl:when test=""CATEGORY/.='BASELINE'"">
                     
              <xsl:value-of select=""SHORT-LABEL/."" />


          </xsl:when>
        </xsl:choose>
      </xsl:for-each>
</EXTERNALTITLE>
        </PROJECT>
      </RT_PROJECTS>
      <RT_RELEASES>
        <xsl:for-each select=""ISSUES/ISSUE/ISSUE-ENVIRONMENT/ENGINEERING-OBJECTS/ENGINEERING-OBJECT"">
          <xsl:variable name=""var:v14"" select=""userCSharp:StringConcat(&quot;REL_1&quot;)"" />
          <xsl:variable name=""var:v15"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
          <xsl:variable name=""var:v17"" select=""userCSharp:StringConcat(&quot;PRO_1&quot;)"" />
          <RELEASE>
            <xsl:attribute name=""ID"">
              <xsl:value-of select=""$var:v14"" />
            </xsl:attribute>
            <DBID>
              <xsl:value-of select=""$var:v15"" />
            </DBID>
            <ID>
              <xsl:value-of select=""$var:v15"" />
            </ID>
            <EXTERNALDESCRIPTION>
              <xsl:value-of select=""SHORT-LABEL/text()"" />
            </EXTERNALDESCRIPTION>
            <PLANNEDDATE>
              <xsl:value-of select=""$var:v15"" />
            </PLANNEDDATE>
            <xsl:variable name=""var:v16"" select=""userCSharp:UnknownDeliveryMilestone(string(../../../ISSUE-PLANNING-INFOS/DELIVERY-MILESTONES/DELIVERY-MILESTONE/text()))"" />
            <EXTERNALTITLE>
              <xsl:value-of select=""$var:v16"" />
            </EXTERNALTITLE>
            <BELONGSTOPROJECT>
              <xsl:attribute name=""ID-REF"">
                <xsl:value-of select=""$var:v17"" />
              </xsl:attribute>
            </BELONGSTOPROJECT>
          </RELEASE>
        </xsl:for-each>
      </RT_RELEASES>
      <RT_IRMAPS>
        <IRMAP>
          <DBID>
            <xsl:value-of select=""$var:v2"" />
          </DBID>
          <HASMAPPEDISSUE>
            <xsl:attribute name=""ID-REF"">
              <xsl:value-of select=""$var:v1"" />
            </xsl:attribute>
            <xsl:value-of select=""$var:v2"" />
          </HASMAPPEDISSUE>
          <HASMAPPEDRELEASE>
            <xsl:attribute name=""ID-REF"">
              <xsl:value-of select=""$var:v18"" />
            </xsl:attribute>
            <xsl:value-of select=""$var:v2"" />
          </HASMAPPEDRELEASE>
          <ISPILOT>
            <xsl:value-of select=""$var:v19"" />
          </ISPILOT>
          <xsl:variable name=""var:v20"" select=""userCSharp:GetDateInFormat()"" />
          <xsl:call-template name=""IRMExternalTags"">
            <xsl:with-param name=""Date"" select=""string($var:v20)"" />
          </xsl:call-template>
          <EXTERNALEXCHANGEWORKFLOW>
  <xsl:for-each select=""//RELATED-ISSUE/ISSUE-RELATION"">
    <xsl:choose>
      <xsl:when test="". = 'CP'"">BMW_ASAM301_CP</xsl:when>
    <xsl:when test="". = 'PR'"">BMW_ASAM301_PR</xsl:when>
    </xsl:choose>
  </xsl:for-each>
</EXTERNALEXCHANGEWORKFLOW>
          <EXTERNAL_ID>
    <xsl:choose>
      <xsl:when test=""//COMPANY-ISSUE-INFO/COMPANY-REF/. = 'BMW'"">
        <xsl:value-of select=""//COMPANY-ISSUE-INFO/ISSUE-ID/."" />
      </xsl:when>
      <xsl:otherwise>
      </xsl:otherwise>
    </xsl:choose>
</EXTERNAL_ID>
          <EXTERNALTITLE>
            <xsl:value-of select=""ISSUES/ISSUE/LONG-NAME/text()"" />
          </EXTERNALTITLE>
          <EXTERNALSTATE_PARALLEL1>
            <xsl:value-of select=""ISSUES/ISSUE/ISSUE-PLANNING-INFOS/ISSUE-CURRENT-STATE/ISSUE-STATE/text()"" />
          </EXTERNALSTATE_PARALLEL1>
          <xsl:for-each select=""ISSUES/ISSUE/ANNOTATIONS"">
            <xsl:for-each select=""ANNOTATION"">
              <xsl:call-template name=""SetDatetoExternalConversation"">
                <xsl:with-param name=""Date"" select=""string(DATE/text())"" />
              </xsl:call-template>
            </xsl:for-each>
          </xsl:for-each>
          <xsl:variable name=""var:v21"" select=""userCSharp:GetDateInFormat()"" />
          <EXTERNALLASTIMPORTEDDATE>
            <xsl:value-of select=""$var:v21"" />
          </EXTERNALLASTIMPORTEDDATE>
          <EXTERNALNEXTSTATE>
            <xsl:value-of select=""$var:v2"" />
          </EXTERNALNEXTSTATE>
        </IRMAP>
      </RT_IRMAPS>
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


public string StringConcat(string param0, string param1, string param2, string param3)
{
   return param0 + param1 + param2 + param3;
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


public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}


public string UnknownDeliveryMilestone(string sDeliveryMileStone)
{
          if(sDeliveryMileStone == null 
                  || sDeliveryMileStone.Trim() == String.Empty)
         {
                   return ""PST-unknown"";
         }
         else
        {
                   return sDeliveryMileStone;
        }
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
  <xsl:template name=""IRMExternalTags"">
  <xsl:param name=""Date"" />

  <EXTERNALTAGS>
    <EXTERNALTAG ACTION=""APPEND"">
      <P>
        <xsl:text>&lt;CreationDate&gt;</xsl:text>
        <xsl:value-of select=""//ADMIN-DATA/DOC-REVISIONS/DOC-REVISION/DATE/."" />
        <xsl:text>&lt;/CreationDate&gt;</xsl:text>
      </P>
      <xsl:for-each select=""//DELIVERY-MILESTONES"">
        <P>
          <xsl:text>&lt;Delivery-Milestone Date=""</xsl:text>
          <xsl:value-of select=""$Date"" />
          <xsl:text>""&gt;</xsl:text>
          <xsl:value-of select=""//DELIVERY-MILESTONE/."" />
          <xsl:text>&lt;/Delivery-Milestone&gt;</xsl:text>
        </P>
      </xsl:for-each>
      <xsl:for-each select=""//ENGINEERING-OBJECTS/ENGINEERING-OBJECT"">    
<P>
 <xsl:text>&lt;</xsl:text>
          <xsl:value-of select=""CATEGORY/."" />
          <xsl:text>&gt;</xsl:text>
          <xsl:value-of select=""SHORT-LABEL/."" />
          <xsl:text>&lt;/</xsl:text>
          <xsl:value-of select=""CATEGORY/."" />
          <xsl:text>&gt;</xsl:text>
  
</P>
      </xsl:for-each>
      <xsl:for-each select=""//DOC-REVISIONS"">
        <P>
          <xsl:text>&lt;CustomerDate State=""</xsl:text>
          <xsl:value-of select=""//ISSUE-STATE/."" />
          <xsl:text>""&gt;</xsl:text>
          <xsl:value-of select=""//DOC-REVISION/DATE/."" />
          <xsl:text>&lt;/CustomerDate&gt;</xsl:text>
        </P>
      </xsl:for-each>

    </EXTERNALTAG>
  </EXTERNALTAGS>
</xsl:template>
  <xsl:template name=""SetDatetoExternalConversation"">
  <xsl:param name=""Date"" />
  <EXTERNALCONVERSATION ACTION=""APPEND"">
    <P>### <xsl:value-of select=""$Date"" /> # <xsl:value-of select=""//ISSUE-STATE/."" /> # <xsl:value-of select=""//TEAM-MEMBER-REF/@ID-REF"" /> ###</P>
    <xsl:for-each select=""//ANNOTATION-TEXT/P"">
      <P><xsl:value-of select=""."" /></P>
    </xsl:for-each>
  </EXTERNALCONVERSATION>
</xsl:template>
  <xsl:template name=""GetAttachments"">
<xsl:param name=""param1"" />


<ATTACHMENTS TYPE=""ATTACHMENT"">
    <xsl:variable name=""counter"" select=""count(//ISSUES/ISSUE/ISSUE-RELATED-DOCUMENTS/ISSUE-RELATED-DOCUMENT[child::XDOC/URL!=''])"" />    
          <xsl:for-each select=""//ISSUES/ISSUE/ISSUE-RELATED-DOCUMENTS/ISSUE-RELATED-DOCUMENT[child::XDOC/URL!='']"">
          <ATTACHMENT>
            <NAME>
                <xsl:value-of select=""XDOC/URL/."" />
            </NAME>
           <DESCRIPTION> 
               <P><xsl:text>OrgReqDoc -</xsl:text> ATT00<xsl:value-of select=""position()"" />:<xsl:value-of select=""$param1"" /></P> 
           </DESCRIPTION> 
            <FULL_NAME>
                <xsl:value-of select=""XDOC/URL/."" />
            </FULL_NAME>
          </ATTACHMENT>
        </xsl:for-each>        
        <xsl:for-each select=""//ISSUE/ISSUE-SOLUTIONS/ISSUE-SOLUTION""> 
            <xsl:choose>
              <xsl:when test=""CATEGORY/. = 'PROPOSAL' or CATEGORY/. = 'SOLUTION' or CATEGORY/. = 'TESTSPECIFICATION'"">
             <xsl:for-each select=""ISSUE-RELATED-DOCUMENTS/ISSUE-RELATED-DOCUMENT[child::XDOC/URL!='']"">
                   <ATTACHMENT>
                      <NAME>
                           <xsl:value-of select=""XDOC/URL/."" />
                     </NAME>
                    <DESCRIPTION>
                     <P><xsl:text>OrgReqDoc -</xsl:text> ATT00<xsl:value-of select=""$counter+position()"" />:<xsl:value-of select=""$param1"" /></P> 
                      </DESCRIPTION> 
            <FULL_NAME>
                <xsl:value-of select=""XDOC/URL/."" />
            </FULL_NAME>
                  </ATTACHMENT>
                </xsl:for-each>
              </xsl:when>
            </xsl:choose>
        </xsl:for-each>
      </ATTACHMENTS>
</xsl:template>
  <xsl:template name=""GetExternalAttachmentData"">
      <xsl:param name=""param1"" />
      <EXTERNALEXCHANGEDATTACH ACTION=""APPEND"">     
          <xsl:variable name=""counter"" select=""count(//ISSUES/ISSUE/ISSUE-RELATED-DOCUMENTS/ISSUE-RELATED-DOCUMENT[child::XDOC/URL!=''])"" />  
      <xsl:for-each select=""//ISSUES/ISSUE/ISSUE-RELATED-DOCUMENTS/ISSUE-RELATED-DOCUMENT[child::XDOC/URL!='']"">
    <xsl:if test=""position() = 1"">       
   <P>### <xsl:value-of select=""//ISSUE-PLANNING-INFOS/ISSUE-CURRENT-STATE/ISSUE-STATE/."" /> <xsl:value-of select=""$param1"" /> ###</P>                 
    </xsl:if>
     <P>ATT00<xsl:value-of select=""position()"" />:<xsl:value-of select=""$param1"" /> <xsl:text>- </xsl:text><xsl:value-of select=""XDOC/URL/."" /></P>
       </xsl:for-each>
        <xsl:for-each select=""//ISSUE/ISSUE-SOLUTIONS/ISSUE-SOLUTION"">
            <xsl:choose>
              <xsl:when test=""CATEGORY/. = 'PROPOSAL' or CATEGORY/. = 'SOLUTION' or CATEGORY/. = 'TESTSPECIFICATION'"">
                <xsl:for-each select=""ISSUE-RELATED-DOCUMENTS/ISSUE-RELATED-DOCUMENT[child::XDOC/URL!='']"">
    <xsl:if test=""$counter+position() = 1"">       
   <P>### <xsl:value-of select=""//ISSUE-PLANNING-INFOS/ISSUE-CURRENT-STATE/ISSUE-STATE/."" /> <xsl:value-of select=""$param1"" /> ###</P>                 
     </xsl:if>
     <P> ATT00<xsl:value-of select=""$counter+position()"" />:<xsl:value-of select=""$param1"" /> <xsl:text>- </xsl:text><xsl:value-of select=""XDOC/URL/."" /></P>
          </xsl:for-each>
          </xsl:when>
            </xsl:choose>
          </xsl:for-each>
        </EXTERNALEXCHANGEDATTACH>
    </xsl:template>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"RB.ROCustomerInterface.Schema.BMW.ASAM_ISSUE_V3_0_1_proposed";
        
        private const global::RB.ROCustomerInterface.Schema.BMW.ASAM_ISSUE_V3_0_1_proposed _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"RB.ROCustomerInterface.Schema.BMW.ASAM_ISSUE_V3_0_1_proposed";
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
