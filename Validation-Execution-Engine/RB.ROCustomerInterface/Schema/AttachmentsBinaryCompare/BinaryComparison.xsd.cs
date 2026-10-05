namespace RB.ROCustomerInterface.Schema.AttachmentsBinaryCompare {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://RB.ROCustomerInterface.RB",@"BinaryComparison")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "RQ1System", XPath = @"/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.ROCustomerInterface.RB']/*[local-name()='RQ1System' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "InterfaceName", XPath = @"/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.ROCustomerInterface.RB']/*[local-name()='InterfaceName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "XProtID", XPath = @"/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.ROCustomerInterface.RB']/*[local-name()='XProtID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "DownloadTargetPath", XPath = @"/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.ROCustomerInterface.RB']/*[local-name()='DownloadTargetPath' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "RQ1FileName", XPath = @"/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.ROCustomerInterface.RB']/*[local-name()='RQ1FileName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ASAMFileName", XPath = @"/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.ROCustomerInterface.RB']/*[local-name()='ASAMFileName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "IssueID", XPath = @"/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.ROCustomerInterface.RB']/*[local-name()='IssueID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "BinaryComparisonStatus", XPath = @"/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.ROCustomerInterface.RB']/*[local-name()='BinaryComparisonStatus' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"BinaryComparison"})]
    public sealed class BinaryComparison : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://RB.ROCustomerInterface.RB"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://RB.ROCustomerInterface.RB"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo standard=""Flat File"" root_reference=""BinaryComparison"" default_pad_char="" "" pad_char_type=""char"" count_positions_by_byte=""false"" parser_optimization=""speed"" lookahead_depth=""3"" suppress_empty_nodes=""false"" generate_empty_nodes=""true"" allow_early_termination=""false"" early_terminate_optional_fields=""false"" allow_message_breakup_of_infix_root=""false"" compile_parse_tables=""false"" />
      <schemaEditorExtension:schemaInfo namespaceAlias=""b"" extensionClass=""Microsoft.BizTalk.FlatFileExtension.FlatFileExtension"" standardName=""Flat File"" xmlns:schemaEditorExtension=""http://schemas.microsoft.com/BizTalk/2003/SchemaEditorExtensions"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""BinaryComparison"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" sequence_number=""1"" />
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.ROCustomerInterface.RB']/*[local-name()='RQ1System' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.ROCustomerInterface.RB']/*[local-name()='InterfaceName' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.ROCustomerInterface.RB']/*[local-name()='XProtID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.ROCustomerInterface.RB']/*[local-name()='DownloadTargetPath' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.ROCustomerInterface.RB']/*[local-name()='RQ1FileName' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.ROCustomerInterface.RB']/*[local-name()='ASAMFileName' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.ROCustomerInterface.RB']/*[local-name()='IssueID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='BinaryComparison' and namespace-uri()='http://RB.ROCustomerInterface.RB']/*[local-name()='BinaryComparisonStatus' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:annotation>
          <xs:appinfo>
            <b:groupInfo sequence_number=""0"" />
          </xs:appinfo>
        </xs:annotation>
        <xs:element name=""RQ1System"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo sequence_number=""1"" justification=""left"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""InterfaceName"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo justification=""left"" sequence_number=""2"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""XProtID"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo justification=""left"" sequence_number=""3"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""DownloadTargetPath"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo justification=""left"" sequence_number=""4"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""ASAMFileName"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo justification=""left"" sequence_number=""5"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""IssueID"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo justification=""left"" sequence_number=""6"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""ORGFileName"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo justification=""left"" sequence_number=""7"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""ORGTruncFileName"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo justification=""left"" sequence_number=""8"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""ORGFileSize"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo justification=""left"" sequence_number=""9"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""RQ1FileName"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo justification=""left"" sequence_number=""10"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""RQ1TruncFileName"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo justification=""left"" sequence_number=""11"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""RQ1FileSize"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo justification=""left"" sequence_number=""12"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""RQ1FileDescription"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo justification=""left"" sequence_number=""13"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""BinaryComparisonStatus"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo sequence_number=""14"" justification=""left"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public BinaryComparison() {
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
