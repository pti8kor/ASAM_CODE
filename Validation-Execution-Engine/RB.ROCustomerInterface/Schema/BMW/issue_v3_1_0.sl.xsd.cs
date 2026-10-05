namespace RB.ROCustomerInterface.Schema.BMW {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.asam.net/schemas/issue/issue310",@"MSR-ISSUE")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"MSR-ISSUE"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"RB.ROCustomerInterface.Schema.BMW.xml", typeof(global::RB.ROCustomerInterface.Schema.BMW.xml))]
    public sealed class issue_v3_1_0_sl : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://www.asam.net/schemas/issue/issue310"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://www.asam.net/schemas/issue/issue310"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""RB.ROCustomerInterface.Schema.BMW.xml"" namespace=""http://www.w3.org/XML/1998/namespace"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""http://www.w3.org/XML/1998/namespace"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:attributeGroup name=""DefaultAttributes"">
    <xs:attribute name=""C"" type=""xs:string"" />
    <xs:attribute name=""SI"" type=""xs:string"" />
    <xs:attribute name=""VIEW"" type=""xs:string"" />
  </xs:attributeGroup>
  <xs:complexType name=""ABSType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""ACCOUNT-IDType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""ADDRESSType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""ADMIN-DATAType"">
    <xs:sequence>
      <xs:element name=""DOC-REVISIONS"" type=""DOC-REVISIONSType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""ANNOTATIONType"">
    <xs:sequence>
      <xs:element name=""TEAM-MEMBER-REF"" type=""TEAM-MEMBER-REFType"" />
      <xs:element minOccurs=""0"" name=""DATE"" type=""DATEType"" />
      <xs:element name=""ANNOTATION-TEXT"" type=""ANNOTATION-TEXTType"" />
      <xs:element minOccurs=""0"" name=""ANNOTATION-RELATED-DOCUMENTS"">
        <xs:complexType>
          <xs:sequence>
            <xs:element maxOccurs=""unbounded"" name=""ANNOTATION-RELATED-DOCUMENT"" type=""DOCUMENTType"" />
          </xs:sequence>
          <xs:attributeGroup ref=""DefaultAttributes"" />
        </xs:complexType>
      </xs:element>
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""ANNOTATION-ORIGINType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""ANNOTATION-TEXTType"">
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:element name=""P"" type=""PType"" />
    </xs:choice>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""ANNOTATIONSType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ISSUE-ANNOTATION"" type=""ANNOTATIONType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""CATEGORYType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:simpleType name=""ISSUE-CATEGORY-ENUMType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CHANGE-REQUEST"" />
      <xs:enumeration value=""CLARIFICATION-REQUEST"" />
      <xs:enumeration value=""PROBLEM-REPORT"" />
      <xs:enumeration value=""EFFORT-ESTIMATION"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""ISSUE-CATEGORYType"">
    <xs:simpleContent>
      <xs:extension base=""ISSUE-CATEGORY-ENUMType"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""CITYType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""COMPANY-DATAType"">
    <xs:sequence>
      <xs:element name=""SHORT-NAME"" type=""SHORT-NAMEType"" />
      <xs:element minOccurs=""0"" name=""LONG-NAME"" type=""LONG-NAMEType"" />
      <xs:element minOccurs=""0"" name=""TEAM-MEMBERS"" type=""TEAM-MEMBERSType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
    <xs:attribute fixed=""COMPANY-DATA"" name=""F-ID-CLASS"" type=""xs:NMTOKEN"" />
    <xs:attribute fixed=""TEAM-MEMBER"" name=""F-NAMESPACE"" type=""xs:NMTOKENS"" />
    <xs:attribute name=""ID"" type=""xs:ID"" />
  </xs:complexType>
  <xs:complexType name=""COMPANY-DATA-REFType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
        <xs:attribute fixed=""COMPANY-DATA"" name=""F-ID-CLASS"" type=""xs:NMTOKEN"" />
        <xs:attribute fixed=""LINKEND ID-REF"" name=""HYNAMES"" type=""xs:NMTOKENS"" />
        <xs:attribute fixed=""CLINK"" name=""HYTIME"" type=""xs:NMTOKEN"" />
        <xs:attribute name=""ID-REF"" type=""xs:IDREF"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""COMPANY-DATASType"">
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" name=""COMPANY-DATA"" type=""COMPANY-DATAType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""COMPANY-DOC-INFOType"">
    <xs:sequence>
      <xs:element name=""COMPANY-DATA-REF"" type=""COMPANY-DATA-REFType"" />
      <xs:element minOccurs=""0"" name=""DOC-LABEL"" type=""DOC-LABELType"" />
      <xs:element minOccurs=""0"" name=""TEAM-MEMBER-REF"" type=""TEAM-MEMBER-REFType"" />
      <xs:element minOccurs=""0"" name=""SDGS"" type=""SDGSType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""COMPANY-DOC-INFOSType"">
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" name=""COMPANY-DOC-INFO"" type=""COMPANY-DOC-INFOType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""COMPANY-ISSUE-INFOType"">
    <xs:sequence>
      <xs:element name=""COMPANY-DATA-REF"" type=""COMPANY-DATA-REFType"" />
      <xs:element name=""ISSUE-ID"" type=""ISSUE-IDType"" />
      <xs:element name=""PROJECT-ID"" type=""PROJECT-IDType"" />
      <xs:element name=""TEAM-MEMBER-REF"" type=""TEAM-MEMBER-REFType"">
        <xs:annotation>
          <xs:documentation>Contact partner for the ISSUE</xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""TRANSACTION-ID"" type=""TRANSACTION-IDType"">
        <xs:annotation>
          <xs:documentation>Transaction ID within a issue tracking system of a company. For enabling the acknowledgement exchange</xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""COMPANY-ISSUE-INFOSType"">
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" name=""COMPANY-ISSUE-INFO"" type=""COMPANY-ISSUE-INFOType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""CONDType"">
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" name=""P"" type=""PType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""CONTENTType"">
    <xs:simpleContent>
      <xs:extension base=""xs:base64Binary"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""COST-DETAILType"">
    <xs:sequence>
      <xs:element name=""PHASE"" type=""PHASEType"" />
      <xs:element name=""AMOUNT"" type=""AMOUNTType"" />
      <xs:element name=""UNIT"" type=""COST-UNITType"" />
      <xs:element minOccurs=""0"" name=""COST-SHARES"" type=""COST-SHARESType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""COST-DETAILSType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""COST-DETAIL"" type=""COST-DETAILType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""COST-SHAREType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""COMPANY-DATA-REF"" type=""COMPANY-DATA-REFType"" />
      <xs:element minOccurs=""0"" name=""PERCENTAGE"" type=""PERCENTAGEType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""COST-SHARESType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""COST-SHARE"" type=""COST-SHAREType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""AMOUNTType"">
    <xs:simpleContent>
      <xs:extension base=""xs:decimal"" />
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""COST-CURRENCYType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""PERCENTAGEType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""EFFORT-SHAREType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""COMPANY-DATA-REF"" type=""COMPANY-DATA-REFType"" />
      <xs:element minOccurs=""0"" name=""PERCENTAGE"" type=""PERCENTAGEType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""EFFORT-SHARESType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""EFFORT-SHARE"" type=""EFFORT-SHAREType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""DATEType"">
    <xs:simpleContent>
      <xs:extension base=""xs:dateTime"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""DELIVERY-MILESTONEType"">
    <xs:sequence>
      <xs:element name=""SHORT-LABEL"" type=""SHORT-LABELType"" />
      <xs:element minOccurs=""0"" name=""CATEGORY"" type=""CATEGORYType"">
        <xs:annotation>
          <xs:documentation>Release Plan State (e.g. Requested, Estimated, Delivered)</xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name=""COMPANY-DATA-REF"" type=""COMPANY-DATA-REFType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""DELIVERY-MILESTONESType"">
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" name=""DELIVERY-MILESTONE"" type=""DELIVERY-MILESTONEType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""DEPARTMENTType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""DESCType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""DOC-LABELType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""DOC-REVISIONType"">
    <xs:sequence>
      <xs:element name=""TEAM-MEMBER-REF"" type=""TEAM-MEMBER-REFType"" />
      <xs:element name=""DATE"" type=""DATEType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""DOC-REVISIONSType"">
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" name=""DOC-REVISION"" type=""DOC-REVISIONType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""DOMAINType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""EFFORT-DETAILType"">
    <xs:sequence>
      <xs:element name=""PHASE"" type=""PHASEType"" />
      <xs:element name=""AMOUNT"" type=""AMOUNTType"" />
      <xs:element name=""UNIT"" type=""UNITType"" />
      <xs:element minOccurs=""0"" name=""EFFORT-SHARES"" type=""EFFORT-SHARESType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""EFFORT-DETAILSType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""EFFORT-DETAIL"" type=""EFFORT-DETAILType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""EFFORT-AMOUNTType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"" />
    </xs:simpleContent>
  </xs:complexType>
  <xs:simpleType name=""COST-UNIT-ENUMType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""€"" />
      <xs:enumeration value=""$"" />
      <xs:enumeration value=""£"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""EFFORT-UNIT-ENUMType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""h"" />
      <xs:enumeration value=""d"" />
      <xs:enumeration value=""w"" />
      <xs:enumeration value=""m"" />
      <xs:enumeration value=""y"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""COST-UNITType"">
    <xs:simpleContent>
      <xs:extension base=""COST-UNIT-ENUMType"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""UNITType"">
    <xs:simpleContent>
      <xs:extension base=""EFFORT-UNIT-ENUMType"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""EMAILType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""ENGINEERING-OBJECTType"">
    <xs:sequence>
      <xs:element name=""SHORT-LABEL"" type=""SHORT-LABELType"" />
      <xs:element name=""CATEGORY"" type=""CATEGORYType"" />
      <xs:element name=""REVISION-LABELS"" type=""REVISION-LABELSType"" />
      <xs:element minOccurs=""0"" name=""DOMAIN"" type=""DOMAINType"" />
      <xs:element minOccurs=""0"" name=""SDGS"" type=""SDGSType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""ENGINEERING-OBJECTSType"">
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" name=""ENGINEERING-OBJECT"" type=""ENGINEERING-OBJECTType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""FAXType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""HOMEPAGEType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""ISSUEType"">
    <xs:sequence>
      <xs:element name=""SHORT-NAME"" type=""SHORT-NAMEType"">
        <xs:annotation>
          <xs:documentation>Best practise: Company short name + ISSUE ID</xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name=""LONG-NAME"" type=""LONG-NAMEType"">
        <xs:annotation>
          <xs:documentation>Used for title</xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name=""CATEGORY"" type=""ISSUE-CATEGORYType"" />
      <xs:element name=""ISSUE-DESC"" type=""ISSUE-DESCType"" />
      <xs:element name=""COMPANY-ISSUE-INFOS"" type=""COMPANY-ISSUE-INFOSType"" />
      <xs:element name=""ISSUE-PROPERTIES"" type=""ISSUE-PROPERTIESType"" />
      <xs:element minOccurs=""0"" name=""ISSUE-RELATED-DOCUMENTS"" type=""ISSUE-RELATED-DOCUMENTSType"" />
      <xs:element minOccurs=""0"" name=""ISSUE-ENVIRONMENT"" type=""ISSUE-ENVIRONMENTType"" />
      <xs:element minOccurs=""0"" name=""RELATED-ISSUES"" type=""RELATED-ISSUESType"" />
      <xs:element minOccurs=""0"" name=""ISSUE-SOLUTIONS"" type=""ISSUE-SOLUTIONSType"" />
      <xs:element minOccurs=""0"" name=""ISSUE-HISTORY-STATES"" type=""ISSUE-HISTORY-STATESType"" />
      <xs:element minOccurs=""0"" name=""ISSUE-ANNOTATIONS"" type=""ANNOTATIONSType"" />
      <xs:element minOccurs=""0"" name=""SDGS"" type=""SDGSType"" />
    </xs:sequence>
    <xs:attribute fixed=""ISSUE"" name=""F-ID-CLASS"" type=""xs:NMTOKEN"" />
    <xs:attribute name=""ID"" type=""xs:ID"" />
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""ISSUE-COSTSType"">
    <xs:sequence />
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""ISSUE-COSTType"">
    <xs:sequence>
      <xs:element name=""AMOUNT"" type=""AMOUNTType"" />
      <xs:element name=""UNIT"" type=""COST-UNITType"" />
      <xs:element minOccurs=""0"" name=""COST-SHARES"" type=""COST-SHARESType"" />
      <xs:element minOccurs=""0"" name=""COST-DETAILS"" type=""COST-DETAILSType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""ISSUE-CURRENT-STATEType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DATE"" type=""DATEType"">
        <xs:annotation>
          <xs:documentation>Date of setting the current issue state</xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name=""TEAM-MEMBER-REF"" type=""TEAM-MEMBER-REFType"">
        <xs:annotation>
          <xs:documentation>Responsible for setting state</xs:documentation>
        </xs:annotation>
      </xs:element>
      <xs:element name=""ISSUE-STATE"" type=""ISSUE-STATEType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""ISSUE-DESCType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""P"" type=""PType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""ISSUE-EFFORTType"">
    <xs:sequence>
      <xs:element name=""AMOUNT"" type=""AMOUNTType"" />
      <xs:element name=""UNIT"" type=""UNITType"" />
      <xs:element minOccurs=""0"" name=""EFFORT-SHARES"" type=""EFFORT-SHARESType"" />
      <xs:element minOccurs=""0"" name=""EFFORT-DETAILS"" type=""EFFORT-DETAILSType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""ISSUE-ENVIRONMENTType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ENGINEERING-OBJECTS"" type=""ENGINEERING-OBJECTSType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""ISSUE-HISTORY-STATESType"">
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" name=""ISSUE-HISTORY-STATE"" type=""ISSUE-CURRENT-STATEType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""ISSUE-IDType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""ISSUE-PRIORITYType"">
    <xs:simpleContent>
      <xs:extension base=""ISSUE-PRIOITY-ENUMType"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:simpleType name=""ISSUE-PRIOITY-ENUMType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""TOP"" />
      <xs:enumeration value=""HIGH"" />
      <xs:enumeration value=""MEDIUM"" />
      <xs:enumeration value=""LOW"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""ISSUE-PROPERTIESType"">
    <xs:sequence>
      <xs:element name=""ISSUE-CURRENT-STATE"" type=""ISSUE-CURRENT-STATEType"" />
      <xs:element name=""ISSUE-PRIORITY"" type=""ISSUE-PRIORITYType"" />
      <xs:element minOccurs=""0"" name=""ISSUE-SEVERITY"" type=""ISSUE-SEVERITYType"" />
      <xs:element minOccurs=""0"" name=""REPRODUCIBILITY"" type=""REPRODUCIBILITYType"" />
      <xs:element minOccurs=""0"" name=""DELIVERY-MILESTONES"" type=""DELIVERY-MILESTONESType"" />
      <xs:element minOccurs=""0"" name=""PRMS"" type=""PRMSType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""ISSUE-REASONType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""P"" type=""PType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""ISSUE-REFType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attribute fixed=""ISSUE"" name=""F-ID-CLASS"" type=""xs:NMTOKEN"" />
        <xs:attribute fixed=""LINKEND ID-REF"" name=""HYNAMES"" type=""xs:NMTOKENS"" />
        <xs:attribute fixed=""CLINK"" name=""HYTIME"" type=""xs:NMTOKEN"" />
        <xs:attribute name=""ID-REF"" type=""xs:IDREF"" />
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""ISSUE-RELATED-DOCUMENTSType"">
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" name=""ISSUE-RELATED-DOCUMENT"" type=""DOCUMENTType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:simpleType name=""ISSUE-RELATION-ENUMType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""PARENT"" />
      <xs:enumeration value=""CHILD"" />
      <xs:enumeration value=""SIBLING"" />
      <xs:enumeration value=""PREDECESSOR"" />
      <xs:enumeration value=""SUCCESSOR"" />
      <xs:enumeration value=""SIMILAR"" />
      <xs:enumeration value=""DEPENDENT ON"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""ISSUE-RELATIONType"">
    <xs:simpleContent>
      <xs:extension base=""ISSUE-RELATION-ENUMType"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:simpleType name=""ISSUE-SEVERITY-ENUMType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""TOP"" />
      <xs:enumeration value=""HIGH"" />
      <xs:enumeration value=""MEDIUM"" />
      <xs:enumeration value=""LOW"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""ISSUE-SEVERITYType"">
    <xs:simpleContent>
      <xs:extension base=""ISSUE-SEVERITY-ENUMType"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""ISSUE-SOLUTIONType"">
    <xs:sequence>
      <xs:element name=""CATEGORY"" type=""CATEGORYType"" />
      <xs:element minOccurs=""0"" name=""ISSUE-SOLUTION-DESC"" type=""ISSUE-SOLUTION-DESCType"" />
      <xs:element minOccurs=""0"" name=""ISSUE-RELATED-DOCUMENTS"" type=""ISSUE-RELATED-DOCUMENTSType"" />
      <xs:element minOccurs=""0"" name=""ENGINEERING-OBJECTS"" type=""ENGINEERING-OBJECTSType"" />
      <xs:element minOccurs=""0"" name=""ISSUE-EFFORT"" type=""ISSUE-EFFORTType"" />
      <xs:element minOccurs=""0"" name=""ISSUE-COST"" type=""ISSUE-COSTType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""ISSUE-SOLUTION-DESCType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""P"" type=""PType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""ISSUE-SOLUTIONSType"">
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" name=""ISSUE-SOLUTION"" type=""ISSUE-SOLUTIONType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:simpleType name=""ISSUE-STATE-ENUMType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""REQUESTED"" />
      <xs:enumeration value=""RECEIVED"" />
      <xs:enumeration value=""ESTIMATED"" />
      <xs:enumeration value=""ACCEPTED"" />
      <xs:enumeration value=""SPECIFIED"" />
      <xs:enumeration value=""APPROVED"" />
      <xs:enumeration value=""DELIVERED"" />
      <xs:enumeration value=""CLOSED-OK"" />
      <xs:enumeration value=""CLOSED-NOT-OK"" />
      <xs:enumeration value=""REJECTED"" />
      <xs:enumeration value=""CANCELED"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""ISSUE-STATEType"">
    <xs:simpleContent>
      <xs:extension base=""ISSUE-STATE-ENUMType"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""ISSUED-BYType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""ISSUESType"">
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" name=""ISSUE"" type=""ISSUEType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""LABELType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""LONG-NAMEType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""LONG-NAME-1Type"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""MATCHING-DCIType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""LABEL"" type=""LABELType"" />
      <xs:element minOccurs=""0"" name=""SHORT-LABEL"" type=""SHORT-LABELType"" />
      <xs:element minOccurs=""0"" name=""URL"" type=""URLType"" />
      <xs:element minOccurs=""0"" name=""REMARK"" type=""REMARKType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""MATCHING-DCISType"">
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" name=""MATCHING-DCI"" type=""MATCHING-DCIType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""MAXType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""MINType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:element name=""MSR-ISSUE"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""SHORT-NAME"" type=""SHORT-NAMEType"" />
        <xs:element minOccurs=""0"" name=""CATEGORY"" type=""CATEGORYType"" />
        <xs:element name=""COMPANY-DATAS"" type=""COMPANY-DATASType"" />
        <xs:element name=""ADMIN-DATA"" type=""ADMIN-DATAType"" />
        <xs:element name=""ISSUES"" type=""ISSUESType"" />
        <xs:element minOccurs=""0"" name=""MSR-PROCESSING-LOG"" type=""MSR-PROCESSING-LOGType"" />
        <xs:element minOccurs=""0"" name=""MATCHING-DCIS"" type=""MATCHING-DCISType"" />
        <xs:element minOccurs=""0"" name=""SDGS"" type=""SDGSType"" />
      </xs:sequence>
      <xs:attributeGroup ref=""DefaultAttributes"" />
      <xs:attribute name=""CREATOR"" type=""xs:string"" />
      <xs:attribute name=""CREATOR-VERSION"" type=""xs:string"" />
      <xs:attribute fixed=""$Id:$"" name=""F-CM-TOOL-ID"" type=""xs:string"" />
      <xs:attribute fixed=""1"" name=""F-DTD-BUILD"" type=""xs:string"" />
      <xs:attribute fixed=""3.1.0"" name=""F-DTD-VERSION"" type=""xs:string"" />
      <xs:attribute fixed=""-//ASAM//DTD MSR ISSUE DTD:V3.1.0:LAI:IAI:XML:MSRISSUE.DTD//EN"" name=""F-PUBID"" type=""xs:string"" />
      <xs:attribute default=""-//ASAM//DTD MSR ISSUE DTD:V3.1.0:LAI:IAI:XML:MSRISSUE.DTD//EN"" name=""PUBID"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""MSR-PROCESSING-LOGType"">
    <xs:sequence>
      <xs:element name=""VERBATIM"" type=""VERBATIMType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""NUMBERType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""PType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
        <xs:attribute name=""HELP-ENTRY"" type=""xs:string"" />
        <xs:attribute name=""KEEP-WITH-PREVIOUS"">
          <xs:simpleType>
            <xs:restriction base=""xs:NMTOKEN"">
              <xs:enumeration value=""KEEP"" />
              <xs:enumeration value=""NO-KEEP"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:attribute>
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""PAYMENT-RESPONSIBILITYType"">
    <xs:sequence>
      <xs:element name=""COMPANY-DATA-REF"" type=""COMPANY-DATA-REFType"" />
      <xs:element name=""RATIO"" type=""RATIOType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PHASEType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""PHONEType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""POSITIONType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""PRMType"">
    <xs:sequence>
      <xs:element name=""SHORT-NAME"" type=""SHORT-NAMEType"" />
      <xs:element minOccurs=""0"" name=""LONG-NAME"" type=""LONG-NAMEType"" />
      <xs:element minOccurs=""0"" name=""DESC"" type=""DESCType"" />
      <xs:element maxOccurs=""unbounded"" name=""PRM-CHAR"" type=""PRM-CHARType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
    <xs:attribute fixed=""PRM"" name=""F-ID-CLASS"" type=""xs:NMTOKEN"" />
    <xs:attribute name=""ID"" type=""xs:ID"" />
  </xs:complexType>
  <xs:complexType name=""PRM-CHARType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""COND"" type=""CONDType"" />
      <xs:choice>
        <xs:sequence>
          <xs:choice>
            <xs:sequence>
              <xs:element name=""ABS"" type=""ABSType"" />
              <xs:element name=""TOL"" type=""TOLType"" />
            </xs:sequence>
            <xs:sequence>
              <xs:element name=""MIN"" type=""MINType"" />
              <xs:element name=""TYP"" type=""TYPType"" />
              <xs:element name=""MAX"" type=""MAXType"" />
            </xs:sequence>
          </xs:choice>
          <xs:element name=""PRM-UNIT"" type=""PRM-UNITType"" />
        </xs:sequence>
        <xs:element name=""TEXT"" type=""TEXTType"" />
      </xs:choice>
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""PRM-UNITType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""PRMSType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""LABEL"" type=""LABELType"" />
      <xs:element maxOccurs=""unbounded"" name=""PRM"" type=""PRMType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
    <xs:attribute name=""KEEP-WITH-PREVIOUS"">
      <xs:simpleType>
        <xs:restriction base=""xs:NMTOKEN"">
          <xs:enumeration value=""KEEP"" />
          <xs:enumeration value=""NO-KEEP"" />
        </xs:restriction>
      </xs:simpleType>
    </xs:attribute>
  </xs:complexType>
  <xs:complexType name=""PROJECT-IDType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""PROJECT-IDSType"">
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" name=""PROJECT-ID"" type=""PROJECT-IDType"">
        <xs:annotation>
          <xs:documentation>Remove..</xs:documentation>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""PUBLISHERType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""RATIOType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""RELATED-ISSUEType"">
    <xs:sequence>
      <xs:element name=""ISSUE-RELATION"" type=""ISSUE-RELATIONType"" />
      <xs:element name=""ISSUE-REF"" type=""ISSUE-REFType"" />
      <xs:element name=""COMPANY-DATA-REF"" type=""COMPANY-DATA-REFType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""RELATED-ISSUESType"">
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" name=""RELATED-ISSUE"" type=""RELATED-ISSUEType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""REMARKType"">
    <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
      <xs:element name=""P"" type=""PType"" />
      <xs:element name=""VERBATIM"" type=""VERBATIMType"" />
    </xs:choice>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:simpleType name=""REPRODUCIBILITY-ENUMType"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""REPEATABLE"" />
      <xs:enumeration value=""SPORADIC"" />
      <xs:enumeration value=""SELDOM"" />
      <xs:enumeration value=""SINGLE"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:complexType name=""REPRODUCIBILITYType"">
    <xs:simpleContent>
      <xs:extension base=""REPRODUCIBILITY-ENUMType"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""REVISION-LABELType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""REVISION-LABELSType"">
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" name=""REVISION-LABEL"" type=""REVISION-LABELType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""ROLEType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""ROLESType"">
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" name=""ROLE"" type=""ROLEType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""SDType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
        <xs:attribute name=""GID"" type=""xs:string"" use=""required"" />
        <xs:attribute name=""ID-CLASS"" type=""xs:NMTOKEN"" />
        <xs:attribute name=""ID-REF"" type=""xs:IDREF"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""SDGType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""SDG-CAPTION"" type=""SDG-CAPTIONType"" />
      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
        <xs:element minOccurs=""0"" name=""SD"" type=""SDType"" />
        <xs:element minOccurs=""0"" name=""SDG"" type=""SDGType"" />
      </xs:choice>
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
    <xs:attribute name=""GID"" type=""xs:string"" use=""required"" />
  </xs:complexType>
  <xs:complexType name=""SDG-CAPTIONType"">
    <xs:sequence>
      <xs:element name=""SHORT-NAME"" type=""SHORT-NAMEType"" />
      <xs:element minOccurs=""0"" name=""LONG-NAME"" type=""LONG-NAMEType"" />
      <xs:element minOccurs=""0"" name=""DESC"" type=""DESCType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
    <xs:attribute fixed=""SDG"" name=""F-ID-CLASS"" type=""xs:NMTOKEN"" />
    <xs:attribute name=""ID"" type=""xs:ID"" />
  </xs:complexType>
  <xs:complexType name=""SDGSType"">
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" name=""SDG"" type=""SDGType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""SHORT-LABELType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""SHORT-NAMEType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""STATEType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""STATE-1Type"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""TEAM-MEMBERType"">
    <xs:sequence>
      <xs:element name=""SHORT-NAME"" type=""SHORT-NAMEType"" />
      <xs:element minOccurs=""0"" name=""LONG-NAME"" type=""LONG-NAMEType"" />
      <xs:element minOccurs=""0"" name=""ROLES"" type=""ROLESType"" />
      <xs:element minOccurs=""0"" name=""DEPARTMENT"" type=""DEPARTMENTType"" />
      <xs:element minOccurs=""0"" name=""ADDRESS"" type=""ADDRESSType"" />
      <xs:element minOccurs=""0"" name=""ZIP"" type=""ZIPType"" />
      <xs:element minOccurs=""0"" name=""CITY"" type=""CITYType"" />
      <xs:element minOccurs=""0"" name=""PHONE"" type=""PHONEType"" />
      <xs:element minOccurs=""0"" name=""FAX"" type=""FAXType"" />
      <xs:element minOccurs=""0"" name=""EMAIL"" type=""EMAILType"" />
      <xs:element minOccurs=""0"" name=""HOMEPAGE"" type=""HOMEPAGEType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
    <xs:attribute fixed=""TEAM-MEMBER"" name=""F-ID-CLASS"" type=""xs:NMTOKEN"" />
    <xs:attribute name=""ID"" type=""xs:ID"" />
  </xs:complexType>
  <xs:complexType name=""TEAM-MEMBER-REFType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
        <xs:attribute fixed=""TEAM-MEMBER"" name=""F-ID-CLASS"" type=""xs:NMTOKEN"" />
        <xs:attribute fixed=""LINKEND ID-REF"" name=""HYNAMES"" type=""xs:NMTOKENS"" />
        <xs:attribute fixed=""CLINK"" name=""HYTIME"" type=""xs:NMTOKEN"" />
        <xs:attribute name=""ID-REF"" type=""xs:IDREF"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""TEAM-MEMBER-REFSType"">
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" name=""TEAM-MEMBER-REF"" type=""TEAM-MEMBER-REFType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""TEAM-MEMBERSType"">
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" name=""TEAM-MEMBER"" type=""TEAM-MEMBERType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""TEXTType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""TOLType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""TRANSACTION-IDType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""TYPType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""URLType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
        <xs:attribute name=""MIME-TYPE"" type=""xs:string"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""VERBATIMType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attribute default=""1"" name=""ALLOW-BREAK"" type=""xs:NMTOKEN"" />
        <xs:attributeGroup ref=""DefaultAttributes"" />
        <xs:attribute name=""FLOAT"">
          <xs:simpleType>
            <xs:restriction base=""xs:NMTOKEN"">
              <xs:enumeration value=""FLOAT"" />
              <xs:enumeration value=""NO-FLOAT"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:attribute>
        <xs:attribute name=""HELP-ENTRY"" type=""xs:string"" />
        <xs:attribute name=""KEEP-WITH-PREVIOUS"">
          <xs:simpleType>
            <xs:restriction base=""xs:NMTOKEN"">
              <xs:enumeration value=""KEEP"" />
              <xs:enumeration value=""NO-KEEP"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:attribute>
        <xs:attribute name=""PGWIDE"">
          <xs:simpleType>
            <xs:restriction base=""xs:NMTOKEN"">
              <xs:enumeration value=""PGWIDE"" />
              <xs:enumeration value=""NO-PGWIDE"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:attribute>
        <xs:attribute ref=""xml:space"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""DOCUMENTType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""LABEL"" type=""LABELType"" />
      <xs:element minOccurs=""0"" name=""REVISION-LABEL"" type=""REVISION-LABELType"" />
      <xs:element minOccurs=""0"" name=""COMPANY-DATA-REF"" type=""COMPANY-DATA-REFType"" />
      <xs:element name=""URL"" type=""URLType"" />
      <xs:element minOccurs=""0"" name=""CONTENT"" type=""CONTENTType"" />
    </xs:sequence>
    <xs:attributeGroup ref=""DefaultAttributes"" />
  </xs:complexType>
  <xs:complexType name=""ZIPType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attributeGroup ref=""DefaultAttributes"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
</xs:schema>";
        
        public issue_v3_1_0_sl() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "MSR-ISSUE";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
