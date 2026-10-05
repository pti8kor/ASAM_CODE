namespace FTPGetNames_Project {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://FTPGetNames_Project.FTPGetNamesSchema",@"FTPRequest")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "InterfaceName", XPath = @"/*[local-name()='FTPRequest' and namespace-uri()='http://FTPGetNames_Project.FTPGetNamesSchema']/*[local-name()='InterfaceName' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "FTPFileNames", XPath = @"/*[local-name()='FTPRequest' and namespace-uri()='http://FTPGetNames_Project.FTPGetNamesSchema']/*[local-name()='FTPFileNames' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "RQ1System", XPath = @"/*[local-name()='FTPRequest' and namespace-uri()='http://FTPGetNames_Project.FTPGetNamesSchema']/*[local-name()='RQ1System' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "XProtID", XPath = @"/*[local-name()='FTPRequest' and namespace-uri()='http://FTPGetNames_Project.FTPGetNamesSchema']/*[local-name()='XProtID' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"FTPRequest"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"FTPGetNames_Project.PropertySchema.PropertySchema", typeof(global::FTPGetNames_Project.PropertySchema.PropertySchema))]
    public sealed class FTPGetNamesSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://FTPGetNames_Project.FTPGetNamesSchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://FTPGetNames_Project.PropertySchema"" targetNamespace=""http://FTPGetNames_Project.FTPGetNamesSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://FTPGetNames_Project.PropertySchema"" location=""FTPGetNames_Project.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""FTPRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='FTPRequest' and namespace-uri()='http://FTPGetNames_Project.FTPGetNamesSchema']/*[local-name()='InterfaceName' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='FTPRequest' and namespace-uri()='http://FTPGetNames_Project.FTPGetNamesSchema']/*[local-name()='FTPFileNames' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='FTPRequest' and namespace-uri()='http://FTPGetNames_Project.FTPGetNamesSchema']/*[local-name()='RQ1System' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='FTPRequest' and namespace-uri()='http://FTPGetNames_Project.FTPGetNamesSchema']/*[local-name()='XProtID' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RQ1System"" type=""xs:string"" />
        <xs:element name=""InterfaceName"" type=""xs:string"" />
        <xs:element name=""XProtID"" type=""xs:string"" />
        <xs:element name=""FTPFileNames"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public FTPGetNamesSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "FTPRequest";
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
