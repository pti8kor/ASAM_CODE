namespace RB.ROCustomerInterface {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM", typeof(global::RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.HISMapperOUT", typeof(global::RB.ROCustomerInterface.Schema.HISMapperOUT))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM", typeof(global::RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM))]
    public sealed class TransformHISOutToIMFOut : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1"" version=""1.0"" xmlns:s1=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:s0=""http://HISMapperOUT.Schema"" xmlns:ns0=""http://RB.ROCustomerInterface.RB"">
  <xsl:output omit-xml-declaration=""yes"" indent=""yes"" version=""1.0"" method=""xml"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:Root"" />
  </xsl:template>
  <xsl:template match=""/s1:Root"">
    <ns0:ASAMISSUE_EXTRACT>
      <RT_VALEX_CONTROLINFO>
        <xsl:copy-of select=""InputMessagePart_0/ns0:ASAMISSUE_EXTRACT/RT_VALEX_CONTROLINFO/@*"" />
        <xsl:copy-of select=""InputMessagePart_0/ns0:ASAMISSUE_EXTRACT/RT_VALEX_CONTROLINFO/*"" />
      </RT_VALEX_CONTROLINFO>
      <RT_CONTACT>
        <xsl:copy-of select=""InputMessagePart_0/ns0:ASAMISSUE_EXTRACT/RT_CONTACT/@*"" />
        <xsl:copy-of select=""InputMessagePart_0/ns0:ASAMISSUE_EXTRACT/RT_CONTACT/*"" />
      </RT_CONTACT>
      <RT_ISSUES>
        <xsl:copy-of select=""InputMessagePart_0/ns0:ASAMISSUE_EXTRACT/RT_ISSUES/@*"" />
        <xsl:copy-of select=""InputMessagePart_0/ns0:ASAMISSUE_EXTRACT/RT_ISSUES/*"" />
      </RT_ISSUES>
      <RT_PROJECTS>
        <xsl:copy-of select=""InputMessagePart_0/ns0:ASAMISSUE_EXTRACT/RT_PROJECTS/@*"" />
        <xsl:copy-of select=""InputMessagePart_0/ns0:ASAMISSUE_EXTRACT/RT_PROJECTS/*"" />
      </RT_PROJECTS>
      <RT_RELEASES xmlns:ns0=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:ns1=""http://RB.ROCustomerInterface.RB"" xmlns:ns2=""http://HISMapperOUT.Schema"">
  <xsl:variable name=""counter"" select=""count(//ns2:vwId2ttnResponse/VwAsamMappingOutputKtn[not (child::resultStatus ='0')]/mapping[count(. | key('REL_group_TitleAndType',concat(RBSGBZ, '|', RBTYPE))[1])=1])"" />

  <xsl:for-each select=""//ns2:vwId2ttnResponse/VwAsamMappingOutputKtn[not (child::resultStatus ='0')]/mapping[count(. | key('REL_group_TitleAndType',concat(RBSGBZ, '|', RBTYPE))[1])=1]"">
    <xsl:variable name=""relid"">
      <xsl:value-of select=""concat('REL_',position())"" />
    </xsl:variable>

    <xsl:variable name=""sgType"">
      <xsl:if test=""//ns1:ASAMISSUE_EXTRACT/RT_RELEASES/RELEASE[@ID ='REL_1']/EXTERNALTITLE !='' and normalize-space(//ns1:ASAMISSUE_EXTRACT/RT_RELEASES/RELEASE[@ID ='REL_1']/EXTERNALTITLE)!=''"">
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_RELEASES/RELEASE[@ID ='REL_1']/EXTERNALTITLE"" />
      </xsl:if>
    </xsl:variable>
    <RELEASE>
      <xsl:attribute name=""ID"">
        <xsl:text>REL_</xsl:text>
        <xsl:value-of select=""position()"" />
      </xsl:attribute>
      <DBID>0</DBID>
      <ID>0</ID>
      <DOMAIN ACTION=""INIT"">
        <xsl:text>Hardware</xsl:text>
      </DOMAIN>
      <TYPE ACTION=""INIT"">
        <xsl:text>HW-ECU</xsl:text>
      </TYPE>
      <SCOPE ACTION=""INIT"">
        <xsl:text>External</xsl:text>
      </SCOPE>
      <TITLE>
        <xsl:choose>
          <xsl:when test=""RBTYPE = 'SERIE'"">
            <xsl:text>ECU-Plan Serie </xsl:text>
            <xsl:value-of select=""RBSGBZ"" />
          </xsl:when>
          <xsl:when test=""RBTYPE = 'MUSTER'"">
            <xsl:text>ECU-Plan </xsl:text>
            <xsl:value-of select=""RBSGBZ"" />
          </xsl:when>
          <xsl:otherwise>
          </xsl:otherwise>
        </xsl:choose>
      </TITLE>
      <EXTERNAL_ID />
      <PLANNEDDATE />
      <EXTERNALTITLE>
        <xsl:value-of select=""$sgType"" />
      </EXTERNALTITLE>
      <BELONGSTOPROJECT>
      </BELONGSTOPROJECT>
      <CATEGORY>
        <xsl:text>Collection</xsl:text>
      </CATEGORY>
	  <OPERATIONMODE><xsl:text>ASAM-IMPORT</xsl:text></OPERATIONMODE>
	  <OPERATIONCONTEXT><xsl:text>BizTalk</xsl:text></OPERATIONCONTEXT>
    </RELEASE>
  </xsl:for-each>

  <xsl:for-each select=""//ns2:vwId2ttnResponse/VwAsamMappingOutputKtn[(child::resultStatus ='0' and not (preceding::VwAsamMappingOutputKtn/resultStatus ='0'))]"">


    <xsl:variable name=""relid"">
      <xsl:value-of select=""concat('REL_',$counter+position())"" />
    </xsl:variable>
    <xsl:variable name=""sgType"">
      <xsl:if test=""//ns1:ASAMISSUE_EXTRACT/RT_RELEASES/RELEASE[@ID ='REL_1']/EXTERNALTITLE !='' and normalize-space(//ns1:ASAMISSUE_EXTRACT/RT_RELEASES/RELEASE[@ID ='REL_1']/EXTERNALTITLE)!=''"">
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_RELEASES/RELEASE[@ID ='REL_1']/EXTERNALTITLE"" />
      </xsl:if>
    </xsl:variable>

    <!--<xsl:variable name=""Test"" select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF =$relid]/MAPPINGTODERIVATIVES/P"" /> -->
    <xsl:variable name=""Test"" select=""KTN"" />
    <RELEASE>
      <xsl:attribute name=""ID"">
        <xsl:text>REL_</xsl:text>
        <xsl:value-of select=""$counter+position()"" />
      </xsl:attribute>
      <DBID>0</DBID>
      <ID>0</ID>
      <DOMAIN ACTION=""INIT"">
        <xsl:text>Hardware</xsl:text>
      </DOMAIN>
      <TYPE ACTION=""INIT"">
        <xsl:text>HW-ECU</xsl:text>
      </TYPE>
      <SCOPE ACTION=""INIT"">
        <xsl:text>External</xsl:text>
      </SCOPE>
      <TITLE>
        <xsl:choose>
          <xsl:when test=""$sgType!='' and normalize-space($sgType)!=''"">
            <xsl:text>ECU-Plan Neu </xsl:text>
            <xsl:value-of select=""$sgType"" />
          </xsl:when>
          <xsl:otherwise>
            <xsl:text>ECU-Plan Neu </xsl:text>
            <xsl:value-of select=""$Test"" />
          </xsl:otherwise>
        </xsl:choose>
      </TITLE>
      <EXTERNAL_ID />
      <PLANNEDDATE />
      <EXTERNALTITLE>
        <xsl:value-of select=""$sgType"" />
      </EXTERNALTITLE>
      <BELONGSTOPROJECT>
      </BELONGSTOPROJECT>
      <CATEGORY>
        <xsl:text>Collection</xsl:text>
      </CATEGORY>
	  <OPERATIONMODE><xsl:text>ASAM-IMPORT</xsl:text></OPERATIONMODE>
	  <OPERATIONCONTEXT><xsl:text>BizTalk</xsl:text></OPERATIONCONTEXT>
    </RELEASE>
  </xsl:for-each>
</RT_RELEASES>
      <RT_IRMAPS xmlns:ns0=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:ns1=""http://RB.ROCustomerInterface.RB"" xmlns:ns2=""http://HISMapperOUT.Schema"">
  <xsl:for-each select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP"">
    <IRMAP>
      <DBID>
        <xsl:value-of select=""DBID"" />
      </DBID>
      <SCOPE ACTION=""INIT"">
        <xsl:value-of select=""SCOPE"" />
      </SCOPE>
      <HASMAPPEDISSUE ID-REF=""ISS_1""></HASMAPPEDISSUE>
      <HASMAPPEDRELEASE>
        <xsl:attribute name=""ID-REF"">
          <xsl:text>REL_</xsl:text>
          <xsl:value-of select=""position()"" />
        </xsl:attribute>

      </HASMAPPEDRELEASE>
      <ISPILOT>
        <xsl:value-of select=""ISPILOT"" />
      </ISPILOT>
      <EXTERNALNEXTSTATE>
        <xsl:value-of select=""EXTERNALNEXTSTATE"" />
      </EXTERNALNEXTSTATE>
      <EXTERNALTAGS>
        <xsl:value-of select=""EXTERNALTAGS"" />
      </EXTERNALTAGS>
      <EXTERNALEXCHANGEWORKFLOW>
        <xsl:value-of select=""EXTERNALEXCHANGEWORKFLOW"" />
      </EXTERNALEXCHANGEWORKFLOW>
      <EXTERNALREVIEW>
        <xsl:value-of select=""EXTERNALREVIEW"" />
      </EXTERNALREVIEW>
      <EXTERNAL_ID>
        <xsl:value-of select=""EXTERNAL_ID"" />
      </EXTERNAL_ID>
      <EXTERNALTITLE>
        <xsl:value-of select=""EXTERNALTITLE"" />
      </EXTERNALTITLE>
      <EXTERNALSTATE_PARALLEL1>
        <xsl:value-of select=""EXTERNALSTATE_PARALLEL1"" />
      </EXTERNALSTATE_PARALLEL1>
      <EXTERNALCONVERSATION ACTION=""APPEND"">
        <xsl:value-of select=""EXTERNALCONVERSATION"" />
      </EXTERNALCONVERSATION>
      <MAPPINGTODERIVATIVES>
        <P>
          <xsl:value-of select=""MAPPINGTODERIVATIVES/P"" />
        </P>
      </MAPPINGTODERIVATIVES>
      <LIFECYCLESTATE>
        <xsl:value-of select=""LIFECYCLESTATE"" />
      </LIFECYCLESTATE>
	  <OPERATIONMODE>
		<xsl:value-of select=""OPERATIONMODE"" />
	  </OPERATIONMODE>
	  <OPERATIONCONTEXT>
		<xsl:value-of select=""OPERATIONCONTEXT"" />
	  </OPERATIONCONTEXT>
    </IRMAP>
  </xsl:for-each>
</RT_IRMAPS>
    </ns0:ASAMISSUE_EXTRACT>
  </xsl:template>
  <xsl:key name=""REL_group_TitleAndType"" match=""mapping"" use=""concat(RBSGBZ, '|', RBTYPE)"" />
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM";
        
        private const global::RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"RB.ROCustomerInterface.Schema.HISMapperOUT";
        
        private const global::RB.ROCustomerInterface.Schema.HISMapperOUT _srcSchemaTypeReference1 = null;
        
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
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM";
                _SrcSchemas[1] = @"RB.ROCustomerInterface.Schema.HISMapperOUT";
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
