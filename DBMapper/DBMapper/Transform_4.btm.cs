namespace DBMapper {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DBMapper.DBMapperType", typeof(global::DBMapper.DBMapperType))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DBMapper.TableOperation_dbo_VW2RBMapping+SelectResponse", typeof(global::DBMapper.TableOperation_dbo_VW2RBMapping.SelectResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DBMapper.DBMapperType", typeof(global::DBMapper.DBMapperType))]
    public sealed class Transform_4 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1 s2"" version=""1.0"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/TableOp/dbo/VW2RBMapping"" xmlns:s1=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:ns0=""http://DBMapper.Schema"" xmlns:s2=""http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:Root"" />
  </xsl:template>
  <xsl:template match=""/s1:Root"">
    <ns0:VWPartnumberMappings xmlns:ns0=""http://DBMapper.Schema"" xmlns:ns1=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:ns2=""http://schemas.microsoft.com/Sql/2008/05/TableOp/dbo/VW2RBMapping"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/Types/Tables/dbo"">

<xsl:for-each select=""//ns0:VWPartnumberMappings/Mapping"">
	<xsl:variable name=""custNumber"">
		<xsl:value-of select=""CUSTTN"" />     
	</xsl:variable>	
	<!-- Fallunterscheidung nach Anzahl der Response-Records pro Mapping-Eintrag -->
	<xsl:variable name=""numOfCUSTTNMatches"">
		<xsl:value-of select=""count(/*/InputMessagePart_1/ns2:SelectResponse/ns2:SelectResult/ns3:VW2RBMapping[ns3:CUST_TN = $custNumber])"" />     
	</xsl:variable>
	<!-- nur den Fall numOfCUSTTNMatches==0 -->
	<xsl:choose>
		<xsl:when test=""$numOfCUSTTNMatches=0"">
			<Mapping>	
				<xsl:element name=""CUSTTN"">
					<xsl:value-of select=""$custNumber"" />
				</xsl:element>
				<RBTTN />
				<RBRELTYPE />
				<RBSGBEZ />
				<Resultstatus>0</Resultstatus>
				<Resultmessage>FAILURE: No mapping found.</Resultmessage>
			</Mapping>
		</xsl:when>
		<xsl:otherwise>
			<xsl:for-each select=""/*/InputMessagePart_1/ns2:SelectResponse/ns2:SelectResult/ns3:VW2RBMapping[ns3:CUST_TN = $custNumber]"">
				<Mapping>	
					<CUSTTN>
						<xsl:value-of select=""$custNumber"" />
					</CUSTTN>
					<xsl:variable name=""DBcustNumber"">
						<xsl:value-of select=""ns3:CUST_TN"" />     
					</xsl:variable>	
					<xsl:variable name=""DBrbttnNumber"">
						<xsl:value-of select=""ns3:RB_TTN"" />     
					</xsl:variable>	
					<RBTTN>
						<xsl:value-of select=""$DBrbttnNumber"" />
					</RBTTN>
					<RBRELTYPE>
						<xsl:value-of select=""ns3:RB_RELTYPE"" />
					</RBRELTYPE>
					<RBSGBEZ>
						<xsl:value-of select=""ns3:RB_SGBEZ"" />
					</RBSGBEZ>
					<Resultstatus>
						<xsl:choose>
							<xsl:when test=""$DBrbttnNumber != ''"">1</xsl:when>
							<xsl:when test=""$DBrbttnNumber = ''"">0</xsl:when>
						</xsl:choose>			
					</Resultstatus>
					<Resultmessage>
						<xsl:choose>
							<xsl:when test=""$DBrbttnNumber != ''"">OK: Mapping found.</xsl:when>
							<xsl:when test=""$DBrbttnNumber = ''"">FAILURE: Empty RBTTN.</xsl:when>
						</xsl:choose>			
					</Resultmessage>
				</Mapping>
			</xsl:for-each>
		</xsl:otherwise>
	</xsl:choose>	
</xsl:for-each>
</ns0:VWPartnumberMappings>
  </xsl:template>
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
