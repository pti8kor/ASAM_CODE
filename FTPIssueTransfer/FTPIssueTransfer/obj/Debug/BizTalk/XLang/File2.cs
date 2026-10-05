
#pragma warning disable 162

namespace FTPIssueTransfer.TransmitterRef.TransmitterService_
{

    [System.SerializableAttribute]
    sealed public class __FTPIssueTransfer_TransmitterRef_Reference_transmitterRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static FTPIssueTransfer.TransmitterRef.Reference.transmitterRequest _schema = new FTPIssueTransfer.TransmitterRef.Reference.transmitterRequest();

        public __FTPIssueTransfer_TransmitterRef_Reference_transmitterRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eRequest,
        "FTPIssueTransfer.TransmitterRef.TransmitterService.startTransmit",
        new System.Type[]{
            typeof(FTPIssueTransfer.TransmitterRef.Reference.transmitterRequest)
        },
        new string[]{
            "transmitterRequest"
        },
        new System.Type[]{
            typeof(__FTPIssueTransfer_TransmitterRef_Reference_transmitterRequest__)
        },
        0,
        @"http://www.bosch.com/edexas/asam/transmitter/services#transmitterRequest"
    )]
    [System.SerializableAttribute]
    sealed public class startTransmit_request : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __FTPIssueTransfer_TransmitterRef_Reference_transmitterRequest__ transmitterRequest;

        private void __CreatePartWrappers()
        {
            transmitterRequest = new __FTPIssueTransfer_TransmitterRef_Reference_transmitterRequest__(this, "transmitterRequest", 0);
            this.AddPart("transmitterRequest", 0, transmitterRequest);
        }

        public startTransmit_request(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __FTPIssueTransfer_TransmitterRef_Reference_transmitterResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static FTPIssueTransfer.TransmitterRef.Reference.transmitterResponse _schema = new FTPIssueTransfer.TransmitterRef.Reference.transmitterResponse();

        public __FTPIssueTransfer_TransmitterRef_Reference_transmitterResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eResponse,
        "FTPIssueTransfer.TransmitterRef.TransmitterService.startTransmit",
        new System.Type[]{
            typeof(FTPIssueTransfer.TransmitterRef.Reference.transmitterResponse)
        },
        new string[]{
            "startTransmitResult"
        },
        new System.Type[]{
            typeof(__FTPIssueTransfer_TransmitterRef_Reference_transmitterResponse__)
        },
        0,
        @"http://www.bosch.com/edexas/asam/transmitter/services#transmitterResponse"
    )]
    [System.SerializableAttribute]
    sealed public class startTransmit_response : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __FTPIssueTransfer_TransmitterRef_Reference_transmitterResponse__ startTransmitResult;

        private void __CreatePartWrappers()
        {
            startTransmitResult = new __FTPIssueTransfer_TransmitterRef_Reference_transmitterResponse__(this, "startTransmitResult", 0);
            this.AddPart("startTransmitResult", 0, startTransmitResult);
        }

        public startTransmit_response(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "startTransmit",
        new System.Type[]{
            typeof(FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_request), 
            typeof(FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_response)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [Microsoft.XLANGs.BaseTypes.WSDLProxyNameAttribute(typeof(FTPIssueTransfer.TransmitterRef.TransmitterService))]
    [System.SerializableAttribute]
    sealed public class TransmitterService : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public TransmitterService(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public TransmitterService(TransmitterService p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            TransmitterService p = new TransmitterService(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo startTransmit = new Microsoft.XLANGs.Core.OperationInfo
        (
            "startTransmit",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(TransmitterService),
            typeof(startTransmit_request),
            typeof(startTransmit_response),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "startTransmit" ] = startTransmit;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(true)]
    [Microsoft.XLANGs.BaseTypes.TargetXmlNamespaceAttribute("http://www.bosch.com/edexas/asam/transmitter/services")]
    sealed public class _MODULE_PROXY_ { }
}
