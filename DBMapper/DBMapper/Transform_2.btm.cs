namespace DBMapper {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DBMapper.TableOperation_dbo_VW2RBMapping+SelectResponse", typeof(global::DBMapper.TableOperation_dbo_VW2RBMapping.SelectResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DBMapper.DBMapperType", typeof(global::DBMapper.DBMapperType))]
    public sealed class Transform_2 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1 userCSharp"" version=""1.0"" xmlns:s1=""http://schemas.microsoft.com/Sql/2008/05/TableOp/dbo/VW2RBMapping"" xmlns:ns0=""http://DBMapper.Schema"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:SelectResponse"" />
  </xsl:template>
  <xsl:template match=""/s1:SelectResponse"">
    <ns0:VWPartnumberMappings>
      <xsl:for-each select=""s1:SelectResult"">
        <xsl:for-each select=""s0:VW2RBMapping"">
          <xsl:variable name=""var:v1"" select=""userCSharp:StringTrimRight(string(s0:CUST_TN/text()))"" />
          <xsl:variable name=""var:v2"" select=""userCSharp:StringTrimRight(string(s0:RB_TTN/text()))"" />
          <xsl:variable name=""var:v3"" select=""userCSharp:StringTrimRight(string(s0:RB_RELTYPE/text()))"" />
          <xsl:variable name=""var:v4"" select=""userCSharp:StringTrimRight(string(s0:RB_SGBEZ/text()))"" />
          <xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(&quot;1&quot;)"" />
          <xsl:variable name=""var:v6"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
          <Mapping>
            <CUSTTN>
              <xsl:value-of select=""$var:v1"" />
            </CUSTTN>
            <RBTTN>
              <xsl:value-of select=""$var:v2"" />
            </RBTTN>
            <RBRELTYPE>
              <xsl:value-of select=""$var:v3"" />
            </RBRELTYPE>
            <RBSGBEZ>
              <xsl:value-of select=""$var:v4"" />
            </RBSGBEZ>
            <Resultstatus>
              <xsl:value-of select=""$var:v5"" />
            </Resultstatus>
            <Resultmessage>
              <xsl:value-of select=""$var:v6"" />
            </Resultmessage>
            <xsl:value-of select=""./text()"" />
          </Mapping>
        </xsl:for-each>
      </xsl:for-each>
    </ns0:VWPartnumberMappings>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringTrimRight(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.TrimEnd(null);
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
        
        private const string _strSrcSchemasList0 = @"DBMapper.TableOperation_dbo_VW2RBMapping+SelectResponse";
        
        private const global::DBMapper.TableOperation_dbo_VW2RBMapping.SelectResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DBMapper.DBMapperType";
        
        private const global::DBMapper.DBMapperType _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DBMapper.TableOperation_dbo_VW2RBMapping+SelectResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DBMapper.DBMapperType";
                return _TrgSchemas;
            }
        }
    }
}
