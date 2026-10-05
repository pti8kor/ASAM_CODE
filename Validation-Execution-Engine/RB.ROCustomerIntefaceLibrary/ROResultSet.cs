using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace RB.ROCustomerIntefaceLibrary
{
    public class ROResultSet
    {
        XDocument m_oResultset = null;
        private const string ROOT = "RESULTSET";
        private const string ATTRSTATUS = "STATUS";
        private const string UPDATED = "UPDATED";
        private const string NEW = "NEW";
        
        public ROResultSet()
        {
            m_oResultset = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));
            m_oResultset.Add(new XElement(ROOT));
        }

        public void AddNodeForUpdate(XElement xNode)
        {
            xNode.SetAttributeValue(ATTRSTATUS, UPDATED);
            m_oResultset.Root.Add(xNode);
        }
        public void AddNodeForAddtion(XElement xNode)
        {
            xNode.SetAttributeValue(ATTRSTATUS, NEW);
            m_oResultset.Root.Add(xNode);
        }
        public void MarkFieldForUpdation(string sFieldName, XElement xNode)
        {
            xNode.Element(sFieldName).SetAttributeValue(ATTRSTATUS, UPDATED);
           
        }

        public void AddElementToNode(string sFieldName, XElement xNode, string sNewValue)
        {
            xNode.SetElementValue(sFieldName, sNewValue);

        }

        public XDocument GetXMLDocument()
        {
            return m_oResultset;
        }

        public void SaveXML(string sFileName)
        {
            m_oResultset.Save(sFileName);
        }
    }
}
