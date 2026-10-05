using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using Microsoft.BizTalk.Message.Interop;
using Microsoft.BizTalk.Component.Interop;

namespace ChangeMessagePipeline
{
      [Serializable]

    [ComponentCategory(CategoryTypes.CATID_PipelineComponent)]
    [ComponentCategory(CategoryTypes.CATID_Decoder )]
    [System.Runtime.InteropServices.Guid("0244A3C8-EB7B-4D41-AC42-7618094DE60F")]	

    
    public class ChangeMessage : 
                                        IBaseComponent, 
                                        IComponentUI,
                                        IComponent,
                                        IPersistPropertyBag 
    {

        #region IBaseComponent Members

        public string Description
        {
            get
            {
                return "Pipeline component used to change namespace of message";
            }
        }
        public string Name
        {
            get
            {
                return "ChangeMessagePipelineComponent";
            }
        }
        public string Version
        {
            get
            {
                return "1.0.0.4";
            }
        }
        #endregion

        #region IComponentUI Members

        public IntPtr Icon
        {
            get
            {
                return new System.IntPtr();
            }
        }



        public System.Collections.IEnumerator Validate(object projectSystem)
        {
            return null;
        }

        #endregion

        #region IPersistPropertyBag Members

        private string _NewNameSpace;
        public string NewNameSpace
        {
            get { return _NewNameSpace; }
            set { _NewNameSpace = value; }
        }

        public void GetClassID(out Guid classID)
        {
            classID = new Guid("0244A3C8-EB7B-4D41-AC42-7618094DE60F");
        }

        public void InitNew()
        {

        }

        public void Load(IPropertyBag propertyBag, int errorLog)
        {
            
            string val = (string)ReadPropertyBag(propertyBag, "NewNameSpace");

            /*
            object val = null;
            try
            {
                propertyBag.Read("NewNameSpace", out val, 0);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error reading propertybag: " + ex.Message);
            }
            */

            if (val != null)
                _NewNameSpace = (string)val;
            else
                _NewNameSpace = "http://AnonymusURL";
            
        }

        public void Save(IPropertyBag propertyBag, bool clearDirty, bool saveAllProperties)
        {
            object val = (object)_NewNameSpace;
            propertyBag.Write("NewNameSpace", ref val);
        }
        
        private static object ReadPropertyBag(IPropertyBag propertyBag, string propertyName)
        {

            object val = null;

            try
            {
                propertyBag.Read(propertyName, out val, 0);
            }


            catch (ArgumentException)
            {
                return val;
            }


            catch (Exception ex)
            {
                throw  new ApplicationException("Error reading propertybag: " + ex.Message);
            }

            return val;
        }

        private static void WritePropertyBag(IPropertyBag propertyBag, string propertyName, object val)
        {

            try
            {
                propertyBag.Write(propertyName, ref val);
            }

            catch (Exception ex)
            {
                throw new ApplicationException("Error Writing propertybag: " + ex.Message);
            }

        }

        #endregion

        #region IComponent Members

        public IBaseMessage Execute(IPipelineContext pContext, IBaseMessage pInMsg)
        {
            IBaseMessagePart bodyPart = pInMsg.BodyPart;
            StringBuilder outputMessageText = null;
            string systemPropertiesNamespace = @"http://schemas.microsoft.com/BizTalk/2003/system-properties";
            string messageType = "";

            if (bodyPart != null)
            {
                Stream originalStream = bodyPart.GetOriginalDataStream();
                if (originalStream != null)
                {

                    XmlDocument xdoc = new XmlDocument();
                    xdoc.Load(originalStream);

                    XmlDeclaration xmldecl;
                    xmldecl = xdoc.CreateXmlDeclaration("1.0", "utf-8", "no");                    
                    XmlElement root = xdoc.DocumentElement;

                    messageType = this.NewNameSpace + "#" + root.LocalName;

                    outputMessageText = new StringBuilder();
                    outputMessageText.Append("<" + root.Name + "  xmlns:ns0='" + this.NewNameSpace + "'>");
                    outputMessageText.Append(root.InnerXml);
                    outputMessageText.Append("</" + root.Name + ">");

                    //byte[] outBytes = System.Text.Encoding.ASCII.GetBytes(outputMessageText.ToString());
                    byte[] outBytes = System.Text.Encoding.UTF8.GetBytes(outputMessageText.ToString());

                    MemoryStream memStream = new MemoryStream();
                    memStream.Write(outBytes, 0, outBytes.Length);
                    memStream.Position = 0;

                    bodyPart.Data = memStream;
                    pContext.ResourceTracker.AddResource(memStream);
                }
            }
            pInMsg.Context.Promote("MessageType", systemPropertiesNamespace, messageType);
            return pInMsg;
        }

        #endregion
 
    }
}
