namespace DBMapper {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DBMapper.DBMapperType", typeof(global::DBMapper.DBMapperType))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DBMapper.TableOperation_dbo_VW2RBMapping+Select", typeof(global::DBMapper.TableOperation_dbo_VW2RBMapping.Select))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TableOp/dbo/VW2RBMapping"" xmlns:s0=""http://DBMapper.Schema"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:VWPartnumberMappings"" />
  </xsl:template>
  <xsl:template match=""/s0:VWPartnumberMappings"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;*&quot;)"" />
    <ns0:Select>
      <ns0:Columns>
        <xsl:value-of select=""$var:v1"" />
      </ns0:Columns>
      <xsl:variable name=""var:v2"" select=""userCSharp:InitCumulativeConcat(0)"" />
      <xsl:for-each select=""Mapping"">
        <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;CUST_TN = '&quot; , string(CUSTTN/text()) , &quot;' OR &quot;)"" />
        <xsl:variable name=""var:v4"" select=""userCSharp:AddToCumulativeConcat(0,string($var:v3),&quot;1&quot;)"" />
      </xsl:for-each>
      <xsl:variable name=""var:v5"" select=""userCSharp:GetCumulativeConcat(0)"" />
      <xsl:variable name=""var:v6"" select=""userCSharp:StringSize(string($var:v5))"" />
      <xsl:variable name=""var:v7"" select=""userCSharp:MathSubtract(string($var:v6) , &quot;4&quot;)"" />
      <xsl:variable name=""var:v8"" select=""userCSharp:StringLeft(string($var:v5) , string($var:v7))"" />
      <xsl:variable name=""var:v9"" select=""userCSharp:StringConcat(&quot;where &quot; , string($var:v8))"" />
      <ns0:Query>
        <xsl:value-of select=""$var:v9"" />
      </ns0:Query>
    </ns0:Select>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string InitCumulativeConcat(int index)
{
	if (index >= 0)
	{
		if (index >= myCumulativeConcatArray.Count)
		{
			int i = myCumulativeConcatArray.Count;
			for (; i<=index; i++)
			{
				myCumulativeConcatArray.Add("""");
			}
		}
		else
		{
			myCumulativeConcatArray[index] = """";
		}
	}
	return """";
}

public System.Collections.ArrayList myCumulativeConcatArray = new System.Collections.ArrayList();

public string AddToCumulativeConcat(int index, string val, string notused)
{
	if (index < 0 || index >= myCumulativeConcatArray.Count)
	{
		return """";
	}
	myCumulativeConcatArray[index] = (string)(myCumulativeConcatArray[index]) + val;
	return myCumulativeConcatArray[index].ToString();
}

public string GetCumulativeConcat(int index)
{
	if (index < 0 || index >= myCumulativeConcatArray.Count)
	{
		return """";
	}
	return myCumulativeConcatArray[index].ToString();
}

public string StringConcat(string param0)
{
   return param0;
}


public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}


public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public string StringLeft(string str, string count)
{
	string retval = """";
	double d = 0;
	if (str != null && IsNumeric(count, ref d))
	{
		int i = (int) d;
		if (i > 0)
		{ 
			if (i <= str.Length)
			{
				retval = str.Substring(0, i);
			}
			else
			{
				retval = str;
			}
		}
	}
	return retval;
}


public int StringSize(string str)
{
	if (str == null)
	{
		return 0;
	}
	return str.Length;
}


public string MathSubtract(string param0, string param1)
{
	System.Collections.ArrayList listValues = new System.Collections.ArrayList();
	listValues.Add(param0);
	listValues.Add(param1);
	double ret = 0;
	bool first = true;
	foreach (string obj in listValues)
	{
		if (first)
		{
			first = false;
			double d = 0;
			if (IsNumeric(obj, ref d))
			{
				ret = d;
			}
			else
			{
				return """";
			}
		}
		else
		{
			double d = 0;
			if (IsNumeric(obj, ref d))
			{
				ret -= d;
			}
			else
			{
				return """";
			}
		}
	}
	return ret.ToString(System.Globalization.CultureInfo.InvariantCulture);
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
        
        private const string _strTrgSchemasList0 = @"DBMapper.TableOperation_dbo_VW2RBMapping+Select";
        
        private const global::DBMapper.TableOperation_dbo_VW2RBMapping.Select _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DBMapper.DBMapperType";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DBMapper.TableOperation_dbo_VW2RBMapping+Select";
                return _TrgSchemas;
            }
        }
    }
}
