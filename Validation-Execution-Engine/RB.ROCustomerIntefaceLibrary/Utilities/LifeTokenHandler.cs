using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RB.ROCustomerIntefaceLibrary
{
    public class LifeTokenHandler
    {
        public static string InsertAllTokenStatus(string tokenStr, string status)
        {
            string modStr;

            tokenStr = tokenStr.Replace(",", "·");
            // \\w statt \\S verwenden, da sonst .xml nur einmal gematched wird:
            modStr = System.Text.RegularExpressions.Regex.Replace(tokenStr, "(\\w+\\.xml)", "$1::" + status + "||||");
            return modStr;
        }

        public static string SetTokenStatus(string tokenStr, string filename, string status, string message)
        {
            string modStr;
            string sFullMessage = string.Empty;

            //REUBK-2826
            //string AddedBy = " >>DATETIME - CQUSER<<";
            //AddedBy = AddedBy.Replace("DATETIME", System.String.Format("{0:dd.MM.yyyy HH.mm.ss}", System.DateTime.Now));


            if (message.Trim() == string.Empty) return tokenStr; //Do nothing if there are no warning messages.

            if (status == RulesFileTags.WARNING)
            {
                message = "W: " + message;
                status = "Failure";
            }
            else if (status == "Failure")
            {
                message = "E: " + message;
            }

            string sCurrentMessage = GetTokenMessageForFile(tokenStr, filename);
            //string[] sMessages = sCurrentMessage.Split('~');
            //REUBK-2266
            string[] sMessages = sCurrentMessage.Split('¬');

            //Copy all warning messages
            for (int i = 0; i < sMessages.Count(); i++)
            {
                if (sMessages[i].Contains("W:"))
                {
                    //sFullMessage += sMessages[i] + "~";
                    sFullMessage += sMessages[i] + "¬"; //REUBK-2266
                }
            }

            sFullMessage += message;
            //to simplyfy matching, extend a comma and delete it afterwards:
            tokenStr = tokenStr + "·";

            if (System.Text.RegularExpressions.Regex.IsMatch(tokenStr, filename + "::.+"))
            {
                //modStr = System.Text.RegularExpressions.Regex.Replace(tokenStr, "(" + filename + "::)[^\\|]+\\|\\|[^\\|]*\\|\\|,", "$1" + status + "||" + sFullMessage + "||,");
                //REUBK-1388 do not use comma for lifetoken file separation, use · 


                //modStr = System.Text.RegularExpressions.Regex.Replace(tokenStr, "(" + filename + "::)[^\\|]+\\|\\|[^\\|]*\\|\\|·", "$1" + status + "||" + sFullMessage + "||·");

                string UserAndDateTime = SetTokenActionStampForFile();
                modStr = System.Text.RegularExpressions.Regex.Replace(tokenStr, "(" + filename + "::)[^\\|]+\\|\\|[^\\|]*\\|\\|·", "$1" + status + UserAndDateTime + "||" + sFullMessage + "||·");
            }
            else
            {
                modStr = tokenStr;
            }

            modStr = System.Text.RegularExpressions.Regex.Replace(modStr, "·$", "");

            //Utilities.objLogger.LogInfo("SetTokenStatus ends" + modStr);

            return modStr;
        }

        public static string SetTokenActionStampForFile()
        {
            string AddedBy = " >>DATETIME - CQUSER<<";
            AddedBy = AddedBy.Replace("DATETIME", System.String.Format("{0:dd.MM.yyyy HH.mm.ss}", System.DateTime.Now));
            return AddedBy;
        }


        public static string GetTokenStatusForFile(string tokenStr, string filename)
        {
            string statusStr;

            //to simplyfy matching, extend a comma and delete it afterwards:
            tokenStr = tokenStr + "·";

            //string pattern = filename + @"::([^\|]+)\|\|[^\|]*\|\|·";

            //System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(tokenStr, pattern);
            //REUBK-2826
            string pattern = filename + @"::([^\ >]+)\s.>([0-9a-zA-Z\.\-\s]+)<.[\|\|\n]*(.*?)\|\|";

            System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(tokenStr, pattern, System.Text.RegularExpressions.RegexOptions.Singleline);
            if (match.Success)
            {
                statusStr = match.Groups[1].Value;
            }
            else
            {
                statusStr = "failure:status not found";
            }


            //Utilities.objLogger.LogInfo("GetTokenStatusForFile ends" + statusStr);
            return statusStr;
        }

        public static string GetTokenMessageForFile(string tokenStr, string filename)
        {
            string messageStr;

            //to simplyfy matching, extend a comma and delete it afterwards:
            tokenStr = tokenStr + "·";

            //string pattern = filename + @"::[^\|]+\|\|([^\|]*)\|\|,"; //REUBK-1884   

            //string pattern = filename + @"::[^\|]+\|\|([^\|]*)\|\|·"; 
            //System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(tokenStr, pattern);

            //REUBK-2826
            string pattern = filename + @"::([^\ >]+)\s.>([0-9a-zA-Z\.\-\s]+)<.[\|\|\n]*(.*?)\|\|";

            System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(tokenStr, pattern, System.Text.RegularExpressions.RegexOptions.Singleline);

            if (match.Success)
            {
                messageStr = match.Groups[3].Value;
            }
            else
            {
                messageStr = "failure:message not found";
            }

            // Utilities.objLogger.LogInfo("GetTokenMessageForFile ends"+messageStr);
            return messageStr;
        }


        public static string GetTokenActionStampForFile(string tokenStr, string filename)
        {
            string UserandDateTime;

            tokenStr = tokenStr + "·";

            //REUBK-2826
            string pattern = filename + @"::([^\ >]+)\s.>([0-9a-zA-Z\.\-\s]+)<.[\|\|\n]*(.*?)\|\|";

            System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(tokenStr, pattern, System.Text.RegularExpressions.RegexOptions.Singleline);

            if (match.Success)
            {
                UserandDateTime = match.Groups[2].Value;
            }
            else
            {
                UserandDateTime = "failure:message not found";
            }

            return UserandDateTime;

        }



        public static bool CanProceed(string tokenStr, string filename)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tokenStr, filename + "::Failure.*"))
            {
                return false;
            }

            return true;
        }

        public static string GetOverallTokenStatus(string tokenStr)
        {
            string overallStatus;

            //> alle "In Work" > Failure gibts nicht einmal
            //> alle "Failure" > In Work gibts nicht einmal
            //> zT "Failure"

            if (!System.Text.RegularExpressions.Regex.IsMatch(tokenStr, "::Failure"))
            {
               // overallStatus = "None";
                overallStatus = "Success";
            }
            else
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(tokenStr, "::Success"))
                {
                    overallStatus = "Failure";
                }
                else
                {
                    overallStatus = "Incomplete";
                }
            }

            //Utilities.objLogger.LogInfo("GetOverallTokenStatus ends" + overallStatus);
            return overallStatus;
        }   



    }
}
