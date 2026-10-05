using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RB.ROCustomerInterfaceExportLibrary
{
    public class TransmitterResponse
    {
        public bool IsSuccess { get; set; }

        public string ResponseXml { get; set; }

        public string ErrorMessage { get; set; }
    }
}
