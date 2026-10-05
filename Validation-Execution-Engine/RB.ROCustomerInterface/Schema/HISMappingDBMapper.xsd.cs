namespace RB.ROCustomerInterface.Schema {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://RB.ROCustomerInterface.HISMappingDBMapper",@"VWPartnumberMappings")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"VWPartnumberMappings"})]
    public sealed class HISMappingDBMapper : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://RB.ROCustomerInterface.HISMappingDBMapper"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://RB.ROCustomerInterface.HISMappingDBMapper"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""VWPartnumberMappings"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""Mapping"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""CUSTTN"" type=""xs:string"" />
              <xs:element name=""RBTTN"" type=""xs:string"" />
              <xs:element name=""RBRELTYPE"" type=""xs:string"" />
              <xs:element name=""RBSGBEZ"" type=""xs:string"" />
              <xs:element name=""Resultstatus"" type=""xs:string"" />
              <xs:element name=""Resultmessage"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public HISMappingDBMapper() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "VWPartnumberMappings";
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
