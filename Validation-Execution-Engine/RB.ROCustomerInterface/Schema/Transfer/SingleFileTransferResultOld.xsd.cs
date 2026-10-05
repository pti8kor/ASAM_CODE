namespace RB.ROCustomerInterface.Schema.Transfer {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://RB.ROCustomerInterface.SingleFileTransferResult",@"SingleFileTransferResult")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "RQ1System", XPath = @"/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='RQ1System' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "XProtID", XPath = @"/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='XProtID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "InterfaceName", XPath = @"/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='InterfaceName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "DownloadTargetHost", XPath = @"/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='DownloadTargetHost' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "DownloadTargetPath", XPath = @"/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='DownloadTargetPath' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "FileName", XPath = @"/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='FileName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "StatusInfo", XPath = @"/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='StatusInfo' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Status", XPath = @"/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='Status' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "DownloadTime", XPath = @"/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='DownloadTime' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "TransactionID", XPath = @"/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='TransactionID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Mode", XPath = @"/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='Mode' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Category", XPath = @"/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='Category' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SingleFileTransferResult"})]
    public sealed class SingleFileTransferResultOld : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://RB.ROCustomerInterface.SingleFileTransferResult"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://RB.ROCustomerInterface.SingleFileTransferResult"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo standard=""Flat File"" root_reference=""SingleFileTransferResult"" default_pad_char="" "" pad_char_type=""char"" count_positions_by_byte=""false"" parser_optimization=""speed"" lookahead_depth=""3"" suppress_empty_nodes=""false"" generate_empty_nodes=""true"" allow_early_termination=""false"" early_terminate_optional_fields=""false"" allow_message_breakup_of_infix_root=""false"" compile_parse_tables=""false"" />
      <schemaEditorExtension:schemaInfo namespaceAlias=""b"" extensionClass=""Microsoft.BizTalk.FlatFileExtension.FlatFileExtension"" standardName=""Flat File"" xmlns:schemaEditorExtension=""http://schemas.microsoft.com/BizTalk/2003/SchemaEditorExtensions"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""SingleFileTransferResult"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" sequence_number=""1"" />
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='RQ1System' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='XProtID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='InterfaceName' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='DownloadTargetHost' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='DownloadTargetPath' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='FileName' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='StatusInfo' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='Status' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='DownloadTime' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='TransactionID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='Mode' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SingleFileTransferResult' and namespace-uri()='http://RB.ROCustomerInterface.SingleFileTransferResult']/*[local-name()='Category' and namespace-uri()='']"" />
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
        <xs:element name=""XProtID"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo sequence_number=""2"" justification=""left"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""InterfaceName"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo sequence_number=""3"" justification=""left"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""DownloadTargetHost"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo sequence_number=""4"" justification=""left"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""DownloadTargetPath"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo sequence_number=""5"" justification=""left"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""DownloadTime"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo justification=""left"" sequence_number=""6"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""FileName"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo sequence_number=""7"" justification=""left"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""Status"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo justification=""left"" sequence_number=""8"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""StatusInfo"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo sequence_number=""9"" justification=""left"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""TransactionID"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo sequence_number=""10"" justification=""left"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""Mode"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo sequence_number=""11"" justification=""left"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""Category"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo sequence_number=""12"" justification=""left"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public SingleFileTransferResultOld() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "SingleFileTransferResult";
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
