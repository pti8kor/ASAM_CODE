namespace RB.ROCustomerInterface {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.BMW.ASAM_ISSUE_V3_0_1_proposed", typeof(global::RB.ROCustomerInterface.Schema.BMW.ASAM_ISSUE_V3_0_1_proposed))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM", typeof(global::RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM))]
    public sealed class BMW_IMF_Map : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp ScriptNS0"" version=""1.0"" xmlns:ns0=""http://RB.ROCustomerInterface.RB"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/MSR-ISSUE"" />
  </xsl:template>
  <xsl:template match=""/MSR-ISSUE"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;ISS_1&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
    <xsl:variable name=""var:v8"" select=""userCSharp:StringConcat(&quot;REL_1&quot;)"" />
    <ns0:ASAMISSUE_EXTRACT>
      <RT_CONTACT>
        
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
                <xsl:value-of select=""//COMPANY/SHORT-NAME[.='BMW']/following-sibling::TEAM-MEMBERS/TEAM-MEMBER[1]/PHONE/."" />                
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
                    <xsl:value-of select=""normalize-space(substring-after(LONG-NAME/., ','))"" />
                  <!--<xsl:value-of select=""LONG-NAME/.""/>-->
                </LASTNAME>
                <FIRSTNAME>
                    <xsl:value-of select=""normalize-space(substring-before(LONG-NAME/., ','))"" />
                  <!--<xsl:value-of select=""SHORT-NAME/.""/>-->
                </FIRSTNAME>
                <PHONENUMBERS>
                  <xsl:value-of select=""PHONE/."" />
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
              </CONTACT>
            </xsl:for-each>
            
          </xsl:otherwise>
        </xsl:choose>
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
            <P>
              <xsl:value-of select=""$var:v2"" />
            </P>
            <P>Description: </P>
            <xsl:for-each select=""//ISSUE-DESC/P"">
    <P>
        <xsl:value-of select=""."" />
     </P>
  </xsl:for-each>
            <xsl:for-each select=""//ISSUE-SOLUTION/ISSUE-SOLUTION-DESC"">
    <xsl:choose>
      <xsl:when test=""//ISSUE-SOLUTION/CATEGORY/. = 'PROPOSAL'"">
        <P>
          Proposal: <xsl:value-of select=""."" />
        </P>
      </xsl:when>
      <xsl:when test=""//ISSUE-SOLUTION/CATEGORY/. = 'SOLUTION'"">
        <P>
          Solution: <xsl:value-of select=""."" />
        </P>
      </xsl:when>
      <xsl:when test=""//ISSUE-SOLUTION/CATEGORY/. = 'TESTSPECIFICATION'"">
        <P>
          Testspecification: <xsl:value-of select=""."" />
        </P>
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
          <ISSUETAGS>
            <ISSUETAG>
              <P>
                <xsl:value-of select=""$var:v2"" />
              </P>
            </ISSUETAG>
          </ISSUETAGS>
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
          <EXTERNALSTATE_PARALLEL1>
            <xsl:value-of select=""ISSUES/ISSUE/ISSUE-PLANNING-INFOS/ISSUE-CURRENT-STATE/ISSUE-STATE/text()"" />
          </EXTERNALSTATE_PARALLEL1>
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
            <P>Description: </P>
            <xsl:for-each select=""//ISSUE-DESC/P"">
    <P>
        <xsl:value-of select=""."" />
     </P>
  </xsl:for-each>
            <xsl:for-each select=""//ISSUE-SOLUTION/ISSUE-SOLUTION-DESC"">
    <xsl:choose>
      <xsl:when test=""//ISSUE-SOLUTION/CATEGORY/. = 'PROPOSAL'"">
        <P>
          Proposal: <xsl:value-of select=""."" />
        </P>
      </xsl:when>
      <xsl:when test=""//ISSUE-SOLUTION/CATEGORY/. = 'SOLUTION'"">
        <P>
          Solution: <xsl:value-of select=""."" />
        </P>
      </xsl:when>
      <xsl:when test=""//ISSUE-SOLUTION/CATEGORY/. = 'TESTSPECIFICATION'"">
        <P>
          Testspecification: <xsl:value-of select=""."" />
        </P>
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
            <xsl:attribute name=""ACTION"">
              <xsl:text>APPEND</xsl:text>
            </xsl:attribute>
            <P>
              <xsl:value-of select=""$var:v2"" />
            </P>
          </EXTERNALCONVERSATION>
          <EXTERNALEXCHANGEWORKFLOW>
            <xsl:value-of select=""$var:v2"" />
          </EXTERNALEXCHANGEWORKFLOW>
          <EXTERNALLASTEXPORTEDDATE>
            <xsl:value-of select=""$var:v2"" />
          </EXTERNALLASTEXPORTEDDATE>
          <EXTERNALLASTIMPORTEDDATE> 
        <xsl:value-of select=""//ADMIN-DATA/DOC-REVISIONS/DOC-REVISION/DATE/."" />
</EXTERNALLASTIMPORTEDDATE>
          <xsl:variable name=""var:v3"" select=""ScriptNS0:GetOrchestrationVaraibles(&quot;ExchangeProtocolID&quot;)"" />
          <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(string(ISSUES/ISSUE/ISSUE-PLANNING-INFOS/ISSUE-CURRENT-STATE/ISSUE-STATE/text()) , &quot; - ExchangeProtocol: &quot; , string($var:v3))"" />
          <EXTERNALHISTORY>
            <xsl:value-of select=""$var:v4"" />
          </EXTERNALHISTORY>
          <ATTACHMENTS TYPE=""ATTACHMENTS"">
        <xsl:for-each select=""//ISSUE/ISSUE-RELATED-DOCUMENTS/ISSUE-RELATED-DOCUMENT"">
          <ATTACHMENT>
            <PATH>
              <xsl:value-of select=""XDOC/URL/."" />
            </PATH>
            <LABEL>
              <xsl:value-of select=""XDOC/LONG-NAME-1/."" />
            </LABEL>
           <CONTENT />
          </ATTACHMENT>
        </xsl:for-each>        
        <xsl:for-each select=""//ISSUE/ISSUE-SOLUTIONS/ISSUE-SOLUTION""> 
            <xsl:choose>
              <xsl:when test=""CATEGORY/. = 'PROPOSAL' or CATEGORY/. = 'SOLUTION' or CATEGORY/. = 'TESTSPECIFICATION'"">
                <xsl:for-each select=""ISSUE-RELATED-DOCUMENTS/ISSUE-RELATED-DOCUMENT"">
                  <ATTACHMENT>
                    <PATH>
                      <xsl:value-of select=""XDOC/URL/."" />
                    </PATH>
                    <LABEL>
                      <xsl:value-of select=""XDOC/LONG-NAME-1/."" />
                    </LABEL>
                    <CONTENT /> 
                  </ATTACHMENT>
                </xsl:for-each>
              </xsl:when>
            </xsl:choose>
        </xsl:for-each>
      </ATTACHMENTS>
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
          <OCCURANCE>
            <xsl:value-of select=""$var:v2"" />
          </OCCURANCE>
          <SEVERITY>
            <xsl:value-of select=""$var:v2"" />
          </SEVERITY>
        </ISSUE>
      </RT_ISSUES>
      <RT_RELEASES>
        <xsl:for-each select=""ISSUES/ISSUE/ISSUE-PLANNING-INFOS/DELIVERY-MILESTONES"">
          <xsl:for-each select=""DELIVERY-MILESTONE"">
            <xsl:variable name=""var:v6"" select=""userCSharp:StringConcat(&quot;REL_1&quot;)"" />
            <xsl:variable name=""var:v7"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
            <RELEASE>
              <xsl:attribute name=""ID"">
                <xsl:value-of select=""$var:v6"" />
              </xsl:attribute>
              <DBID>
                <xsl:value-of select=""$var:v7"" />
              </DBID>
              <ID>
                <xsl:value-of select=""$var:v7"" />
              </ID>
              <TITLE>
                <xsl:value-of select=""$var:v7"" />
              </TITLE>
              <PLANNEDDATE>
                <xsl:value-of select=""$var:v7"" />
              </PLANNEDDATE>
              <EXTERNAL_ID>
                <xsl:value-of select=""./text()"" />
              </EXTERNAL_ID>
              <EXTERNALTITLE>
                <xsl:value-of select=""../../../ISSUE-ENVIRONMENT/ENGINEERING-OBJECTS/ENGINEERING-OBJECT/SHORT-LABEL/text()"" />
              </EXTERNALTITLE>
            </RELEASE>
          </xsl:for-each>
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
              <xsl:value-of select=""$var:v8"" />
            </xsl:attribute>
            <xsl:value-of select=""$var:v2"" />
          </HASMAPPEDRELEASE>
          <ISPILOT>
            <xsl:value-of select=""$var:v2"" />
          </ISPILOT>
          <EXTERNALNEXTSTATE>
            <xsl:value-of select=""$var:v2"" />
          </EXTERNALNEXTSTATE>
          <xsl:variable name=""var:v9"" select=""userCSharp:GetDateInFormat()"" />
          <xsl:call-template name=""IRMExternalTags"">
            <xsl:with-param name=""Date"" select=""string($var:v9)"" />
          </xsl:call-template>
          <EXCHANGEWORKFLOW>
  <xsl:for-each select=""//RELATED-ISSUE/ISSUE-RELATION"">
    <xsl:choose>
      <xsl:when test="". = 'CP'"">
      BMW_ASAM310_CP
    </xsl:when>
    <xsl:when test="". = 'PR'"">
      BMW_ASAM310_PR
    </xsl:when>
    </xsl:choose>
  </xsl:for-each>
</EXCHANGEWORKFLOW>
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
          <xsl:variable name=""var:v10"" select=""userCSharp:GetDateInFormat()"" />
          <xsl:call-template name=""SetDatetoExternalConversation"">
            <xsl:with-param name=""Date"" select=""string($var:v10)"" />
          </xsl:call-template>
        </IRMAP>
      </RT_IRMAPS>
    </ns0:ASAMISSUE_EXTRACT>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string GetDateInFormat()
{
         string strDate;
         strDate = System.DateTime.Parse(DateTime.Today.ToString()).ToString(""yyyyMMdd"");
        return strDate;
}

public string StringConcat(string param0)
{
   return param0;
}


public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}



]]></msxsl:script>
  <xsl:template name=""IRMExternalTags"">
<xsl:param name=""Date"" />
<EXTERNALTAGS>
  <EXTERNALTAG ACTION=""APPEND"">
  <xsl:for-each select=""//DELIVERY-MILESTONES"">
    <P><xsl:value-of select=""$Date"" />_Delivery-Milestone: <xsl:value-of select=""//DELIVERY-MILESTONE/."" /></P>
  </xsl:for-each>

  <xsl:for-each select=""//ENGINEERING-OBJECTS"">
      <xsl:choose>
      <xsl:when test=""ENGINEERING-OBJECT/CATEGORY/.='BASELINE' or ENGINEERING-OBJECT/CATEGORY/.='INTEGRATIONLEVEL'"">
        <P>
          Baseline: <xsl:value-of select=""ENGINEERING-OBJECT/SHORT-LABEL/."" />
        </P>
      </xsl:when>
      </xsl:choose>
  </xsl:for-each>


  <xsl:for-each select=""//DOC-REVISIONS"">
     <P>
     CustomerDate{<xsl:value-of select=""//ISSUE-STATE/."" />}: <xsl:value-of select=""//DOC-REVISION/DATE/."" />
     </P>
  </xsl:for-each>

  </EXTERNALTAG>
</EXTERNALTAGS>
</xsl:template>
  <xsl:template name=""SetDatetoExternalConversation"">
<xsl:param name=""Date"" />

<EXTERNALCONVERSATION ACTION=""APPEND"">
    <P><xsl:value-of select=""//ISSUE-STATE/."" /> : <xsl:value-of select=""$Date"" /></P>
    <xsl:for-each select=""//ANNOTATION-TEXT/P"">
	<P><xsl:value-of select=""."" /></P>
      </xsl:for-each>
</EXTERNALCONVERSATION>
</xsl:template>
  <xsl:template name=""GetExternalAttachmentData"">
<xsl:param name=""param1"" />

 <EXTERNALEXCHANGEDATTACH ACTION=""APPEND"">
        <P>
          ### <xsl:value-of select=""//ISSUE-PLANNING-INFOS/ISSUE-CURRENT-STATE/ISSUE-STATE/."" /> <xsl:value-of select=""$param1"" /> ###
        </P>                
        <xsl:for-each select=""//ISSUE/ISSUE-RELATED-DOCUMENTS/ISSUE-RELATED-DOCUMENT"">          
            <P>
              <xsl:value-of select=""XDOC/URL/."" />
            </P>
        </xsl:for-each>
        <xsl:for-each select=""//ISSUE/ISSUE-SOLUTIONS/ISSUE-SOLUTION"">
          <xsl:choose>
            <xsl:when test=""CATEGORY/. = 'PROPOSAL' or CATEGORY/. = 'SOLUTION' or CATEGORY/. = 'TESTSPECIFICATION'"">
              <xsl:for-each select=""ISSUE-RELATED-DOCUMENTS/ISSUE-RELATED-DOCUMENT"">                
                  <P>
                    <xsl:value-of select=""XDOC/URL/."" />
                  </P>
              </xsl:for-each>
            </xsl:when>
          </xsl:choose>
        </xsl:for-each>
      </EXTERNALEXCHANGEDATTACH>

</xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""RB.ROCustomerIntefaceLibrary, Version=1.0.2.3, Culture=neutral, PublicKeyToken=55495bc4c1159231"" ClassName=""RB.ROCustomerIntefaceLibrary.BTHelper"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"RB.ROCustomerInterface.Schema.BMW.ASAM_ISSUE_V3_0_1_proposed";
        
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
