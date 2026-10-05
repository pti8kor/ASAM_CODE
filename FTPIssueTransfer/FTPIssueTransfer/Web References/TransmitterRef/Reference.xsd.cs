namespace FTPIssueTransfer.TransmitterRef {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"transmitterRequest", @"transmitterResponse"})]
    public sealed class Reference : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://www.bosch.com/edexas/asam/transmitter/services"" elementFormDefault=""qualified"" targetNamespace=""http://www.bosch.com/edexas/asam/transmitter/services"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""transmitterRequest"" nillable=""true"" type=""tns:transmitterRequest"" />
  <xs:complexType name=""transmitterRequest"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" form=""unqualified"" name=""transferBinary"" type=""xs:base64Binary"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" form=""unqualified"" name=""transferData"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" form=""unqualified"" name=""transferFile"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" form=""unqualified"" name=""transferType"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""transmitterResponse"" nillable=""true"" type=""tns:transmitterResponse"" />
  <xs:complexType name=""transmitterResponse"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""1"" form=""unqualified"" name=""failure"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" form=""unqualified"" name=""result"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
</xs:schema>";
        
        public Reference() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "transmitterRequest";
                _RootElements[1] = "transmitterResponse";
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
        
        [Schema(@"http://www.bosch.com/edexas/asam/transmitter/services",@"transmitterRequest")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"transmitterRequest"})]
        public sealed class transmitterRequest : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public transmitterRequest() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "transmitterRequest";
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
        
        [Schema(@"http://www.bosch.com/edexas/asam/transmitter/services",@"transmitterResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"transmitterResponse"})]
        public sealed class transmitterResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public transmitterResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "transmitterResponse";
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
}
