using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;



namespace RB.ROCustomerIntefaceLibrary
{
    public struct OSLCComplexType
    {
        public const string MAINRECORD = "MAINRECORD";
        public const string ALLRECORDS = "ALLRECORDS";
    }

    public class OSLC_QueryResult:IQueryResult
    {
        RO_OSLC_DataInterface  m_oDataInterface = null;
        
        public XNamespace nsoslc = XNamespace.Get("http://open-services.net/xmlns/cm/1.0/"); //OSLC XML Namespace
        XDocument xDoc = null;
        int iRecordCount = 0;
        List<int> l_ReturnedDbids = new List<int>();


        Dictionary<string, string> m_oFieldValues 
            = new Dictionary<string, string>();

        public OSLC_QueryResult()
        {
            QuerySuccess = true;
        }

        public RO_OSLC_DataInterface DataInterface
        {
            get
            {
                return m_oDataInterface; //REUBK-1411
            }
            set
            {
                m_oDataInterface = value;
            }
        }

        public Dictionary<string, string> FieldValues
        {
            get
            {
                return m_oFieldValues;
            }
            set
            {
                m_oFieldValues = value;
            }
        }

        public object GetRaw()
        {
            return xDoc;
        }

        public void SetRaw(object oRaw)
        {
            xDoc = oRaw as XDocument;

            foreach (XElement xProperty in xDoc.Root.Elements())
            {
                string sAttr = xProperty.Name.ToString();
                sAttr = sAttr.Replace("{","");
                sAttr = sAttr.Replace("}","");
                sAttr = sAttr.Replace("http://www.ibm.com/xmlns/prod/rational/clearquest/1.0/", "");

                try
                {
                    //it is possible that this element has an attribute rdf:resource
                    //then it is a reference field
                    string sFieldValue = xProperty.Value.ToString();                   

                    try
                    {
                        if (string.IsNullOrEmpty(sFieldValue))
                        {
                            sFieldValue = xProperty.Attributes().First().Value;
                        }
                    }catch {}


                    if(!m_oFieldValues.ContainsKey(sAttr))
                    {
                        
                        m_oFieldValues.Add(sAttr, sFieldValue);

                    }
                   
                }
                catch (Exception ex)
                {
                    //Utilities.objLogger.LogException(ex);
                }
            }
            
            iRecordCount = GetRecordCount(xDoc);

            QuerySuccess = true;
        }
        
        
        public string GetValue(string sKey)
        {
            string[] sKeys = sKey.Split('.');
            IQueryResult l_oResult;

            if (sKeys.Length > 1)
            {
                string sCurrentKey = sKeys[0];
                string sLink = m_oFieldValues
                               .Where(n => n.Key.ToUpper() == sCurrentKey.ToUpper())
                               .Select(n => n.Value).Single();
                string sFurtherkey = string.Empty;

                for (int i = 1; i < sKeys.Length; i++)
                {
                    if (sFurtherkey == string.Empty)
                    {
                        sFurtherkey = sKeys[i];
                    }
                    else
                    {
                        sFurtherkey = sFurtherkey + "." + sKeys[i];
                    }
                }

                try
                {
                    l_oResult = m_oDataInterface.QueryRecord(sLink);
                }
                catch (Exception e)  //REUBK-1740 xprot log field should be udpated with exception msg in case of any excep in oslc query of linked record
                {
                    //Utilities.objLogger.LogException(e, "OSLC Query Exception in GetValue()"); 
                    throw;
                }

                return l_oResult.GetValue(sFurtherkey);
            }
            else
            {
                return m_oFieldValues
                       .Where(n => n.Key.ToUpper() == sKey.ToUpper())
                       .Select(n => n.Value).Single();

                //return HttpUtility.HtmlDecode(m_oFieldValues.Where(n => n.Key.ToUpper() == sKey.ToUpper()).Select(n => n.Value).Single());

            }
        }

       
        private int GetRecordCount(XDocument xResponseFromCQ)
        {
            try
            {
                if (xResponseFromCQ != null)
                {
                    XElement xLink = xResponseFromCQ.Descendants(nsoslc + "totalCount").Single();

                    return Convert.ToInt16(xLink.Value.ToString());
                }
                else
                {
                    throw new Exception("Parameter type not Xdoc to get count");
                }
            }
            catch { }
            return 0;
        }

        public int RecordCount
        {
            get
            {
                return iRecordCount;
            }
            set
            {
                iRecordCount = value;
            }
        }

        public bool QuerySuccess
        {
            get;
            set;
        }
        public List<int> ReturnedDbids
        {
            get
            {
                return l_ReturnedDbids;
            }
            set
            {
                l_ReturnedDbids = value;
            }
        }
    }
}
