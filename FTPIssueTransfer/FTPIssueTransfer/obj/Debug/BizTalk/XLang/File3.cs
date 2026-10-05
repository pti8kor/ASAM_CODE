
#pragma warning disable 162

namespace FTPFileShift
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(FTPFileShift.__messagetype_FTPIssueTransfer_DEV_SingleFileShiftInformation)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class ReceiveImportResultPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public ReceiveImportResultPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public ReceiveImportResultPortType(ReceiveImportResultPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            ReceiveImportResultPortType p = new ReceiveImportResultPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(ReceiveImportResultPortType),
            typeof(__messagetype_FTPIssueTransfer_DEV_SingleFileShiftInformation),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(FTPFileShift.__messagetype_System_Xml_XmlDocument)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_ACK : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_ACK(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_ACK(PortType_ACK p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_ACK p = new PortType_ACK(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_ACK),
            typeof(__messagetype_System_Xml_XmlDocument),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(FTPFileShift.__messagetype_System_Xml_XmlDocument)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_ACK2 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_ACK2(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_ACK2(PortType_ACK2 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_ACK2 p = new PortType_ACK2(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_ACK2),
            typeof(__messagetype_System_Xml_XmlDocument),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(FTPFileShift.__messagetype_System_Xml_XmlDocument)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_1(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_1(PortType_1 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_1 p = new PortType_1(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_1),
            typeof(__messagetype_System_Xml_XmlDocument),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_request)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_2 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_2(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_2(PortType_2 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_2 p = new PortType_2(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_2),
            typeof(FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_request),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_response)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_3 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_3(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_3(PortType_3 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_3 p = new PortType_3(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_3),
            typeof(FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_response),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_request), 
            typeof(FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_response)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_4 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_4(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_4(PortType_4 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_4 p = new PortType_4(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(PortType_4),
            typeof(FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_request),
            typeof(FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_response),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_request)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_5 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_5(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_5(PortType_5 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_5 p = new PortType_5(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_5),
            typeof(FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_request),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_response)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_6 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_6(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_6(PortType_6 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_6 p = new PortType_6(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_6),
            typeof(FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_response),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_request)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_7 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_7(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_7(PortType_7 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_7 p = new PortType_7(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_7),
            typeof(FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_request),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(FTPIssueTransfer.__messagetype_FTPIssueTransfer_InitialTransmitterRequestSchema)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_8 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_8(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_8(PortType_8 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_8 p = new PortType_8(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_8),
            typeof(FTPIssueTransfer.__messagetype_FTPIssueTransfer_InitialTransmitterRequestSchema),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(FTPIssueTransfer.__messagetype_FTPIssueTransfer_InitialTransmitterRequestSchema)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_9 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_9(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_9(PortType_9 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_9 p = new PortType_9(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_9),
            typeof(FTPIssueTransfer.__messagetype_FTPIssueTransfer_InitialTransmitterRequestSchema),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 801 "D:\ASAM-IF-IMPORT\Import\960 - Sources\PTI8KOR\BTImportSoftware\FTPIssueTransfer\FTPIssueTransfer\FileShift.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "ReceiveImportResultPort", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eDynamic,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(FTPFileShift.ReceiveImportResultPortType),
            typeof(FTPFileShift.PortType_ACK),
            typeof(FTPFileShift.PortType_8),
            typeof(FTPFileShift.PortType_9),
            typeof(FTPFileShift.PortType_1)
        },
        new System.String[] {
            "ReceiveImportResultPort",
            "PortsndACK1",
            "TransmitterRequestSendPort",
            "TransmitterRequestCopyPort",
            "sndError"
        },
        new System.Type[] {
            null,
            null,
            null,
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class FileShift : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(FileShift));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static FileShift()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 1;
            _rootContext = new __FileShift_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public FileShift(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "FileShift", tracker)
        {
            ConstructorHelper();
        }

        public FileShift(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "FileShift")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>bbe59e99-d2c5-490b-b15b-221708df7622</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>1bb18933-1f9f-4f56-8b1f-d0be090b7fe2</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_ImportResult</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>b9cbc59d-0425-49ca-9b86-424802cce2f1</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>7096ad74-f0a9-4028-b627-012c74a0e8e9</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>SetLogger</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>9859b988-fdd3-4286-b0fd-84fdd25c1dcd</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ShiftFile</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>f149725d-d1cc-47ad-9388-ad4e601fe08c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Expression_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>63ce9f27-d47b-4ff3-9671-a97fa227870d</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Decide_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>9ed832f9-6f57-4ddf-97a0-8479878c8b06</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>e2b61a6b-9850-4ea0-837e-6010002e440a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>72d14793-ac58-4592-bd33-45f69d6ed0a9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMsgAck</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>2ae490ec-b21e-48a4-86df-dafecf348066</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>144b9e3f-16a7-4872-a8b0-2ea6a8cf48db</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>f95f9268-14f0-4fdc-bf62-3cd992cd7c59</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>setPortAddress</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>63bdfffd-2ad6-443a-a8df-56b3161a814a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>877b6a75-b888-4cb1-8bd5-72c53eaf9f8f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Sleep</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>f9a25805-2d3f-445f-8675-6d59d1a5fbdd</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Decide_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>b9bc45f9-1826-4381-91e2-665e32056ffd</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>285a97ac-24b5-4bb8-809d-bf83c149bf03</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructTxReq</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>9248d143-fa1c-4087-8e95-e1a05e1aaaf6</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>2a5d45dc-f276-4026-b65e-dee443636dba</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>ae9c067f-3f92-4a63-98ac-20dc476c44a7</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>50f95b09-0ceb-4f67-b402-cfa3b4a3af24</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ShiftACKFile</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>78e6976a-9bb4-4786-9a28-fd89b6ff504b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>44c24508-ed2e-4079-b4d6-438851e03aeb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>9e356cc7-4d38-4c18-9419-e86d5ad380cd</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>2fc053fc-2aae-40d0-8fcf-978c2ec6ff24</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>880170a8-8496-4492-9bb9-cad436a8b32c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>e01a6165-2d7e-4c60-b963-ac4b84136cc8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>664dacdc-0256-45e0-81ad-feb8c34d26da</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_8</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>8ca80e36-eaa0-4d3e-84d8-97b4e5d38b5d</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>c1681754-d9d9-4396-8745-78533d16eb61</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>SetmsgError</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>de5c94f3-e604-4506-843e-25423c370aff</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>b82d1adc-06db-478f-b677-9e8688aaadae</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>c9d662c7-c69f-4ea7-94b6-a3060b695a42</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>43fa5402-54f6-45c7-b900-20a368fcd497</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>d970e890-a2dd-450f-9dcc-036e9354661f</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>CloseLogger</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>e3a2f897-ae22-4b09-a718-b6913cde968f</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'FileShift'</ActionName><IsAtomic>0</IsAtomic><Line>801</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>835</Line><Position>22</Position><ShapeID>'1bb18933-1f9f-4f56-8b1f-d0be090b7fe2'</ShapeID>
<Messages>
	<MsgInfo><name>msgSingleFileImportResult</name><part>part</part><schema>FTPIssueTransfer_DEV.SingleFileShiftInformation</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>847</Line><Position>51</Position><ShapeID>'b9cbc59d-0425-49ca-9b86-424802cce2f1'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>849</Line><Position>24</Position><ShapeID>'7096ad74-f0a9-4028-b627-012c74a0e8e9'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>852</Line><Position>25</Position><ShapeID>'9859b988-fdd3-4286-b0fd-84fdd25c1dcd'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>884</Line><Position>51</Position><ShapeID>'f149725d-d1cc-47ad-9388-ad4e601fe08c'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>886</Line><Position>13</Position><ShapeID>'63ce9f27-d47b-4ff3-9671-a97fa227870d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>890</Line><Position>55</Position><ShapeID>'e2b61a6b-9850-4ea0-837e-6010002e440a'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>895</Line><Position>17</Position><ShapeID>'72d14793-ac58-4592-bd33-45f69d6ed0a9'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>918</Line><Position>29</Position><ShapeID>'f95f9268-14f0-4fdc-bf62-3cd992cd7c59'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>927</Line><Position>17</Position><ShapeID>'63bdfffd-2ad6-443a-a8df-56b3161a814a'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>929</Line><Position>55</Position><ShapeID>'877b6a75-b888-4cb1-8bd5-72c53eaf9f8f'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>946</Line><Position>17</Position><ShapeID>'f9a25805-2d3f-445f-8675-6d59d1a5fbdd'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>949</Line><Position>21</Position><ShapeID>'285a97ac-24b5-4bb8-809d-bf83c149bf03'</ShapeID>
<Messages>
	<MsgInfo><name>msgTransmitterREQ</name><part>part</part><schema>FTPIssueTransfer.InitialTransmitterRequestSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>967</Line><Position>59</Position><ShapeID>'50f95b09-0ceb-4f67-b402-cfa3b4a3af24'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>977</Line><Position>59</Position><ShapeID>'78e6976a-9bb4-4786-9a28-fd89b6ff504b'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>982</Line><Position>21</Position><ShapeID>'44c24508-ed2e-4079-b4d6-438851e03aeb'</ShapeID>
<Messages>
	<MsgInfo><name>msgTransmitterREQ</name><part>part</part><schema>FTPIssueTransfer.InitialTransmitterRequestSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>984</Line><Position>21</Position><ShapeID>'9e356cc7-4d38-4c18-9419-e86d5ad380cd'</ShapeID>
<Messages>
	<MsgInfo><name>msgTransmitterREQCopy</name><part>part</part><schema>FTPIssueTransfer.InitialTransmitterRequestSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>993</Line><Position>21</Position><ShapeID>'e01a6165-2d7e-4c60-b963-ac4b84136cc8'</ShapeID>
<Messages>
	<MsgInfo><name>msgTransmitterREQCopy</name><part>part</part><schema>FTPIssueTransfer.InitialTransmitterRequestSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>995</Line><Position>59</Position><ShapeID>'664dacdc-0256-45e0-81ad-feb8c34d26da'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1000</Line><Position>21</Position><ShapeID>'c1681754-d9d9-4396-8745-78533d16eb61'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1008</Line><Position>21</Position><ShapeID>'c9d662c7-c69f-4ea7-94b6-a3060b695a42'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1012</Line><Position>35</Position><ShapeID>'d970e890-a2dd-450f-9dcc-036e9354661f'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1016</Line><Position>51</Position><ShapeID>'e3a2f897-ae22-4b09-a718-b6913cde968f'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='778e2f67-10f4-4b61-8ee2-e9b8ab59f11a' LowerBound='1.1' HigherBound='308.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='FTPFileShift' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='28b16174-cb44-459f-8bb8-c1a6fc8a2252' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ReceiveImportResultPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='aa30eef4-d599-4263-8d6d-00de6ac6de6b' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='6c24b40c-2959-4bde-870b-26fafb39ab21' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.60'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer_DEV.SingleFileShiftInformation' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='2263e69a-91cf-42d7-9baa-c65dfb05eb40' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_ACK' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='d32c66fc-5d24-4611-8502-04676882593c' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='c35f51f3-719c-4777-8d42-389fc94dd38f' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='3400c978-8081-418d-9b00-c2172b9b1023' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_ACK2' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='35626aef-7bf8-461f-a581-f4bde967bacb' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='43bcc2a5-513c-4ee6-8e1d-e45eb880e5c0' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='a4c07bd5-e112-4ea1-8e5b-ff9926673d9c' ParentLink='Module_PortType' LowerBound='25.1' HigherBound='32.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='91c5958c-cc22-447e-8810-afd9079d4bae' ParentLink='PortType_OperationDeclaration' LowerBound='27.1' HigherBound='31.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='51cd180e-9bea-46ed-9063-7787d8169d14' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='29.13' HigherBound='29.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='99ace0a5-f475-4adf-aa12-41b11e8d9999' ParentLink='Module_PortType' LowerBound='32.1' HigherBound='39.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_2' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='c1429570-4749-4d0d-8484-c955b3869613' ParentLink='PortType_OperationDeclaration' LowerBound='34.1' HigherBound='38.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='19cc2667-d5d1-4241-917e-e18541a9f4d3' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='36.13' HigherBound='36.86'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='61585367-a356-41f2-a386-e57323c08954' ParentLink='Module_PortType' LowerBound='39.1' HigherBound='46.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_3' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='b7145c79-91db-4e06-87e5-40114d88d283' ParentLink='PortType_OperationDeclaration' LowerBound='41.1' HigherBound='45.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='3d944112-8917-45bd-881f-12994f2b3b0f' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='43.13' HigherBound='43.87'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='69afd710-b9ee-4a2c-825c-7abfaef6906d' ParentLink='Module_PortType' LowerBound='46.1' HigherBound='53.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_4' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='25ffb343-3eec-4280-8f41-2b9f9b939e52' ParentLink='PortType_OperationDeclaration' LowerBound='48.1' HigherBound='52.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='f3f99747-1797-4c5b-8368-1f911ffa1bdb' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='50.13' HigherBound='50.86'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='746f59ff-d269-494b-808c-ecf7e8a55115' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='50.88' HigherBound='50.162'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='6cca1bde-f167-4a7c-a0f1-03b536bf14ec' ParentLink='Module_PortType' LowerBound='53.1' HigherBound='60.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_5' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='716fe12f-ddb1-4e1c-8702-d062f0f302b9' ParentLink='PortType_OperationDeclaration' LowerBound='55.1' HigherBound='59.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='3392e617-3023-4571-ae8d-70da90b96c3b' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='57.13' HigherBound='57.86'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='327de6a6-63f1-402f-a24b-4aa74e7b4335' ParentLink='Module_PortType' LowerBound='60.1' HigherBound='67.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_6' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='7faedb8f-5e6c-4cdb-9b2a-17ac7e2494ee' ParentLink='PortType_OperationDeclaration' LowerBound='62.1' HigherBound='66.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='3ab9fa5a-140a-4bd2-926c-79e4172825b6' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='64.13' HigherBound='64.87'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='2aaacb72-287d-4e49-ae0e-82472771c621' ParentLink='Module_PortType' LowerBound='67.1' HigherBound='74.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_7' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='604d332a-3136-4bce-ab76-c70c5d0b088a' ParentLink='PortType_OperationDeclaration' LowerBound='69.1' HigherBound='73.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='9e42c8bb-08f9-498c-b48f-3952296ae5b8' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='71.13' HigherBound='71.86'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='6264a38a-4df0-4787-ba22-0dc45e4bfa6b' ParentLink='Module_PortType' LowerBound='74.1' HigherBound='81.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_8' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='c896c9ba-eaf9-4c23-83ad-d091827ca927' ParentLink='PortType_OperationDeclaration' LowerBound='76.1' HigherBound='80.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='92083815-8fa0-4df7-8e7b-ead5c791d305' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='78.13' HigherBound='78.61'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.InitialTransmitterRequestSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='403a1e46-a3bb-4186-9186-1b5d4920f7cc' ParentLink='Module_PortType' LowerBound='81.1' HigherBound='88.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_9' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='6cd46fcf-88f5-4a82-8336-4c1decad27c1' ParentLink='PortType_OperationDeclaration' LowerBound='83.1' HigherBound='87.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='71114050-e5fa-4188-ac0b-00ebba6ba38e' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='85.13' HigherBound='85.61'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.InitialTransmitterRequestSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='d2e65f81-fdaa-4ba1-92f1-cbf5d2e252af' ParentLink='Module_ServiceDeclaration' LowerBound='88.1' HigherBound='307.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='FileShift' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='6e1e6627-e107-4eec-89d5-e86905a6184c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='107.1' HigherBound='108.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Successfully downloaded filenames, given in lines.' />
                <om:Property Name='Name' Value='SuccFileNameList' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='17252e53-8c68-4cdf-a527-388163b2fdb5' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='108.1' HigherBound='109.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tmpStr1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='916207e1-9ed6-4ae6-b75a-13e740e83182' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='109.1' HigherBound='110.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='shiftResult' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='367fbe3e-747f-4843-85f2-fd9c983c0c7e' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='110.1' HigherBound='111.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='RB.BTLoggerLibrary.BTLogger' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ROBTLogger' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='4c467730-a245-44ad-be97-675bb3c5a36d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='111.1' HigherBound='112.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='RB.BTLoggerLibrary.Logger' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ROLogger' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='b4b34b78-b95e-4f7e-a84b-a95f63965cfc' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='112.1' HigherBound='113.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sACKFileName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='1e4eaa33-200a-4883-9b2a-2b64da1e9293' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='113.1' HigherBound='114.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sACKFileNameWO' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='9f0b2b99-dd77-41ab-9aab-f4f14437e184' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='114.1' HigherBound='115.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sFolderName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='d689e230-df61-4abb-aada-ed3af2217d88' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='115.1' HigherBound='116.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sTemp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='93eb846a-2338-4a6f-95fc-26278d573f5a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='116.1' HigherBound='117.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='bACKFileExists' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='32fe72b9-c3fa-4ba3-a9e7-0ce0017c8ebe' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='117.1' HigherBound='118.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='RB.FTPLibrary.FTPHandler' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FTPHandler1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='452303a1-d8da-4cb0-8f8f-736f2c23d7dc' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='118.1' HigherBound='119.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sDownloadHost' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='0da1e3d4-9e70-46c6-b67a-de9e6ef6f2e8' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='119.1' HigherBound='120.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='iDelayTime' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ae0190b7-8e5f-4d54-838d-318d8fa3ef3a' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='101.1' HigherBound='102.1'>
                <om:Property Name='Type' Value='FTPIssueTransfer_DEV.SingleFileShiftInformation' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgSingleFileImportResult' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='4470b280-b9cb-483d-a95b-dd2d01194cd7' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='102.1' HigherBound='103.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgACK' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='8ae06dde-fbb5-495c-96f5-e109a1f5ce13' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='103.1' HigherBound='104.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgError' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='6f5e5fc2-2970-4c09-a2dc-6ae01c2433b1' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='104.1' HigherBound='105.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgTxReq' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='b4052bff-01d8-44f4-bc55-f8b6284c0217' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='105.1' HigherBound='106.1'>
                <om:Property Name='Type' Value='FTPIssueTransfer.InitialTransmitterRequestSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgTransmitterREQCopy' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='6400aa11-9a1b-4d52-99e5-2c58a58307af' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='106.1' HigherBound='107.1'>
                <om:Property Name='Type' Value='FTPIssueTransfer.InitialTransmitterRequestSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgTransmitterREQ' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='bbe59e99-d2c5-490b-b15b-221708df7622' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='1bb18933-1f9f-4f56-8b1f-d0be090b7fe2' ParentLink='ServiceBody_Statement' LowerBound='122.1' HigherBound='134.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='ReceiveImportResultPort' />
                    <om:Property Name='MessageName' Value='msgSingleFileImportResult' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_ImportResult' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='b9cbc59d-0425-49ca-9b86-424802cce2f1' ParentLink='ServiceBody_Statement' LowerBound='134.1' HigherBound='136.1'>
                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;FILESHIFT&quot;,&quot;Inside fileshift orch&quot; );' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Expression_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='7096ad74-f0a9-4028-b627-012c74a0e8e9' ParentLink='ServiceBody_Statement' LowerBound='136.1' HigherBound='138.1'>
                    <om:Property Name='Expression' Value=' ROLogger  = ROBTLogger.GetLogger(msgSingleFileImportResult.InterfaceName,msgSingleFileImportResult.XProtID, &quot;Import&quot;);' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SetLogger' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='9859b988-fdd3-4286-b0fd-84fdd25c1dcd' ParentLink='ServiceBody_Statement' LowerBound='138.1' HigherBound='171.1'>
                    <om:Property Name='Expression' Value='&#xD;&#xA;FTPHandler1 = new RB.FTPLibrary.FTPHandler(msgSingleFileImportResult.InterfaceName, msgSingleFileImportResult.RQ1System);&#xD;&#xA;&#xD;&#xA;if(msgSingleFileImportResult.Mode == &quot;Automatic&quot;)&#xD;&#xA;{&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FILESHIFT for Automatic mode&quot; ,&#xD;&#xA;ROLogger);&#xD;&#xA;    FTPHandler1.GetDateTimeFolderBasedOnMode(msgSingleFileImportResult.DownloadTargetPath);&#xD;&#xA;}&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;FILESHIFT&quot;,&quot;checkstatus=&quot; +msgSingleFileImportResult.Status);&#xD;&#xA;//REUBK-1592 SingleFileShift&#xD;&#xA;&#xD;&#xA;//fetch next Filename to tmpStr1&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FILESHIFT - import status = &quot; + msgSingleFileImportResult.Status,&#xD;&#xA;ROLogger);&#xD;&#xA;&#xD;&#xA;SuccFileNameList = msgSingleFileImportResult.FileName;&#xD;&#xA;&#xD;&#xA;tmpStr1 = FTPHandler1.ReadStringLine(SuccFileNameList, 1);&#xD;&#xA;&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;callin shift source file&quot;,&#xD;&#xA;ROLogger);&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;FILESHIFT&quot;,&quot;call ShiftSourceFile&quot;);&#xD;&#xA;shiftResult = FTPHandler1.ShiftSourceFile(tmpStr1,msgSingleFileImportResult.XProtID,msgSingleFileImportResult.DownloadTargetPath,msgSingleFileImportResult.DownloadTime,msgSingleFileImportResult.Status);&#xD;&#xA;&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPShiftFile : ShiftSourceFileFile &lt;&quot; + tmpStr1 +&quot;&gt; &quot; + shiftResult,&#xD;&#xA;ROLogger);&#xD;&#xA;&#xD;&#xA;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ShiftFile' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='f149725d-d1cc-47ad-9388-ad4e601fe08c' ParentLink='ServiceBody_Statement' LowerBound='171.1' HigherBound='173.1'>
                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;FILESHIFT&quot;,&quot;TransactionID=&quot; +msgSingleFileImportResult.TransactionID);' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Expression_3' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Decision' OID='63ce9f27-d47b-4ff3-9671-a97fa227870d' ParentLink='ServiceBody_Statement' LowerBound='173.1' HigherBound='299.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Decide_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='DecisionBranch' OID='9ed832f9-6f57-4ddf-97a0-8479878c8b06' ParentLink='ReallyComplexStatement_Branch' LowerBound='174.13' HigherBound='299.1'>
                        <om:Property Name='Expression' Value='FTPHandler1.canShiftACK == &quot;1&quot; &amp;&amp; msgSingleFileImportResult.TransactionID != &quot;&quot; ' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Rule_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='e2b61a6b-9850-4ea0-837e-6010002e440a' ParentLink='ComplexStatement_Statement' LowerBound='176.1' HigherBound='182.1'>
                            <om:Property Name='Expression' Value='&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;FILESHIFT&quot;,&quot;construct ack msg&quot;);&#xD;&#xA;&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;start TransferACK&quot;,&#xD;&#xA;ROLogger);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Construct' OID='72d14793-ac58-4592-bd33-45f69d6ed0a9' ParentLink='ComplexStatement_Statement' LowerBound='182.1' HigherBound='205.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMsgAck' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageRef' OID='2ae490ec-b21e-48a4-86df-dafecf348066' ParentLink='Construct_MessageRef' LowerBound='183.27' HigherBound='183.33'>
                                <om:Property Name='Ref' Value='msgACK' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessageAssignment' OID='144b9e3f-16a7-4872-a8b0-2ea6a8cf48db' ParentLink='ComplexStatement_Statement' LowerBound='185.1' HigherBound='204.1'>
                                <om:Property Name='Expression' Value='//ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;inside set msgACK&quot;,ROLogger);&#xD;&#xA;&#xD;&#xA;msgACK = FTPHandler1.SetValuesForACK(msgSingleFileImportResult.TransactionID,msgSingleFileImportResult.StatusInfo,msgSingleFileImportResult.Status);&#xD;&#xA;&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;set SetTAFileName&quot;,&#xD;&#xA;ROLogger);&#xD;&#xA;&#xD;&#xA;sACKFileName = FTPHandler1.SetTAFileName(msgSingleFileImportResult.FileName, ROLogger);&#xD;&#xA;sACKFileNameWO = FTPHandler1.GetFileNameWithoutExtn(sACKFileName);&#xD;&#xA;&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;sACKFileName=&quot; +sACKFileName,&#xD;&#xA;ROLogger);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;//msgTxReq = FTPHandler1.FrameMsgACKREQ(msgACK,sACKFileName);&#xD;&#xA;//ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;set msgTxReq&quot;,ROLogger);&#xD;&#xA;//msgREQ.transmitterRequest = msgTxReq;&#xD;&#xA;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='MessageAssignment_1' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='f95f9268-14f0-4fdc-bf62-3cd992cd7c59' ParentLink='ComplexStatement_Statement' LowerBound='205.1' HigherBound='214.1'>
                            <om:Property Name='Expression' Value='sFolderName = FTPHandler1.GetFormattedDateTime(msgSingleFileImportResult.DownloadTime)+ &quot;_&quot;+ msgSingleFileImportResult.XProtID;&#xD;&#xA;sFolderName =&quot;D:\\ASAM-IF-IMPORT\\Import\\082 - TransferAcknowledgment\\&quot;+sFolderName;&#xD;&#xA;&#xD;&#xA;System.IO.Directory.CreateDirectory(sFolderName);&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmssffffff - }&quot;, System.DateTime.Now) + &quot;Framing dynamic port name&quot;,&#xD;&#xA;ROLogger);&#xD;&#xA;PortsndACK1(Microsoft.XLANGs.BaseTypes.Address) = &quot;file://&quot; + sFolderName + &quot;/&quot; + sACKFileName;&#xD;&#xA;//ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmssffffff - }&quot;, System.DateTime.Now) + &quot;Before dynamic port creation&quot;,ROLogger);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='setPortAddress' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Send' OID='63bdfffd-2ad6-443a-a8df-56b3161a814a' ParentLink='ComplexStatement_Statement' LowerBound='214.1' HigherBound='216.1'>
                            <om:Property Name='PortName' Value='PortsndACK1' />
                            <om:Property Name='MessageName' Value='msgACK' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='877b6a75-b888-4cb1-8bd5-72c53eaf9f8f' ParentLink='ComplexStatement_Statement' LowerBound='216.1' HigherBound='233.1'>
                            <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;FILESHIFT&quot;,&quot;after sending file to ACk folder&quot;);&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmssffffff - }&quot;, System.DateTime.Now) + &quot;After dynamic port creation&quot;,&#xD;&#xA;ROLogger);&#xD;&#xA;&#xD;&#xA;iDelayTime = System.Convert.ToInt32(FTPHandler1.ACKDelayTime);&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmssffffff - }&quot;, System.DateTime.Now) + &quot;Introducing delay time of &quot;+ iDelayTime.ToString() +&quot; millisec&quot;,&#xD;&#xA;ROLogger);&#xD;&#xA;System.Threading.Thread.Sleep(iDelayTime);&#xD;&#xA;&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmssffffff - }&quot;, System.DateTime.Now) + &quot;Checking if ACK file exists after delay time&quot;,&#xD;&#xA;ROLogger);&#xD;&#xA; &#xD;&#xA;bACKFileExists = FTPHandler1.CheckACKFileExists(msgSingleFileImportResult.XProtID,msgSingleFileImportResult.DownloadTime,sACKFileName);&#xD;&#xA;&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmssffffff - }&quot;, System.DateTime.Now) + &quot;bACKFileExists:&quot;+bACKFileExists.ToString(),&#xD;&#xA;ROLogger);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Sleep' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Decision' OID='f9a25805-2d3f-445f-8675-6d59d1a5fbdd' ParentLink='ComplexStatement_Statement' LowerBound='233.1' HigherBound='298.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Decide_2' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='DecisionBranch' OID='b9bc45f9-1826-4381-91e2-665e32056ffd' ParentLink='ReallyComplexStatement_Branch' LowerBound='234.17' HigherBound='285.1'>
                                <om:Property Name='Expression' Value='bACKFileExists == true' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Rule_1' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Construct' OID='285a97ac-24b5-4bb8-809d-bf83c149bf03' ParentLink='ComplexStatement_Statement' LowerBound='236.1' HigherBound='254.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='ConstructTxReq' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessageRef' OID='9248d143-fa1c-4087-8e95-e1a05e1aaaf6' ParentLink='Construct_MessageRef' LowerBound='237.31' HigherBound='237.39'>
                                        <om:Property Name='Ref' Value='msgTxReq' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessageRef' OID='2a5d45dc-f276-4026-b65e-dee443636dba' ParentLink='Construct_MessageRef' LowerBound='237.41' HigherBound='237.58'>
                                        <om:Property Name='Ref' Value='msgTransmitterREQ' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessageAssignment' OID='ae9c067f-3f92-4a63-98ac-20dc476c44a7' ParentLink='ComplexStatement_Statement' LowerBound='239.1' HigherBound='253.1'>
                                        <om:Property Name='Expression' Value='ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;Frame msgTxReq&quot;,ROLogger);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;//For Zip file transfer&#xD;&#xA;msgTxReq = FTPHandler1.FrameMsgACKREQ(sFolderName,sACKFileNameWO,msgSingleFileImportResult.RQ1System,msgSingleFileImportResult.InterfaceName,msgSingleFileImportResult.XProtID, ROLogger, msgSingleFileImportResult.Category);&#xD;&#xA;&#xD;&#xA;//For normal xml transfer&#xD;&#xA;//msgTxReq = FTPHandler1.FrameMsgACKREQ(msgACK,sACKFileName);&#xD;&#xA;&#xD;&#xA;//ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;Set msgTxReq&quot;,ROLogger);&#xD;&#xA;&#xD;&#xA;msgTransmitterREQ = msgTxReq;&#xD;&#xA;&#xD;&#xA;' />
                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                        <om:Property Name='Name' Value='MessageAssignment_1' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='VariableAssignment' OID='50f95b09-0ceb-4f67-b402-cfa3b4a3af24' ParentLink='ComplexStatement_Statement' LowerBound='254.1' HigherBound='264.1'>
                                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;FILESHIFT&quot;,&quot;call TransferACKFile&quot;);&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;callin TransferACKFile&quot;,&#xD;&#xA;ROLogger);&#xD;&#xA;shiftResult = FTPHandler1.TransferACKFile(sACKFileName,msgSingleFileImportResult.DownloadTime,msgSingleFileImportResult.XProtID);&#xD;&#xA;&#xD;&#xA;//ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot; aft callin TransferACKFile&quot; +shiftResult,ROLogger);&#xD;&#xA;&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPShiftFile : TransferACKFile for &lt;&quot; + sACKFileName +&quot;&gt; &quot; + shiftResult,&#xD;&#xA;ROLogger);&#xD;&#xA;' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='ShiftACKFile' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='VariableAssignment' OID='78e6976a-9bb4-4786-9a28-fd89b6ff504b' ParentLink='ComplexStatement_Statement' LowerBound='264.1' HigherBound='269.1'>
                                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;FILESHIFT&quot;,&quot;send wb servicerq to sendport&quot; );&#xD;&#xA;tmpStr1=msgSingleFileImportResult.TransactionID;&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPShiftFile : TransactionID is&quot; + tmpStr1,&#xD;&#xA;ROLogger);' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Expression_1' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Send' OID='44c24508-ed2e-4079-b4d6-438851e03aeb' ParentLink='ComplexStatement_Statement' LowerBound='269.1' HigherBound='271.1'>
                                    <om:Property Name='PortName' Value='TransmitterRequestSendPort' />
                                    <om:Property Name='MessageName' Value='msgTransmitterREQ' />
                                    <om:Property Name='OperationName' Value='Operation_1' />
                                    <om:Property Name='OperationMessageName' Value='Request' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Send_4' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Construct' OID='9e356cc7-4d38-4c18-9419-e86d5ad380cd' ParentLink='ComplexStatement_Statement' LowerBound='271.1' HigherBound='280.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='ConstructMessage_2' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessageRef' OID='2fc053fc-2aae-40d0-8fcf-978c2ec6ff24' ParentLink='Construct_MessageRef' LowerBound='272.31' HigherBound='272.52'>
                                        <om:Property Name='Ref' Value='msgTransmitterREQCopy' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessageAssignment' OID='880170a8-8496-4492-9bb9-cad436a8b32c' ParentLink='ComplexStatement_Statement' LowerBound='274.1' HigherBound='279.1'>
                                        <om:Property Name='Expression' Value='msgTransmitterREQCopy = msgTransmitterREQ;&#xD;&#xA;sDownloadHost = msgSingleFileImportResult.RQ1System;&#xD;&#xA;sDownloadHost = sDownloadHost.Substring(sDownloadHost.LastIndexOf(&quot;@&quot;)+1);&#xD;&#xA;msgTransmitterREQCopy(FILE.ReceivedFileName) = sDownloadHost + &quot;_&quot; + msgSingleFileImportResult.XProtID +&quot;_083_&quot; +&quot;TransmitterRequest_&quot; + sACKFileNameWO; &#xD;&#xA;' />
                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                        <om:Property Name='Name' Value='MessageAssignment_3' />
                                        <om:Property Name='Signal' Value='True' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Send' OID='e01a6165-2d7e-4c60-b963-ac4b84136cc8' ParentLink='ComplexStatement_Statement' LowerBound='280.1' HigherBound='282.1'>
                                    <om:Property Name='PortName' Value='TransmitterRequestCopyPort' />
                                    <om:Property Name='MessageName' Value='msgTransmitterREQCopy' />
                                    <om:Property Name='OperationName' Value='Operation_1' />
                                    <om:Property Name='OperationMessageName' Value='Request' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Send_3' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='VariableAssignment' OID='664dacdc-0256-45e0-81ad-feb8c34d26da' ParentLink='ComplexStatement_Statement' LowerBound='282.1' HigherBound='284.1'>
                                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;FILESHIFT&quot;,&quot;send wb servicerq to send port ends&quot; );' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Expression_8' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='8ca80e36-eaa0-4d3e-84d8-97b4e5d38b5d' ParentLink='ReallyComplexStatement_Branch'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Else' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='Construct' OID='c1681754-d9d9-4396-8745-78533d16eb61' ParentLink='ComplexStatement_Statement' LowerBound='287.1' HigherBound='295.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='SetmsgError' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessageAssignment' OID='de5c94f3-e604-4506-843e-25423c370aff' ParentLink='ComplexStatement_Statement' LowerBound='290.1' HigherBound='294.1'>
                                        <om:Property Name='Expression' Value='msgError = FTPHandler1.SetValuesForError(msgSingleFileImportResult.XProtID,msgSingleFileImportResult.FileName,&quot;File not transferred to Export share&quot;);&#xD;&#xA;sTemp = FTPHandler1.GetFileNameWithoutExtn(msgSingleFileImportResult.FileName);&#xD;&#xA;msgError(FILE.ReceivedFileName) = msgSingleFileImportResult.XProtID+ &quot;_&quot;+ sTemp;' />
                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                        <om:Property Name='Name' Value='MessageAssignment_2' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessageRef' OID='b82d1adc-06db-478f-b677-9e8688aaadae' ParentLink='Construct_MessageRef' LowerBound='288.31' HigherBound='288.39'>
                                        <om:Property Name='Ref' Value='msgError' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Send' OID='c9d662c7-c69f-4ea7-94b6-a3060b695a42' ParentLink='ComplexStatement_Statement' LowerBound='295.1' HigherBound='297.1'>
                                    <om:Property Name='PortName' Value='sndError' />
                                    <om:Property Name='MessageName' Value='msgError' />
                                    <om:Property Name='OperationName' Value='Operation_1' />
                                    <om:Property Name='OperationMessageName' Value='Request' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Send_2' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='43fa5402-54f6-45c7-b900-20a368fcd497' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='VariableAssignment' OID='d970e890-a2dd-450f-9dcc-036e9354661f' ParentLink='ServiceBody_Statement' LowerBound='299.1' HigherBound='303.1'>
                    <om:Property Name='Expression' Value='ROBTLogger.CloseLogger(ROLogger);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='CloseLogger' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='e3a2f897-ae22-4b09-a718-b6913cde968f' ParentLink='ServiceBody_Statement' LowerBound='303.1' HigherBound='305.1'>
                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;FILESHIFT&quot;,&quot;End fileshift orch&quot; );' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Expression_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='f64ee3ea-41d2-4047-8e2a-e0202d9a204b' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='91.1' HigherBound='93.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='FTPFileShift.ReceiveImportResultPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceiveImportResultPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='96766c21-8892-47b7-bd8c-a565a5208e69' ParentLink='PortDeclaration_CLRAttribute' LowerBound='91.1' HigherBound='92.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='8bf05034-19cf-49f7-9db1-ba6b4d4c87e8' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='93.1' HigherBound='95.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='22' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='FTPFileShift.PortType_ACK' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PortsndACK1' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='PhysicalBindingAttribute' OID='3d82cad9-b458-4ec8-b23a-a34927298406' ParentLink='PortDeclaration_CLRAttribute' LowerBound='93.1' HigherBound='94.1'>
                    <om:Property Name='InPipeline' Value='Microsoft.BizTalk.DefaultPipelines.XMLReceive' />
                    <om:Property Name='OutPipeline' Value='Microsoft.BizTalk.DefaultPipelines.XMLTransmit' />
                    <om:Property Name='TransportType' Value='HTTP' />
                    <om:Property Name='URI' Value='http://tempURI' />
                    <om:Property Name='IsDynamic' Value='True' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='155448c5-923f-4e4c-b15c-a396c57c3d06' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='95.1' HigherBound='97.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='FTPFileShift.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sndError' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='93e1533c-bbc5-4cde-97c7-bf6f85473f83' ParentLink='PortDeclaration_CLRAttribute' LowerBound='95.1' HigherBound='96.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='4170c834-f489-4be7-a3c6-7e8f53d0a8f2' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='97.1' HigherBound='99.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='100' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='FTPFileShift.PortType_8' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TransmitterRequestSendPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='6559e003-bbe7-4bc8-a766-e5f45c36506c' ParentLink='PortDeclaration_CLRAttribute' LowerBound='97.1' HigherBound='98.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='399d2487-4091-4081-aeb5-009e7e67b891' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='99.1' HigherBound='101.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='115' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='FTPFileShift.PortType_9' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TransmitterRequestCopyPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='d1562d13-66f9-42c0-b455-857c07750251' ParentLink='PortDeclaration_CLRAttribute' LowerBound='99.1' HigherBound='100.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __FileShift_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __FileShift_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "FileShift")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                FileShift __svc__ = (FileShift)_service;
                __FileShift_root_0 __ctx0__ = (__FileShift_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.TransmitterRequestCopyPort != null)
                {
                    __svc__.TransmitterRequestCopyPort.Close(this, null);
                    __svc__.TransmitterRequestCopyPort = null;
                }
                if (__svc__.TransmitterRequestSendPort != null)
                {
                    __svc__.TransmitterRequestSendPort.Close(this, null);
                    __svc__.TransmitterRequestSendPort = null;
                }
                if (__svc__.ReceiveImportResultPort != null)
                {
                    __svc__.ReceiveImportResultPort.Close(this, null);
                    __svc__.ReceiveImportResultPort = null;
                }
                if (__svc__.sndError != null)
                {
                    __svc__.sndError.Close(this, null);
                    __svc__.sndError = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __FileShift_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __FileShift_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "FileShift")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                FileShift __svc__ = (FileShift)_service;
                __FileShift_1 __ctx1__ = (__FileShift_1)(__svc__._stateMgrs[1]);
                __FileShift_root_0 __ctx0__ = (__FileShift_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.PortsndACK1 != null)
                {
                    __svc__.PortsndACK1.Close(this, null);
                    __svc__.PortsndACK1 = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__FTPHandler1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__sDownloadHost = null;
                if (__ctx1__ != null && __ctx1__.__msgACK != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgACK);
                    __ctx1__.__msgACK = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__sACKFileName = null;
                if (__ctx1__ != null)
                    __ctx1__.__ROLogger = null;
                if (__ctx1__ != null && __ctx1__.__msgTransmitterREQCopy != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgTransmitterREQCopy);
                    __ctx1__.__msgTransmitterREQCopy = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgTransmitterREQ != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgTransmitterREQ);
                    __ctx1__.__msgTransmitterREQ = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__SuccFileNameList = null;
                if (__ctx1__ != null)
                    __ctx1__.__shiftResult = null;
                if (__ctx1__ != null && __ctx1__.__msgSingleFileImportResult != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSingleFileImportResult);
                    __ctx1__.__msgSingleFileImportResult = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__ROBTLogger = null;
                if (__ctx1__ != null)
                    __ctx1__.__sTemp = null;
                if (__ctx1__ != null && __ctx1__.__msgError != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgError);
                    __ctx1__.__msgError = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgTxReq != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgTxReq);
                    __ctx1__.__msgTxReq = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__tmpStr1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__sACKFileNameWO = null;
                if (__ctx1__ != null)
                    __ctx1__.__sFolderName = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgSingleFileImportResult")]
            public __messagetype_FTPIssueTransfer_DEV_SingleFileShiftInformation __msgSingleFileImportResult;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgACK")]
            public __messagetype_System_Xml_XmlDocument __msgACK;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgError")]
            public __messagetype_System_Xml_XmlDocument __msgError;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgTxReq")]
            public __messagetype_System_Xml_XmlDocument __msgTxReq;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgTransmitterREQCopy")]
            public FTPIssueTransfer.__messagetype_FTPIssueTransfer_InitialTransmitterRequestSchema __msgTransmitterREQCopy;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgTransmitterREQ")]
            public FTPIssueTransfer.__messagetype_FTPIssueTransfer_InitialTransmitterRequestSchema __msgTransmitterREQ;
            [Microsoft.XLANGs.Core.UserVariableAttribute("SuccFileNameList")]
            internal System.String __SuccFileNameList;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tmpStr1")]
            internal System.String __tmpStr1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("shiftResult")]
            internal System.String __shiftResult;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ROBTLogger")]
            internal RB.BTLoggerLibrary.BTLogger __ROBTLogger;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ROLogger")]
            internal RB.BTLoggerLibrary.Logger __ROLogger;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sACKFileName")]
            internal System.String __sACKFileName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sACKFileNameWO")]
            internal System.String __sACKFileNameWO;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sFolderName")]
            internal System.String __sFolderName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sTemp")]
            internal System.String __sTemp;
            [Microsoft.XLANGs.Core.UserVariableAttribute("bACKFileExists")]
            internal System.Boolean __bACKFileExists;
            [Microsoft.XLANGs.Core.UserVariableAttribute("FTPHandler1")]
            internal RB.FTPLibrary.FTPHandler __FTPHandler1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sDownloadHost")]
            internal System.String __sDownloadHost;
            [Microsoft.XLANGs.Core.UserVariableAttribute("iDelayTime")]
            internal System.Int32 __iDelayTime;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("ReceiveImportResultPort")]
        internal ReceiveImportResultPortType ReceiveImportResultPort;
        [Microsoft.XLANGs.BaseTypes.PhysicalBindingAttribute(typeof(Microsoft.BizTalk.DefaultPipelines.XMLTransmit))]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eDynamic
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("PortsndACK1")]
        internal PortType_ACK PortsndACK1;  // lock index = 0
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("TransmitterRequestSendPort")]
        internal PortType_8 TransmitterRequestSendPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("TransmitterRequestCopyPort")]
        internal PortType_9 TransmitterRequestCopyPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("sndError")]
        internal PortType_1 sndError;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ReceiveImportResultPortType.Operation_1},
                                               typeof(FileShift).GetField("ReceiveImportResultPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(FileShift), "ReceiveImportResultPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_ACK.Operation_1},
                                               typeof(FileShift).GetField("PortsndACK1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               true,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(FileShift), "PortsndACK1"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_8.Operation_1},
                                               typeof(FileShift).GetField("TransmitterRequestSendPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(FileShift), "TransmitterRequestSendPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_9.Operation_1},
                                               typeof(FileShift).GetField("TransmitterRequestCopyPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(FileShift), "TransmitterRequestCopyPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_1.Operation_1},
                                               typeof(FileShift).GetField("sndError", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(FileShift), "sndError"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                h[_portInfo[2].Name] = _portInfo[2];
                h[_portInfo[3].Name] = _portInfo[3];
                h[_portInfo[4].Name] = _portInfo[4];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "1bb18933-1f9f-4f56-8b1f-d0be090b7fe2", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "1bb18933-1f9f-4f56-8b1f-d0be090b7fe2", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "b9cbc59d-0425-49ca-9b86-424802cce2f1", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "b9cbc59d-0425-49ca-9b86-424802cce2f1", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "7096ad74-f0a9-4028-b627-012c74a0e8e9", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "7096ad74-f0a9-4028-b627-012c74a0e8e9", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "9859b988-fdd3-4286-b0fd-84fdd25c1dcd", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "9859b988-fdd3-4286-b0fd-84fdd25c1dcd", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "f149725d-d1cc-47ad-9388-ad4e601fe08c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "f149725d-d1cc-47ad-9388-ad4e601fe08c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "63ce9f27-d47b-4ff3-9671-a97fa227870d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "e2b61a6b-9850-4ea0-837e-6010002e440a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "e2b61a6b-9850-4ea0-837e-6010002e440a", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "72d14793-ac58-4592-bd33-45f69d6ed0a9", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "72d14793-ac58-4592-bd33-45f69d6ed0a9", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "f95f9268-14f0-4fdc-bf62-3cd992cd7c59", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "f95f9268-14f0-4fdc-bf62-3cd992cd7c59", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "63bdfffd-2ad6-443a-a8df-56b3161a814a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "63bdfffd-2ad6-443a-a8df-56b3161a814a", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "877b6a75-b888-4cb1-8bd5-72c53eaf9f8f", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "877b6a75-b888-4cb1-8bd5-72c53eaf9f8f", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "f9a25805-2d3f-445f-8675-6d59d1a5fbdd", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "285a97ac-24b5-4bb8-809d-bf83c149bf03", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "285a97ac-24b5-4bb8-809d-bf83c149bf03", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "50f95b09-0ceb-4f67-b402-cfa3b4a3af24", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "50f95b09-0ceb-4f67-b402-cfa3b4a3af24", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "78e6976a-9bb4-4786-9a28-fd89b6ff504b", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "78e6976a-9bb4-4786-9a28-fd89b6ff504b", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(30, "44c24508-ed2e-4079-b4d6-438851e03aeb", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(31, "44c24508-ed2e-4079-b4d6-438851e03aeb", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(32, "9e356cc7-4d38-4c18-9419-e86d5ad380cd", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(33, "9e356cc7-4d38-4c18-9419-e86d5ad380cd", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(34, "e01a6165-2d7e-4c60-b963-ac4b84136cc8", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(35, "e01a6165-2d7e-4c60-b963-ac4b84136cc8", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(36, "664dacdc-0256-45e0-81ad-feb8c34d26da", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(37, "664dacdc-0256-45e0-81ad-feb8c34d26da", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(38, "c1681754-d9d9-4396-8745-78533d16eb61", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(39, "c1681754-d9d9-4396-8745-78533d16eb61", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(40, "c9d662c7-c69f-4ea7-94b6-a3060b695a42", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(41, "c9d662c7-c69f-4ea7-94b6-a3060b695a42", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(42, "f9a25805-2d3f-445f-8675-6d59d1a5fbdd", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(43, "63ce9f27-d47b-4ff3-9671-a97fa227870d", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(44, "d970e890-a2dd-450f-9dcc-036e9354661f", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(45, "d970e890-a2dd-450f-9dcc-036e9354661f", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(46, "e3a2f897-ae22-4b09-a718-b6913cde968f", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(47, "e3a2f897-ae22-4b09-a718-b6913cde968f", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,2,2,2,2,2,4,4,5,6,6,7,8,8,9,9,9,9,9,9,9,9,9,9,9,9,9,9,10,10,11,12,12,13,13,14,14,15,15,16,17,17,18,18,18,18,18,19,19,19,20,21,21,22,22,22,22,22,22,22,22,23,23,24,24,25,26,26,27,27,27,27,28,28,29,29,29,30,30,30,31,32,32,33,34,34,34,35,36,36,37,23,38,38,39,40,40,40,41,42,43,44,44,45,46,46,47,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __FileShift_1 __ctx1__ = (__FileShift_1)_stateMgrs[1];
            __FileShift_root_0 __ctx0__ = (__FileShift_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                ReceiveImportResultPort = new ReceiveImportResultPortType(0, this);
                PortsndACK1 = new PortType_ACK(1, this);
                sndError = new PortType_1(4, this);
                TransmitterRequestSendPort = new PortType_8(2, this);
                TransmitterRequestCopyPort = new PortType_9(3, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], ReceiveImportResultPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __FileShift_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __FileShift_1 __ctx1__ = (__FileShift_1)_stateMgrs[1];
            __FileShift_root_0 __ctx0__ = (__FileShift_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__SuccFileNameList = default(System.String);
                __ctx1__.__tmpStr1 = default(System.String);
                __ctx1__.__shiftResult = default(System.String);
                __ctx1__.__ROBTLogger = default(RB.BTLoggerLibrary.BTLogger);
                __ctx1__.__ROLogger = default(RB.BTLoggerLibrary.Logger);
                __ctx1__.__sACKFileName = default(System.String);
                __ctx1__.__sACKFileNameWO = default(System.String);
                __ctx1__.__sFolderName = default(System.String);
                __ctx1__.__sTemp = default(System.String);
                __ctx1__.__bACKFileExists = default(System.Boolean);
                __ctx1__.__FTPHandler1 = default(RB.FTPLibrary.FTPHandler);
                __ctx1__.__sDownloadHost = default(System.String);
                __ctx1__.__iDelayTime = default(System.Int32);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!ReceiveImportResultPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgSingleFileImportResult != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgSingleFileImportResult);
                __ctx1__.__msgSingleFileImportResult = new __messagetype_FTPIssueTransfer_DEV_SingleFileShiftInformation("msgSingleFileImportResult", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgSingleFileImportResult);
                ReceiveImportResultPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgSingleFileImportResult, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (ReceiveImportResultPort != null)
                {
                    ReceiveImportResultPort.Close(__ctx1__, __seg__);
                    ReceiveImportResultPort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgSingleFileImportResult);
                    __edata.PortName = @"ReceiveImportResultPort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__SuccFileNameList = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__tmpStr1 = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__shiftResult = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__ROBTLogger = new RB.BTLoggerLibrary.BTLogger();
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__sACKFileName = "";
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__sACKFileNameWO = "";
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__sFolderName = "";
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__sTemp = "";
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __ctx1__.__bACKFileExists = true;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.__sDownloadHost = "";
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                System.Diagnostics.EventLog.WriteEntry("FILESHIFT", "Inside fileshift orch");
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                __ctx1__.__ROLogger = __ctx1__.__ROBTLogger.GetLogger((System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("InterfaceName"), (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("XProtID"), "Import");
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                __ctx1__.__FTPHandler1 = new RB.FTPLibrary.FTPHandler((System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("InterfaceName"), (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("RQ1System"));
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                __condition__ = (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("Mode") == "Automatic";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 28;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FILESHIFT for Automatic mode", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                __ctx1__.__FTPHandler1.GetDateTimeFolderBasedOnMode((System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("DownloadTargetPath"));
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                System.Diagnostics.EventLog.WriteEntry("FILESHIFT", "checkstatus=" + (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("Status"));
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FILESHIFT - import status = " + (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("Status"), __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                __ctx1__.__SuccFileNameList = (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("FileName");
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                __ctx1__.__tmpStr1 = __ctx1__.__FTPHandler1.ReadStringLine(__ctx1__.__SuccFileNameList, 1);
                if (__ctx1__ != null)
                    __ctx1__.__SuccFileNameList = null;
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "callin shift source file", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 34;
            case 34:
                System.Diagnostics.EventLog.WriteEntry("FILESHIFT", "call ShiftSourceFile");
                if ( !PostProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 35;
            case 35:
                __ctx1__.__shiftResult = __ctx1__.__FTPHandler1.ShiftSourceFile(__ctx1__.__tmpStr1, (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("XProtID"), (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("DownloadTargetPath"), (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("DownloadTime"), (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("Status"));
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 36:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPShiftFile : ShiftSourceFileFile <" + __ctx1__.__tmpStr1 + "> " + __ctx1__.__shiftResult, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 37;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 38;
            case 38:
                System.Diagnostics.EventLog.WriteEntry("FILESHIFT", "TransactionID=" + (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("TransactionID"));
                if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 40;
            case 40:
                if ( !PreProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 41;
            case 41:
                __condition__ = __ctx1__.__FTPHandler1.canShiftACK == "1" && (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("TransactionID") != "";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 109 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 109;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 42;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 43;
            case 43:
                System.Diagnostics.EventLog.WriteEntry("FILESHIFT", "construct ack msg");
                if ( !PostProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 44;
            case 44:
                if ( !PreProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 45;
            case 45:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "start TransferACK", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 46;
            case 46:
                if ( !PreProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 47;
            case 47:
                {
                    __messagetype_System_Xml_XmlDocument __msgACK = new __messagetype_System_Xml_XmlDocument("msgACK", __ctx1__);

                    __msgACK.part.LoadFrom(__ctx1__.__FTPHandler1.SetValuesForACK((System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("TransactionID"), (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("StatusInfo"), (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("Status")));
                    __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "set SetTAFileName", __ctx1__.__ROLogger);
                    __ctx1__.__sACKFileName = __ctx1__.__FTPHandler1.SetTAFileName((System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("FileName"), __ctx1__.__ROLogger);
                    __ctx1__.__sACKFileNameWO = __ctx1__.__FTPHandler1.GetFileNameWithoutExtn(__ctx1__.__sACKFileName);
                    __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "sACKFileName=" + __ctx1__.__sACKFileName, __ctx1__.__ROLogger);

                    if (__ctx1__.__msgACK != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgACK);
                    __ctx1__.__msgACK = __msgACK;
                    __ctx1__.RefMessage(__ctx1__.__msgACK);
                }
                __ctx1__.__msgACK.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 48;
            case 48:
                if ( !PreProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgACK);
                    Tracker.FireEvent(__eventLocations[16],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 49;
            case 49:
                if ( !PreProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 50;
            case 50:
                __ctx1__.__sFolderName = __ctx1__.__FTPHandler1.GetFormattedDateTime((System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("DownloadTime")) + "_" + (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("XProtID");
                if ( !PostProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 51;
            case 51:
                if ( !PreProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 52;
            case 52:
                __ctx1__.__sFolderName = "D:\\ASAM-IF-IMPORT\\Import\\082 - TransferAcknowledgment\\" + __ctx1__.__sFolderName;
                if ( !PostProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 53;
            case 53:
                System.IO.Directory.CreateDirectory(__ctx1__.__sFolderName);
                if ( !PostProgressInc( __seg__, __ctx__, 54 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 54;
            case 54:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmssffffff - }", System.DateTime.Now) + "Framing dynamic port name", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 55 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 55;
            case 55:
                PortsndACK1.SetPropertyValue(typeof(Microsoft.XLANGs.BaseTypes.Address), "file://" + __ctx1__.__sFolderName + "/" + __ctx1__.__sACKFileName);
                if ( !PostProgressInc( __seg__, __ctx__, 56 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 56;
            case 56:
                if ( !PreProgressInc( __seg__, __ctx__, 57 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 57;
            case 57:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 58 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 58;
            case 58:
                if ( !PreProgressInc( __seg__, __ctx__, 59 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                PortsndACK1.SendMessage(0, __ctx1__.__msgACK, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 59;
            case 59:
                if ( !PreProgressInc( __seg__, __ctx__, 60 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgACK);
                    __edata.PortName = @"PortsndACK1";
                    Tracker.FireEvent(__eventLocations[20],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgACK != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgACK);
                    __ctx1__.__msgACK = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 60;
            case 60:
                if ( !PreProgressInc( __seg__, __ctx__, 61 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 61;
            case 61:
                System.Diagnostics.EventLog.WriteEntry("FILESHIFT", "after sending file to ACk folder");
                if ( !PostProgressInc( __seg__, __ctx__, 62 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 62;
            case 62:
                if ( !PreProgressInc( __seg__, __ctx__, 63 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 63;
            case 63:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmssffffff - }", System.DateTime.Now) + "After dynamic port creation", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 64 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 64;
            case 64:
                __ctx1__.__iDelayTime = System.Convert.ToInt32(__ctx1__.__FTPHandler1.ACKDelayTime);
                if ( !PostProgressInc( __seg__, __ctx__, 65 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 65;
            case 65:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmssffffff - }", System.DateTime.Now) + "Introducing delay time of " + __ctx1__.__iDelayTime.ToString() + " millisec", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 66 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 66;
            case 66:
                System.Threading.Thread.Sleep(__ctx1__.__iDelayTime);
                if ( !PostProgressInc( __seg__, __ctx__, 67 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 67;
            case 67:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmssffffff - }", System.DateTime.Now) + "Checking if ACK file exists after delay time", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 68 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 68;
            case 68:
                __ctx1__.__bACKFileExists = __ctx1__.__FTPHandler1.CheckACKFileExists((System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("XProtID"), (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("DownloadTime"), __ctx1__.__sACKFileName);
                if ( !PostProgressInc( __seg__, __ctx__, 69 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 69;
            case 69:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmssffffff - }", System.DateTime.Now) + "bACKFileExists:" + __ctx1__.__bACKFileExists.ToString(), __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 70 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 70;
            case 70:
                if ( !PreProgressInc( __seg__, __ctx__, 71 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[23],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 71;
            case 71:
                __condition__ = __ctx1__.__bACKFileExists;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 101 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 101;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 72 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 72;
            case 72:
                if ( !PreProgressInc( __seg__, __ctx__, 73 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 73;
            case 73:
                {
                    __messagetype_System_Xml_XmlDocument __msgTxReq = new __messagetype_System_Xml_XmlDocument("msgTxReq", __ctx1__);
                    FTPIssueTransfer.__messagetype_FTPIssueTransfer_InitialTransmitterRequestSchema __msgTransmitterREQ = new FTPIssueTransfer.__messagetype_FTPIssueTransfer_InitialTransmitterRequestSchema("msgTransmitterREQ", __ctx1__);

                    __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "Frame msgTxReq", __ctx1__.__ROLogger);
                    __msgTxReq.part.LoadFrom(__ctx1__.__FTPHandler1.FrameMsgACKREQ(__ctx1__.__sFolderName, __ctx1__.__sACKFileNameWO, (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("RQ1System"), (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("InterfaceName"), (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("XProtID"), __ctx1__.__ROLogger, (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("Category")));
                    __msgTransmitterREQ.CopyFrom(__msgTxReq);

                    if (__ctx1__.__msgTxReq != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgTxReq);
                    __ctx1__.__msgTxReq = __msgTxReq;
                    __ctx1__.RefMessage(__ctx1__.__msgTxReq);
                    if (__ctx1__.__msgTransmitterREQ != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgTransmitterREQ);
                    __ctx1__.__msgTransmitterREQ = __msgTransmitterREQ;
                    __ctx1__.RefMessage(__ctx1__.__msgTransmitterREQ);
                }
                __ctx1__.__msgTxReq.ConstructionCompleteEvent(false);
                __ctx1__.__msgTransmitterREQ.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 74 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 74;
            case 74:
                if ( !PreProgressInc( __seg__, __ctx__, 75 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgTxReq);
                    __edata.Messages.Add(__ctx1__.__msgTransmitterREQ);
                    Tracker.FireEvent(__eventLocations[25],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgTxReq != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgTxReq);
                    __ctx1__.__msgTxReq = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 75;
            case 75:
                if ( !PreProgressInc( __seg__, __ctx__, 76 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[26],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 76;
            case 76:
                System.Diagnostics.EventLog.WriteEntry("FILESHIFT", "call TransferACKFile");
                if ( !PostProgressInc( __seg__, __ctx__, 77 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 77;
            case 77:
                if ( !PreProgressInc( __seg__, __ctx__, 78 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[27],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 78;
            case 78:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "callin TransferACKFile", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 79 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 79;
            case 79:
                __ctx1__.__shiftResult = __ctx1__.__FTPHandler1.TransferACKFile(__ctx1__.__sACKFileName, (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("DownloadTime"), (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("XProtID"));
                if ( !PostProgressInc( __seg__, __ctx__, 80 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 80;
            case 80:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPShiftFile : TransferACKFile for <" + __ctx1__.__sACKFileName + "> " + __ctx1__.__shiftResult, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 81 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 81;
            case 81:
                if ( !PreProgressInc( __seg__, __ctx__, 82 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[28],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 82;
            case 82:
                System.Diagnostics.EventLog.WriteEntry("FILESHIFT", "send wb servicerq to sendport");
                if ( !PostProgressInc( __seg__, __ctx__, 83 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 83;
            case 83:
                if ( !PreProgressInc( __seg__, __ctx__, 84 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[29],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 84;
            case 84:
                __ctx1__.__tmpStr1 = (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("TransactionID");
                if ( !PostProgressInc( __seg__, __ctx__, 85 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 85;
            case 85:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPShiftFile : TransactionID is" + __ctx1__.__tmpStr1, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 86 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 86;
            case 86:
                if ( !PreProgressInc( __seg__, __ctx__, 87 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[30],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 87;
            case 87:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 88 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 88;
            case 88:
                if ( !PreProgressInc( __seg__, __ctx__, 89 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                TransmitterRequestSendPort.SendMessage(0, __ctx1__.__msgTransmitterREQ, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 89;
            case 89:
                if ( !PreProgressInc( __seg__, __ctx__, 90 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgTransmitterREQ);
                    __edata.PortName = @"TransmitterRequestSendPort";
                    Tracker.FireEvent(__eventLocations[31],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 90;
            case 90:
                if ( !PreProgressInc( __seg__, __ctx__, 91 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[32],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 91;
            case 91:
                {
                    FTPIssueTransfer.__messagetype_FTPIssueTransfer_InitialTransmitterRequestSchema __msgTransmitterREQCopy = new FTPIssueTransfer.__messagetype_FTPIssueTransfer_InitialTransmitterRequestSchema("msgTransmitterREQCopy", __ctx1__);

                    __msgTransmitterREQCopy.CopyFrom(__ctx1__.__msgTransmitterREQ);
                    if (__ctx1__ != null && __ctx1__.__msgTransmitterREQ != null)
                    {
                        __ctx1__.UnrefMessage(__ctx1__.__msgTransmitterREQ);
                        __ctx1__.__msgTransmitterREQ = null;
                    }
                    __ctx1__.__sDownloadHost = (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("RQ1System");
                    __ctx1__.__sDownloadHost = __ctx1__.__sDownloadHost.Substring(__ctx1__.__sDownloadHost.LastIndexOf("@") + 1);
                    __msgTransmitterREQCopy.SetPropertyValue(typeof(FILE.ReceivedFileName), __ctx1__.__sDownloadHost + "_" + (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("XProtID") + "_083_" + "TransmitterRequest_" + __ctx1__.__sACKFileNameWO);

                    if (__ctx1__.__msgTransmitterREQCopy != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgTransmitterREQCopy);
                    __ctx1__.__msgTransmitterREQCopy = __msgTransmitterREQCopy;
                    __ctx1__.RefMessage(__ctx1__.__msgTransmitterREQCopy);
                }
                __ctx1__.__msgTransmitterREQCopy.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 92 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 92;
            case 92:
                if ( !PreProgressInc( __seg__, __ctx__, 93 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgTransmitterREQCopy);
                    Tracker.FireEvent(__eventLocations[33],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 93;
            case 93:
                if ( !PreProgressInc( __seg__, __ctx__, 94 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[34],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 94;
            case 94:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 95 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 95;
            case 95:
                if ( !PreProgressInc( __seg__, __ctx__, 96 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                TransmitterRequestCopyPort.SendMessage(0, __ctx1__.__msgTransmitterREQCopy, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 96;
            case 96:
                if ( !PreProgressInc( __seg__, __ctx__, 97 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgTransmitterREQCopy);
                    __edata.PortName = @"TransmitterRequestCopyPort";
                    Tracker.FireEvent(__eventLocations[35],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgTransmitterREQCopy != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgTransmitterREQCopy);
                    __ctx1__.__msgTransmitterREQCopy = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 97;
            case 97:
                if ( !PreProgressInc( __seg__, __ctx__, 98 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[36],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 98;
            case 98:
                System.Diagnostics.EventLog.WriteEntry("FILESHIFT", "send wb servicerq to send port ends");
                if ( !PostProgressInc( __seg__, __ctx__, 99 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 99;
            case 99:
                if ( !PreProgressInc( __seg__, __ctx__, 100 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[37],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 100;
            case 100:
                if ( !PostProgressInc( __seg__, __ctx__, 108 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 108;
            case 101:
                if ( !PreProgressInc( __seg__, __ctx__, 102 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[38],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 102;
            case 102:
                {
                    __messagetype_System_Xml_XmlDocument __msgError = new __messagetype_System_Xml_XmlDocument("msgError", __ctx1__);

                    __msgError.part.LoadFrom(__ctx1__.__FTPHandler1.SetValuesForError((System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("XProtID"), (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("FileName"), "File not transferred to Export share"));
                    __ctx1__.__sTemp = __ctx1__.__FTPHandler1.GetFileNameWithoutExtn((System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("FileName"));
                    __msgError.SetPropertyValue(typeof(FILE.ReceivedFileName), (System.String)__ctx1__.__msgSingleFileImportResult.part.GetDistinguishedField("XProtID") + "_" + __ctx1__.__sTemp);

                    if (__ctx1__.__msgError != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgError);
                    __ctx1__.__msgError = __msgError;
                    __ctx1__.RefMessage(__ctx1__.__msgError);
                }
                __ctx1__.__msgError.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 103 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 103;
            case 103:
                if ( !PreProgressInc( __seg__, __ctx__, 104 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgError);
                    Tracker.FireEvent(__eventLocations[39],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 104;
            case 104:
                if ( !PreProgressInc( __seg__, __ctx__, 105 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[40],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 105;
            case 105:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 106 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 106;
            case 106:
                if ( !PreProgressInc( __seg__, __ctx__, 107 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                sndError.SendMessage(0, __ctx1__.__msgError, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 107;
            case 107:
                if ( !PreProgressInc( __seg__, __ctx__, 108 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgError);
                    __edata.PortName = @"sndError";
                    Tracker.FireEvent(__eventLocations[41],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__msgError != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgError);
                    __ctx1__.__msgError = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 108;
            case 108:
                if ( !PreProgressInc( __seg__, __ctx__, 109 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[42],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 109;
            case 109:
                if ( !PreProgressInc( __seg__, __ctx__, 110 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__sDownloadHost = null;
                if (__ctx1__ != null)
                    __ctx1__.__FTPHandler1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__sTemp = null;
                if (__ctx1__ != null)
                    __ctx1__.__sFolderName = null;
                if (__ctx1__ != null)
                    __ctx1__.__sACKFileNameWO = null;
                if (__ctx1__ != null)
                    __ctx1__.__sACKFileName = null;
                if (__ctx1__ != null)
                    __ctx1__.__shiftResult = null;
                if (__ctx1__ != null)
                    __ctx1__.__tmpStr1 = null;
                if (__ctx1__ != null && __ctx1__.__msgSingleFileImportResult != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgSingleFileImportResult);
                    __ctx1__.__msgSingleFileImportResult = null;
                }
                if (TransmitterRequestCopyPort != null)
                {
                    TransmitterRequestCopyPort.Close(__ctx1__, __seg__);
                    TransmitterRequestCopyPort = null;
                }
                if (TransmitterRequestSendPort != null)
                {
                    TransmitterRequestSendPort.Close(__ctx1__, __seg__);
                    TransmitterRequestSendPort = null;
                }
                if (sndError != null)
                {
                    sndError.Close(__ctx1__, __seg__);
                    sndError = null;
                }
                if (PortsndACK1 != null)
                {
                    PortsndACK1.Close(__ctx1__, __seg__);
                    PortsndACK1 = null;
                }
                Tracker.FireEvent(__eventLocations[43],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 110;
            case 110:
                if ( !PreProgressInc( __seg__, __ctx__, 111 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[44],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 111;
            case 111:
                __ctx1__.__ROBTLogger.CloseLogger(__ctx1__.__ROLogger);
                if (__ctx1__ != null)
                    __ctx1__.__ROLogger = null;
                if (__ctx1__ != null)
                    __ctx1__.__ROBTLogger = null;
                if ( !PostProgressInc( __seg__, __ctx__, 112 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 112;
            case 112:
                if ( !PreProgressInc( __seg__, __ctx__, 113 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[45],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 113;
            case 113:
                if ( !PreProgressInc( __seg__, __ctx__, 114 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[46],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 114;
            case 114:
                System.Diagnostics.EventLog.WriteEntry("FILESHIFT", "End fileshift orch");
                if ( !PostProgressInc( __seg__, __ctx__, 115 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 115;
            case 115:
                if ( !PreProgressInc( __seg__, __ctx__, 116 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[47],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 116;
            case 116:
                if ( !PreProgressInc( __seg__, __ctx__, 117 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 117;
            case 117:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 118 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 118;
            case 118:
                if ( !PreProgressInc( __seg__, __ctx__, 119 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 119;
            case 119:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __FTPIssueTransfer_DEV_SingleFileShiftInformation__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static FTPIssueTransfer_DEV.SingleFileShiftInformation _schema = new FTPIssueTransfer_DEV.SingleFileShiftInformation();

        public __FTPIssueTransfer_DEV_SingleFileShiftInformation__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "FTPIssueTransfer_DEV.SingleFileShiftInformation",
        new System.Type[]{
            typeof(FTPIssueTransfer_DEV.SingleFileShiftInformation)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__FTPIssueTransfer_DEV_SingleFileShiftInformation__)
        },
        0,
        @"http://FTPFileShift.FTPFileInformation#SingleFileTransferResult"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_FTPIssueTransfer_DEV_SingleFileShiftInformation : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __FTPIssueTransfer_DEV_SingleFileShiftInformation__ part;

        private void __CreatePartWrappers()
        {
            part = new __FTPIssueTransfer_DEV_SingleFileShiftInformation__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_FTPIssueTransfer_DEV_SingleFileShiftInformation(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Microsoft_XLANGs_BaseTypes_Any__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Microsoft.XLANGs.BaseTypes.Any _schema = new Microsoft.XLANGs.BaseTypes.Any();

        public __Microsoft_XLANGs_BaseTypes_Any__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "System.Xml.XmlDocument",
        new System.Type[]{
            typeof(Microsoft.XLANGs.BaseTypes.Any)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Microsoft_XLANGs_BaseTypes_Any__)
        },
        0,
        Microsoft.XLANGs.Core.XMessage.AnyMessageTypeName
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_System_Xml_XmlDocument : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Microsoft_XLANGs_BaseTypes_Any__ part;

        private void __CreatePartWrappers()
        {
            part = new __Microsoft_XLANGs_BaseTypes_Any__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_System_Xml_XmlDocument(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
