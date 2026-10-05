namespace RB.ROCustomerInterface {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM", typeof(global::RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.HISMapperOUT", typeof(global::RB.ROCustomerInterface.Schema.HISMapperOUT))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM", typeof(global::RB.ROCustomerInterface.Schema.RB.ASAM.RB_RO_ASAM))]
    public sealed class Transform_IMFOutToIMFOut2 : global::Microsoft.BizTalk.TestTools.Mapper.TestableMapBase {
        
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
 <xsl:for-each select=""//ns1:ASAMISSUE_EXTRACT/RT_RELEASES/RELEASE"">	
    <RELEASE>	
<xsl:variable name=""relid"">
	<xsl:value-of select=""concat('REL_',position())"" />     
	</xsl:variable>	
      <xsl:attribute name=""ID"">
        <xsl:text>REL_</xsl:text>
        <xsl:value-of select=""position()"" />
      </xsl:attribute>
      <DBID><xsl:value-of select=""DBID"" />	</DBID>
            <ID><xsl:value-of select=""ID"" />	</ID>
     <DOMAIN ACTION=""INIT""><xsl:value-of select=""DOMAIN"" /></DOMAIN>
			<TYPE ACTION=""INIT""><xsl:value-of select=""TYPE"" /></TYPE>
			<SCOPE ACTION=""INIT""><xsl:value-of select=""SCOPE"" /></SCOPE>
      <TITLE>        
			<xsl:value-of select=""TITLE"" />
		</TITLE>
		<EXTERNAL_ID><xsl:value-of select=""EXTERNAL_ID"" /></EXTERNAL_ID>
		<PLANNEDDATE><xsl:value-of select=""PLANNEDDATE"" /></PLANNEDDATE>
		<EXTERNALTITLE><xsl:value-of select=""TITLE"" /></EXTERNALTITLE>
		<BELONGSTOPROJECT><xsl:value-of select=""BELONGSTOPROJECT"" /></BELONGSTOPROJECT>		             
		<CATEGORY><xsl:value-of select=""CATEGORY"" /></CATEGORY>
		<OPERATIONMODE><xsl:value-of select=""OPERATIONMODE"" /></OPERATIONMODE>
		<OPERATIONCONTEXT><xsl:value-of select=""OPERATIONCONTEXT"" /></OPERATIONCONTEXT>
	</RELEASE>
  </xsl:for-each>
</RT_RELEASES>
      <RT_IRMAPS xmlns:ns0=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:ns1=""http://RB.ROCustomerInterface.RB"" xmlns:ns2=""http://HISMapperOUT.Schema"">

  <xsl:for-each select=""//ns2:vwId2ttnResponse/VwAsamMappingOutputKtn[not (child::resultStatus ='0')]/mapping"">


    <xsl:variable name=""mp2d"">
      <xsl:value-of select=""parent::node()/KTN"" />
    </xsl:variable>


    <xsl:variable name=""VWparttitle"">
      <xsl:value-of select=""RBSGBZ"" />
    </xsl:variable>
    <xsl:variable name=""VWparttype"">
      <xsl:value-of select=""RBTYPE"" />
    </xsl:variable>

    <xsl:variable name=""sgType"">
      <xsl:if test=""//ns1:ASAMISSUE_EXTRACT/RT_RELEASES/RELEASE[@ID ='REL_1']/EXTERNALTITLE !='' and normalize-space(//ns1:ASAMISSUE_EXTRACT/RT_RELEASES/RELEASE[@ID ='REL_1']/EXTERNALTITLE)!=''"">
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_RELEASES/RELEASE[@ID ='REL_1']/EXTERNALTITLE"" />
      </xsl:if>
    </xsl:variable>

    <xsl:variable name=""reltype"">
      <xsl:if test=""$VWparttype='' or normalize-space($VWparttype)=''"">
        <xsl:choose>
          <xsl:when test=""$sgType!='' and normalize-space($sgType)!=''"">
            <xsl:value-of select=""concat('ECU-Plan Neu ', $sgType)"" />
          </xsl:when>
          <xsl:otherwise>
            <xsl:value-of select=""concat('ECU-Plan Neu ', $mp2d)"" />
          </xsl:otherwise>
        </xsl:choose>
      </xsl:if>
      <xsl:if test=""$VWparttype='MUSTER'"">
        <xsl:value-of select=""'ECU-Plan '"" />
      </xsl:if>
      <xsl:if test=""$VWparttype='SERIE'"">
        <xsl:value-of select=""'ECU-Plan Serie '"" />
      </xsl:if>
    </xsl:variable>
    <xsl:variable name=""t1"">
      <xsl:value-of select=""concat('REL_',position())"" />
    </xsl:variable>
    <xsl:variable name=""reltitle"" select=""concat($reltype, $VWparttitle)"" />
    <IRMAP>
      <DBID>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/DBID"" />
      </DBID>
      <RB_ID>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/RB_ID"" />
      </RB_ID>
      <SCOPE>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/SCOPE"" />
      </SCOPE>
      <HASMAPPEDISSUE ID-REF=""ISS_1""></HASMAPPEDISSUE>
      <HASMAPPEDRELEASE>
        <xsl:attribute name=""ID-REF"">
          <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_RELEASES/RELEASE[TITLE =$reltitle]/@ID"" />
        </xsl:attribute>
      </HASMAPPEDRELEASE>
      <ISPILOT>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/ISPILOT"" />
      </ISPILOT>
      <EXTERNALNEXTSTATE>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/EXTERNALNEXTSTATE"" />
      </EXTERNALNEXTSTATE>
      <EXTERNALTAGS>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/EXTERNALTAGS"" />
      </EXTERNALTAGS>
      <EXTERNALEXCHANGEWORKFLOW>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/EXTERNALEXCHANGEWORKFLOW"" />
      </EXTERNALEXCHANGEWORKFLOW>
      <EXTERNALREVIEW>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/EXTERNALREVIEW"" />
      </EXTERNALREVIEW>
      <EXTERNAL_ID>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/EXTERNAL_ID"" />
      </EXTERNAL_ID>
      <EXTERNALTITLE>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/EXTERNALTITLE"" />
      </EXTERNALTITLE>
      <EXTERNALSTATE_PARALLEL1>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/EXTERNALSTATE_PARALLEL1"" />
      </EXTERNALSTATE_PARALLEL1>
      <EXTERNALCONVERSATION ACTION=""APPEND"">
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/EXTERNALCONVERSATION"" />
      </EXTERNALCONVERSATION>
      <MAPPINGTODERIVATIVES>
        <P>
          <xsl:text>&lt;MAPINT2EXT SI=""</xsl:text>
          <xsl:value-of select=""RBTTN/."" />
          <xsl:text>""&gt;</xsl:text>
          <xsl:value-of select=""$mp2d"" />
          <xsl:text>&lt;/MAPINT2EXT&gt;</xsl:text>
        </P>
      </MAPPINGTODERIVATIVES>
      <LIFECYCLESTATE>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/LIFECYCLESTATE"" />
      </LIFECYCLESTATE>
	  <OPERATIONMODE><xsl:text>ASAM-IMPORT</xsl:text></OPERATIONMODE>
	  <OPERATIONCONTEXT><xsl:text>BizTalk</xsl:text></OPERATIONCONTEXT>
    </IRMAP>
  </xsl:for-each>
  <xsl:for-each select=""//ns2:vwId2ttnResponse/VwAsamMappingOutputKtn[(child::resultStatus ='0')]"">
    <xsl:variable name=""mp2d"">
      <xsl:value-of select=""KTN"" />
    </xsl:variable>

    <xsl:variable name=""mp2d1"">
      <xsl:value-of select=""//ns2:vwId2ttnResponse/VwAsamMappingOutputKtn[(child::resultStatus ='0' and not (preceding::VwAsamMappingOutputKtn/resultStatus ='0'))]/KTN"" />
    </xsl:variable>
    <xsl:variable name=""VWparttitle"">
      <xsl:value-of select=""''"" />
    </xsl:variable>
    <xsl:variable name=""VWparttype"">
      <xsl:value-of select=""''"" />
    </xsl:variable>

	<xsl:variable name=""sgType"">
      <xsl:if test=""//ns1:ASAMISSUE_EXTRACT/RT_RELEASES/RELEASE[@ID ='REL_1']/EXTERNALTITLE !='' and normalize-space(//ns1:ASAMISSUE_EXTRACT/RT_RELEASES/RELEASE[@ID ='REL_1']/EXTERNALTITLE)!=''"">
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_RELEASES/RELEASE[@ID ='REL_1']/EXTERNALTITLE"" />
      </xsl:if>
    </xsl:variable>

    <xsl:variable name=""reltype"">
      <xsl:if test=""$VWparttype='' or normalize-space($VWparttype)=''"">
        <xsl:choose>
          <xsl:when test=""$sgType!='' and normalize-space($sgType)!=''"">
            <xsl:value-of select=""concat('ECU-Plan Neu ', $sgType)"" />
          </xsl:when>
          <xsl:otherwise>
            <xsl:value-of select=""concat('ECU-Plan Neu ', $mp2d1)"" />
          </xsl:otherwise>
        </xsl:choose>
      </xsl:if>
    </xsl:variable>
    <xsl:variable name=""t1"">
      <xsl:value-of select=""concat('REL_',position())"" />
    </xsl:variable>
    <xsl:variable name=""reltitle"" select=""concat($reltype, $VWparttitle)"" />
    <IRMAP>
      <DBID>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/DBID"" />
      </DBID>
      <RB_ID>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/RB_ID"" />
      </RB_ID>
      <SCOPE>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/SCOPE"" />
      </SCOPE>
      <HASMAPPEDISSUE ID-REF=""ISS_1""></HASMAPPEDISSUE>
      <HASMAPPEDRELEASE>
        <xsl:attribute name=""ID-REF"">
          <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_RELEASES/RELEASE[TITLE =$reltitle]/@ID"" />
        </xsl:attribute>
      </HASMAPPEDRELEASE>
      <ISPILOT>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/ISPILOT"" />
      </ISPILOT>
      <EXTERNALNEXTSTATE>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/EXTERNALNEXTSTATE"" />
      </EXTERNALNEXTSTATE>
      <EXTERNALTAGS>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/EXTERNALTAGS"" />
      </EXTERNALTAGS>
      <EXTERNALEXCHANGEWORKFLOW>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/EXTERNALEXCHANGEWORKFLOW"" />
      </EXTERNALEXCHANGEWORKFLOW>
      <EXTERNALREVIEW>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/EXTERNALREVIEW"" />
      </EXTERNALREVIEW>
      <EXTERNAL_ID>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/EXTERNAL_ID"" />
      </EXTERNAL_ID>
      <EXTERNALTITLE>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/EXTERNALTITLE"" />
      </EXTERNALTITLE>
      <EXTERNALSTATE_PARALLEL1>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/EXTERNALSTATE_PARALLEL1"" />
      </EXTERNALSTATE_PARALLEL1>
      <EXTERNALCONVERSATION ACTION=""APPEND"">
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/EXTERNALCONVERSATION"" />
      </EXTERNALCONVERSATION>
      <MAPPINGTODERIVATIVES>
        <P>
          <xsl:text>&lt;MAPINT2EXT SI=""</xsl:text>
          <xsl:text>""&gt;</xsl:text>
          <xsl:value-of select=""$mp2d"" />
          <xsl:text>&lt;/MAPINT2EXT&gt;</xsl:text>
        </P>
      </MAPPINGTODERIVATIVES>
      <LIFECYCLESTATE>
        <xsl:value-of select=""//ns1:ASAMISSUE_EXTRACT/RT_IRMAPS/IRMAP[HASMAPPEDRELEASE/@ID-REF = $t1]/LIFECYCLESTATE"" />
      </LIFECYCLESTATE>
	  <OPERATIONMODE><xsl:text>ASAM-IMPORT</xsl:text></OPERATIONMODE>
	  <OPERATIONCONTEXT><xsl:text>BizTalk</xsl:text></OPERATIONCONTEXT>
    </IRMAP>
  </xsl:for-each>
</RT_IRMAPS>
    </ns0:ASAMISSUE_EXTRACT>
  </xsl:template>
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
