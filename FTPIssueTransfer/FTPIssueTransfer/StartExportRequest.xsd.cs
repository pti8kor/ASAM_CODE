namespace FTPIssueTransfer {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://FTPIssueTransfer.StartExportRequest",@"ExportRequest")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "RQ1System", XPath = @"/*[local-name()='ExportRequest' and namespace-uri()='http://FTPIssueTransfer.StartExportRequest']/*[local-name()='RQ1System' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "XProtID", XPath = @"/*[local-name()='ExportRequest' and namespace-uri()='http://FTPIssueTransfer.StartExportRequest']/*[local-name()='XProtID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "InterfaceName", XPath = @"/*[local-name()='ExportRequest' and namespace-uri()='http://FTPIssueTransfer.StartExportRequest']/*[local-name()='InterfaceName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "FTPFileNames", XPath = @"/*[local-name()='ExportRequest' and namespace-uri()='http://FTPIssueTransfer.StartExportRequest']/*[local-name()='FTPFileNames' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "BTRMsg", XPath = @"/*[local-name()='ExportRequest' and namespace-uri()='http://FTPIssueTransfer.StartExportRequest']/*[local-name()='BTRMsg' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Dummy", XPath = @"/*[local-name()='ExportRequest' and namespace-uri()='http://FTPIssueTransfer.StartExportRequest']/*[local-name()='Dummy' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ExportRequest"})]
    public sealed class StartExportRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://FTPIssueTransfer.StartExportRequest"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://FTPIssueTransfer.StartExportRequest"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ExportRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='ExportRequest' and namespace-uri()='http://FTPIssueTransfer.StartExportRequest']/*[local-name()='RQ1System' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ExportRequest' and namespace-uri()='http://FTPIssueTransfer.StartExportRequest']/*[local-name()='XProtID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ExportRequest' and namespace-uri()='http://FTPIssueTransfer.StartExportRequest']/*[local-name()='InterfaceName' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ExportRequest' and namespace-uri()='http://FTPIssueTransfer.StartExportRequest']/*[local-name()='FTPFileNames' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ExportRequest' and namespace-uri()='http://FTPIssueTransfer.StartExportRequest']/*[local-name()='BTRMsg' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='ExportRequest' and namespace-uri()='http://FTPIssueTransfer.StartExportRequest']/*[local-name()='Dummy' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RQ1System"" type=""xs:string"" />
        <xs:element name=""XProtID"" type=""xs:string"" />
        <xs:element name=""InterfaceName"" type=""xs:string"" />
        <xs:element name=""TargetedProjects"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""TargetedProject"">
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
        <xs:element name=""BTRMsg"" type=""xs:string"" />
        <xs:element name=""Dummy"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public StartExportRequest() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ExportRequest";
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
