using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.XPath;
using System.IO;
using System.Text.RegularExpressions;

namespace RB.ROCustomerIntefaceLibrary
{
    public class Query
    {
        public Dictionary<string, string> OrcParms
        {
            get;
            set;
        }

        public string QueryString
        {
            get;
            set;
        }

        Logger objlogger = null;

        List<string> lstIMF = new List<string>();
        List<string> lstRT = new List<string>();
        List<string> lstRO = new List<string>();

        public Query(Dictionary<string, string> p_OrcParms,Logger l_ologger)
        {
            OrcParms = p_OrcParms;
            objlogger = l_ologger;

        }
        public QueryParameters GetQueryparamsForKeys(XElement xContext, XElement xIDRule, IEnumerable<XElement> xoKeys, QueryParameters l_oParameters)
        {
            string sValueToCheck;

            foreach (XElement xoKey in xoKeys)
            {
                string sKeyTocheck = xoKey.Value.ToString();
                try
                {
                    switch (xoKey.Attribute(ConfigurationFileTags.ATTR_SOURCE).Value)
                    {
                        case GlobalConstants.SOURCECONFIG:
                            {
                                sValueToCheck = xIDRule.Element(sKeyTocheck.ToUpper()).Value;
                                break;
                            }
                        case GlobalConstants.SOURCERUNTIME:
                            {
                                sValueToCheck = OrcParms[sKeyTocheck.ToUpper()];
                                break;
                            }
                        default:
                            {
                                IEnumerable<XElement> xValueToCheck = xContext.Elements(sKeyTocheck.ToUpper());
                                sValueToCheck = xValueToCheck.First<XElement>().Value.ToString();
                                break;
                            }
                    }
                }
                catch
                {
                   //Utilities.objLogger.LogInfo("Key not found in IMF file " + sKeyTocheck);
                    throw;
                }

                l_oParameters.Add(sKeyTocheck, sValueToCheck);
            }

            return l_oParameters;
        }

        public string Prepare(XElement xContext,IMFManager p_oIMFManager)
        {

            Condition oCondition = new Condition(null, null, xContext, null, p_oIMFManager, this, OrcParms, false, null, null,objlogger);
            string strQuery = QueryString;
            QueryString = oCondition.DecodeOperandForString(strQuery);  //REUBK-1222          
            return QueryString;
        }


        public string ReplaceString(string sValue, string sToReplace)
        {
            string sToReturn = string.Empty;
           
            if (sValue.Contains(RulesFileTags.ROFIELD))
            {
                sToReturn = sValue.Replace(RulesFileTags.ROFIELD, "");
            }
            else
            {
                sToReturn = sValue.Replace(RulesFileTags.IMFFIELD, "");
            }           

            return sToReturn;
        }


         //method not used:       
        public static string ReplaceValuesInQuery(string sQuery, string skey, string sField, string sValue)
        {
           // Utilities.objLogger.LogInfo("inside ReplaceValuesInQuery");
            string sToReplace = "$" + skey + "." + sField;
            // sQuery = Regex.Replace(sQuery, sToReplace, sValue);
            sQuery = sQuery.Replace(sToReplace, sValue);
           // Utilities.objLogger.LogInfo("return value from ReplaceValuesInQuery" + sQuery);
            return sQuery;
        }

    


    }
}
