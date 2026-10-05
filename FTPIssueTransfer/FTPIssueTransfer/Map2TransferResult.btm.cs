namespace FTPIssueTransfer {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"FTPIssueTransfer.StartImportSchema", typeof(global::FTPIssueTransfer.StartImportSchema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"FTPIssueTransfer.TransferResultInformation", typeof(global::FTPIssueTransfer.TransferResultInformation))]
    public sealed class Map2TransferResult : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://FTPIssueTransfer.FTPFileInformation"" xmlns:s0=""http://FTPIssueTransfer.Schema1"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:FTPImportRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:FTPImportRequest"">
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;&quot;)"" />
    <ns0:TransferResult>
      <RQ1System>
        <xsl:value-of select=""RQ1System/text()"" />
      </RQ1System>
      <XProtID>
        <xsl:value-of select=""XProtID/text()"" />
      </XProtID>
      <InterfaceName>
        <xsl:value-of select=""InterfaceName/text()"" />
      </InterfaceName>
      <TargetProjects>
        <xsl:for-each select=""TargetProjects/TargetProject"">
          <TargetProject>
            <ProjectID>
              <xsl:value-of select=""ProjectID/text()"" />
            </ProjectID>
            <ProjectDomain>
              <xsl:value-of select=""ProjectDomain/text()"" />
            </ProjectDomain>
            <xsl:value-of select=""./text()"" />
          </TargetProject>
        </xsl:for-each>
        <xsl:value-of select=""TargetProjects/text()"" />
      </TargetProjects>
      <xsl:variable name=""var:v1"" select=""userCSharp:Hostname()"" />
      <DownloadTargetHost>
        <xsl:value-of select=""$var:v1"" />
      </DownloadTargetHost>
      <DownloadTargetPath>
        <xsl:text />
      </DownloadTargetPath>
      <xsl:variable name=""var:v2"" select=""userCSharp:strDate()"" />
      <DownloadTime>
        <xsl:value-of select=""$var:v2"" />
      </DownloadTime>
      <LifeToken4XProt>
        <xsl:text />
      </LifeToken4XProt>
      <LifeToken4Files>
        <xsl:text />
      </LifeToken4Files>
      <Mode>
        <xsl:value-of select=""$var:v3"" />
      </Mode>
    </ns0:TransferResult>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

//public string MyConcat(string param1, string param2)
//{
//	return param1+param2;
//}

public string Hostname()
{
      return System.Environment.MachineName;
}


///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

//public string MyConcat(string param1, string param2)
//{
//	return param1+param2;
//}
public string strDate()
{
      return System.String.Format(""{0:dd.MM.yyyy-HH.mm.ss}"", System.DateTime.Now);
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
        
        private const string _strSrcSchemasList0 = @"FTPIssueTransfer.StartImportSchema";
        
        private const global::FTPIssueTransfer.StartImportSchema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"FTPIssueTransfer.TransferResultInformation";
        
        private const global::FTPIssueTransfer.TransferResultInformation _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"FTPIssueTransfer.StartImportSchema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"FTPIssueTransfer.TransferResultInformation";
                return _TrgSchemas;
            }
        }
    }
}
