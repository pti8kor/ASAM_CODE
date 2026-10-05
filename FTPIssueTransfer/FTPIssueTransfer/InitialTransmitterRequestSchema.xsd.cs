namespace FTPIssueTransfer {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://FTPIssueTransfer.InitialTransmitterRequestSchema",@"transmitterRequest")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "transferData", XPath = @"/*[local-name()='transmitterRequest' and namespace-uri()='http://FTPIssueTransfer.InitialTransmitterRequestSchema']/*[local-name()='transferData' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "transferFile", XPath = @"/*[local-name()='transmitterRequest' and namespace-uri()='http://FTPIssueTransfer.InitialTransmitterRequestSchema']/*[local-name()='transferFile' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "transferType", XPath = @"/*[local-name()='transmitterRequest' and namespace-uri()='http://FTPIssueTransfer.InitialTransmitterRequestSchema']/*[local-name()='transferType' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "RQ1System", XPath = @"/*[local-name()='transmitterRequest' and namespace-uri()='http://FTPIssueTransfer.InitialTransmitterRequestSchema']/*[local-name()='RQ1System' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "InterfaceName", XPath = @"/*[local-name()='transmitterRequest' and namespace-uri()='http://FTPIssueTransfer.InitialTransmitterRequestSchema']/*[local-name()='InterfaceName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "XProtID", XPath = @"/*[local-name()='transmitterRequest' and namespace-uri()='http://FTPIssueTransfer.InitialTransmitterRequestSchema']/*[local-name()='XProtID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Category", XPath = @"/*[local-name()='transmitterRequest' and namespace-uri()='http://FTPIssueTransfer.InitialTransmitterRequestSchema']/*[local-name()='Category' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"transmitterRequest"})]
    public sealed class InitialTransmitterRequestSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://FTPIssueTransfer.InitialTransmitterRequestSchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://FTPIssueTransfer.InitialTransmitterRequestSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""transmitterRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='transmitterRequest' and namespace-uri()='http://FTPIssueTransfer.InitialTransmitterRequestSchema']/*[local-name()='transferData' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='transmitterRequest' and namespace-uri()='http://FTPIssueTransfer.InitialTransmitterRequestSchema']/*[local-name()='transferFile' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='transmitterRequest' and namespace-uri()='http://FTPIssueTransfer.InitialTransmitterRequestSchema']/*[local-name()='transferType' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='transmitterRequest' and namespace-uri()='http://FTPIssueTransfer.InitialTransmitterRequestSchema']/*[local-name()='RQ1System' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='transmitterRequest' and namespace-uri()='http://FTPIssueTransfer.InitialTransmitterRequestSchema']/*[local-name()='InterfaceName' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='transmitterRequest' and namespace-uri()='http://FTPIssueTransfer.InitialTransmitterRequestSchema']/*[local-name()='XProtID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='transmitterRequest' and namespace-uri()='http://FTPIssueTransfer.InitialTransmitterRequestSchema']/*[local-name()='Category' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" form=""unqualified"" name=""transferBinary"" type=""xs:base64Binary"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" form=""unqualified"" name=""transferData"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" form=""unqualified"" name=""transferFile"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" form=""unqualified"" name=""transferType"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" form=""unqualified"" name=""RQ1System"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" form=""unqualified"" name=""InterfaceName"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""1"" form=""unqualified"" name=""XProtID"" type=""xs:string"" />
        <xs:element name=""Category"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public InitialTransmitterRequestSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "transmitterRequest";
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
