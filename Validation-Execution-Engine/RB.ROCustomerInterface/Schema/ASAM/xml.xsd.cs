namespace RB.ROCustomerInterface.Schema.ASAM {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    public sealed class xml : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://www.w3.org/XML/1998/namespace"" xml:lang=""en"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:documentation>This schema defines attributes and an attribute group
        suitable for use by
        schemas wishing to allow xml:lang or xml:space attributes
        on elements they define.

        To enable this, such a schema must import this schema
        for the XML namespace, e.g. as follows:
        &lt;schema . . .&gt;
         . . .
         &lt;import namespace=""http://www.w3.org/XML/1998/namespace""
                    schemaLocation=""http://www.w3.org/2001/03/xml.xsd""/&gt;

        Subsequently, qualified reference to either of the attributes
        or the group defined below will have the desired effect, e.g.

        &lt;type . . .&gt;
         . . .
         &lt;attributeGroup ref=""xml:specialAttrs""/&gt;
 
         will define a type which will schema-validate a instance
         element with both xml:space and xml:lang attribute</xs:documentation>
  </xs:annotation>
  <xs:attribute name=""lang"" type=""xs:language"">
    <xs:annotation>
      <xs:documentation>In due course, we should install the relevant ISO 2- and 3-letter
         codes as the enumerated possible values . . .</xs:documentation>
    </xs:annotation>
  </xs:attribute>
  <xs:attribute default=""preserve"" name=""space"">
    <xs:simpleType>
      <xs:restriction base=""xs:NCName"">
        <xs:enumeration value=""default"" />
        <xs:enumeration value=""preserve"" />
      </xs:restriction>
    </xs:simpleType>
  </xs:attribute>
  <xs:attributeGroup name=""specialAttrs"">
    <xs:attribute ref=""xml:lang"" />
    <xs:attribute ref=""xml:space"" />
  </xs:attributeGroup>
</xs:schema>";
        
        public xml() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [0];
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
