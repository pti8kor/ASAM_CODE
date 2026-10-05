namespace RB.ROCustomerInterface {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"InternalErrorFault", @"vwId2ttnResponse", @"vwId2ttnTestResponse", @"vwId2ttn", @"KTNLIST"})]
    public sealed class vwid2ttn_vwid2ttn_webservices_his_bosch_com : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xsd:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://v2.vwid2ttn.webservices.his.bosch.com/"" targetNamespace=""http://v2.vwid2ttn.webservices.his.bosch.com/"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <xsd:complexType name=""vwAsamMappingEntry"">
    <xsd:sequence>
      <xsd:element minOccurs=""0"" name=""RBTTN"" type=""xsd:string"" />
      <xsd:element minOccurs=""0"" name=""RBTYPE"" type=""xsd:string"" />
      <xsd:element minOccurs=""0"" name=""RBSGBZ"" type=""xsd:string"" />
    </xsd:sequence>
  </xsd:complexType>
  <xsd:complexType name=""vwAsamMappingInput"">
    <xsd:sequence>
      <xsd:element minOccurs=""0"" maxOccurs=""unbounded"" name=""KTNARG"" type=""ns0:vwAsamMappingInputKtn"" />
    </xsd:sequence>
  </xsd:complexType>
  <xsd:complexType name=""InternalErrorFault"">
    <xsd:sequence>
      <xsd:element minOccurs=""0"" name=""message"" type=""xsd:string"" />
    </xsd:sequence>
  </xsd:complexType>
  <xsd:complexType name=""vwAsamMappingInputKtn"">
    <xsd:sequence>
      <xsd:element minOccurs=""0"" name=""KTN"" type=""xsd:string"" />
    </xsd:sequence>
  </xsd:complexType>
  <xsd:complexType name=""vwAsamMappingOutputKtnList"">
    <xsd:sequence>
      <xsd:element minOccurs=""0"" maxOccurs=""unbounded"" name=""VwAsamMappingOutputKtn"" type=""ns0:vwAsamMappingOutputKtn"" />
    </xsd:sequence>
  </xsd:complexType>
  <xsd:complexType name=""vwAsamMappingOutputKtn"">
    <xsd:sequence>
      <xsd:element minOccurs=""0"" name=""KTN"" type=""xsd:string"" />
      <xsd:element minOccurs=""0"" maxOccurs=""unbounded"" name=""mapping"" type=""ns0:vwAsamMappingEntry"" />
      <xsd:element minOccurs=""0"" name=""resultStatus"" type=""xsd:string"" />
      <xsd:element minOccurs=""0"" name=""resultMessage"" type=""xsd:string"" />
    </xsd:sequence>
  </xsd:complexType>
  <xsd:element name=""InternalErrorFault"" type=""ns0:InternalErrorFault"" />
  <xsd:element name=""vwId2ttnResponse"" type=""ns0:vwAsamMappingOutputKtnList"" />
  <xsd:element name=""vwId2ttnTestResponse"" type=""ns0:vwAsamMappingOutputKtnList"" />
  <xsd:element name=""vwId2ttn"" type=""ns0:vwAsamMappingInput"" />
  <xsd:element name=""KTNLIST"" type=""ns0:vwAsamMappingInput"" />
</xsd:schema>";
        
        public vwid2ttn_vwid2ttn_webservices_his_bosch_com() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [5];
                _RootElements[0] = "InternalErrorFault";
                _RootElements[1] = "vwId2ttnResponse";
                _RootElements[2] = "vwId2ttnTestResponse";
                _RootElements[3] = "vwId2ttn";
                _RootElements[4] = "KTNLIST";
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
        
        [Schema(@"http://v2.vwid2ttn.webservices.his.bosch.com/",@"InternalErrorFault")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InternalErrorFault"})]
        public sealed class InternalErrorFault : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InternalErrorFault() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InternalErrorFault";
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
        
        [Schema(@"http://v2.vwid2ttn.webservices.his.bosch.com/",@"vwId2ttnResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"vwId2ttnResponse"})]
        public sealed class vwId2ttnResponse : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public vwId2ttnResponse() {
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
        
        [Schema(@"http://v2.vwid2ttn.webservices.his.bosch.com/",@"vwId2ttnTestResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"vwId2ttnTestResponse"})]
        public sealed class vwId2ttnTestResponse : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public vwId2ttnTestResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "vwId2ttnTestResponse";
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
        
        [Schema(@"http://v2.vwid2ttn.webservices.his.bosch.com/",@"vwId2ttn")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"vwId2ttn"})]
        public sealed class vwId2ttn : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public vwId2ttn() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "vwId2ttn";
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
        
        [Schema(@"http://v2.vwid2ttn.webservices.his.bosch.com/",@"KTNLIST")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"KTNLIST"})]
        public sealed class KTNLIST : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public KTNLIST() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "KTNLIST";
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
