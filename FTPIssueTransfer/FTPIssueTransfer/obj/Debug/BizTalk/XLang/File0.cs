
#pragma warning disable 162

namespace FTPIssueTransfer
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(FTPIssueTransfer.__messagetype_FTPIssueTransfer_StartImportSchema), 
            typeof(FTPIssueTransfer.__messagetype_FTPIssueTransfer_StartImportSchema)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class RequestResponse_Type : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public RequestResponse_Type(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public RequestResponse_Type(RequestResponse_Type p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            RequestResponse_Type p = new RequestResponse_Type(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(RequestResponse_Type),
            typeof(__messagetype_FTPIssueTransfer_StartImportSchema),
            typeof(__messagetype_FTPIssueTransfer_StartImportSchema),
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
            typeof(FTPIssueTransfer.__messagetype_FTPIssueTransfer_TransferResultInformation)
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
            typeof(__messagetype_FTPIssueTransfer_TransferResultInformation),
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
            typeof(FTPIssueTransfer.__messagetype_FTPIssueTransfer_TransferResultInformation)
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
            typeof(__messagetype_FTPIssueTransfer_TransferResultInformation),
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
            typeof(FTPIssueTransfer.__messagetype_FTPIssueTransfer_StartImportSchema)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_req : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_req(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_req(PortType_req p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_req p = new PortType_req(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_req),
            typeof(__messagetype_FTPIssueTransfer_StartImportSchema),
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
            typeof(FTPIssueTransfer.__messagetype_FTPIssueTransfer_StartImportSchema)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_res : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_res(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_res(PortType_res p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_res p = new PortType_res(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_res),
            typeof(__messagetype_FTPIssueTransfer_StartImportSchema),
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

    [System.SerializableAttribute]
    sealed public class __FTPIssueTransfer_InitialTransmitterRequestSchema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static FTPIssueTransfer.InitialTransmitterRequestSchema _schema = new FTPIssueTransfer.InitialTransmitterRequestSchema();

        public __FTPIssueTransfer_InitialTransmitterRequestSchema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "FTPIssueTransfer.InitialTransmitterRequestSchema",
        new System.Type[]{
            typeof(FTPIssueTransfer.InitialTransmitterRequestSchema)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__FTPIssueTransfer_InitialTransmitterRequestSchema__)
        },
        0,
        @"http://FTPIssueTransfer.InitialTransmitterRequestSchema#transmitterRequest"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_FTPIssueTransfer_InitialTransmitterRequestSchema : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __FTPIssueTransfer_InitialTransmitterRequestSchema__ part;

        private void __CreatePartWrappers()
        {
            part = new __FTPIssueTransfer_InitialTransmitterRequestSchema__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_FTPIssueTransfer_InitialTransmitterRequestSchema(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
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
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_4),
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
            typeof(FTPIssueTransfer.__messagetype_FTPIssueTransfer_InitialTransmitterRequestSchema)
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
            typeof(__messagetype_FTPIssueTransfer_InitialTransmitterRequestSchema),
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
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class BMW_CCTRANSRECEIVE : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public BMW_CCTRANSRECEIVE(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public BMW_CCTRANSRECEIVE(BMW_CCTRANSRECEIVE p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            BMW_CCTRANSRECEIVE p = new BMW_CCTRANSRECEIVE(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(BMW_CCTRANSRECEIVE),
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
    //#line 636 "D:\ASAM-IF-IMPORT\Import\960 - Sources\PTI8KOR\BTImportSoftware\FTPIssueTransfer\FTPIssueTransfer\FTPStartIssueImport.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "RR_P", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(FTPIssueTransfer.RequestResponse_Type),
            typeof(FTPIssueTransfer.PortType_1),
            typeof(FTPIssueTransfer.PortType_2)
        },
        new System.String[] {
            "RR_P",
            "TR_P",
            "TR_CPY"
        },
        new System.Type[] {
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
    sealed internal class FTPStartIssueImport : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(FTPStartIssueImport));
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

        static FTPStartIssueImport()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __FTPStartIssueImport_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public FTPStartIssueImport(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "FTPStartIssueImport", tracker)
        {
            ConstructorHelper();
        }

        public FTPStartIssueImport(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "FTPStartIssueImport")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>2e52cf3a-cd05-4b8d-a23e-de5ad87e5053</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>bb436360-b0ac-48f7-87d8-fd2073c65120</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>66130cf7-920e-44e7-8df0-2dabfbd86f6e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Log</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>c9cae778-de51-4acb-ba3f-9c3cd584daf4</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>SetLogger</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>521a27de-b290-4a19-a00f-89bc7d3b27d2</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>SetupDownload</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>WhileShape</shapeType>      <ShapeID>85e3fb3d-1160-48fe-97cc-542e6fd357a9</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Loop_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>77519480-c6ff-40bc-aace-71b2815459a5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>IncrementLoopCounter</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>b130cf5c-d2cc-4681-a60a-8a15afce9b26</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>4746bd86-8b04-4382-88e7-5f5f4538954e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>800fcafd-877f-4797-ad03-353fddfb9483</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>a34056f3-e6dd-4296-b6e0-1a69768a1ba2</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>a4cf53ec-e2ab-4907-9afb-cbbbf9a3c12f</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>InitLoop</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>WhileShape</shapeType>      <ShapeID>e1ef5518-eec4-4da3-893c-24333370a024</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Loop_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>611cf214-8376-48d6-b5d4-94d3cb168dca</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Attachment DL</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>bf1ba650-ebcd-4011-a4f1-816102ae7450</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>3bf0f9a0-76ac-4d3b-b036-f5df2330ddd1</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_3</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>59e0fdb1-320b-4263-bf9f-a9d86286c686</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>3f71b0c2-1eed-4469-92f5-66192a9e6881</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>1b535c38-1bde-4525-af1b-e49c4af5d781</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>72c59a52-eab3-4403-a213-1cae5589a6d6</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>ce8e640d-51af-452e-bac8-97c6feedbe85</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>786be4f1-9fe3-428d-afa4-eec0f349d177</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>CloseLogger</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>5afd2eb4-24b1-4c3a-a947-8a34ec3fb290</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>e5308ac7-af57-4a73-9cae-e19955356c4d</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'FTPStartIssueImport'</ActionName><IsAtomic>0</IsAtomic><Line>636</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>679</Line><Position>22</Position><ShapeID>'bb436360-b0ac-48f7-87d8-fd2073c65120'</ShapeID>
<Messages>
	<MsgInfo><name>Message_1</name><part>part</part><schema>FTPIssueTransfer.StartImportSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>707</Line><Position>51</Position><ShapeID>'66130cf7-920e-44e7-8df0-2dabfbd86f6e'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>709</Line><Position>23</Position><ShapeID>'c9cae778-de51-4acb-ba3f-9c3cd584daf4'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>714</Line><Position>22</Position><ShapeID>'521a27de-b290-4a19-a00f-89bc7d3b27d2'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>802</Line><Position>13</Position><ShapeID>'85e3fb3d-1160-48fe-97cc-542e6fd357a9'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>805</Line><Position>26</Position><ShapeID>'77519480-c6ff-40bc-aace-71b2815459a5'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>941</Line><Position>13</Position><ShapeID>'b130cf5c-d2cc-4681-a60a-8a15afce9b26'</ShapeID>
<Messages>
	<MsgInfo><name>Message_2</name><part>part</part><schema>FTPIssueTransfer.StartImportSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>968</Line><Position>13</Position><ShapeID>'a34056f3-e6dd-4296-b6e0-1a69768a1ba2'</ShapeID>
<Messages>
	<MsgInfo><name>Message_2</name><part>part</part><schema>FTPIssueTransfer.StartImportSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>971</Line><Position>32</Position><ShapeID>'a4cf53ec-e2ab-4907-9afb-cbbbf9a3c12f'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>976</Line><Position>13</Position><ShapeID>'e1ef5518-eec4-4da3-893c-24333370a024'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>981</Line><Position>26</Position><ShapeID>'611cf214-8376-48d6-b5d4-94d3cb168dca'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1089</Line><Position>29</Position><ShapeID>'bf1ba650-ebcd-4011-a4f1-816102ae7450'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1113</Line><Position>13</Position><ShapeID>'3bf0f9a0-76ac-4d3b-b036-f5df2330ddd1'</ShapeID>
<Messages>
	<MsgInfo><name>Message_3</name><part>part</part><schema>FTPIssueTransfer.TransferResultInformation</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Message_2</name><part>part</part><schema>FTPIssueTransfer.StartImportSchema</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1133</Line><Position>35</Position><ShapeID>'786be4f1-9fe3-428d-afa4-eec0f349d177'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1137</Line><Position>13</Position><ShapeID>'5afd2eb4-24b1-4c3a-a947-8a34ec3fb290'</ShapeID>
<Messages>
	<MsgInfo><name>Message_3</name><part>part</part><schema>FTPIssueTransfer.TransferResultInformation</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1139</Line><Position>13</Position><ShapeID>'e5308ac7-af57-4a73-9cae-e19955356c4d'</ShapeID>
<Messages>
	<MsgInfo><name>Message_3</name><part>part</part><schema>FTPIssueTransfer.TransferResultInformation</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='0dfa1a6e-7605-4136-95f6-e285b2a1f69d' LowerBound='1.1' HigherBound='547.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='FTPIssueTransfer' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='8e0169c0-76bb-4411-b904-7a7016eeed81' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='RequestResponse_Type' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='1718239d-4ec0-4541-aadf-c1f0bcd57004' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='866c8fc0-fc2b-435a-8f3a-596e16de5f8b' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.30'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.StartImportSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='3faa38c5-7973-4c0e-9c7a-06d6180898bd' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='8.32' HigherBound='8.49'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.StartImportSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='aafe8e9b-d00e-43a5-8c3d-78701510067a' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='da60f275-f4bc-43e2-98ab-00dca8461651' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='6dfc3593-6614-4a2b-b56b-6d42d93bd958' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.38'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.TransferResultInformation' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='70e9e1b4-0690-440f-b4c3-9d9248838e6d' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_2' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='bb6cb4f5-9701-48b8-bc99-bacb1eefc562' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='cba63d7d-524b-45e3-b4d0-f837e184081f' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.38'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.TransferResultInformation' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='03504fe7-0c08-4117-b110-cbf9735576cc' ParentLink='Module_PortType' LowerBound='25.1' HigherBound='32.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_req' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='26053f26-646b-4464-a8de-74f7b50c2862' ParentLink='PortType_OperationDeclaration' LowerBound='27.1' HigherBound='31.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='980b589f-c4ec-4f95-9edd-dea80e11bad1' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='29.13' HigherBound='29.30'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.StartImportSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='b87f5ba2-48ec-4c6c-9bbb-97cc54f2fcbc' ParentLink='Module_PortType' LowerBound='32.1' HigherBound='39.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_res' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='bec2953d-18ac-4eb8-827c-02ab37bc20cf' ParentLink='PortType_OperationDeclaration' LowerBound='34.1' HigherBound='38.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='ac1fd6fd-4334-4154-a7ab-9180b6c10295' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='36.13' HigherBound='36.30'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.StartImportSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='f859c9a4-0d63-4b71-8434-7e480ea81e63' ParentLink='Module_ServiceDeclaration' LowerBound='39.1' HigherBound='546.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='FTPStartIssueImport' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='824904de-6c95-44f7-a87c-0238506eaa20' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='51.1' HigherBound='52.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ChildNumber' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='1fe768ba-9d23-4e15-b1dd-e2984dee0e46' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='52.1' HigherBound='53.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='LoopCounter' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='209c2d8e-8875-4648-aa70-dfcb4dc5867c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='53.1' HigherBound='54.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tmp_str1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='f4747392-0e7a-4c8a-9a24-7e8172a3605c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='54.1' HigherBound='55.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tmp_str2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='d5993880-5fae-4214-8468-e4c5222d16a2' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='55.1' HigherBound='56.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='contains filenames with one filename per line' />
                <om:Property Name='Name' Value='FileNames' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8643787e-5eb3-4245-bf33-1fde4db23c47' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='56.1' HigherBound='57.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DLDirName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='fd1a5023-8df7-4681-ab28-f25e33fdec0b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='57.1' HigherBound='58.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='InterfaceName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='4537edbb-025d-40f2-945b-f05ec88d0a7d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='58.1' HigherBound='59.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='result' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='67f997a7-68b0-42f0-864f-5d8187f8988b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='59.1' HigherBound='60.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='RB.FTPLibrary.FTPHandler' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FTPHandler1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='53e52ef6-2117-4482-92ed-80e250f7057f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='60.1' HigherBound='61.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='LifeToken4Files' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='9c55c59d-a667-4a22-b017-107f376f8368' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='61.1' HigherBound='62.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='LifeToken4XProt' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='286d122a-32dc-41cf-8a63-cde284910a8c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='62.1' HigherBound='63.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tmp_str3' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='16f9b3d4-5d17-4466-943e-185fc8bb6ba1' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='63.1' HigherBound='64.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FileNamesCom' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='49786729-e2c6-4edd-9f98-a2c4845fbe5f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='64.1' HigherBound='65.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='RB.FTPLibrary.retStrBool' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='retVar1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='a43e2eaa-94bf-4247-b917-6d5730371fac' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='65.1' HigherBound='66.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='RB.FTPLibrary.retStrBool' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='retVar2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='788441af-e088-4371-8510-d6c504d7bb7b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='66.1' HigherBound='67.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TargetSystem' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='5abe781d-4456-4f3b-a753-8a9d4c348468' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='67.1' HigherBound='68.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='RB.BTLoggerLibrary.ROUpdater' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ROUpdater1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='518a0cd4-0c8c-44cc-9259-e8ee50a36d0f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='68.1' HigherBound='69.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='RB.BTLoggerLibrary.Logger' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ROLogger' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='c6f76f68-8b04-4c65-b503-4c8807605b0c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='69.1' HigherBound='70.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='resultCharCheck' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='aa94c656-9854-4c7b-91ae-372f3f51fe28' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='70.1' HigherBound='71.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='RB.FTPLibrary.retStrBool' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='retVar3' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7d885e53-0858-4b5a-b501-dd220bdfcf0e' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='71.1' HigherBound='72.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TransferMode' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='34ffc23b-3d2b-42a2-9af0-9b62f3fe8e65' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='72.1' HigherBound='73.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='RB.BTLoggerLibrary.BTLogger' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ROBTLogger' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='9afe6388-8cfb-4bd5-8d30-0434c55860d8' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='73.1' HigherBound='74.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DLDirOut' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='9bca854e-35e1-47e6-9c25-402a5c88fb23' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='74.1' HigherBound='75.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='isMsgAck' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ce428011-1b8b-4697-b5ca-2e15f53ee614' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='75.1' HigherBound='76.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tmp_str4' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='bc515fe3-934f-4967-81d9-bba0980056aa' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='76.1' HigherBound='77.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='isValid' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='66b03c60-293e-445f-a21d-bbbc6905f0b8' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='77.1' HigherBound='78.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tmp_str5' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='d1e40c3a-7745-4319-8614-d9215b5a45bb' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='78.1' HigherBound='79.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='unModifiedAIFileName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='6894c34a-1c7f-4da7-9abe-764d84809711' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='79.1' HigherBound='80.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='isattachmentValid' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='656ed494-9e14-46d8-bf15-6e50c1bafed4' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='48.1' HigherBound='49.1'>
                <om:Property Name='Type' Value='FTPIssueTransfer.TransferResultInformation' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Message_3' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='da58c5e6-a1d2-4c49-bed8-6f4610476d8e' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='49.1' HigherBound='50.1'>
                <om:Property Name='Type' Value='FTPIssueTransfer.StartImportSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Message_1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='0bc036fd-3fd7-4002-8bb4-dfdd6764becd' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='50.1' HigherBound='51.1'>
                <om:Property Name='Type' Value='FTPIssueTransfer.StartImportSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Message_2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='2e52cf3a-cd05-4b8d-a23e-de5ad87e5053' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='bb436360-b0ac-48f7-87d8-fd2073c65120' ParentLink='ServiceBody_Statement' LowerBound='82.1' HigherBound='110.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='RR_P' />
                    <om:Property Name='MessageName' Value='Message_1' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='66130cf7-920e-44e7-8df0-2dabfbd86f6e' ParentLink='ServiceBody_Statement' LowerBound='110.1' HigherBound='112.1'>
                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Request received at &quot;+System.String.Format(&quot;{0:yyyyMMdd-HHmmssffffff - }&quot;, System.DateTime.Now));' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Log' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='c9cae778-de51-4acb-ba3f-9c3cd584daf4' ParentLink='ServiceBody_Statement' LowerBound='112.1' HigherBound='116.1'>
                    <om:Property Name='Expression' Value='ROLogger  = ROBTLogger.GetLogger(Message_1.InterfaceName,Message_1.XProtID, &quot;Import&quot;);&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmssffffff - }&quot;, System.DateTime.Now) + &quot;After receiving Request&quot;,&#xD;&#xA;ROLogger);&#xD;&#xA;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SetLogger' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='521a27de-b290-4a19-a00f-89bc7d3b27d2' ParentLink='ServiceBody_Statement' LowerBound='116.1' HigherBound='205.1'>
                    <om:Property Name='Expression' Value='&#xD;&#xA;tmp_str1 = Message_1.RQ1System;&#xD;&#xA;tmp_str2 = Message_1.XProtID;&#xD;&#xA;InterfaceName = System.Convert.ToString(Message_1.InterfaceName);&#xD;&#xA;TargetSystem = System.Convert.ToString(Message_1.RQ1System);&#xD;&#xA;&#xD;&#xA;FTPHandler1 = new RB.FTPLibrary.FTPHandler(InterfaceName, TargetSystem);&#xD;&#xA;&#xD;&#xA;// Fehlerbehandlung notwendig : sind Zeichen enthalten, die nicht in Dir-Namen verwendet werden dürfen? zB &quot;\:&quot;&#xD;&#xA;// DownloadDirName : Name des Unterverzeichnisses, in das die Files kopiert werden&#xD;&#xA;&#xD;&#xA; //ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;Download directory before : &quot;, ROLogger);&#xD;&#xA;&#xD;&#xA; DLDirName = System.String.Format(&quot;{0:yyyyMMdd-HHmmss_}&quot;, System.DateTime.Now) + tmp_str1 + &quot;_&quot; + tmp_str2; &#xD;&#xA; DLDirOut = System.String.Format(&quot;{0:yyyyMMdd-HHmmss_}&quot;, System.DateTime.Now) + tmp_str1 + &quot;_&quot; + tmp_str2; &#xD;&#xA;&#xD;&#xA; TransferMode = FTPHandler1.GetTransferMode(Message_1.FTPFileNames);&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : TransferMode : &quot; +TransferMode,&#xD;&#xA;ROLogger);&#xD;&#xA;&#xD;&#xA;if(TransferMode.ToUpper() == &quot;AUTOMATIC&quot;)&#xD;&#xA;{&#xD;&#xA;     DLDirName = FTPHandler1.GetDLDirNameForXPROTCreation(Message_1.FTPFileNames, tmp_str1, tmp_str2);&#xD;&#xA;     DLDirOut = System.String.Format(&quot;{0:yyyyMMdd-HHmmss_}&quot;, System.DateTime.Now) + tmp_str1 + &quot;_&quot; + tmp_str2;    &#xD;&#xA;}&#xD;&#xA;&#xD;&#xA; ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : Download directory  : &quot; + DLDirName,&#xD;&#xA;ROLogger);&#xD;&#xA; &#xD;&#xA;&#xD;&#xA;&#xD;&#xA;// Example for TargetSystem : SOAP::Data-&gt;name(&apos;ftp:FTPImportRequest&apos;)-&gt;value("+
@"[SOAP::Data-&gt;name(&apos;RQ1System&apos;)-&gt;value(&apos;CDG_DEV_INTEGRATION@RQ1ML&apos;), ...&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;// setup ftp interface&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;//result = System.Convert.ToBoolean(FTPHandler1.FTPHandlerValid); // access not possible because static variable&#xD;&#xA;&#xD;&#xA;// get csv-Filenames from tag:&#xD;&#xA;&#xD;&#xA;//tmp_str1 =  xpath(Message_1, &quot;string(/*[local-name()=&apos;FTPImportRequest&apos; and namespace-uri()=&apos;http://FTPIssueTransfer.Schema1&apos;]/*[local-name()=&apos;FTPFileNames&apos; and namespace-uri()=&apos;&apos;])&quot;);&#xD;&#xA;//tmp_str1 = Message_1.FTPFileNames;&#xD;&#xA;tmp_str1 = FTPHandler1.GetFileNamesForXPROTCreation(Message_1.FTPFileNames);&#xD;&#xA;&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : GetFileNamesForXPROTCreation  : &quot; + tmp_str1,&#xD;&#xA;ROLogger);&#xD;&#xA;&#xD;&#xA;tmp_str4 = tmp_str1;&#xD;&#xA;&#xD;&#xA;//Check for Sorting&#xD;&#xA;if(FTPHandler1.canSortFiles ==&quot;1&quot;)&#xD;&#xA;{&#xD;&#xA;    tmp_str1 = FTPHandler1.GetSortedFiles(tmp_str1);&#xD;&#xA;    ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : GetSortedFiles  : &quot; + tmp_str1,ROLogger);&#xD;&#xA;}&#xD;&#xA;&#xD;&#xA;// storing the sorted files in a string.&#xD;&#xA;tmp_str5 = tmp_str1;&#xD;&#xA;&#xD;&#xA;// Initialisation&#xD;&#xA;LifeToken4XProt = &quot;In Progress&quot;;&#xD;&#xA;LifeToken4Files = ROBTLogger.InsertAllTokenStatus(tmp_str4, &quot;In Progress&quot;, &quot;import&quot;);&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : LifeToken4Files  : &quot; + LifeToken4Files,ROLogger);&#xD;&#xA;&#xD;&#xA;//&gt;LifeToken4Files = RB.BTLogger.BTLogger.SetTokenStatus(LifeToken4Files, Filename, &quot;In Progress&quot;);&#xD;&#xA;//&gt;Status = RB.BTLogger.BTLogger.GetTokenStatus(LifeToken4Files"+
@", Filename);&#xD;&#xA;&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;XProtID -&gt;&quot; + tmp_str2 +  &quot;; Download FileList -&gt; &quot; + tmp_str1,&#xD;&#xA;ROLogger);&#xD;&#xA;&#xD;&#xA;//ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : Download directory : &quot; + DLDirName,ROLogger);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;Biztalk : FTPFilenames raw&quot;, tmp_str1 , System.Diagnostics.EventLogEntryType.Information);&#xD;&#xA;&#xD;&#xA;FileNames = FTPHandler1.ConvertToLines(tmp_str4,&quot;,&quot;);&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;Biztalk : FTPFilenames in Lines&quot;, FileNames , System.Diagnostics.EventLogEntryType.Information);&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FileNames : &quot; + FileNames,&#xD;&#xA;ROLogger);&#xD;&#xA;&#xD;&#xA;ChildNumber = FTPHandler1.CountStringLines(FileNames);&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;Biztalk : ChildNumber&quot;, System.Convert.ToString(ChildNumber), System.Diagnostics.EventLogEntryType.Information);&#xD;&#xA;&#xD;&#xA;LoopCounter = 1;&#xD;&#xA;&#xD;&#xA;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SetupDownload' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='While' OID='85e3fb3d-1160-48fe-97cc-542e6fd357a9' ParentLink='ServiceBody_Statement' LowerBound='205.1' HigherBound='344.1'>
                    <om:Property Name='Expression' Value='LoopCounter &lt;= ChildNumber' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Loop_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='VariableAssignment' OID='77519480-c6ff-40bc-aace-71b2815459a5' ParentLink='ComplexStatement_Statement' LowerBound='208.1' HigherBound='343.1'>
                        <om:Property Name='Expression' Value='tmp_str1 = FTPHandler1.ReadStringLine(FileNames, LoopCounter);  // contains single file name&#xD;&#xA;&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;FileDownload started -&gt;&quot; + tmp_str1,&#xD;&#xA;ROLogger);&#xD;&#xA;&#xD;&#xA;//System.Diagnostics.EventLog.WriteEntry(&quot;Biztalk : SingleFileDownload - raw value&quot;, tmp_str1, System.Diagnostics.EventLogEntryType.Information);&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;Biztalk : SingleFileDownload - single file&quot;, tmp_str1, System.Diagnostics.EventLogEntryType.Information);&#xD;&#xA;&#xD;&#xA;//verifying wether the file name is present in filterd filenames string. &#xD;&#xA;isValid = FTPHandler1.IsValid(tmp_str1, tmp_str5);&#xD;&#xA;&#xD;&#xA;result = FTPHandler1.TransferSingleFTPFile(tmp_str1, DLDirName,isValid);&#xD;&#xA;&#xD;&#xA;if (result == true)&#xD;&#xA;{&#xD;&#xA;    //not needed as value is already set:&#xD;&#xA;    //LifeToken4Files = RB.BTLogger.BTLogger.SetTokenStatus(LifeToken4Files, tmp_str1, &quot;In Progress&quot;);&#xD;&#xA;&#xD;&#xA;    // write success log back to FTPLog&#xD;&#xA;    ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;FTPFile successfully downloaded - &quot; + tmp_str1,&#xD;&#xA;ROLogger);&#xD;&#xA;    &#xD;&#xA;&#xD;&#xA;}&#xD;&#xA;else&#xD;&#xA;{&#xD;&#xA;    if (isValid)&#xD;&#xA;    {&#xD;&#xA;        LifeToken4Files = ROBTLogger.SetTokenStatus(LifeToken4Files, tmp_str1, &quot;Failure&quot;, &quot;download failed&quot;);&#xD;&#xA;        ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;Error - FTPFile not available on FTPServer - &quot; + tmp_str1,&#xD;&#xA;ROLogger);&#xD;&#xA;    }&#xD;&#xA;    else&#xD;&#xA;    {&#xD;&#xA;        LifeToken4Files = RO"+
@"BTLogger.SetTokenStatus(LifeToken4Files, tmp_str1, &quot;Failure&quot;, &quot;File Name is not valid. Please provide valid file name.&quot;);&#xD;&#xA;        ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;Error - FTPFile name is not valid. Please provide valid file name - &quot; + tmp_str1,&#xD;&#xA;ROLogger);&#xD;&#xA;    }&#xD;&#xA;    &#xD;&#xA;&#xD;&#xA;    &#xD;&#xA;}&#xD;&#xA;&#xD;&#xA;if(result == true)&#xD;&#xA;{ &#xD;&#xA;    result = FTPHandler1.CheckforEmptyFTPFile(tmp_str1, DLDirName);&#xD;&#xA;    if(!result)&#xD;&#xA;    {&#xD;&#xA;        ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;FTPFile size is 0 bytes - &quot; + tmp_str1,&#xD;&#xA;        ROLogger);&#xD;&#xA;        LifeToken4Files = ROBTLogger.SetTokenStatus(LifeToken4Files, tmp_str1, &quot;Failure&quot;, &quot;ASAM file is empty&quot;);&#xD;&#xA;&#xD;&#xA;    }&#xD;&#xA;}&#xD;&#xA;isattachmentValid = FTPHandler1.VerifyAttachmentNames(tmp_str1, DLDirName);&#xD;&#xA;&#xD;&#xA;if(isattachmentValid == false)&#xD;&#xA;{&#xD;&#xA;   LifeToken4Files = ROBTLogger.SetTokenStatus(LifeToken4Files, tmp_str1, &quot;Failure&quot;, &quot;Invalid Character in the attachment name. Please provide valid attachment name.&quot;); &#xD;&#xA;}&#xD;&#xA;&#xD;&#xA;if (result == true)&#xD;&#xA;{&#xD;&#xA;    // ISO check&#xD;&#xA;    retVar3  = FTPHandler1.DetectInvalidCharacter(tmp_str1, DLDirName);&#xD;&#xA;&#xD;&#xA;  //ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;DetectInvalidChar &quot;+ &quot; - &quot; + retVar3.rString,ROLogger);&#xD;&#xA;&#xD;&#xA;	tmp_str2 = retVar3.rMessage;&#xD;&#xA;&#xD;&#xA;	  ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;DetectInvalidChar &quot;+ &quot; -"+
@" &quot; + tmp_str2,&#xD;&#xA;ROLogger);&#xD;&#xA;	&#xD;&#xA;    if (System.Text.RegularExpressions.Regex.IsMatch(tmp_str2,&quot;.*failure:.*&quot;))&#xD;&#xA;    {&#xD;&#xA;        // write error log back to FTPLog&#xD;&#xA;		resultCharCheck = false;&#xD;&#xA;      &#xD;&#xA;        tmp_str3 = System.Text.RegularExpressions.Regex.Replace(tmp_str2, &quot;.*failure:(.*)&quot;, &quot;$1&quot;);&#xD;&#xA;        tmp_str3 = System.Text.RegularExpressions.Regex.Replace(tmp_str3, @&quot;.*(invalid character.*)&quot;, &quot;$1&quot;, System.Text.RegularExpressions.RegexOptions.IgnoreCase);&#xD;&#xA;&#xD;&#xA;        LifeToken4Files = ROBTLogger.SetTokenStatus(LifeToken4Files, tmp_str1, &quot;Failure&quot;, tmp_str3);&#xD;&#xA;&#xD;&#xA;       ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + tmp_str2 + &quot; - &quot; + tmp_str1,&#xD;&#xA;ROLogger);&#xD;&#xA;    }&#xD;&#xA;    else&#xD;&#xA;    {&#xD;&#xA;	&#xD;&#xA;		//reconstruct lifetoken if chars are replaced in asam file&#xD;&#xA;		 if (System.Text.RegularExpressions.Regex.IsMatch(retVar3.rString,&quot;.*Chars replaced in asam file*&quot;))&#xD;&#xA;		{&#xD;&#xA; ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;FTPFile change lifetoken&quot; ,&#xD;&#xA;ROLogger);&#xD;&#xA;			//change file name in lifetoken&#xD;&#xA;			LifeToken4Files = ROBTLogger.ChangeFileNameInToken(LifeToken4Files,tmp_str1);&#xD;&#xA; ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;FTPFile updated lifetoken - &quot; + LifeToken4Files,&#xD;&#xA;ROLogger);&#xD;&#xA;		}&#xD;&#xA;        &#xD;&#xA;&#xD;&#xA;&#xD;&#xA;        // write success log back to FTPLog&#xD;&#xA;       ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;FTPFile succes"+
@"sfully checked for ISO conformance - &quot; + tmp_str1,&#xD;&#xA;ROLogger);&#xD;&#xA;    }&#xD;&#xA;}&#xD;&#xA;&#xD;&#xA;if (result == true &amp;&amp; resultCharCheck == true)&#xD;&#xA;{&#xD;&#xA;    //check if xml is validating against xsd schema&#xD;&#xA;    retVar1 = FTPHandler1.ValidateAIFileByXSD(tmp_str1, DLDirName);&#xD;&#xA;    if (retVar1.rSuccess == true)&#xD;&#xA;    {&#xD;&#xA;        // write success log back to FTPLog&#xD;&#xA;       ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;ASAM file successfully validated - &quot; + tmp_str1,&#xD;&#xA;ROLogger);&#xD;&#xA;    }&#xD;&#xA;    else&#xD;&#xA;    {&#xD;&#xA;   ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;Error from xsd validation retVar1 msg = &quot; +retVar1.rMessage + &quot; tmp_str1=&quot;+ tmp_str1,&#xD;&#xA;ROLogger);&#xD;&#xA;&#xD;&#xA;        // write error log back to FTPLog    &#xD;&#xA;        LifeToken4Files =ROBTLogger.SetTokenStatus(LifeToken4Files, tmp_str1, &quot;Failure&quot;,&quot;xsd validation of asam file failed with error: &quot;+ retVar1.rMessage);&#xD;&#xA;        //ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;Error - xsd validation of ASAM file failed - &quot; + tmp_str1, ROLogger);&#xD;&#xA;       &#xD;&#xA;    }&#xD;&#xA;&#xD;&#xA;}&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;LoopCounter = LoopCounter + 1;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='IncrementLoopCounter' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Construct' OID='b130cf5c-d2cc-4681-a60a-8a15afce9b26' ParentLink='ServiceBody_Statement' LowerBound='344.1' HigherBound='371.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_2' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='4746bd86-8b04-4382-88e7-5f5f4538954e' ParentLink='ComplexStatement_Statement' LowerBound='347.1' HigherBound='370.1'>
                        <om:Property Name='Expression' Value='LifeToken4XProt = ROBTLogger.GetOverallTokenStatus(LifeToken4Files);&#xD;&#xA;//&gt;if LifeToken4XProt = &quot;Failure&quot; ....&#xD;&#xA;&#xD;&#xA;Message_2 = Message_1;&#xD;&#xA;// BTLogger-Message only, because this line is available already in ExchangeProtocol-Log :&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;Result of xml downloads -&gt; &quot; + LifeToken4XProt,&#xD;&#xA;ROLogger);&#xD;&#xA;//ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;Exchange protocol queued for import -&gt; &quot; + Message_2.XProtID,ROLogger);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;// reduce message text in XProt&#xD;&#xA;//Message_2.BTReturnMsg = ROLogText; &#xD;&#xA;Message_2.BTReturnMsg = &quot;&quot;;&#xD;&#xA;&#xD;&#xA;//ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;BTReturnMsg -&gt;&quot; +Message_2.BTReturnMsg +&quot;-&quot;,ROLogger);&#xD;&#xA;//ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;ReturnMsg Files -&gt;&quot; +Message_2.FTPFileNames +&quot;-&quot;,ROLogger);&#xD;&#xA;&#xD;&#xA;//FTPIssueTransfer_Project.PropertySchema.FileName) = Message_2.GetPropertyValue(typeof(FTPHandler.ParseFTPListStream(FTPStream)));&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;Message_2 = FTPHandler1.AddDummyTagToResponse(Message_2);&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;Added Dummy tag to response&quot;,ROLogger);' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='MessageAssignment_1' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='800fcafd-877f-4797-ad03-353fddfb9483' ParentLink='Construct_MessageRef' LowerBound='345.23' HigherBound='345.32'>
                        <om:Property Name='Ref' Value='Message_2' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='a34056f3-e6dd-4296-b6e0-1a69768a1ba2' ParentLink='ServiceBody_Statement' LowerBound='371.1' HigherBound='373.1'>
                    <om:Property Name='PortName' Value='RR_P' />
                    <om:Property Name='MessageName' Value='Message_2' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='a4cf53ec-e2ab-4907-9afb-cbbbf9a3c12f' ParentLink='ServiceBody_Statement' LowerBound='373.1' HigherBound='379.1'>
                    <om:Property Name='Expression' Value='//System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;After sending Response &quot;+System.String.Format(&quot;{0:yyyyMMdd-HHmmssffffff - }&quot;, System.DateTime.Now));&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmssffffff - }&quot;, System.DateTime.Now) + &quot;After sending Response&quot;,&#xD;&#xA;ROLogger);&#xD;&#xA;&#xD;&#xA;LoopCounter = 1;&#xD;&#xA;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='InitLoop' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='While' OID='e1ef5518-eec4-4da3-893c-24333370a024' ParentLink='ServiceBody_Statement' LowerBound='379.1' HigherBound='491.1'>
                    <om:Property Name='Expression' Value='LoopCounter &lt;= ChildNumber' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Loop_2' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='VariableAssignment' OID='611cf214-8376-48d6-b5d4-94d3cb168dca' ParentLink='ComplexStatement_Statement' LowerBound='382.1' HigherBound='490.1'>
                        <om:Property Name='Expression' Value='   //REUBK-2187&#xD;&#xA;&#xD;&#xA;tmp_str1 = FTPHandler1.ReadStringLine(FileNames, LoopCounter); // contains single file name&#xD;&#xA;&#xD;&#xA;tmp_str1 = ROBTLogger.GetFileName(LifeToken4Files,tmp_str1); //get modified asam file name based on new token&#xD;&#xA;&#xD;&#xA;if (ROBTLogger.GetTokenStatusForFile(LifeToken4Files, tmp_str1)!=&quot;Failure&quot;) //REUBK-2187 do not proceed for att download if non iso char is found&#xD;&#xA;    {&#xD;&#xA;&#xD;&#xA;	//Check if STATUS-TAG exists in config&#xD;&#xA;	retVar1 = FTPHandler1.CheckIfStatusTagExists(tmp_str1,DLDirName);&#xD;&#xA;    ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;CheckIfStatusTagExists -&gt;&quot; + retVar1.rSuccess.ToString(),&#xD;&#xA;		ROLogger);&#xD;&#xA;    ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;CheckIfStatusTagExists -&gt;&quot; + retVar1.rMessage,&#xD;&#xA;		ROLogger);&#xD;&#xA;    if(retVar1.rSuccess)&#xD;&#xA;    {&#xD;&#xA;        isMsgAck = false;&#xD;&#xA;    }&#xD;&#xA;    else&#xD;&#xA;    {&#xD;&#xA;        isMsgAck = true;&#xD;&#xA;    }&#xD;&#xA;&#xD;&#xA;	if(!isMsgAck)&#xD;&#xA;	{&#xD;&#xA;&#xD;&#xA;		ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;AttachmentDownload of -&gt;&quot; + tmp_str1,&#xD;&#xA;		ROLogger);&#xD;&#xA;&#xD;&#xA;        //need to use non modified ASAM file to verify attachments&#xD;&#xA;&#xD;&#xA;        //unModifiedAIFileName = tmp_str1;&#xD;&#xA;        &#xD;&#xA;        //unModifiedAIFileName = unModifiedAIFileName.Replace(&quot;_M&quot;,&quot;&quot;);&#xD;&#xA;&#xD;&#xA;        //FTPHandler1.UpdateModifiedFileUrls(tmp_str1, unModifiedAIFileName, DLDirName);&#xD;&#xA;&#xD;&#xA;		///System.Diagnostics.EventLog.WriteEntry(&quot;Biztalk : SingleFileDown"+
@"load - raw value&quot;, tmp_str1, System.Diagnostics.EventLogEntryType.Warning);&#xD;&#xA;		///System.Diagnostics.EventLog.WriteEntry(&quot;Biztalk : SingleFileDownload - single file&quot;, tmp_str1, System.Diagnostics.EventLogEntryType.Warning);&#xD;&#xA;&#xD;&#xA;		//Fill list of commercial files&#xD;&#xA;		retVar1 = FTPHandler1.CheckCommercialFiles(tmp_str1, DLDirName, FileNamesCom);&#xD;&#xA;&#xD;&#xA;		ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;CheckCommercialFiles -&gt;&quot; + System.Convert.ToString(retVar1.rSuccess),&#xD;&#xA;		ROLogger);&#xD;&#xA;		if (retVar1.rSuccess == true)&#xD;&#xA;		{&#xD;&#xA;			ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;CheckCommercialFiles FileNamesCom-&gt;&quot; + retVar1.rString,&#xD;&#xA;			ROLogger);&#xD;&#xA;			FileNamesCom = System.Convert.ToString(retVar1.rString);&#xD;&#xA;&#xD;&#xA;			//Zugriff auf lokales File&#xD;&#xA;			ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;CheckCommercialFiles -call GetAttachmentNames-&gt;&quot;,&#xD;&#xA;			ROLogger);&#xD;&#xA;			retVar2 = FTPHandler1.GetAttachmentNames(tmp_str1, DLDirName,false);&#xD;&#xA;			tmp_str2 = System.Convert.ToString(retVar2.rMessage);&#xD;&#xA;			//retVar2-error not yet handled explicitly&#xD;&#xA;			&#xD;&#xA;				ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;CheckCommercialFiles - GetAttachmentNames-&gt;&quot; + tmp_str2,&#xD;&#xA;			ROLogger);&#xD;&#xA;&#xD;&#xA;			ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;Attachments queued for download -&gt;&quot; + tmp_str1,ROLogger);&#xD;&#xA;			ROBTLogger.WriteLog(System.String.Format(&quot"+
@";{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;AttachmentsDownload result -&gt;&quot; + tmp_str2,ROLogger);&#xD;&#xA;&#xD;&#xA;			ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; +  &quot;ASAM file &quot;+tmp_str1 + &quot;LifeToken4Files&quot; + LifeToken4Files,ROLogger);&#xD;&#xA;			&#xD;&#xA;			if (ROBTLogger.GetTokenStatusForFile(LifeToken4Files, tmp_str1)!=&quot;Failure&quot;)&#xD;&#xA;			{&#xD;&#xA;				ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; +  &quot;ASAM file status is not failure &quot;+tmp_str1 +LifeToken4Files,ROLogger);&#xD;&#xA;				if (System.Text.RegularExpressions.Regex.IsMatch(tmp_str2,&quot;.*failure:.*&quot;))&#xD;&#xA;				{&#xD;&#xA;					//REUBK-1388&#xD;&#xA;					ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;ASAM file attachment status is failure &quot;+tmp_str2,ROLogger);&#xD;&#xA;					//tmp_str3 = System.Text.RegularExpressions.Regex.Replace(tmp_str2, &quot;.*failure:([^,]+).*&quot;, &quot;$1&quot;);&#xD;&#xA;					tmp_str3 = System.Text.RegularExpressions.Regex.Replace(tmp_str2, &quot;.*failure:([^·]+).*&quot;, &quot;$1&quot;);&#xD;&#xA;						ROBTLogger.WriteLog( System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;ASAM file attachment status is failure &quot;+tmp_str3,ROLogger);&#xD;&#xA;					LifeToken4Files = ROBTLogger.SetTokenStatus(LifeToken4Files, tmp_str1, &quot;Failure&quot;, tmp_str3);&#xD;&#xA;				}&#xD;&#xA;				else&#xD;&#xA;				{&#xD;&#xA;					ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; +  &quot;set status to Inprogress&quot; ,ROLogger);&#xD;&#xA;					LifeToken4Files = ROBTLogger.SetTokenStatus(LifeToken4File"+
@"s, tmp_str1, &quot;In Progress&quot;,&quot;&quot;);&#xD;&#xA;				}&#xD;&#xA;			}&#xD;&#xA;			else&#xD;&#xA;			{&#xD;&#xA;			ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; +  &quot;ASAM file status is failure &quot;+ tmp_str1,ROLogger);&#xD;&#xA;			}&#xD;&#xA;		}&#xD;&#xA;		else&#xD;&#xA;		{&#xD;&#xA;		ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;CheckCommercialFiles -&gt; inside failure case&quot; ,&#xD;&#xA;		ROLogger);&#xD;&#xA;			LifeToken4Files = ROBTLogger.SetTokenStatus(LifeToken4Files, tmp_str1, &quot;Failure&quot;, System.Convert.ToString(retVar1.rMessage));&#xD;&#xA;		}&#xD;&#xA;	}&#xD;&#xA;	else&#xD;&#xA;	{&#xD;&#xA;		ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;CheckIfStatusTagExists -&gt;&quot; + System.Convert.ToString(retVar1.rSuccess),ROLogger);&#xD;&#xA;        LifeToken4Files = ROBTLogger.SetTokenStatus(LifeToken4Files, tmp_str1, &quot;In Progress&quot;,&quot;&quot;);&#xD;&#xA;	}&#xD;&#xA;}&#xD;&#xA;&#xD;&#xA;LoopCounter = LoopCounter + 1;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Attachment DL' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='VariableAssignment' OID='bf1ba650-ebcd-4011-a4f1-816102ae7450' ParentLink='ServiceBody_Statement' LowerBound='491.1' HigherBound='516.1'>
                    <om:Property Name='Expression' Value='&#xD;&#xA;LifeToken4XProt = ROBTLogger.GetOverallTokenStatus(LifeToken4Files);&#xD;&#xA;//&gt;if LifeToken4XProt = &quot;Failure&quot; .... not implemented&#xD;&#xA;// -&gt; better do not skip attachment upload to XProt&#xD;&#xA;&#xD;&#xA;tmp_str1 = System.Convert.ToString(Message_2.RQ1System);&#xD;&#xA;tmp_str2 = Message_2.XProtID;&#xD;&#xA;&#xD;&#xA;// upload all files to RO&#xD;&#xA;&#xD;&#xA;tmp_str3 = ROUpdater1.Attach2XProt(tmp_str1, tmp_str2, &quot;ExchangedFiles&quot;, DLDirName, FileNamesCom, ROLogger, LifeToken4Files);&#xD;&#xA;&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + tmp_str3,ROLogger);&#xD;&#xA;&#xD;&#xA;if (System.Text.RegularExpressions.Regex.IsMatch(tmp_str3,&quot;.*failure:.*&quot;))&#xD;&#xA;{&#xD;&#xA;    // write error log back to FTPLog&#xD;&#xA;    &#xD;&#xA;    LifeToken4Files = ROBTLogger.SetAllTokenStatus(LifeToken4Files, &quot;Failure&quot;, &quot;FTPIssueTransfer: &quot; + tmp_str3);&#xD;&#xA;&#xD;&#xA;} &#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;Final Log update -&gt;&quot; + tmp_str1 + &quot;,&quot; + tmp_str2,&#xD;&#xA;ROLogger);&#xD;&#xA;&#xD;&#xA;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Expression_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='Construct' OID='3bf0f9a0-76ac-4d3b-b036-f5df2330ddd1' ParentLink='ServiceBody_Statement' LowerBound='516.1' HigherBound='536.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_3' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='59e0fdb1-320b-4263-bf9f-a9d86286c686' ParentLink='ComplexStatement_Statement' LowerBound='519.1' HigherBound='521.1'>
                        <om:Property Name='ClassName' Value='FTPIssueTransfer.Map2TransferResult' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='3f71b0c2-1eed-4469-92f5-66192a9e6881' ParentLink='Transform_InputMessagePartRef' LowerBound='520.78' HigherBound='520.87'>
                            <om:Property Name='MessageRef' Value='Message_2' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='1b535c38-1bde-4525-af1b-e49c4af5d781' ParentLink='Transform_OutputMessagePartRef' LowerBound='520.28' HigherBound='520.37'>
                            <om:Property Name='MessageRef' Value='Message_3' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageAssignment' OID='72c59a52-eab3-4403-a213-1cae5589a6d6' ParentLink='ComplexStatement_Statement' LowerBound='521.1' HigherBound='535.1'>
                        <om:Property Name='Expression' Value='//TEST&#xD;&#xA;Message_3.DownloadTargetPath = RB.FTPLibrary.GlobalConstants.FTP_LOCAL_BASE_DIR + DLDirOut + &quot;\\&quot;;&#xD;&#xA;Message_3.LifeToken4XProt = LifeToken4XProt;&#xD;&#xA;Message_3.LifeToken4Files = LifeToken4Files;&#xD;&#xA;Message_3.Mode = TransferMode;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;tmp_str1 = Message_3.RQ1System;&#xD;&#xA;tmp_str2 = tmp_str1.Substring(tmp_str1.LastIndexOf(&quot;@&quot;)+1);&#xD;&#xA;&#xD;&#xA;//msgFileName = Message_2(FILE.ReceivedFileName);&#xD;&#xA;Message_3(FILE.ReceivedFileName) = tmp_str2 + &quot;_&quot; + Message_3.XProtID + &quot;_005_FTPTransferResult_&quot;;&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='MessageAssignment_2' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='ce8e640d-51af-452e-bac8-97c6feedbe85' ParentLink='Construct_MessageRef' LowerBound='517.23' HigherBound='517.32'>
                        <om:Property Name='Ref' Value='Message_3' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='VariableAssignment' OID='786be4f1-9fe3-428d-afa4-eec0f349d177' ParentLink='ServiceBody_Statement' LowerBound='536.1' HigherBound='540.1'>
                    <om:Property Name='Expression' Value='ROBTLogger.CloseLogger(ROLogger);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='CloseLogger' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='5afd2eb4-24b1-4c3a-a947-8a34ec3fb290' ParentLink='ServiceBody_Statement' LowerBound='540.1' HigherBound='542.1'>
                    <om:Property Name='PortName' Value='TR_P' />
                    <om:Property Name='MessageName' Value='Message_3' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='e5308ac7-af57-4a73-9cae-e19955356c4d' ParentLink='ServiceBody_Statement' LowerBound='542.1' HigherBound='544.1'>
                    <om:Property Name='PortName' Value='TR_CPY' />
                    <om:Property Name='MessageName' Value='Message_3' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_3' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='d5c87afd-c58a-49ac-bac2-443a9ea5456e' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='42.1' HigherBound='44.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='FTPIssueTransfer.RequestResponse_Type' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RR_P' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='52ba9012-6561-467b-ac6a-2a431276ded5' ParentLink='PortDeclaration_CLRAttribute' LowerBound='42.1' HigherBound='43.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='1a840fb0-f7c1-4e69-9f23-e5f88d29e61e' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='44.1' HigherBound='46.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='78' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='FTPIssueTransfer.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TR_P' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='2bba4bc9-22a3-4ec3-9eef-31ad5bf13f43' ParentLink='PortDeclaration_CLRAttribute' LowerBound='44.1' HigherBound='45.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='4bf094de-3669-41c5-8d12-f7c9a780a4ee' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='46.1' HigherBound='48.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='FTPIssueTransfer.PortType_2' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TR_CPY' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='15e4bb1d-c81f-4c9f-ad7b-ef01496355ed' ParentLink='PortDeclaration_CLRAttribute' LowerBound='46.1' HigherBound='47.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
    <om:Element Type='PrintElement' OID='4c1d7b45-d4b1-4f24-8f74-0be395cdebc7'>
        <om:Property Name='Bottom' Value='0' />
        <om:Property Name='FooterBottom' Value='0' />
        <om:Property Name='FooterCenter' Value='0' />
        <om:Property Name='FooterMargin' Value='0' />
        <om:Property Name='FooterTop' Value='0' />
        <om:Property Name='HeaderBottom' Value='0' />
        <om:Property Name='HeaderCenter' Value='0' />
        <om:Property Name='HeaderMargin' Value='0' />
        <om:Property Name='HeaderTop' Value='0' />
        <om:Property Name='Left' Value='79' />
        <om:Property Name='PagesAcross' Value='0' />
        <om:Property Name='PagesDown' Value='0' />
        <om:Property Name='Right' Value='0' />
        <om:Property Name='Scaling' Value='80' />
        <om:Property Name='Top' Value='0' />
        <om:Property Name='Orientation' Value='Portrait' />
        <om:Property Name='Signal' Value='False' />
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __FTPStartIssueImport_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __FTPStartIssueImport_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "FTPStartIssueImport")
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
                FTPStartIssueImport __svc__ = (FTPStartIssueImport)_service;
                __FTPStartIssueImport_root_0 __ctx0__ = (__FTPStartIssueImport_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.TR_CPY != null)
                {
                    __svc__.TR_CPY.Close(this, null);
                    __svc__.TR_CPY = null;
                }
                if (__svc__.RR_P != null)
                {
                    __svc__.RR_P.Close(this, null);
                    __svc__.RR_P = null;
                }
                if (__svc__.TR_P != null)
                {
                    __svc__.TR_P.Close(this, null);
                    __svc__.TR_P = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __FTPStartIssueImport_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __FTPStartIssueImport_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "FTPStartIssueImport")
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
                FTPStartIssueImport __svc__ = (FTPStartIssueImport)_service;
                __FTPStartIssueImport_1 __ctx1__ = (__FTPStartIssueImport_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__ROBTLogger = null;
                if (__ctx1__ != null)
                    __ctx1__.__LifeToken4XProt = null;
                if (__ctx1__ != null)
                    __ctx1__.__FTPHandler1 = null;
                if (__ctx1__ != null && __ctx1__.__Message_3 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Message_3);
                    __ctx1__.__Message_3 = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__tmp_str4 = null;
                if (__ctx1__ != null)
                    __ctx1__.__tmp_str2 = null;
                if (__ctx1__ != null)
                    __ctx1__.__FileNames = null;
                if (__ctx1__ != null)
                    __ctx1__.__InterfaceName = null;
                if (__ctx1__ != null)
                    __ctx1__.__LifeToken4Files = null;
                if (__ctx1__ != null)
                    __ctx1__.__retVar2 = null;
                if (__ctx1__ != null)
                    __ctx1__.__DLDirName = null;
                if (__ctx1__ != null)
                    __ctx1__.__TargetSystem = null;
                if (__ctx1__ != null && __ctx1__.__Message_1 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Message_1);
                    __ctx1__.__Message_1 = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__retVar3 = null;
                if (__ctx1__ != null)
                    __ctx1__.__TransferMode = null;
                if (__ctx1__ != null)
                    __ctx1__.__DLDirOut = null;
                if (__ctx1__ != null)
                    __ctx1__.__FileNamesCom = null;
                if (__ctx1__ != null)
                    __ctx1__.__retVar1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__tmp_str1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__ROUpdater1 = null;
                if (__ctx1__ != null && __ctx1__.__Message_2 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Message_2);
                    __ctx1__.__Message_2 = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__tmp_str3 = null;
                if (__ctx1__ != null)
                    __ctx1__.__ROLogger = null;
                if (__ctx1__ != null)
                    __ctx1__.__tmp_str5 = null;
                if (__ctx1__ != null)
                    __ctx1__.__unModifiedAIFileName = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Message_3")]
            public __messagetype_FTPIssueTransfer_TransferResultInformation __Message_3;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Message_1")]
            public __messagetype_FTPIssueTransfer_StartImportSchema __Message_1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Message_2")]
            public __messagetype_FTPIssueTransfer_StartImportSchema __Message_2;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ChildNumber")]
            internal System.Int32 __ChildNumber;
            [Microsoft.XLANGs.Core.UserVariableAttribute("LoopCounter")]
            internal System.Int32 __LoopCounter;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tmp_str1")]
            internal System.String __tmp_str1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tmp_str2")]
            internal System.String __tmp_str2;
            [Microsoft.XLANGs.Core.UserVariableAttribute("FileNames")]
            internal System.String __FileNames;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DLDirName")]
            internal System.String __DLDirName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("InterfaceName")]
            internal System.String __InterfaceName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("result")]
            internal System.Boolean __result;
            [Microsoft.XLANGs.Core.UserVariableAttribute("FTPHandler1")]
            internal RB.FTPLibrary.FTPHandler __FTPHandler1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("LifeToken4Files")]
            internal System.String __LifeToken4Files;
            [Microsoft.XLANGs.Core.UserVariableAttribute("LifeToken4XProt")]
            internal System.String __LifeToken4XProt;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tmp_str3")]
            internal System.String __tmp_str3;
            [Microsoft.XLANGs.Core.UserVariableAttribute("FileNamesCom")]
            internal System.String __FileNamesCom;
            [Microsoft.XLANGs.Core.UserVariableAttribute("retVar1")]
            internal RB.FTPLibrary.retStrBool __retVar1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("retVar2")]
            internal RB.FTPLibrary.retStrBool __retVar2;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TargetSystem")]
            internal System.String __TargetSystem;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ROUpdater1")]
            internal RB.BTLoggerLibrary.ROUpdater __ROUpdater1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ROLogger")]
            internal RB.BTLoggerLibrary.Logger __ROLogger;
            [Microsoft.XLANGs.Core.UserVariableAttribute("resultCharCheck")]
            internal System.Boolean __resultCharCheck;
            [Microsoft.XLANGs.Core.UserVariableAttribute("retVar3")]
            internal RB.FTPLibrary.retStrBool __retVar3;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TransferMode")]
            internal System.String __TransferMode;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ROBTLogger")]
            internal RB.BTLoggerLibrary.BTLogger __ROBTLogger;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DLDirOut")]
            internal System.String __DLDirOut;
            [Microsoft.XLANGs.Core.UserVariableAttribute("isMsgAck")]
            internal System.Boolean __isMsgAck;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tmp_str4")]
            internal System.String __tmp_str4;
            [Microsoft.XLANGs.Core.UserVariableAttribute("isValid")]
            internal System.Boolean __isValid;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tmp_str5")]
            internal System.String __tmp_str5;
            [Microsoft.XLANGs.Core.UserVariableAttribute("unModifiedAIFileName")]
            internal System.String __unModifiedAIFileName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("isattachmentValid")]
            internal System.Boolean __isattachmentValid;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("RR_P")]
        internal RequestResponse_Type RR_P;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("TR_P")]
        internal PortType_1 TR_P;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("TR_CPY")]
        internal PortType_2 TR_CPY;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {RequestResponse_Type.Operation_1},
                                               typeof(FTPStartIssueImport).GetField("RR_P", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(FTPStartIssueImport), "RR_P"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_1.Operation_1},
                                               typeof(FTPStartIssueImport).GetField("TR_P", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(FTPStartIssueImport), "TR_P"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_2.Operation_1},
                                               typeof(FTPStartIssueImport).GetField("TR_CPY", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(FTPStartIssueImport), "TR_CPY"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "bb436360-b0ac-48f7-87d8-fd2073c65120", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "bb436360-b0ac-48f7-87d8-fd2073c65120", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "66130cf7-920e-44e7-8df0-2dabfbd86f6e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "66130cf7-920e-44e7-8df0-2dabfbd86f6e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "c9cae778-de51-4acb-ba3f-9c3cd584daf4", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "c9cae778-de51-4acb-ba3f-9c3cd584daf4", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "521a27de-b290-4a19-a00f-89bc7d3b27d2", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "521a27de-b290-4a19-a00f-89bc7d3b27d2", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "85e3fb3d-1160-48fe-97cc-542e6fd357a9", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "77519480-c6ff-40bc-aace-71b2815459a5", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "77519480-c6ff-40bc-aace-71b2815459a5", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "85e3fb3d-1160-48fe-97cc-542e6fd357a9", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "b130cf5c-d2cc-4681-a60a-8a15afce9b26", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "b130cf5c-d2cc-4681-a60a-8a15afce9b26", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "a34056f3-e6dd-4296-b6e0-1a69768a1ba2", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "a34056f3-e6dd-4296-b6e0-1a69768a1ba2", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "a4cf53ec-e2ab-4907-9afb-cbbbf9a3c12f", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "a4cf53ec-e2ab-4907-9afb-cbbbf9a3c12f", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "e1ef5518-eec4-4da3-893c-24333370a024", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "611cf214-8376-48d6-b5d4-94d3cb168dca", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "611cf214-8376-48d6-b5d4-94d3cb168dca", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "e1ef5518-eec4-4da3-893c-24333370a024", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "bf1ba650-ebcd-4011-a4f1-816102ae7450", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "bf1ba650-ebcd-4011-a4f1-816102ae7450", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "3bf0f9a0-76ac-4d3b-b036-f5df2330ddd1", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "3bf0f9a0-76ac-4d3b-b036-f5df2330ddd1", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "786be4f1-9fe3-428d-afa4-eec0f349d177", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "786be4f1-9fe3-428d-afa4-eec0f349d177", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(30, "5afd2eb4-24b1-4c3a-a947-8a34ec3fb290", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(31, "5afd2eb4-24b1-4c3a-a947-8a34ec3fb290", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(32, "e5308ac7-af57-4a73-9cae-e19955356c4d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(33, "e5308ac7-af57-4a73-9cae-e19955356c4d", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,4,4,5,6,6,7,7,8,8,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,10,10,10,11,11,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,13,13,13,14,14,15,16,16,16,17,18,18,19,19,20,20,20,21,21,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,22,23,23,23,24,24,25,25,25,25,25,25,25,25,25,25,26,26,27,28,28,29,30,30,30,31,32,32,32,33,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __FTPStartIssueImport_1 __ctx1__ = (__FTPStartIssueImport_1)_stateMgrs[1];
            __FTPStartIssueImport_root_0 __ctx0__ = (__FTPStartIssueImport_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                RR_P = new RequestResponse_Type(0, this);
                TR_P = new PortType_1(1, this);
                TR_CPY = new PortType_2(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], RR_P, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __FTPStartIssueImport_1(this);
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
            __FTPStartIssueImport_1 __ctx1__ = (__FTPStartIssueImport_1)_stateMgrs[1];
            __FTPStartIssueImport_root_0 __ctx0__ = (__FTPStartIssueImport_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__ChildNumber = default(System.Int32);
                __ctx1__.__LoopCounter = default(System.Int32);
                __ctx1__.__tmp_str1 = default(System.String);
                __ctx1__.__tmp_str2 = default(System.String);
                __ctx1__.__FileNames = default(System.String);
                __ctx1__.__DLDirName = default(System.String);
                __ctx1__.__InterfaceName = default(System.String);
                __ctx1__.__result = default(System.Boolean);
                __ctx1__.__FTPHandler1 = default(RB.FTPLibrary.FTPHandler);
                __ctx1__.__LifeToken4Files = default(System.String);
                __ctx1__.__LifeToken4XProt = default(System.String);
                __ctx1__.__tmp_str3 = default(System.String);
                __ctx1__.__FileNamesCom = default(System.String);
                __ctx1__.__retVar1 = default(RB.FTPLibrary.retStrBool);
                __ctx1__.__retVar2 = default(RB.FTPLibrary.retStrBool);
                __ctx1__.__TargetSystem = default(System.String);
                __ctx1__.__ROUpdater1 = default(RB.BTLoggerLibrary.ROUpdater);
                __ctx1__.__ROLogger = default(RB.BTLoggerLibrary.Logger);
                __ctx1__.__resultCharCheck = default(System.Boolean);
                __ctx1__.__retVar3 = default(RB.FTPLibrary.retStrBool);
                __ctx1__.__TransferMode = default(System.String);
                __ctx1__.__ROBTLogger = default(RB.BTLoggerLibrary.BTLogger);
                __ctx1__.__DLDirOut = default(System.String);
                __ctx1__.__isMsgAck = default(System.Boolean);
                __ctx1__.__tmp_str4 = default(System.String);
                __ctx1__.__isValid = default(System.Boolean);
                __ctx1__.__tmp_str5 = default(System.String);
                __ctx1__.__unModifiedAIFileName = default(System.String);
                __ctx1__.__isattachmentValid = default(System.Boolean);
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
                if (!RR_P.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Message_1 != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Message_1);
                __ctx1__.__Message_1 = new __messagetype_FTPIssueTransfer_StartImportSchema("Message_1", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Message_1);
                RR_P.ReceiveMessage(0, __msgEnv__, __ctx1__.__Message_1, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Message_1);
                    __edata.PortName = @"RR_P";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__tmp_str1 = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__tmp_str2 = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__FileNames = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__DLDirName = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__InterfaceName = "";
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__result = true;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__FTPHandler1 = new RB.FTPLibrary.FTPHandler();
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__LifeToken4Files = "";
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __ctx1__.__LifeToken4XProt = "";
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.__tmp_str3 = "";
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                __ctx1__.__FileNamesCom = "";
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                __ctx1__.__retVar1 = new RB.FTPLibrary.retStrBool();
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                __ctx1__.__retVar2 = new RB.FTPLibrary.retStrBool();
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                __ctx1__.__TargetSystem = "";
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                __ctx1__.__ROUpdater1 = new RB.BTLoggerLibrary.ROUpdater();
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                __ctx1__.__resultCharCheck = true;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                __ctx1__.__retVar3 = new RB.FTPLibrary.retStrBool();
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                __ctx1__.__TransferMode = "";
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                __ctx1__.__ROBTLogger = new RB.BTLoggerLibrary.BTLogger();
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                __ctx1__.__DLDirOut = "";
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                __ctx1__.__isMsgAck = true;
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                __ctx1__.__tmp_str4 = "";
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                __ctx1__.__isValid = true;
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                __ctx1__.__tmp_str5 = "";
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                __ctx1__.__unModifiedAIFileName = "";
                if (__ctx1__ != null)
                    __ctx1__.__unModifiedAIFileName = null;
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                __ctx1__.__isattachmentValid = true;
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Request received at " + System.String.Format("{0:yyyyMMdd-HHmmssffffff - }", System.DateTime.Now));
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                __ctx1__.__ROLogger = __ctx1__.__ROBTLogger.GetLogger((System.String)__ctx1__.__Message_1.part.GetDistinguishedField("InterfaceName"), (System.String)__ctx1__.__Message_1.part.GetDistinguishedField("XProtID"), "Import");
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmssffffff - }", System.DateTime.Now) + "After receiving Request", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 38;
            case 38:
                if ( !PreProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 39;
            case 39:
                __ctx1__.__tmp_str1 = (System.String)__ctx1__.__Message_1.part.GetDistinguishedField("RQ1System");
                if ( !PostProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 40;
            case 40:
                if ( !PreProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 41;
            case 41:
                __ctx1__.__tmp_str2 = (System.String)__ctx1__.__Message_1.part.GetDistinguishedField("XProtID");
                if ( !PostProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 42;
            case 42:
                __ctx1__.__InterfaceName = System.Convert.ToString((System.String)__ctx1__.__Message_1.part.GetDistinguishedField("InterfaceName"));
                if ( !PostProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 43;
            case 43:
                __ctx1__.__TargetSystem = System.Convert.ToString((System.String)__ctx1__.__Message_1.part.GetDistinguishedField("RQ1System"));
                if ( !PostProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 44;
            case 44:
                __ctx1__.__FTPHandler1 = new RB.FTPLibrary.FTPHandler(__ctx1__.__InterfaceName, __ctx1__.__TargetSystem);
                if (__ctx1__ != null)
                    __ctx1__.__TargetSystem = null;
                if (__ctx1__ != null)
                    __ctx1__.__InterfaceName = null;
                if ( !PostProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 45;
            case 45:
                __ctx1__.__DLDirName = System.String.Format("{0:yyyyMMdd-HHmmss_}", System.DateTime.Now) + __ctx1__.__tmp_str1 + "_" + __ctx1__.__tmp_str2;
                if ( !PostProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 46;
            case 46:
                __ctx1__.__DLDirOut = System.String.Format("{0:yyyyMMdd-HHmmss_}", System.DateTime.Now) + __ctx1__.__tmp_str1 + "_" + __ctx1__.__tmp_str2;
                if ( !PostProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 47;
            case 47:
                __ctx1__.__TransferMode = __ctx1__.__FTPHandler1.GetTransferMode((System.String)__ctx1__.__Message_1.part.GetDistinguishedField("FTPFileNames"));
                if ( !PostProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 48;
            case 48:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : TransferMode : " + __ctx1__.__TransferMode, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 49;
            case 49:
                if ( !PreProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 50;
            case 50:
                __condition__ = __ctx1__.__TransferMode.ToUpper() == "AUTOMATIC";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 53 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 53;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 51;
            case 51:
                __ctx1__.__DLDirName = __ctx1__.__FTPHandler1.GetDLDirNameForXPROTCreation((System.String)__ctx1__.__Message_1.part.GetDistinguishedField("FTPFileNames"), __ctx1__.__tmp_str1, __ctx1__.__tmp_str2);
                if ( !PostProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 52;
            case 52:
                __ctx1__.__DLDirOut = System.String.Format("{0:yyyyMMdd-HHmmss_}", System.DateTime.Now) + __ctx1__.__tmp_str1 + "_" + __ctx1__.__tmp_str2;
                if ( !PostProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 53;
            case 53:
                if ( !PreProgressInc( __seg__, __ctx__, 54 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 54;
            case 54:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : Download directory  : " + __ctx1__.__DLDirName, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 55 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 55;
            case 55:
                __ctx1__.__tmp_str1 = __ctx1__.__FTPHandler1.GetFileNamesForXPROTCreation((System.String)__ctx1__.__Message_1.part.GetDistinguishedField("FTPFileNames"));
                if ( !PostProgressInc( __seg__, __ctx__, 56 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 56;
            case 56:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : GetFileNamesForXPROTCreation  : " + __ctx1__.__tmp_str1, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 57 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 57;
            case 57:
                __ctx1__.__tmp_str4 = __ctx1__.__tmp_str1;
                if ( !PostProgressInc( __seg__, __ctx__, 58 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 58;
            case 58:
                if ( !PreProgressInc( __seg__, __ctx__, 59 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 59;
            case 59:
                __condition__ = __ctx1__.__FTPHandler1.canSortFiles == "1";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 62 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 62;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 60 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 60;
            case 60:
                __ctx1__.__tmp_str1 = __ctx1__.__FTPHandler1.GetSortedFiles(__ctx1__.__tmp_str1);
                if ( !PostProgressInc( __seg__, __ctx__, 61 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 61;
            case 61:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : GetSortedFiles  : " + __ctx1__.__tmp_str1, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 62 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 62;
            case 62:
                if ( !PreProgressInc( __seg__, __ctx__, 63 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 63;
            case 63:
                __ctx1__.__tmp_str5 = __ctx1__.__tmp_str1;
                if ( !PostProgressInc( __seg__, __ctx__, 64 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 64;
            case 64:
                __ctx1__.__LifeToken4XProt = "In Progress";
                if ( !PostProgressInc( __seg__, __ctx__, 65 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 65;
            case 65:
                __ctx1__.__LifeToken4Files = __ctx1__.__ROBTLogger.InsertAllTokenStatus(__ctx1__.__tmp_str4, "In Progress", "import");
                if ( !PostProgressInc( __seg__, __ctx__, 66 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 66;
            case 66:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : LifeToken4Files  : " + __ctx1__.__LifeToken4Files, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 67 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 67;
            case 67:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "XProtID ->" + __ctx1__.__tmp_str2 + "; Download FileList -> " + __ctx1__.__tmp_str1, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 68 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 68;
            case 68:
                System.Diagnostics.EventLog.WriteEntry("Biztalk : FTPFilenames raw", __ctx1__.__tmp_str1, System.Diagnostics.EventLogEntryType.Information);
                if ( !PostProgressInc( __seg__, __ctx__, 69 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 69;
            case 69:
                __ctx1__.__FileNames = __ctx1__.__FTPHandler1.ConvertToLines(__ctx1__.__tmp_str4, ",");
                if (__ctx1__ != null)
                    __ctx1__.__tmp_str4 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 70 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 70;
            case 70:
                System.Diagnostics.EventLog.WriteEntry("Biztalk : FTPFilenames in Lines", __ctx1__.__FileNames, System.Diagnostics.EventLogEntryType.Information);
                if ( !PostProgressInc( __seg__, __ctx__, 71 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 71;
            case 71:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FileNames : " + __ctx1__.__FileNames, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 72 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 72;
            case 72:
                __ctx1__.__ChildNumber = __ctx1__.__FTPHandler1.CountStringLines(__ctx1__.__FileNames);
                if ( !PostProgressInc( __seg__, __ctx__, 73 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 73;
            case 73:
                System.Diagnostics.EventLog.WriteEntry("Biztalk : ChildNumber", System.Convert.ToString(__ctx1__.__ChildNumber), System.Diagnostics.EventLogEntryType.Information);
                if ( !PostProgressInc( __seg__, __ctx__, 74 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 74;
            case 74:
                __ctx1__.__LoopCounter = 1;
                if ( !PostProgressInc( __seg__, __ctx__, 75 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 75;
            case 75:
                if ( !PreProgressInc( __seg__, __ctx__, 76 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 76;
            case 76:
                __condition__ = __ctx1__.__LoopCounter <= __ctx1__.__ChildNumber;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 148 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 148;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 77 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 77;
            case 77:
                if ( !PreProgressInc( __seg__, __ctx__, 78 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 78;
            case 78:
                if ( !PreProgressInc( __seg__, __ctx__, 79 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 79;
            case 79:
                __ctx1__.__tmp_str1 = __ctx1__.__FTPHandler1.ReadStringLine(__ctx1__.__FileNames, __ctx1__.__LoopCounter);
                if ( !PostProgressInc( __seg__, __ctx__, 80 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 80;
            case 80:
                if ( !PreProgressInc( __seg__, __ctx__, 81 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 81;
            case 81:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "FileDownload started ->" + __ctx1__.__tmp_str1, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 82 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 82;
            case 82:
                System.Diagnostics.EventLog.WriteEntry("Biztalk : SingleFileDownload - single file", __ctx1__.__tmp_str1, System.Diagnostics.EventLogEntryType.Information);
                if ( !PostProgressInc( __seg__, __ctx__, 83 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 83;
            case 83:
                __ctx1__.__isValid = __ctx1__.__FTPHandler1.IsValid(__ctx1__.__tmp_str1, __ctx1__.__tmp_str5);
                if ( !PostProgressInc( __seg__, __ctx__, 84 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 84;
            case 84:
                __ctx1__.__result = __ctx1__.__FTPHandler1.TransferSingleFTPFile(__ctx1__.__tmp_str1, __ctx1__.__DLDirName, __ctx1__.__isValid);
                if ( !PostProgressInc( __seg__, __ctx__, 85 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 85;
            case 85:
                if ( !PreProgressInc( __seg__, __ctx__, 86 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 86;
            case 86:
                __condition__ = __ctx1__.__result;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 89 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 89;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 87 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 87;
            case 87:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "FTPFile successfully downloaded - " + __ctx1__.__tmp_str1, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 88 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 88;
            case 88:
                if ( !PostProgressInc( __seg__, __ctx__, 97 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 97;
            case 89:
                if ( !PreProgressInc( __seg__, __ctx__, 90 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 90;
            case 90:
                __condition__ = __ctx1__.__isValid;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 94 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 94;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 91 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 91;
            case 91:
                __ctx1__.__LifeToken4Files = __ctx1__.__ROBTLogger.SetTokenStatus(__ctx1__.__LifeToken4Files, __ctx1__.__tmp_str1, "Failure", "download failed");
                if ( !PostProgressInc( __seg__, __ctx__, 92 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 92;
            case 92:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "Error - FTPFile not available on FTPServer - " + __ctx1__.__tmp_str1, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 93 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 93;
            case 93:
                if ( !PostProgressInc( __seg__, __ctx__, 96 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 96;
            case 94:
                __ctx1__.__LifeToken4Files = __ctx1__.__ROBTLogger.SetTokenStatus(__ctx1__.__LifeToken4Files, __ctx1__.__tmp_str1, "Failure", "File Name is not valid. Please provide valid file name.");
                if ( !PostProgressInc( __seg__, __ctx__, 95 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 95;
            case 95:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "Error - FTPFile name is not valid. Please provide valid file name - " + __ctx1__.__tmp_str1, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 96 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 96;
            case 96:
                if ( !PreProgressInc( __seg__, __ctx__, 97 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 97;
            case 97:
                if ( !PreProgressInc( __seg__, __ctx__, 98 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 98;
            case 98:
                if ( !PreProgressInc( __seg__, __ctx__, 99 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 99;
            case 99:
                __condition__ = __ctx1__.__result;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 106 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 106;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 100 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 100;
            case 100:
                __ctx1__.__result = __ctx1__.__FTPHandler1.CheckforEmptyFTPFile(__ctx1__.__tmp_str1, __ctx1__.__DLDirName);
                if ( !PostProgressInc( __seg__, __ctx__, 101 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 101;
            case 101:
                if ( !PreProgressInc( __seg__, __ctx__, 102 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 102;
            case 102:
                __condition__ = !__ctx1__.__result;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 105 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 105;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 103 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 103;
            case 103:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "FTPFile size is 0 bytes - " + __ctx1__.__tmp_str1, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 104 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 104;
            case 104:
                __ctx1__.__LifeToken4Files = __ctx1__.__ROBTLogger.SetTokenStatus(__ctx1__.__LifeToken4Files, __ctx1__.__tmp_str1, "Failure", "ASAM file is empty");
                if ( !PostProgressInc( __seg__, __ctx__, 105 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 105;
            case 105:
                if ( !PreProgressInc( __seg__, __ctx__, 106 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 106;
            case 106:
                if ( !PreProgressInc( __seg__, __ctx__, 107 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 107;
            case 107:
                __ctx1__.__isattachmentValid = __ctx1__.__FTPHandler1.VerifyAttachmentNames(__ctx1__.__tmp_str1, __ctx1__.__DLDirName);
                if ( !PostProgressInc( __seg__, __ctx__, 108 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 108;
            case 108:
                if ( !PreProgressInc( __seg__, __ctx__, 109 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 109;
            case 109:
                __condition__ = !__ctx1__.__isattachmentValid;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 111 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 111;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 110 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 110;
            case 110:
                __ctx1__.__LifeToken4Files = __ctx1__.__ROBTLogger.SetTokenStatus(__ctx1__.__LifeToken4Files, __ctx1__.__tmp_str1, "Failure", "Invalid Character in the attachment name. Please provide valid attachment name.");
                if ( !PostProgressInc( __seg__, __ctx__, 111 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 111;
            case 111:
                if ( !PreProgressInc( __seg__, __ctx__, 112 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 112;
            case 112:
                if ( !PreProgressInc( __seg__, __ctx__, 113 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 113;
            case 113:
                __condition__ = __ctx1__.__result;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 133 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 133;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 114 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 114;
            case 114:
                __ctx1__.__retVar3 = __ctx1__.__FTPHandler1.DetectInvalidCharacter(__ctx1__.__tmp_str1, __ctx1__.__DLDirName);
                if ( !PostProgressInc( __seg__, __ctx__, 115 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 115;
            case 115:
                __ctx1__.__tmp_str2 = __ctx1__.__retVar3.rMessage;
                if ( !PostProgressInc( __seg__, __ctx__, 116 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 116;
            case 116:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "DetectInvalidChar " + " - " + __ctx1__.__tmp_str2, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 117 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 117;
            case 117:
                if ( !PreProgressInc( __seg__, __ctx__, 118 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 118;
            case 118:
                __condition__ = System.Text.RegularExpressions.Regex.IsMatch(__ctx1__.__tmp_str2, ".*failure:.*");
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 125 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 125;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 119 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 119;
            case 119:
                __ctx1__.__resultCharCheck = false;
                if ( !PostProgressInc( __seg__, __ctx__, 120 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 120;
            case 120:
                __ctx1__.__tmp_str3 = System.Text.RegularExpressions.Regex.Replace(__ctx1__.__tmp_str2, ".*failure:(.*)", "$1");
                if ( !PostProgressInc( __seg__, __ctx__, 121 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 121;
            case 121:
                __ctx1__.__tmp_str3 = System.Text.RegularExpressions.Regex.Replace(__ctx1__.__tmp_str3, @".*(invalid character.*)", "$1", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if ( !PostProgressInc( __seg__, __ctx__, 122 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 122;
            case 122:
                __ctx1__.__LifeToken4Files = __ctx1__.__ROBTLogger.SetTokenStatus(__ctx1__.__LifeToken4Files, __ctx1__.__tmp_str1, "Failure", __ctx1__.__tmp_str3);
                if ( !PostProgressInc( __seg__, __ctx__, 123 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 123;
            case 123:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + __ctx1__.__tmp_str2 + " - " + __ctx1__.__tmp_str1, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 124 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 124;
            case 124:
                if ( !PostProgressInc( __seg__, __ctx__, 132 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 132;
            case 125:
                if ( !PreProgressInc( __seg__, __ctx__, 126 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 126;
            case 126:
                __condition__ = System.Text.RegularExpressions.Regex.IsMatch(__ctx1__.__retVar3.rString, ".*Chars replaced in asam file*");
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 130 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 130;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 127 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 127;
            case 127:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "FTPFile change lifetoken", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 128 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 128;
            case 128:
                __ctx1__.__LifeToken4Files = __ctx1__.__ROBTLogger.ChangeFileNameInToken(__ctx1__.__LifeToken4Files, __ctx1__.__tmp_str1);
                if ( !PostProgressInc( __seg__, __ctx__, 129 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 129;
            case 129:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "FTPFile updated lifetoken - " + __ctx1__.__LifeToken4Files, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 130 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 130;
            case 130:
                if ( !PreProgressInc( __seg__, __ctx__, 131 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 131;
            case 131:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "FTPFile successfully checked for ISO conformance - " + __ctx1__.__tmp_str1, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 132 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 132;
            case 132:
                if ( !PreProgressInc( __seg__, __ctx__, 133 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 133;
            case 133:
                if ( !PreProgressInc( __seg__, __ctx__, 134 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 134;
            case 134:
                if ( !PreProgressInc( __seg__, __ctx__, 135 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 135;
            case 135:
                __condition__ = __ctx1__.__result && __ctx1__.__resultCharCheck;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 144 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 144;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 136 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 136;
            case 136:
                __ctx1__.__retVar1 = __ctx1__.__FTPHandler1.ValidateAIFileByXSD(__ctx1__.__tmp_str1, __ctx1__.__DLDirName);
                if ( !PostProgressInc( __seg__, __ctx__, 137 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 137;
            case 137:
                if ( !PreProgressInc( __seg__, __ctx__, 138 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 138;
            case 138:
                __condition__ = __ctx1__.__retVar1.rSuccess;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 141 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 141;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 139 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 139;
            case 139:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "ASAM file successfully validated - " + __ctx1__.__tmp_str1, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 140 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 140;
            case 140:
                if ( !PostProgressInc( __seg__, __ctx__, 143 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 143;
            case 141:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "Error from xsd validation retVar1 msg = " + __ctx1__.__retVar1.rMessage + " tmp_str1=" + __ctx1__.__tmp_str1, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 142 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 142;
            case 142:
                __ctx1__.__LifeToken4Files = __ctx1__.__ROBTLogger.SetTokenStatus(__ctx1__.__LifeToken4Files, __ctx1__.__tmp_str1, "Failure", "xsd validation of asam file failed with error: " + __ctx1__.__retVar1.rMessage);
                if ( !PostProgressInc( __seg__, __ctx__, 143 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 143;
            case 143:
                if ( !PreProgressInc( __seg__, __ctx__, 144 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 144;
            case 144:
                if ( !PreProgressInc( __seg__, __ctx__, 145 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 145;
            case 145:
                __ctx1__.__LoopCounter = __ctx1__.__LoopCounter + 1;
                if ( !PostProgressInc( __seg__, __ctx__, 146 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 146;
            case 146:
                if ( !PreProgressInc( __seg__, __ctx__, 147 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 147;
            case 147:
                if ( !PostProgressInc( __seg__, __ctx__, 76 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 76;
            case 148:
                if ( !PreProgressInc( __seg__, __ctx__, 149 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__tmp_str5 = null;
                if (__ctx1__ != null)
                    __ctx1__.__retVar3 = null;
                Tracker.FireEvent(__eventLocations[13],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 149;
            case 149:
                if ( !PreProgressInc( __seg__, __ctx__, 150 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 150;
            case 150:
                {
                    __messagetype_FTPIssueTransfer_StartImportSchema __Message_2 = new __messagetype_FTPIssueTransfer_StartImportSchema("Message_2", __ctx1__);

                    __ctx1__.__LifeToken4XProt = __ctx1__.__ROBTLogger.GetOverallTokenStatus(__ctx1__.__LifeToken4Files);
                    __Message_2.CopyFrom(__ctx1__.__Message_1);
                    if (__ctx1__ != null && __ctx1__.__Message_1 != null)
                    {
                        __ctx1__.UnrefMessage(__ctx1__.__Message_1);
                        __ctx1__.__Message_1 = null;
                    }
                    __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "Result of xml downloads -> " + __ctx1__.__LifeToken4XProt, __ctx1__.__ROLogger);
                    __Message_2.part.SetDistinguishedField("BTReturnMsg", "");
                    __Message_2.part.LoadFrom(__ctx1__.__FTPHandler1.AddDummyTagToResponse(__Message_2.part.TypedValue));
                    __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "Added Dummy tag to response", __ctx1__.__ROLogger);

                    if (__ctx1__.__Message_2 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Message_2);
                    __ctx1__.__Message_2 = __Message_2;
                    __ctx1__.RefMessage(__ctx1__.__Message_2);
                }
                __ctx1__.__Message_2.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 151 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 151;
            case 151:
                if ( !PreProgressInc( __seg__, __ctx__, 152 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Message_2);
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 152;
            case 152:
                if ( !PreProgressInc( __seg__, __ctx__, 153 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[11],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 153;
            case 153:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 154 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 154;
            case 154:
                if ( !PreProgressInc( __seg__, __ctx__, 155 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                RR_P.SendMessage(0, __ctx1__.__Message_2, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (RR_P != null)
                {
                    RR_P.Close(__ctx1__, __seg__);
                    RR_P = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 155;
            case 155:
                if ( !PreProgressInc( __seg__, __ctx__, 156 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Message_2);
                    __edata.PortName = @"RR_P";
                    Tracker.FireEvent(__eventLocations[17],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 156;
            case 156:
                if ( !PreProgressInc( __seg__, __ctx__, 157 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 157;
            case 157:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmssffffff - }", System.DateTime.Now) + "After sending Response", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 158 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 158;
            case 158:
                if ( !PreProgressInc( __seg__, __ctx__, 159 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 159;
            case 159:
                __ctx1__.__LoopCounter = 1;
                if ( !PostProgressInc( __seg__, __ctx__, 160 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 160;
            case 160:
                if ( !PreProgressInc( __seg__, __ctx__, 161 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 161;
            case 161:
                __condition__ = __ctx1__.__LoopCounter <= __ctx1__.__ChildNumber;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 222 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 222;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 162 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 162;
            case 162:
                if ( !PreProgressInc( __seg__, __ctx__, 163 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 163;
            case 163:
                if ( !PreProgressInc( __seg__, __ctx__, 164 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 164;
            case 164:
                __ctx1__.__tmp_str1 = __ctx1__.__FTPHandler1.ReadStringLine(__ctx1__.__FileNames, __ctx1__.__LoopCounter);
                if ( !PostProgressInc( __seg__, __ctx__, 165 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 165;
            case 165:
                if ( !PreProgressInc( __seg__, __ctx__, 166 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 166;
            case 166:
                __ctx1__.__tmp_str1 = __ctx1__.__ROBTLogger.GetFileName(__ctx1__.__LifeToken4Files, __ctx1__.__tmp_str1);
                if ( !PostProgressInc( __seg__, __ctx__, 167 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 167;
            case 167:
                if ( !PreProgressInc( __seg__, __ctx__, 168 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 168;
            case 168:
                __condition__ = __ctx1__.__ROBTLogger.GetTokenStatusForFile(__ctx1__.__LifeToken4Files, __ctx1__.__tmp_str1) != "Failure";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 218 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 218;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 169 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 169;
            case 169:
                __ctx1__.__retVar1 = __ctx1__.__FTPHandler1.CheckIfStatusTagExists(__ctx1__.__tmp_str1, __ctx1__.__DLDirName);
                if ( !PostProgressInc( __seg__, __ctx__, 170 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 170;
            case 170:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "CheckIfStatusTagExists ->" + __ctx1__.__retVar1.rSuccess.ToString(), __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 171 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 171;
            case 171:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "CheckIfStatusTagExists ->" + __ctx1__.__retVar1.rMessage, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 172 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 172;
            case 172:
                if ( !PreProgressInc( __seg__, __ctx__, 173 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 173;
            case 173:
                __condition__ = __ctx1__.__retVar1.rSuccess;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 176 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 176;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 174 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 174;
            case 174:
                __ctx1__.__isMsgAck = false;
                if ( !PostProgressInc( __seg__, __ctx__, 175 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 175;
            case 175:
                if ( !PostProgressInc( __seg__, __ctx__, 177 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 177;
            case 176:
                __ctx1__.__isMsgAck = true;
                if ( !PostProgressInc( __seg__, __ctx__, 177 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 177;
            case 177:
                if ( !PreProgressInc( __seg__, __ctx__, 178 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 178;
            case 178:
                if ( !PreProgressInc( __seg__, __ctx__, 179 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 179;
            case 179:
                __condition__ = !__ctx1__.__isMsgAck;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 215 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 215;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 180 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 180;
            case 180:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "AttachmentDownload of ->" + __ctx1__.__tmp_str1, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 181 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 181;
            case 181:
                __ctx1__.__retVar1 = __ctx1__.__FTPHandler1.CheckCommercialFiles(__ctx1__.__tmp_str1, __ctx1__.__DLDirName, __ctx1__.__FileNamesCom);
                if ( !PostProgressInc( __seg__, __ctx__, 182 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 182;
            case 182:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "CheckCommercialFiles ->" + System.Convert.ToString(__ctx1__.__retVar1.rSuccess), __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 183 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 183;
            case 183:
                if ( !PreProgressInc( __seg__, __ctx__, 184 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 184;
            case 184:
                __condition__ = __ctx1__.__retVar1.rSuccess;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 211 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 211;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 185 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 185;
            case 185:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "CheckCommercialFiles FileNamesCom->" + __ctx1__.__retVar1.rString, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 186 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 186;
            case 186:
                __ctx1__.__FileNamesCom = System.Convert.ToString(__ctx1__.__retVar1.rString);
                if ( !PostProgressInc( __seg__, __ctx__, 187 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 187;
            case 187:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "CheckCommercialFiles -call GetAttachmentNames->", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 188 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 188;
            case 188:
                __ctx1__.__retVar2 = __ctx1__.__FTPHandler1.GetAttachmentNames(__ctx1__.__tmp_str1, __ctx1__.__DLDirName, false);
                if ( !PostProgressInc( __seg__, __ctx__, 189 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 189;
            case 189:
                __ctx1__.__tmp_str2 = System.Convert.ToString(__ctx1__.__retVar2.rMessage);
                if ( !PostProgressInc( __seg__, __ctx__, 190 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 190;
            case 190:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "CheckCommercialFiles - GetAttachmentNames->" + __ctx1__.__tmp_str2, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 191 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 191;
            case 191:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "Attachments queued for download ->" + __ctx1__.__tmp_str1, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 192 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 192;
            case 192:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "AttachmentsDownload result ->" + __ctx1__.__tmp_str2, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 193 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 193;
            case 193:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "ASAM file " + __ctx1__.__tmp_str1 + "LifeToken4Files" + __ctx1__.__LifeToken4Files, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 194 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 194;
            case 194:
                if ( !PreProgressInc( __seg__, __ctx__, 195 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 195;
            case 195:
                __condition__ = __ctx1__.__ROBTLogger.GetTokenStatusForFile(__ctx1__.__LifeToken4Files, __ctx1__.__tmp_str1) != "Failure";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 208 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 208;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 196 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 196;
            case 196:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "ASAM file status is not failure " + __ctx1__.__tmp_str1 + __ctx1__.__LifeToken4Files, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 197 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 197;
            case 197:
                if ( !PreProgressInc( __seg__, __ctx__, 198 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 198;
            case 198:
                __condition__ = System.Text.RegularExpressions.Regex.IsMatch(__ctx1__.__tmp_str2, ".*failure:.*");
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 204 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 204;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 199 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 199;
            case 199:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "ASAM file attachment status is failure " + __ctx1__.__tmp_str2, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 200 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 200;
            case 200:
                __ctx1__.__tmp_str3 = System.Text.RegularExpressions.Regex.Replace(__ctx1__.__tmp_str2, ".*failure:([^·]+).*", "$1");
                if ( !PostProgressInc( __seg__, __ctx__, 201 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 201;
            case 201:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "ASAM file attachment status is failure " + __ctx1__.__tmp_str3, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 202 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 202;
            case 202:
                __ctx1__.__LifeToken4Files = __ctx1__.__ROBTLogger.SetTokenStatus(__ctx1__.__LifeToken4Files, __ctx1__.__tmp_str1, "Failure", __ctx1__.__tmp_str3);
                if ( !PostProgressInc( __seg__, __ctx__, 203 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 203;
            case 203:
                if ( !PostProgressInc( __seg__, __ctx__, 206 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 206;
            case 204:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "set status to Inprogress", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 205 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 205;
            case 205:
                __ctx1__.__LifeToken4Files = __ctx1__.__ROBTLogger.SetTokenStatus(__ctx1__.__LifeToken4Files, __ctx1__.__tmp_str1, "In Progress", "");
                if ( !PostProgressInc( __seg__, __ctx__, 206 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 206;
            case 206:
                if ( !PreProgressInc( __seg__, __ctx__, 207 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 207;
            case 207:
                if ( !PostProgressInc( __seg__, __ctx__, 209 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 209;
            case 208:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "ASAM file status is failure " + __ctx1__.__tmp_str1, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 209 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 209;
            case 209:
                if ( !PreProgressInc( __seg__, __ctx__, 210 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 210;
            case 210:
                if ( !PostProgressInc( __seg__, __ctx__, 213 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 213;
            case 211:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "CheckCommercialFiles -> inside failure case", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 212 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 212;
            case 212:
                __ctx1__.__LifeToken4Files = __ctx1__.__ROBTLogger.SetTokenStatus(__ctx1__.__LifeToken4Files, __ctx1__.__tmp_str1, "Failure", System.Convert.ToString(__ctx1__.__retVar1.rMessage));
                if ( !PostProgressInc( __seg__, __ctx__, 213 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 213;
            case 213:
                if ( !PreProgressInc( __seg__, __ctx__, 214 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 214;
            case 214:
                if ( !PostProgressInc( __seg__, __ctx__, 217 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 217;
            case 215:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "CheckIfStatusTagExists ->" + System.Convert.ToString(__ctx1__.__retVar1.rSuccess), __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 216 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 216;
            case 216:
                __ctx1__.__LifeToken4Files = __ctx1__.__ROBTLogger.SetTokenStatus(__ctx1__.__LifeToken4Files, __ctx1__.__tmp_str1, "In Progress", "");
                if ( !PostProgressInc( __seg__, __ctx__, 217 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 217;
            case 217:
                if ( !PreProgressInc( __seg__, __ctx__, 218 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 218;
            case 218:
                if ( !PreProgressInc( __seg__, __ctx__, 219 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 219;
            case 219:
                __ctx1__.__LoopCounter = __ctx1__.__LoopCounter + 1;
                if ( !PostProgressInc( __seg__, __ctx__, 220 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 220;
            case 220:
                if ( !PreProgressInc( __seg__, __ctx__, 221 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[23],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 221;
            case 221:
                if ( !PostProgressInc( __seg__, __ctx__, 161 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 161;
            case 222:
                if ( !PreProgressInc( __seg__, __ctx__, 223 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__retVar2 = null;
                if (__ctx1__ != null)
                    __ctx1__.__retVar1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__FTPHandler1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__FileNames = null;
                Tracker.FireEvent(__eventLocations[23],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 223;
            case 223:
                if ( !PreProgressInc( __seg__, __ctx__, 224 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 224;
            case 224:
                __ctx1__.__LifeToken4XProt = __ctx1__.__ROBTLogger.GetOverallTokenStatus(__ctx1__.__LifeToken4Files);
                if ( !PostProgressInc( __seg__, __ctx__, 225 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 225;
            case 225:
                if ( !PreProgressInc( __seg__, __ctx__, 226 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[25],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 226;
            case 226:
                __ctx1__.__tmp_str1 = System.Convert.ToString((System.String)__ctx1__.__Message_2.part.GetDistinguishedField("RQ1System"));
                if ( !PostProgressInc( __seg__, __ctx__, 227 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 227;
            case 227:
                __ctx1__.__tmp_str2 = (System.String)__ctx1__.__Message_2.part.GetDistinguishedField("XProtID");
                if ( !PostProgressInc( __seg__, __ctx__, 228 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 228;
            case 228:
                __ctx1__.__tmp_str3 = __ctx1__.__ROUpdater1.Attach2XProt(__ctx1__.__tmp_str1, __ctx1__.__tmp_str2, "ExchangedFiles", __ctx1__.__DLDirName, __ctx1__.__FileNamesCom, __ctx1__.__ROLogger, __ctx1__.__LifeToken4Files);
                if (__ctx1__ != null)
                    __ctx1__.__ROUpdater1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__FileNamesCom = null;
                if (__ctx1__ != null)
                    __ctx1__.__DLDirName = null;
                if ( !PostProgressInc( __seg__, __ctx__, 229 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 229;
            case 229:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + __ctx1__.__tmp_str3, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 230 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 230;
            case 230:
                if ( !PreProgressInc( __seg__, __ctx__, 231 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 231;
            case 231:
                __condition__ = System.Text.RegularExpressions.Regex.IsMatch(__ctx1__.__tmp_str3, ".*failure:.*");
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 233 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 233;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 232 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 232;
            case 232:
                __ctx1__.__LifeToken4Files = __ctx1__.__ROBTLogger.SetAllTokenStatus(__ctx1__.__LifeToken4Files, "Failure", "FTPIssueTransfer: " + __ctx1__.__tmp_str3);
                if ( !PostProgressInc( __seg__, __ctx__, 233 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 233;
            case 233:
                if ( !PreProgressInc( __seg__, __ctx__, 234 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__tmp_str3 = null;
                Tracker.FireEvent(__eventLocations[3],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 234;
            case 234:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "Final Log update ->" + __ctx1__.__tmp_str1 + "," + __ctx1__.__tmp_str2, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 235 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 235;
            case 235:
                if ( !PreProgressInc( __seg__, __ctx__, 236 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[26],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 236;
            case 236:
                {
                    __messagetype_FTPIssueTransfer_TransferResultInformation __Message_3 = new __messagetype_FTPIssueTransfer_TransferResultInformation("Message_3", __ctx1__);

                    ApplyTransform(typeof(FTPIssueTransfer.Map2TransferResult), new object[] {__Message_3.part}, new object[] {__ctx1__.__Message_2.part});
                    __Message_3.part.SetDistinguishedField("DownloadTargetPath", RB.FTPLibrary.GlobalConstants.FTP_LOCAL_BASE_DIR + __ctx1__.__DLDirOut + "\\");
                    if (__ctx1__ != null)
                        __ctx1__.__DLDirOut = null;
                    __Message_3.part.SetDistinguishedField("LifeToken4XProt", __ctx1__.__LifeToken4XProt);
                    if (__ctx1__ != null)
                        __ctx1__.__LifeToken4XProt = null;
                    __Message_3.part.SetDistinguishedField("LifeToken4Files", __ctx1__.__LifeToken4Files);
                    if (__ctx1__ != null)
                        __ctx1__.__LifeToken4Files = null;
                    __Message_3.part.SetDistinguishedField("Mode", __ctx1__.__TransferMode);
                    if (__ctx1__ != null)
                        __ctx1__.__TransferMode = null;
                    __ctx1__.__tmp_str1 = (System.String)__Message_3.part.GetDistinguishedField("RQ1System");
                    __ctx1__.__tmp_str2 = __ctx1__.__tmp_str1.Substring(__ctx1__.__tmp_str1.LastIndexOf("@") + 1);
                    if (__ctx1__ != null)
                        __ctx1__.__tmp_str1 = null;
                    __Message_3.SetPropertyValue(typeof(FILE.ReceivedFileName), __ctx1__.__tmp_str2 + "_" + (System.String)__Message_3.part.GetDistinguishedField("XProtID") + "_005_FTPTransferResult_");
                    if (__ctx1__ != null)
                        __ctx1__.__tmp_str2 = null;

                    if (__ctx1__.__Message_3 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Message_3);
                    __ctx1__.__Message_3 = __Message_3;
                    __ctx1__.RefMessage(__ctx1__.__Message_3);
                }
                __ctx1__.__Message_3.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 237 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 237;
            case 237:
                if ( !PreProgressInc( __seg__, __ctx__, 238 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Message_3);
                    __edata.Messages.Add(__ctx1__.__Message_2);
                    Tracker.FireEvent(__eventLocations[27],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Message_2 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Message_2);
                    __ctx1__.__Message_2 = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 238;
            case 238:
                if ( !PreProgressInc( __seg__, __ctx__, 239 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[28],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 239;
            case 239:
                __ctx1__.__ROBTLogger.CloseLogger(__ctx1__.__ROLogger);
                if (__ctx1__ != null)
                    __ctx1__.__ROBTLogger = null;
                if (__ctx1__ != null)
                    __ctx1__.__ROLogger = null;
                if ( !PostProgressInc( __seg__, __ctx__, 240 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 240;
            case 240:
                if ( !PreProgressInc( __seg__, __ctx__, 241 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[29],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 241;
            case 241:
                if ( !PreProgressInc( __seg__, __ctx__, 242 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[30],__eventData[11],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 242;
            case 242:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 243 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 243;
            case 243:
                if ( !PreProgressInc( __seg__, __ctx__, 244 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                TR_P.SendMessage(0, __ctx1__.__Message_3, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (TR_P != null)
                {
                    TR_P.Close(__ctx1__, __seg__);
                    TR_P = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 244;
            case 244:
                if ( !PreProgressInc( __seg__, __ctx__, 245 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Message_3);
                    __edata.PortName = @"TR_P";
                    Tracker.FireEvent(__eventLocations[31],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 245;
            case 245:
                if ( !PreProgressInc( __seg__, __ctx__, 246 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[32],__eventData[11],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 246;
            case 246:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 247 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 247;
            case 247:
                if ( !PreProgressInc( __seg__, __ctx__, 248 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                TR_CPY.SendMessage(0, __ctx1__.__Message_3, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (TR_CPY != null)
                {
                    TR_CPY.Close(__ctx1__, __seg__);
                    TR_CPY = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 248;
            case 248:
                if ( !PreProgressInc( __seg__, __ctx__, 249 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Message_3);
                    __edata.PortName = @"TR_CPY";
                    Tracker.FireEvent(__eventLocations[33],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Message_3 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Message_3);
                    __ctx1__.__Message_3 = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 249;
            case 249:
                if ( !PreProgressInc( __seg__, __ctx__, 250 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[12],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 250;
            case 250:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 251 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 251;
            case 251:
                if ( !PreProgressInc( __seg__, __ctx__, 252 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 252;
            case 252:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }
    //#line 584 "D:\ASAM-IF-IMPORT\Import\960 - Sources\PTI8KOR\BTImportSoftware\FTPIssueTransfer\FTPIssueTransfer\SendMessageAcknowledgement.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "TransmitterRequestRecievePort", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(FTPIssueTransfer.PortType_7),
            typeof(FTPIssueTransfer.TransmitterRef.TransmitterService_.TransmitterService),
            typeof(FTPIssueTransfer.PortType_4),
            typeof(FTPIssueTransfer.TransmitterRef.TransmitterService_.TransmitterService),
            typeof(FTPIssueTransfer.TransmitterRef.TransmitterService_.TransmitterService)
        },
        new System.String[] {
            "TransmitterRequestRecievePort",
            "Port_DAIMLER_TRANSRECEIVE",
            "Port_WSOUT",
            "Port_BMW_TRANSRECEIVE",
            "Port_BMW_CC_TRANSRECIEVE"
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
    sealed internal class SendMessageAcknowledgement : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(SendMessageAcknowledgement));
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

        static SendMessageAcknowledgement()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 2, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 2, 3),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment4), 1, 2, 4),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment5), 1, 2, 5)
            };

            _Locks = 0;
            _rootContext = new __SendMessageAcknowledgement_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public SendMessageAcknowledgement(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "SendMessageAcknowledgement", tracker)
        {
            ConstructorHelper();
        }

        public SendMessageAcknowledgement(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "SendMessageAcknowledgement")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>51588f47-24d7-436d-b078-cf3835cc86c2</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>562759cd-ebf4-487d-b806-a16845e5ddd0</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>1614766b-da8e-45ed-bdc6-6919ae21f2b0</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>SetVariables</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>c2a767a2-13e8-4035-948d-32c4a9dc90c0</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>e460493d-31f9-4299-b74c-fced14113aee</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructTransmitterMessage</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>5ed3f3f7-c168-4401-85a2-62c9fdd500ed</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>7f90adb6-f3e3-4cf8-81f5-6bfeea9d556a</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>fe1f6845-d272-4cb6-ac3f-be2d3ff12a27</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>50c75634-0fa4-418c-a283-93f697b117a5</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>9f15cbd4-7a44-47a5-b615-53b84f29de95</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Check Interface Name</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>d917d6f0-6cd6-4f89-9dbf-748017c9f9f1</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>IsDaimlerInterface</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>80bdb8d1-462a-4705-967d-c7a7a99bac9c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>SendDaimlerPort</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>04870a02-1bf5-4498-bbb4-c46bfa5a1754</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ReceiveDaimlerPort</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>c3e2ecba-e2c9-400e-b2cf-3686eb7594b2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>SetDaimlerResponseInfo</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>69596319-9315-4c3d-ba20-ee93edf9ad3d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>a9a02a7d-b38c-4fbe-bb7f-9b45097a9117</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ReadResponseAndSendMails</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>57c729b8-e7cf-4a4f-a224-de138e95e0ce</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>ae75022a-f41d-4437-976f-dc5fedf24fa8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>SendBMWPort</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>51212de7-dc6d-4776-b7bf-9a25bbbab0e1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ReceiveBMWPort</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>c62f7e6a-af35-492b-ad9c-ac5dc871ffa6</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>SetBMWResponseInfo</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>0a701e99-f5bf-40cb-b7a2-4d8925794c73</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>e2427e37-d7ef-4b02-a3dd-6b5fb605eaea</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ReadResponseAndSendMails</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>87627154-887b-4181-9f0a-d3e6520a00ab</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>c3b88a7a-aafb-49a0-b358-219881faaa30</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>SendBMWCCPort</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>541be316-1a36-478b-b45a-04496556d244</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ReceiveBMWCCPort</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>0410dae9-8f4e-42a1-99d9-22532d9ff029</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>SetBMWCCResponseInfo</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>9943c390-056e-4ada-a0a8-d6c54822f80d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>41e4ca8e-f986-4396-8abf-c31524733096</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ReadResponseAndSendMails</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>b365f816-0fab-46c1-abb0-fea89705625b</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>85592bda-5aed-456c-9f54-d133b9467a01</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Log</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>407888b7-2ef2-4a1b-a689-3bff592da8f4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>SuccessLog</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>55a8f2c0-2ec8-4751-ae3f-847b581570e6</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchSystemException</shapeText>                      <ExceptionType>System.SystemException</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>3c8f9f30-f00b-4ff2-b1d7-da7aa132ec20</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>8f2080d2-4072-4043-8ecc-0d4a0d123203</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchSoapException</shapeText>                      <ExceptionType>System.Web.Services.Protocols.SoapException</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>d314e148-f3b9-4a0c-8489-d38dc543da44</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Expression_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>7e94074a-937a-4a4d-ae84-f37dd4873794</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchGeneralException</shapeText>                      <ExceptionType>General Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>d3588c06-50a1-41fa-a32a-5dc3011fcca9</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Expression_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'SendMessageAcknowledgement'</ActionName><IsAtomic>0</IsAtomic><Line>584</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>614</Line><Position>22</Position><ShapeID>'562759cd-ebf4-487d-b806-a16845e5ddd0'</ShapeID>
<Messages>
	<MsgInfo><name>receivedMsg</name><part>part</part><schema>FTPIssueTransfer.InitialTransmitterRequestSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>626</Line><Position>51</Position><ShapeID>'1614766b-da8e-45ed-bdc6-6919ae21f2b0'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope33'</ActionName><IsAtomic>0</IsAtomic><Line>642</Line><Position>13</Position><ShapeID>'c2a767a2-13e8-4035-948d-32c4a9dc90c0'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>647</Line><Position>21</Position><ShapeID>'e460493d-31f9-4299-b74c-fced14113aee'</ShapeID>
<Messages>
	<MsgInfo><name>msgREQ</name><part>transmitterRequest</part><schema>FTPIssueTransfer.TransmitterRef.Reference+transmitterRequest</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>receivedMsg</name><part>part</part><schema>FTPIssueTransfer.InitialTransmitterRequestSchema</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>653</Line><Position>21</Position><ShapeID>'9f15cbd4-7a44-47a5-b615-53b84f29de95'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>656</Line><Position>25</Position><ShapeID>'80bdb8d1-462a-4705-967d-c7a7a99bac9c'</ShapeID>
<Messages>
	<MsgInfo><name>msgREQ</name><part>transmitterRequest</part><schema>FTPIssueTransfer.TransmitterRef.Reference+transmitterRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>658</Line><Position>25</Position><ShapeID>'04870a02-1bf5-4498-bbb4-c46bfa5a1754'</ShapeID>
<Messages>
	<MsgInfo><name>msgRES</name><part>startTransmitResult</part><schema>FTPIssueTransfer.TransmitterRef.Reference+transmitterResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>660</Line><Position>34</Position><ShapeID>'c3e2ecba-e2c9-400e-b2cf-3686eb7594b2'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>668</Line><Position>25</Position><ShapeID>'69596319-9315-4c3d-ba20-ee93edf9ad3d'</ShapeID>
<Messages>
	<MsgInfo><name>msgRES</name><part>startTransmitResult</part><schema>FTPIssueTransfer.TransmitterRef.Reference+transmitterResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>670</Line><Position>25</Position><ShapeID>'a9a02a7d-b38c-4fbe-bb7f-9b45097a9117'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>694</Line><Position>25</Position><ShapeID>'ae75022a-f41d-4437-976f-dc5fedf24fa8'</ShapeID>
<Messages>
	<MsgInfo><name>msgREQ</name><part>transmitterRequest</part><schema>FTPIssueTransfer.TransmitterRef.Reference+transmitterRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>696</Line><Position>25</Position><ShapeID>'51212de7-dc6d-4776-b7bf-9a25bbbab0e1'</ShapeID>
<Messages>
	<MsgInfo><name>msgRES</name><part>startTransmitResult</part><schema>FTPIssueTransfer.TransmitterRef.Reference+transmitterResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>698</Line><Position>34</Position><ShapeID>'c62f7e6a-af35-492b-ad9c-ac5dc871ffa6'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>706</Line><Position>25</Position><ShapeID>'0a701e99-f5bf-40cb-b7a2-4d8925794c73'</ShapeID>
<Messages>
	<MsgInfo><name>msgRES</name><part>startTransmitResult</part><schema>FTPIssueTransfer.TransmitterRef.Reference+transmitterResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>708</Line><Position>25</Position><ShapeID>'e2427e37-d7ef-4b02-a3dd-6b5fb605eaea'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>732</Line><Position>25</Position><ShapeID>'c3b88a7a-aafb-49a0-b358-219881faaa30'</ShapeID>
<Messages>
	<MsgInfo><name>msgREQ</name><part>transmitterRequest</part><schema>FTPIssueTransfer.TransmitterRef.Reference+transmitterRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>734</Line><Position>25</Position><ShapeID>'541be316-1a36-478b-b45a-04496556d244'</ShapeID>
<Messages>
	<MsgInfo><name>msgRES</name><part>startTransmitResult</part><schema>FTPIssueTransfer.TransmitterRef.Reference+transmitterResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>736</Line><Position>34</Position><ShapeID>'0410dae9-8f4e-42a1-99d9-22532d9ff029'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>744</Line><Position>25</Position><ShapeID>'9943c390-056e-4ada-a0a8-d6c54822f80d'</ShapeID>
<Messages>
	<MsgInfo><name>msgRES</name><part>startTransmitResult</part><schema>FTPIssueTransfer.TransmitterRef.Reference+transmitterResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>746</Line><Position>25</Position><ShapeID>'41e4ca8e-f986-4396-8abf-c31524733096'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>770</Line><Position>63</Position><ShapeID>'85592bda-5aed-456c-9f54-d133b9467a01'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>773</Line><Position>59</Position><ShapeID>'407888b7-2ef2-4a1b-a689-3bff592da8f4'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>796</Line><Position>21</Position><ShapeID>'8f2080d2-4072-4043-8ecc-0d4a0d123203'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>799</Line><Position>63</Position><ShapeID>'d314e148-f3b9-4a0c-8489-d38dc543da44'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>816</Line><Position>21</Position><ShapeID>'7e94074a-937a-4a4d-ae84-f37dd4873794'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>819</Line><Position>67</Position><ShapeID>'d3588c06-50a1-41fa-a32a-5dc3011fcca9'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>778</Line><Position>21</Position><ShapeID>'55a8f2c0-2ec8-4751-ae3f-847b581570e6'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>781</Line><Position>63</Position><ShapeID>'3c8f9f30-f00b-4ff2-b1d7-da7aa132ec20'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='2e239c8e-eb80-4428-b30b-cbb7ce97abc0' LowerBound='1.1' HigherBound='285.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='FTPIssueTransfer' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='8aa0e76e-eeec-4341-8241-446a8f420ac4' ParentLink='Module_ServiceDeclaration' LowerBound='32.1' HigherBound='284.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SendMessageAcknowledgement' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='3a92f8ed-4f9a-4714-8810-9eefdd0bf6ab' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='49.1' HigherBound='50.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='responseStatus' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='5c7ca20d-bb26-49ea-803b-f546c5d7d310' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='50.1' HigherBound='51.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='responseMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='72110cc1-9b78-439d-9e02-d31a3f6a6b9f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='51.1' HigherBound='52.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgACKFileName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='1f6ca8f4-4a10-48e4-9157-a9d971278824' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='52.1' HigherBound='53.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RQ1System' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='b8ae16d7-3479-4ac7-8d2e-6372be443745' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='53.1' HigherBound='54.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='interfaceName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ff8dbaf4-fd1b-4d69-8088-67eb9ff98d40' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='54.1' HigherBound='55.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='mailStatus' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='90e2f889-ba60-4153-984b-38b8e00cbd16' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='55.1' HigherBound='56.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='xprotID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='0cb3cf85-f270-4b78-bc52-724b5e3aa739' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='56.1' HigherBound='57.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='RB.BTLoggerLibrary.Logger' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ROLogger' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='5a6c48cc-2754-4b8a-8315-5b55abb9871f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='57.1' HigherBound='58.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='RB.BTLoggerLibrary.BTLogger' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ROBTLogger' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8a7ec392-8304-437d-ab98-2b0d9d5afea5' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='58.1' HigherBound='59.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='RB.FTPLibrary.FTPHandler' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FTPHandler1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8ede69df-596a-4ed7-9e70-08bfcff898b4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='59.1' HigherBound='60.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='category' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='4ee86955-e13b-40e7-bbf8-5f2b7701ff5e' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='46.1' HigherBound='47.1'>
                <om:Property Name='Type' Value='FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_request' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgREQ' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='37a8f703-6658-47d3-89e1-88535331bc3b' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='47.1' HigherBound='48.1'>
                <om:Property Name='Type' Value='FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_response' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgRES' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='93cfa114-273a-41a0-aa6f-f81aba6ee0cf' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='48.1' HigherBound='49.1'>
                <om:Property Name='Type' Value='FTPIssueTransfer.InitialTransmitterRequestSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='receivedMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='51588f47-24d7-436d-b078-cf3835cc86c2' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='562759cd-ebf4-487d-b806-a16845e5ddd0' ParentLink='ServiceBody_Statement' LowerBound='62.1' HigherBound='74.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='TransmitterRequestRecievePort' />
                    <om:Property Name='MessageName' Value='receivedMsg' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='1614766b-da8e-45ed-bdc6-6919ae21f2b0' ParentLink='ServiceBody_Statement' LowerBound='74.1' HigherBound='90.1'>
                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Transmitter Request received at &quot;+System.String.Format(&quot;{0:yyyyMMdd-HHmmssffffff - }&quot;, System.DateTime.Now));&#xD;&#xA;msgACKFileName = System.Convert.ToString(xpath(receivedMsg,&quot;string(/*[local-name()=&apos;transmitterRequest&apos; and namespace-uri()=&apos;http://FTPIssueTransfer.InitialTransmitterRequestSchema&apos;]/*[local-name()=&apos;transferFile&apos; and namespace-uri()=&apos;&apos;])&quot;));&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Transmitter Request msg ACK FileName: &quot;+ msgACKFileName);&#xD;&#xA;interfaceName = System.Convert.ToString(xpath(receivedMsg,&quot;string(/*[local-name()=&apos;transmitterRequest&apos; and namespace-uri()=&apos;http://FTPIssueTransfer.InitialTransmitterRequestSchema&apos;]/*[local-name()=&apos;InterfaceName&apos; and namespace-uri()=&apos;&apos;])&quot;));&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Transmitter Request Interface Name: &quot;+ interfaceName);&#xD;&#xA;RQ1System = System.Convert.ToString(xpath(receivedMsg,&quot;string(/*[local-name()=&apos;transmitterRequest&apos; and namespace-uri()=&apos;http://FTPIssueTransfer.InitialTransmitterRequestSchema&apos;]/*[local-name()=&apos;RQ1System&apos; and namespace-uri()=&apos;&apos;])&quot;));&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Transmitter Request RQ1System: &quot;+ RQ1System);&#xD;&#xA;FTPHandler1 = new RB.FTPLibrary.FTPHandler();&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Successfully initiated FTPHandler&quot;);&#xD;&#xA;xprotID = System.Convert.ToString(xpath(receivedMsg,&quot;string(/*[local-name()=&apos;transmitterRequest&apos; and namespace-uri()=&apos;http://FTPIssueTransfer.InitialTransmitterRequestSchema&apos;]/*[local-name()=&apos;XProtID&apos; and namespace-uri()=&apos;&apos;])&quo"+
@"t;));&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Transmitter Request XProtID: &quot;+ xprotID);&#xD;&#xA;ROLogger = ROBTLogger.GetLogger(interfaceName,xprotID,&quot;Import&quot;);&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;Setting log for msg acknowledgement&quot;,ROLogger);&#xD;&#xA;category = System.Convert.ToString(xpath(receivedMsg,&quot;string(/*[local-name()=&apos;transmitterRequest&apos; and namespace-uri()=&apos;http://FTPIssueTransfer.InitialTransmitterRequestSchema&apos;]/*[local-name()=&apos;Category&apos; and namespace-uri()=&apos;&apos;])&quot;));&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Transmitter Request Category: &quot;+ category);' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SetVariables' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='c2a767a2-13e8-4035-948d-32c4a9dc90c0' ParentLink='ServiceBody_Statement' LowerBound='90.1' HigherBound='282.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Construct' OID='e460493d-31f9-4299-b74c-fced14113aee' ParentLink='ComplexStatement_Statement' LowerBound='95.1' HigherBound='101.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructTransmitterMessage' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Transform' OID='5ed3f3f7-c168-4401-85a2-62c9fdd500ed' ParentLink='ComplexStatement_Statement' LowerBound='98.1' HigherBound='100.1'>
                            <om:Property Name='ClassName' Value='FTPIssueTransfer.TransformTransmitterRequestMessage' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Transform_2' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='MessagePartRef' OID='7f90adb6-f3e3-4cf8-81f5-6bfeea9d556a' ParentLink='Transform_InputMessagePartRef' LowerBound='99.118' HigherBound='99.129'>
                                <om:Property Name='MessageRef' Value='receivedMsg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_1' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='fe1f6845-d272-4cb6-ac3f-be2d3ff12a27' ParentLink='Transform_OutputMessagePartRef' LowerBound='99.36' HigherBound='99.61'>
                                <om:Property Name='MessageRef' Value='msgREQ' />
                                <om:Property Name='PartRef' Value='transmitterRequest' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_2' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='MessageRef' OID='50c75634-0fa4-418c-a283-93f697b117a5' ParentLink='Construct_MessageRef' LowerBound='96.31' HigherBound='96.37'>
                            <om:Property Name='Ref' Value='msgREQ' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Decision' OID='9f15cbd4-7a44-47a5-b615-53b84f29de95' ParentLink='ComplexStatement_Statement' LowerBound='101.1' HigherBound='221.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Check Interface Name' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='DecisionBranch' OID='d917d6f0-6cd6-4f89-9dbf-748017c9f9f1' ParentLink='ReallyComplexStatement_Branch' LowerBound='102.21' HigherBound='140.1'>
                            <om:Property Name='Expression' Value='System.String.Equals(interfaceName,&quot;RO-ASAM-DAIMLER&quot;)' />
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='IsDaimlerInterface' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Send' OID='80bdb8d1-462a-4705-967d-c7a7a99bac9c' ParentLink='ComplexStatement_Statement' LowerBound='104.1' HigherBound='106.1'>
                                <om:Property Name='PortName' Value='Port_DAIMLER_TRANSRECEIVE' />
                                <om:Property Name='MessageName' Value='msgREQ' />
                                <om:Property Name='OperationName' Value='startTransmit' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='SendDaimlerPort' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='Receive' OID='04870a02-1bf5-4498-bbb4-c46bfa5a1754' ParentLink='ComplexStatement_Statement' LowerBound='106.1' HigherBound='108.1'>
                                <om:Property Name='Activate' Value='False' />
                                <om:Property Name='PortName' Value='Port_DAIMLER_TRANSRECEIVE' />
                                <om:Property Name='MessageName' Value='msgRES' />
                                <om:Property Name='OperationName' Value='startTransmit' />
                                <om:Property Name='OperationMessageName' Value='Response' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ReceiveDaimlerPort' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='c3e2ecba-e2c9-400e-b2cf-3686eb7594b2' ParentLink='ComplexStatement_Statement' LowerBound='108.1' HigherBound='116.1'>
                                <om:Property Name='Expression' Value='ROLogger = ROBTLogger.GetLogger(interfaceName,xprotID,&quot;Import&quot;);&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Daimler Transmitter Response received at &quot;+System.String.Format(&quot;{0:yyyyMMdd-HHmmssffffff - }&quot;, System.DateTime.Now));&#xD;&#xA;ROBTLogger.WriteLog(&quot;Daimler Transmitter Response received at &quot;+System.String.Format(&quot;{0:yyyyMMdd-HHmmssffffff - }&quot;, System.DateTime.Now),ROLogger);&#xD;&#xA;responseStatus = System.Convert.ToString(xpath(msgRES.startTransmitResult,&quot;string(/*[local-name()=&apos;transmitterResponse&apos; and namespace-uri()=&apos;http://www.bosch.com/edexas/asam/transmitter/services&apos;]/*[local-name()=&apos;failure&apos; and namespace-uri()=&apos;&apos;])&quot;));&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Daimler Transmitter Received Response Status - &quot; + responseStatus);&#xD;&#xA;responseMessage = System.Convert.ToString(xpath(msgRES.startTransmitResult,&quot;string(/*[local-name()=&apos;transmitterResponse&apos; and namespace-uri()=&apos;http://www.bosch.com/edexas/asam/transmitter/services&apos;]/*[local-name()=&apos;result&apos; and namespace-uri()=&apos;&apos;])&quot;));&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Daimler Transmitter Received Response Message - &quot; + responseMessage);' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='SetDaimlerResponseInfo' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='Send' OID='69596319-9315-4c3d-ba20-ee93edf9ad3d' ParentLink='ComplexStatement_Statement' LowerBound='116.1' HigherBound='118.1'>
                                <om:Property Name='PortName' Value='Port_WSOUT' />
                                <om:Property Name='MessageName' Value='msgRES' />
                                <om:Property Name='OperationName' Value='Operation_1' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='a9a02a7d-b38c-4fbe-bb7f-9b45097a9117' ParentLink='ComplexStatement_Statement' LowerBound='118.1' HigherBound='139.1'>
                                <om:Property Name='Expression' Value='if(responseStatus == &quot;true&quot;)&#xD;&#xA;{&#xD;&#xA;    &#xD;&#xA;    if(!System.String.IsNullOrEmpty(responseMessage))&#xD;&#xA;    {&#xD;&#xA;        if(responseMessage.Contains(&quot;HTTP/1.1 500&quot;))&#xD;&#xA;        {&#xD;&#xA;            ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;Daimler Transmitter Response has error,sending mail&quot;,&#xD;&#xA;            ROLogger);&#xD;&#xA;            System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Daimler Transmitter Response has error,sending mail&quot;);           &#xD;&#xA;            mailStatus = FTPHandler1.SendMailToAdmins(interfaceName,RQ1System,msgACKFileName,xprotID,ROLogger);&#xD;&#xA;            if(mailStatus)&#xD;&#xA;            {&#xD;&#xA;                System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Mail sent successfully&quot;);           &#xD;&#xA;                ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;Mail sent successfully&quot;,&#xD;&#xA;                ROLogger);&#xD;&#xA;            }&#xD;&#xA;        }&#xD;&#xA;    }&#xD;&#xA;}' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ReadResponseAndSendMails' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='DecisionBranch' OID='57c729b8-e7cf-4a4f-a224-de138e95e0ce' ParentLink='ReallyComplexStatement_Branch' LowerBound='140.26' HigherBound='178.1'>
                            <om:Property Name='Expression' Value='System.String.Equals(interfaceName,&quot;RO-ASAM-BMW&quot;) &amp;&amp;  System.String.Equals(category,&quot;BMW-PROSPR&quot;)' />
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Rule_1' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Send' OID='ae75022a-f41d-4437-976f-dc5fedf24fa8' ParentLink='ComplexStatement_Statement' LowerBound='142.1' HigherBound='144.1'>
                                <om:Property Name='PortName' Value='Port_BMW_TRANSRECEIVE' />
                                <om:Property Name='MessageName' Value='msgREQ' />
                                <om:Property Name='OperationName' Value='startTransmit' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='SendBMWPort' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='Receive' OID='51212de7-dc6d-4776-b7bf-9a25bbbab0e1' ParentLink='ComplexStatement_Statement' LowerBound='144.1' HigherBound='146.1'>
                                <om:Property Name='Activate' Value='False' />
                                <om:Property Name='PortName' Value='Port_BMW_TRANSRECEIVE' />
                                <om:Property Name='MessageName' Value='msgRES' />
                                <om:Property Name='OperationName' Value='startTransmit' />
                                <om:Property Name='OperationMessageName' Value='Response' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ReceiveBMWPort' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='c62f7e6a-af35-492b-ad9c-ac5dc871ffa6' ParentLink='ComplexStatement_Statement' LowerBound='146.1' HigherBound='154.1'>
                                <om:Property Name='Expression' Value='ROLogger = ROBTLogger.GetLogger(interfaceName,xprotID,&quot;Import&quot;);&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;BMW Transmitter Response received at &quot;+System.String.Format(&quot;{0:yyyyMMdd-HHmmssffffff - }&quot;, System.DateTime.Now));&#xD;&#xA;ROBTLogger.WriteLog(&quot;BMW Transmitter Response received at &quot;+System.String.Format(&quot;{0:yyyyMMdd-HHmmssffffff - }&quot;, System.DateTime.Now),ROLogger);&#xD;&#xA;responseStatus = System.Convert.ToString(xpath(msgRES.startTransmitResult,&quot;string(/*[local-name()=&apos;transmitterResponse&apos; and namespace-uri()=&apos;http://www.bosch.com/edexas/asam/transmitter/services&apos;]/*[local-name()=&apos;failure&apos; and namespace-uri()=&apos;&apos;])&quot;));&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;BMW Transmitter Received Response Status - &quot; + responseStatus);&#xD;&#xA;responseMessage = System.Convert.ToString(xpath(msgRES.startTransmitResult,&quot;string(/*[local-name()=&apos;transmitterResponse&apos; and namespace-uri()=&apos;http://www.bosch.com/edexas/asam/transmitter/services&apos;]/*[local-name()=&apos;result&apos; and namespace-uri()=&apos;&apos;])&quot;));&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;BMW Transmitter Received Response Message - &quot; + responseMessage);' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='SetBMWResponseInfo' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='Send' OID='0a701e99-f5bf-40cb-b7a2-4d8925794c73' ParentLink='ComplexStatement_Statement' LowerBound='154.1' HigherBound='156.1'>
                                <om:Property Name='PortName' Value='Port_WSOUT' />
                                <om:Property Name='MessageName' Value='msgRES' />
                                <om:Property Name='OperationName' Value='Operation_1' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send_4' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='e2427e37-d7ef-4b02-a3dd-6b5fb605eaea' ParentLink='ComplexStatement_Statement' LowerBound='156.1' HigherBound='177.1'>
                                <om:Property Name='Expression' Value='if(responseStatus == &quot;true&quot;)&#xD;&#xA;{&#xD;&#xA;    //ROLogger = ROBTLogger.GetLogger(interfaceName,xprotID);&#xD;&#xA;    if(!System.String.IsNullOrEmpty(responseMessage))&#xD;&#xA;    {&#xD;&#xA;        if(responseMessage.Contains(&quot;HTTP/1.1 500&quot;))&#xD;&#xA;        {&#xD;&#xA;            System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;BMW Transmitter Response has error,sending mail&quot;);           &#xD;&#xA;            ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;BMW Transmitter Response has error,sending mail&quot;,&#xD;&#xA;            ROLogger);&#xD;&#xA;            mailStatus = FTPHandler1.SendMailToAdmins(interfaceName,RQ1System,msgACKFileName,xprotID,ROLogger);&#xD;&#xA;            if(mailStatus)&#xD;&#xA;            {&#xD;&#xA;                System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Mail sent successfully&quot;);   &#xD;&#xA;                ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;Mail sent successfully&quot;,&#xD;&#xA;                ROLogger);        &#xD;&#xA;            }&#xD;&#xA;        }&#xD;&#xA;    }&#xD;&#xA;}' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ReadResponseAndSendMails' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='DecisionBranch' OID='87627154-887b-4181-9f0a-d3e6520a00ab' ParentLink='ReallyComplexStatement_Branch' LowerBound='178.26' HigherBound='216.1'>
                            <om:Property Name='Expression' Value='System.String.Equals(interfaceName,&quot;RO-ASAM-BMW&quot;) &amp;&amp;  System.String.Equals(category,&quot;BMW-CC-PROSPR&quot;)' />
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Rule_2' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Send' OID='c3b88a7a-aafb-49a0-b358-219881faaa30' ParentLink='ComplexStatement_Statement' LowerBound='180.1' HigherBound='182.1'>
                                <om:Property Name='PortName' Value='Port_BMW_CC_TRANSRECIEVE' />
                                <om:Property Name='MessageName' Value='msgREQ' />
                                <om:Property Name='OperationName' Value='startTransmit' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='SendBMWCCPort' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='Receive' OID='541be316-1a36-478b-b45a-04496556d244' ParentLink='ComplexStatement_Statement' LowerBound='182.1' HigherBound='184.1'>
                                <om:Property Name='Activate' Value='False' />
                                <om:Property Name='PortName' Value='Port_BMW_CC_TRANSRECIEVE' />
                                <om:Property Name='MessageName' Value='msgRES' />
                                <om:Property Name='OperationName' Value='startTransmit' />
                                <om:Property Name='OperationMessageName' Value='Response' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ReceiveBMWCCPort' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='0410dae9-8f4e-42a1-99d9-22532d9ff029' ParentLink='ComplexStatement_Statement' LowerBound='184.1' HigherBound='192.1'>
                                <om:Property Name='Expression' Value='ROLogger = ROBTLogger.GetLogger(interfaceName,xprotID,&quot;Import&quot;);&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;BMW Transmitter Response received at &quot;+System.String.Format(&quot;{0:yyyyMMdd-HHmmssffffff - }&quot;, System.DateTime.Now));&#xD;&#xA;ROBTLogger.WriteLog(&quot;BMW Transmitter Response received at &quot;+System.String.Format(&quot;{0:yyyyMMdd-HHmmssffffff - }&quot;, System.DateTime.Now),ROLogger);&#xD;&#xA;responseStatus = System.Convert.ToString(xpath(msgRES.startTransmitResult,&quot;string(/*[local-name()=&apos;transmitterResponse&apos; and namespace-uri()=&apos;http://www.bosch.com/edexas/asam/transmitter/services&apos;]/*[local-name()=&apos;failure&apos; and namespace-uri()=&apos;&apos;])&quot;));&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;BMW Transmitter Received Response Status - &quot; + responseStatus);&#xD;&#xA;responseMessage = System.Convert.ToString(xpath(msgRES.startTransmitResult,&quot;string(/*[local-name()=&apos;transmitterResponse&apos; and namespace-uri()=&apos;http://www.bosch.com/edexas/asam/transmitter/services&apos;]/*[local-name()=&apos;result&apos; and namespace-uri()=&apos;&apos;])&quot;));&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;BMW Transmitter Received Response Message - &quot; + responseMessage);' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='SetBMWCCResponseInfo' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Send' OID='9943c390-056e-4ada-a0a8-d6c54822f80d' ParentLink='ComplexStatement_Statement' LowerBound='192.1' HigherBound='194.1'>
                                <om:Property Name='PortName' Value='Port_WSOUT' />
                                <om:Property Name='MessageName' Value='msgRES' />
                                <om:Property Name='OperationName' Value='Operation_1' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send_4' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='41e4ca8e-f986-4396-8abf-c31524733096' ParentLink='ComplexStatement_Statement' LowerBound='194.1' HigherBound='215.1'>
                                <om:Property Name='Expression' Value='if(responseStatus == &quot;true&quot;)&#xD;&#xA;{&#xD;&#xA;    //ROLogger = ROBTLogger.GetLogger(interfaceName,xprotID);&#xD;&#xA;    if(!System.String.IsNullOrEmpty(responseMessage))&#xD;&#xA;    {&#xD;&#xA;        if(responseMessage.Contains(&quot;HTTP/1.1 500&quot;))&#xD;&#xA;        {&#xD;&#xA;            System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;BMW Transmitter Response has error,sending mail&quot;);           &#xD;&#xA;            ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;BMW Transmitter Response has error,sending mail&quot;,&#xD;&#xA;            ROLogger);&#xD;&#xA;            mailStatus = FTPHandler1.SendMailToAdmins(interfaceName,RQ1System,msgACKFileName,xprotID,ROLogger);&#xD;&#xA;            if(mailStatus)&#xD;&#xA;            {&#xD;&#xA;                System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Mail sent successfully&quot;);   &#xD;&#xA;                ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;Mail sent successfully&quot;,&#xD;&#xA;                ROLogger);        &#xD;&#xA;            }&#xD;&#xA;        }&#xD;&#xA;    }&#xD;&#xA;}' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ReadResponseAndSendMails' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='DecisionBranch' OID='b365f816-0fab-46c1-abb0-fea89705625b' ParentLink='ReallyComplexStatement_Branch'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Else' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='VariableAssignment' OID='85592bda-5aed-456c-9f54-d133b9467a01' ParentLink='ComplexStatement_Statement' LowerBound='218.1' HigherBound='220.1'>
                                <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;InterfaceName is not DAIMLER or BMW&quot;);           ' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Log' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='407888b7-2ef2-4a1b-a689-3bff592da8f4' ParentLink='ComplexStatement_Statement' LowerBound='221.1' HigherBound='223.1'>
                        <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Out of transmitter scope&quot;);&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='SuccessLog' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Catch' OID='55a8f2c0-2ec8-4751-ae3f-847b581570e6' ParentLink='Scope_Catch' LowerBound='226.1' HigherBound='244.1'>
                        <om:Property Name='ExceptionName' Value='systemException' />
                        <om:Property Name='ExceptionType' Value='System.SystemException' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchSystemException' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='3c8f9f30-f00b-4ff2-b1d7-da7aa132ec20' ParentLink='Catch_Statement' LowerBound='229.1' HigherBound='243.1'>
                            <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Inside catch of transmitter system exception&quot;);       &#xD;&#xA;ROLogger = ROBTLogger.GetLogger(interfaceName,xprotID,&quot;Import&quot;);       &#xD;&#xA;if(systemException != null)&#xD;&#xA;{&#xD;&#xA;    System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Sending mail after system exception&quot;);            &#xD;&#xA;    ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;Sending mail after system exception&quot;,ROLogger);&#xD;&#xA;    mailStatus = FTPHandler1.SendMailToAdmins(interfaceName,RQ1System,msgACKFileName,xprotID,ROLogger);&#xD;&#xA;    if(mailStatus)&#xD;&#xA;    {&#xD;&#xA;        System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Mail sent successfully&quot;);           &#xD;&#xA;        ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;Mail sent successfully&quot;,ROLogger); &#xD;&#xA;    }&#xD;&#xA;}&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='8f2080d2-4072-4043-8ecc-0d4a0d123203' ParentLink='Scope_Catch' LowerBound='244.1' HigherBound='264.1'>
                        <om:Property Name='ExceptionName' Value='soapException' />
                        <om:Property Name='ExceptionType' Value='System.Web.Services.Protocols.SoapException' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchSoapException' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='d314e148-f3b9-4a0c-8489-d38dc543da44' ParentLink='Catch_Statement' LowerBound='247.1' HigherBound='263.1'>
                            <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Inside catch of transmitter soap exception&quot; );&#xD;&#xA;ROLogger = ROBTLogger.GetLogger(interfaceName,xprotID,&quot;Import&quot;);&#xD;&#xA;if(soapException != null)&#xD;&#xA;{&#xD;&#xA;    System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Sending mail after soap exception&quot;);            &#xD;&#xA;    &#xD;&#xA;    ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + soapException.Message ,ROLogger);  &#xD;&#xA;    ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;Sending mail after soap exception&quot;,ROLogger);&#xD;&#xA;    mailStatus = FTPHandler1.SendMailToAdmins(interfaceName,RQ1System,msgACKFileName,xprotID,ROLogger);&#xD;&#xA;    if(mailStatus)&#xD;&#xA;    {&#xD;&#xA;        System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Mail sent successfully&quot;);           &#xD;&#xA;        ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;Mail sent successfully&quot;,ROLogger);        &#xD;&#xA;    }&#xD;&#xA;}&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_2' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='7e94074a-937a-4a4d-ae84-f37dd4873794' ParentLink='Scope_Catch' LowerBound='264.1' HigherBound='280.1'>
                        <om:Property Name='ExceptionType' Value='General Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchGeneralException' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='d3588c06-50a1-41fa-a32a-5dc3011fcca9' ParentLink='Catch_Statement' LowerBound='267.1' HigherBound='279.1'>
                            <om:Property Name='Expression' Value='    System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Inside catch of transmitter general exception&quot; );&#xD;&#xA;    System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Sending mail after general exception&quot;);        &#xD;&#xA;    ROLogger = ROBTLogger.GetLogger(interfaceName,xprotID,&quot;Import&quot;);&#xD;&#xA;    ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;Sending mail after general exception&quot;,ROLogger);&#xD;&#xA;    mailStatus = FTPHandler1.SendMailToAdmins(interfaceName,RQ1System,msgACKFileName,xprotID,ROLogger);&#xD;&#xA;    if(mailStatus)&#xD;&#xA;    {&#xD;&#xA;        System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Mail sent successfully&quot;);          &#xD;&#xA;        ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;Mail sent successfully&quot;,ROLogger);&#xD;&#xA;    }&#xD;&#xA;    &#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_3' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='e462a36c-c769-40aa-93a3-841ea97c22cc' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='35.1' HigherBound='38.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='True' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='Transmitted' />
                <om:Property Name='Type' Value='FTPIssueTransfer.TransmitterRef.TransmitterService_.TransmitterService' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_DAIMLER_TRANSRECEIVE' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='5bc8118d-790f-487e-8d13-ca3c0d9bcd81' ParentLink='PortDeclaration_CLRAttribute' LowerBound='35.1' HigherBound='36.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='cc8ea6c8-5d1a-4209-a39d-f29fa7137252' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='38.1' HigherBound='40.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='14' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='FTPIssueTransfer.PortType_4' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_WSOUT' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='fd5c82a1-d8b4-4877-abba-1d35ad6500b5' ParentLink='PortDeclaration_CLRAttribute' LowerBound='38.1' HigherBound='39.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='c89e596b-2b9a-47bc-9abf-c8c48ff4bcd8' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='40.1' HigherBound='42.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='15' />
                <om:Property Name='IsWebPort' Value='True' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='FTPIssueTransfer.TransmitterRef.TransmitterService_.TransmitterService' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_BMW_TRANSRECEIVE' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='4b16c266-2243-4c06-b99b-247d6932f27b' ParentLink='PortDeclaration_CLRAttribute' LowerBound='40.1' HigherBound='41.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='cb57781d-2db3-41d7-9f92-f43857ba93db' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='42.1' HigherBound='44.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='0' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='FTPIssueTransfer.PortType_7' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TransmitterRequestRecievePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='1b221d08-402c-40d7-9aa7-561c1f5df0b7' ParentLink='PortDeclaration_CLRAttribute' LowerBound='42.1' HigherBound='43.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='dc69848a-3859-4417-abd5-5a391b6882ec' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='44.1' HigherBound='46.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='15' />
                <om:Property Name='IsWebPort' Value='True' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='FTPIssueTransfer.TransmitterRef.TransmitterService_.TransmitterService' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_BMW_CC_TRANSRECIEVE' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='b043f8fb-1620-4c69-9804-d4653f0da28f' ParentLink='PortDeclaration_CLRAttribute' LowerBound='44.1' HigherBound='45.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='8c5d2eeb-25a1-4616-8a35-db6e0c99c559' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_3' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='cf7494de-8fd8-4244-b670-6a02a1e0ab60' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='24d4481f-d3e0-47e9-867f-a89d1a3ca127' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.69'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='58480c5c-c238-4543-9b6c-e8dda0907c0c' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_4' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='2a13486d-3b2b-4568-93f8-0d535851cae9' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='57508f32-98dd-45d7-963f-0c9afb310938' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.70'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='0aef7cfd-9707-4e29-bf13-f46ab485a9bc' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_7' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='2863c2b2-b8bb-4707-948b-214cdaac8a7f' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='4ff3b286-7d09-4af9-aa58-f4292d125a76' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.44'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.InitialTransmitterRequestSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='5fe39244-be1b-4855-a333-6a5a18474a4e' ParentLink='Module_PortType' LowerBound='25.1' HigherBound='32.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='BMW_CCTRANSRECEIVE' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='340f31dd-74fb-470e-9e84-92dfc381261a' ParentLink='PortType_OperationDeclaration' LowerBound='27.1' HigherBound='31.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='5bbe3bf0-a2b6-41a3-bf47-356ee8a9b455' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='29.13' HigherBound='29.69'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='8b9b8689-1147-46f1-b259-fd589f059490' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='29.71' HigherBound='29.128'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __SendMessageAcknowledgement_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __SendMessageAcknowledgement_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "SendMessageAcknowledgement")
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
                SendMessageAcknowledgement __svc__ = (SendMessageAcknowledgement)_service;
                __SendMessageAcknowledgement_root_0 __ctx0__ = (__SendMessageAcknowledgement_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Port_BMW_TRANSRECEIVE != null)
                {
                    __svc__.Port_BMW_TRANSRECEIVE.Close(this, null);
                    __svc__.Port_BMW_TRANSRECEIVE = null;
                }
                if (__svc__.Port_WSOUT != null)
                {
                    __svc__.Port_WSOUT.Close(this, null);
                    __svc__.Port_WSOUT = null;
                }
                if (__svc__.Port_BMW_CC_TRANSRECIEVE != null)
                {
                    __svc__.Port_BMW_CC_TRANSRECIEVE.Close(this, null);
                    __svc__.Port_BMW_CC_TRANSRECIEVE = null;
                }
                if (__svc__.Port_DAIMLER_TRANSRECEIVE != null)
                {
                    __svc__.Port_DAIMLER_TRANSRECEIVE.Close(this, null);
                    __svc__.Port_DAIMLER_TRANSRECEIVE = null;
                }
                if (__svc__.TransmitterRequestRecievePort != null)
                {
                    __svc__.TransmitterRequestRecievePort.Close(this, null);
                    __svc__.TransmitterRequestRecievePort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper2;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper3;
        }


        [System.SerializableAttribute]
        public class __SendMessageAcknowledgement_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __SendMessageAcknowledgement_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "SendMessageAcknowledgement")
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
                SendMessageAcknowledgement __svc__ = (SendMessageAcknowledgement)_service;
                __SendMessageAcknowledgement_1 __ctx1__ = (__SendMessageAcknowledgement_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__responseMessage = null;
                if (__ctx1__ != null)
                    __ctx1__.__interfaceName = null;
                if (__ctx1__ != null)
                    __ctx1__.__msgACKFileName = null;
                if (__ctx1__ != null && __ctx1__.__receivedMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__receivedMsg);
                    __ctx1__.__receivedMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__responseStatus = null;
                if (__ctx1__ != null)
                    __ctx1__.__xprotID = null;
                if (__ctx1__ != null)
                    __ctx1__.__ROLogger = null;
                if (__ctx1__ != null)
                    __ctx1__.__ROBTLogger = null;
                if (__ctx1__ != null)
                    __ctx1__.__RQ1System = null;
                if (__ctx1__ != null)
                    __ctx1__.__FTPHandler1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__category = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgREQ")]
            internal FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_request __msgREQ;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgRES")]
            internal FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_response __msgRES;
            [Microsoft.XLANGs.Core.UserVariableAttribute("receivedMsg")]
            public __messagetype_FTPIssueTransfer_InitialTransmitterRequestSchema __receivedMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("responseStatus")]
            internal System.String __responseStatus;
            [Microsoft.XLANGs.Core.UserVariableAttribute("responseMessage")]
            internal System.String __responseMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgACKFileName")]
            internal System.String __msgACKFileName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RQ1System")]
            internal System.String __RQ1System;
            [Microsoft.XLANGs.Core.UserVariableAttribute("interfaceName")]
            internal System.String __interfaceName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("mailStatus")]
            internal System.Boolean __mailStatus;
            [Microsoft.XLANGs.Core.UserVariableAttribute("xprotID")]
            internal System.String __xprotID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ROLogger")]
            internal RB.BTLoggerLibrary.Logger __ROLogger;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ROBTLogger")]
            internal RB.BTLoggerLibrary.BTLogger __ROBTLogger;
            [Microsoft.XLANGs.Core.UserVariableAttribute("FTPHandler1")]
            internal RB.FTPLibrary.FTPHandler __FTPHandler1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("category")]
            internal System.String __category;
        }


        [System.SerializableAttribute]
        public class ____scope33_2 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope33_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope33")
            {
            }

            public override int Index { get { return 2; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[2]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[2]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;
                Microsoft.XLANGs.Core.FaultReceiveException __fault__;

                __exv__ = _exception;
                if (!(__exv__ is Microsoft.XLANGs.Core.UnknownException))
                {
                    __fault__ = __exv__ as Microsoft.XLANGs.Core.FaultReceiveException;
                    if ((__fault__ == null) && (__exv__ is System.Web.Services.Protocols.SoapException))
                    {
                        __seg__ = _service._segments[3];
                        __seg__.Reset(1);
                        __seg__.PredecessorDone(_service);
                        return true;
                    }
                    if ((__fault__ == null) && (__exv__ is System.SystemException))
                    {
                        __seg__ = _service._segments[5];
                        __seg__.Reset(1);
                        __seg__.PredecessorDone(_service);
                        return true;
                    }
                }

                __seg__ = _service._segments[4];
                __seg__.Reset(1);
                __seg__.PredecessorDone(_service);
                return true;
            }

            public override void Finally()
            {
                SendMessageAcknowledgement __svc__ = (SendMessageAcknowledgement)_service;
                ____scope33_2 __ctx2__ = (____scope33_2)(__svc__._stateMgrs[2]);
                __SendMessageAcknowledgement_root_0 __ctx0__ = (__SendMessageAcknowledgement_root_0)(__svc__._stateMgrs[0]);
                __SendMessageAcknowledgement_1 __ctx1__ = (__SendMessageAcknowledgement_1)(__svc__._stateMgrs[1]);

                if (__ctx0__ != null && __ctx0__.__subWrapper2 != null)
                {
                    __ctx0__.__subWrapper2.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper2 = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper3 != null)
                {
                    __ctx0__.__subWrapper3.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper3 = null;
                }
                if (__ctx2__ != null)
                    __ctx2__.__systemException_1 = null;
                if (__ctx2__ != null)
                    __ctx2__.__soapException_0 = null;
                if (__ctx1__ != null && __ctx1__.__msgRES != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgRES);
                    __ctx1__.__msgRES = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgREQ != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgREQ);
                    __ctx1__.__msgREQ = null;
                }
                base.Finally();
            }

            internal object __exv__;
            internal System.Web.Services.Protocols.SoapException __soapException_0
            {
                get { return (System.Web.Services.Protocols.SoapException)__exv__; }
                set { __exv__ = value; }
            }
            internal System.SystemException __systemException_1
            {
                get { return (System.SystemException)__exv__; }
                set { __exv__ = value; }
            }
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("TransmitterRequestRecievePort")]
        internal PortType_7 TransmitterRequestRecievePort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.DeliveryNotificationAttribute(Microsoft.XLANGs.BaseTypes.DeliveryNotificationAttribute.NotificationLevel.Transmitted)]
        [Microsoft.XLANGs.BaseTypes.WSDLProxyNameAttribute(typeof(FTPIssueTransfer.TransmitterRef.TransmitterService))]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_DAIMLER_TRANSRECEIVE")]
        internal FTPIssueTransfer.TransmitterRef.TransmitterService_.TransmitterService Port_DAIMLER_TRANSRECEIVE;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_WSOUT")]
        internal PortType_4 Port_WSOUT;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.WSDLProxyNameAttribute(typeof(FTPIssueTransfer.TransmitterRef.TransmitterService))]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_BMW_TRANSRECEIVE")]
        internal FTPIssueTransfer.TransmitterRef.TransmitterService_.TransmitterService Port_BMW_TRANSRECEIVE;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.WSDLProxyNameAttribute(typeof(FTPIssueTransfer.TransmitterRef.TransmitterService))]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_BMW_CC_TRANSRECIEVE")]
        internal FTPIssueTransfer.TransmitterRef.TransmitterService_.TransmitterService Port_BMW_CC_TRANSRECIEVE;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_7.Operation_1},
                                               typeof(SendMessageAcknowledgement).GetField("TransmitterRequestRecievePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(SendMessageAcknowledgement), "TransmitterRequestRecievePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {FTPIssueTransfer.TransmitterRef.TransmitterService_.TransmitterService.startTransmit},
                                               typeof(SendMessageAcknowledgement).GetField("Port_DAIMLER_TRANSRECEIVE", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(SendMessageAcknowledgement), "Port_DAIMLER_TRANSRECEIVE"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_4.Operation_1},
                                               typeof(SendMessageAcknowledgement).GetField("Port_WSOUT", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(SendMessageAcknowledgement), "Port_WSOUT"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {FTPIssueTransfer.TransmitterRef.TransmitterService_.TransmitterService.startTransmit},
                                               typeof(SendMessageAcknowledgement).GetField("Port_BMW_TRANSRECEIVE", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(SendMessageAcknowledgement), "Port_BMW_TRANSRECEIVE"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {FTPIssueTransfer.TransmitterRef.TransmitterService_.TransmitterService.startTransmit},
                                               typeof(SendMessageAcknowledgement).GetField("Port_BMW_CC_TRANSRECIEVE", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(SendMessageAcknowledgement), "Port_BMW_CC_TRANSRECIEVE"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "562759cd-ebf4-487d-b806-a16845e5ddd0", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "562759cd-ebf4-487d-b806-a16845e5ddd0", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "1614766b-da8e-45ed-bdc6-6919ae21f2b0", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "1614766b-da8e-45ed-bdc6-6919ae21f2b0", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "c2a767a2-13e8-4035-948d-32c4a9dc90c0", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "e460493d-31f9-4299-b74c-fced14113aee", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "e460493d-31f9-4299-b74c-fced14113aee", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "9f15cbd4-7a44-47a5-b615-53b84f29de95", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "80bdb8d1-462a-4705-967d-c7a7a99bac9c", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "80bdb8d1-462a-4705-967d-c7a7a99bac9c", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "04870a02-1bf5-4498-bbb4-c46bfa5a1754", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "04870a02-1bf5-4498-bbb4-c46bfa5a1754", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "c3e2ecba-e2c9-400e-b2cf-3686eb7594b2", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "c3e2ecba-e2c9-400e-b2cf-3686eb7594b2", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "69596319-9315-4c3d-ba20-ee93edf9ad3d", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "69596319-9315-4c3d-ba20-ee93edf9ad3d", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "a9a02a7d-b38c-4fbe-bb7f-9b45097a9117", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "a9a02a7d-b38c-4fbe-bb7f-9b45097a9117", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "ae75022a-f41d-4437-976f-dc5fedf24fa8", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "ae75022a-f41d-4437-976f-dc5fedf24fa8", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "51212de7-dc6d-4776-b7bf-9a25bbbab0e1", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "51212de7-dc6d-4776-b7bf-9a25bbbab0e1", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "c62f7e6a-af35-492b-ad9c-ac5dc871ffa6", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "c62f7e6a-af35-492b-ad9c-ac5dc871ffa6", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "0a701e99-f5bf-40cb-b7a2-4d8925794c73", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "0a701e99-f5bf-40cb-b7a2-4d8925794c73", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(30, "e2427e37-d7ef-4b02-a3dd-6b5fb605eaea", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(31, "e2427e37-d7ef-4b02-a3dd-6b5fb605eaea", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(32, "c3b88a7a-aafb-49a0-b358-219881faaa30", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(33, "c3b88a7a-aafb-49a0-b358-219881faaa30", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(34, "541be316-1a36-478b-b45a-04496556d244", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(35, "541be316-1a36-478b-b45a-04496556d244", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(36, "0410dae9-8f4e-42a1-99d9-22532d9ff029", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(37, "0410dae9-8f4e-42a1-99d9-22532d9ff029", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(38, "9943c390-056e-4ada-a0a8-d6c54822f80d", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(39, "9943c390-056e-4ada-a0a8-d6c54822f80d", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(40, "41e4ca8e-f986-4396-8abf-c31524733096", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(41, "41e4ca8e-f986-4396-8abf-c31524733096", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(42, "85592bda-5aed-456c-9f54-d133b9467a01", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(43, "85592bda-5aed-456c-9f54-d133b9467a01", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(44, "9f15cbd4-7a44-47a5-b615-53b84f29de95", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(45, "407888b7-2ef2-4a1b-a689-3bff592da8f4", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(46, "407888b7-2ef2-4a1b-a689-3bff592da8f4", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(47, "8f2080d2-4072-4043-8ecc-0d4a0d123203", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(48, "d314e148-f3b9-4a0c-8489-d38dc543da44", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(49, "d314e148-f3b9-4a0c-8489-d38dc543da44", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(50, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(51, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(52, "8f2080d2-4072-4043-8ecc-0d4a0d123203", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(53, "7e94074a-937a-4a4d-ae84-f37dd4873794", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(54, "d3588c06-50a1-41fa-a32a-5dc3011fcca9", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(55, "d3588c06-50a1-41fa-a32a-5dc3011fcca9", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(56, "00000000-0000-0000-0000-000000000000", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(57, "00000000-0000-0000-0000-000000000000", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(58, "7e94074a-937a-4a4d-ae84-f37dd4873794", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(59, "55a8f2c0-2ec8-4751-ae3f-847b581570e6", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(60, "3c8f9f30-f00b-4ff2-b1d7-da7aa132ec20", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(61, "3c8f9f30-f00b-4ff2-b1d7-da7aa132ec20", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(62, "00000000-0000-0000-0000-000000000000", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(63, "00000000-0000-0000-0000-000000000000", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(64, "55a8f2c0-2ec8-4751-ae3f-847b581570e6", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(65, "c2a767a2-13e8-4035-948d-32c4a9dc90c0", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,2,2,2,2,2,4,4,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,6,6,6,65,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 8,8,8,9,10,10,11,11,11,12,13,13,14,15,15,16,16,16,16,16,16,16,18,18,18,19,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,20,21,10,10,10,22,22,22,23,24,24,25,26,26,27,27,27,27,27,27,27,28,28,28,29,30,30,30,30,30,30,30,30,30,30,30,30,30,30,30,30,31,31,31,31,32,32,32,33,34,34,35,36,36,37,37,37,37,37,37,37,38,38,38,39,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40,40,41,41,42,42,43,43,43,44,45,45,46,46,46,46,};
        public static int[] __progressLocation3 = new int[] { 47,47,48,48,49,49,49,49,49,49,49,49,49,49,49,49,49,49,52,52,};
        public static int[] __progressLocation4 = new int[] { 53,53,54,54,55,55,55,55,55,55,55,55,55,55,58,58,};
        public static int[] __progressLocation5 = new int[] { 59,59,60,60,61,61,61,61,61,61,61,61,61,61,61,61,61,64,64,};

        public static int[][] __progressLocations = new int[6] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3,__progressLocation4,__progressLocation5};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __SendMessageAcknowledgement_root_0 __ctx0__ = (__SendMessageAcknowledgement_root_0)_stateMgrs[0];
            __SendMessageAcknowledgement_1 __ctx1__ = (__SendMessageAcknowledgement_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                Port_DAIMLER_TRANSRECEIVE = new FTPIssueTransfer.TransmitterRef.TransmitterService_.TransmitterService(1, this);
                Port_WSOUT = new PortType_4(2, this);
                Port_BMW_TRANSRECEIVE = new FTPIssueTransfer.TransmitterRef.TransmitterService_.TransmitterService(3, this);
                TransmitterRequestRecievePort = new PortType_7(0, this);
                Port_BMW_CC_TRANSRECIEVE = new FTPIssueTransfer.TransmitterRef.TransmitterService_.TransmitterService(4, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], TransmitterRequestRecievePort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __SendMessageAcknowledgement_1(this);
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
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __SendMessageAcknowledgement_root_0 __ctx0__ = (__SendMessageAcknowledgement_root_0)_stateMgrs[0];
            __SendMessageAcknowledgement_1 __ctx1__ = (__SendMessageAcknowledgement_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__responseStatus = default(System.String);
                __ctx1__.__responseMessage = default(System.String);
                __ctx1__.__msgACKFileName = default(System.String);
                __ctx1__.__RQ1System = default(System.String);
                __ctx1__.__interfaceName = default(System.String);
                __ctx1__.__mailStatus = default(System.Boolean);
                __ctx1__.__xprotID = default(System.String);
                __ctx1__.__ROLogger = default(RB.BTLoggerLibrary.Logger);
                __ctx1__.__ROBTLogger = default(RB.BTLoggerLibrary.BTLogger);
                __ctx1__.__FTPHandler1 = default(RB.FTPLibrary.FTPHandler);
                __ctx1__.__category = default(System.String);
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
                if (!TransmitterRequestRecievePort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__receivedMsg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__receivedMsg);
                __ctx1__.__receivedMsg = new __messagetype_FTPIssueTransfer_InitialTransmitterRequestSchema("receivedMsg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__receivedMsg);
                TransmitterRequestRecievePort.ReceiveMessage(0, __msgEnv__, __ctx1__.__receivedMsg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (TransmitterRequestRecievePort != null)
                {
                    TransmitterRequestRecievePort.Close(__ctx1__, __seg__);
                    TransmitterRequestRecievePort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__receivedMsg);
                    __edata.PortName = @"TransmitterRequestRecievePort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__responseStatus = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__responseMessage = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__msgACKFileName = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__RQ1System = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__interfaceName = "";
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__mailStatus = true;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__xprotID = "";
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__ROBTLogger = new RB.BTLoggerLibrary.BTLogger();
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __ctx1__.__FTPHandler1 = new RB.FTPLibrary.FTPHandler();
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.__category = "";
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
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Transmitter Request received at " + System.String.Format("{0:yyyyMMdd-HHmmssffffff - }", System.DateTime.Now));
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
                __ctx1__.__msgACKFileName = System.Convert.ToString(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__receivedMsg.part, "string(/*[local-name()='transmitterRequest' and namespace-uri()='http://FTPIssueTransfer.InitialTransmitterRequestSchema']/*[local-name()='transferFile' and namespace-uri()=''])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Transmitter Request msg ACK FileName: " + __ctx1__.__msgACKFileName);
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                __ctx1__.__interfaceName = System.Convert.ToString(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__receivedMsg.part, "string(/*[local-name()='transmitterRequest' and namespace-uri()='http://FTPIssueTransfer.InitialTransmitterRequestSchema']/*[local-name()='InterfaceName' and namespace-uri()=''])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Transmitter Request Interface Name: " + __ctx1__.__interfaceName);
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                __ctx1__.__RQ1System = System.Convert.ToString(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__receivedMsg.part, "string(/*[local-name()='transmitterRequest' and namespace-uri()='http://FTPIssueTransfer.InitialTransmitterRequestSchema']/*[local-name()='RQ1System' and namespace-uri()=''])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Transmitter Request RQ1System: " + __ctx1__.__RQ1System);
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                __ctx1__.__FTPHandler1 = new RB.FTPLibrary.FTPHandler();
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Successfully initiated FTPHandler");
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                __ctx1__.__xprotID = System.Convert.ToString(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__receivedMsg.part, "string(/*[local-name()='transmitterRequest' and namespace-uri()='http://FTPIssueTransfer.InitialTransmitterRequestSchema']/*[local-name()='XProtID' and namespace-uri()=''])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Transmitter Request XProtID: " + __ctx1__.__xprotID);
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                __ctx1__.__ROLogger = __ctx1__.__ROBTLogger.GetLogger(__ctx1__.__interfaceName, __ctx1__.__xprotID, "Import");
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "Setting log for msg acknowledgement", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                __ctx1__.__category = System.Convert.ToString(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__receivedMsg.part, "string(/*[local-name()='transmitterRequest' and namespace-uri()='http://FTPIssueTransfer.InitialTransmitterRequestSchema']/*[local-name()='Category' and namespace-uri()=''])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Transmitter Request Category: " + __ctx1__.__category);
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 33;
            case 33:
                __ctx2__ = new ____scope33_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 34;
            case 34:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__category = null;
                if (__ctx1__ != null)
                    __ctx1__.__FTPHandler1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__ROBTLogger = null;
                if (__ctx1__ != null)
                    __ctx1__.__ROLogger = null;
                if (__ctx1__ != null)
                    __ctx1__.__xprotID = null;
                if (__ctx1__ != null)
                    __ctx1__.__interfaceName = null;
                if (__ctx1__ != null)
                    __ctx1__.__RQ1System = null;
                if (__ctx1__ != null)
                    __ctx1__.__msgACKFileName = null;
                if (__ctx1__ != null)
                    __ctx1__.__responseMessage = null;
                if (__ctx1__ != null)
                    __ctx1__.__responseStatus = null;
                if (__ctx1__ != null && __ctx1__.__receivedMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__receivedMsg);
                    __ctx1__.__receivedMsg = null;
                }
                if (Port_BMW_CC_TRANSRECIEVE != null)
                {
                    Port_BMW_CC_TRANSRECIEVE.Close(__ctx1__, __seg__);
                    Port_BMW_CC_TRANSRECIEVE = null;
                }
                if (Port_BMW_TRANSRECEIVE != null)
                {
                    Port_BMW_TRANSRECEIVE.Close(__ctx1__, __seg__);
                    Port_BMW_TRANSRECEIVE = null;
                }
                if (Port_WSOUT != null)
                {
                    Port_WSOUT.Close(__ctx1__, __seg__);
                    Port_WSOUT = null;
                }
                if (Port_DAIMLER_TRANSRECEIVE != null)
                {
                    Port_DAIMLER_TRANSRECEIVE.Close(__ctx1__, __seg__);
                    Port_DAIMLER_TRANSRECEIVE = null;
                }
                Tracker.FireEvent(__eventLocations[65],__eventData[11],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[12],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 38;
            case 38:
                if ( !PreProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 39;
            case 39:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __SendMessageAcknowledgement_root_0 __ctx0__ = (__SendMessageAcknowledgement_root_0)_stateMgrs[0];
            __SendMessageAcknowledgement_1 __ctx1__ = (__SendMessageAcknowledgement_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                {
                    FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_request __msgREQ = new FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_request("msgREQ", __ctx1__);

                    ApplyTransform(typeof(FTPIssueTransfer.TransformTransmitterRequestMessage), new object[] {__msgREQ.transmitterRequest}, new object[] {__ctx1__.__receivedMsg.part});

                    if (__ctx1__.__msgREQ != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgREQ);
                    __ctx1__.__msgREQ = __msgREQ;
                    __ctx1__.RefMessage(__ctx1__.__msgREQ);
                }
                __ctx1__.__msgREQ.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgREQ);
                    __edata.Messages.Add(__ctx1__.__receivedMsg);
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __condition__ = System.String.Equals(__ctx1__.__interfaceName, "RO-ASAM-DAIMLER");
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 44 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 44;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_DAIMLER_TRANSRECEIVE.SendMessage(0, __ctx1__.__msgREQ, null, null, out __ctx0__.__subWrapper1, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgREQ);
                    __edata.PortName = @"Port_DAIMLER_TRANSRECEIVE";
                    Tracker.FireEvent(__eventLocations[12],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if (!Port_DAIMLER_TRANSRECEIVE.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__msgRES != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgRES);
                __ctx1__.__msgRES = new FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_response("msgRES", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgRES);
                Port_DAIMLER_TRANSRECEIVE.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgRES, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgRES);
                    __edata.PortName = @"Port_DAIMLER_TRANSRECEIVE";
                    Tracker.FireEvent(__eventLocations[14],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                __ctx1__.__ROLogger = __ctx1__.__ROBTLogger.GetLogger(__ctx1__.__interfaceName, __ctx1__.__xprotID, "Import");
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Daimler Transmitter Response received at " + System.String.Format("{0:yyyyMMdd-HHmmssffffff - }", System.DateTime.Now));
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                __ctx1__.__ROBTLogger.WriteLog("Daimler Transmitter Response received at " + System.String.Format("{0:yyyyMMdd-HHmmssffffff - }", System.DateTime.Now), __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                __ctx1__.__responseStatus = System.Convert.ToString(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__msgRES.startTransmitResult, "string(/*[local-name()='transmitterResponse' and namespace-uri()='http://www.bosch.com/edexas/asam/transmitter/services']/*[local-name()='failure' and namespace-uri()=''])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Daimler Transmitter Received Response Status - " + __ctx1__.__responseStatus);
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                __ctx1__.__responseMessage = System.Convert.ToString(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__msgRES.startTransmitResult, "string(/*[local-name()='transmitterResponse' and namespace-uri()='http://www.bosch.com/edexas/asam/transmitter/services']/*[local-name()='result' and namespace-uri()=''])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Daimler Transmitter Received Response Message - " + __ctx1__.__responseMessage);
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_WSOUT.SendMessage(0, __ctx1__.__msgRES, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgRES);
                    __edata.PortName = @"Port_WSOUT";
                    Tracker.FireEvent(__eventLocations[19],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                __condition__ = __ctx1__.__responseStatus == "true";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 42 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 42;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                __condition__ = !System.String.IsNullOrEmpty(__ctx1__.__responseMessage);
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 41 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 41;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                __condition__ = __ctx1__.__responseMessage.Contains("HTTP/1.1 500");
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 40 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 40;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "Daimler Transmitter Response has error,sending mail", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Daimler Transmitter Response has error,sending mail");
                if ( !PostProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 34;
            case 34:
                __ctx1__.__mailStatus = __ctx1__.__FTPHandler1.SendMailToAdmins(__ctx1__.__interfaceName, __ctx1__.__RQ1System, __ctx1__.__msgACKFileName, __ctx1__.__xprotID, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 35;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 36;
            case 36:
                __condition__ = __ctx1__.__mailStatus;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 39;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 37;
            case 37:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Mail sent successfully");
                if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 38;
            case 38:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "Mail sent successfully", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 40;
            case 40:
                if ( !PreProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 41;
            case 41:
                if ( !PreProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 42;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 43;
            case 43:
                if ( !PostProgressInc( __seg__, __ctx__, 129 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 129;
            case 44:
                if ( !PreProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 45;
            case 45:
                __condition__ = System.String.Equals(__ctx1__.__interfaceName, "RO-ASAM-BMW") && System.String.Equals(__ctx1__.__category, "BMW-PROSPR");
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 84 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 84;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 46;
            case 46:
                if ( !PreProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 47;
            case 47:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 48;
            case 48:
                if ( !PreProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_BMW_TRANSRECEIVE.SendMessage(0, __ctx1__.__msgREQ, null, null, out __ctx0__.__subWrapper2, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 49;
            case 49:
                if ( !PreProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgREQ);
                    __edata.PortName = @"Port_BMW_TRANSRECEIVE";
                    Tracker.FireEvent(__eventLocations[23],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 50;
            case 50:
                if ( !PreProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 51;
            case 51:
                if (!Port_BMW_TRANSRECEIVE.GetMessageId(__ctx0__.__subWrapper2.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[1]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper2 != null)
                {
                    __ctx0__.__subWrapper2.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper2 = null;
                }
                if (__ctx1__.__msgRES != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgRES);
                __ctx1__.__msgRES = new FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_response("msgRES", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgRES);
                Port_BMW_TRANSRECEIVE.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgRES, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 52;
            case 52:
                if ( !PreProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgRES);
                    __edata.PortName = @"Port_BMW_TRANSRECEIVE";
                    Tracker.FireEvent(__eventLocations[25],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 53;
            case 53:
                if ( !PreProgressInc( __seg__, __ctx__, 54 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[26],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 54;
            case 54:
                __ctx1__.__ROLogger = __ctx1__.__ROBTLogger.GetLogger(__ctx1__.__interfaceName, __ctx1__.__xprotID, "Import");
                if ( !PostProgressInc( __seg__, __ctx__, 55 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 55;
            case 55:
                if ( !PreProgressInc( __seg__, __ctx__, 56 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[27],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 56;
            case 56:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "BMW Transmitter Response received at " + System.String.Format("{0:yyyyMMdd-HHmmssffffff - }", System.DateTime.Now));
                if ( !PostProgressInc( __seg__, __ctx__, 57 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 57;
            case 57:
                __ctx1__.__ROBTLogger.WriteLog("BMW Transmitter Response received at " + System.String.Format("{0:yyyyMMdd-HHmmssffffff - }", System.DateTime.Now), __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 58 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 58;
            case 58:
                __ctx1__.__responseStatus = System.Convert.ToString(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__msgRES.startTransmitResult, "string(/*[local-name()='transmitterResponse' and namespace-uri()='http://www.bosch.com/edexas/asam/transmitter/services']/*[local-name()='failure' and namespace-uri()=''])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 59 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 59;
            case 59:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "BMW Transmitter Received Response Status - " + __ctx1__.__responseStatus);
                if ( !PostProgressInc( __seg__, __ctx__, 60 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 60;
            case 60:
                __ctx1__.__responseMessage = System.Convert.ToString(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__msgRES.startTransmitResult, "string(/*[local-name()='transmitterResponse' and namespace-uri()='http://www.bosch.com/edexas/asam/transmitter/services']/*[local-name()='result' and namespace-uri()=''])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 61 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 61;
            case 61:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "BMW Transmitter Received Response Message - " + __ctx1__.__responseMessage);
                if ( !PostProgressInc( __seg__, __ctx__, 62 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 62;
            case 62:
                if ( !PreProgressInc( __seg__, __ctx__, 63 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[28],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 63;
            case 63:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 64 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 64;
            case 64:
                if ( !PreProgressInc( __seg__, __ctx__, 65 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_WSOUT.SendMessage(0, __ctx1__.__msgRES, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 65;
            case 65:
                if ( !PreProgressInc( __seg__, __ctx__, 66 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgRES);
                    __edata.PortName = @"Port_WSOUT";
                    Tracker.FireEvent(__eventLocations[29],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 66;
            case 66:
                if ( !PreProgressInc( __seg__, __ctx__, 67 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[30],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 67;
            case 67:
                __condition__ = __ctx1__.__responseStatus == "true";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 82 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 82;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 68 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 68;
            case 68:
                if ( !PreProgressInc( __seg__, __ctx__, 69 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 69;
            case 69:
                __condition__ = !System.String.IsNullOrEmpty(__ctx1__.__responseMessage);
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 81 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 81;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 70 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 70;
            case 70:
                if ( !PreProgressInc( __seg__, __ctx__, 71 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 71;
            case 71:
                __condition__ = __ctx1__.__responseMessage.Contains("HTTP/1.1 500");
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 80 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 80;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 72 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 72;
            case 72:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "BMW Transmitter Response has error,sending mail");
                if ( !PostProgressInc( __seg__, __ctx__, 73 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 73;
            case 73:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "BMW Transmitter Response has error,sending mail", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 74 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 74;
            case 74:
                __ctx1__.__mailStatus = __ctx1__.__FTPHandler1.SendMailToAdmins(__ctx1__.__interfaceName, __ctx1__.__RQ1System, __ctx1__.__msgACKFileName, __ctx1__.__xprotID, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 75 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 75;
            case 75:
                if ( !PreProgressInc( __seg__, __ctx__, 76 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 76;
            case 76:
                __condition__ = __ctx1__.__mailStatus;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 79 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 79;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 77 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 77;
            case 77:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Mail sent successfully");
                if ( !PostProgressInc( __seg__, __ctx__, 78 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 78;
            case 78:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "Mail sent successfully", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 79 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 79;
            case 79:
                if ( !PreProgressInc( __seg__, __ctx__, 80 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 80;
            case 80:
                if ( !PreProgressInc( __seg__, __ctx__, 81 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 81;
            case 81:
                if ( !PreProgressInc( __seg__, __ctx__, 82 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 82;
            case 82:
                if ( !PreProgressInc( __seg__, __ctx__, 83 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[31],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 83;
            case 83:
                if ( !PostProgressInc( __seg__, __ctx__, 128 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 128;
            case 84:
                if ( !PreProgressInc( __seg__, __ctx__, 85 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 85;
            case 85:
                __condition__ = System.String.Equals(__ctx1__.__interfaceName, "RO-ASAM-BMW") && System.String.Equals(__ctx1__.__category, "BMW-CC-PROSPR");
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 124 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 124;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 86 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 86;
            case 86:
                if ( !PreProgressInc( __seg__, __ctx__, 87 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[32],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 87;
            case 87:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 88 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 88;
            case 88:
                if ( !PreProgressInc( __seg__, __ctx__, 89 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_BMW_CC_TRANSRECIEVE.SendMessage(0, __ctx1__.__msgREQ, null, null, out __ctx0__.__subWrapper3, __ctx2__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 89;
            case 89:
                if ( !PreProgressInc( __seg__, __ctx__, 90 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgREQ);
                    __edata.PortName = @"Port_BMW_CC_TRANSRECIEVE";
                    Tracker.FireEvent(__eventLocations[33],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 90;
            case 90:
                if ( !PreProgressInc( __seg__, __ctx__, 91 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[34],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 91;
            case 91:
                if (!Port_BMW_CC_TRANSRECIEVE.GetMessageId(__ctx0__.__subWrapper3.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[2]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper3 != null)
                {
                    __ctx0__.__subWrapper3.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper3 = null;
                }
                if (__ctx1__.__msgRES != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgRES);
                __ctx1__.__msgRES = new FTPIssueTransfer.TransmitterRef.TransmitterService_.startTransmit_response("msgRES", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgRES);
                Port_BMW_CC_TRANSRECIEVE.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgRES, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 92 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 92;
            case 92:
                if ( !PreProgressInc( __seg__, __ctx__, 93 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgRES);
                    __edata.PortName = @"Port_BMW_CC_TRANSRECIEVE";
                    Tracker.FireEvent(__eventLocations[35],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 93;
            case 93:
                if ( !PreProgressInc( __seg__, __ctx__, 94 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[36],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 94;
            case 94:
                __ctx1__.__ROLogger = __ctx1__.__ROBTLogger.GetLogger(__ctx1__.__interfaceName, __ctx1__.__xprotID, "Import");
                if ( !PostProgressInc( __seg__, __ctx__, 95 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 95;
            case 95:
                if ( !PreProgressInc( __seg__, __ctx__, 96 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[37],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 96;
            case 96:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "BMW Transmitter Response received at " + System.String.Format("{0:yyyyMMdd-HHmmssffffff - }", System.DateTime.Now));
                if ( !PostProgressInc( __seg__, __ctx__, 97 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 97;
            case 97:
                __ctx1__.__ROBTLogger.WriteLog("BMW Transmitter Response received at " + System.String.Format("{0:yyyyMMdd-HHmmssffffff - }", System.DateTime.Now), __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 98 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 98;
            case 98:
                __ctx1__.__responseStatus = System.Convert.ToString(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__msgRES.startTransmitResult, "string(/*[local-name()='transmitterResponse' and namespace-uri()='http://www.bosch.com/edexas/asam/transmitter/services']/*[local-name()='failure' and namespace-uri()=''])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 99 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 99;
            case 99:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "BMW Transmitter Received Response Status - " + __ctx1__.__responseStatus);
                if ( !PostProgressInc( __seg__, __ctx__, 100 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 100;
            case 100:
                __ctx1__.__responseMessage = System.Convert.ToString(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__msgRES.startTransmitResult, "string(/*[local-name()='transmitterResponse' and namespace-uri()='http://www.bosch.com/edexas/asam/transmitter/services']/*[local-name()='result' and namespace-uri()=''])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 101 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 101;
            case 101:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "BMW Transmitter Received Response Message - " + __ctx1__.__responseMessage);
                if ( !PostProgressInc( __seg__, __ctx__, 102 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 102;
            case 102:
                if ( !PreProgressInc( __seg__, __ctx__, 103 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[38],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 103;
            case 103:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 104 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 104;
            case 104:
                if ( !PreProgressInc( __seg__, __ctx__, 105 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_WSOUT.SendMessage(0, __ctx1__.__msgRES, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 105;
            case 105:
                if ( !PreProgressInc( __seg__, __ctx__, 106 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgRES);
                    __edata.PortName = @"Port_WSOUT";
                    Tracker.FireEvent(__eventLocations[39],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 106;
            case 106:
                if ( !PreProgressInc( __seg__, __ctx__, 107 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[40],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 107;
            case 107:
                __condition__ = __ctx1__.__responseStatus == "true";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 122 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 122;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 108 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 108;
            case 108:
                if ( !PreProgressInc( __seg__, __ctx__, 109 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 109;
            case 109:
                __condition__ = !System.String.IsNullOrEmpty(__ctx1__.__responseMessage);
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 121 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 121;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 110 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 110;
            case 110:
                if ( !PreProgressInc( __seg__, __ctx__, 111 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 111;
            case 111:
                __condition__ = __ctx1__.__responseMessage.Contains("HTTP/1.1 500");
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 120 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 120;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 112 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 112;
            case 112:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "BMW Transmitter Response has error,sending mail");
                if ( !PostProgressInc( __seg__, __ctx__, 113 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 113;
            case 113:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "BMW Transmitter Response has error,sending mail", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 114 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 114;
            case 114:
                __ctx1__.__mailStatus = __ctx1__.__FTPHandler1.SendMailToAdmins(__ctx1__.__interfaceName, __ctx1__.__RQ1System, __ctx1__.__msgACKFileName, __ctx1__.__xprotID, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 115 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 115;
            case 115:
                if ( !PreProgressInc( __seg__, __ctx__, 116 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 116;
            case 116:
                __condition__ = __ctx1__.__mailStatus;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 119 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 119;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 117 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 117;
            case 117:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Mail sent successfully");
                if ( !PostProgressInc( __seg__, __ctx__, 118 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 118;
            case 118:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "Mail sent successfully", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 119 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 119;
            case 119:
                if ( !PreProgressInc( __seg__, __ctx__, 120 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 120;
            case 120:
                if ( !PreProgressInc( __seg__, __ctx__, 121 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 121;
            case 121:
                if ( !PreProgressInc( __seg__, __ctx__, 122 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 122;
            case 122:
                if ( !PreProgressInc( __seg__, __ctx__, 123 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[41],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 123;
            case 123:
                if ( !PostProgressInc( __seg__, __ctx__, 127 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 127;
            case 124:
                if ( !PreProgressInc( __seg__, __ctx__, 125 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[42],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 125;
            case 125:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "InterfaceName is not DAIMLER or BMW");
                if ( !PostProgressInc( __seg__, __ctx__, 126 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 126;
            case 126:
                Tracker.FireEvent(__eventLocations[43],__eventData[3],_stateMgrs[2].TrackDataStream );
                if ( !PostProgressInc( __seg__, __ctx__, 127 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 127;
            case 127:
                if ( !PreProgressInc( __seg__, __ctx__, 128 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 128;
            case 128:
                if ( !PreProgressInc( __seg__, __ctx__, 129 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 129;
            case 129:
                if ( !PreProgressInc( __seg__, __ctx__, 130 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__msgRES != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgRES);
                    __ctx1__.__msgRES = null;
                }
                if (__ctx1__ != null && __ctx1__.__msgREQ != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgREQ);
                    __ctx1__.__msgREQ = null;
                }
                Tracker.FireEvent(__eventLocations[44],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 130;
            case 130:
                if ( !PreProgressInc( __seg__, __ctx__, 131 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[45],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 131;
            case 131:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Out of transmitter scope");
                if ( !PostProgressInc( __seg__, __ctx__, 132 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 132;
            case 132:
                if ( !PreProgressInc( __seg__, __ctx__, 133 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[46],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 133;
            case 133:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 134 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 134;
            case 134:
                if ( !PreProgressInc( __seg__, __ctx__, 135 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 135;
            case 135:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __SendMessageAcknowledgement_1 __ctx1__ = (__SendMessageAcknowledgement_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(2);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[47],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[48],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Inside catch of transmitter soap exception");
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[49],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__ROLogger = __ctx1__.__ROBTLogger.GetLogger(__ctx1__.__interfaceName, __ctx1__.__xprotID, "Import");
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[50],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __condition__ = __ctx2__.__soapException_0 != null;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 17;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Sending mail after soap exception");
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + __ctx2__.__soapException_0.Message, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "Sending mail after soap exception", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__mailStatus = __ctx1__.__FTPHandler1.SendMailToAdmins(__ctx1__.__interfaceName, __ctx1__.__RQ1System, __ctx1__.__msgACKFileName, __ctx1__.__xprotID, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[50],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                __condition__ = __ctx1__.__mailStatus;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 16;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Mail sent successfully");
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "Mail sent successfully", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[51],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx2__ != null)
                    __ctx2__.__soapException_0 = null;
                Tracker.FireEvent(__eventLocations[51],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[52],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment4(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[4];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __SendMessageAcknowledgement_1 __ctx1__ = (__SendMessageAcknowledgement_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(2);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[53],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[54],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Inside catch of transmitter general exception");
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[55],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Sending mail after general exception");
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__ROLogger = __ctx1__.__ROBTLogger.GetLogger(__ctx1__.__interfaceName, __ctx1__.__xprotID, "Import");
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "Sending mail after general exception", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__mailStatus = __ctx1__.__FTPHandler1.SendMailToAdmins(__ctx1__.__interfaceName, __ctx1__.__RQ1System, __ctx1__.__msgACKFileName, __ctx1__.__xprotID, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[56],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __condition__ = __ctx1__.__mailStatus;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 13;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Mail sent successfully");
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "Mail sent successfully", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[57],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[58],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment5(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[5];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __SendMessageAcknowledgement_1 __ctx1__ = (__SendMessageAcknowledgement_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(2);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[59],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[60],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Inside catch of transmitter system exception");
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[61],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__ROLogger = __ctx1__.__ROBTLogger.GetLogger(__ctx1__.__interfaceName, __ctx1__.__xprotID, "Import");
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[62],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __condition__ = __ctx2__.__systemException_1 != null;
                if (__ctx2__ != null)
                    __ctx2__.__systemException_1 = null;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 16;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Sending mail after system exception");
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "Sending mail after system exception", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__mailStatus = __ctx1__.__FTPHandler1.SendMailToAdmins(__ctx1__.__interfaceName, __ctx1__.__RQ1System, __ctx1__.__msgACKFileName, __ctx1__.__xprotID, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[62],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                __condition__ = __ctx1__.__mailStatus;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 15;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Mail sent successfully");
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "Mail sent successfully", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[63],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[63],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[64],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{0074AD80-183F-447C-B7A0-77605274DDE4}")),
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{9A2F31E9-17D8-42DB-B2A9-9F47015DD780}")),
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{9D3ECB24-5CDA-4938-9DBF-1902CCA0D925}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __FTPIssueTransfer_StartImportSchema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static FTPIssueTransfer.StartImportSchema _schema = new FTPIssueTransfer.StartImportSchema();

        public __FTPIssueTransfer_StartImportSchema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "FTPIssueTransfer.StartImportSchema",
        new System.Type[]{
            typeof(FTPIssueTransfer.StartImportSchema)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__FTPIssueTransfer_StartImportSchema__)
        },
        0,
        @"http://FTPIssueTransfer.Schema1#FTPImportRequest"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_FTPIssueTransfer_StartImportSchema : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __FTPIssueTransfer_StartImportSchema__ part;

        private void __CreatePartWrappers()
        {
            part = new __FTPIssueTransfer_StartImportSchema__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_FTPIssueTransfer_StartImportSchema(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __FTPIssueTransfer_TransferResultInformation__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static FTPIssueTransfer.TransferResultInformation _schema = new FTPIssueTransfer.TransferResultInformation();

        public __FTPIssueTransfer_TransferResultInformation__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "FTPIssueTransfer.TransferResultInformation",
        new System.Type[]{
            typeof(FTPIssueTransfer.TransferResultInformation)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__FTPIssueTransfer_TransferResultInformation__)
        },
        0,
        @"http://FTPIssueTransfer.FTPFileInformation#TransferResult"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_FTPIssueTransfer_TransferResultInformation : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __FTPIssueTransfer_TransferResultInformation__ part;

        private void __CreatePartWrappers()
        {
            part = new __FTPIssueTransfer_TransferResultInformation__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_FTPIssueTransfer_TransferResultInformation(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
