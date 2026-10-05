using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RB.ROCustomerIntefaceLibrary
{
    public enum ActionTypes
    {
        Overwrite,
        Append,
        Merge,
        Ignore,
        Init
    }

    public class QueryParameters
    {
        private bool bIsComplex;

        Dictionary<string, string> oSimpleData =
            new Dictionary<string, string>();

        Dictionary<string, object> oComplexData =
            new Dictionary<string, object>();

        List<string> oAppendList = new List<string>();
        List<string> oMergeList = new List<string>();
        List<string> oIgnoreList = new List<string>();
        List<string> oInitList = new List<string>();


        public bool IsMergeField(string p_sKey)
        {
            return oMergeList.Contains(p_sKey.ToUpper());
        }
        public bool IsAppendField(string p_sKey)
        {
            return oAppendList.Contains(p_sKey.ToUpper());
        }
        public bool IsIgnoreField(string p_sKey)
        {
            return oIgnoreList.Contains(p_sKey.ToUpper());
        }
        public bool IsInitField(string p_sKey)
        {
            return oInitList.Contains(p_sKey.ToUpper());
        }


        public List<string> AppendList
        {
            get { return oAppendList; }
            set { oAppendList = value; }
        }

        public bool IsComplex
        {
            get { return bIsComplex; }
            set { bIsComplex = value; }
        }

        public void Add(string p_sKey, string p_sValue)
        {
            oSimpleData.Add(p_sKey, p_sValue); 
        }

        //public void Add(string p_sKey)
        //{
        //    oSimpleData.Add(p_sKey);
        //}

        public void Add(string p_sKey, string p_sValue, ActionTypes eAction)
        {
            oSimpleData.Add(p_sKey, p_sValue);

            if(eAction== ActionTypes.Append)
            {
                oAppendList.Add(p_sKey.ToUpper());
            }
            else if (eAction == ActionTypes.Merge)
            {
                oMergeList.Add(p_sKey.ToUpper());
            }
            else if (eAction == ActionTypes.Ignore)
            {
                oIgnoreList.Add(p_sKey.ToUpper());
            }
            else if (eAction == ActionTypes.Init)
            {
                oInitList.Add(p_sKey.ToUpper());
            }
        }

        public void Remove(string p_sKey)
        {
            oSimpleData.Remove(p_sKey);
            oComplexData.Remove(p_sKey);
        }

        public void AddComplex(string p_sKey, object p_sAddtionalInfo)
        {
            oComplexData.Add(p_sKey, p_sAddtionalInfo);
            this.IsComplex = true;
        }

        public bool Exists(string p_sKey)
        {
            return (oSimpleData.Keys.Contains(p_sKey) 
                    || oComplexData.Keys.Contains (p_sKey));
        }

        public Dictionary<string, string> GetRaw()
        {
            return oSimpleData;
        }

        public Dictionary<string,object> GetRawComplex()
        {
            return oComplexData;
        }

        public string this[string p_sKey]
        {
            get 
            {
                return oSimpleData[p_sKey];
            }
            set 
            {
                oSimpleData[p_sKey] = value;
            }
        }

        public string this[int p_Index]
        {
            get 
            {
                return
                    oSimpleData.Where((n, i) => i == p_Index)
                    .Select(n => n.Value).Single();
            }
        }

        public override string ToString()
        {
            StringBuilder s_oBuilder = new StringBuilder();

            try
            {
                s_oBuilder.Append(System.Environment.NewLine);
                s_oBuilder.Append("-------------Parameter Values Start ---------------");
                foreach (var oParam in this.GetRaw())
                {
                    string sa = string.Format("Key:{0}  Value:{1}{2}", oParam.Key, oParam.Value, System.Environment.NewLine);
                    s_oBuilder.Append(sa);
                }
                s_oBuilder.Append(System.Environment.NewLine);
                s_oBuilder.Append("-------------Parameter Values End---------------");
            }
            catch { }

            return s_oBuilder.ToString();
        }
    }
}
