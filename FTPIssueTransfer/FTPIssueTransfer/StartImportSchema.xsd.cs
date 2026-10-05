namespace FTPIssueTransfer {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://FTPIssueTransfer.Schema1",@"FTPImportRequest")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "RQ1System", XPath = @"/*[local-name()='FTPImportRequest' and namespace-uri()='http://FTPIssueTransfer.Schema1']/*[local-name()='RQ1System' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "XProtID", XPath = @"/*[local-name()='FTPImportRequest' and namespace-uri()='http://FTPIssueTransfer.Schema1']/*[local-name()='XProtID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "InterfaceName", XPath = @"/*[local-name()='FTPImportRequest' and namespace-uri()='http://FTPIssueTransfer.Schema1']/*[local-name()='InterfaceName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "FTPFileNames", XPath = @"/*[local-name()='FTPImportRequest' and namespace-uri()='http://FTPIssueTransfer.Schema1']/*[local-name()='FTPFileNames' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "BTReturnMsg", XPath = @"/*[local-name()='FTPImportRequest' and namespace-uri()='http://FTPIssueTransfer.Schema1']/*[local-name()='BTReturnMsg' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Dummy", XPath = @"/*[local-name()='FTPImportRequest' and namespace-uri()='http://FTPIssueTransfer.Schema1']/*[local-name()='Dummy' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"FTPImportRequest"})]
    public sealed class StartImportSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://FTPIssueTransfer.Schema1"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://FTPIssueTransfer.PropertySchema"" targetNamespace=""http://FTPIssueTransfer.Schema1"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""FTPImportRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='FTPImportRequest' and namespace-uri()='http://FTPIssueTransfer.Schema1']/*[local-name()='RQ1System' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='FTPImportRequest' and namespace-uri()='http://FTPIssueTransfer.Schema1']/*[local-name()='XProtID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='FTPImportRequest' and namespace-uri()='http://FTPIssueTransfer.Schema1']/*[local-name()='InterfaceName' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='FTPImportRequest' and namespace-uri()='http://FTPIssueTransfer.Schema1']/*[local-name()='FTPFileNames' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='FTPImportRequest' and namespace-uri()='http://FTPIssueTransfer.Schema1']/*[local-name()='BTReturnMsg' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='FTPImportRequest' and namespace-uri()='http://FTPIssueTransfer.Schema1']/*[local-name()='Dummy' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RQ1System"" type=""xs:string"" />
        <xs:element name=""XProtID"" type=""xs:string"" />
        <xs:element name=""InterfaceName"" type=""xs:string"" />
        <xs:element name=""TargetProjects"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""TargetProject"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ProjectID"" type=""xs:string"" />
                    <xs:element name=""ProjectDomain"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""FTPFileNames"" type=""xs:string"" />
        <xs:element name=""BTReturnMsg"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""Dummy"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public StartImportSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "FTPImportRequest";
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
