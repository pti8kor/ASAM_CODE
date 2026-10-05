namespace RB.ROCustomerInterface.Schema.Transfer {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://FTPIssueTransfer.FTPFileInformation",@"TransferResult")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "DownloadTargetPath", XPath = @"/*[local-name()='TransferResult' and namespace-uri()='http://FTPIssueTransfer.FTPFileInformation']/*[local-name()='DownloadTargetPath' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "InterfaceName", XPath = @"/*[local-name()='TransferResult' and namespace-uri()='http://FTPIssueTransfer.FTPFileInformation']/*[local-name()='InterfaceName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "XProtID", XPath = @"/*[local-name()='TransferResult' and namespace-uri()='http://FTPIssueTransfer.FTPFileInformation']/*[local-name()='XProtID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "LifeToken4XProt", XPath = @"/*[local-name()='TransferResult' and namespace-uri()='http://FTPIssueTransfer.FTPFileInformation']/*[local-name()='LifeToken4XProt' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "LifeToken4Files", XPath = @"/*[local-name()='TransferResult' and namespace-uri()='http://FTPIssueTransfer.FTPFileInformation']/*[local-name()='LifeToken4Files' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "RQ1System", XPath = @"/*[local-name()='TransferResult' and namespace-uri()='http://FTPIssueTransfer.FTPFileInformation']/*[local-name()='RQ1System' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "DownloadTargetHost", XPath = @"/*[local-name()='TransferResult' and namespace-uri()='http://FTPIssueTransfer.FTPFileInformation']/*[local-name()='DownloadTargetHost' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "DownloadTime", XPath = @"/*[local-name()='TransferResult' and namespace-uri()='http://FTPIssueTransfer.FTPFileInformation']/*[local-name()='DownloadTime' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Mode", XPath = @"/*[local-name()='TransferResult' and namespace-uri()='http://FTPIssueTransfer.FTPFileInformation']/*[local-name()='Mode' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"TransferResult"})]
    public sealed class TransferResultInformation : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://FTPIssueTransfer.FTPFileInformation"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://FTPIssueTransfer.FTPFileInformation"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo standard=""Flat File"" root_reference=""TransferResult"" default_pad_char="" "" pad_char_type=""char"" count_positions_by_byte=""false"" parser_optimization=""speed"" lookahead_depth=""3"" suppress_empty_nodes=""false"" generate_empty_nodes=""true"" allow_early_termination=""false"" early_terminate_optional_fields=""false"" allow_message_breakup_of_infix_root=""false"" compile_parse_tables=""false"" />
      <schemaEditorExtension:schemaInfo namespaceAlias=""b"" extensionClass=""Microsoft.BizTalk.FlatFileExtension.FlatFileExtension"" standardName=""Flat File"" xmlns:schemaEditorExtension=""http://schemas.microsoft.com/BizTalk/2003/SchemaEditorExtensions"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""TransferResult"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" sequence_number=""1"" />
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='TransferResult' and namespace-uri()='http://FTPIssueTransfer.FTPFileInformation']/*[local-name()='DownloadTargetPath' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TransferResult' and namespace-uri()='http://FTPIssueTransfer.FTPFileInformation']/*[local-name()='InterfaceName' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TransferResult' and namespace-uri()='http://FTPIssueTransfer.FTPFileInformation']/*[local-name()='TargetProjectID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TransferResult' and namespace-uri()='http://FTPIssueTransfer.FTPFileInformation']/*[local-name()='XProtID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TransferResult' and namespace-uri()='http://FTPIssueTransfer.FTPFileInformation']/*[local-name()='LifeToken4XProt' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TransferResult' and namespace-uri()='http://FTPIssueTransfer.FTPFileInformation']/*[local-name()='LifeToken4Files' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TransferResult' and namespace-uri()='http://FTPIssueTransfer.FTPFileInformation']/*[local-name()='RQ1System' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TransferResult' and namespace-uri()='http://FTPIssueTransfer.FTPFileInformation']/*[local-name()='DownloadTargetHost' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TransferResult' and namespace-uri()='http://FTPIssueTransfer.FTPFileInformation']/*[local-name()='DownloadTime' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='TransferResult' and namespace-uri()='http://FTPIssueTransfer.FTPFileInformation']/*[local-name()='Mode' and namespace-uri()='']"" />
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
              <b:fieldInfo justification=""left"" sequence_number=""1"" />
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
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""TargetProjects"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" sequence_number=""4"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:complexType>
            <xs:sequence>
              <xs:annotation>
                <xs:appinfo>
                  <b:groupInfo sequence_number=""0"" />
                </xs:appinfo>
              </xs:annotation>
              <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""TargetProject"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:recordInfo sequence_number=""1"" structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:complexType>
                  <xs:sequence>
                    <xs:annotation>
                      <xs:appinfo>
                        <b:groupInfo sequence_number=""0"" />
                      </xs:appinfo>
                    </xs:annotation>
                    <xs:element name=""ProjectID"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo sequence_number=""1"" justification=""left"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element name=""ProjectDomain"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo sequence_number=""2"" justification=""left"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""DownloadTargetHost"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo justification=""left"" sequence_number=""5"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""DownloadTargetPath"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo sequence_number=""6"" justification=""left"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""DownloadTime"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo sequence_number=""7"" justification=""left"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""LifeToken4XProt"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo sequence_number=""8"" justification=""left"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""LifeToken4Files"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo sequence_number=""9"" justification=""left"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element name=""Mode"" type=""xs:string"">
          <xs:annotation>
            <xs:appinfo>
              <b:fieldInfo sequence_number=""10"" justification=""left"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public TransferResultInformation() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "TransferResult";
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
