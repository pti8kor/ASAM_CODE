using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace RB.ROCustomerIntefaceLibrary
{
    public abstract class RORuleValidationEngine
    {
        #region Variables


        #endregion

        #region Properties
        //Stores the Configuration file. Accessible throught the class 
        public string ValidationRuleFilePath { get; set; }
        public XDocument ValidationRuleConfigurationXMLFile { get; set; }
        public XDocument InterfaceConfigFile { get; set; }
        public XDocument IssueIMF { get; set; }
        public XDocument IssueDataFromRO { get; set; }
        public string IssueProjectID { get; set; }
        public string IssueExternalID { get; set; }
        public string IssueID { get; set; }
        public string IssueState { get; set; }
        public string IssueExternalState { get; set; }
        public bool IsValidationSuccessful { get; set; }
        public string EnityToBeProcessed { get; set; }

        #endregion

        #region Methods

        /// <summary>        
        /// Loads the Rules configuration file based on the customer group and stores the same in global property "ValidationRuleConfigurationXMLFile"
        /// </summary>
        /// <returns>True, if the loading of configuration file was sucessful, 
        ///          False, if there was a failure in loading the file</returns>

        public virtual bool LoadValidationsRulesFile(string strXMLPath)
        {
            bool isFileLoaded = false;
            Utilities.objLogger.LogInfo("RORuleValidationEngine::LoadValidationsRulesFile - Starts");
            try
            {
                Utilities.objLogger.LogInfo("strXMLPath: " + strXMLPath);
                ValidationRuleConfigurationXMLFile = Utilities.LoadXMLDocument(strXMLPath);
                if (ValidationRuleConfigurationXMLFile != null)
                {
                    isFileLoaded = true;
                }
                else
                {
                    throw new IMFRulesFileNotFoundFileException("LoadValidationsRulesFile - File not found");
                }
            }
            catch (IMFRulesFileNotFoundFileException ex)
            {
                isFileLoaded = false;
                Utilities.objLogger.LogException(ex, "LoadValidationsRulesFile: FileNotFound error");
            }
            catch (Exception ex)
            {
                isFileLoaded = false;
                Utilities.objLogger.LogException(ex, "LoadValidationsRulesFile: other errors:");
            }
            Utilities.objLogger.LogInfo("isFileLoaded: " + isFileLoaded);
            Utilities.objLogger.LogInfo("RORuleValidationEngine::LoadValidationsRulesFile - ends");
            return isFileLoaded;
        }

        /// <summary>
        ///    Entry point to this class. This method Will be called from BizTalk.
        ///    This method will take the the Intermediate Issue File as the input.
        ///    Based on the customer, the validation rule file configuration file will be loaded.
        ///    Set Interm issue file to global property "IssueIntermFile"
        /// </summary>
        /// <param name=""></param>
        /// <returns>TRUE, when all the valiation is sucessful,
        ///          FALSE, when any one of the valiation is failed</returns>

        public abstract bool ValidateIMF();

        /// <summary>
        /// Get the Issue's External State from the IMF and set the preoprty IssueExternalState
        /// </summary>
        /// <returns>State from IMF and set to IssueExternalState</returns>
        public abstract string GetIssueState();

        /// <summary>
        /// This method will call the other methods to process the XML file
        /// </summary>
        /// <returns>True when the validation is successful, False whent the validation fails </returns>
        public abstract bool ProcessAllRules();

        ///<summary>
        ///Process all the common rules which are common for all the states
        ///</summary> 
        ///<returns>True, when all the rules are processed and valiations were sucessful
        ///         False, when any one of the rules failed </returns>        
        public abstract bool ProcessCommonRules();

        /// <summary>
        /// Process rules that are state based. 
        /// </summary>
        /// <param name="strStatename">Loads the "state" based configuration rule from validation rule XML</param>
        /// <returns> True, when all the rules are processed and valiations were sucessful
        ///           False, when any one of the rules failed</returns>
        public abstract bool ProcessStateBasedRules(string strStatename);

        /// <summary>
        /// Process all <RULEs/> nodes in sequence
        /// </summary>
        /// <example><code> <RULES name="Issue"></code>: the attribute name from the RULES node is set to EnityToBeProcessed </example>
        /// <param name="xRulesNode"></param>
        /// <returns>TRUE, when all the valiation is sucessful,
        ///         FALSE, when any one of the valiation is failed</returns>

        /// <summary>
        /// Processes the <IMF_RULES/> node for validation. Get's the XPATH to be processed
        /// </summary>
        /// <param name="xRulesNode">xRulesNode will contain the <IMF_NODE/> node</param>
        /// <param name="xRulesNode">Recordtype name of type GlobalConstants.RORecordTypes  </param>
        /// <param name="xRulesNode">String xPATH of the record  </param>
        /// <returns>TRUE, when all the valiation is sucessful,
        ///         FALSE, when any one of the valiation is failed</returns>
        public abstract bool ProcessIMFRule(XElement xRulesNode, GlobalConstants.RORecordTypes rorecType, string sXPATH);

        /// <summary>
        /// Execute RO Specific rules by calling LoadContentFromRO()
        /// </summary>
        /// <param name="xRORules"></param>
        /// <param name="xRulesNode">Recordtype name of type GlobalConstants.RORecordTypes  </param>
        /// <returns>True, when all the rules are processed and valiations were sucessful
        ///          false, when any one of the rules failed</returns>
        public abstract bool ProcessIMFFieldRules(XElement xIMFFieldRules, string sXPath);

        /// <summary>
        /// Processes the <IDRULE/> under the IMF on the RequestOne Record specified. 
        /// </summary>
        /// <example>The RO field name to be valiated will be specified in the <code><KEY>EXTERNAL_ID</KEY></code> node.
        /// If the COUNT node contains the following <code><COUNT><OPERATOR>=</OPERATOR><VALUE>0</VALUE></COUNT></code>, 
        /// this means that the External_ID value which is obtained from the XPATH above should not exist in RO. A query is issue against the 
        /// </example>
        /// <param name="xIDRule"></param>        
        /// <returns></returns>
     
        #endregion


    }
}
