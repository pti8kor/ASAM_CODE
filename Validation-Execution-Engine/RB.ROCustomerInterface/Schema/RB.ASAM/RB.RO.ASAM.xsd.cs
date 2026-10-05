namespace RB.ROCustomerInterface.Schema.RB.ASAM {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://RB.ROCustomerInterface.RB",@"ASAMISSUE_EXTRACT")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ASAMISSUE_EXTRACT"})]
    public sealed class RB_RO_ASAM : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://RB.ROCustomerInterface.RB"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://RB.ROCustomerInterface.RB"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ASAMISSUE_EXTRACT"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='ASAMISSUE_EXTRACT' and namespace-uri()='http://RB.ROCustomerInterface.RB']/*[local-name()='RT_ISSUES' and namespace-uri()='']/*[local-name()='ISSUE' and namespace-uri()='']/*[local-name()='TRANSACTIONID' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RT_VALEX_CONTROLINFO"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""VALEX_CONTROLINFO"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""OEMEXTERNALSTATE"" type=""xs:string"" />
                    <xs:element name=""OEMWORKFLOW"" type=""xs:string"" />
                  </xs:sequence>
                  <xs:attribute name=""ACTION"" type=""xs:string"" />
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""RT_CONTACT"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""CONTACT"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""DBID"" type=""xs:string"" />
                    <xs:element name=""FIRSTNAME"" type=""xs:string"" />
                    <xs:element name=""LASTNAME"" type=""xs:string"" />
                    <xs:element name=""EMAIL"" type=""xs:string"" />
                    <xs:element name=""PHONENUMBERS"" type=""xs:string"" />
                    <xs:element name=""DEPARTMENT"" type=""xs:string"" />
                    <xs:element name=""ORGANIZATION"" type=""xs:string"" />
                    <xs:element name=""ROLE"" type=""xs:string"" />
                    <xs:element name=""DESCRIPTION"" type=""xs:string"" />
                    <xs:element name=""OPERATIONMODE"" type=""xs:string"" />
                    <xs:element name=""OPERATIONCONTEXT"" type=""xs:string"" />
                  </xs:sequence>
                  <xs:attribute name=""ID"" type=""xs:string"" />
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""RT_ISSUES"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ISSUE"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""DBID"" type=""xs:string"" />
                    <xs:element name=""RB_ID"" type=""xs:string"" />
                    <xs:element name=""ID"" type=""xs:string"" />
                    <xs:element name=""TITLE"" type=""xs:string"" />
                    <xs:element name=""DESCRIPTION"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element maxOccurs=""unbounded"" name=""P"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""BELONGSTOPROJECT"">
                      <xs:complexType>
                        <xs:attribute name=""ID-REF"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""TYPE"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""DOMAIN"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""SCOPE"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""CATEGORY"" type=""xs:string"" />
                    <xs:element name=""ISSUE_CATEGORY_FROM_CUSTOMER"" type=""xs:string"" />
                    <xs:element name=""ISSUETAGS"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""ISSUETAG"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""P"" type=""xs:string"" />
                              </xs:sequence>
                              <xs:attribute name=""ACTION"" type=""xs:string"" />
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""EXTERNAL_ID"" type=""xs:string"" />
                    <xs:element name=""EXTERNALTITLE"" type=""xs:string"" />
                    <xs:element name=""EXTERNALSTATE_PARALLEL1"" type=""xs:string"" />
                    <xs:element name=""EXTERNALSTATE_PARALLEL2"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""EXTERNALNEXTSTATE"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""EXTERNALCOMMENT"" type=""xs:string"" />
                    <xs:element name=""EXTERNALSUBMITTER"">
                      <xs:complexType>
                        <xs:attribute name=""ID-REF"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""EXTERNALASSIGNEE"">
                      <xs:complexType>
                        <xs:attribute name=""ID-REF"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""EXTERNALORGANISATION"" type=""xs:string"" />
                    <xs:element name=""EXTERNALREVIEW"" type=""xs:string"" />
                    <xs:element name=""EXTERNALTAGS"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element maxOccurs=""unbounded"" name=""EXTERNALTAG"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""P"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""EXTERNALDESCRIPTION"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element maxOccurs=""unbounded"" name=""P"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""EXTERNALMILESTONES"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element maxOccurs=""unbounded"" name=""P"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""EXTERNALCONVERSATION"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element maxOccurs=""unbounded"" name=""P"" type=""xs:string"" />
                        </xs:sequence>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""EXTERNALEXCHANGEWORKFLOW"" type=""xs:string"" />
                    <xs:element name=""EXTERNALLASTEXPORTEDDATE"" type=""xs:string"" />
                    <xs:element name=""EXTERNALLASTIMPORTEDDATE"" type=""xs:string"" />
                    <xs:element name=""ATTACHMENTS"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element maxOccurs=""unbounded"" name=""ATTACHMENT"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""NAME"" type=""xs:string"" />
                                <xs:element name=""DESCRIPTION"" type=""xs:string"" />
                                <xs:element name=""FULL_NAME"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                        <xs:attribute name=""TYPE"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""EXTERNALEXCHANGEDATTACH"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""P"" type=""xs:string"" />
                        </xs:sequence>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""COMMERCIALCLASSIFICATION"" type=""xs:string"" />
                    <xs:element name=""COMMERCIALAMOUNT"" type=""xs:string"" />
                    <xs:element name=""COMMERCIALAMOUNTCONFIRMED"" type=""xs:string"" />
                    <xs:element name=""COMMERCIALORIGSOLUTIONACC"" type=""xs:string"" />
                    <xs:element name=""COMMERCIALCOMMENT"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element maxOccurs=""unbounded"" name=""P"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""COMMERCIALCONVERSATION"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element maxOccurs=""unbounded"" name=""P"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""COMMERCIALQUOTATIONREQ"" type=""xs:string"" />
                    <xs:element name=""OCCURRENCE"" type=""xs:string"" />
                    <xs:element name=""SEVERITY"" type=""xs:string"" />
                    <xs:element name=""EXTERNALHISTORY"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""OEMEXTERNALSTATE"" type=""xs:string"" />
                    <xs:element name=""AFFECTEDISSUE_EXTERNAL"" type=""xs:string"" />
                    <xs:element name=""IRM_ID"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""OEMWORKFLOWTYPE"">
                      <xs:complexType />
                    </xs:element>
                    <xs:element name=""OEMWORKFLOW"" type=""xs:string"" />
                    <xs:element name=""LIFECYCLESTATE"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""ASILCLASSIFICATION"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""PVER-EXTERNALTITLE"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""INTERNALCOMMENT"" type=""xs:string"" />
                    <xs:element name=""HASPREDECESSOR"" type=""xs:string"" />
                    <xs:element name=""BELONGSTOPROJECT_TITLE"" type=""xs:string"" />
                    <xs:element name=""OPERATIONMODE"" type=""xs:string"" />
                    <xs:element name=""OPERATIONCONTEXT"" type=""xs:string"" />
                    <xs:element name=""EXTERNALUPDATEVERSION"" type=""xs:string"" />
                    <xs:element name=""EXPORT_COUNTER_OEM"" type=""xs:string"" />
                    <xs:element name=""EXPORT_COUNTER_SUPPLIER"" type=""xs:string"" />
                    <xs:element name=""OEMORIGINATINGSTATE"" type=""xs:string"" />
                    <xs:element name=""TAGS"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""TAGS"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""P"" type=""xs:string"" />
                              </xs:sequence>
                              <xs:attribute name=""ACTION"" type=""xs:string"" />
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""OEMTEMP"" type=""xs:string"" />
                    <xs:element name=""ASSIGNEE"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                  <xs:attribute name=""ID"" type=""xs:string"" />
                  <xs:attribute name=""ACTION"" type=""xs:string"" />
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""RT_PROJECTS"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""PROJECT"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ID"">
                      <xs:complexType />
                    </xs:element>
                    <xs:element name=""DBID"">
                      <xs:complexType />
                    </xs:element>
                    <xs:element name=""RB_ID"" type=""xs:string"" />
                    <xs:element name=""DOMAIN"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""TYPE"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""TITLE"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""SCOPE"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""EXTERNAL_ID"">
                      <xs:complexType />
                    </xs:element>
                    <xs:element name=""EXTERNALTITLE"">
                      <xs:complexType />
                    </xs:element>
                    <xs:element name=""BELONGSTOPOOLPROJECT"">
                      <xs:complexType />
                    </xs:element>
                    <xs:element name=""CUSTOMER"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""OPERATIONMODE"" type=""xs:string"" />
                    <xs:element name=""OPERATIONCONTEXT"" type=""xs:string"" />
                  </xs:sequence>
                  <xs:attribute name=""ID"" type=""xs:string"" />
                  <xs:attribute name=""ACTION"" type=""xs:string"" />
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""RT_RELEASES"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""RELEASE"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""DBID"" type=""xs:string"" />
                    <xs:element name=""RB_ID"" type=""xs:string"" />
                    <xs:element name=""ID"" type=""xs:string"" />
                    <xs:element name=""DOMAIN"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""TYPE"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""SCOPE"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""TITLE"" type=""xs:string"" />
                    <xs:element name=""EXTERNALDESCRIPTION"" type=""xs:string"" />
                    <xs:element name=""EXTERNAL_ID"" type=""xs:string"" />
                    <xs:element name=""PLANNEDDATE"" type=""xs:string"" />
                    <xs:element name=""EXTERNALTITLE"" type=""xs:string"" />
                    <xs:element name=""BELONGSTOPROJECT"">
                      <xs:complexType>
                        <xs:attribute name=""ID-REF"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""CATEGORY"" type=""xs:string"" />
                    <xs:element name=""LIFECYCLESTATE"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""EXTERNALASSIGNEE"">
                      <xs:complexType>
                        <xs:attribute name=""ID-REF"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""OPERATIONMODE"" type=""xs:string"" />
                    <xs:element name=""OPERATIONCONTEXT"" type=""xs:string"" />
                    <xs:element name=""PVER_CATEGORY"" type=""xs:string"" />
                  </xs:sequence>
                  <xs:attribute name=""ID"" type=""xs:string"" />
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""RT_IRMAPS"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""IRMAP"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""DBID"" type=""xs:string"" />
                    <xs:element name=""RB_ID"" type=""xs:string"" />
                    <xs:element name=""SCOPE"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""HASMAPPEDISSUE"">
                      <xs:complexType>
                        <xs:attribute name=""ID-REF"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""HASMAPPEDRELEASE"">
                      <xs:complexType>
                        <xs:attribute name=""ID-REF"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""ISPILOT"" type=""xs:string"" />
                    <xs:element name=""EXTERNALTAGS"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""EXTERNALTAG"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""P"" type=""xs:string"" />
                              </xs:sequence>
                              <xs:attribute name=""ACTION"" type=""xs:string"" />
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""EXTERNALEXCHANGEWORKFLOW"" type=""xs:string"" />
                    <xs:element name=""EXTERNALREVIEW"" type=""xs:string"" />
                    <xs:element name=""EXTERNAL_ID"" type=""xs:string"" />
                    <xs:element name=""EXTERNALTITLE"" type=""xs:string"" />
                    <xs:element name=""EXTERNALSTATE_PARALLEL1"" type=""xs:string"" />
                    <xs:element name=""EXTERNALCONVERSATION"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""P"" type=""xs:string"" />
                        </xs:sequence>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""EXTERNALLASTEXPORTEDDATE"" type=""xs:string"" />
                    <xs:element name=""EXTERNALLASTIMPORTEDDATE"" type=""xs:string"" />
                    <xs:element name=""RELEASEEXTERNAL_ID"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""TAGS"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""TAGS"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""P"" type=""xs:string"" />
                              </xs:sequence>
                              <xs:attribute name=""ACTION"" type=""xs:string"" />
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""LIFECYCLESTATE"" type=""xs:string"" />
                    <xs:element name=""MAPPINGTODERIVATIVES"" type=""xs:string"" />
                    <xs:element name=""QUALIFICATIONSTATUS"" type=""xs:string"" />
                    <xs:element name=""EXTERNALUPDATEVERSION"" type=""xs:string"" />
                    <xs:element name=""OEMORIGINATINGSTATE"" type=""xs:string"" />
                    <xs:element name=""ACTUALCONFIGURATION"" type=""xs:string"" />
                    <xs:element name=""WORKFLOWSTATUS"" type=""xs:string"" />
                    <xs:element name=""EXTERNALNEXTSTATE"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""EXTERNALASSIGNEE"">
                      <xs:complexType>
                        <xs:attribute name=""ID-REF"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""OPERATIONMODE"" type=""xs:string"" />
                    <xs:element name=""OPERATIONCONTEXT"" type=""xs:string"" />
                    <xs:element name=""LIFECYCLESTATECOMMENT"" type=""xs:string"" />
                    <xs:element name=""ERRORCODE"" type=""xs:string"" />
                    <xs:element name=""TRANSACTIONID"" type=""xs:string"" />
                    <xs:element name=""EXPORT_COUNTER_OEM"" type=""xs:string"" />
                    <xs:element name=""EXTERNALDESCRIPTION"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""EXTERNALHISTORY"">
                      <xs:complexType>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""ASSIGNEE"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""RT_COMMERCIALS"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""COMMERCIAL"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""BELONGSTOISSUE"">
                      <xs:complexType>
                        <xs:attribute name=""ID-REF"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""COMMERCIALCONVERSATION"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""P"">
                            <xs:complexType />
                          </xs:element>
                        </xs:sequence>
                        <xs:attribute name=""ACTION"" type=""xs:string"" />
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""DBID"" type=""xs:string"" />
                    <xs:element name=""COMMERCIALCOMMENT"" type=""xs:string"" />
                    <xs:element name=""COMMERCIALTAGS"" type=""xs:string"" />
                    <xs:element name=""OPERATIONMODE"" type=""xs:string"" />
                    <xs:element name=""OPERATIONCONTEXT"" type=""xs:string"" />
                  </xs:sequence>
                  <xs:attribute name=""ID"" type=""xs:string"" />
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public RB_RO_ASAM() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ASAMISSUE_EXTRACT";
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
