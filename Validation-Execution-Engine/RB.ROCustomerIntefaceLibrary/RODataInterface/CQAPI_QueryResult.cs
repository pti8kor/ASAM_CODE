using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClearQuestOleServer;

namespace RB.ROCustomerIntefaceLibrary
{
    public class CQAPI_QueryResult:IQueryResult
    {
        Dictionary<string, string> m_oFieldValues
         = new Dictionary<string, string>();

        OAdEntity l_oEntity=null;
        bool bSuccess = false;

        List<int> l_ReturnedDbids = null;

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

        public object GetRaw()
        {
            return l_oEntity;
        }

        public void SetRaw(object oRaw)
        {
            l_oEntity = oRaw as OAdEntity;
                       
            var oFields = l_oEntity.GetAllFieldValues();

            foreach (IOAdFieldInfo oField in oFields)
            {
                m_oFieldValues.Add(oField.GetName(), oField.GetValue());
            }
        }

        public int RecordCount
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool QuerySuccess
        {
            get
            {
                return bSuccess;
            }
            set
            {
                bSuccess = value;
            }
        }


        public string GetValue(string sField)
        {
            return m_oFieldValues
                   .Where(n => n.Key.ToUpper() == sField.ToUpper())
                   .Select(n => n.Value).Single();
        }

        
    }
}
