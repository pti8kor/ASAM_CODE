
#pragma warning disable 162

namespace FTPGetNames_Project
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(FTPGetNames_Project.__messagetype_FTPGetNames_Project_FTPGetNamesSchema), 
            typeof(FTPGetNames_Project.__messagetype_FTPGetNames_Project_FTPGetNamesSchema)
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
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(PortType_1),
            typeof(__messagetype_FTPGetNames_Project_FTPGetNamesSchema),
            typeof(__messagetype_FTPGetNames_Project_FTPGetNamesSchema),
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
            typeof(FTPGetNames_Project.__messagetype_FTPGetNames_Project_FTPGetNamesSchema)
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
            typeof(__messagetype_FTPGetNames_Project_FTPGetNamesSchema),
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
    //#line 242 "D:\RB-ASAM-Interface\Import\960 - Sources\RBAdmin_App2\FTPGetNames Project\FTPGetNames Project\FTPGetNames.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "RR_P", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        },
        new System.Type[] {
            typeof(FTPGetNames_Project.PortType_1)
        },
        new System.String[] {
            "RR_P"
        },
        new System.Type[] {
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
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone|Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eAtomic
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    [Microsoft.XLANGs.BaseTypes.TransactionAttribute(Retry = true, Batch = true, Timeout = 60, TranIsolationLevel = System.Data.IsolationLevel.Serializable)]
    sealed internal class FTPGetNames : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(FTPGetNames));
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

        static FTPGetNames()
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
            _rootContext = new __FTPGetNames_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public FTPGetNames(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "FTPGetNames", tracker)
        {
            ConstructorHelper();
        }

        public FTPGetNames(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "FTPGetNames")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>e9b70d9d-6b84-413c-87e2-de207833290c</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>7207a16f-61ae-4f16-a373-9062e1b539ff</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>6e18c5e4-f6a9-474d-87ec-d30d45838af3</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>SetLogger</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>b83220af-db08-4551-b45e-21ba07e71944</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>d4f93c1b-4d6b-4a3e-bd3b-2ee54ae44aca</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>512c97f8-f877-4646-ad49-6ddb21170747</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>e09fb6b7-c22f-40ac-88a8-8323bbadd6ee</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>CloseLogger</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>29065c64-7161-4de9-b46d-2d5b83d67e23</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'FTPGetNames'</ActionName><IsAtomic>1</IsAtomic><Line>242</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>257</Line><Position>22</Position><ShapeID>'7207a16f-61ae-4f16-a373-9062e1b539ff'</ShapeID>
<Messages>
	<MsgInfo><name>Message_1</name><part>part</part><schema>FTPGetNames_Project.FTPGetNamesSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>263</Line><Position>24</Position><ShapeID>'6e18c5e4-f6a9-474d-87ec-d30d45838af3'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>265</Line><Position>13</Position><ShapeID>'b83220af-db08-4551-b45e-21ba07e71944'</ShapeID>
<Messages>
	<MsgInfo><name>Message_2</name><part>part</part><schema>FTPGetNames_Project.FTPGetNamesSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>294</Line><Position>35</Position><ShapeID>'e09fb6b7-c22f-40ac-88a8-8323bbadd6ee'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>298</Line><Position>13</Position><ShapeID>'29065c64-7161-4de9-b46d-2d5b83d67e23'</ShapeID>
<Messages>
	<MsgInfo><name>Message_2</name><part>part</part><schema>FTPGetNames_Project.FTPGetNamesSchema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='cc25b36b-93c9-48a2-8ab1-4fa7da5ebc0d' LowerBound='1.1' HigherBound='80.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='FTPGetNames_Project' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='b84e6e97-48f2-4542-aa1f-e05605cfae0f' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='cc2c6726-0150-4360-b57d-f77d6c98c040' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='63e11852-9e61-47da-ad78-f072829a3f31' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.30'>
                    <om:Property Name='Ref' Value='FTPGetNames_Project.FTPGetNamesSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='6338a1f0-fb54-4d06-be9d-41e011d57c31' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='8.32' HigherBound='8.49'>
                    <om:Property Name='Ref' Value='FTPGetNames_Project.FTPGetNamesSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='1b4ac3dd-205b-443f-a0f2-c4fb6eac8630' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_2' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='56a82ad0-31c3-4f4b-8c81-beb4ac220b36' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='e6fd3247-5446-4bd7-aabf-7f11fe70a886' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.30'>
                    <om:Property Name='Ref' Value='FTPGetNames_Project.FTPGetNamesSchema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='6c23a822-075b-44d8-8d1c-d681d4cf5135' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='79.1'>
            <om:Property Name='InitializedTransactionType' Value='True' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='FTPGetNames' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='93fa74ed-1bee-43e8-9280-200c0440c833' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FileList' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3eed3621-cda2-4af6-82ba-a44a31d02170' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tmpStr' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='a5350e0d-231a-4f4c-bda1-effa4117964c' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='RB.FTPLibrary.FTPHandler' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='FTPHandler1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3bd183c2-180b-40a5-af23-6e67a9fb0b1a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TargetSystem' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='03ad31a7-f828-49ae-977d-3b477f2c6642' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='RB.BTLoggerLibrary.BTLogger' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ROBTLogger' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='2c5e6e95-c922-46d3-8329-969e8767d177' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='31.1' HigherBound='32.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='RB.BTLoggerLibrary.Logger' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ROLogger' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='AtomicTransaction' OID='7b8f8410-707e-44c8-bd45-c057c6526522' ParentLink='ServiceDeclaration_Transaction' LowerBound='20.21' HigherBound='20.40'>
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Transaction_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
            <om:Element Type='TransactionAttribute' OID='269e0d64-0d12-4305-b653-66aaa3e5d4b5' ParentLink='ServiceDeclaration_CLRAttribute' LowerBound='19.1' HigherBound='20.1'>
                <om:Property Name='Batch' Value='True' />
                <om:Property Name='Retry' Value='True' />
                <om:Property Name='Timeout' Value='60' />
                <om:Property Name='Isolation' Value='Serializable' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='38027366-e484-4910-beaf-91aab5040368' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='24.1' HigherBound='25.1'>
                <om:Property Name='Type' Value='FTPGetNames_Project.FTPGetNamesSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Message_1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='e24222e8-f5d0-4ae6-abeb-cc707fa96dc8' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='FTPGetNames_Project.FTPGetNamesSchema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Message_2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='e9b70d9d-6b84-413c-87e2-de207833290c' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='7207a16f-61ae-4f16-a373-9062e1b539ff' ParentLink='ServiceBody_Statement' LowerBound='34.1' HigherBound='40.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='RR_P' />
                    <om:Property Name='MessageName' Value='Message_1' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='6e18c5e4-f6a9-474d-87ec-d30d45838af3' ParentLink='ServiceBody_Statement' LowerBound='40.1' HigherBound='42.1'>
                    <om:Property Name='Expression' Value=' ROLogger  = ROBTLogger.GetLogger(Message_1.InterfaceName,Message_1.XProtID);' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SetLogger' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='Construct' OID='b83220af-db08-4551-b45e-21ba07e71944' ParentLink='ServiceBody_Statement' LowerBound='42.1' HigherBound='71.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_2' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='MessageAssignment' OID='d4f93c1b-4d6b-4a3e-bd3b-2ee54ae44aca' ParentLink='ComplexStatement_Statement' LowerBound='45.1' HigherBound='70.1'>
                        <om:Property Name='Expression' Value='     Message_2 = Message_1;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;    //Exception-Handling missing ...&#xD;&#xA;&#xD;&#xA;    tmpStr = System.Convert.ToString(Message_1.InterfaceName);&#xD;&#xA;    TargetSystem = System.Convert.ToString(Message_1.RQ1System);&#xD;&#xA;    &#xD;&#xA;    FTPHandler1 = new RB.FTPLibrary.FTPHandler(tmpStr, TargetSystem);     &#xD;&#xA;   &#xD;&#xA;     ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPGetNames : &quot; + &quot;FTP testing--&gt;Handler= &quot; + FTPHandler1.FTPHandlerValid.ToString(), ROLogger);  &#xD;&#xA;    FileList = FTPHandler1.FTPDirectoryList();&#xD;&#xA;&#xD;&#xA;    Message_2.FTPFileNames = FileList;&#xD;&#xA;&#xD;&#xA;    ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPGetNames : &quot; + &quot;FTP directory listing -&gt; &quot; + FileList, ROLogger);  &#xD;&#xA;&#xD;&#xA;    ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPGetNames : &quot; + &quot;InterfaceName -&gt; &quot; + tmpStr, ROLogger);&#xD;&#xA;&#xD;&#xA;    ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPGetNames : &quot; + &quot;XPROT ID -&gt; &quot; + System.Convert.ToString(Message_1.XProtID),&#xD;&#xA;    ROLogger);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;    // no log in XProt necessary because this routine is only for choicelist value generation' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='MessageAssignment_2' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='512c97f8-f877-4646-ad49-6ddb21170747' ParentLink='Construct_MessageRef' LowerBound='43.23' HigherBound='43.32'>
                        <om:Property Name='Ref' Value='Message_2' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='VariableAssignment' OID='e09fb6b7-c22f-40ac-88a8-8323bbadd6ee' ParentLink='ServiceBody_Statement' LowerBound='71.1' HigherBound='75.1'>
                    <om:Property Name='Expression' Value='ROBTLogger.CloseLogger(ROLogger);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='CloseLogger' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='29065c64-7161-4de9-b46d-2d5b83d67e23' ParentLink='ServiceBody_Statement' LowerBound='75.1' HigherBound='77.1'>
                    <om:Property Name='PortName' Value='RR_P' />
                    <om:Property Name='MessageName' Value='Message_2' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='6dad2968-f989-4e07-b7ff-33e2a8e4721c' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='22.1' HigherBound='24.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='FTPGetNames_Project.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='RR_P' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='7e469ffd-8850-47b7-b352-76b5035818d8' ParentLink='PortDeclaration_CLRAttribute' LowerBound='22.1' HigherBound='23.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
    <om:Element Type='PrintElement' OID='451ac60c-6ce7-4cd2-8582-500fa5843dd3'>
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
        <om:Property Name='Scaling' Value='100' />
        <om:Property Name='Top' Value='79' />
        <om:Property Name='Orientation' Value='Portrait' />
        <om:Property Name='Signal' Value='False' />
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __FTPGetNames_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __FTPGetNames_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "FTPGetNames")
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
                FTPGetNames __svc__ = (FTPGetNames)_service;
                __FTPGetNames_root_0 __ctx0__ = (__FTPGetNames_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.RR_P != null)
                {
                    __svc__.RR_P.Close(this, null);
                    __svc__.RR_P = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __FTPGetNames_1 : Microsoft.XLANGs.Core.AtomicTransaction
        {
            public __FTPGetNames_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "FTPGetNames")
            {
                Retry = true;
                Batch = true;
                Timeout = 60;
                TranIsolationLevel = System.Data.IsolationLevel.Serializable;
            }

            public override int Index { get { return 1; } }

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
                FTPGetNames __svc__ = (FTPGetNames)_service;
                __FTPGetNames_1 __ctx1__ = (__FTPGetNames_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__tmpStr = null;
                if (__ctx1__ != null)
                    __ctx1__.__ROBTLogger = null;
                if (__ctx1__ != null)
                    __ctx1__.__TargetSystem = null;
                if (__ctx1__ != null)
                    __ctx1__.__ROLogger = null;
                if (__ctx1__ != null && __ctx1__.__Message_1 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Message_1);
                    __ctx1__.__Message_1 = null;
                }
                if (__ctx1__ != null && __ctx1__.__Message_2 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Message_2);
                    __ctx1__.__Message_2 = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__FTPHandler1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__FileList = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Message_1")]
            public __messagetype_FTPGetNames_Project_FTPGetNamesSchema __Message_1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Message_2")]
            public __messagetype_FTPGetNames_Project_FTPGetNamesSchema __Message_2;
            [Microsoft.XLANGs.Core.UserVariableAttribute("FileList")]
            internal System.String __FileList;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tmpStr")]
            internal System.String __tmpStr;
            [Microsoft.XLANGs.Core.UserVariableAttribute("FTPHandler1")]
            internal RB.FTPLibrary.FTPHandler __FTPHandler1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TargetSystem")]
            internal System.String __TargetSystem;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ROBTLogger")]
            internal RB.BTLoggerLibrary.BTLogger __ROBTLogger;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ROLogger")]
            internal RB.BTLoggerLibrary.Logger __ROLogger;
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
        internal PortType_1 RR_P;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_1.Operation_1},
                                               typeof(FTPGetNames).GetField("RR_P", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(FTPGetNames), "RR_P"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "7207a16f-61ae-4f16-a373-9062e1b539ff", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "7207a16f-61ae-4f16-a373-9062e1b539ff", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "6e18c5e4-f6a9-474d-87ec-d30d45838af3", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "6e18c5e4-f6a9-474d-87ec-d30d45838af3", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "b83220af-db08-4551-b45e-21ba07e71944", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "b83220af-db08-4551-b45e-21ba07e71944", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "e09fb6b7-c22f-40ac-88a8-8323bbadd6ee", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "e09fb6b7-c22f-40ac-88a8-8323bbadd6ee", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "29065c64-7161-4de9-b46d-2d5b83d67e23", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "29065c64-7161-4de9-b46d-2d5b83d67e23", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,4,4,5,6,6,7,8,8,9,10,10,10,11,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __FTPGetNames_root_0 __ctx0__ = (__FTPGetNames_root_0)_stateMgrs[0];
            __FTPGetNames_1 __ctx1__ = (__FTPGetNames_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                RR_P = new PortType_1(0, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], RR_P, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __FTPGetNames_1(this);
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
                if (RR_P != null)
                {
                    RR_P.Close(__ctx0__, __seg__);
                    RR_P = null;
                }
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
            __FTPGetNames_root_0 __ctx0__ = (__FTPGetNames_root_0)_stateMgrs[0];
            __FTPGetNames_1 __ctx1__ = (__FTPGetNames_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__FileList = default(System.String);
                __ctx1__.__tmpStr = default(System.String);
                __ctx1__.__FTPHandler1 = default(RB.FTPLibrary.FTPHandler);
                __ctx1__.__TargetSystem = default(System.String);
                __ctx1__.__ROBTLogger = default(RB.BTLoggerLibrary.BTLogger);
                __ctx1__.__ROLogger = default(RB.BTLoggerLibrary.Logger);
                __ctx1__.__Message_1 = null;
                __ctx1__.__Message_2 = null;
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
                __ctx1__.__Message_1 = new __messagetype_FTPGetNames_Project_FTPGetNamesSchema("Message_1", __ctx1__);
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
                __ctx1__.__FileList = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__tmpStr = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__TargetSystem = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__ROBTLogger = new RB.BTLoggerLibrary.BTLogger();
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __ctx1__.__ROLogger = __ctx1__.__ROBTLogger.GetLogger((System.String)__ctx1__.__Message_1.part.GetDistinguishedField("InterfaceName"), (System.String)__ctx1__.__Message_1.part.GetDistinguishedField("XProtID"));
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                {
                    __messagetype_FTPGetNames_Project_FTPGetNamesSchema __Message_2 = new __messagetype_FTPGetNames_Project_FTPGetNamesSchema("Message_2", __ctx1__);

                    __Message_2.CopyFrom(__ctx1__.__Message_1);
                    __ctx1__.__tmpStr = System.Convert.ToString((System.String)__ctx1__.__Message_1.part.GetDistinguishedField("InterfaceName"));
                    __ctx1__.__TargetSystem = System.Convert.ToString((System.String)__ctx1__.__Message_1.part.GetDistinguishedField("RQ1System"));
                    __ctx1__.__FTPHandler1 = new RB.FTPLibrary.FTPHandler(__ctx1__.__tmpStr, __ctx1__.__TargetSystem);
                    if (__ctx1__ != null)
                        __ctx1__.__TargetSystem = null;
                    __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPGetNames : " + "FTP testing-->Handler= " + __ctx1__.__FTPHandler1.FTPHandlerValid.ToString(), __ctx1__.__ROLogger);
                    __ctx1__.__FileList = __ctx1__.__FTPHandler1.FTPDirectoryList();
                    if (__ctx1__ != null)
                        __ctx1__.__FTPHandler1 = null;
                    __Message_2.part.SetDistinguishedField("FTPFileNames", __ctx1__.__FileList);
                    __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPGetNames : " + "FTP directory listing -> " + __ctx1__.__FileList, __ctx1__.__ROLogger);
                    if (__ctx1__ != null)
                        __ctx1__.__FileList = null;
                    __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPGetNames : " + "InterfaceName -> " + __ctx1__.__tmpStr, __ctx1__.__ROLogger);
                    if (__ctx1__ != null)
                        __ctx1__.__tmpStr = null;
                    __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPGetNames : " + "XPROT ID -> " + System.Convert.ToString((System.String)__ctx1__.__Message_1.part.GetDistinguishedField("XProtID")), __ctx1__.__ROLogger);
                    if (__ctx1__ != null && __ctx1__.__Message_1 != null)
                    {
                        __ctx1__.UnrefMessage(__ctx1__.__Message_1);
                        __ctx1__.__Message_1 = null;
                    }

                    if (__ctx1__.__Message_2 != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Message_2);
                    __ctx1__.__Message_2 = __Message_2;
                    __ctx1__.RefMessage(__ctx1__.__Message_2);
                }
                __ctx1__.__Message_2.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Message_2);
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                __ctx1__.__ROBTLogger.CloseLogger(__ctx1__.__ROLogger);
                if (__ctx1__ != null)
                    __ctx1__.__ROLogger = null;
                if (__ctx1__ != null)
                    __ctx1__.__ROBTLogger = null;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                RR_P.SendMessage(0, __ctx1__.__Message_2, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Message_2);
                    __edata.PortName = @"RR_P";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Message_2 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Message_2);
                    __ctx1__.__Message_2 = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 25;
            case 25:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __FTPGetNames_Project_FTPGetNamesSchema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static FTPGetNames_Project.FTPGetNamesSchema _schema = new FTPGetNames_Project.FTPGetNamesSchema();

        public __FTPGetNames_Project_FTPGetNamesSchema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "FTPGetNames_Project.FTPGetNamesSchema",
        new System.Type[]{
            typeof(FTPGetNames_Project.FTPGetNamesSchema)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__FTPGetNames_Project_FTPGetNamesSchema__)
        },
        0,
        @"http://FTPGetNames_Project.FTPGetNamesSchema#FTPRequest"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_FTPGetNames_Project_FTPGetNamesSchema : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __FTPGetNames_Project_FTPGetNamesSchema__ part;

        private void __CreatePartWrappers()
        {
            part = new __FTPGetNames_Project_FTPGetNamesSchema__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_FTPGetNames_Project_FTPGetNamesSchema(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
