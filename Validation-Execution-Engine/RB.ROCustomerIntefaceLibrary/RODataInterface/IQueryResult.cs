using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RB.ROCustomerIntefaceLibrary
{
    public interface IQueryResult
    {

        Dictionary<string, string> FieldValues
        {
            get;
            set;
        }

        object GetRaw();

        string GetValue(string sField);

        void SetRaw(object oRaw);

        int RecordCount { get; set; }

        bool QuerySuccess
        {
            get;
            set;
        }
        List<int> ReturnedDbids
        {
            get;
            set;
        }
    }
}
