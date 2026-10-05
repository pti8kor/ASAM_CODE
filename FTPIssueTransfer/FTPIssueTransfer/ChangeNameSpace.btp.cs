namespace FTPIssueTransfer
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class ChangeNameSpace : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s>        <Component>          <Name>ChangeMessagePipeline.ChangeMessage,ChangeMessagePipeline, Vers"+
"ion=1.0.5.1, Culture=neutral, PublicKeyToken=84a9d77fe8620687</Name>          <ComponentName>ChangeM"+
"essagePipelineComponent</ComponentName>          <Description>Pipeline component used to change name"+
"space of message</Description>          <Version>1.0.0.4</Version>          <Properties>            "+
"<Property Name=\"NewNameSpace\">              <Value xsi:type=\"xsd:string\">http://FTPFileShift.FTPFile"+
"Information</Value>            </Property>          </Properties>          <CachedDisplayName>Change"+
"MessagePipelineComponent</CachedDisplayName>          <CachedIsManaged>true</CachedIsManaged>       "+
" </Component>      </Components>    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _l"+
"ocID=\"2\" Name=\"Disassemble\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"FirstMatch\" stageId=\"9d0e4105-4"+
"cce-4536-83fa-4a5040674ad6\" />      <Components />    </Stage>    <Stage>      <PolicyFileStage _loc"+
"AttrData=\"Name\" _locID=\"3\" Name=\"Validate\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d"+
"0e410d-4cce-4536-83fa-4a5040674ad6\" />      <Components />    </Stage>    <Stage>      <PolicyFileSt"+
"age _locAttrData=\"Name\" _locID=\"4\" Name=\"ResolveParty\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\""+
" stageId=\"9d0e410e-4cce-4536-83fa-4a5040674ad6\" />      <Components />    </Stage>  </Stages></Docum"+
"ent>";
        
        private const string _versionDependentGuid = "b2441c53-f0a7-4739-baec-eaeba6cc0593";
        
        public ChangeNameSpace()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4103-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("ChangeMessagePipeline.ChangeMessage,ChangeMessagePipeline, Version=1.0.5.1, Culture=neutral, PublicKeyToken=84a9d77fe8620687");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"NewNameSpace\"> "+
"     <Value xsi:type=\"xsd:string\">http://FTPFileShift.FTPFileInformation</Value>    </Property>  </P"+
"roperties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
        }
        
        public override string XmlContent
        {
            get
            {
                return _strPipeline;
            }
        }
        
        public override System.Guid VersionDependentGuid
        {
            get
            {
                return new System.Guid(_versionDependentGuid);
            }
        }
    }
}
