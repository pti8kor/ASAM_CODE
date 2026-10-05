namespace RB.ROCustomerInterface.Schema.BMW {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"MSR-ISSUE")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"MSR-ISSUE"})]
    public sealed class ASAM_ISSUE_V3_0_1_proposed : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""qualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:complexType name=""TEAM-MEMBER-REFType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attribute fixed=""TEAM-MEMBER"" name=""F-ID-CLASS"" type=""xs:NMTOKEN"" />
        <xs:attribute fixed=""LINKEND ID-REF"" name=""HYNAMES"" type=""xs:NMTOKENS"" />
        <xs:attribute fixed=""CLINK"" name=""HYTIME"" type=""xs:NMTOKEN"" />
        <xs:attribute name=""ID-REF"" type=""xs:string"" />
        <xs:attribute name=""S"" type=""xs:string"" />
        <xs:attribute name=""SI"" type=""xs:string"" />
        <xs:attribute name=""T"" type=""xs:string"" />
        <xs:attribute name=""VIEW"" type=""xs:string"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""stringBaseAttrListType"">
    <xs:simpleContent>
      <xs:extension base=""xs:string"">
        <xs:attribute name=""S"" type=""xs:string"" />
        <xs:attribute name=""SI"" type=""xs:string"" />
        <xs:attribute name=""T"" type=""xs:string"" />
        <xs:attribute name=""VIEW"" type=""xs:string"" />
      </xs:extension>
    </xs:simpleContent>
  </xs:complexType>
  <xs:complexType name=""XDOCType"">
    <xs:sequence>
      <xs:element name=""LONG-NAME-1"" type=""xs:string"" />
      <xs:element name=""URL"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""NUMBER"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""STATE-1"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""IssueStateType"">
    <xs:sequence>
      <xs:element name=""DATE"" type=""xs:string"" />
      <xs:element name=""TEAM-MEMBER-REF"" type=""TEAM-MEMBER-REFType"" />
      <xs:element name=""ISSUE-STATE"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ENGINEERING-OBJECTType"">
    <xs:sequence>
      <xs:element name=""SHORT-LABEL"" type=""xs:string"" />
      <xs:element name=""CATEGORY"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""DOMAIN"" type=""xs:string"" />
      <xs:element minOccurs=""0"" name=""REVISION-LABEL"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ENGINEERING-OBJECTSType"">
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" name=""ENGINEERING-OBJECT"" type=""ENGINEERING-OBJECTType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ISSUE-RELATED-DOCUMENTType"">
    <xs:sequence>
      <xs:element name=""XDOC"" type=""XDOCType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ISSUE-RELATED-DOCUMENTSType"">
    <xs:sequence>
      <xs:element maxOccurs=""unbounded"" name=""ISSUE-RELATED-DOCUMENT"" type=""ISSUE-RELATED-DOCUMENTType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""MSR-ISSUE"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""SHORT-NAME"" type=""stringBaseAttrListType"" />
        <xs:element name=""CATEGORY"" type=""xs:string"">
          <xs:annotation>
            <xs:documentation>The category is used to distinguish different use cases: e.g. 'atomic issues', 'multiple_issues',  'effort indication' for several issues</xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element name=""COMPANIES"">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs=""unbounded"" name=""COMPANY"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""LONG-NAME"" type=""xs:string"" />
                    <xs:element name=""SHORT-NAME"" type=""stringBaseAttrListType"" />
                    <xs:element minOccurs=""0"" name=""TEAM-MEMBERS"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element maxOccurs=""unbounded"" name=""TEAM-MEMBER"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""LONG-NAME"" type=""xs:string"" />
                                <xs:element name=""SHORT-NAME"" type=""stringBaseAttrListType"" />
                                <xs:element name=""DEPARTMENT"" type=""xs:string"" />
                                <xs:element name=""PHONE"" type=""xs:string"" />
                                <xs:element minOccurs=""0"" name=""FAX"" type=""xs:string"" />
                                <xs:element name=""EMAIL"" type=""stringBaseAttrListType"" />
                              </xs:sequence>
                              <xs:attribute name=""ID"" type=""xs:ID"" use=""required"" />
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                  <xs:attribute name=""ROLE"" type=""xs:string"" use=""optional"" />
                  <xs:attribute name=""ID"" type=""xs:ID"" />
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""ADMIN-DATA"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""DOC-REVISIONS"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""DOC-REVISION"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""TEAM-MEMBER-REF"" type=""TEAM-MEMBER-REFType"" />
                          <xs:element name=""DATE"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""ISSUES"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ISSUE"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""LONG-NAME"" type=""xs:string"" />
                    <xs:element name=""SHORT-NAME"" type=""stringBaseAttrListType"" />
                    <xs:element name=""CATEGORY"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ISSUE-DESC"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element maxOccurs=""unbounded"" name=""P"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""COMPANY-ISSUE-INFOS"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element maxOccurs=""unbounded"" name=""COMPANY-ISSUE-INFO"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""COMPANY-REF"" type=""xs:string"" />
                                <xs:element name=""ISSUE-ID"" type=""xs:string"" />
                                <xs:element minOccurs=""0"" name=""TEAM-MEMBER-REF"" type=""TEAM-MEMBER-REFType"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""ISSUE-PLANNING-INFOS"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""ISSUE-CURRENT-STATE"" type=""IssueStateType"" />
                          <xs:element minOccurs=""0"" name=""ISSUE-PRIORITY"" type=""xs:string"">
                            <xs:annotation>
                              <xs:documentation>Changed: New Element</xs:documentation>
                            </xs:annotation>
                          </xs:element>
                          <xs:element minOccurs=""0"" name=""ISSUE-SEVERITY"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""DELIVERY-MILESTONES"">
                            <xs:annotation>
                              <xs:documentation>Changed: Unbounded</xs:documentation>
                            </xs:annotation>
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element maxOccurs=""unbounded"" name=""DELIVERY-MILESTONE"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""ISSUE-RELATED-DOCUMENTS"" type=""ISSUE-RELATED-DOCUMENTSType"" />
                    <xs:element name=""ISSUE-ENVIRONMENT"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""ENGINEERING-OBJECTS"" type=""ENGINEERING-OBJECTSType"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""RELATED-ISSUES"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element maxOccurs=""unbounded"" name=""RELATED-ISSUE"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" name=""ISSUE-RELATION"" type=""xs:string"" />
                                <xs:element name=""ISSUE-REF"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""ISSUE-SOLUTIONS"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element maxOccurs=""unbounded"" name=""ISSUE-SOLUTION"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""CATEGORY"" type=""xs:string"" />
                                <xs:element minOccurs=""0"" name=""ISSUE-SOLUTION-DESC"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element maxOccurs=""unbounded"" name=""P"" type=""xs:string"" />
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                                <xs:element minOccurs=""0"" name=""ISSUE-RELATED-DOCUMENTS"" type=""ISSUE-RELATED-DOCUMENTSType"" />
                                <xs:element minOccurs=""0"" name=""ENGINEERING-OBJECTS"" type=""ENGINEERING-OBJECTSType"" />
                                <xs:element minOccurs=""0"" name=""ISSUE-COSTS"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""COST-AMOUNT"" type=""xs:string"" />
                                      <xs:element name=""COST-CURRENCY"" type=""xs:string"" />
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                                <xs:element minOccurs=""0"" name=""ISSUE-EFFORT"">
                                  <xs:annotation>
                                    <xs:documentation>Changed: New Element</xs:documentation>
                                  </xs:annotation>
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""EFFORT-AMOUNT"" type=""xs:string"">
                                        <xs:annotation>
                                          <xs:documentation>Positive decimal figures</xs:documentation>
                                        </xs:annotation>
                                      </xs:element>
                                      <xs:element name=""EFFORT-UNIT"" type=""xs:string"" />
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""ANNOTATIONS"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element maxOccurs=""unbounded"" name=""ANNOTATION"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""TEAM-MEMBER-REF"" type=""TEAM-MEMBER-REFType"" />
                                <xs:element minOccurs=""0"" name=""DATE"" type=""xs:string"" />
                                <xs:element name=""ANNOTATION-TEXT"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""P"" type=""xs:string"" />
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                                <xs:element minOccurs=""0"" name=""ANNOTATION-RELATED-DOCUMENTS"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element maxOccurs=""unbounded"" name=""ANNOTATION-RELATED-DOCUMENT"">
                                        <xs:complexType>
                                          <xs:sequence>
                                            <xs:element name=""XDOC"" type=""XDOCType"" />
                                          </xs:sequence>
                                        </xs:complexType>
                                      </xs:element>
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""ISSUE-HISTORY-STATES"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element maxOccurs=""unbounded"" name=""ISSUE-HISTORY-STATE"" type=""IssueStateType"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
      <xs:attribute name=""F-CM-TOOL-ID"" type=""xs:string"" use=""optional"" />
      <xs:attribute default=""2006-04-24"" name=""F-XSD-BUILD"" type=""xs:string"" />
      <xs:attribute default=""3.0.0"" name=""F-XSD-VERSION"" type=""xs:string"" />
      <xs:attribute default=""-//ASAM//XSD ISSUE V3.0.0:BMW/SV//EN&quot;"" name=""F-PUBID"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ASAM_ISSUE_V3_0_1_proposed() {
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
