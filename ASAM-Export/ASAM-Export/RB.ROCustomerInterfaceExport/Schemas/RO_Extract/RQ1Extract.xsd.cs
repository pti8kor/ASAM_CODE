namespace RB.ROCustomerInterfaceExport.Schemas.RO_Extract {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"RQ1_EXTRACT")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"RQ1_EXTRACT"})]
    public sealed class RQ1Extract : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xsd:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <xsd:element name=""RQ1_EXTRACT"">
    <xsd:complexType>
      <xsd:sequence>
        <xsd:element minOccurs=""0"" name=""userss"">
          <xsd:complexType>
            <xsd:sequence>
              <xsd:element minOccurs=""0"" maxOccurs=""unbounded"" name=""users"">
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element name=""dbid"" type=""xsd:string"" />
                    <xsd:element name=""email"" type=""xsd:string"" />
                    <xsd:element name=""fullname"" type=""xsd:string"" />
                    <xsd:element name=""login_name"" type=""xsd:string"" />
                    <xsd:element name=""phone"" type=""xsd:string"" />
                  </xsd:sequence>
                  <xsd:attribute name=""recordtype"" type=""xsd:string"" use=""required"" />
                  <xsd:attribute name=""dbid"" type=""xsd:string"" use=""required"" />
                </xsd:complexType>
              </xsd:element>
            </xsd:sequence>
          </xsd:complexType>
        </xsd:element>
        <xsd:element minOccurs=""0"" name=""Contacts"">
          <xsd:complexType>
            <xsd:sequence>
              <xsd:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Contact"">
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element name=""dbid"" type=""xsd:string"" />
                    <xsd:element name=""eMail"" type=""xsd:string"" />
                    <xsd:element name=""Department"" type=""xsd:string"" />
                    <xsd:element name=""FirstName"" type=""xsd:string"" />
                    <xsd:element name=""LastName"" type=""xsd:string"" />
                    <xsd:element name=""PhoneNumbers"" type=""xsd:string"" />
                  </xsd:sequence>
                  <xsd:attribute name=""recordtype"" type=""xsd:string"" use=""required"" />
                  <xsd:attribute name=""dbid"" type=""xsd:string"" use=""required"" />
                </xsd:complexType>
              </xsd:element>
            </xsd:sequence>
          </xsd:complexType>
        </xsd:element>
        <xsd:element minOccurs=""0"" name=""Issues"">
          <xsd:complexType>
            <xsd:sequence>
              <xsd:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Issue"">
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element name=""dbid"" type=""xsd:string"" />
                    <xsd:element name=""id"" type=""xsd:string"" />
                    <xsd:element name=""Assignee"" type=""xsd:string"" />
                    <xsd:element name=""Attachments"" type=""xsd:string"" />
                    <xsd:element name=""CommercialAssignee"" type=""xsd:string"" />
                    <xsd:element name=""Domain"" type=""xsd:string"" />
                    <xsd:element name=""ExternalAssignee"" type=""xsd:string"" />
                    <xsd:element name=""ExternalComment"" type=""xsd:string"" />
                    <xsd:element name=""ExternalConversation"" type=""xsd:string"" />
                    <xsd:element name=""ExternalExchangedAttach"" type=""xsd:string"" />
                    <xsd:element name=""ExternalExchangeWorkflow"" type=""xsd:string"" />
                    <xsd:element name=""ExternalHistory"" type=""xsd:string"" />
                    <xsd:element name=""ExternalNextState"" type=""xsd:string"" />
                    <xsd:element name=""ExternalOrganisation"" type=""xsd:string"" />
                    <xsd:element name=""ExternalState_Parallel1"" type=""xsd:string"" />
                    <xsd:element name=""ExternalSubmitter"" type=""xsd:string"" />
                    <xsd:element name=""ExternalTitle"" type=""xsd:string"" />
                    <xsd:element name=""External_ID"" type=""xsd:string"" />
                    <xsd:element name=""hasAttachmentMappings"" type=""xsd:string"" />
                    <xsd:element name=""hasCommercialData"" type=""xsd:string"" />
                    <xsd:element name=""OEMProposalAdopted"" type=""xsd:string"" />
                    <xsd:element name=""Tags"" type=""xsd:string"" />
                    <xsd:element name=""Type"" type=""xsd:string"" />
                    <xsd:element name=""ExternalState_Parallel2"" type=""xsd:string"" />
                    <xsd:element name=""ExternalUpdateVersion"" type=""xsd:string"" />
                  </xsd:sequence>
                  <xsd:attribute name=""recordtype"" type=""xsd:string"" use=""required"" />
                  <xsd:attribute name=""dbid"" type=""xsd:string"" use=""required"" />
                </xsd:complexType>
              </xsd:element>
            </xsd:sequence>
          </xsd:complexType>
        </xsd:element>
        <xsd:element minOccurs=""0"" name=""Releases"" type=""xsd:anyType"" />
        <xsd:element minOccurs=""0"" name=""AttachmentMappings"">
          <xsd:complexType>
            <xsd:sequence>
              <xsd:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AttachmentMapping"">
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element name=""dbid"" type=""xsd:string"" />
                    <xsd:element name=""Attribute"" type=""xsd:string"" />
                    <xsd:element name=""ExportState"" type=""xsd:string"" />
                    <xsd:element name=""Eng_Attachment"" type=""xsd:string"" />
                    <xsd:element name=""Sales_Attachment"" type=""xsd:string"" />
                  </xsd:sequence>
                  <xsd:attribute name=""recordtype"" type=""xsd:string"" use=""required"" />
                  <xsd:attribute name=""dbid"" type=""xsd:string"" use=""required"" />
                </xsd:complexType>
              </xsd:element>
            </xsd:sequence>
          </xsd:complexType>
        </xsd:element>
        <xsd:element minOccurs=""0"" name=""Attachmentss"" type=""xsd:anyType"" />
        <xsd:element minOccurs=""0"" name=""Commercials"">
          <xsd:complexType>
            <xsd:sequence>
              <xsd:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Commercial"">
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element name=""dbid"" type=""xsd:string"" />
                    <xsd:element name=""CommercialAmount"" type=""xsd:string"" />
                    <xsd:element name=""CommercialAmountDetails"" type=""xsd:string"" />
                    <xsd:element name=""CommercialAmountUnit"" type=""xsd:string"" />
                    <xsd:element name=""CommercialAttachments"" type=""xsd:string"" />
                    <xsd:element name=""CommercialComment"" type=""xsd:string"" />
                    <xsd:element name=""CommercialConversation"" type=""xsd:string"" />
                    <xsd:element name=""CommercialTags"" type=""xsd:string"" />
                  </xsd:sequence>
                  <xsd:attribute name=""recordtype"" type=""xsd:string"" use=""required"" />
                  <xsd:attribute name=""dbid"" type=""xsd:string"" use=""required"" />
                </xsd:complexType>
              </xsd:element>
            </xsd:sequence>
          </xsd:complexType>
        </xsd:element>
        <xsd:element name=""IssueReleaseMaps"">
          <xsd:complexType>
            <xsd:sequence>
              <xsd:element name=""IssueReleaseMap"">
                <xsd:complexType>
                  <xsd:sequence>
                    <xsd:element name=""dbid"" type=""xsd:string"" />
                    <xsd:element name=""id"" type=""xsd:string"" />
                    <xsd:element name=""Assignee"" type=""xsd:string"" />
                    <xsd:element name=""ExternalComment"" type=""xsd:string"" />
                    <xsd:element name=""ExternalConversation"" type=""xsd:string"" />
                    <xsd:element name=""ExternalNextState"" type=""xsd:string"" />
                    <xsd:element name=""ExternalTags"" type=""xsd:string"" />
                    <xsd:element name=""hasMappedIssue"" type=""xsd:string"" />
                    <xsd:element name=""MappingToDerivatives"" type=""xsd:string"" />
                    <xsd:element name=""isPilot"" type=""xsd:string"" />
                    <xsd:element name=""hasMappedRelease"" type=""xsd:string"" />
                    <xsd:element name=""ExternalState_Parallel1"" type=""xsd:string"" />
                    <xsd:element name=""ExternalHistory"" type=""xsd:string"" />
                    <xsd:element name=""ExternalUpdateVersion"" type=""xsd:string"" />
                    <xsd:element name=""Tags"" type=""xsd:string"" />
                  </xsd:sequence>
                  <xsd:attribute name=""recordtype"" type=""xsd:string"" />
                  <xsd:attribute name=""dbid"" type=""xsd:string"" />
                </xsd:complexType>
              </xsd:element>
            </xsd:sequence>
          </xsd:complexType>
        </xsd:element>
        <xsd:element name=""Exchangeprotocols"">
          <xsd:complexType />
        </xsd:element>
      </xsd:sequence>
    </xsd:complexType>
  </xsd:element>
</xsd:schema>";
        
        public RQ1Extract() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "RQ1_EXTRACT";
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
