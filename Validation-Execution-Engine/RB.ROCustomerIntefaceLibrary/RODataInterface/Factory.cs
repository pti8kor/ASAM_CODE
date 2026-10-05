using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RB.ROCustomerIntefaceLibrary
{
    public enum ROAvailableDataInterfaces
    {
        OSLC, 
        CQ_API
    }

    public  enum  AvailableEvaluatorTypes
    {
       IMF,
       RO
    }

    public static class Factory
    {
        public static RODataInterface GetInterface(ROAvailableDataInterfaces p_sContext)
        {

            switch (p_sContext)
            {
                case ROAvailableDataInterfaces.OSLC:
                    {
                        return new RO_OSLC_DataInterface();
                        //return RO_OSLC_DataInterface.GetCurrentInstance();
                    }
                case ROAvailableDataInterfaces.CQ_API:
                    {
                        return new RO_CQAPI_DataInterface();
                        //return RO_CQAPI_DataInterface.GetCurrentInstance();
                    }
            }

            return null;
        }

        public static IEvaluator GetEvaluator(AvailableEvaluatorTypes p_eEvaluator)
        {
            switch (p_eEvaluator)
            {
                case AvailableEvaluatorTypes.IMF:
                    {
                        return new IMFEvaluator();
                        
                    }
                case AvailableEvaluatorTypes.RO:
                    {
                        return new ROEvaluator();
                        
                    }
            }

            throw new System.NotImplementedException();
        }
    }
}
