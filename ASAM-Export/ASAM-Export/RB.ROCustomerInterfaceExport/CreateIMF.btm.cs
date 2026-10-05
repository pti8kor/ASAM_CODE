namespace RB.ROCustomerInterfaceExport {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterfaceExport.Schemas.RO_Extract.RQ1Extract", typeof(global::RB.ROCustomerInterfaceExport.Schemas.RO_Extract.RQ1Extract))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF", typeof(global::RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF))]
    public sealed class CreateIMF : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/RQ1_EXTRACT"" />
  </xsl:template>
  <xsl:template match=""/RQ1_EXTRACT"">
    <ns0:EXPORT_IMF>
      <xsl:for-each select=""Issues"">
        <xsl:for-each select=""Issue"">
          <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
          <ISSUE>
            <xsl:attribute name=""dbid"">
              <xsl:value-of select=""@dbid"" />
            </xsl:attribute>
            <CommercialQuotationReq>
              <xsl:value-of select=""$var:v1"" />
            </CommercialQuotationReq>
            <ExternalComment>
              <xsl:value-of select=""ExternalComment/text()"" />
            </ExternalComment>
            <ExternalConversation>
              <xsl:value-of select=""ExternalConversation/text()"" />
            </ExternalConversation>
            <ExternalExchangedAttach>
              <xsl:value-of select=""ExternalExchangedAttach/text()"" />
            </ExternalExchangedAttach>
            <ExternalHistory>
              <xsl:value-of select=""ExternalHistory/text()"" />
            </ExternalHistory>
            <xsl:variable name=""var:v2"" select=""userCSharp:GetDateInFormat()"" />
            <ExternalLastExportedDate>
              <xsl:value-of select=""$var:v2"" />
            </ExternalLastExportedDate>
            <ExternalNextState>
              <xsl:value-of select=""ExternalNextState/text()"" />
            </ExternalNextState>
            <ExternalState_Parallel1>
              <xsl:value-of select=""ExternalState_Parallel1/text()"" />
            </ExternalState_Parallel1>
            <ExternalState_Parallel2>
              <xsl:value-of select=""ExternalState_Parallel2/text()"" />
            </ExternalState_Parallel2>
            <ExternalUpdateVersion>
              <xsl:value-of select=""ExternalUpdateVersion/text()"" />
            </ExternalUpdateVersion>
          </ISSUE>
        </xsl:for-each>
      </xsl:for-each>
      <ISSUERELEASEMAP>
        <xsl:attribute name=""dbid"">
          <xsl:value-of select=""IssueReleaseMaps/IssueReleaseMap/dbid/text()"" />
        </xsl:attribute>
        <ExternalComment>
          <xsl:value-of select=""IssueReleaseMaps/IssueReleaseMap/ExternalComment/text()"" />
        </ExternalComment>
        <ExternalConversation>
          <xsl:value-of select=""IssueReleaseMaps/IssueReleaseMap/ExternalConversation/text()"" />
        </ExternalConversation>
        <xsl:variable name=""var:v3"" select=""userCSharp:GetDateInFormat()"" />
        <ExternalLastExportedDate>
          <xsl:value-of select=""$var:v3"" />
        </ExternalLastExportedDate>
        <ExternalNextState>
          <xsl:value-of select=""IssueReleaseMaps/IssueReleaseMap/ExternalNextState/text()"" />
        </ExternalNextState>
        <ExternalState_Parallel1>
          <xsl:value-of select=""IssueReleaseMaps/IssueReleaseMap/ExternalState_Parallel1/text()"" />
        </ExternalState_Parallel1>
        <ExternalTags>
          <xsl:value-of select=""IssueReleaseMaps/IssueReleaseMap/ExternalTags/text()"" />
        </ExternalTags>
        <ExternalHistory>
          <xsl:value-of select=""IssueReleaseMaps/IssueReleaseMap/ExternalHistory/text()"" />
        </ExternalHistory>
        <ExternalUpdateVersion>
          <xsl:value-of select=""IssueReleaseMaps/IssueReleaseMap/ExternalUpdateVersion/text()"" />
        </ExternalUpdateVersion>
        <Tags>
          <xsl:value-of select=""IssueReleaseMaps/IssueReleaseMap/Tags/text()"" />
        </Tags>
      </ISSUERELEASEMAP>
      <xsl:for-each select=""Commercials"">
        <xsl:for-each select=""Commercial"">
          <COMMERCIAL>
            <CommercialComment>
              <xsl:value-of select=""CommercialComment/text()"" />
            </CommercialComment>
            <CommercialConversation>
              <xsl:value-of select=""CommercialConversation/text()"" />
            </CommercialConversation>
          </COMMERCIAL>
        </xsl:for-each>
      </xsl:for-each>
    </ns0:EXPORT_IMF>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string GetDateInFormat()
{
      string strFormatedDateTime = DateTime.UtcNow.ToString(""yyyy-MM-ddTHH:mm:ssZ"");

           return strFormatedDateTime;
}


public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"RB.ROCustomerInterfaceExport.Schemas.RO_Extract.RQ1Extract";
        
        private const global::RB.ROCustomerInterfaceExport.Schemas.RO_Extract.RQ1Extract _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF";
        
        private const global::RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"RB.ROCustomerInterfaceExport.Schemas.RO_Extract.RQ1Extract";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF";
                return _TrgSchemas;
            }
        }
    }
}
