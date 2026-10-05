namespace DBMapper {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DBMapper.DBMapperType", typeof(global::DBMapper.DBMapperType))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DBMapper.TableOperation_dbo_VW2RBMapping+SelectResponse", typeof(global::DBMapper.TableOperation_dbo_VW2RBMapping.SelectResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DBMapper.DBMapperType", typeof(global::DBMapper.DBMapperType))]
    public sealed class Transform_3 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1 s2 userCSharp"" version=""1.0"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/TableOp/dbo/VW2RBMapping"" xmlns:s1=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:ns0=""http://DBMapper.Schema"" xmlns:s2=""http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:Root"" />
  </xsl:template>
  <xsl:template match=""/s1:Root"">
    <ns0:VWPartnumberMappings>
      <xsl:for-each select=""InputMessagePart_0/ns0:VWPartnumberMappings/Mapping"">
        <xsl:variable name=""var:v1"" select=""userCSharp:LogicalEq(string(CUSTTN/text()) , string(../../../InputMessagePart_1/s0:SelectResponse/s0:SelectResult/s2:VW2RBMapping/s2:CUST_TN/text()))"" />
        <xsl:variable name=""var:v3"" select=""string(CUSTTN/text())"" />
        <xsl:variable name=""var:v4"" select=""string(../../../InputMessagePart_1/s0:SelectResponse/s0:SelectResult/s2:VW2RBMapping/s2:CUST_TN/text())"" />
        <xsl:variable name=""var:v5"" select=""userCSharp:LogicalEq($var:v3 , $var:v4)"" />
        <xsl:variable name=""var:v8"" select=""userCSharp:StringConcat(&quot;&quot;Success&quot;&quot; , string(Resultmessage/text()))"" />
        <Mapping>
          <CUSTTN>
            <xsl:value-of select=""CUSTTN/text()"" />
          </CUSTTN>
          <xsl:if test=""string($var:v1)='true'"">
            <xsl:variable name=""var:v2"" select=""../../../InputMessagePart_1/s0:SelectResponse/s0:SelectResult/s2:VW2RBMapping/s2:RB_TTN/text()"" />
            <RBTTN>
              <xsl:value-of select=""$var:v2"" />
            </RBTTN>
          </xsl:if>
          <xsl:if test=""string($var:v5)='true'"">
            <xsl:variable name=""var:v6"" select=""../../../InputMessagePart_1/s0:SelectResponse/s0:SelectResult/s2:VW2RBMapping/s2:RB_RELTYPE/text()"" />
            <RBRELTYPE>
              <xsl:value-of select=""$var:v6"" />
            </RBRELTYPE>
          </xsl:if>
          <xsl:if test=""string($var:v5)='true'"">
            <xsl:variable name=""var:v7"" select=""../../../InputMessagePart_1/s0:SelectResponse/s0:SelectResult/s2:VW2RBMapping/s2:RB_SGBEZ/text()"" />
            <RBSGBEZ>
              <xsl:value-of select=""$var:v7"" />
            </RBSGBEZ>
          </xsl:if>
          <Resultmessage>
            <xsl:value-of select=""$var:v8"" />
          </Resultmessage>
          <xsl:value-of select=""./text()"" />
        </Mapping>
      </xsl:for-each>
    </ns0:VWPartnumberMappings>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
	}
	return ret;
}


public string StringConcat(string param0, string param1)
{
   return param0 + param1;
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
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DBMapper.DBMapperType";
        
        private const global::DBMapper.DBMapperType _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"DBMapper.TableOperation_dbo_VW2RBMapping+SelectResponse";
        
        private const global::DBMapper.TableOperation_dbo_VW2RBMapping.SelectResponse _srcSchemaTypeReference1 = null;
        
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
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"DBMapper.DBMapperType";
                _SrcSchemas[1] = @"DBMapper.TableOperation_dbo_VW2RBMapping+SelectResponse";
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
