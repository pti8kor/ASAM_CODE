namespace RB.BT.ROBinaryComparison {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://RB.BT.ROBinaryComparison.Test",@"BinaryComparison")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "RQ1System", XPath = @"/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.BT.ROBinaryComparison.Test']/*[local-name()='RQ1System' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "IssueID", XPath = @"/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.BT.ROBinaryComparison.Test']/*[local-name()='IssueID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ASAMFileName", XPath = @"/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.BT.ROBinaryComparison.Test']/*[local-name()='ASAMFileName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "BinaryComparisonStatus", XPath = @"/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.BT.ROBinaryComparison.Test']/*[local-name()='BinaryComparisonStatus' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"BinaryComparison"})]
    public sealed class Test : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://RB.BT.ROBinaryComparison.Test"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://RB.BT.ROBinaryComparison.Test"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""BinaryComparison"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.BT.ROBinaryComparison.Test']/*[local-name()='RQ1System' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.BT.ROBinaryComparison.Test']/*[local-name()='IssueID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.BT.ROBinaryComparison.Test']/*[local-name()='ASAMFileName' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.BT.ROBinaryComparison.Test']/*[local-name()='BinaryComparisonStatus' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RQ1System"" type=""xs:string"" />
        <xs:element name=""InterfaceName"" type=""xs:string"" />
        <xs:element name=""XProtID"" type=""xs:string"" />
        <xs:element name=""DownloadTargetPath"" type=""xs:string"" />
        <xs:element name=""ASAMFileName"" type=""xs:string"" />
        <xs:element name=""IssueID"" type=""xs:string"" />
        <xs:element name=""ORGFileName"" type=""xs:string"" />
        <xs:element name=""ORGTruncFileName"" type=""xs:string"" />
        <xs:element name=""ORGFileSize"" type=""xs:string"" />
        <xs:element name=""RQ1FileName"" type=""xs:string"" />
        <xs:element name=""RQ1TruncFileName"" type=""xs:string"" />
        <xs:element name=""RQ1FileSize"" type=""xs:string"" />
        <xs:element name=""RQ1FileDescription"" type=""xs:string"" />
        <xs:element name=""BinaryComparisonStatus"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Test() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "BinaryComparison";
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
