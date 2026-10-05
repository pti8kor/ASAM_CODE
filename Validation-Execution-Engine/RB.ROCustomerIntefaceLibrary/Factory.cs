using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace RB.ROCustomerIntefaceLibrary
{
    public enum ROAvailableDataInterfaces
    {
        OSLC, 
        CQ_API
    }



    public static class Factory
    {
        public static RODataInterface GetInterface(ROAvailableDataInterfaces p_sContext
            , string p_sExchangeFormat, string p_sExchangeProtocolId, string p_sSystem, string p_sattpath, Logger l_ologger)
        {

            switch (p_sContext)
            {
                case ROAvailableDataInterfaces.OSLC:
                    {
                        return new RO_OSLC_DataInterface(p_sSystem,p_sExchangeFormat,l_ologger);
                        //return RO_OSLC_DataInterface.GetCurrentInstance();
                    }
                case ROAvailableDataInterfaces.CQ_API:
                    {
                        return new RO_CQAPI_DataInterface(p_sExchangeFormat, p_sExchangeProtocolId, p_sSystem, p_sattpath, l_ologger);
                        //return RO_CQAPI_DataInterface.GetCurrentInstance();
                    }
            }

            return null;
        }


    }
}
