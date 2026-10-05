using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RB.ROCustomerIntefaceLibrary
{
    public class AffectedRecord
    {
        string sRecordType = string.Empty;
        string sRecordID = string.Empty;

        public AffectedRecord(string sRecordType, string sRecordID)
        {
            this.RecordID = sRecordID;
            this.RecordType = sRecordType; 
        }
        public string RecordID
        {
            get { return sRecordID; }
            set { sRecordID = value; }
        }

        public string RecordType
        {
            get { return sRecordType; }
            set { sRecordType = value; }
        }
    }
}
