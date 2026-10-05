namespace RB.ROCustomerInterface.Schema {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://HISMapperOUT.Schema",@"vwId2ttnResponse")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"vwId2ttnResponse"})]
    public sealed class HISMapperOUT : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://HISMapperOUT.Schema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://HISMapperOUT.Schema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""vwId2ttnResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""VwAsamMappingOutputKtn"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""KTN"" type=""xs:string"" />
              <xs:element maxOccurs=""unbounded"" name=""mapping"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""RBTTN"" type=""xs:string"" />
                    <xs:element name=""RBTYPE"" type=""xs:string"" />
                    <xs:element name=""RBSGBZ"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""resultStatus"" type=""xs:string"" />
              <xs:element name=""resultMessage"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public HISMapperOUT() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "vwId2ttnResponse";
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
