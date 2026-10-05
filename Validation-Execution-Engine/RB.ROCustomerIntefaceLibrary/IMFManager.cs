using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.XPath;
using System.IO;
using System.Data;
using System.Text.RegularExpressions;

namespace RB.ROCustomerIntefaceLibrary
{
    public class IMFManager
    {
        public XDocument IssueIMF { get; set; }
        XmlNamespaceManager nsIMFMgr;

        Logger objlogger = null;
        public DataTable AttachmentsTable = new DataTable();
        public IMFManager(XDocument xIssueIntermFile, Logger l_ologger)
        {
            objlogger = l_ologger;

            if (xIssueIntermFile != null)
            {
                IssueIMF = xIssueIntermFile;
                nsIMFMgr = Utilities.GetIMFNameSpace(xIssueIntermFile);
            }
        }

        /// <summary>
        /// Format values -- for tags with <para></para> in IMF file(used during validation)
        /// </summary>
        /// <param name="oField"></param>
        /// <returns></returns>
        private string FormatValues(XElement oField)
        {
            string sFinalValue = string.Empty;

            if (oField.Elements().Count() > 0)
            {
                //Utilities.objLogger.LogInfo("format imf values");
                foreach (XElement oVal in oField.Elements())
                {
                    if (oVal.HasElements)
                    {
                        //recursion
                        sFinalValue = FormatValues(oVal);
                    }
                    else
                    {
                        sFinalValue = sFinalValue + System.Environment.NewLine + oVal.Value;
                    }
                }
            }
            else
            {
                sFinalValue = oField.Value;
            }

            //Utilities.objLogger.LogInfo("return value from FormatValues" + sFinalValue);
            return sFinalValue;
        }


        /// <summary>
        /// Gets the value of field from IMF file
        /// </summary>
        /// <param name="sFieldName"></param>
        /// <param name="sXPath"></param>
        /// <returns></returns>
        public string GetValueFromIMF(string sFieldName, XElement xNode, string sInterfaceName)
        {
            // objlogger.LogInfo("inside GetValueFromIMF Field=" + sFieldName);          
            string strToReturn = "";

            try
            {
                string[] sKeys = sFieldName.Split('.');

                if (sKeys.Length > 1)
                {
                    objlogger.LogInfo("splitting involved", GlobalConstants.LOGGERLEVEL2);
                    string sCurrentKey = sKeys[0];
                    string sCurrentId = string.Empty;

                    objlogger.LogInfo("Current Key" + sCurrentKey, GlobalConstants.LOGGERLEVEL1);

                    if (!(string.IsNullOrEmpty(sCurrentKey)))
                    {
                        //objlogger.LogInfo("Current Key" + sCurrentKey);
                        if (sCurrentKey.Contains(GlobalConstants.ATTR)) //REUBK-1450
                        {
                            sCurrentKey = sCurrentKey.Replace(GlobalConstants.ATTR, ' ');
                            sCurrentKey = sCurrentKey.Trim();

                            XAttribute Xattr = xNode.Attributes()
                                         .Where(n => n.Name.ToString().ToUpper() == sCurrentKey.ToUpper())
                                         .Select(n => n).Single();

                            objlogger.LogInfo("got attr value", GlobalConstants.LOGGERLEVEL1);
                            sCurrentId = Xattr.Value.Trim();
                        }
                        else
                        {
                            XElement xIMFElement = xNode.Elements()
                                        .Where(n => n.Name.ToString().ToUpper() == sCurrentKey.ToUpper())
                                        .Select(n => n).Single();
                            if (xIMFElement.FirstAttribute != null)
                            {
                                objlogger.LogInfo("got element's attr value", GlobalConstants.LOGGERLEVEL1);
                                sCurrentId = xIMFElement.FirstAttribute.Value.Trim();
                            }
                        }



                        objlogger.LogInfo("Current ID" + sCurrentId, GlobalConstants.LOGGERLEVEL1);

                        XElement oLinkedElement = IssueIMF.Elements().Elements().Elements()
                                                  .Where(n => (n.FirstAttribute != null
                                                                && n.FirstAttribute.Name == GlobalConstants.ID)
                                                                && n.FirstAttribute.Value == sCurrentId).Select(n => n)
                                                  .Single();

                        //objlogger.LogInfo("Linked element  " + oLinkedElement.ToString());


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

                        objlogger.LogInfo("Further Key " + sFurtherkey + " -Linked element " + oLinkedElement.ToString(), GlobalConstants.LOGGERLEVEL1);

                        strToReturn = GetValueFromIMF(sFurtherkey, oLinkedElement, sInterfaceName);

                        //objlogger.LogInfo("Return from sub query " + sFurtherkey);
                    }

                    else
                    {
                        throw new SystemException(sCurrentKey + " is not a reference field and . Notation cannot be used with it");
                    }
                }
                else
                {
                    objlogger.LogInfo("splitting not involved", GlobalConstants.LOGGERLEVEL2);

                    if (sFieldName.Contains(GlobalConstants.ATTR)) //REUBK-1442
                    {
                        objlogger.LogInfo("fetch attribute", GlobalConstants.LOGGERLEVEL2);
                        sFieldName = sFieldName.Replace(GlobalConstants.ATTR, ' ');
                        sFieldName = sFieldName.Trim();
                        XAttribute xIMFAttr = xNode.Attributes().Where(n => n.Name.ToString().ToUpper() == sFieldName.ToUpper())
                                          .Select(n => n).Single();
                        strToReturn = xIMFAttr.Value;
                        objlogger.LogInfo("fetch attribute-end", GlobalConstants.LOGGERLEVEL2);

                    }
                    else
                    {
                        //stop import if field not present in imf is an OPERAND
                        try
                        {
                            objlogger.LogInfo("fetch element", GlobalConstants.LOGGERLEVEL2);

                            //Start Test
                           /* objlogger.LogInfo("Displaying ALL IMF elements");
                            objlogger.LogInfo("Main element name : " + xNode.Name.ToString());
                            foreach(XElement e in xNode.Elements())
                            {
                                objlogger.LogInfo("Name : " + e.Name.ToString());
                                objlogger.LogInfo("Value : " + e.Value);

                            }*/
                            //End Test
                            XElement xIMFElement = xNode.Elements()
                                               .Where(n => n.Name.ToString().ToUpper() == sFieldName.ToUpper())
                                               .Select(n => n).Single();

                            strToReturn = FormatValues(xIMFElement);
                            objlogger.LogInfo("fetch element-end", GlobalConstants.LOGGERLEVEL2);
                        }
                        catch
                        {
                            throw new Exception("Exception in getting value from IMF operand");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                objlogger.LogInfo("Excep in GetValueFromIMF" + ex.Message, GlobalConstants.LOGGERLEVEL1);
            }
            objlogger.LogInfo("return value from GetValueFromIMF" + strToReturn, GlobalConstants.LOGGERLEVEL1);
            return strToReturn;
        }


        public string ResolveXPATH(string sXPATH)
        {
            int iResult = 0;
            string xpathResult = string.Empty;
            try
            {
                if (sXPATH.Contains("count"))
                {
                    //set count based on xpath                    
                    iResult = Convert.ToInt16(IssueIMF.Root.XPathEvaluate(sXPATH, nsIMFMgr));
                    xpathResult = iResult.ToString();
                }
                else
                {
                    if (IssueIMF.XPathSelectElements(sXPATH, nsIMFMgr).Count() > 1)
                    {
                        foreach (XElement xSingle in IssueIMF.XPathSelectElements(sXPATH, nsIMFMgr))
                        {
                            xpathResult = xpathResult + xSingle.Value + " , ";
                        }

                        xpathResult = System.Text.RegularExpressions.Regex.Replace(xpathResult, " , $", "");
                    }
                    else
                    {
                        xpathResult = Convert.ToString(IssueIMF.XPathSelectElement(sXPATH, nsIMFMgr).Value);
                    }
                }
            }
            catch (Exception ex)
            {
              
            }
            return xpathResult;
        }
        public void UpdateIMFForStructChange(string sName, string sValueToUpdate, string sXPath, string sAction,Logger objLogger) //REUBK-1232
        {
            try
            {
                //objLogger.LogInfo("Inside Structure change");
                IEnumerable<XElement> xoKeys = IssueIMF.Root.XPathSelectElements(sXPath, nsIMFMgr);
                objLogger.LogInfo("UpdateIMFForStructChange:" + xoKeys.Count().ToString(), GlobalConstants.LOGGERLEVEL1);

                 
                foreach (XElement xElement in xoKeys)
                {
                    //Utilities.objLogger.LogInfo("switch action" + sAction);
                    switch (sAction)
                    {
                        case RulesFileTags.ADD_BRACKETELEMENT:
                            objLogger.LogInfo("Inside ADD_BRACKETELEMENT", GlobalConstants.LOGGERLEVEL1);

                            XElement existingElement = xElement.Element(sName);
                            objlogger.LogInfo("xElement :" + xElement.Name, GlobalConstants.LOGGERLEVEL1);
                            if (!string.IsNullOrEmpty(sValueToUpdate))
                            {
                                //xElement.AddAfterSelf(new XElement(sName, sValueToUpdate));
                                xElement.Element(sName).AddAfterSelf(new XElement(sName, sValueToUpdate));
                            }

                            else if (existingElement == null)
                            {
                                // Since the element does not exist, we can add it as the first child
                                xElement.Add(new XElement(sName, sValueToUpdate));
                            }

                            else
                            {
                                //xElement.AddAfterSelf(new XElement(sName));
                                xElement.Element(sName).AddAfterSelf(new XElement(sName));
                            }
                            objLogger.LogInfo("After adding sibling element", GlobalConstants.LOGGERLEVEL1);
                            break;

                        case RulesFileTags.ADD:
                            xElement.SetElementValue(sName, sValueToUpdate);
                            break;

                        case RulesFileTags.REMOVE:
                            xElement.SetElementValue(sName, null);
                            break;

                        case RulesFileTags.ADDATTR:

                            //string[] str = sName.Split(GlobalConstants.COLON);
                            //string sAttanme = str[0];
                            //string sAttVAlue = str[1];          
                            objLogger.LogInfo("Inside ADDATTR" + xElement.Name.ToString() + sValueToUpdate + sName, GlobalConstants.LOGGERLEVEL1);
                            xElement.SetAttributeValue(sName, sValueToUpdate);
                            objLogger.LogInfo("after DDATTR", GlobalConstants.LOGGERLEVEL1);
                            break;

                        case RulesFileTags.REMOVEATTR:
                            xElement.SetAttributeValue(sName, null);
                            break;

                        default:
                            break;
                    }
                }
                //Utilities.objLogger.LogInfo("End Structure change");
            }
            catch (Exception ex)
            {
                //objlogger.LogException("Exception in Structure change" + ex.Message);
                //Utilities.objLogger.LogInfo("exception inUpdateIMFForStructChange--" + ex.Message);
                throw new SystemException("Exception in iUpdateIMFForStructChange. Please contact administrator");
            }
            objLogger.LogInfo("end of structure change", GlobalConstants.LOGGERLEVEL1);
        }


        public void UpdateIMFForElementChange(string sName, string sValueToUpdate, string sXPath, string sAction, Logger objlogger) //REUBK-1232
        {
            try
            {
                //Utilities.objLogger.LogInfo("Inside Structure change");

                objlogger.LogInfo("calling UpdateIMFForElementChange, name=" + sName + "Value=" + sValueToUpdate + "Action=" + sAction + "XPath=" + sXPath, GlobalConstants.LOGGERLEVEL1);

                IEnumerable<XElement> xoKeys = IssueIMF.Root.XPathSelectElements(sXPath, nsIMFMgr);
                foreach (XElement xElement in xoKeys)
                {
                    //Utilities.objLogger.LogInfo("switch action" + sAction);
                    switch (sAction)
                    {
                        case RulesFileTags.ADD:
                            xElement.SetElementValue(sName, sValueToUpdate);
                            break;

                        case RulesFileTags.REMOVE:
                            xElement.SetElementValue(sName, null);
                            break;

                        case RulesFileTags.DELETE:

                            objlogger.LogInfo("inside DELETE-->", GlobalConstants.LOGGERLEVEL1);
                            xElement.Remove();

                            //if (xElement.Parent.Name.ToString() == "EXTERNALEXCHANGEDATTACH")
                            //{
                            //    if (xElement.Parent.Elements().Count() == 1) xElement.Parent.Elements().Remove();
                            //}
                            break;

                        case RulesFileTags.REPLACE:
                            objlogger.LogInfo("inside REPLACE-->", GlobalConstants.LOGGERLEVEL1);
                            if (xElement.HasElements)
                            {                                
                                XElement xPNode = xElement.Elements().Where(x => x.Value == sValueToUpdate).Single();
                                xPNode.Remove();
                                //no attachments - only stateinfo -delete first p tag
                                if (xElement.Elements().Count() == 1) xElement.Elements().Remove();
                            }                          
                            break;

                        default:
                            break;
                    }
                }
                //Utilities.objLogger.LogInfo("End Structure change");
            }
            catch (Exception ex)
            {
                //Utilities.objLogger.LogInfo("exception inUpdateIMFForStructChange--" + ex.Message);
                throw new SystemException("Exception in iUpdateIMFForStructChange. Please contact administrator");
            }
        }


        /// <summary>
        /// Method to load field values to IMF from VRF
        /// </summary>
        /// <param name="sFieldName"></param>
        /// <param name="sValueToUpdate"></param>
        /// <param name="xNode"></param>
        /// <param name="ForViolationHandler"></param>
        public void UpdateIMFFromRulesFile(string sFieldName, string sValueToUpdate, XElement xNode, bool ForViolationHandler, string sInterfaceName)
        {
            objlogger.LogInfo("UpdateIMFFromRulesFile starts", GlobalConstants.LOGGERLEVEL1);
            var ValueInIMF = GetNodeFromIMF(sFieldName, xNode, sInterfaceName); //REUBK-1232,1442
            //var ValueInIMF = xNode.Element(sFieldName);
            if (ValueInIMF == null)
            {
                objlogger.LogInfo("UpdateIMFFromRulesFile-- Create new element in IMF", GlobalConstants.LOGGERLEVEL2);
                XElement xElementNew = new XElement(sFieldName);
                xElementNew.Value = sValueToUpdate;
                xNode.Add(xElementNew);
            }
            else
            {
                objlogger.LogInfo("UpdateIMFFromRulesFile-- set value to existing field in IMF", GlobalConstants.LOGGERLEVEL2);
                ValueInIMF.Value = sValueToUpdate;
            }
            objlogger.LogInfo("UpdateIMFFromRulesFile ends", GlobalConstants.LOGGERLEVEL1);
        }

        public XElement GetNodeFromIMF(string sFieldName, XElement xNode, string sInterfaceName) //REUBK-1232
        {
            objlogger.LogInfo("inside GetNodeFromIMF Field=" + sFieldName, GlobalConstants.LOGGERLEVEL1);
            XElement xIMFElement;

            if (sFieldName.Contains('.'))
            {
                objlogger.LogInfo("multilevel --> split string", GlobalConstants.LOGGERLEVEL2);
                string[] sKeys = sFieldName.Split('.');

                if (sKeys.Length > 1)
                {
                    string sCurrentKey = sKeys[0];

                    objlogger.LogInfo("Current Key" + sCurrentKey, GlobalConstants.LOGGERLEVEL1);

                    xIMFElement = xNode.Elements()
                                     .Where(n => n.Name.ToString().ToUpper() == sCurrentKey.ToUpper())
                                     .Select(n => n).Single();

                    if (xIMFElement.FirstAttribute != null)
                    {
                        string sCurrentId = xIMFElement.FirstAttribute.Value.Trim();

                        objlogger.LogInfo("Current ID" + sCurrentId, GlobalConstants.LOGGERLEVEL1);

                        XElement oLinkedElement = IssueIMF.Elements().Elements().Elements()
                                                  .Where(n => (n.FirstAttribute != null
                                                                && n.FirstAttribute.Name == GlobalConstants.ID)
                                                                && n.FirstAttribute.Value == sCurrentId).Select(n => n)
                                                  .Single();

                        //objlogger.LogInfo("Linked element  " + oLinkedElement.ToString());

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

                        objlogger.LogInfo("Further Key " + sFurtherkey + " -Linked element " + oLinkedElement.ToString(), GlobalConstants.LOGGERLEVEL1);

                        xIMFElement = GetNodeFromIMF(sFurtherkey, oLinkedElement, sInterfaceName);

                        //objlogger.LogInfo("Return from sub query " + sFurtherkey);
                    }
                    else
                    {
                        throw new SystemException(sCurrentKey + " is not a reference field and . Notation cannot be used with it");
                    }
                }
                else
                {
                    try
                    {
                        xIMFElement = xNode.Elements()
                                             .Where(n => n.Name.ToString().ToUpper() == sFieldName.ToUpper())
                                             .Select(n => n).Single();
                    }
                    catch
                    {
                        objlogger.LogInfo("excep in getting node-element not found", GlobalConstants.LOGGERLEVEL1);
                        return null;
                    }
                }
            }
            else
            {
                objlogger.LogInfo("no splitting involved", GlobalConstants.LOGGERLEVEL2);

                try
                {
                    xIMFElement = xNode.Elements()
                                         .Where(n => n.Name.ToString().ToUpper() == sFieldName.ToUpper())
                                         .Select(n => n).Single();
                }
                catch
                {
                    objlogger.LogInfo("excep in getting node-element not found", GlobalConstants.LOGGERLEVEL1);
                    return null;
                }
            }

            objlogger.LogInfo("return value from GetNodeFromIMF" + xIMFElement.ToString(), GlobalConstants.LOGGERLEVEL1);
            return xIMFElement;
        }

        /// <summary>
        /// Updates DBID and all its references in IMF
        /// </summary>
        /// <param name="l_oQueryResult"></param>
        /// <param name="oRecord"></param>
        public void UpdateBackMaps(IQueryResult l_oQueryResult, XElement oRecord, string sInterfaceName)
        {
            objlogger.LogInfo("UpdateBackMaps: Starts() for " + oRecord.Name.ToString(), GlobalConstants.LOGGERLEVEL1);
            objlogger.LogInfo(oRecord.ToString(), GlobalConstants.LOGGERLEVEL2);
            string sDBID = l_oQueryResult.FieldValues[GlobalConstants.DBID.ToLower()];
            string description = string.Empty;
            objlogger.LogInfo("sDBID: " + sDBID, GlobalConstants.LOGGERLEVEL1);
            string sIDRef = string.Empty;
            string sID = string.Empty;
            string sDescription = string.Empty;
            string sTag = string.Empty;
            string oemWorkFlow = IssueIMF.Root.Element(IMFFileTags.RT_VALEXCONTROLINFO).Element(IMFFileTags.VALEXCONTROLINFO).Element(IMFFileTags.OEMWORKFLOW).Value;
            string oemWorkFlowState = IssueIMF.Root.Element(IMFFileTags.RT_VALEXCONTROLINFO).Element(IMFFileTags.VALEXCONTROLINFO).Element(IMFFileTags.OEMEXTERNALSTATE).Value;
            try
            {
                sID = l_oQueryResult.FieldValues[GlobalConstants.ID.ToLower()];
                objlogger.LogInfo("sID : " + sID, GlobalConstants.LOGGERLEVEL1);
                try
                {
                    oRecord.Element(GlobalConstants.ID).Value = sID;
                }
                catch (Exception ex)
                {
                    objlogger.LogException(ex, "UpdateBackMaps()- Exception while setting ID value");
                }
            }
            catch (Exception ex)
            {
                //Do not log this error
                //objlogger.LogException(ex, "UpdateBackMaps()- Exception while getting ID value");
            }

            try
            {
                sIDRef = oRecord.Attribute(GlobalConstants.ID).Value;
                objlogger.LogInfo("sIDRef : " + sIDRef, GlobalConstants.LOGGERLEVEL1);
            }
            catch (Exception ex)
            {
                //Do not log this error
                //Utilities.objLogger.LogException(ex, "UpdateBackMaps()- Exception while getting IDREF value");
            }

            oRecord.Element(GlobalConstants.DBID).Value = sDBID;

            objlogger.LogInfo("Post ID update" + oRecord.ToString(), GlobalConstants.LOGGERLEVEL1);

            //updating Issue.Assignee with Release.Tags.DefaultASAMAssignee

            //-shreya's Code
            try
            {
                if (oemWorkFlow.Contains("DAI_ASAM320_SWRQ") && oemWorkFlowState.ToLower() == "requested" )
                {
                    string recordType = l_oQueryResult.FieldValues[GlobalConstants.DcType];
                    if(recordType.Equals("Release"))
                    {
                        sTag = l_oQueryResult.FieldValues[GlobalConstants.TAGS];
                        if (sTag != String.Empty)
                        {
                            Regex r = new Regex(@"(?s)(?<=\<DefaultASAMAssignee\>)(.*?)(?=\<\/DefaultASAMAssignee\>)");
                            Match m = r.Match(sTag);
                            if (m.Success)
                            {
                                IEnumerable<XElement> l_oMappableIssue
                                    = IssueIMF.Root.Elements(IMFFileTags.RT_ISSUE)
                                    .Elements(IMFFileTags.ISSUE).Elements();
                                foreach (XElement oElement in l_oMappableIssue)
                                {
                                    if (oElement.Name.LocalName.ToUpper().Equals("ASSIGNEE"))
                                    {
                                        oElement.Value = m.Value;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }


            //updating description field of issue
            try
                
            {
                sDescription = l_oQueryResult.FieldValues[GlobalConstants.DESCRIPTION];
                objlogger.LogInfo("sDescription : " + sDescription, GlobalConstants.LOGGERLEVEL1);
            }

            catch (Exception ex)
            {
                objlogger.LogException(ex, "UpdateBackMaps()- Exception while getting description value");
            }

            //updating description field of issue in IMF
            //string oemWorkFlow = IssueIMF.Root.Element(IMFFileTags.RT_VALEXCONTROLINFO).Element(IMFFileTags.VALEXCONTROLINFO).Element(IMFFileTags.OEMWORKFLOW).Value;
            if(oemWorkFlow.Contains("DAI_ASAM320_SWRQ") || oemWorkFlow.Contains("DAI_ASAM320_SWSP"))
            {
                if (sDescription != String.Empty)
                {
                    IEnumerable<XElement> l_oMappableIssue
                        = IssueIMF.Root.Elements(IMFFileTags.RT_ISSUE)
                        .Elements(IMFFileTags.ISSUE).Elements();
                    foreach (XElement oElement in l_oMappableIssue)
                    {
                        try
                        {
                            if (oElement.Name.LocalName.ToUpper().Contains("DESCRIPTION"))
                            {

                                Regex r = new Regex(@"\d{2}.\d{2}.\d{4} \d{2}:\d{2}:\d{2}");
                                Match m = r.Match(oElement.Value);
                                Match m2 = r.Match(sDescription);
                                string sImfdescriptionDateStamp = string.Empty;   // used as a temp variable to store oElement value

                                if (sDescription.Contains("DATE=") && oElement.Value.Contains("DATE="))
                                {
                                    if (m.Success)
                                    {
                                        sImfdescriptionDateStamp = oElement.Value.Replace(m.Value, "");
                                    }
                                    if (m2.Success)
                                    {
                                        sDescription = sDescription.Replace(m2.Value, "");
                                    }
                                    sDescription = sDescription.Trim();
                                    sImfdescriptionDateStamp = Regex.Replace(sImfdescriptionDateStamp, "<.*?>", String.Empty).Trim();
                                    if (sDescription.Contains(sImfdescriptionDateStamp))
                                    {
                                        oElement.Value = "";
                                        break;
                                    }
                                }


                            }

                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }
            }

            //Updating SDBiD and IDRef in IMF
            if (sIDRef != string.Empty)
            {

                IEnumerable<XElement> l_oMappableIssue
                    = IssueIMF.Root.Elements(IMFFileTags.RT_ISSUE)
                    .Elements(IMFFileTags.ISSUE).Elements();

                foreach (XElement oElement in l_oMappableIssue)
                {
                    try
                    {
                        if (oElement.Attribute(IMFFileTags.ID_REF).Value == sIDRef)
                        {
                            if (sID != string.Empty)
                                oElement.Value = sID;
                            else
                                oElement.Value = sDBID;
                        }
                    }
                    catch (Exception ex)
                    {
                        //Do not log this error
                        //Utilities.GetLogger(sInterfaceName).LogException(ex, "UpdateBackMaps()- Exception while setting backref values in Issues");
                    }
                }

                IEnumerable<XElement> l_oMappableRelease
               = IssueIMF.Root.Elements(IMFFileTags.RT_RELEASES)
               .Elements(IMFFileTags.RELEASE).Elements();

                foreach (XElement oElement in l_oMappableRelease)
                {
                    try
                    {
                        if (oElement.Attribute(IMFFileTags.ID_REF).Value == sIDRef)
                        {
                            if (sID != string.Empty)
                                oElement.Value = sID;
                            else
                                oElement.Value = sDBID;
                        }
                    }
                    catch (Exception ex)
                    {//Do not log this error
                        //Utilities.GetLogger(sInterfaceName).LogException(ex, "UpdateBackMaps()- Exception while setting backref values in IRMAPS");
                    }

                }

                IEnumerable<XElement> l_oMappableReleaseMap
                 = IssueIMF.Root.Elements(IMFFileTags.RT_IRMAPS)
                 .Elements(IMFFileTags.IRMAP).Elements();

                foreach (XElement oElement in l_oMappableReleaseMap)
                {
                    try
                    {
                        if (oElement.Attribute(IMFFileTags.ID_REF).Value == sIDRef)
                        {
                            if (sID != string.Empty)
                                oElement.Value = sID;
                            else
                                oElement.Value = sDBID;
                        }
                    }
                    catch (Exception ex)
                    {
                        //Do not log this error
                        //Utilities.GetLogger(sInterfaceName).LogException(ex, "UpdateBackMaps()- Exception while setting backref values in IRMAPS");
                    }

                }

                IEnumerable<XElement> l_oCommertial
                = IssueIMF.Root.Elements(IMFFileTags.RT_COMMERCIALS)
                .Elements(IMFFileTags.COMMERCIAL).Elements();

                foreach (XElement oElement in l_oCommertial)
                {
                    try
                    {
                        if (oElement.Attribute(IMFFileTags.ID_REF).Value == sIDRef)
                        {
                            if (sID != string.Empty)
                                oElement.Value = sID;
                            else
                                oElement.Value = sDBID;
                        }
                    }
                    catch (Exception ex)
                    {
                        //Do not log this error
                        //Utilities.GetLogger(sInterfaceName).LogException(ex, "UpdateBackMaps()- Exception while setting backref values in IRMAPS");
                    }

                }

            }
            objlogger.LogInfo("UpdateBackMaps: ends() ", GlobalConstants.LOGGERLEVEL1);
        }

        public void WriteToIsolatedStorage(Dictionary<string, string> OrcParms, string sPersistenceDataStore)
        {
            //Utilities.objLogger.LogInfo("WriteToIsolatedStorage-starts");
            PersistenceDataManager l_oDataManager = new PersistenceDataManager();

            if (!(sPersistenceDataStore.Contains(PersistenceDataStores.LIFETOKEN)))
            {
                l_oDataManager.WriteData(IssueIMF.ToString(),
             sPersistenceDataStore,
             false,
             OrcParms[OrcParameters.XCHANGEPROTOCOLID]);
            }
            else
            {
                //Utilities.objLogger.LogInfo("WriteToIsolatedStorage-for usererror recreate--");
                l_oDataManager.WriteData(OrcParms[OrcParameters.INITIALLIFETOKEN],
                 sPersistenceDataStore,
                 false,
                 OrcParms[OrcParameters.XCHANGEPROTOCOLID]);
            }


            //Utilities.objLogger.LogInfo("WriteToIsolatedStorage-ends");
        }


        public void WriteToIsolatedStorage(string xprot, string sPersistenceDataStore, string sdata)
        {
            //REUBK-2136
            //Utilities.objLogger.LogInfo("WriteToIsolatedStorage-starts");
            PersistenceDataManager l_oDataManager = new PersistenceDataManager();
            l_oDataManager.WriteData(sdata, sPersistenceDataStore, false, xprot);
        }


        public void WriteToIsolatedStorageTest(string xprot, string sPersistenceDataStore, string sdata, Logger objlogger)
        {
            //REUBK-2136
            //Utilities.objLogger.LogInfo("WriteToIsolatedStorage-starts");
            PersistenceDataManager l_oDataManager = new PersistenceDataManager();
            l_oDataManager.WriteDataTest(sdata, sPersistenceDataStore, false, xprot, objlogger);
        }

        public string ReadFromIsolatedStorage(string xProtocol)
        {
            //Utilities.objLogger.LogInfo("ReadFromIsolatedStorage-starts");
            PersistenceDataManager l_oDataManager = new PersistenceDataManager();
            return l_oDataManager.ReadData(PersistenceDataStores.ROISSUEIMF, xProtocol);

        }


        public void LoadAttachmentTable(string longname, string truncname, Logger objlogger)
        {
            if (AttachmentsTable.Columns.Count == 0)
            {
                AttachmentsTable.Columns.Add("Num", typeof(string));
                AttachmentsTable.Columns.Add("Longname", typeof(string));
                AttachmentsTable.Columns.Add("TruncName", typeof(string));
            }

            int num = AttachmentsTable.Rows.Count + 1;

            bool bRowexists = false;

            foreach (DataRow dr in AttachmentsTable.Rows)
            {
                if (dr["LongName"].ToString() == longname)
                {
                    bRowexists = true;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (bRowexists == false)
            {
                objlogger.LogInfo("att table adding row--->", GlobalConstants.LOGGERLEVEL2);
                AttachmentsTable.Rows.Add(new object[] { num.ToString(), longname, truncname });
            }

            objlogger.LogInfo("att tab rowcount" + AttachmentsTable.Rows.Count.ToString(), GlobalConstants.LOGGERLEVEL2);
        }

        public string[] GetAttTruncName(string longname, string truncname, Logger objlogger)
        {
            objlogger.LogInfo("inside  GetAttTruncName" + longname, GlobalConstants.LOGGERLEVEL1);
            string[] ArrTruncContents = new string[2];
            foreach (DataRow dr in AttachmentsTable.Rows)
            {
                if (dr["LongName"] != null)
                {
                    objlogger.LogInfo("from table-LongName" + dr["LongName"].ToString(), GlobalConstants.LOGGERLEVEL2);
                    if (dr["LongName"].ToString() == longname)
                    {

                        ArrTruncContents[0] = dr["TruncName"].ToString();
                        ArrTruncContents[1] = dr["Num"].ToString();
                        break;
                    }
                }
            }
            objlogger.LogInfo("end  GetAttTruncName" + ArrTruncContents.Count().ToString(), GlobalConstants.LOGGERLEVEL1);
            return ArrTruncContents;
        }

    }
}