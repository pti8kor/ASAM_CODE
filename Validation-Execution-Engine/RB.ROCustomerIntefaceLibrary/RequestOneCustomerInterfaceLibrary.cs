using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;

namespace RB.ROCustomerIntefaceLibrary
{
    public abstract class RequestOneCustomerInterfaceLibrary
    {

        #region Properties
        public string ExchangeFormat { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// This method will be called from BTHelper. This method will call the other methdos to validate the IMF
        /// </summary>
        /// <param name="xIssueDoc">IMF from BizTalk in XDocument format</param>
        /// <returns>true if the validation is true, false if the validation fails</returns>
        public abstract bool ValidateIMF(XDocument xIssueDoc,Dictionary<string,string> Orc_parms, bool bIsMsgAck, Logger l_ologger);
        /// <summary>
        /// This method will process the IMF, by getting the data from CQ etc. 
        /// </summary>
        /// <param name="xIssueDoc">IMF from BizTalk in XDocument format</param>
        /// <returns>the modified IMF to the calling function</returns>
        public abstract XDocument ProcessIMFAndFillMissingDetails(XDocument xIssueDoc, Dictionary<string, string> Orc_parms);
        /// <summary>
        /// UpdateIMRToRO() -> Based on the resultset this method will update / insert the data into RO
        /// </summary>
        /// <param name="xIssueDoc">Updated IMF from the orchestration</param>
        /// <returns>True, if the update or insert is successful, False, if the update or insert is a failure</returns>
        public abstract bool UpdateIMRToRO(XDocument xIssueDoc);
        /// <summary>
        /// GetEvaluator the Project ID from Interface Configuration file
        /// </summary>
        /// <returns></returns>
        public abstract string GetProjectIDFromConfig();

        public abstract XmlDocument GetImportFileNamesForExchange();

        string GetExchangeFormat()
        { return ""; }

        #endregion
    }

}
