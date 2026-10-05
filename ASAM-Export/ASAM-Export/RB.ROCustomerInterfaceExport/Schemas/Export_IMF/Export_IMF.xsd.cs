namespace RB.ROCustomerInterfaceExport.Schemas.Export_IMF {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF",@"EXPORT_IMF")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"EXPORT_IMF"})]
    public sealed class Export_IMF : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""EXPORT_IMF"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""ISSUE"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""CommercialQuotationReq"" type=""xs:string"" />
              <xs:element name=""ExternalComment"" type=""xs:string"" />
              <xs:element name=""ExternalCommentAuthor"" type=""xs:string"" />
              <xs:element name=""ExternalConversation"" type=""xs:string"" />
              <xs:element name=""ExternalExchangedAttach"" type=""xs:string"" />
              <xs:element name=""ExternalHistory"" type=""xs:string"" />
              <xs:element name=""ExternalLastExportedDate"" type=""xs:string"" />
              <xs:element name=""ExternalNextState"" type=""xs:string"" />
              <xs:element name=""ExternalState_Parallel1"" type=""xs:string"" />
              <xs:element name=""ExternalState_Parallel2"" type=""xs:string"" />
              <xs:element name=""ExternalUpdateVersion"" type=""xs:string"" />
            </xs:sequence>
            <xs:attribute name=""dbid"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
        <xs:element name=""ISSUERELEASEMAP"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ExternalComment"" type=""xs:string"" />
              <xs:element name=""ExternalCommentAuthor"" type=""xs:string"" />
              <xs:element name=""ExternalConversation"" type=""xs:string"" />
              <xs:element name=""ExternalLastExportedDate"" type=""xs:string"" />
              <xs:element name=""ExternalNextState"" type=""xs:string"" />
              <xs:element name=""ExternalState_Parallel1"" type=""xs:string"" />
              <xs:element name=""ExternalTags"" type=""xs:string"" />
              <xs:element name=""ExternalHistory"" type=""xs:string"" />
              <xs:element name=""ExternalUpdateVersion"" type=""xs:string"" />
              <xs:element name=""Tags"" type=""xs:string"" />
            </xs:sequence>
            <xs:attribute name=""dbid"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
        <xs:element name=""COMMERCIAL"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""CommercialComment"" type=""xs:string"" />
              <xs:element name=""CommercialConversation"" type=""xs:string"" />
            </xs:sequence>
            <xs:attribute name=""dbid"" type=""xs:string"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Export_IMF() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "EXPORT_IMF";
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
