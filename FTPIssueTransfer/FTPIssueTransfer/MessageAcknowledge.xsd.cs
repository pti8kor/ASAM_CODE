namespace FTPIssueTransfer {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"MESSAGE-ACKNOWLEDGE", @"TRANSACTION-ID", @"ERROR-CODES", @"ERROR-CODE"})]
    public sealed class MessageAcknowledge : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://www.asam.net/schemas/issue/messageacknowledgement"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://www.asam.net/schemas/issue/messageacknowledgement"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""MESSAGE-ACKNOWLEDGE"">
    <xs:annotation>
      <xs:documentation>Message Acknowledgment</xs:documentation>
      <xs:appinfo>
        <recordInfo rootTypeName=""MESSAGE_ACKNOWLEDGE"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""TRANSACTION-ID"">
          <xs:annotation>
            <xs:documentation>Unique transaction ID for successfully acknowledged messages</xs:documentation>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" ref=""ERROR-CODES"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TRANSACTION-ID"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Unique transaction ID sent by an exchange partner</xs:documentation>
      <xs:appinfo>
        <fieldInfo rootTypeName=""TRANSACTION_ID"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""ERROR-CODES"">
    <xs:annotation>
      <xs:documentation>Error reference containing one or more error codes details of an error for unsuccessfully acknowledged messages</xs:documentation>
      <xs:appinfo>
        <recordInfo rootTypeName=""ERROR_CODES"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence maxOccurs=""unbounded"">
        <xs:element ref=""ERROR-CODE"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ERROR-CODE"" type=""xs:string"">
    <xs:annotation>
      <xs:documentation>Error code</xs:documentation>
      <xs:appinfo>
        <fieldInfo rootTypeName=""ERROR_CODE"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public MessageAcknowledge() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [4];
                _RootElements[0] = "MESSAGE-ACKNOWLEDGE";
                _RootElements[1] = "TRANSACTION-ID";
                _RootElements[2] = "ERROR-CODES";
                _RootElements[3] = "ERROR-CODE";
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
        
        [Schema(@"http://www.asam.net/schemas/issue/messageacknowledgement",@"MESSAGE-ACKNOWLEDGE")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"MESSAGE-ACKNOWLEDGE"})]
        public sealed class MESSAGE_ACKNOWLEDGE : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public MESSAGE_ACKNOWLEDGE() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "MESSAGE-ACKNOWLEDGE";
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
        
        [Schema(@"http://www.asam.net/schemas/issue/messageacknowledgement",@"TRANSACTION-ID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TRANSACTION-ID"})]
        public sealed class TRANSACTION_ID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TRANSACTION_ID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TRANSACTION-ID";
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
        
        [Schema(@"http://www.asam.net/schemas/issue/messageacknowledgement",@"ERROR-CODES")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ERROR-CODES"})]
        public sealed class ERROR_CODES : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ERROR_CODES() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ERROR-CODES";
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
        
        [Schema(@"http://www.asam.net/schemas/issue/messageacknowledgement",@"ERROR-CODE")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ERROR-CODE"})]
        public sealed class ERROR_CODE : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ERROR_CODE() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ERROR-CODE";
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
