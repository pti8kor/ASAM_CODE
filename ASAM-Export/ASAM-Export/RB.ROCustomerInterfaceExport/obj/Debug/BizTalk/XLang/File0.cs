
#pragma warning disable 162

namespace RB.ROCustomerInterfaceExport
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(RB.ROCustomerInterfaceExport.__messagetype_RB_ROCustomerInterfaceExport_Schemas_Transfer_TransferResultInformation)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
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

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_1),
            typeof(__messagetype_RB_ROCustomerInterfaceExport_Schemas_Transfer_TransferResultInformation),
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
    sealed public class __RB_ROCustomerInterfaceExport_Schemas_Export_IMF_Export_IMF__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF _schema = new RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF();

        public __RB_ROCustomerInterfaceExport_Schemas_Export_IMF_Export_IMF__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF",
        new System.Type[]{
            typeof(RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__RB_ROCustomerInterfaceExport_Schemas_Export_IMF_Export_IMF__)
        },
        0,
        @"http://RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF#EXPORT_IMF"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_RB_ROCustomerInterfaceExport_Schemas_Export_IMF_Export_IMF : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __RB_ROCustomerInterfaceExport_Schemas_Export_IMF_Export_IMF__ part;

        private void __CreatePartWrappers()
        {
            part = new __RB_ROCustomerInterfaceExport_Schemas_Export_IMF_Export_IMF__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_RB_ROCustomerInterfaceExport_Schemas_Export_IMF_Export_IMF(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(RB.ROCustomerInterfaceExport.__messagetype_RB_ROCustomerInterfaceExport_Schemas_RO_Extract_RQ1Extract)
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
            typeof(__messagetype_RB_ROCustomerInterfaceExport_Schemas_RO_Extract_RQ1Extract),
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
            typeof(RB.ROCustomerInterfaceExport.__messagetype_RB_ROCustomerInterfaceExport_Schemas_RO_Extract_RQ1Extract)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Send_RQ1Extract : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Send_RQ1Extract(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Send_RQ1Extract(Send_RQ1Extract p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Send_RQ1Extract p = new Send_RQ1Extract(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Send_RQ1Extract),
            typeof(__messagetype_RB_ROCustomerInterfaceExport_Schemas_RO_Extract_RQ1Extract),
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
            typeof(RB.ROCustomerInterfaceExport.__messagetype_RB_ROCustomerInterfaceExport_Schemas_Export_IMF_Export_IMF)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class IMF_Before_Validate : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public IMF_Before_Validate(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public IMF_Before_Validate(IMF_Before_Validate p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            IMF_Before_Validate p = new IMF_Before_Validate(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(IMF_Before_Validate),
            typeof(__messagetype_RB_ROCustomerInterfaceExport_Schemas_Export_IMF_Export_IMF),
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
            typeof(RB.ROCustomerInterfaceExport.__messagetype_RB_ROCustomerInterfaceExport_Schemas_Export_IMF_Export_IMF)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class afterValidate : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public afterValidate(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public afterValidate(afterValidate p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            afterValidate p = new afterValidate(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(afterValidate),
            typeof(__messagetype_RB_ROCustomerInterfaceExport_Schemas_Export_IMF_Export_IMF),
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
    //#line 305 "D:\ASAM-IF-IMPORT\Import\960 - Sources\SI0VM07516\FFM3FE\BTImportSoftware\ASAM-Export\ASAM-Export\RB.ROCustomerInterfaceExport\Orchestrations\CustomerInterfaceExport.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "ftpTransferRecPort_Export", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        },
        new System.Type[] {
            typeof(RB.ROCustomerInterfaceExport.PortType_1)
        },
        new System.String[] {
            "ftpTransferRecPort_Export"
        },
        new System.Type[] {
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
            typeof(RB.ROCustomerInterfaceExport.ValidateandExecute)
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
    sealed internal class CustomerInterfaceExport : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
                "RB.ROCustomerInterfaceExport.ValidateandExecute"
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(CustomerInterfaceExport));
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

        static CustomerInterfaceExport()
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
            _rootContext = new __CustomerInterfaceExport_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public CustomerInterfaceExport(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "CustomerInterfaceExport", tracker)
        {
            ConstructorHelper();
        }

        public CustomerInterfaceExport(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "CustomerInterfaceExport")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>b90e6a23-6b8a-4692-b7d9-fa0b9671ae69</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>a2bf78e8-d9c6-4247-b799-33330ba09706</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>FTPTransferRec_Export</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>be1034e9-485f-414e-b4f8-a79cdfbb72d0</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Event_log</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>a0145f68-9eed-4995-aafe-422b7909c2bc</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Set_Orch_Variables</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>77ac079c-bc6f-49f3-82db-2108c0bde289</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Set_Logger</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>63209d35-1dce-47f5-9d97-4ca6f95c8ceb</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Records Count</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>WhileShape</shapeType>      <ShapeID>2c9c5397-547b-44ce-af6d-ab55d38ec9b0</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Loop_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>CallShape</shapeType>      <ShapeID>00b2eb50-6c93-4b2f-977e-612978b6cc33</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>CallOrchestration_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>9833b93f-d25f-4b56-9aef-c186a66f8984</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ROLogger</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>df9d5016-9dc0-4a98-8960-beb8bc19aac9</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>batchCount</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>55f5f90d-6ef6-43b5-8ee9-cd31467f8d81</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>sLifeToken4Files</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>0cc96a55-d7bf-46b2-957a-7758827eb5a7</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>sExchangeProtocolID</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>f7d3d356-9dc1-4386-99f5-9acd97dca699</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>ROCustomerExportLibrary</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>af016922-2be1-4bea-abde-1cb459aff699</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>sSystem</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>fbdbc05f-6ac3-43b5-a2b0-b2a2572d28c1</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>sInterfaceName</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>85369e0f-bbb0-459c-afbf-2e574409b6f5</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>index</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>23a60b78-1d59-4017-96a5-3ae4679f5aec</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>increment</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>7094dc66-aae7-451d-a1d1-5b7a79b9ab57</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Update_ExchangeProtocol</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'CustomerInterfaceExport'</ActionName><IsAtomic>0</IsAtomic><Line>305</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>328</Line><Position>22</Position><ShapeID>'a2bf78e8-d9c6-4247-b799-33330ba09706'</ShapeID>
<Messages>
	<MsgInfo><name>msgFTPTransfer</name><part>part</part><schema>RB.ROCustomerInterfaceExport.Schemas.Transfer.TransferResultInformation</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>342</Line><Position>51</Position><ShapeID>'be1034e9-485f-414e-b4f8-a79cdfbb72d0'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>344</Line><Position>51</Position><ShapeID>'a0145f68-9eed-4995-aafe-422b7909c2bc'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>359</Line><Position>25</Position><ShapeID>'77ac079c-bc6f-49f3-82db-2108c0bde289'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>367</Line><Position>26</Position><ShapeID>'63209d35-1dce-47f5-9d97-4ca6f95c8ceb'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>374</Line><Position>13</Position><ShapeID>'2c9c5397-547b-44ce-af6d-ab55d38ec9b0'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>377</Line><Position>70</Position><ShapeID>'00b2eb50-6c93-4b2f-977e-612978b6cc33'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>379</Line><Position>23</Position><ShapeID>'23a60b78-1d59-4017-96a5-3ae4679f5aec'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>382</Line><Position>30</Position><ShapeID>'7094dc66-aae7-451d-a1d1-5b7a79b9ab57'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='ba0dc0e2-99f6-4c0c-8fe6-e0d2cac54a6e' LowerBound='1.1' HigherBound='95.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='RB.ROCustomerInterfaceExport' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='f9b9a46f-8dda-427b-b70b-56ee6f85b7d3' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='fd77cb56-9e1c-4bd3-bd1e-d6cf6a040e6d' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='903cbd8f-5bb5-41bf-8702-762d283041a4' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.55'>
                    <om:Property Name='Ref' Value='RB.ROCustomerInterfaceExport.Schemas.Transfer.TransferResultInformation' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='d824e26d-6efc-4463-9422-a136715add21' ParentLink='Module_ServiceDeclaration' LowerBound='11.1' HigherBound='94.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CustomerInterfaceExport' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='0a354fd6-e21d-49c8-9557-6e3f144e1874' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='17.1' HigherBound='18.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sDownloadTargetPath' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='674f5473-6204-4474-98d0-d9c117446dd2' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='18.1' HigherBound='19.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sInterfaceName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='781a8c6c-f81e-406e-bcf5-d6a65e8b4629' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='19.1' HigherBound='20.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sExchangeProtocolID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='e1a4b58e-09b5-46ec-a9fc-58422d2777dd' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='20.1' HigherBound='21.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sSystem' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='b657be2e-653b-4b4a-8926-cfc4dd092d2e' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='21.1' HigherBound='22.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sLifeToken4Xprot' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='bdc5199b-6035-4572-b82e-647ad89a54db' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='22.1' HigherBound='23.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sLifeToken4Files' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='6e4e4b1e-cd73-4190-ad09-c70dfb5da0bc' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='23.1' HigherBound='24.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sMode' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='5e619351-f26a-47e4-be5b-7e714f7c6387' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='24.1' HigherBound='25.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sConfigPath' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='40682d78-4cf2-4d85-9a45-45b6bcb1f8f4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExportLibrary.Logger' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ROLogger' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='afecd09a-4208-4444-9886-ea2856b8ed21' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExportLibrary.BTHelper' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ROCustomerExportLibrary' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='bd88ae17-96d9-43d8-abc4-2c04bc7e5d6a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='InitialValue' Value='0' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='recordsCount' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='a734df00-81e9-430d-8d73-c39bafade5e2' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='InitialValue' Value='0' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='batchCount' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='1b7e8544-fda3-41f8-918e-0c5450d442fc' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='index' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3b2af4a5-e8c4-466b-9337-f00f003c458f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExportLibrary.AsyncLogger' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='asyncLogger' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ea3753d8-236e-4769-b5cd-50d3676adaac' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='31.1' HigherBound='32.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sStatus' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='722acb69-9c3a-4ba3-9c4c-b94c1de3f46d' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='16.1' HigherBound='17.1'>
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExport.Schemas.Transfer.TransferResultInformation' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgFTPTransfer' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='b90e6a23-6b8a-4692-b7d9-fa0b9671ae69' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='a2bf78e8-d9c6-4247-b799-33330ba09706' ParentLink='ServiceBody_Statement' LowerBound='34.1' HigherBound='48.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='ftpTransferRecPort_Export' />
                    <om:Property Name='MessageName' Value='msgFTPTransfer' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='FTPTransferRec_Export' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='be1034e9-485f-414e-b4f8-a79cdfbb72d0' ParentLink='ServiceBody_Statement' LowerBound='48.1' HigherBound='50.1'>
                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;Export - Interface run starts&quot; );' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Event_log' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='a0145f68-9eed-4995-aafe-422b7909c2bc' ParentLink='ServiceBody_Statement' LowerBound='50.1' HigherBound='65.1'>
                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;Setting Variables starts&quot; );&#xD;&#xA;&#xD;&#xA;sInterfaceName = msgFTPTransfer.InterfaceName;&#xD;&#xA;sDownloadTargetPath=msgFTPTransfer.DownloadTargetPath;&#xD;&#xA;sExchangeProtocolID = msgFTPTransfer.XProtID;&#xD;&#xA;sSystem = msgFTPTransfer.RQ1System;&#xD;&#xA;sLifeToken4Files = msgFTPTransfer.LifeToken4Files;&#xD;&#xA;sLifeToken4Xprot = msgFTPTransfer.LifeToken4XProt;&#xD;&#xA;&#xD;&#xA;sMode = msgFTPTransfer.Mode;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;Interface name =&quot;+ sInterfaceName);' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Set_Orch_Variables' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='77ac079c-bc6f-49f3-82db-2108c0bde289' ParentLink='ServiceBody_Statement' LowerBound='65.1' HigherBound='73.1'>
                    <om:Property Name='Expression' Value='sConfigPath = ROCustomerExportLibrary.GetConfigPathForLogger(sInterfaceName,sExchangeProtocolID);&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_EXPORT&quot;,&quot;sConfigPath=&quot;+sConfigPath);&#xD;&#xA;ROLogger = new RB.ROCustomerInterfaceExportLibrary.Logger(sConfigPath);&#xD;&#xA;&#xD;&#xA;ROCustomerExportLibrary.SetLoggingMode(sInterfaceName,ROLogger);&#xD;&#xA;&#xD;&#xA;ROLogger.LogInfo(&quot;Log set&quot;);' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Set_Logger' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='63209d35-1dce-47f5-9d97-4ca6f95c8ceb' ParentLink='ServiceBody_Statement' LowerBound='73.1' HigherBound='80.1'>
                    <om:Property Name='Expression' Value='recordsCount = ROCustomerExportLibrary.GetRecordsCount(sLifeToken4Files, ROLogger);&#xD;&#xA;&#xD;&#xA;batchCount = ROCustomerExportLibrary.GetBatchCount(recordsCount, ROLogger);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;index = 1;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Records Count' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='While' OID='2c9c5397-547b-44ce-af6d-ab55d38ec9b0' ParentLink='ServiceBody_Statement' LowerBound='80.1' HigherBound='88.1'>
                    <om:Property Name='Expression' Value='index &lt;= batchCount' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Loop_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Call' OID='00b2eb50-6c93-4b2f-977e-612978b6cc33' ParentLink='ComplexStatement_Statement' LowerBound='83.1' HigherBound='85.1'>
                        <om:Property Name='Identifier' Value='CallOrchestration_1' />
                        <om:Property Name='Invokee' Value='RB.ROCustomerInterfaceExport.ValidateandExecute' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CallOrchestration_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Parameter' OID='9833b93f-d25f-4b56-9aef-c186a66f8984' ParentLink='InvokeStatement_Parameter'>
                            <om:Property Name='Direction' Value='In' />
                            <om:Property Name='Name' Value='ROLogger' />
                            <om:Property Name='Type' Value='RB.ROCustomerInterfaceExportLibrary.Logger' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Parameter' OID='df9d5016-9dc0-4a98-8960-beb8bc19aac9' ParentLink='InvokeStatement_Parameter'>
                            <om:Property Name='Direction' Value='In' />
                            <om:Property Name='Name' Value='batchCount' />
                            <om:Property Name='Type' Value='System.Int32' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Parameter' OID='55f5f90d-6ef6-43b5-8ee9-cd31467f8d81' ParentLink='InvokeStatement_Parameter'>
                            <om:Property Name='Direction' Value='Ref' />
                            <om:Property Name='Name' Value='sLifeToken4Files' />
                            <om:Property Name='Type' Value='System.String' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Parameter' OID='0cc96a55-d7bf-46b2-957a-7758827eb5a7' ParentLink='InvokeStatement_Parameter'>
                            <om:Property Name='Direction' Value='In' />
                            <om:Property Name='Name' Value='sExchangeProtocolID' />
                            <om:Property Name='Type' Value='System.String' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Parameter' OID='f7d3d356-9dc1-4386-99f5-9acd97dca699' ParentLink='InvokeStatement_Parameter'>
                            <om:Property Name='Direction' Value='In' />
                            <om:Property Name='Name' Value='ROCustomerExportLibrary' />
                            <om:Property Name='Type' Value='RB.ROCustomerInterfaceExportLibrary.BTHelper' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Parameter' OID='af016922-2be1-4bea-abde-1cb459aff699' ParentLink='InvokeStatement_Parameter'>
                            <om:Property Name='Direction' Value='In' />
                            <om:Property Name='Name' Value='sSystem' />
                            <om:Property Name='Type' Value='System.String' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Parameter' OID='fbdbc05f-6ac3-43b5-a2b0-b2a2572d28c1' ParentLink='InvokeStatement_Parameter'>
                            <om:Property Name='Direction' Value='In' />
                            <om:Property Name='Name' Value='sInterfaceName' />
                            <om:Property Name='Type' Value='System.String' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Parameter' OID='85369e0f-bbb0-459c-afbf-2e574409b6f5' ParentLink='InvokeStatement_Parameter'>
                            <om:Property Name='Direction' Value='In' />
                            <om:Property Name='Name' Value='index' />
                            <om:Property Name='Type' Value='System.Int32' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='VariableAssignment' OID='23a60b78-1d59-4017-96a5-3ae4679f5aec' ParentLink='ComplexStatement_Statement' LowerBound='85.1' HigherBound='87.1'>
                        <om:Property Name='Expression' Value='index = index + 1;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='increment' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='VariableAssignment' OID='7094dc66-aae7-451d-a1d1-5b7a79b9ab57' ParentLink='ServiceBody_Statement' LowerBound='88.1' HigherBound='92.1'>
                    <om:Property Name='Expression' Value='sLifeToken4Xprot = ROCustomerExportLibrary.ChangeLifeToken4Xprot(sLifeToken4Files,sLifeToken4Xprot);&#xD;&#xA;sStatus = ROCustomerExportLibrary.UpdateExchangeProtocol(sExchangeProtocolID,sSystem,sInterfaceName,sLifeToken4Files, sLifeToken4Xprot);&#xD;&#xA;ROCustomerExportLibrary.DeleteStageLock(sExchangeProtocolID);' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Update_ExchangeProtocol' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='2ebfef07-0d5e-413e-b298-ce9853905a71' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='14.1' HigherBound='16.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExport.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ftpTransferRecPort_Export' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='50b0c698-7c5a-4108-885f-724f5f39e19a' ParentLink='PortDeclaration_CLRAttribute' LowerBound='14.1' HigherBound='15.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __CustomerInterfaceExport_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __CustomerInterfaceExport_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "CustomerInterfaceExport")
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
                CustomerInterfaceExport __svc__ = (CustomerInterfaceExport)_service;
                __CustomerInterfaceExport_root_0 __ctx0__ = (__CustomerInterfaceExport_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.ftpTransferRecPort_Export != null)
                {
                    __svc__.ftpTransferRecPort_Export.Close(this, null);
                    __svc__.ftpTransferRecPort_Export = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __CustomerInterfaceExport_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __CustomerInterfaceExport_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "CustomerInterfaceExport")
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
                CustomerInterfaceExport __svc__ = (CustomerInterfaceExport)_service;
                __CustomerInterfaceExport_1 __ctx1__ = (__CustomerInterfaceExport_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__sLifeToken4Xprot = null;
                if (__ctx1__ != null)
                    __ctx1__.__ROCustomerExportLibrary = null;
                if (__ctx1__ != null)
                    __ctx1__.__sMode = null;
                if (__ctx1__ != null)
                    __ctx1__.__ROLogger = null;
                if (__ctx1__ != null)
                    __ctx1__.__sConfigPath = null;
                if (__ctx1__ != null)
                    __ctx1__.__sExchangeProtocolID = null;
                if (__ctx1__ != null)
                    __ctx1__.__sInterfaceName = null;
                if (__ctx1__ != null)
                    __ctx1__.__sLifeToken4Files = null;
                if (__ctx1__ != null)
                    __ctx1__.__sDownloadTargetPath = null;
                if (__ctx1__ != null)
                    __ctx1__.__sStatus = null;
                if (__ctx1__ != null)
                    __ctx1__.__sSystem = null;
                if (__ctx1__ != null && __ctx1__.__msgFTPTransfer != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgFTPTransfer);
                    __ctx1__.__msgFTPTransfer = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgFTPTransfer")]
            public __messagetype_RB_ROCustomerInterfaceExport_Schemas_Transfer_TransferResultInformation __msgFTPTransfer;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sDownloadTargetPath")]
            internal System.String __sDownloadTargetPath;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sInterfaceName")]
            internal System.String __sInterfaceName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sExchangeProtocolID")]
            internal System.String __sExchangeProtocolID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sSystem")]
            internal System.String __sSystem;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sLifeToken4Xprot")]
            internal System.String __sLifeToken4Xprot;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sLifeToken4Files")]
            internal System.String __sLifeToken4Files;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sMode")]
            internal System.String __sMode;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sConfigPath")]
            internal System.String __sConfigPath;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ROLogger")]
            internal RB.ROCustomerInterfaceExportLibrary.Logger __ROLogger;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ROCustomerExportLibrary")]
            internal RB.ROCustomerInterfaceExportLibrary.BTHelper __ROCustomerExportLibrary;
            [Microsoft.XLANGs.Core.UserVariableAttribute("recordsCount")]
            internal System.Int32 __recordsCount;
            [Microsoft.XLANGs.Core.UserVariableAttribute("batchCount")]
            internal System.Int32 __batchCount;
            [Microsoft.XLANGs.Core.UserVariableAttribute("index")]
            internal System.Int32 __index;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sStatus")]
            internal System.String __sStatus;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("ftpTransferRecPort_Export")]
        internal PortType_1 ftpTransferRecPort_Export;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_1.Operation_1},
                                               typeof(CustomerInterfaceExport).GetField("ftpTransferRecPort_Export", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CustomerInterfaceExport), "ftpTransferRecPort_Export"),
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
                    typeof(RB.ROCustomerInterfaceExport.ValidateandExecute)                    
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "a2bf78e8-d9c6-4247-b799-33330ba09706", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "a2bf78e8-d9c6-4247-b799-33330ba09706", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "be1034e9-485f-414e-b4f8-a79cdfbb72d0", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "be1034e9-485f-414e-b4f8-a79cdfbb72d0", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "a0145f68-9eed-4995-aafe-422b7909c2bc", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "a0145f68-9eed-4995-aafe-422b7909c2bc", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "77ac079c-bc6f-49f3-82db-2108c0bde289", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "77ac079c-bc6f-49f3-82db-2108c0bde289", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "63209d35-1dce-47f5-9d97-4ca6f95c8ceb", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "63209d35-1dce-47f5-9d97-4ca6f95c8ceb", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "2c9c5397-547b-44ce-af6d-ab55d38ec9b0", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "00b2eb50-6c93-4b2f-977e-612978b6cc33", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "00b2eb50-6c93-4b2f-977e-612978b6cc33", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "23a60b78-1d59-4017-96a5-3ae4679f5aec", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "23a60b78-1d59-4017-96a5-3ae4679f5aec", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "2c9c5397-547b-44ce-af6d-ab55d38ec9b0", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "7094dc66-aae7-451d-a1d1-5b7a79b9ab57", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "7094dc66-aae7-451d-a1d1-5b7a79b9ab57", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Call),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,4,4,5,6,6,7,7,7,7,7,7,7,7,7,8,8,9,9,9,9,9,10,10,11,11,11,12,12,12,13,13,14,15,15,16,17,17,17,18,18,19,19,19,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __CustomerInterfaceExport_root_0 __ctx0__ = (__CustomerInterfaceExport_root_0)_stateMgrs[0];
            __CustomerInterfaceExport_1 __ctx1__ = (__CustomerInterfaceExport_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                ftpTransferRecPort_Export = new PortType_1(0, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], ftpTransferRecPort_Export, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __CustomerInterfaceExport_1(this);
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
            __CustomerInterfaceExport_root_0 __ctx0__ = (__CustomerInterfaceExport_root_0)_stateMgrs[0];
            __CustomerInterfaceExport_1 __ctx1__ = (__CustomerInterfaceExport_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__sDownloadTargetPath = default(System.String);
                __ctx1__.__sInterfaceName = default(System.String);
                __ctx1__.__sExchangeProtocolID = default(System.String);
                __ctx1__.__sSystem = default(System.String);
                __ctx1__.__sLifeToken4Xprot = default(System.String);
                __ctx1__.__sLifeToken4Files = default(System.String);
                __ctx1__.__sMode = default(System.String);
                __ctx1__.__sConfigPath = default(System.String);
                __ctx1__.__ROLogger = default(RB.ROCustomerInterfaceExportLibrary.Logger);
                __ctx1__.__ROCustomerExportLibrary = default(RB.ROCustomerInterfaceExportLibrary.BTHelper);
                __ctx1__.__recordsCount = default(System.Int32);
                __ctx1__.__batchCount = default(System.Int32);
                __ctx1__.__index = default(System.Int32);
                __ctx1__.__sStatus = default(System.String);
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
                if (!ftpTransferRecPort_Export.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgFTPTransfer != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgFTPTransfer);
                __ctx1__.__msgFTPTransfer = new __messagetype_RB_ROCustomerInterfaceExport_Schemas_Transfer_TransferResultInformation("msgFTPTransfer", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgFTPTransfer);
                ftpTransferRecPort_Export.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgFTPTransfer, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (ftpTransferRecPort_Export != null)
                {
                    ftpTransferRecPort_Export.Close(__ctx1__, __seg__);
                    ftpTransferRecPort_Export = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgFTPTransfer);
                    __edata.PortName = @"ftpTransferRecPort_Export";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__sDownloadTargetPath = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__sInterfaceName = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__sExchangeProtocolID = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__sSystem = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__sLifeToken4Xprot = "";
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__sLifeToken4Files = "";
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__sMode = "";
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__sConfigPath = "";
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __ctx1__.__ROCustomerExportLibrary = new RB.ROCustomerInterfaceExportLibrary.BTHelper();
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.__recordsCount = 0;
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                __ctx1__.__batchCount = 0;
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                __ctx1__.__sStatus = "";
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "Export - Interface run starts");
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "Setting Variables starts");
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                __ctx1__.__sInterfaceName = (System.String)__ctx1__.__msgFTPTransfer.part.GetDistinguishedField("InterfaceName");
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                __ctx1__.__sDownloadTargetPath = (System.String)__ctx1__.__msgFTPTransfer.part.GetDistinguishedField("DownloadTargetPath");
                if (__ctx1__ != null)
                    __ctx1__.__sDownloadTargetPath = null;
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                __ctx1__.__sExchangeProtocolID = (System.String)__ctx1__.__msgFTPTransfer.part.GetDistinguishedField("XProtID");
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                __ctx1__.__sSystem = (System.String)__ctx1__.__msgFTPTransfer.part.GetDistinguishedField("RQ1System");
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                __ctx1__.__sLifeToken4Files = (System.String)__ctx1__.__msgFTPTransfer.part.GetDistinguishedField("LifeToken4Files");
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                __ctx1__.__sLifeToken4Xprot = (System.String)__ctx1__.__msgFTPTransfer.part.GetDistinguishedField("LifeToken4XProt");
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                __ctx1__.__sMode = (System.String)__ctx1__.__msgFTPTransfer.part.GetDistinguishedField("Mode");
                if (__ctx1__ != null)
                    __ctx1__.__sMode = null;
                if (__ctx1__ != null && __ctx1__.__msgFTPTransfer != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgFTPTransfer);
                    __ctx1__.__msgFTPTransfer = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "Interface name =" + __ctx1__.__sInterfaceName);
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                __ctx1__.__sConfigPath = __ctx1__.__ROCustomerExportLibrary.GetConfigPathForLogger(__ctx1__.__sInterfaceName, __ctx1__.__sExchangeProtocolID);
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_EXPORT", "sConfigPath=" + __ctx1__.__sConfigPath);
                if ( !PostProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 35;
            case 35:
                __ctx1__.__ROLogger = new RB.ROCustomerInterfaceExportLibrary.Logger(__ctx1__.__sConfigPath);
                if (__ctx1__ != null)
                    __ctx1__.__sConfigPath = null;
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 36:
                __ctx1__.__ROCustomerExportLibrary.SetLoggingMode(__ctx1__.__sInterfaceName, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 37;
            case 37:
                __ctx1__.__ROLogger.LogInfo("Log set");
                if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 38;
            case 38:
                if ( !PreProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 39;
            case 39:
                __ctx1__.__recordsCount = __ctx1__.__ROCustomerExportLibrary.GetRecordsCount(__ctx1__.__sLifeToken4Files, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 40;
            case 40:
                if ( !PreProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 41;
            case 41:
                __ctx1__.__batchCount = __ctx1__.__ROCustomerExportLibrary.GetBatchCount(__ctx1__.__recordsCount, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 42;
            case 42:
                __ctx1__.__index = 1;
                if ( !PostProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 43;
            case 43:
                if ( !PreProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 44;
            case 44:
                __condition__ = __ctx1__.__index <= __ctx1__.__batchCount;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 54 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 54;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 45;
            case 45:
                if ( !PreProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 46;
            case 46:
                if ( !PreProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 47;
            case 47:
                {
                    Microsoft.XLANGs.Core.Service svc = new RB.ROCustomerInterfaceExport.ValidateandExecute(2, InstanceId, this);
                    _stateMgrs[2] = svc;
                    __ctx1__.StartCall(__seg__, svc, __eventLocations[13],new object[] {__ctx1__.__ROLogger, __ctx1__.__batchCount, __ctx1__.__sLifeToken4Files, __ctx1__.__sExchangeProtocolID, __ctx1__.__ROCustomerExportLibrary, __ctx1__.__sSystem, __ctx1__.__sInterfaceName, __ctx1__.__index});
                }
                if ( !PostProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 48:
                if ( !PreProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    object[] args = ((Microsoft.XLANGs.Core.Service)_stateMgrs[2]).Args;
                    __ctx1__.__sLifeToken4Files = (System.String)args[2];
                }
                Tracker.FireEvent(__eventLocations[14],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 49;
            case 49:
                if ( !PreProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 50;
            case 50:
                __ctx1__.__index = __ctx1__.__index + 1;
                if ( !PostProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 51;
            case 51:
                if ( !PreProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 52;
            case 52:
                if ( !PreProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 53;
            case 53:
                if ( !PostProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 44;
            case 54:
                if ( !PreProgressInc( __seg__, __ctx__, 55 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__ROLogger = null;
                Tracker.FireEvent(__eventLocations[17],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 55;
            case 55:
                if ( !PreProgressInc( __seg__, __ctx__, 56 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 56;
            case 56:
                __ctx1__.__sLifeToken4Xprot = __ctx1__.__ROCustomerExportLibrary.ChangeLifeToken4Xprot(__ctx1__.__sLifeToken4Files, __ctx1__.__sLifeToken4Xprot);
                if ( !PostProgressInc( __seg__, __ctx__, 57 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 57;
            case 57:
                if ( !PreProgressInc( __seg__, __ctx__, 58 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 58;
            case 58:
                __ctx1__.__sStatus = __ctx1__.__ROCustomerExportLibrary.UpdateExchangeProtocol(__ctx1__.__sExchangeProtocolID, __ctx1__.__sSystem, __ctx1__.__sInterfaceName, __ctx1__.__sLifeToken4Files, __ctx1__.__sLifeToken4Xprot);
                if (__ctx1__ != null)
                    __ctx1__.__sStatus = null;
                if (__ctx1__ != null)
                    __ctx1__.__sLifeToken4Files = null;
                if (__ctx1__ != null)
                    __ctx1__.__sLifeToken4Xprot = null;
                if (__ctx1__ != null)
                    __ctx1__.__sSystem = null;
                if (__ctx1__ != null)
                    __ctx1__.__sInterfaceName = null;
                if ( !PostProgressInc( __seg__, __ctx__, 59 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 59;
            case 59:
                __ctx1__.__ROCustomerExportLibrary.DeleteStageLock(__ctx1__.__sExchangeProtocolID);
                if (__ctx1__ != null)
                    __ctx1__.__ROCustomerExportLibrary = null;
                if (__ctx1__ != null)
                    __ctx1__.__sExchangeProtocolID = null;
                if ( !PostProgressInc( __seg__, __ctx__, 60 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 60;
            case 60:
                if ( !PreProgressInc( __seg__, __ctx__, 61 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 61;
            case 61:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 62 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 62;
            case 62:
                if ( !PreProgressInc( __seg__, __ctx__, 63 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 63;
            case 63:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }
    //#line 1051 "D:\ASAM-IF-IMPORT\Import\960 - Sources\SI0VM07516\FFM3FE\BTImportSoftware\ASAM-Export\ASAM-Export\RB.ROCustomerInterfaceExport\Orchestrations\ValidateandExecute.odx"
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(RB.ROCustomerInterfaceExport.Send_RQ1Extract),
            typeof(RB.ROCustomerInterfaceExport.IMF_Before_Validate),
            typeof(RB.ROCustomerInterfaceExport.afterValidate)
        },
        new System.String[] {
            "snd_RQ1Extract",
            "snd_ExportIMF_BeforeValidate",
            "snd_ExportIMF_AfterValidate"
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
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eCallable
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class ValidateandExecute : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        public static void __bodyProxy(
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] RB.ROCustomerInterfaceExportLibrary.Logger ROLogger,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.Int32 batchCount,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] ref System.String LifeToken4Files,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String sXprotID,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] RB.ROCustomerInterfaceExportLibrary.BTHelper ROCustomerExportLibrary,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String sSystem,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.String sInterfaceName,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eVariable, "") ] System.Int32 loopIndex)
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(ValidateandExecute));
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

        protected override bool HasActivation { get { return false; } }

        internal bool IsExeced = false;

        static ValidateandExecute()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 1, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 1, 3),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment4), 1, 1, 4),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment5), 1, 1, 5),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment6), 1, 1, 6)
            };

            _Locks = 0;
            _rootContext = new __ValidateandExecute_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public ValidateandExecute(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "ValidateandExecute", tracker)
        {
            ConstructorHelper();
        }

        public ValidateandExecute(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "ValidateandExecute")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>139d7fce-aaf8-433e-a1c6-946b5be34e86</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>4e9db563-1443-43c6-aca5-b30e9f46477d</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>ROLogger</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>6f50310d-14a2-4e64-8b78-b0b6592c8ab9</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>batchCount</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>707de4f2-c864-4972-b82a-74f3e06ca54a</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>LifeToken4Files</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>c5385aba-cb34-4822-a72f-da9eb598f9dd</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>sXprotID</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>9a947478-109b-4536-9aa7-996153b40122</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>ROCustomerExportLibrary</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>f3c77cea-e641-4870-83ad-25a1d2303fde</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>sSystem</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>92d11d30-a481-4539-8279-7bb84d65c424</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>sInterfaceName</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableDeclarationShape</shapeType>      <ShapeID>c76d25b5-4d88-4955-a955-c82a0390ebbf</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>loopIndex</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>47680ca8-7462-4ce0-806e-b554fa2a313d</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParallelShape</shapeType>      <ShapeID>694c0094-e1be-4247-a834-8533f95d0657</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ParallelActions_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>4015c60b-f47e-492a-8430-90f192230074</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>fb51336c-2f3b-46a9-9035-c182832e597d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Variables_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>aec60798-fe0d-480d-ae1e-bc207b431ef6</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Decide_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>593b51c2-6dee-40e9-a3f0-09966376eac4</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>87116fbe-e79c-40f3-ac85-cdf84cb9bc48</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct_RQ1Extract</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>af580bb1-f3e0-4320-9963-f6e0881cc173</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Decide_8</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>0517544a-616f-434c-addb-64d1d59a993c</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>13f8ef49-e877-4239-85d7-9b867c352588</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_RQ1Extract1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>821e0a49-7957-46dc-9825-2717d6e1a4a3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructIMF1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>b7e55966-b89e-40c5-b999-ecda8deee087</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>a3f5386c-da17-46f4-9767-757e1ac5c08a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>ae1d69af-3cb5-4cd1-aefb-4cefdc377034</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>8e145ef9-da54-483c-ba24-52a612df2d40</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>72e0b467-75dc-4b04-a1a0-df12b8d6741c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>c74e5a0f-0e80-4d56-bdfe-88161e0baa09</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_EXPORT_IMF1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>cbe51c87-290f-4b53-91d8-bddccaae3083</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Validate</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>974ad448-5872-47c4-88d0-4b8172b0b66a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Decide_6</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>74c8c9d1-9158-42a8-8c03-a879124d834a</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Validation check</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>d203ee77-a581-4e14-823c-32f6621c1c87</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructIMF_AfterValidate</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>b42461b4-1329-464c-93b0-9d50b0b5ae55</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_4</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>0b0d6928-92d9-4fbc-900e-186e742f65aa</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>158df1d7-9eec-4258-9249-04237bd327c6</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>ed28a9ac-0967-4f01-af2a-6ea3405e172a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>9426bcf3-94fa-40c0-a0e7-38f77e5f7646</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>2cade61f-6150-4bbe-8747-e41eaf609b4a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>d7e72fc2-cabb-4c6e-a10c-25b20b9ea659</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Create ASAM File</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>bc760d68-2ab9-45bb-b7df-e59e6afce3cf</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>update record</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>1d527d04-43c8-4aad-85ec-006b8ba1209e</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>a59434c1-8b69-492e-ab1d-b19c27d77def</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>8a2a18d8-4c2d-4e4e-9704-6adbc7b8afef</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>cd79de91-a017-4e46-b5d7-d59daff7e109</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>End</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>bd0319db-fcf3-45a8-811a-a6b51f42d20d</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>498d910b-8a5e-4113-9d35-330bb242f2eb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Variables_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>35ceaf59-34ca-43f3-a4ee-87d41ef8195a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Decide_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>5e6a1a58-55a1-4ff5-a237-c8682877e0be</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>0b1ef171-a35a-4e6f-abd9-6ebbdf01c2c7</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct_RQ1Extract</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>d93742be-eb91-4ecd-8872-9d26601b04c9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Decide_9</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>556dee00-7afb-4fcf-b88e-8037fe7ccfe7</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>8850b447-9320-458f-9e76-91a840d09707</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_RQ1Extract2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>1280fa01-2d2a-4165-bd63-9bbc51b465bd</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructIMF2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>bf16572f-894c-4543-a1da-624eef9e3d1e</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>ea383468-e612-4ba6-906e-c5def96eac8e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>d72c818d-4df6-4768-8101-cc6f92664502</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>7167af51-18a0-43d7-be09-e332d783f437</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>866ac327-84a0-46f0-8e58-e4843aa1a63b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>3eb4d947-97c5-44fc-972e-ee07a6153227</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_EXPORT_IMF2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>32a4c10c-4263-461f-82de-1b90c5fb5e29</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Validate</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>36cc7485-ffc4-4319-b1a4-c5720a46e48d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Decide_7</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>4ffc212f-a481-4d9a-8655-2b2316360110</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Validation check</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>78a683fc-393c-4bde-a44c-f209f8866901</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructIMF_AfterValidate</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>f6c28b8c-b5ca-4a10-8b8a-ddc2cd54e8e3</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>3cacfc99-7da1-44c7-927e-fd656cfcc53f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_3</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>7cf0da74-6f12-4430-86db-58589bf156b9</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_5</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>ab74e1c0-a898-47d2-8224-76e73d7440f9</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_6</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>114afe87-8b2e-4059-9475-2a5211fe0c11</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>13acd33e-ace7-4056-8d54-cab905b61abb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_EXPORT_IMF2_AV</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>8c0d2d9f-eebe-4a97-aea5-0a5df1808de4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Create ASAM File2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>e8ee222c-0ebd-4801-b5aa-919a4e38d8cb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>update record</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>75387507-ea92-49e6-abe9-337796a9b2b6</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>380ddf6f-b825-4357-aa27-a327c9828079</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>106f5599-6fff-4ddc-8f8f-07eb08149ce2</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>b791477a-a87c-4a8a-a68b-ff8a2f2c7fcf</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>End</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>77affe73-22a1-4da7-aa1b-02cbc935e876</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_3</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>a3e38ea1-d044-4de6-b439-46f7e7cbd28c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Variables_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>a11bcd5f-4e16-49b6-9321-dcd982bf882c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Decide_3</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>b9c64240-9a46-4ef0-898e-fc95d23745eb</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>d16cf294-8682-471d-839c-e04c744fbe5c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>c8cd9814-7159-4a5e-86b1-65ea4ba9478e</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>7888364f-4b6b-4aee-9d65-68c3af350f6a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>End</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>de6c4119-47a5-4110-a876-f7d535b79d74</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_4</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>d09f8ae6-50b2-4fff-a8e2-c7377a8e9376</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Variables_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>78115a98-3cf9-4c3e-ac1c-08a8732b9464</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Decide_4</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>cfd325b6-ae1e-417d-9222-6cde86d00d69</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>2afbebf1-b2f2-4710-99f4-4ebc222ebfd3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_5</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>67001391-f74f-492b-aa59-3fe5be2fb0c5</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>ead2d9a5-c743-4e6d-8192-83ff05c43262</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>End</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>857a6d32-9084-416c-847b-324ff6f4528b</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_5</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>f9f59832-efd4-4cb7-bf7b-e3ba23b77fb8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Set Variables_5</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>77310f3f-639a-4326-98e9-b39359380b1e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Decide_5</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>1532230e-4bf0-455f-9f57-f224c540bd9c</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>835f8744-5596-4990-9607-fd0b401c0fd1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_6</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>83f822a7-1edc-4584-9c2e-3342e96df8a0</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>05030e42-cc1c-42e0-add6-aeb61fdead4a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>End</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>631cf19c-6de5-4d49-8aa1-e33407ac5896</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Update LifeTokens</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'ValidateandExecute'</ActionName><IsAtomic>0</IsAtomic><Line>1051</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1123</Line><Position>51</Position><ShapeID>'47680ca8-7462-4ce0-806e-b554fa2a313d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1135</Line><Position>13</Position><ShapeID>'694c0094-e1be-4247-a834-8533f95d0657'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1140</Line><Position>35</Position><ShapeID>'fb51336c-2f3b-46a9-9035-c182832e597d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1150</Line><Position>21</Position><ShapeID>'aec60798-fe0d-480d-ae1e-bc207b431ef6'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1154</Line><Position>25</Position><ShapeID>'87116fbe-e79c-40f3-ac85-cdf84cb9bc48'</ShapeID>
<Messages>
	<MsgInfo><name>RQ1Extract1</name><part>part</part><schema>RB.ROCustomerInterfaceExport.Schemas.RO_Extract.RQ1Extract</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1171</Line><Position>25</Position><ShapeID>'af580bb1-f3e0-4320-9963-f6e0881cc173'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1174</Line><Position>29</Position><ShapeID>'13f8ef49-e877-4239-85d7-9b867c352588'</ShapeID>
<Messages>
	<MsgInfo><name>RQ1Extract1</name><part>part</part><schema>RB.ROCustomerInterfaceExport.Schemas.RO_Extract.RQ1Extract</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1176</Line><Position>29</Position><ShapeID>'821e0a49-7957-46dc-9825-2717d6e1a4a3'</ShapeID>
<Messages>
	<MsgInfo><name>EXPORT_IMF1</name><part>part</part><schema>RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>RQ1Extract1</name><part>part</part><schema>RB.ROCustomerInterfaceExport.Schemas.RO_Extract.RQ1Extract</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1186</Line><Position>29</Position><ShapeID>'c74e5a0f-0e80-4d56-bdfe-88161e0baa09'</ShapeID>
<Messages>
	<MsgInfo><name>EXPORT_IMF1</name><part>part</part><schema>RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1188</Line><Position>67</Position><ShapeID>'cbe51c87-290f-4b53-91d8-bddccaae3083'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1192</Line><Position>29</Position><ShapeID>'974ad448-5872-47c4-88d0-4b8172b0b66a'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1195</Line><Position>33</Position><ShapeID>'d203ee77-a581-4e14-823c-32f6621c1c87'</ShapeID>
<Messages>
	<MsgInfo><name>EXPORT_IMF1</name><part>part</part><schema>RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>RQ1Extract1</name><part>part</part><schema>RB.ROCustomerInterfaceExport.Schemas.RO_Extract.RQ1Extract</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1211</Line><Position>33</Position><ShapeID>'2cade61f-6150-4bbe-8747-e41eaf609b4a'</ShapeID>
<Messages>
	<MsgInfo><name>EXPORT_IMF1</name><part>part</part><schema>RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1213</Line><Position>71</Position><ShapeID>'d7e72fc2-cabb-4c6e-a10c-25b20b9ea659'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1218</Line><Position>33</Position><ShapeID>'bc760d68-2ab9-45bb-b7df-e59e6afce3cf'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1237</Line><Position>63</Position><ShapeID>'cd79de91-a017-4e46-b5d7-d59daff7e109'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1247</Line><Position>35</Position><ShapeID>'498d910b-8a5e-4113-9d35-330bb242f2eb'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1257</Line><Position>21</Position><ShapeID>'35ceaf59-34ca-43f3-a4ee-87d41ef8195a'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1261</Line><Position>25</Position><ShapeID>'0b1ef171-a35a-4e6f-abd9-6ebbdf01c2c7'</ShapeID>
<Messages>
	<MsgInfo><name>RQ1Extract2</name><part>part</part><schema>RB.ROCustomerInterfaceExport.Schemas.RO_Extract.RQ1Extract</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1277</Line><Position>25</Position><ShapeID>'d93742be-eb91-4ecd-8872-9d26601b04c9'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1280</Line><Position>29</Position><ShapeID>'8850b447-9320-458f-9e76-91a840d09707'</ShapeID>
<Messages>
	<MsgInfo><name>RQ1Extract2</name><part>part</part><schema>RB.ROCustomerInterfaceExport.Schemas.RO_Extract.RQ1Extract</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1282</Line><Position>29</Position><ShapeID>'1280fa01-2d2a-4165-bd63-9bbc51b465bd'</ShapeID>
<Messages>
	<MsgInfo><name>EXPORT_IMF2</name><part>part</part><schema>RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>RQ1Extract2</name><part>part</part><schema>RB.ROCustomerInterfaceExport.Schemas.RO_Extract.RQ1Extract</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1292</Line><Position>29</Position><ShapeID>'3eb4d947-97c5-44fc-972e-ee07a6153227'</ShapeID>
<Messages>
	<MsgInfo><name>EXPORT_IMF2</name><part>part</part><schema>RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1294</Line><Position>67</Position><ShapeID>'32a4c10c-4263-461f-82de-1b90c5fb5e29'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1298</Line><Position>29</Position><ShapeID>'36cc7485-ffc4-4319-b1a4-c5720a46e48d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1301</Line><Position>33</Position><ShapeID>'78a683fc-393c-4bde-a44c-f209f8866901'</ShapeID>
<Messages>
	<MsgInfo><name>EXPORT_IMF2</name><part>part</part><schema>RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>RQ1Extract2</name><part>part</part><schema>RB.ROCustomerInterfaceExport.Schemas.RO_Extract.RQ1Extract</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1317</Line><Position>33</Position><ShapeID>'13acd33e-ace7-4056-8d54-cab905b61abb'</ShapeID>
<Messages>
	<MsgInfo><name>EXPORT_IMF2</name><part>part</part><schema>RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1319</Line><Position>71</Position><ShapeID>'8c0d2d9f-eebe-4a97-aea5-0a5df1808de4'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1323</Line><Position>33</Position><ShapeID>'e8ee222c-0ebd-4801-b5aa-919a4e38d8cb'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1340</Line><Position>63</Position><ShapeID>'b791477a-a87c-4a8a-a68b-ff8a2f2c7fcf'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1350</Line><Position>35</Position><ShapeID>'a3e38ea1-d044-4de6-b439-46f7e7cbd28c'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1358</Line><Position>21</Position><ShapeID>'a11bcd5f-4e16-49b6-9321-dcd982bf882c'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1361</Line><Position>63</Position><ShapeID>'d16cf294-8682-471d-839c-e04c744fbe5c'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1366</Line><Position>63</Position><ShapeID>'7888364f-4b6b-4aee-9d65-68c3af350f6a'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1372</Line><Position>35</Position><ShapeID>'d09f8ae6-50b2-4fff-a8e2-c7377a8e9376'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1380</Line><Position>21</Position><ShapeID>'78115a98-3cf9-4c3e-ac1c-08a8732b9464'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1383</Line><Position>63</Position><ShapeID>'2afbebf1-b2f2-4710-99f4-4ebc222ebfd3'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1388</Line><Position>63</Position><ShapeID>'ead2d9a5-c743-4e6d-8192-83ff05c43262'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1394</Line><Position>35</Position><ShapeID>'f9f59832-efd4-4cb7-bf7b-e3ba23b77fb8'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1402</Line><Position>21</Position><ShapeID>'77310f3f-639a-4326-98e9-b39359380b1e'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1405</Line><Position>63</Position><ShapeID>'835f8744-5596-4990-9607-fd0b401c0fd1'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1410</Line><Position>63</Position><ShapeID>'05030e42-cc1c-42e0-add6-aeb61fdead4a'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>1415</Line><Position>29</Position><ShapeID>'631cf19c-6de5-4d49-8aa1-e33407ac5896'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='12ab6a39-3a16-4c9c-9b5a-a23095d59ecb' LowerBound='1.1' HigherBound='401.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='RB.ROCustomerInterfaceExport' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='b7d42f5e-798f-4152-90b4-4a2fdf233e06' ParentLink='Module_ServiceDeclaration' LowerBound='32.1' HigherBound='400.1'>
            <om:Property Name='InitializedTransactionType' Value='True' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ValidateandExecute' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='e7ed9b88-5754-495f-98dd-5a5477793b6a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='45.1' HigherBound='46.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sRecordNamesOfBatch' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='a8bdafa8-080c-4226-989b-aa6007a093c7' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='46.1' HigherBound='47.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='record_1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8ea2f399-66f7-48e1-8db3-7270ffaa4b7d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='47.1' HigherBound='48.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='record_2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='a442afc3-17dd-40db-893e-23939ba84557' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='48.1' HigherBound='49.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='record_3' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='c1e938dc-8499-417c-a36a-1bac8961fd91' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='49.1' HigherBound='50.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='record_4' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='e1980afd-1174-455a-a811-a3a937b79bf5' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='50.1' HigherBound='51.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='record_5' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='2086fb86-6219-4b78-853e-f1b0163d7c26' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='51.1' HigherBound='52.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sConfigPath' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7a9e0e8b-d3e4-4e89-a673-b92f56a49e8d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='52.1' HigherBound='53.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExportLibrary.AsyncLogger' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='async_logger1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='49d7b42b-ac9d-47e8-900d-669d959eca6e' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='53.1' HigherBound='54.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExportLibrary.AsyncLogger' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='async_logger2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='d55e3f19-294b-4d46-af5a-4404fd7ef249' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='54.1' HigherBound='55.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExportLibrary.AsyncLogger' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='async_logger3' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='fe7085b3-9fab-4e92-9e36-b8a200ba4d39' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='55.1' HigherBound='56.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExportLibrary.AsyncLogger' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='async_logger4' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='bd84760f-4825-4671-bdcb-f562aa6d11e5' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='56.1' HigherBound='57.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExportLibrary.AsyncLogger' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='async_logger5' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='2ca0c831-b044-4c97-9026-b71e063ec8b8' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='57.1' HigherBound='58.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExportLibrary.BTHelper' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='objBTHelper_1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='685023a7-7d49-4170-97f9-e7893e99be24' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='58.1' HigherBound='59.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExportLibrary.BTHelper' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='objBTHelper_2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='9577827f-11c4-4d3b-b409-c6ecde04048a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='59.1' HigherBound='60.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExportLibrary.BTHelper' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='objBTHelper_3' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='135951be-aeff-4da4-8724-dd15a89b7de4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='60.1' HigherBound='61.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExportLibrary.BTHelper' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='objBTHelper_4' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='a54be348-9b1a-416c-a977-9083881fbda2' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='61.1' HigherBound='62.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExportLibrary.BTHelper' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='objBTHelper_5' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='b694b4ce-b63f-44b3-82c6-bc6b423369d4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='62.1' HigherBound='63.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sRecord_id1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='52e85ad4-50ae-431b-9805-922aa6d660f8' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='63.1' HigherBound='64.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='is_validate' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7261eacb-708f-4e78-a5ae-b6b415da2fa3' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='64.1' HigherBound='65.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='isUpdated' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8d8b1dd6-0efe-46ad-a6e3-09d384861b21' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='65.1' HigherBound='66.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='asam_file' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='6f1c0b4f-3192-4d6d-8ef9-d756f78acd19' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='66.1' HigherBound='67.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='LifeTokenofFile1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='27c3e7bc-53b4-42db-b252-57180b5ea254' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='67.1' HigherBound='68.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sRecord_id2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='d25778c2-5c78-4e99-a1f9-cfadba270d2d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='68.1' HigherBound='69.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='LifeTokenofFile2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='0cedcc15-c157-4a99-986c-603fbc707b0b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='69.1' HigherBound='70.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='is_validate2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='c9728d24-d01f-400b-b1ac-cc02fadad181' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='70.1' HigherBound='71.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='isUpdated_2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='39d5060f-af48-48f4-8816-c5c0ed871228' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='71.1' HigherBound='72.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='asam_file2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3ae679b2-278c-4b64-8870-1c35f5df3fec' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='72.1' HigherBound='73.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExportLibrary.LifeTokenManager' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='manager' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='1da49645-6f7e-4782-8a32-bb3d2acc83ba' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='73.1' HigherBound='74.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='isException1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7e9ff5e1-bf7e-47f0-96bf-6fb923bbcfbf' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='74.1' HigherBound='75.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='verifyLock_2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='2c7531a9-a5a7-4acb-ab61-66f0907994f4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='75.1' HigherBound='76.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='verifyLock_1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='410c2f5c-7d68-41a6-91e5-bc891f4d0e1f' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='41.1' HigherBound='42.1'>
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EXPORT_IMF2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='6b1eafa0-961a-44e2-9c67-5183d84f6710' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='42.1' HigherBound='43.1'>
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExport.Schemas.RO_Extract.RQ1Extract' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RQ1Extract2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='603e8028-7771-48fa-a0ad-9cb4279c59a6' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='43.1' HigherBound='44.1'>
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExport.Schemas.RO_Extract.RQ1Extract' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RQ1Extract1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='72797549-dc2a-4f8e-94d9-c5416c676bd5' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='44.1' HigherBound='45.1'>
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EXPORT_IMF1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='139d7fce-aaf8-433e-a1c6-946b5be34e86' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='VariableDeclaration' OID='4e9db563-1443-43c6-aca5-b30e9f46477d' ParentLink='ServiceBody_Declaration' LowerBound='76.15' HigherBound='76.66'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='RB.ROCustomerInterfaceExportLibrary.Logger' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ROLogger' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='6f50310d-14a2-4e64-8b78-b0b6592c8ab9' ParentLink='ServiceBody_Declaration' LowerBound='76.68' HigherBound='76.91'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.Int32' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='batchCount' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='707de4f2-c864-4972-b82a-74f3e06ca54a' ParentLink='ServiceBody_Declaration' LowerBound='76.93' HigherBound='76.126'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='Ref' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='LifeToken4Files' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='c5385aba-cb34-4822-a72f-da9eb598f9dd' ParentLink='ServiceBody_Declaration' LowerBound='76.128' HigherBound='76.150'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='sXprotID' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='9a947478-109b-4536-9aa7-996153b40122' ParentLink='ServiceBody_Declaration' LowerBound='76.152' HigherBound='76.220'>
                    <om:Property Name='UseDefaultConstructor' Value='True' />
                    <om:Property Name='Type' Value='RB.ROCustomerInterfaceExportLibrary.BTHelper' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ROCustomerExportLibrary' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='f3c77cea-e641-4870-83ad-25a1d2303fde' ParentLink='ServiceBody_Declaration' LowerBound='76.222' HigherBound='76.243'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='sSystem' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='92d11d30-a481-4539-8279-7bb84d65c424' ParentLink='ServiceBody_Declaration' LowerBound='76.245' HigherBound='76.273'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='sInterfaceName' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableDeclaration' OID='c76d25b5-4d88-4955-a955-c82a0390ebbf' ParentLink='ServiceBody_Declaration' LowerBound='76.275' HigherBound='76.297'>
                    <om:Property Name='UseDefaultConstructor' Value='False' />
                    <om:Property Name='Type' Value='System.Int32' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='loopIndex' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='47680ca8-7462-4ce0-806e-b554fa2a313d' ParentLink='ServiceBody_Statement' LowerBound='104.1' HigherBound='116.1'>
                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;Validate and Execute Orchestration Starts : &quot; );&#xD;&#xA;&#xD;&#xA;sRecordNamesOfBatch = ROCustomerExportLibrary.GetRecordNamesFromBatch(LifeToken4Files, loopIndex, ROLogger);&#xD;&#xA;&#xD;&#xA;manager =  new RB.ROCustomerInterfaceExportLibrary.LifeTokenManager();&#xD;&#xA;manager.Initialize(LifeToken4Files);&#xD;&#xA;&#xD;&#xA;//creating an instance for AsyncLogger&#xD;&#xA;sConfigPath = ROCustomerExportLibrary.GetConfigPathForFolderCreation(sInterfaceName,sXprotID);&#xD;&#xA;&#xD;&#xA;&#xA;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Expression_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Parallel' OID='694c0094-e1be-4247-a834-8533f95d0657' ParentLink='ServiceBody_Statement' LowerBound='116.1' HigherBound='396.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ParallelActions_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='ParallelBranch' OID='4015c60b-f47e-492a-8430-90f192230074' ParentLink='ReallyComplexStatement_Branch' LowerBound='121.1' HigherBound='225.1'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ParallelBranch_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='VariableAssignment' OID='fb51336c-2f3b-46a9-9035-c182832e597d' ParentLink='ComplexStatement_Statement' LowerBound='121.1' HigherBound='131.1'>
                            <om:Property Name='Expression' Value='async_logger1 = new RB.ROCustomerInterfaceExportLibrary.AsyncLogger(sConfigPath, sXprotID);&#xD;&#xA;&#xD;&#xA;record_1 = objBTHelper_1.GetEachRecordFromBatch(sRecordNamesOfBatch, 1);&#xD;&#xA;&#xD;&#xA;record_1 = objBTHelper_1.GetRecordID(record_1);&#xD;&#xA;&#xD;&#xA;async_logger1.LogInfoAsync(record_1, &quot;Log Set&quot;);&#xD;&#xA;&#xD;&#xA;verifyLock_1 = objBTHelper_1.VerifyStageLock(record_1, sXprotID);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Set Variables_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Decision' OID='aec60798-fe0d-480d-ae1e-bc207b431ef6' ParentLink='ComplexStatement_Statement' LowerBound='131.1' HigherBound='225.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Decide_1' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='DecisionBranch' OID='593b51c2-6dee-40e9-a3f0-09966376eac4' ParentLink='ReallyComplexStatement_Branch' LowerBound='132.21' HigherBound='216.1'>
                                <om:Property Name='Expression' Value='record_1 != System.String.Empty &amp;&amp; verifyLock_1 == true' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Rule_1' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='VariableAssignment' OID='87116fbe-e79c-40f3-ac85-cdf84cb9bc48' ParentLink='ComplexStatement_Statement' LowerBound='134.1' HigherBound='152.1'>
                                    <om:Property Name='Expression' Value='&#xD;&#xA;construct RQ1Extract1&#xD;&#xA; {&#xD;&#xA;    System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;Processing the records : &quot; + record_1);&#xD;&#xA;&#xD;&#xA;    RQ1Extract1 = objBTHelper_1.CreateRQ1DataExtractFile(record_1, sXprotID, sSystem, sInterfaceName, async_logger1, manager);&#xD;&#xA;&#xD;&#xA;    RQ1Extract1 = objBTHelper_1.PrettyXml(RQ1Extract1, record_1, async_logger1, manager);&#xD;&#xA;&#xD;&#xA;    sRecord_id1 = record_1.Substring(0, record_1.IndexOf(&quot;:&quot;));&#xD;&#xA;    RQ1Extract1(FILE.ReceivedFileName) = sSystem + &quot;_&quot; + sXprotID +&quot;_030_&quot; + sRecord_id1 +&quot;_RQ1_Extract&quot;; &#xD;&#xA;&#xD;&#xA;    System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;RQ1 Extract File Created = &quot; + RQ1Extract1(FILE.ReceivedFileName));&#xD;&#xA;  &#xD;&#xA; }&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Construct_RQ1Extract' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Decision' OID='af580bb1-f3e0-4320-9963-f6e0881cc173' ParentLink='ComplexStatement_Statement' LowerBound='152.1' HigherBound='215.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Decide_8' />
                                    <om:Property Name='Signal' Value='False' />
                                    <om:Element Type='DecisionBranch' OID='0517544a-616f-434c-addb-64d1d59a993c' ParentLink='ReallyComplexStatement_Branch' LowerBound='153.25' HigherBound='215.1'>
                                        <om:Property Name='Expression' Value='!objBTHelper_1.VerifyTokenOfRecord(sRecord_id1,manager)' />
                                        <om:Property Name='IsGhostBranch' Value='True' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Rule_1' />
                                        <om:Property Name='Signal' Value='False' />
                                        <om:Element Type='Send' OID='13f8ef49-e877-4239-85d7-9b867c352588' ParentLink='ComplexStatement_Statement' LowerBound='155.1' HigherBound='157.1'>
                                            <om:Property Name='PortName' Value='snd_RQ1Extract' />
                                            <om:Property Name='MessageName' Value='RQ1Extract1' />
                                            <om:Property Name='OperationName' Value='Operation_1' />
                                            <om:Property Name='OperationMessageName' Value='Request' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Send_RQ1Extract1' />
                                            <om:Property Name='Signal' Value='True' />
                                        </om:Element>
                                        <om:Element Type='Construct' OID='821e0a49-7957-46dc-9825-2717d6e1a4a3' ParentLink='ComplexStatement_Statement' LowerBound='157.1' HigherBound='167.1'>
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='ConstructIMF1' />
                                            <om:Property Name='Signal' Value='True' />
                                            <om:Element Type='MessageRef' OID='b7e55966-b89e-40c5-b999-ecda8deee087' ParentLink='Construct_MessageRef' LowerBound='158.39' HigherBound='158.50'>
                                                <om:Property Name='Ref' Value='EXPORT_IMF1' />
                                                <om:Property Name='ReportToAnalyst' Value='True' />
                                                <om:Property Name='Signal' Value='False' />
                                            </om:Element>
                                            <om:Element Type='Transform' OID='a3f5386c-da17-46f4-9767-757e1ac5c08a' ParentLink='ComplexStatement_Statement' LowerBound='160.1' HigherBound='162.1'>
                                                <om:Property Name='ClassName' Value='RB.ROCustomerInterfaceExport.CreateIMF' />
                                                <om:Property Name='ReportToAnalyst' Value='True' />
                                                <om:Property Name='Name' Value='Transform_1' />
                                                <om:Property Name='Signal' Value='True' />
                                                <om:Element Type='MessagePartRef' OID='ae1d69af-3cb5-4cd1-aefb-4cefdc377034' ParentLink='Transform_OutputMessagePartRef' LowerBound='161.44' HigherBound='161.55'>
                                                    <om:Property Name='MessageRef' Value='EXPORT_IMF1' />
                                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                                    <om:Property Name='Name' Value='MessagePartReference_2' />
                                                    <om:Property Name='Signal' Value='False' />
                                                </om:Element>
                                                <om:Element Type='MessagePartRef' OID='8e145ef9-da54-483c-ba24-52a612df2d40' ParentLink='Transform_InputMessagePartRef' LowerBound='161.99' HigherBound='161.110'>
                                                    <om:Property Name='MessageRef' Value='RQ1Extract1' />
                                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                                    <om:Property Name='Name' Value='MessagePartReference_1' />
                                                    <om:Property Name='Signal' Value='False' />
                                                </om:Element>
                                            </om:Element>
                                            <om:Element Type='MessageAssignment' OID='72e0b467-75dc-4b04-a1a0-df12b8d6741c' ParentLink='ComplexStatement_Statement' LowerBound='162.1' HigherBound='166.1'>
                                                <om:Property Name='Expression' Value='EXPORT_IMF1(FILE.ReceivedFileName) = sSystem + &quot;_&quot; + sXprotID +&quot;_030_&quot; + sRecord_id1 +&quot;IMF_Before_Validate&quot;; &#xD;&#xA;&#xD;&#xA;EXPORT_IMF1 = objBTHelper_1.PrettyXml(EXPORT_IMF1, record_1, async_logger1, manager);' />
                                                <om:Property Name='ReportToAnalyst' Value='False' />
                                                <om:Property Name='Name' Value='MessageAssignment_1' />
                                                <om:Property Name='Signal' Value='False' />
                                            </om:Element>
                                        </om:Element>
                                        <om:Element Type='Send' OID='c74e5a0f-0e80-4d56-bdfe-88161e0baa09' ParentLink='ComplexStatement_Statement' LowerBound='167.1' HigherBound='169.1'>
                                            <om:Property Name='PortName' Value='snd_ExportIMF_BeforeValidate' />
                                            <om:Property Name='MessageName' Value='EXPORT_IMF1' />
                                            <om:Property Name='OperationName' Value='Operation_1' />
                                            <om:Property Name='OperationMessageName' Value='Request' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Send_EXPORT_IMF1' />
                                            <om:Property Name='Signal' Value='True' />
                                        </om:Element>
                                        <om:Element Type='VariableAssignment' OID='cbe51c87-290f-4b53-91d8-bddccaae3083' ParentLink='ComplexStatement_Statement' LowerBound='169.1' HigherBound='173.1'>
                                            <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;Validation started for &quot; + record_1);&#xD;&#xA;is_validate = objBTHelper_1.ValidateRQ1ExtractFile( RQ1Extract1, record_1, async_logger1, manager);&#xD;&#xA; ' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Validate' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='Decision' OID='974ad448-5872-47c4-88d0-4b8172b0b66a' ParentLink='ComplexStatement_Statement' LowerBound='173.1' HigherBound='214.1'>
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Decide_6' />
                                            <om:Property Name='Signal' Value='False' />
                                            <om:Element Type='DecisionBranch' OID='74c8c9d1-9158-42a8-8c03-a879124d834a' ParentLink='ReallyComplexStatement_Branch' LowerBound='174.29' HigherBound='214.1'>
                                                <om:Property Name='Expression' Value='is_validate == true' />
                                                <om:Property Name='IsGhostBranch' Value='True' />
                                                <om:Property Name='ReportToAnalyst' Value='True' />
                                                <om:Property Name='Name' Value='Validation check' />
                                                <om:Property Name='Signal' Value='False' />
                                                <om:Element Type='Construct' OID='d203ee77-a581-4e14-823c-32f6621c1c87' ParentLink='ComplexStatement_Statement' LowerBound='176.1' HigherBound='192.1'>
                                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                                    <om:Property Name='Name' Value='ConstructIMF_AfterValidate' />
                                                    <om:Property Name='Signal' Value='True' />
                                                    <om:Element Type='Transform' OID='b42461b4-1329-464c-93b0-9d50b0b5ae55' ParentLink='ComplexStatement_Statement' LowerBound='179.1' HigherBound='181.1'>
                                                        <om:Property Name='ClassName' Value='RB.ROCustomerInterfaceExport.CreateIMF' />
                                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                                        <om:Property Name='Name' Value='Transform_4' />
                                                        <om:Property Name='Signal' Value='True' />
                                                        <om:Element Type='MessagePartRef' OID='0b0d6928-92d9-4fbc-900e-186e742f65aa' ParentLink='Transform_OutputMessagePartRef' LowerBound='180.48' HigherBound='180.59'>
                                                            <om:Property Name='MessageRef' Value='EXPORT_IMF1' />
                                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                                            <om:Property Name='Name' Value='MessagePartReference_2' />
                                                            <om:Property Name='Signal' Value='False' />
                                                        </om:Element>
                                                        <om:Element Type='MessagePartRef' OID='158df1d7-9eec-4258-9249-04237bd327c6' ParentLink='Transform_InputMessagePartRef' LowerBound='180.103' HigherBound='180.114'>
                                                            <om:Property Name='MessageRef' Value='RQ1Extract1' />
                                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                                            <om:Property Name='Name' Value='MessagePartReference_1' />
                                                            <om:Property Name='Signal' Value='False' />
                                                        </om:Element>
                                                    </om:Element>
                                                    <om:Element Type='MessageAssignment' OID='ed28a9ac-0967-4f01-af2a-6ea3405e172a' ParentLink='ComplexStatement_Statement' LowerBound='181.1' HigherBound='191.1'>
                                                        <om:Property Name='Expression' Value='EXPORT_IMF1 = objBTHelper_1.PrettyXml(EXPORT_IMF1, record_1, async_logger1, manager);&#xD;&#xA;&#xD;&#xA;EXPORT_IMF1 = objBTHelper_1.UpdateIMFAfterValidation(RQ1Extract1, EXPORT_IMF1, record_1 , sXprotID, manager);&#xD;&#xA;&#xD;&#xA;EXPORT_IMF1(FILE.ReceivedFileName) = sSystem + &quot;_&quot; + sXprotID +&quot;_030_&quot; + sRecord_id1 +&quot;IMF_After_Validate&quot;; &#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;Validation Success for &quot; + record_1);&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;After Validate File Created = &quot; + EXPORT_IMF1(FILE.ReceivedFileName));' />
                                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                                        <om:Property Name='Name' Value='MessageAssignment_1' />
                                                        <om:Property Name='Signal' Value='False' />
                                                    </om:Element>
                                                    <om:Element Type='MessageRef' OID='9426bcf3-94fa-40c0-a0e7-38f77e5f7646' ParentLink='Construct_MessageRef' LowerBound='177.43' HigherBound='177.54'>
                                                        <om:Property Name='Ref' Value='EXPORT_IMF1' />
                                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                                        <om:Property Name='Signal' Value='False' />
                                                    </om:Element>
                                                </om:Element>
                                                <om:Element Type='Send' OID='2cade61f-6150-4bbe-8747-e41eaf609b4a' ParentLink='ComplexStatement_Statement' LowerBound='192.1' HigherBound='194.1'>
                                                    <om:Property Name='PortName' Value='snd_ExportIMF_AfterValidate' />
                                                    <om:Property Name='MessageName' Value='EXPORT_IMF1' />
                                                    <om:Property Name='OperationName' Value='Operation_1' />
                                                    <om:Property Name='OperationMessageName' Value='Request' />
                                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                                    <om:Property Name='Name' Value='Send_3' />
                                                    <om:Property Name='Signal' Value='True' />
                                                </om:Element>
                                                <om:Element Type='VariableAssignment' OID='d7e72fc2-cabb-4c6e-a10c-25b20b9ea659' ParentLink='ComplexStatement_Statement' LowerBound='194.1' HigherBound='198.1'>
                                                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;, &quot;Creating ASAM File&quot;);&#xD;&#xA;asam_file = objBTHelper_1.CreateASAMFile(RQ1Extract1,record_1,sXprotID, sSystem,sInterfaceName,async_logger1, manager);&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;, &quot;ASAM File Generated = &quot; + asam_file);' />
                                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                                    <om:Property Name='Name' Value='Create ASAM File' />
                                                    <om:Property Name='Signal' Value='False' />
                                                </om:Element>
                                                <om:Element Type='VariableAssignment' OID='bc760d68-2ab9-45bb-b7df-e59e6afce3cf' ParentLink='ComplexStatement_Statement' LowerBound='198.1' HigherBound='213.1'>
                                                    <om:Property Name='Expression' Value='&#xD;&#xA;if(asam_file != &quot;&quot; &amp;&amp; asam_file != null){&#xD;&#xA;    isUpdated = objBTHelper_1.UpdateRecords(EXPORT_IMF1, record_1, sXprotID, sSystem,sInterfaceName, async_logger1, manager);&#xD;&#xA;&#xD;&#xA;    if(isUpdated){&#xD;&#xA;        System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;, record_1 + &quot; Update Successful&quot;);&#xD;&#xA;    }&#xD;&#xA;&#xD;&#xA;    else{&#xD;&#xA;    System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;, record_1 + &quot; Update Failure&quot;);&#xD;&#xA;    }&#xD;&#xA;}&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                                    <om:Property Name='Name' Value='update record' />
                                                    <om:Property Name='Signal' Value='False' />
                                                </om:Element>
                                            </om:Element>
                                            <om:Element Type='DecisionBranch' OID='1d527d04-43c8-4aad-85ec-006b8ba1209e' ParentLink='ReallyComplexStatement_Branch'>
                                                <om:Property Name='IsGhostBranch' Value='True' />
                                                <om:Property Name='ReportToAnalyst' Value='True' />
                                                <om:Property Name='Name' Value='Else' />
                                                <om:Property Name='Signal' Value='False' />
                                            </om:Element>
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='DecisionBranch' OID='a59434c1-8b69-492e-ab1d-b19c27d77def' ParentLink='ReallyComplexStatement_Branch'>
                                        <om:Property Name='IsGhostBranch' Value='True' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Else' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='8a2a18d8-4c2d-4e4e-9704-6adbc7b8afef' ParentLink='ReallyComplexStatement_Branch'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Else' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='VariableAssignment' OID='cd79de91-a017-4e46-b5d7-d59daff7e109' ParentLink='ComplexStatement_Statement' LowerBound='218.1' HigherBound='224.1'>
                                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;Process Ends : &quot; + record_1);&#xD;&#xA;if(verifyLock_1 == false)&#xD;&#xA;{&#xD;&#xA;   objBTHelper_1.UpdateTokenManager(record_1, sXprotID, manager);&#xD;&#xA;}' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='End' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='ParallelBranch' OID='bd0319db-fcf3-45a8-811a-a6b51f42d20d' ParentLink='ReallyComplexStatement_Branch' LowerBound='228.1' HigherBound='328.1'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ParallelBranch_2' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='VariableAssignment' OID='498d910b-8a5e-4113-9d35-330bb242f2eb' ParentLink='ComplexStatement_Statement' LowerBound='228.1' HigherBound='238.1'>
                            <om:Property Name='Expression' Value='async_logger2 = new RB.ROCustomerInterfaceExportLibrary.AsyncLogger(sConfigPath, sXprotID);&#xD;&#xA;&#xD;&#xA;record_2 = objBTHelper_2.GetEachRecordFromBatch(sRecordNamesOfBatch, 2);&#xD;&#xA;&#xD;&#xA;record_2 = objBTHelper_2.GetRecordID(record_2);&#xD;&#xA;&#xD;&#xA;async_logger2.LogInfoAsync(record_2, &quot;Log Set&quot;);&#xD;&#xA;&#xD;&#xA;verifyLock_2 = objBTHelper_2.VerifyStageLock(record_2, sXprotID);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Set Variables_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Decision' OID='35ceaf59-34ca-43f3-a4ee-87d41ef8195a' ParentLink='ComplexStatement_Statement' LowerBound='238.1' HigherBound='328.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Decide_2' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='DecisionBranch' OID='5e6a1a58-55a1-4ff5-a237-c8682877e0be' ParentLink='ReallyComplexStatement_Branch' LowerBound='239.21' HigherBound='319.1'>
                                <om:Property Name='Expression' Value='record_2 != System.String.Empty &amp;&amp; verifyLock_2 == true' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Rule_1' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='VariableAssignment' OID='0b1ef171-a35a-4e6f-abd9-6ebbdf01c2c7' ParentLink='ComplexStatement_Statement' LowerBound='241.1' HigherBound='258.1'>
                                    <om:Property Name='Expression' Value='&#xD;&#xA;construct RQ1Extract2&#xD;&#xA; {&#xD;&#xA;    System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;Processing the records : &quot; + record_2);&#xD;&#xA;&#xD;&#xA;    RQ1Extract2 = objBTHelper_2.CreateRQ1DataExtractFile(record_2, sXprotID, sSystem, sInterfaceName, async_logger2, manager);&#xD;&#xA;&#xD;&#xA;    RQ1Extract2 = objBTHelper_2.PrettyXml(RQ1Extract2, record_2, async_logger2, manager);&#xD;&#xA;&#xD;&#xA;    sRecord_id2 = record_2.Substring(0, record_2.IndexOf(&quot;:&quot;));&#xD;&#xA;    RQ1Extract2(FILE.ReceivedFileName) = sSystem + &quot;_&quot; + sXprotID +&quot;_030_&quot; + sRecord_id2 +&quot;_RQ1_Extract&quot;; &#xD;&#xA;&#xD;&#xA;    System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;RQ1 Extract File Created = &quot; + RQ1Extract2(FILE.ReceivedFileName));&#xD;&#xA; }&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Construct_RQ1Extract' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Decision' OID='d93742be-eb91-4ecd-8872-9d26601b04c9' ParentLink='ComplexStatement_Statement' LowerBound='258.1' HigherBound='318.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Decide_9' />
                                    <om:Property Name='Signal' Value='False' />
                                    <om:Element Type='DecisionBranch' OID='556dee00-7afb-4fcf-b88e-8037fe7ccfe7' ParentLink='ReallyComplexStatement_Branch' LowerBound='259.25' HigherBound='318.1'>
                                        <om:Property Name='Expression' Value='!objBTHelper_2.VerifyTokenOfRecord(sRecord_id2,manager)' />
                                        <om:Property Name='IsGhostBranch' Value='True' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Rule_1' />
                                        <om:Property Name='Signal' Value='False' />
                                        <om:Element Type='Send' OID='8850b447-9320-458f-9e76-91a840d09707' ParentLink='ComplexStatement_Statement' LowerBound='261.1' HigherBound='263.1'>
                                            <om:Property Name='PortName' Value='snd_RQ1Extract' />
                                            <om:Property Name='MessageName' Value='RQ1Extract2' />
                                            <om:Property Name='OperationName' Value='Operation_1' />
                                            <om:Property Name='OperationMessageName' Value='Request' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Send_RQ1Extract2' />
                                            <om:Property Name='Signal' Value='True' />
                                        </om:Element>
                                        <om:Element Type='Construct' OID='1280fa01-2d2a-4165-bd63-9bbc51b465bd' ParentLink='ComplexStatement_Statement' LowerBound='263.1' HigherBound='273.1'>
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='ConstructIMF2' />
                                            <om:Property Name='Signal' Value='True' />
                                            <om:Element Type='MessageRef' OID='bf16572f-894c-4543-a1da-624eef9e3d1e' ParentLink='Construct_MessageRef' LowerBound='264.39' HigherBound='264.50'>
                                                <om:Property Name='Ref' Value='EXPORT_IMF2' />
                                                <om:Property Name='ReportToAnalyst' Value='True' />
                                                <om:Property Name='Signal' Value='False' />
                                            </om:Element>
                                            <om:Element Type='Transform' OID='ea383468-e612-4ba6-906e-c5def96eac8e' ParentLink='ComplexStatement_Statement' LowerBound='266.1' HigherBound='268.1'>
                                                <om:Property Name='ClassName' Value='RB.ROCustomerInterfaceExport.CreateIMF' />
                                                <om:Property Name='ReportToAnalyst' Value='True' />
                                                <om:Property Name='Name' Value='Transform_2' />
                                                <om:Property Name='Signal' Value='False' />
                                                <om:Element Type='MessagePartRef' OID='d72c818d-4df6-4768-8101-cc6f92664502' ParentLink='Transform_InputMessagePartRef' LowerBound='267.99' HigherBound='267.110'>
                                                    <om:Property Name='MessageRef' Value='RQ1Extract2' />
                                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                                    <om:Property Name='Name' Value='MessagePartReference_3' />
                                                    <om:Property Name='Signal' Value='False' />
                                                </om:Element>
                                                <om:Element Type='MessagePartRef' OID='7167af51-18a0-43d7-be09-e332d783f437' ParentLink='Transform_OutputMessagePartRef' LowerBound='267.44' HigherBound='267.55'>
                                                    <om:Property Name='MessageRef' Value='EXPORT_IMF2' />
                                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                                    <om:Property Name='Name' Value='MessagePartReference_4' />
                                                    <om:Property Name='Signal' Value='False' />
                                                </om:Element>
                                            </om:Element>
                                            <om:Element Type='MessageAssignment' OID='866ac327-84a0-46f0-8e58-e4843aa1a63b' ParentLink='ComplexStatement_Statement' LowerBound='268.1' HigherBound='272.1'>
                                                <om:Property Name='Expression' Value='EXPORT_IMF2(FILE.ReceivedFileName) = sSystem + &quot;_&quot; + sXprotID +&quot;_030_&quot; + sRecord_id2 +&quot;IMF_Before_Validate&quot;; &#xD;&#xA;&#xD;&#xA;EXPORT_IMF2 = objBTHelper_2.PrettyXml(EXPORT_IMF2, record_2, async_logger2, manager);' />
                                                <om:Property Name='ReportToAnalyst' Value='False' />
                                                <om:Property Name='Name' Value='MessageAssignment_1' />
                                                <om:Property Name='Signal' Value='True' />
                                            </om:Element>
                                        </om:Element>
                                        <om:Element Type='Send' OID='3eb4d947-97c5-44fc-972e-ee07a6153227' ParentLink='ComplexStatement_Statement' LowerBound='273.1' HigherBound='275.1'>
                                            <om:Property Name='PortName' Value='snd_ExportIMF_BeforeValidate' />
                                            <om:Property Name='MessageName' Value='EXPORT_IMF2' />
                                            <om:Property Name='OperationName' Value='Operation_1' />
                                            <om:Property Name='OperationMessageName' Value='Request' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Send_EXPORT_IMF2' />
                                            <om:Property Name='Signal' Value='True' />
                                        </om:Element>
                                        <om:Element Type='VariableAssignment' OID='32a4c10c-4263-461f-82de-1b90c5fb5e29' ParentLink='ComplexStatement_Statement' LowerBound='275.1' HigherBound='279.1'>
                                            <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;Validation started for &quot; + record_2);&#xD;&#xA;is_validate2 = objBTHelper_2.ValidateRQ1ExtractFile( RQ1Extract2, record_2, async_logger2, manager);&#xD;&#xA; ' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Validate' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='Decision' OID='36cc7485-ffc4-4319-b1a4-c5720a46e48d' ParentLink='ComplexStatement_Statement' LowerBound='279.1' HigherBound='317.1'>
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Decide_7' />
                                            <om:Property Name='Signal' Value='True' />
                                            <om:Element Type='DecisionBranch' OID='4ffc212f-a481-4d9a-8655-2b2316360110' ParentLink='ReallyComplexStatement_Branch' LowerBound='280.29' HigherBound='317.1'>
                                                <om:Property Name='Expression' Value='is_validate2 == true' />
                                                <om:Property Name='IsGhostBranch' Value='True' />
                                                <om:Property Name='ReportToAnalyst' Value='True' />
                                                <om:Property Name='Name' Value='Validation check' />
                                                <om:Property Name='Signal' Value='True' />
                                                <om:Element Type='Construct' OID='78a683fc-393c-4bde-a44c-f209f8866901' ParentLink='ComplexStatement_Statement' LowerBound='282.1' HigherBound='298.1'>
                                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                                    <om:Property Name='Name' Value='ConstructIMF_AfterValidate' />
                                                    <om:Property Name='Signal' Value='True' />
                                                    <om:Element Type='MessageRef' OID='f6c28b8c-b5ca-4a10-8b8a-ddc2cd54e8e3' ParentLink='Construct_MessageRef' LowerBound='283.43' HigherBound='283.54'>
                                                        <om:Property Name='Ref' Value='EXPORT_IMF2' />
                                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                                        <om:Property Name='Signal' Value='False' />
                                                    </om:Element>
                                                    <om:Element Type='Transform' OID='3cacfc99-7da1-44c7-927e-fd656cfcc53f' ParentLink='ComplexStatement_Statement' LowerBound='285.1' HigherBound='287.1'>
                                                        <om:Property Name='ClassName' Value='RB.ROCustomerInterfaceExport.CreateIMF' />
                                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                                        <om:Property Name='Name' Value='Transform_3' />
                                                        <om:Property Name='Signal' Value='True' />
                                                        <om:Element Type='MessagePartRef' OID='7cf0da74-6f12-4430-86db-58589bf156b9' ParentLink='Transform_InputMessagePartRef' LowerBound='286.103' HigherBound='286.114'>
                                                            <om:Property Name='MessageRef' Value='RQ1Extract2' />
                                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                                            <om:Property Name='Name' Value='MessagePartReference_5' />
                                                            <om:Property Name='Signal' Value='False' />
                                                        </om:Element>
                                                        <om:Element Type='MessagePartRef' OID='ab74e1c0-a898-47d2-8224-76e73d7440f9' ParentLink='Transform_OutputMessagePartRef' LowerBound='286.48' HigherBound='286.59'>
                                                            <om:Property Name='MessageRef' Value='EXPORT_IMF2' />
                                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                                            <om:Property Name='Name' Value='MessagePartReference_6' />
                                                            <om:Property Name='Signal' Value='False' />
                                                        </om:Element>
                                                    </om:Element>
                                                    <om:Element Type='MessageAssignment' OID='114afe87-8b2e-4059-9475-2a5211fe0c11' ParentLink='ComplexStatement_Statement' LowerBound='287.1' HigherBound='297.1'>
                                                        <om:Property Name='Expression' Value='EXPORT_IMF2 = objBTHelper_2.PrettyXml(EXPORT_IMF2, record_2, async_logger2, manager);&#xD;&#xA;&#xD;&#xA;EXPORT_IMF2 = objBTHelper_2.UpdateIMFAfterValidation(RQ1Extract2, EXPORT_IMF2, record_2 , sXprotID, manager);&#xD;&#xA;&#xD;&#xA;EXPORT_IMF2(FILE.ReceivedFileName) = sSystem + &quot;_&quot; + sXprotID +&quot;_030_&quot; + sRecord_id2 +&quot;IMF_After_Validate&quot;; &#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;Validation Success for &quot; + record_2);&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;After Validate File Created = &quot; + EXPORT_IMF2(FILE.ReceivedFileName));' />
                                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                                        <om:Property Name='Name' Value='MessageAssignment_2' />
                                                        <om:Property Name='Signal' Value='False' />
                                                    </om:Element>
                                                </om:Element>
                                                <om:Element Type='Send' OID='13acd33e-ace7-4056-8d54-cab905b61abb' ParentLink='ComplexStatement_Statement' LowerBound='298.1' HigherBound='300.1'>
                                                    <om:Property Name='PortName' Value='snd_ExportIMF_AfterValidate' />
                                                    <om:Property Name='MessageName' Value='EXPORT_IMF2' />
                                                    <om:Property Name='OperationName' Value='Operation_1' />
                                                    <om:Property Name='OperationMessageName' Value='Request' />
                                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                                    <om:Property Name='Name' Value='Send_EXPORT_IMF2_AV' />
                                                    <om:Property Name='Signal' Value='True' />
                                                </om:Element>
                                                <om:Element Type='VariableAssignment' OID='8c0d2d9f-eebe-4a97-aea5-0a5df1808de4' ParentLink='ComplexStatement_Statement' LowerBound='300.1' HigherBound='304.1'>
                                                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;, &quot;Creating ASAM File&quot;);&#xD;&#xA;asam_file2 = objBTHelper_2.CreateASAMFile(RQ1Extract2,record_2,sXprotID, sSystem,sInterfaceName,async_logger2, manager);&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;, &quot;ASAM File Generated = &quot; + asam_file2);' />
                                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                                    <om:Property Name='Name' Value='Create ASAM File2' />
                                                    <om:Property Name='Signal' Value='False' />
                                                </om:Element>
                                                <om:Element Type='VariableAssignment' OID='e8ee222c-0ebd-4801-b5aa-919a4e38d8cb' ParentLink='ComplexStatement_Statement' LowerBound='304.1' HigherBound='316.1'>
                                                    <om:Property Name='Expression' Value='if(asam_file2 != &quot;&quot; &amp;&amp; asam_file2 != null){&#xD;&#xA;    isUpdated_2 = objBTHelper_2.UpdateRecords(EXPORT_IMF2, record_2, sXprotID, sSystem,sInterfaceName, async_logger2, manager);&#xD;&#xA;&#xD;&#xA;    if(isUpdated_2){&#xD;&#xA;        System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;, record_2 + &quot; Update Successful&quot;);&#xD;&#xA;    }&#xD;&#xA;&#xD;&#xA;    else{&#xD;&#xA;    System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;, record_2 + &quot; Update Failure&quot;);&#xD;&#xA;    }&#xD;&#xA;}' />
                                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                                    <om:Property Name='Name' Value='update record' />
                                                    <om:Property Name='Signal' Value='True' />
                                                </om:Element>
                                            </om:Element>
                                            <om:Element Type='DecisionBranch' OID='75387507-ea92-49e6-abe9-337796a9b2b6' ParentLink='ReallyComplexStatement_Branch'>
                                                <om:Property Name='IsGhostBranch' Value='True' />
                                                <om:Property Name='ReportToAnalyst' Value='True' />
                                                <om:Property Name='Name' Value='Else' />
                                                <om:Property Name='Signal' Value='False' />
                                            </om:Element>
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='DecisionBranch' OID='380ddf6f-b825-4357-aa27-a327c9828079' ParentLink='ReallyComplexStatement_Branch'>
                                        <om:Property Name='IsGhostBranch' Value='True' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Else' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='106f5599-6fff-4ddc-8f8f-07eb08149ce2' ParentLink='ReallyComplexStatement_Branch'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Else' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='VariableAssignment' OID='b791477a-a87c-4a8a-a68b-ff8a2f2c7fcf' ParentLink='ComplexStatement_Statement' LowerBound='321.1' HigherBound='327.1'>
                                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;Process Ends : &quot; + record_2);&#xD;&#xA;if(verifyLock_2 == false)&#xD;&#xA;{&#xD;&#xA;   objBTHelper_2.UpdateTokenManager(record_2, sXprotID, manager);&#xD;&#xA;}' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='End' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='ParallelBranch' OID='77affe73-22a1-4da7-aa1b-02cbc935e876' ParentLink='ReallyComplexStatement_Branch' LowerBound='331.1' HigherBound='350.1'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ParallelBranch_3' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='VariableAssignment' OID='a3e38ea1-d044-4de6-b439-46f7e7cbd28c' ParentLink='ComplexStatement_Statement' LowerBound='331.1' HigherBound='339.1'>
                            <om:Property Name='Expression' Value='async_logger3 = new RB.ROCustomerInterfaceExportLibrary.AsyncLogger(sConfigPath, sXprotID);&#xD;&#xA;&#xD;&#xA;record_3 = objBTHelper_3.GetEachRecordFromBatch(sRecordNamesOfBatch, 3);&#xD;&#xA;&#xD;&#xA;record_3 = objBTHelper_3.GetRecordID(record_3);&#xD;&#xA;&#xD;&#xA;async_logger3.LogInfoAsync(record_3, &quot;Log Set&quot;);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Set Variables_3' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Decision' OID='a11bcd5f-4e16-49b6-9321-dcd982bf882c' ParentLink='ComplexStatement_Statement' LowerBound='339.1' HigherBound='350.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Decide_3' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='DecisionBranch' OID='b9c64240-9a46-4ef0-898e-fc95d23745eb' ParentLink='ReallyComplexStatement_Branch' LowerBound='340.21' HigherBound='345.1'>
                                <om:Property Name='Expression' Value='record_3 != System.String.Empty' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Rule_1' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='VariableAssignment' OID='d16cf294-8682-471d-839c-e04c744fbe5c' ParentLink='ComplexStatement_Statement' LowerBound='342.1' HigherBound='344.1'>
                                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;Processing the records : &quot; + record_3);' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Expression_4' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='c8cd9814-7159-4a5e-86b1-65ea4ba9478e' ParentLink='ReallyComplexStatement_Branch'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Else' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='VariableAssignment' OID='7888364f-4b6b-4aee-9d65-68c3af350f6a' ParentLink='ComplexStatement_Statement' LowerBound='347.1' HigherBound='349.1'>
                                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;Process Ends : &quot; + record_3);' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='End' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='ParallelBranch' OID='de6c4119-47a5-4110-a876-f7d535b79d74' ParentLink='ReallyComplexStatement_Branch' LowerBound='353.1' HigherBound='372.1'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ParallelBranch_4' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='VariableAssignment' OID='d09f8ae6-50b2-4fff-a8e2-c7377a8e9376' ParentLink='ComplexStatement_Statement' LowerBound='353.1' HigherBound='361.1'>
                            <om:Property Name='Expression' Value='async_logger4 = new RB.ROCustomerInterfaceExportLibrary.AsyncLogger(sConfigPath, sXprotID);&#xD;&#xA;&#xD;&#xA;record_4 = objBTHelper_4.GetEachRecordFromBatch(sRecordNamesOfBatch, 4);&#xD;&#xA;&#xD;&#xA;record_4 = objBTHelper_4.GetRecordID(record_4);&#xD;&#xA;&#xD;&#xA;async_logger4.LogInfoAsync(record_4, &quot;Log Set&quot;);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Set Variables_4' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Decision' OID='78115a98-3cf9-4c3e-ac1c-08a8732b9464' ParentLink='ComplexStatement_Statement' LowerBound='361.1' HigherBound='372.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Decide_4' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='DecisionBranch' OID='cfd325b6-ae1e-417d-9222-6cde86d00d69' ParentLink='ReallyComplexStatement_Branch' LowerBound='362.21' HigherBound='367.1'>
                                <om:Property Name='Expression' Value='record_4 != System.String.Empty' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Rule_1' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='VariableAssignment' OID='2afbebf1-b2f2-4710-99f4-4ebc222ebfd3' ParentLink='ComplexStatement_Statement' LowerBound='364.1' HigherBound='366.1'>
                                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;Processing the records : &quot; + record_4);' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Expression_5' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='67001391-f74f-492b-aa59-3fe5be2fb0c5' ParentLink='ReallyComplexStatement_Branch'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Else' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='VariableAssignment' OID='ead2d9a5-c743-4e6d-8192-83ff05c43262' ParentLink='ComplexStatement_Statement' LowerBound='369.1' HigherBound='371.1'>
                                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;Process Ends : &quot; + record_4);' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='End' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='ParallelBranch' OID='857a6d32-9084-416c-847b-324ff6f4528b' ParentLink='ReallyComplexStatement_Branch' LowerBound='375.1' HigherBound='394.1'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ParallelBranch_5' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='VariableAssignment' OID='f9f59832-efd4-4cb7-bf7b-e3ba23b77fb8' ParentLink='ComplexStatement_Statement' LowerBound='375.1' HigherBound='383.1'>
                            <om:Property Name='Expression' Value='async_logger5 = new RB.ROCustomerInterfaceExportLibrary.AsyncLogger(sConfigPath, sXprotID);&#xD;&#xA;&#xD;&#xA;record_5 = objBTHelper_5.GetEachRecordFromBatch(sRecordNamesOfBatch, 5);&#xD;&#xA;&#xD;&#xA;record_5 = objBTHelper_5.GetRecordID(record_5);&#xD;&#xA;&#xD;&#xA;async_logger5.LogInfoAsync(record_5, &quot;Log Set&quot;);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Set Variables_5' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Decision' OID='77310f3f-639a-4326-98e9-b39359380b1e' ParentLink='ComplexStatement_Statement' LowerBound='383.1' HigherBound='394.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Decide_5' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='DecisionBranch' OID='1532230e-4bf0-455f-9f57-f224c540bd9c' ParentLink='ReallyComplexStatement_Branch' LowerBound='384.21' HigherBound='389.1'>
                                <om:Property Name='Expression' Value='record_5 != System.String.Empty' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Rule_1' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='VariableAssignment' OID='835f8744-5596-4990-9607-fd0b401c0fd1' ParentLink='ComplexStatement_Statement' LowerBound='386.1' HigherBound='388.1'>
                                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;Processing the records : &quot; + record_5);' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Expression_6' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='83f822a7-1edc-4584-9c2e-3342e96df8a0' ParentLink='ReallyComplexStatement_Branch'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Else' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='VariableAssignment' OID='05030e42-cc1c-42e0-add6-aeb61fdead4a' ParentLink='ComplexStatement_Statement' LowerBound='391.1' HigherBound='393.1'>
                                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;ROINTERFACE_Export&quot;,&quot;Process Ends : &quot; + record_5);' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='End' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
                <om:Element Type='VariableAssignment' OID='631cf19c-6de5-4d49-8aa1-e33407ac5896' ParentLink='ServiceBody_Statement' LowerBound='396.1' HigherBound='398.1'>
                    <om:Property Name='Expression' Value='LifeToken4Files = manager.UpdateLifeToken4FilesString(LifeToken4Files);&#xD;&#xA;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Update LifeTokens' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='66547591-3717-4b14-8a2b-55b3fcd92398' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='35.1' HigherBound='37.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='30' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExport.Send_RQ1Extract' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='snd_RQ1Extract' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='92721f72-1590-4f13-a32f-66cd56cd8e14' ParentLink='PortDeclaration_CLRAttribute' LowerBound='35.1' HigherBound='36.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='d93a5994-9a27-4e37-b7e1-c9908358ba4f' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='37.1' HigherBound='39.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='81' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExport.afterValidate' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='snd_ExportIMF_AfterValidate' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='c761dfe0-afdd-4a06-9751-87cb80e6fa57' ParentLink='PortDeclaration_CLRAttribute' LowerBound='37.1' HigherBound='38.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='4f770153-fcb1-41bc-b0bc-09e10c7663f8' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='39.1' HigherBound='41.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='48' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='RB.ROCustomerInterfaceExport.IMF_Before_Validate' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='snd_ExportIMF_BeforeValidate' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='f730836a-807a-4a7f-b84d-1f9f68adf0ca' ParentLink='PortDeclaration_CLRAttribute' LowerBound='39.1' HigherBound='40.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='6c5b50f0-5b8d-4588-a84d-53ca5a854555' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_2' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='dfcd3d6f-1ffb-4669-adf3-e9178b1c0f74' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='76dbfe82-51c8-4476-b42a-ada9d1001d15' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.42'>
                    <om:Property Name='Ref' Value='RB.ROCustomerInterfaceExport.Schemas.RO_Extract.RQ1Extract' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='81e166fe-8cdb-4a3a-b5d2-9bbbce7681b8' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Send_RQ1Extract' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='abcef021-290f-4519-a1e5-5e95784c2585' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='9ce4dc07-645e-446f-a031-279ad116eec6' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.42'>
                    <om:Property Name='Ref' Value='RB.ROCustomerInterfaceExport.Schemas.RO_Extract.RQ1Extract' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='3f83a2d6-147c-48e1-b828-e1cf5cb49edf' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='IMF_Before_Validate' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='baa9000b-cc8a-4c82-8d3c-5f10a353651e' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='0cc393c8-f6df-4897-aab8-b18ba1923685' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.42'>
                    <om:Property Name='Ref' Value='RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='691fbd05-a12b-4656-b65b-42a66775323d' ParentLink='Module_PortType' LowerBound='25.1' HigherBound='32.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='afterValidate' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='152b85ec-34e4-4512-9de6-ba9b8fb7c8d5' ParentLink='PortType_OperationDeclaration' LowerBound='27.1' HigherBound='31.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='9a7d4bc8-ca49-46e5-aada-d60edf68c3b7' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='29.13' HigherBound='29.42'>
                    <om:Property Name='Ref' Value='RB.ROCustomerInterfaceExport.Schemas.Export_IMF.Export_IMF' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __ValidateandExecute_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __ValidateandExecute_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ValidateandExecute")
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
                ValidateandExecute __svc__ = (ValidateandExecute)_service;
                __ValidateandExecute_root_0 __ctx0__ = (__ValidateandExecute_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.snd_ExportIMF_AfterValidate != null)
                {
                    __svc__.snd_ExportIMF_AfterValidate.Close(this, null);
                    __svc__.snd_ExportIMF_AfterValidate = null;
                }
                if (__svc__.snd_ExportIMF_BeforeValidate != null)
                {
                    __svc__.snd_ExportIMF_BeforeValidate.Close(this, null);
                    __svc__.snd_ExportIMF_BeforeValidate = null;
                }
                if (__svc__.snd_RQ1Extract != null)
                {
                    __svc__.snd_RQ1Extract.Close(this, null);
                    __svc__.snd_RQ1Extract = null;
                }
                base.Finally();
            }

        }


        [System.SerializableAttribute]
        public class __ValidateandExecute_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __ValidateandExecute_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ValidateandExecute")
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
                ValidateandExecute __svc__ = (ValidateandExecute)_service;
                __ValidateandExecute_1 __ctx1__ = (__ValidateandExecute_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__LifeTokenofFile1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__asam_file = null;
                if (__ctx1__ != null)
                    __ctx1__.__objBTHelper_3 = null;
                if (__ctx1__ != null)
                    __ctx1__.__objBTHelper_4 = null;
                if (__ctx1__ != null)
                    __ctx1__.__objBTHelper_5 = null;
                if (__ctx1__ != null)
                    __ctx1__.__sRecord_id1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__record_1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__record_3 = null;
                if (__ctx1__ != null)
                    __ctx1__.__record_5 = null;
                if (__ctx1__ != null)
                    __ctx1__.__async_logger1 = null;
                if (__ctx1__ != null && __ctx1__.__EXPORT_IMF2 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EXPORT_IMF2);
                    __ctx1__.__EXPORT_IMF2 = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__async_logger2 = null;
                if (__ctx1__ != null)
                    __ctx1__.__async_logger3 = null;
                if (__ctx1__ != null)
                    __ctx1__.__async_logger4 = null;
                if (__ctx1__ != null && __ctx1__.__RQ1Extract1 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RQ1Extract1);
                    __ctx1__.__RQ1Extract1 = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__async_logger5 = null;
                if (__ctx1__ != null)
                    __ctx1__.__objBTHelper_1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__sConfigPath = null;
                if (__ctx1__ != null)
                    __ctx1__.__sRecordNamesOfBatch = null;
                if (__ctx1__ != null)
                    __ctx1__.__objBTHelper_2 = null;
                if (__ctx1__ != null)
                    __ctx1__.__record_2 = null;
                if (__ctx1__ != null)
                    __ctx1__.__record_4 = null;
                if (__ctx1__ != null && __ctx1__.__RQ1Extract2 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RQ1Extract2);
                    __ctx1__.__RQ1Extract2 = null;
                }
                if (__ctx1__ != null && __ctx1__.__EXPORT_IMF1 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EXPORT_IMF1);
                    __ctx1__.__EXPORT_IMF1 = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__sInterfaceName = null;
                if (__ctx1__ != null)
                    __ctx1__.__LifeTokenofFile2 = null;
                if (__ctx1__ != null)
                    __ctx1__.__LifeToken4Files = null;
                if (__ctx1__ != null)
                    __ctx1__.__ROLogger = null;
                if (__ctx1__ != null)
                    __ctx1__.__sRecord_id2 = null;
                if (__ctx1__ != null)
                    __ctx1__.__asam_file2 = null;
                if (__ctx1__ != null)
                    __ctx1__.__sXprotID = null;
                if (__ctx1__ != null)
                    __ctx1__.__manager = null;
                if (__ctx1__ != null)
                    __ctx1__.__ROCustomerExportLibrary = null;
                if (__ctx1__ != null)
                    __ctx1__.__sSystem = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("EXPORT_IMF2")]
            public __messagetype_RB_ROCustomerInterfaceExport_Schemas_Export_IMF_Export_IMF __EXPORT_IMF2;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RQ1Extract2")]
            public __messagetype_RB_ROCustomerInterfaceExport_Schemas_RO_Extract_RQ1Extract __RQ1Extract2;
            [Microsoft.XLANGs.Core.UserVariableAttribute("RQ1Extract1")]
            public __messagetype_RB_ROCustomerInterfaceExport_Schemas_RO_Extract_RQ1Extract __RQ1Extract1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EXPORT_IMF1")]
            public __messagetype_RB_ROCustomerInterfaceExport_Schemas_Export_IMF_Export_IMF __EXPORT_IMF1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sRecordNamesOfBatch")]
            internal System.String __sRecordNamesOfBatch;
            [Microsoft.XLANGs.Core.UserVariableAttribute("record_1")]
            internal System.String __record_1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("record_2")]
            internal System.String __record_2;
            [Microsoft.XLANGs.Core.UserVariableAttribute("record_3")]
            internal System.String __record_3;
            [Microsoft.XLANGs.Core.UserVariableAttribute("record_4")]
            internal System.String __record_4;
            [Microsoft.XLANGs.Core.UserVariableAttribute("record_5")]
            internal System.String __record_5;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sConfigPath")]
            internal System.String __sConfigPath;
            [Microsoft.XLANGs.Core.UserVariableAttribute("async_logger1")]
            internal RB.ROCustomerInterfaceExportLibrary.AsyncLogger __async_logger1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("async_logger2")]
            internal RB.ROCustomerInterfaceExportLibrary.AsyncLogger __async_logger2;
            [Microsoft.XLANGs.Core.UserVariableAttribute("async_logger3")]
            internal RB.ROCustomerInterfaceExportLibrary.AsyncLogger __async_logger3;
            [Microsoft.XLANGs.Core.UserVariableAttribute("async_logger4")]
            internal RB.ROCustomerInterfaceExportLibrary.AsyncLogger __async_logger4;
            [Microsoft.XLANGs.Core.UserVariableAttribute("async_logger5")]
            internal RB.ROCustomerInterfaceExportLibrary.AsyncLogger __async_logger5;
            [Microsoft.XLANGs.Core.UserVariableAttribute("objBTHelper_1")]
            internal RB.ROCustomerInterfaceExportLibrary.BTHelper __objBTHelper_1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("objBTHelper_2")]
            internal RB.ROCustomerInterfaceExportLibrary.BTHelper __objBTHelper_2;
            [Microsoft.XLANGs.Core.UserVariableAttribute("objBTHelper_3")]
            internal RB.ROCustomerInterfaceExportLibrary.BTHelper __objBTHelper_3;
            [Microsoft.XLANGs.Core.UserVariableAttribute("objBTHelper_4")]
            internal RB.ROCustomerInterfaceExportLibrary.BTHelper __objBTHelper_4;
            [Microsoft.XLANGs.Core.UserVariableAttribute("objBTHelper_5")]
            internal RB.ROCustomerInterfaceExportLibrary.BTHelper __objBTHelper_5;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sRecord_id1")]
            internal System.String __sRecord_id1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("is_validate")]
            internal System.Boolean __is_validate;
            [Microsoft.XLANGs.Core.UserVariableAttribute("isUpdated")]
            internal System.Boolean __isUpdated;
            [Microsoft.XLANGs.Core.UserVariableAttribute("asam_file")]
            internal System.String __asam_file;
            [Microsoft.XLANGs.Core.UserVariableAttribute("LifeTokenofFile1")]
            internal System.String __LifeTokenofFile1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sRecord_id2")]
            internal System.String __sRecord_id2;
            [Microsoft.XLANGs.Core.UserVariableAttribute("LifeTokenofFile2")]
            internal System.String __LifeTokenofFile2;
            [Microsoft.XLANGs.Core.UserVariableAttribute("is_validate2")]
            internal System.Boolean __is_validate2;
            [Microsoft.XLANGs.Core.UserVariableAttribute("isUpdated_2")]
            internal System.Boolean __isUpdated_2;
            [Microsoft.XLANGs.Core.UserVariableAttribute("asam_file2")]
            internal System.String __asam_file2;
            [Microsoft.XLANGs.Core.UserVariableAttribute("manager")]
            internal RB.ROCustomerInterfaceExportLibrary.LifeTokenManager __manager;
            [Microsoft.XLANGs.Core.UserVariableAttribute("isException1")]
            internal System.Boolean __isException1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("verifyLock_2")]
            internal System.Boolean __verifyLock_2;
            [Microsoft.XLANGs.Core.UserVariableAttribute("verifyLock_1")]
            internal System.Boolean __verifyLock_1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ROLogger")]
            internal RB.ROCustomerInterfaceExportLibrary.Logger __ROLogger;
            [Microsoft.XLANGs.Core.UserVariableAttribute("batchCount")]
            internal System.Int32 __batchCount;
            [Microsoft.XLANGs.Core.UserVariableAttribute("LifeToken4Files")]
            internal System.String __LifeToken4Files;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sXprotID")]
            internal System.String __sXprotID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ROCustomerExportLibrary")]
            internal RB.ROCustomerInterfaceExportLibrary.BTHelper __ROCustomerExportLibrary;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sSystem")]
            internal System.String __sSystem;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sInterfaceName")]
            internal System.String __sInterfaceName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("loopIndex")]
            internal System.Int32 __loopIndex;
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
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("snd_RQ1Extract")]
        internal Send_RQ1Extract snd_RQ1Extract;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("snd_ExportIMF_BeforeValidate")]
        internal IMF_Before_Validate snd_ExportIMF_BeforeValidate;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("snd_ExportIMF_AfterValidate")]
        internal afterValidate snd_ExportIMF_AfterValidate;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Send_RQ1Extract.Operation_1},
                                               typeof(ValidateandExecute).GetField("snd_RQ1Extract", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ValidateandExecute), "snd_RQ1Extract"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {IMF_Before_Validate.Operation_1},
                                               typeof(ValidateandExecute).GetField("snd_ExportIMF_BeforeValidate", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ValidateandExecute), "snd_ExportIMF_BeforeValidate"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {afterValidate.Operation_1},
                                               typeof(ValidateandExecute).GetField("snd_ExportIMF_AfterValidate", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ValidateandExecute), "snd_ExportIMF_AfterValidate"),
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


        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "47680ca8-7462-4ce0-806e-b554fa2a313d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "47680ca8-7462-4ce0-806e-b554fa2a313d", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "694c0094-e1be-4247-a834-8533f95d0657", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "694c0094-e1be-4247-a834-8533f95d0657", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "fb51336c-2f3b-46a9-9035-c182832e597d", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "fb51336c-2f3b-46a9-9035-c182832e597d", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "aec60798-fe0d-480d-ae1e-bc207b431ef6", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "87116fbe-e79c-40f3-ac85-cdf84cb9bc48", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "87116fbe-e79c-40f3-ac85-cdf84cb9bc48", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "af580bb1-f3e0-4320-9963-f6e0881cc173", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "13f8ef49-e877-4239-85d7-9b867c352588", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "13f8ef49-e877-4239-85d7-9b867c352588", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "821e0a49-7957-46dc-9825-2717d6e1a4a3", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "821e0a49-7957-46dc-9825-2717d6e1a4a3", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "c74e5a0f-0e80-4d56-bdfe-88161e0baa09", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "c74e5a0f-0e80-4d56-bdfe-88161e0baa09", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "cbe51c87-290f-4b53-91d8-bddccaae3083", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "cbe51c87-290f-4b53-91d8-bddccaae3083", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "974ad448-5872-47c4-88d0-4b8172b0b66a", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "d203ee77-a581-4e14-823c-32f6621c1c87", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "d203ee77-a581-4e14-823c-32f6621c1c87", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "2cade61f-6150-4bbe-8747-e41eaf609b4a", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "2cade61f-6150-4bbe-8747-e41eaf609b4a", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "d7e72fc2-cabb-4c6e-a10c-25b20b9ea659", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "d7e72fc2-cabb-4c6e-a10c-25b20b9ea659", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "bc760d68-2ab9-45bb-b7df-e59e6afce3cf", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(30, "bc760d68-2ab9-45bb-b7df-e59e6afce3cf", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(31, "974ad448-5872-47c4-88d0-4b8172b0b66a", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(32, "af580bb1-f3e0-4320-9963-f6e0881cc173", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(33, "cd79de91-a017-4e46-b5d7-d59daff7e109", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(34, "cd79de91-a017-4e46-b5d7-d59daff7e109", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(35, "aec60798-fe0d-480d-ae1e-bc207b431ef6", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(36, "498d910b-8a5e-4113-9d35-330bb242f2eb", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(37, "498d910b-8a5e-4113-9d35-330bb242f2eb", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(38, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(39, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(40, "35ceaf59-34ca-43f3-a4ee-87d41ef8195a", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(41, "0b1ef171-a35a-4e6f-abd9-6ebbdf01c2c7", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(42, "0b1ef171-a35a-4e6f-abd9-6ebbdf01c2c7", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(43, "d93742be-eb91-4ecd-8872-9d26601b04c9", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(44, "8850b447-9320-458f-9e76-91a840d09707", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(45, "8850b447-9320-458f-9e76-91a840d09707", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(46, "1280fa01-2d2a-4165-bd63-9bbc51b465bd", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(47, "1280fa01-2d2a-4165-bd63-9bbc51b465bd", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(48, "3eb4d947-97c5-44fc-972e-ee07a6153227", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(49, "3eb4d947-97c5-44fc-972e-ee07a6153227", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(50, "32a4c10c-4263-461f-82de-1b90c5fb5e29", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(51, "32a4c10c-4263-461f-82de-1b90c5fb5e29", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(52, "36cc7485-ffc4-4319-b1a4-c5720a46e48d", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(53, "78a683fc-393c-4bde-a44c-f209f8866901", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(54, "78a683fc-393c-4bde-a44c-f209f8866901", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(55, "13acd33e-ace7-4056-8d54-cab905b61abb", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(56, "13acd33e-ace7-4056-8d54-cab905b61abb", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(57, "8c0d2d9f-eebe-4a97-aea5-0a5df1808de4", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(58, "8c0d2d9f-eebe-4a97-aea5-0a5df1808de4", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(59, "e8ee222c-0ebd-4801-b5aa-919a4e38d8cb", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(60, "e8ee222c-0ebd-4801-b5aa-919a4e38d8cb", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(61, "36cc7485-ffc4-4319-b1a4-c5720a46e48d", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(62, "d93742be-eb91-4ecd-8872-9d26601b04c9", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(63, "b791477a-a87c-4a8a-a68b-ff8a2f2c7fcf", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(64, "b791477a-a87c-4a8a-a68b-ff8a2f2c7fcf", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(65, "35ceaf59-34ca-43f3-a4ee-87d41ef8195a", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(66, "a3e38ea1-d044-4de6-b439-46f7e7cbd28c", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(67, "a3e38ea1-d044-4de6-b439-46f7e7cbd28c", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(68, "00000000-0000-0000-0000-000000000000", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(69, "00000000-0000-0000-0000-000000000000", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(70, "a11bcd5f-4e16-49b6-9321-dcd982bf882c", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(71, "d16cf294-8682-471d-839c-e04c744fbe5c", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(72, "d16cf294-8682-471d-839c-e04c744fbe5c", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(73, "7888364f-4b6b-4aee-9d65-68c3af350f6a", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(74, "7888364f-4b6b-4aee-9d65-68c3af350f6a", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(75, "a11bcd5f-4e16-49b6-9321-dcd982bf882c", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(76, "d09f8ae6-50b2-4fff-a8e2-c7377a8e9376", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(77, "d09f8ae6-50b2-4fff-a8e2-c7377a8e9376", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(78, "00000000-0000-0000-0000-000000000000", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(79, "00000000-0000-0000-0000-000000000000", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(80, "78115a98-3cf9-4c3e-ac1c-08a8732b9464", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(81, "2afbebf1-b2f2-4710-99f4-4ebc222ebfd3", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(82, "2afbebf1-b2f2-4710-99f4-4ebc222ebfd3", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(83, "ead2d9a5-c743-4e6d-8192-83ff05c43262", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(84, "ead2d9a5-c743-4e6d-8192-83ff05c43262", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(85, "78115a98-3cf9-4c3e-ac1c-08a8732b9464", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(86, "f9f59832-efd4-4cb7-bf7b-e3ba23b77fb8", 6, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(87, "f9f59832-efd4-4cb7-bf7b-e3ba23b77fb8", 6, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(88, "00000000-0000-0000-0000-000000000000", 6, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(89, "00000000-0000-0000-0000-000000000000", 6, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(90, "77310f3f-639a-4326-98e9-b39359380b1e", 6, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(91, "835f8744-5596-4990-9607-fd0b401c0fd1", 6, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(92, "835f8744-5596-4990-9607-fd0b401c0fd1", 6, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(93, "05030e42-cc1c-42e0-add6-aeb61fdead4a", 6, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(94, "05030e42-cc1c-42e0-add6-aeb61fdead4a", 6, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(95, "77310f3f-639a-4326-98e9-b39359380b1e", 6, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(96, "631cf19c-6de5-4d49-8aa1-e33407ac5896", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(97, "631cf19c-6de5-4d49-8aa1-e33407ac5896", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Parallel),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Parallel)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,1,1,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,3,3,3,3,3,4,5,5,96,96,97,1,1,1,1,1,};
        public static int[] __progressLocation2 = new int[] { 6,6,7,7,7,7,7,10,10,11,11,12,13,13,14,14,14,15,16,16,17,18,18,18,19,20,20,21,21,22,22,23,23,24,25,25,25,26,27,27,28,28,28,29,29,29,29,29,29,29,29,29,30,31,32,10,33,33,34,34,34,34,34,35,5,};
        public static int[] __progressLocation3 = new int[] { 36,36,37,37,37,37,37,40,40,41,41,42,43,43,44,44,44,45,46,46,47,48,48,48,49,50,50,51,51,52,52,53,53,54,55,55,55,56,57,57,58,58,58,59,59,59,59,59,59,59,59,59,60,61,62,40,63,63,64,64,64,64,64,65,5,};
        public static int[] __progressLocation4 = new int[] { 66,66,67,67,67,67,70,70,71,71,72,70,73,73,74,75,5,};
        public static int[] __progressLocation5 = new int[] { 76,76,77,77,77,77,80,80,81,81,82,80,83,83,84,85,5,};
        public static int[] __progressLocation6 = new int[] { 86,86,87,87,87,87,90,90,91,91,92,90,93,93,94,95,5,};

        public static int[][] __progressLocations = new int[7] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3,__progressLocation4,__progressLocation5,__progressLocation6};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __ValidateandExecute_1 __ctx1__ = (__ValidateandExecute_1)_stateMgrs[1];
            __ValidateandExecute_root_0 __ctx0__ = (__ValidateandExecute_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                snd_RQ1Extract = new Send_RQ1Extract(0, this);
                snd_ExportIMF_AfterValidate = new afterValidate(2, this);
                snd_ExportIMF_BeforeValidate = new IMF_Before_Validate(1, this);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __ValidateandExecute_1(this);
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
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __ValidateandExecute_1 __ctx1__ = (__ValidateandExecute_1)_stateMgrs[1];
            __ValidateandExecute_root_0 __ctx0__ = (__ValidateandExecute_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__ROLogger = (RB.ROCustomerInterfaceExportLibrary.Logger)Args[0];
                __ctx1__.__batchCount = (System.Int32)Args[1];
                __ctx1__.__LifeToken4Files = (System.String)Args[2];
                __ctx1__.__sXprotID = (System.String)Args[3];
                __ctx1__.__ROCustomerExportLibrary = (RB.ROCustomerInterfaceExportLibrary.BTHelper)Args[4];
                __ctx1__.__sSystem = (System.String)Args[5];
                __ctx1__.__sInterfaceName = (System.String)Args[6];
                __ctx1__.__loopIndex = (System.Int32)Args[7];
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx1__.__sRecordNamesOfBatch = default(System.String);
                __ctx1__.__record_1 = default(System.String);
                __ctx1__.__record_2 = default(System.String);
                __ctx1__.__record_3 = default(System.String);
                __ctx1__.__record_4 = default(System.String);
                __ctx1__.__record_5 = default(System.String);
                __ctx1__.__sConfigPath = default(System.String);
                __ctx1__.__async_logger1 = default(RB.ROCustomerInterfaceExportLibrary.AsyncLogger);
                __ctx1__.__async_logger2 = default(RB.ROCustomerInterfaceExportLibrary.AsyncLogger);
                __ctx1__.__async_logger3 = default(RB.ROCustomerInterfaceExportLibrary.AsyncLogger);
                __ctx1__.__async_logger4 = default(RB.ROCustomerInterfaceExportLibrary.AsyncLogger);
                __ctx1__.__async_logger5 = default(RB.ROCustomerInterfaceExportLibrary.AsyncLogger);
                __ctx1__.__objBTHelper_1 = default(RB.ROCustomerInterfaceExportLibrary.BTHelper);
                __ctx1__.__objBTHelper_2 = default(RB.ROCustomerInterfaceExportLibrary.BTHelper);
                __ctx1__.__objBTHelper_3 = default(RB.ROCustomerInterfaceExportLibrary.BTHelper);
                __ctx1__.__objBTHelper_4 = default(RB.ROCustomerInterfaceExportLibrary.BTHelper);
                __ctx1__.__objBTHelper_5 = default(RB.ROCustomerInterfaceExportLibrary.BTHelper);
                __ctx1__.__sRecord_id1 = default(System.String);
                __ctx1__.__is_validate = default(System.Boolean);
                __ctx1__.__isUpdated = default(System.Boolean);
                __ctx1__.__asam_file = default(System.String);
                __ctx1__.__LifeTokenofFile1 = default(System.String);
                __ctx1__.__sRecord_id2 = default(System.String);
                __ctx1__.__LifeTokenofFile2 = default(System.String);
                __ctx1__.__is_validate2 = default(System.Boolean);
                __ctx1__.__isUpdated_2 = default(System.Boolean);
                __ctx1__.__asam_file2 = default(System.String);
                __ctx1__.__manager = default(RB.ROCustomerInterfaceExportLibrary.LifeTokenManager);
                __ctx1__.__isException1 = default(System.Boolean);
                __ctx1__.__verifyLock_2 = default(System.Boolean);
                __ctx1__.__verifyLock_1 = default(System.Boolean);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__sRecordNamesOfBatch = "";
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.__record_1 = "";
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__record_2 = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__record_3 = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__record_4 = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__record_5 = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__sConfigPath = "";
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__objBTHelper_1 = new RB.ROCustomerInterfaceExportLibrary.BTHelper();
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__objBTHelper_2 = new RB.ROCustomerInterfaceExportLibrary.BTHelper();
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__objBTHelper_3 = new RB.ROCustomerInterfaceExportLibrary.BTHelper();
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __ctx1__.__objBTHelper_4 = new RB.ROCustomerInterfaceExportLibrary.BTHelper();
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                __ctx1__.__objBTHelper_5 = new RB.ROCustomerInterfaceExportLibrary.BTHelper();
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                __ctx1__.__sRecord_id1 = "";
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                __ctx1__.__is_validate = true;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                __ctx1__.__isUpdated = true;
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                __ctx1__.__asam_file = "";
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                __ctx1__.__LifeTokenofFile1 = "";
                if (__ctx1__ != null)
                    __ctx1__.__LifeTokenofFile1 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                __ctx1__.__sRecord_id2 = "";
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                __ctx1__.__LifeTokenofFile2 = "";
                if (__ctx1__ != null)
                    __ctx1__.__LifeTokenofFile2 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                __ctx1__.__is_validate2 = true;
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                __ctx1__.__isUpdated_2 = true;
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                __ctx1__.__asam_file2 = "";
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                __ctx1__.__manager = new RB.ROCustomerInterfaceExportLibrary.LifeTokenManager();
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                __ctx1__.__isException1 = true;
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                __ctx1__.__verifyLock_2 = true;
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                __ctx1__.__verifyLock_1 = true;
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[2],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "Validate and Execute Orchestration Starts : ");
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                __ctx1__.__sRecordNamesOfBatch = __ctx1__.__ROCustomerExportLibrary.GetRecordNamesFromBatch(__ctx1__.__LifeToken4Files, __ctx1__.__loopIndex, __ctx1__.__ROLogger);
                if (__ctx1__ != null)
                    __ctx1__.__ROLogger = null;
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                __ctx1__.__manager = new RB.ROCustomerInterfaceExportLibrary.LifeTokenManager();
                if ( !PostProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 34;
            case 34:
                __ctx1__.__manager.Initialize(__ctx1__.__LifeToken4Files);
                if ( !PostProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 35;
            case 35:
                __ctx1__.__sConfigPath = __ctx1__.__ROCustomerExportLibrary.GetConfigPathForFolderCreation(__ctx1__.__sInterfaceName, __ctx1__.__sXprotID);
                if (__ctx1__ != null)
                    __ctx1__.__ROCustomerExportLibrary = null;
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                __seg__.RunSegments(new Microsoft.XLANGs.Core.Segment[] {_segments[2], _segments[3], _segments[4], _segments[5], _segments[6]}, this);
                if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 38:
                if ( !PreProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__sInterfaceName = null;
                if (__ctx1__ != null)
                    __ctx1__.__sSystem = null;
                if (__ctx1__ != null)
                    __ctx1__.__sXprotID = null;
                if (__ctx1__ != null)
                    __ctx1__.__asam_file2 = null;
                if (__ctx1__ != null)
                    __ctx1__.__sRecord_id2 = null;
                if (__ctx1__ != null)
                    __ctx1__.__asam_file = null;
                if (__ctx1__ != null)
                    __ctx1__.__sRecord_id1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__objBTHelper_5 = null;
                if (__ctx1__ != null)
                    __ctx1__.__objBTHelper_4 = null;
                if (__ctx1__ != null)
                    __ctx1__.__objBTHelper_3 = null;
                if (__ctx1__ != null)
                    __ctx1__.__objBTHelper_2 = null;
                if (__ctx1__ != null)
                    __ctx1__.__objBTHelper_1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__sConfigPath = null;
                if (__ctx1__ != null)
                    __ctx1__.__record_5 = null;
                if (__ctx1__ != null)
                    __ctx1__.__record_4 = null;
                if (__ctx1__ != null)
                    __ctx1__.__record_3 = null;
                if (__ctx1__ != null)
                    __ctx1__.__record_2 = null;
                if (__ctx1__ != null)
                    __ctx1__.__record_1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__sRecordNamesOfBatch = null;
                if (snd_ExportIMF_BeforeValidate != null)
                {
                    snd_ExportIMF_BeforeValidate.Close(__ctx1__, __seg__);
                    snd_ExportIMF_BeforeValidate = null;
                }
                if (snd_ExportIMF_AfterValidate != null)
                {
                    snd_ExportIMF_AfterValidate.Close(__ctx1__, __seg__);
                    snd_ExportIMF_AfterValidate = null;
                }
                if (snd_RQ1Extract != null)
                {
                    snd_RQ1Extract.Close(__ctx1__, __seg__);
                    snd_RQ1Extract = null;
                }
                Tracker.FireEvent(__eventLocations[5],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[96],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 40;
            case 40:
                __ctx1__.__LifeToken4Files = __ctx1__.__manager.UpdateLifeToken4FilesString(__ctx1__.__LifeToken4Files);
                if (__ctx1__ != null)
                    __ctx1__.__manager = null;
                if ( !PostProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 41;
            case 41:
                if ( !PreProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[97],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 42;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 43;
            case 43:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 44;
            case 44:
                if ( !PreProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 45;
            case 45:
                Args[2] = __ctx1__.__LifeToken4Files;
                if (__ctx1__ != null)
                    __ctx1__.__LifeToken4Files = null;
                if ( !PostProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 46;
            case 46:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __ValidateandExecute_1 __ctx1__ = (__ValidateandExecute_1)_stateMgrs[1];
            __ValidateandExecute_root_0 __ctx0__ = (__ValidateandExecute_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                if ( !PreProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 1;
            case 1:
                __ctx1__.__async_logger1 = new RB.ROCustomerInterfaceExportLibrary.AsyncLogger(__ctx1__.__sConfigPath, __ctx1__.__sXprotID);
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__record_1 = __ctx1__.__objBTHelper_1.GetEachRecordFromBatch(__ctx1__.__sRecordNamesOfBatch, 1);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.__record_1 = __ctx1__.__objBTHelper_1.GetRecordID(__ctx1__.__record_1);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__async_logger1.LogInfoAsync(__ctx1__.__record_1, "Log Set");
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__verifyLock_1 = __ctx1__.__objBTHelper_1.VerifyStageLock(__ctx1__.__record_1, __ctx1__.__sXprotID);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                __condition__ = __ctx1__.__record_1 != System.String.Empty && __ctx1__.__verifyLock_1;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 56 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 56;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                {
                    __messagetype_RB_ROCustomerInterfaceExport_Schemas_RO_Extract_RQ1Extract __RQ1Extract1 = new __messagetype_RB_ROCustomerInterfaceExport_Schemas_RO_Extract_RQ1Extract("RQ1Extract1", __ctx1__);

                    System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "Processing the records : " + __ctx1__.__record_1);
                    __RQ1Extract1.part.LoadFrom(__ctx1__.__objBTHelper_1.CreateRQ1DataExtractFile(__ctx1__.__record_1, __ctx1__.__sXprotID, __ctx1__.__sSystem, __ctx1__.__sInterfaceName, __ctx1__.__async_logger1, __ctx1__.__manager));
                    __RQ1Extract1.part.LoadFrom(__ctx1__.__objBTHelper_1.PrettyXml(__RQ1Extract1.part.TypedValue, __ctx1__.__record_1, __ctx1__.__async_logger1, __ctx1__.__manager));
                    __ctx1__.__sRecord_id1 = __ctx1__.__record_1.Substring(0, __ctx1__.__record_1.IndexOf(":"));
                    __RQ1Extract1.SetPropertyValue(typeof(FILE.ReceivedFileName), __ctx1__.__sSystem + "_" + __ctx1__.__sXprotID + "_030_" + __ctx1__.__sRecord_id1 + "_RQ1_Extract");
                    System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "RQ1 Extract File Created = " + (System.String)__RQ1Extract1.GetPropertyValueThrows(typeof(FILE.ReceivedFileName)));

                    if (__ctx1__.__RQ1Extract1 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__RQ1Extract1);
                    __ctx1__.__RQ1Extract1 = __RQ1Extract1;
                    __ctx1__.RefMessage(__ctx1__.__RQ1Extract1);
                }
                __ctx1__.__RQ1Extract1.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__RQ1Extract1);
                    Tracker.FireEvent(__eventLocations[12],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                __condition__ = !__ctx1__.__objBTHelper_1.VerifyTokenOfRecord(__ctx1__.__sRecord_id1, __ctx1__.__manager);
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 54 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 54;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                snd_RQ1Extract.SendMessage(0, __ctx1__.__RQ1Extract1, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__RQ1Extract1);
                    __edata.PortName = @"snd_RQ1Extract";
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                {
                    __messagetype_RB_ROCustomerInterfaceExport_Schemas_Export_IMF_Export_IMF __EXPORT_IMF1 = new __messagetype_RB_ROCustomerInterfaceExport_Schemas_Export_IMF_Export_IMF("EXPORT_IMF1", __ctx1__);

                    ApplyTransform(typeof(RB.ROCustomerInterfaceExport.CreateIMF), new object[] {__EXPORT_IMF1.part}, new object[] {__ctx1__.__RQ1Extract1.part});
                    __EXPORT_IMF1.SetPropertyValue(typeof(FILE.ReceivedFileName), __ctx1__.__sSystem + "_" + __ctx1__.__sXprotID + "_030_" + __ctx1__.__sRecord_id1 + "IMF_Before_Validate");
                    __EXPORT_IMF1.part.LoadFrom(__ctx1__.__objBTHelper_1.PrettyXml(__EXPORT_IMF1.part.TypedValue, __ctx1__.__record_1, __ctx1__.__async_logger1, __ctx1__.__manager));

                    if (__ctx1__.__EXPORT_IMF1 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__EXPORT_IMF1);
                    __ctx1__.__EXPORT_IMF1 = __EXPORT_IMF1;
                    __ctx1__.RefMessage(__ctx1__.__EXPORT_IMF1);
                }
                __ctx1__.__EXPORT_IMF1.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__EXPORT_IMF1);
                    __edata.Messages.Add(__ctx1__.__RQ1Extract1);
                    Tracker.FireEvent(__eventLocations[17],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                snd_ExportIMF_BeforeValidate.SendMessage(0, __ctx1__.__EXPORT_IMF1, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__EXPORT_IMF1);
                    __edata.PortName = @"snd_ExportIMF_BeforeValidate";
                    Tracker.FireEvent(__eventLocations[19],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "Validation started for " + __ctx1__.__record_1);
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                __ctx1__.__is_validate = __ctx1__.__objBTHelper_1.ValidateRQ1ExtractFile(__ctx1__.__RQ1Extract1.part.TypedValue, __ctx1__.__record_1, __ctx1__.__async_logger1, __ctx1__.__manager);
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                __condition__ = __ctx1__.__is_validate;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 53 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 53;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[23],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                {
                    __messagetype_RB_ROCustomerInterfaceExport_Schemas_Export_IMF_Export_IMF __EXPORT_IMF1 = new __messagetype_RB_ROCustomerInterfaceExport_Schemas_Export_IMF_Export_IMF("EXPORT_IMF1", __ctx1__);

                    ApplyTransform(typeof(RB.ROCustomerInterfaceExport.CreateIMF), new object[] {__EXPORT_IMF1.part}, new object[] {__ctx1__.__RQ1Extract1.part});
                    __EXPORT_IMF1.part.LoadFrom(__ctx1__.__objBTHelper_1.PrettyXml(__EXPORT_IMF1.part.TypedValue, __ctx1__.__record_1, __ctx1__.__async_logger1, __ctx1__.__manager));
                    __EXPORT_IMF1.part.LoadFrom(__ctx1__.__objBTHelper_1.UpdateIMFAfterValidation(__ctx1__.__RQ1Extract1.part.TypedValue, __EXPORT_IMF1.part.TypedValue, __ctx1__.__record_1, __ctx1__.__sXprotID, __ctx1__.__manager));
                    __EXPORT_IMF1.SetPropertyValue(typeof(FILE.ReceivedFileName), __ctx1__.__sSystem + "_" + __ctx1__.__sXprotID + "_030_" + __ctx1__.__sRecord_id1 + "IMF_After_Validate");
                    System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "Validation Success for " + __ctx1__.__record_1);
                    System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "After Validate File Created = " + (System.String)__EXPORT_IMF1.GetPropertyValueThrows(typeof(FILE.ReceivedFileName)));

                    if (__ctx1__.__EXPORT_IMF1 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__EXPORT_IMF1);
                    __ctx1__.__EXPORT_IMF1 = __EXPORT_IMF1;
                    __ctx1__.RefMessage(__ctx1__.__EXPORT_IMF1);
                }
                __ctx1__.__EXPORT_IMF1.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__EXPORT_IMF1);
                    __edata.Messages.Add(__ctx1__.__RQ1Extract1);
                    Tracker.FireEvent(__eventLocations[24],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[25],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                snd_ExportIMF_AfterValidate.SendMessage(0, __ctx1__.__EXPORT_IMF1, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 37;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__EXPORT_IMF1);
                    __edata.PortName = @"snd_ExportIMF_AfterValidate";
                    Tracker.FireEvent(__eventLocations[26],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 38;
            case 38:
                if ( !PreProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[27],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 39;
            case 39:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "Creating ASAM File");
                if ( !PostProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 40;
            case 40:
                if ( !PreProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[28],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 41;
            case 41:
                __ctx1__.__asam_file = __ctx1__.__objBTHelper_1.CreateASAMFile(__ctx1__.__RQ1Extract1.part.TypedValue, __ctx1__.__record_1, __ctx1__.__sXprotID, __ctx1__.__sSystem, __ctx1__.__sInterfaceName, __ctx1__.__async_logger1, __ctx1__.__manager);
                if ( !PostProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 42;
            case 42:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "ASAM File Generated = " + __ctx1__.__asam_file);
                if ( !PostProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 43;
            case 43:
                if ( !PreProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[29],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 44;
            case 44:
                __condition__ = __ctx1__.__asam_file != "" && __ctx1__.__asam_file != null;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 52 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 52;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 45;
            case 45:
                __ctx1__.__isUpdated = __ctx1__.__objBTHelper_1.UpdateRecords(__ctx1__.__EXPORT_IMF1.part.TypedValue, __ctx1__.__record_1, __ctx1__.__sXprotID, __ctx1__.__sSystem, __ctx1__.__sInterfaceName, __ctx1__.__async_logger1, __ctx1__.__manager);
                if ( !PostProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 46;
            case 46:
                if ( !PreProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 47;
            case 47:
                __condition__ = __ctx1__.__isUpdated;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 50 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 50;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 48;
            case 48:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", __ctx1__.__record_1 + " Update Successful");
                if ( !PostProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 49;
            case 49:
                if ( !PostProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 51;
            case 50:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", __ctx1__.__record_1 + " Update Failure");
                if ( !PostProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 51;
            case 51:
                if ( !PreProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 52;
            case 52:
                if ( !PreProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[30],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 53;
            case 53:
                if ( !PreProgressInc( __seg__, __ctx__, 54 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__EXPORT_IMF1 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EXPORT_IMF1);
                    __ctx1__.__EXPORT_IMF1 = null;
                }
                Tracker.FireEvent(__eventLocations[31],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 54;
            case 54:
                if ( !PreProgressInc( __seg__, __ctx__, 55 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__RQ1Extract1 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RQ1Extract1);
                    __ctx1__.__RQ1Extract1 = null;
                }
                Tracker.FireEvent(__eventLocations[32],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 55;
            case 55:
                if ( !PostProgressInc( __seg__, __ctx__, 63 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 63;
            case 56:
                if ( !PreProgressInc( __seg__, __ctx__, 57 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[33],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 57;
            case 57:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "Process Ends : " + __ctx1__.__record_1);
                if ( !PostProgressInc( __seg__, __ctx__, 58 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 58;
            case 58:
                if ( !PreProgressInc( __seg__, __ctx__, 59 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[34],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 59;
            case 59:
                if ( !PreProgressInc( __seg__, __ctx__, 60 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 60;
            case 60:
                __condition__ = !__ctx1__.__verifyLock_1;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 62 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 62;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 61 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 61;
            case 61:
                __ctx1__.__objBTHelper_1.UpdateTokenManager(__ctx1__.__record_1, __ctx1__.__sXprotID, __ctx1__.__manager);
                if ( !PostProgressInc( __seg__, __ctx__, 62 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 62;
            case 62:
                if ( !PreProgressInc( __seg__, __ctx__, 63 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 63;
            case 63:
                if ( !PreProgressInc( __seg__, __ctx__, 64 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__async_logger1 = null;
                Tracker.FireEvent(__eventLocations[35],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 64;
            case 64:
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
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __ValidateandExecute_1 __ctx1__ = (__ValidateandExecute_1)_stateMgrs[1];
            __ValidateandExecute_root_0 __ctx0__ = (__ValidateandExecute_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                if ( !PreProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[36],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 1;
            case 1:
                __ctx1__.__async_logger2 = new RB.ROCustomerInterfaceExportLibrary.AsyncLogger(__ctx1__.__sConfigPath, __ctx1__.__sXprotID);
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[37],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__record_2 = __ctx1__.__objBTHelper_2.GetEachRecordFromBatch(__ctx1__.__sRecordNamesOfBatch, 2);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.__record_2 = __ctx1__.__objBTHelper_2.GetRecordID(__ctx1__.__record_2);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__async_logger2.LogInfoAsync(__ctx1__.__record_2, "Log Set");
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__verifyLock_2 = __ctx1__.__objBTHelper_2.VerifyStageLock(__ctx1__.__record_2, __ctx1__.__sXprotID);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[40],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                __condition__ = __ctx1__.__record_2 != System.String.Empty && __ctx1__.__verifyLock_2;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 56 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 56;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[41],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                {
                    __messagetype_RB_ROCustomerInterfaceExport_Schemas_RO_Extract_RQ1Extract __RQ1Extract2 = new __messagetype_RB_ROCustomerInterfaceExport_Schemas_RO_Extract_RQ1Extract("RQ1Extract2", __ctx1__);

                    System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "Processing the records : " + __ctx1__.__record_2);
                    __RQ1Extract2.part.LoadFrom(__ctx1__.__objBTHelper_2.CreateRQ1DataExtractFile(__ctx1__.__record_2, __ctx1__.__sXprotID, __ctx1__.__sSystem, __ctx1__.__sInterfaceName, __ctx1__.__async_logger2, __ctx1__.__manager));
                    __RQ1Extract2.part.LoadFrom(__ctx1__.__objBTHelper_2.PrettyXml(__RQ1Extract2.part.TypedValue, __ctx1__.__record_2, __ctx1__.__async_logger2, __ctx1__.__manager));
                    __ctx1__.__sRecord_id2 = __ctx1__.__record_2.Substring(0, __ctx1__.__record_2.IndexOf(":"));
                    __RQ1Extract2.SetPropertyValue(typeof(FILE.ReceivedFileName), __ctx1__.__sSystem + "_" + __ctx1__.__sXprotID + "_030_" + __ctx1__.__sRecord_id2 + "_RQ1_Extract");
                    System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "RQ1 Extract File Created = " + (System.String)__RQ1Extract2.GetPropertyValueThrows(typeof(FILE.ReceivedFileName)));

                    if (__ctx1__.__RQ1Extract2 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__RQ1Extract2);
                    __ctx1__.__RQ1Extract2 = __RQ1Extract2;
                    __ctx1__.RefMessage(__ctx1__.__RQ1Extract2);
                }
                __ctx1__.__RQ1Extract2.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__RQ1Extract2);
                    Tracker.FireEvent(__eventLocations[42],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[43],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                __condition__ = !__ctx1__.__objBTHelper_2.VerifyTokenOfRecord(__ctx1__.__sRecord_id2, __ctx1__.__manager);
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 54 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 54;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[44],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                snd_RQ1Extract.SendMessage(0, __ctx1__.__RQ1Extract2, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__RQ1Extract2);
                    __edata.PortName = @"snd_RQ1Extract";
                    Tracker.FireEvent(__eventLocations[45],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[46],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                {
                    __messagetype_RB_ROCustomerInterfaceExport_Schemas_Export_IMF_Export_IMF __EXPORT_IMF2 = new __messagetype_RB_ROCustomerInterfaceExport_Schemas_Export_IMF_Export_IMF("EXPORT_IMF2", __ctx1__);

                    ApplyTransform(typeof(RB.ROCustomerInterfaceExport.CreateIMF), new object[] {__EXPORT_IMF2.part}, new object[] {__ctx1__.__RQ1Extract2.part});
                    __EXPORT_IMF2.SetPropertyValue(typeof(FILE.ReceivedFileName), __ctx1__.__sSystem + "_" + __ctx1__.__sXprotID + "_030_" + __ctx1__.__sRecord_id2 + "IMF_Before_Validate");
                    __EXPORT_IMF2.part.LoadFrom(__ctx1__.__objBTHelper_2.PrettyXml(__EXPORT_IMF2.part.TypedValue, __ctx1__.__record_2, __ctx1__.__async_logger2, __ctx1__.__manager));

                    if (__ctx1__.__EXPORT_IMF2 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__EXPORT_IMF2);
                    __ctx1__.__EXPORT_IMF2 = __EXPORT_IMF2;
                    __ctx1__.RefMessage(__ctx1__.__EXPORT_IMF2);
                }
                __ctx1__.__EXPORT_IMF2.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__EXPORT_IMF2);
                    __edata.Messages.Add(__ctx1__.__RQ1Extract2);
                    Tracker.FireEvent(__eventLocations[47],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[48],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                snd_ExportIMF_BeforeValidate.SendMessage(0, __ctx1__.__EXPORT_IMF2, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__EXPORT_IMF2);
                    __edata.PortName = @"snd_ExportIMF_BeforeValidate";
                    Tracker.FireEvent(__eventLocations[49],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[50],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "Validation started for " + __ctx1__.__record_2);
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[51],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                __ctx1__.__is_validate2 = __ctx1__.__objBTHelper_2.ValidateRQ1ExtractFile(__ctx1__.__RQ1Extract2.part.TypedValue, __ctx1__.__record_2, __ctx1__.__async_logger2, __ctx1__.__manager);
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[52],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                __condition__ = __ctx1__.__is_validate2;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 53 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 53;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[53],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                {
                    __messagetype_RB_ROCustomerInterfaceExport_Schemas_Export_IMF_Export_IMF __EXPORT_IMF2 = new __messagetype_RB_ROCustomerInterfaceExport_Schemas_Export_IMF_Export_IMF("EXPORT_IMF2", __ctx1__);

                    ApplyTransform(typeof(RB.ROCustomerInterfaceExport.CreateIMF), new object[] {__EXPORT_IMF2.part}, new object[] {__ctx1__.__RQ1Extract2.part});
                    __EXPORT_IMF2.part.LoadFrom(__ctx1__.__objBTHelper_2.PrettyXml(__EXPORT_IMF2.part.TypedValue, __ctx1__.__record_2, __ctx1__.__async_logger2, __ctx1__.__manager));
                    __EXPORT_IMF2.part.LoadFrom(__ctx1__.__objBTHelper_2.UpdateIMFAfterValidation(__ctx1__.__RQ1Extract2.part.TypedValue, __EXPORT_IMF2.part.TypedValue, __ctx1__.__record_2, __ctx1__.__sXprotID, __ctx1__.__manager));
                    __EXPORT_IMF2.SetPropertyValue(typeof(FILE.ReceivedFileName), __ctx1__.__sSystem + "_" + __ctx1__.__sXprotID + "_030_" + __ctx1__.__sRecord_id2 + "IMF_After_Validate");
                    System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "Validation Success for " + __ctx1__.__record_2);
                    System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "After Validate File Created = " + (System.String)__EXPORT_IMF2.GetPropertyValueThrows(typeof(FILE.ReceivedFileName)));

                    if (__ctx1__.__EXPORT_IMF2 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__EXPORT_IMF2);
                    __ctx1__.__EXPORT_IMF2 = __EXPORT_IMF2;
                    __ctx1__.RefMessage(__ctx1__.__EXPORT_IMF2);
                }
                __ctx1__.__EXPORT_IMF2.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__EXPORT_IMF2);
                    __edata.Messages.Add(__ctx1__.__RQ1Extract2);
                    Tracker.FireEvent(__eventLocations[54],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[55],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                snd_ExportIMF_AfterValidate.SendMessage(0, __ctx1__.__EXPORT_IMF2, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 37;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__EXPORT_IMF2);
                    __edata.PortName = @"snd_ExportIMF_AfterValidate";
                    Tracker.FireEvent(__eventLocations[56],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 38;
            case 38:
                if ( !PreProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[57],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 39;
            case 39:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "Creating ASAM File");
                if ( !PostProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 40;
            case 40:
                if ( !PreProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[58],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 41;
            case 41:
                __ctx1__.__asam_file2 = __ctx1__.__objBTHelper_2.CreateASAMFile(__ctx1__.__RQ1Extract2.part.TypedValue, __ctx1__.__record_2, __ctx1__.__sXprotID, __ctx1__.__sSystem, __ctx1__.__sInterfaceName, __ctx1__.__async_logger2, __ctx1__.__manager);
                if ( !PostProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 42;
            case 42:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "ASAM File Generated = " + __ctx1__.__asam_file2);
                if ( !PostProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 43;
            case 43:
                if ( !PreProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[59],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 44;
            case 44:
                __condition__ = __ctx1__.__asam_file2 != "" && __ctx1__.__asam_file2 != null;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 52 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 52;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 45;
            case 45:
                __ctx1__.__isUpdated_2 = __ctx1__.__objBTHelper_2.UpdateRecords(__ctx1__.__EXPORT_IMF2.part.TypedValue, __ctx1__.__record_2, __ctx1__.__sXprotID, __ctx1__.__sSystem, __ctx1__.__sInterfaceName, __ctx1__.__async_logger2, __ctx1__.__manager);
                if ( !PostProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 46;
            case 46:
                if ( !PreProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[38],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 47;
            case 47:
                __condition__ = __ctx1__.__isUpdated_2;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 50 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 50;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 48;
            case 48:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", __ctx1__.__record_2 + " Update Successful");
                if ( !PostProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 49;
            case 49:
                if ( !PostProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 51;
            case 50:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", __ctx1__.__record_2 + " Update Failure");
                if ( !PostProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 51;
            case 51:
                if ( !PreProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[39],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 52;
            case 52:
                if ( !PreProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[60],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 53;
            case 53:
                if ( !PreProgressInc( __seg__, __ctx__, 54 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__EXPORT_IMF2 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EXPORT_IMF2);
                    __ctx1__.__EXPORT_IMF2 = null;
                }
                Tracker.FireEvent(__eventLocations[61],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 54;
            case 54:
                if ( !PreProgressInc( __seg__, __ctx__, 55 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__RQ1Extract2 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__RQ1Extract2);
                    __ctx1__.__RQ1Extract2 = null;
                }
                Tracker.FireEvent(__eventLocations[62],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 55;
            case 55:
                if ( !PostProgressInc( __seg__, __ctx__, 63 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 63;
            case 56:
                if ( !PreProgressInc( __seg__, __ctx__, 57 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[63],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 57;
            case 57:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "Process Ends : " + __ctx1__.__record_2);
                if ( !PostProgressInc( __seg__, __ctx__, 58 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 58;
            case 58:
                if ( !PreProgressInc( __seg__, __ctx__, 59 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[64],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 59;
            case 59:
                if ( !PreProgressInc( __seg__, __ctx__, 60 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[38],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 60;
            case 60:
                __condition__ = !__ctx1__.__verifyLock_2;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 62 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 62;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 61 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 61;
            case 61:
                __ctx1__.__objBTHelper_2.UpdateTokenManager(__ctx1__.__record_2, __ctx1__.__sXprotID, __ctx1__.__manager);
                if ( !PostProgressInc( __seg__, __ctx__, 62 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 62;
            case 62:
                if ( !PreProgressInc( __seg__, __ctx__, 63 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[39],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 63;
            case 63:
                if ( !PreProgressInc( __seg__, __ctx__, 64 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__async_logger2 = null;
                Tracker.FireEvent(__eventLocations[65],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 64;
            case 64:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment4(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[4];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __ValidateandExecute_1 __ctx1__ = (__ValidateandExecute_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                if ( !PreProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[66],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 1;
            case 1:
                __ctx1__.__async_logger3 = new RB.ROCustomerInterfaceExportLibrary.AsyncLogger(__ctx1__.__sConfigPath, __ctx1__.__sXprotID);
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[67],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__record_3 = __ctx1__.__objBTHelper_3.GetEachRecordFromBatch(__ctx1__.__sRecordNamesOfBatch, 3);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.__record_3 = __ctx1__.__objBTHelper_3.GetRecordID(__ctx1__.__record_3);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__async_logger3.LogInfoAsync(__ctx1__.__record_3, "Log Set");
                if (__ctx1__ != null)
                    __ctx1__.__async_logger3 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[70],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __condition__ = __ctx1__.__record_3 != System.String.Empty;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 12;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[71],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "Processing the records : " + __ctx1__.__record_3);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[72],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[73],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "Process Ends : " + __ctx1__.__record_3);
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                Tracker.FireEvent(__eventLocations[74],__eventData[3],_stateMgrs[1].TrackDataStream );
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[75],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment5(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[5];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __ValidateandExecute_1 __ctx1__ = (__ValidateandExecute_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                if ( !PreProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[76],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 1;
            case 1:
                __ctx1__.__async_logger4 = new RB.ROCustomerInterfaceExportLibrary.AsyncLogger(__ctx1__.__sConfigPath, __ctx1__.__sXprotID);
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[77],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__record_4 = __ctx1__.__objBTHelper_4.GetEachRecordFromBatch(__ctx1__.__sRecordNamesOfBatch, 4);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.__record_4 = __ctx1__.__objBTHelper_4.GetRecordID(__ctx1__.__record_4);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__async_logger4.LogInfoAsync(__ctx1__.__record_4, "Log Set");
                if (__ctx1__ != null)
                    __ctx1__.__async_logger4 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[80],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __condition__ = __ctx1__.__record_4 != System.String.Empty;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 12;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[81],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "Processing the records : " + __ctx1__.__record_4);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[82],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[83],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "Process Ends : " + __ctx1__.__record_4);
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                Tracker.FireEvent(__eventLocations[84],__eventData[3],_stateMgrs[1].TrackDataStream );
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[85],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment6(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[6];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __ValidateandExecute_1 __ctx1__ = (__ValidateandExecute_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                if ( !PreProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[86],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 1;
            case 1:
                __ctx1__.__async_logger5 = new RB.ROCustomerInterfaceExportLibrary.AsyncLogger(__ctx1__.__sConfigPath, __ctx1__.__sXprotID);
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[87],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__record_5 = __ctx1__.__objBTHelper_5.GetEachRecordFromBatch(__ctx1__.__sRecordNamesOfBatch, 5);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.__record_5 = __ctx1__.__objBTHelper_5.GetRecordID(__ctx1__.__record_5);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__async_logger5.LogInfoAsync(__ctx1__.__record_5, "Log Set");
                if (__ctx1__ != null)
                    __ctx1__.__async_logger5 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[90],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __condition__ = __ctx1__.__record_5 != System.String.Empty;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 12;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[91],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "Processing the records : " + __ctx1__.__record_5);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[92],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[93],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                System.Diagnostics.EventLog.WriteEntry("ROINTERFACE_Export", "Process Ends : " + __ctx1__.__record_5);
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                Tracker.FireEvent(__eventLocations[94],__eventData[3],_stateMgrs[1].TrackDataStream );
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[95],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __RB_ROCustomerInterfaceExport_Schemas_Transfer_TransferResultInformation__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static RB.ROCustomerInterfaceExport.Schemas.Transfer.TransferResultInformation _schema = new RB.ROCustomerInterfaceExport.Schemas.Transfer.TransferResultInformation();

        public __RB_ROCustomerInterfaceExport_Schemas_Transfer_TransferResultInformation__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "RB.ROCustomerInterfaceExport.Schemas.Transfer.TransferResultInformation",
        new System.Type[]{
            typeof(RB.ROCustomerInterfaceExport.Schemas.Transfer.TransferResultInformation)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__RB_ROCustomerInterfaceExport_Schemas_Transfer_TransferResultInformation__)
        },
        0,
        @"http://FTPIssueTransfer.FTPFileInformation#TransferResult"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_RB_ROCustomerInterfaceExport_Schemas_Transfer_TransferResultInformation : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __RB_ROCustomerInterfaceExport_Schemas_Transfer_TransferResultInformation__ part;

        private void __CreatePartWrappers()
        {
            part = new __RB_ROCustomerInterfaceExport_Schemas_Transfer_TransferResultInformation__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_RB_ROCustomerInterfaceExport_Schemas_Transfer_TransferResultInformation(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __RB_ROCustomerInterfaceExport_Schemas_RO_Extract_RQ1Extract__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static RB.ROCustomerInterfaceExport.Schemas.RO_Extract.RQ1Extract _schema = new RB.ROCustomerInterfaceExport.Schemas.RO_Extract.RQ1Extract();

        public __RB_ROCustomerInterfaceExport_Schemas_RO_Extract_RQ1Extract__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "RB.ROCustomerInterfaceExport.Schemas.RO_Extract.RQ1Extract",
        new System.Type[]{
            typeof(RB.ROCustomerInterfaceExport.Schemas.RO_Extract.RQ1Extract)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__RB_ROCustomerInterfaceExport_Schemas_RO_Extract_RQ1Extract__)
        },
        0,
        @"RQ1_EXTRACT"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_RB_ROCustomerInterfaceExport_Schemas_RO_Extract_RQ1Extract : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __RB_ROCustomerInterfaceExport_Schemas_RO_Extract_RQ1Extract__ part;

        private void __CreatePartWrappers()
        {
            part = new __RB_ROCustomerInterfaceExport_Schemas_RO_Extract_RQ1Extract__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_RB_ROCustomerInterfaceExport_Schemas_RO_Extract_RQ1Extract(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
