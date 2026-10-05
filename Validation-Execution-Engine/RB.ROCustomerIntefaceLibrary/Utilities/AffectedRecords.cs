using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace RB.ROCustomerIntefaceLibrary
{
    public class AffectedRecords: List<AffectedRecord>
    {
        List<string> l_oAllowedRecords = new List<string>();


        public void SetConfiguration(XDocument oConfiguration)
        {
            //Utilities.objLogger.LogInfo("Setting configuration for Affected records");
            string sAffectedRecords = oConfiguration.Root.Element(ConfigurationFileTags.REQUESTONE)
                                      .Element("CQ").Element(ConfigurationFileTags.AFFECTEDRECORDS).Value;
            //Utilities.objLogger.LogInfo("Affected records are :" + sAffectedRecords);

            string[] sAffecteds = sAffectedRecords.Split(',');

            foreach (string sAffected in sAffecteds)
            {
                l_oAllowedRecords.Add(sAffected.ToUpper());
            }

            //Utilities.objLogger.LogInfo("Affected records Count :" + l_oAllowedRecords.Count.ToString());
        }

        public void Add(string sRecordType, string sRecordID)
        {
           // Utilities.objLogger.LogInfo("Affected Records added Method starts");
           if(!RecordAlreadyExists(sRecordType,sRecordID))
           {
              //Utilities.objLogger.LogInfo("Record added to affected records");
                this.Add(new AffectedRecord(sRecordType, sRecordID));
           }
          // Utilities.objLogger.LogInfo("Affected Records added Method Ends");
        }

        public bool RecordAlreadyExists(string sRecordType, string sRecordID)
        {
           // Utilities.objLogger.LogInfo("Affected Records RecordAlreadyExists Method starts");
            int iRecordcount = this.Where(n => n.RecordType == sRecordType && n.RecordID == sRecordID)
                                    .Count();
           // Utilities.objLogger.LogInfo("Affected Records RecordAlreadyExists Method Ends");
            if (iRecordcount > 0) return true;

            return false;

        }

        //public override string ToString()
        //{
        //    int iCount = 0;
        //    StringBuilder l_oBuilder = new StringBuilder();
        //    //Utilities.objLogger.LogInfo("Building Affected records string");
        //    l_oBuilder.Append("~");
        //    l_oBuilder.Append("Affected Records:~");
        //    foreach (AffectedRecord l_oRecord in this)
        //    {
        //        //Utilities.objLogger.LogInfo("Building Affected records" + l_oRecord.RecordType);
        //        if (l_oAllowedRecords.Contains(l_oRecord.RecordType.ToUpper()))
        //        {
        //            //Utilities.objLogger.LogInfo("Building Affected record added" + l_oRecord.RecordType);
        //            iCount++;
        //            l_oBuilder.Append(l_oRecord.RecordType);
        //            l_oBuilder.Append(" : ");
        //            l_oBuilder.Append(l_oRecord.RecordID);
        //            l_oBuilder.Append("~");
        //        }
        //    }
        //    if (iCount == 0) return "";

        //    return l_oBuilder.ToString();
        //}

        public override string ToString()
        {
            int iCount = 0;
            StringBuilder l_oBuilder = new StringBuilder();
            string sRecordType = string.Empty;
            //Utilities.objLogger.LogInfo("Building Affected records string");
            l_oBuilder.Append("¬");
            l_oBuilder.Append("Affected Records:¬");
            //foreach (AffectedRecord l_oRecord in this)
            foreach (AffectedRecord l_oRecord in this.OrderBy(o=>o.RecordType))
            {
                //Utilities.objLogger.LogInfo("Building Affected records" + l_oRecord.RecordType);

                sRecordType = l_oRecord.RecordType.ToUpper();

                if (sRecordType.Contains("("))
                {
                    string[] sAffecteds = sRecordType.Split('(');
                    sRecordType = sAffecteds[0].ToString();
                }

                if (l_oAllowedRecords.Contains(sRecordType.ToUpper()))
                {                    
                    //Utilities.objLogger.LogInfo("Building Affected record added" + l_oRecord.RecordType);
                    iCount++;
                    l_oBuilder.Append(l_oRecord.RecordType);
                    l_oBuilder.Append(" : ");
                    l_oBuilder.Append(l_oRecord.RecordID);
                    l_oBuilder.Append("¬");
                }
            }
            if (iCount == 0) return "";

            return l_oBuilder.ToString();
        }
        
    }
}
