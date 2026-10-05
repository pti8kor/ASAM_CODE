namespace FTPGetNames_Project {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk_Web_Service_Project.ReceiveSchema",@"ReceiveText")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ReceiveText"})]
    public sealed class Receive : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk_Web_Service_Project.ReceiveSchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BizTalk_Web_Service_Project.ReceiveSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ReceiveText"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"" />
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Receive() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ReceiveText";
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
