
#pragma warning disable 162

namespace BTBinaryComparison
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(BTBinaryComparison.__messagetype_RB_BT_ROBinaryComparison_BinaryCompare)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Rec_BinCompPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Rec_BinCompPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Rec_BinCompPortType(Rec_BinCompPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Rec_BinCompPortType p = new Rec_BinCompPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Rec_BinCompPortType),
            typeof(__messagetype_RB_BT_ROBinaryComparison_BinaryCompare),
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
            typeof(BTBinaryComparison.__messagetype_RB_BT_ROBinaryComparison_BinaryCompare)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_Ident : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Ident(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Ident(PortType_Ident p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Ident p = new PortType_Ident(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_Ident),
            typeof(__messagetype_RB_BT_ROBinaryComparison_BinaryCompare),
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
            typeof(BTBinaryComparison.__messagetype_RB_BT_ROBinaryComparison_BinaryCompare)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_DIFF : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_DIFF(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_DIFF(PortType_DIFF p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_DIFF p = new PortType_DIFF(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_DIFF),
            typeof(__messagetype_RB_BT_ROBinaryComparison_BinaryCompare),
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
            typeof(BTBinaryComparison.__messagetype_RB_BT_ROBinaryComparison_BinaryCompare)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_ERROR : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_ERROR(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_ERROR(PortType_ERROR p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_ERROR p = new PortType_ERROR(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_ERROR),
            typeof(__messagetype_RB_BT_ROBinaryComparison_BinaryCompare),
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
    //#line 402 "D:\RB-ASAM-Interface\Import\960 - Sources\BT9RSI\960 - BTImportSoftware\BinaryComparison\BTBinaryComparison\BinaryComparisonOrchestration.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Prot_RCV", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(BTBinaryComparison.Rec_BinCompPortType),
            typeof(BTBinaryComparison.PortType_Ident),
            typeof(BTBinaryComparison.PortType_DIFF),
            typeof(BTBinaryComparison.PortType_ERROR)
        },
        new System.String[] {
            "Prot_RCV",
            "PORT_IDENTITIES",
            "PORT_DIFF",
            "PORT_ERROR"
        },
        new System.Type[] {
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
    sealed internal class BizTalk_Orchestration2 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(BizTalk_Orchestration2));
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

        static BizTalk_Orchestration2()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 2, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 2, 3)
            };

            _Locks = 0;
            _rootContext = new __BizTalk_Orchestration2_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public BizTalk_Orchestration2(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "BizTalk_Orchestration2", tracker)
        {
            ConstructorHelper();
        }

        public BizTalk_Orchestration2(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "BizTalk_Orchestration2")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>bb44d1b4-2746-4158-828a-07a2b3ae0c61</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>137d5bc1-7097-48b0-9224-cc2f14420f34</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>6e911921-72f5-4715-a493-77369053770d</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>f2c6f490-74e2-4b1f-944e-ff01d7d12ddb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>4c38a546-d752-439b-a225-1e72ab238181</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Decide_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>5e03980a-d107-4ef5-80f9-42995b0af043</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>a9247795-8645-49c7-9a80-2387fe48e557</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>d1992bda-1d0a-482b-9d3c-e91e54747a7f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>3494fe5a-8e53-4d7e-ba2b-3014918cc8f2</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>ee020a6c-92bc-478d-a79e-db242a339c2d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>e4042693-7cdb-4191-82b5-b5ee595e6b04</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>fe8bac55-1a29-4a63-adb6-dce27b452d27</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>f86e543b-a257-4416-bc51-235633556ecd</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>6e658e6d-a50d-4bbe-8e18-b503d40bec1d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>d308526d-00ef-4a8f-94cf-89c9f292e176</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>761f6ef9-54f9-48bf-91ca-d98a3be34982</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>89a7536f-697e-4c4a-baec-9294fa9c0057</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>091a86c7-4e95-42b9-8d61-5f3b0b1d569f</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>244901c3-bd07-413b-a974-9f517765d42c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>de71c02a-8a5b-4c5f-bf32-b28a2644ab20</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>a4965d2c-73d0-4095-ac09-d49128beed77</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_1</shapeText>                      <ExceptionType>General Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>ThrowShape</shapeType>      <ShapeID>97e239d9-8883-4417-8909-6dda86697480</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>ThrowException_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'BizTalk_Orchestration2'</ActionName><IsAtomic>0</IsAtomic><Line>402</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>424</Line><Position>22</Position><ShapeID>'137d5bc1-7097-48b0-9224-cc2f14420f34'</ShapeID>
<Messages>
	<MsgInfo><name>msgBinCompare</name><part>part</part><schema>RB.BT.ROBinaryComparison.BinaryCompare</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope33'</ActionName><IsAtomic>0</IsAtomic><Line>432</Line><Position>13</Position><ShapeID>'6e911921-72f5-4715-a493-77369053770d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>437</Line><Position>29</Position><ShapeID>'f2c6f490-74e2-4b1f-944e-ff01d7d12ddb'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>439</Line><Position>21</Position><ShapeID>'4c38a546-d752-439b-a225-1e72ab238181'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>442</Line><Position>25</Position><ShapeID>'a9247795-8645-49c7-9a80-2387fe48e557'</ShapeID>
<Messages>
	<MsgInfo><name>msgBinCompareCopy</name><part>part</part><schema>RB.BT.ROBinaryComparison.BinaryCompare</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>451</Line><Position>25</Position><ShapeID>'ee020a6c-92bc-478d-a79e-db242a339c2d'</ShapeID>
<Messages>
	<MsgInfo><name>msgBinCompareCopy</name><part>part</part><schema>RB.BT.ROBinaryComparison.BinaryCompare</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>456</Line><Position>25</Position><ShapeID>'fe8bac55-1a29-4a63-adb6-dce27b452d27'</ShapeID>
<Messages>
	<MsgInfo><name>msgBinCompareCopy</name><part>part</part><schema>RB.BT.ROBinaryComparison.BinaryCompare</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>465</Line><Position>25</Position><ShapeID>'d308526d-00ef-4a8f-94cf-89c9f292e176'</ShapeID>
<Messages>
	<MsgInfo><name>msgBinCompareCopy</name><part>part</part><schema>RB.BT.ROBinaryComparison.BinaryCompare</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>470</Line><Position>25</Position><ShapeID>'89a7536f-697e-4c4a-baec-9294fa9c0057'</ShapeID>
<Messages>
	<MsgInfo><name>msgBinCompareCopy</name><part>part</part><schema>RB.BT.ROBinaryComparison.BinaryCompare</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>479</Line><Position>25</Position><ShapeID>'de71c02a-8a5b-4c5f-bf32-b28a2644ab20'</ShapeID>
<Messages>
	<MsgInfo><name>msgBinCompareCopy</name><part>part</part><schema>RB.BT.ROBinaryComparison.BinaryCompare</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>485</Line><Position>21</Position><ShapeID>'a4965d2c-73d0-4095-ac09-d49128beed77'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>488</Line><Position>25</Position><ShapeID>'97e239d9-8883-4417-8909-6dda86697480'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='0bbc557a-42fb-4df7-b3b6-64da0b7c04b0' LowerBound='1.1' HigherBound='126.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='BTBinaryComparison' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='0e2fb17a-82f2-4662-a85f-237bee7ffc73' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Rec_BinCompPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='6c498d38-5250-4dde-9320-1461246f99ba' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='f141644b-27ad-42f5-9dfe-de247a4cea9a' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.51'>
                    <om:Property Name='Ref' Value='RB.BT.ROBinaryComparison.BinaryCompare' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='70854250-0c99-4a3e-b18d-84611c83a02f' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Ident' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='d3c60312-70bc-4359-93db-ac5232a16dcb' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='168290c8-870b-4037-9a19-d3a3b504891f' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.51'>
                    <om:Property Name='Ref' Value='RB.BT.ROBinaryComparison.BinaryCompare' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='18e6addb-31d9-43ca-ad72-35f781a5eaa3' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_DIFF' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='27815460-46b6-4fc9-a192-33dba7e5c6bb' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='c526a2e2-c270-4157-8b3a-b52ada79bce0' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.51'>
                    <om:Property Name='Ref' Value='RB.BT.ROBinaryComparison.BinaryCompare' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='20ab6059-086b-41c1-a57f-ae7e3199f302' ParentLink='Module_PortType' LowerBound='25.1' HigherBound='32.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_ERROR' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='e24b95b3-3f74-4daa-8d62-d1fad1fbf238' ParentLink='PortType_OperationDeclaration' LowerBound='27.1' HigherBound='31.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='c8b4b60e-24a9-41cc-8682-beb9bf1ff2f0' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='29.13' HigherBound='29.51'>
                    <om:Property Name='Ref' Value='RB.BT.ROBinaryComparison.BinaryCompare' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='19ed5308-bebb-4383-80fd-1216a78d8b26' ParentLink='Module_ServiceDeclaration' LowerBound='32.1' HigherBound='125.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='BizTalk_Orchestration2' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PortDeclaration' OID='ec6e2d37-e2eb-4665-a080-c08cfb13bfff' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='35.1' HigherBound='37.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BTBinaryComparison.Rec_BinCompPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Prot_RCV' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='d75dbe01-3cf2-412c-b059-800a1f049658' ParentLink='PortDeclaration_CLRAttribute' LowerBound='35.1' HigherBound='36.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='a183d9fe-bbf8-4fbd-b6a1-d08ee456bb76' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='37.1' HigherBound='39.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BTBinaryComparison.PortType_Ident' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PORT_IDENTITIES' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='8d959573-9e3f-4d34-ae86-416e7cb5ae1a' ParentLink='PortDeclaration_CLRAttribute' LowerBound='37.1' HigherBound='38.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='99f02a35-f41b-4bd1-a31f-2f16d019c309' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='39.1' HigherBound='41.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BTBinaryComparison.PortType_DIFF' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PORT_DIFF' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='2c3d7902-3941-40ac-a6a4-76844aa0284b' ParentLink='PortDeclaration_CLRAttribute' LowerBound='39.1' HigherBound='40.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='0cf328f0-001b-4617-a6d0-bda1f39f0976' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='41.1' HigherBound='43.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BTBinaryComparison.PortType_ERROR' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PORT_ERROR' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='dabb425e-64c9-4b34-82ac-c62acce60093' ParentLink='PortDeclaration_CLRAttribute' LowerBound='41.1' HigherBound='42.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='31ad42a7-9aad-458d-ad2e-131b12e3daca' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='45.1' HigherBound='46.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int64' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='iListOfFiles' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='106af274-6526-49b0-be3b-28a7f8773dcf' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='46.1' HigherBound='47.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sFileNames' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='d0419384-d8b9-47f6-9168-46da706d02e6' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='47.1' HigherBound='48.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sFileName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='fd14e0ff-2930-4cbb-bfbe-62d3d3150744' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='48.1' HigherBound='49.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='RB.BT.ROBinaryComparisonLibrary.FileComparison' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ROBinComp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8dac87ff-63f9-48b3-9743-f87d09f8797f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='49.1' HigherBound='50.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sTargetPath' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='c1e5a544-51bc-4102-868e-722feb8972f7' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='50.1' HigherBound='51.1'>
                <om:Property Name='InitialValue' Value='true' />
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Boolean' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='bIsEqual' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='b004c82b-b4f6-409b-bba0-e8da9a6e889f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='51.1' HigherBound='52.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='sStatus' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='6c176a57-4d22-414c-8072-788a6eb43b21' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='43.1' HigherBound='44.1'>
                <om:Property Name='Type' Value='RB.BT.ROBinaryComparison.BinaryCompare' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgBinCompareCopy' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='78f1ba2c-0cba-4435-8af5-492d73977196' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='44.1' HigherBound='45.1'>
                <om:Property Name='Type' Value='RB.BT.ROBinaryComparison.BinaryCompare' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='msgBinCompare' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='bb44d1b4-2746-4158-828a-07a2b3ae0c61' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='137d5bc1-7097-48b0-9224-cc2f14420f34' ParentLink='ServiceBody_Statement' LowerBound='54.1' HigherBound='62.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Prot_RCV' />
                    <om:Property Name='MessageName' Value='msgBinCompare' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='6e911921-72f5-4715-a493-77369053770d' ParentLink='ServiceBody_Statement' LowerBound='62.1' HigherBound='123.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='VariableAssignment' OID='f2c6f490-74e2-4b1f-944e-ff01d7d12ddb' ParentLink='ComplexStatement_Statement' LowerBound='67.1' HigherBound='69.1'>
                        <om:Property Name='Expression' Value='sStatus = ROBinComp.TestCompare(msgBinCompare);' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Expression_1' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Decision' OID='4c38a546-d752-439b-a225-1e72ab238181' ParentLink='ComplexStatement_Statement' LowerBound='69.1' HigherBound='112.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Decide_2' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='DecisionBranch' OID='5e03980a-d107-4ef5-80f9-42995b0af043' ParentLink='ReallyComplexStatement_Branch' LowerBound='70.21' HigherBound='84.1'>
                            <om:Property Name='Expression' Value='sStatus == &quot;Identical&quot;' />
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Rule_1' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Construct' OID='a9247795-8645-49c7-9a80-2387fe48e557' ParentLink='ComplexStatement_Statement' LowerBound='72.1' HigherBound='81.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ConstructMessage_2' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageAssignment' OID='d1992bda-1d0a-482b-9d3c-e91e54747a7f' ParentLink='ComplexStatement_Statement' LowerBound='75.1' HigherBound='80.1'>
                                    <om:Property Name='Expression' Value='msgBinCompareCopy = msgBinCompare;&#xD;&#xA;msgBinCompareCopy.BinaryComparisonStatus = sStatus;&#xD;&#xA;msgBinCompareCopy(FILE.ReceivedFileName) = System.IO.Path.GetFileNameWithoutExtension(msgBinCompare(FILE.ReceivedFileName));&#xD;&#xA;//System.Diagnostics.EventLog.WriteEntry(&quot;Biztalk : BinCOmapre&quot;, &quot;before end&quot; , System.Diagnostics.EventLogEntryType.Information);' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='MessageAssignment_2' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='3494fe5a-8e53-4d7e-ba2b-3014918cc8f2' ParentLink='Construct_MessageRef' LowerBound='73.35' HigherBound='73.52'>
                                    <om:Property Name='Ref' Value='msgBinCompareCopy' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Send' OID='ee020a6c-92bc-478d-a79e-db242a339c2d' ParentLink='ComplexStatement_Statement' LowerBound='81.1' HigherBound='83.1'>
                                <om:Property Name='PortName' Value='PORT_IDENTITIES' />
                                <om:Property Name='MessageName' Value='msgBinCompareCopy' />
                                <om:Property Name='OperationName' Value='Operation_1' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='DecisionBranch' OID='e4042693-7cdb-4191-82b5-b5ee595e6b04' ParentLink='ReallyComplexStatement_Branch' LowerBound='84.26' HigherBound='98.1'>
                            <om:Property Name='Expression' Value='sStatus == &quot;Different&quot;' />
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Rule_2' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Construct' OID='fe8bac55-1a29-4a63-adb6-dce27b452d27' ParentLink='ComplexStatement_Statement' LowerBound='86.1' HigherBound='95.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ConstructMessage_2' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageRef' OID='f86e543b-a257-4416-bc51-235633556ecd' ParentLink='Construct_MessageRef' LowerBound='87.35' HigherBound='87.52'>
                                    <om:Property Name='Ref' Value='msgBinCompareCopy' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessageAssignment' OID='6e658e6d-a50d-4bbe-8e18-b503d40bec1d' ParentLink='ComplexStatement_Statement' LowerBound='89.1' HigherBound='94.1'>
                                    <om:Property Name='Expression' Value='msgBinCompareCopy = msgBinCompare;&#xD;&#xA;msgBinCompareCopy.BinaryComparisonStatus = sStatus;&#xD;&#xA;msgBinCompareCopy(FILE.ReceivedFileName) = System.IO.Path.GetFileNameWithoutExtension(msgBinCompare(FILE.ReceivedFileName));&#xD;&#xA;//System.Diagnostics.EventLog.WriteEntry(&quot;Biztalk : BinCOmapre&quot;, &quot;before end&quot; , System.Diagnostics.EventLogEntryType.Information);' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='MessageAssignment_2' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Send' OID='d308526d-00ef-4a8f-94cf-89c9f292e176' ParentLink='ComplexStatement_Statement' LowerBound='95.1' HigherBound='97.1'>
                                <om:Property Name='PortName' Value='PORT_DIFF' />
                                <om:Property Name='MessageName' Value='msgBinCompareCopy' />
                                <om:Property Name='OperationName' Value='Operation_1' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send_2' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='DecisionBranch' OID='761f6ef9-54f9-48bf-91ca-d98a3be34982' ParentLink='ReallyComplexStatement_Branch'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Else' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Construct' OID='89a7536f-697e-4c4a-baec-9294fa9c0057' ParentLink='ComplexStatement_Statement' LowerBound='100.1' HigherBound='109.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ConstructMessage_2' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageRef' OID='091a86c7-4e95-42b9-8d61-5f3b0b1d569f' ParentLink='Construct_MessageRef' LowerBound='101.35' HigherBound='101.52'>
                                    <om:Property Name='Ref' Value='msgBinCompareCopy' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessageAssignment' OID='244901c3-bd07-413b-a974-9f517765d42c' ParentLink='ComplexStatement_Statement' LowerBound='103.1' HigherBound='108.1'>
                                    <om:Property Name='Expression' Value='msgBinCompareCopy = msgBinCompare;&#xD;&#xA;msgBinCompareCopy.BinaryComparisonStatus = sStatus;&#xD;&#xA;msgBinCompareCopy(FILE.ReceivedFileName) = System.IO.Path.GetFileNameWithoutExtension(msgBinCompare(FILE.ReceivedFileName));&#xD;&#xA;//System.Diagnostics.EventLog.WriteEntry(&quot;Biztalk : BinCOmapre&quot;, &quot;before end&quot; , System.Diagnostics.EventLogEntryType.Information);' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='MessageAssignment_2' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Send' OID='de71c02a-8a5b-4c5f-bf32-b28a2644ab20' ParentLink='ComplexStatement_Statement' LowerBound='109.1' HigherBound='111.1'>
                                <om:Property Name='PortName' Value='PORT_ERROR' />
                                <om:Property Name='MessageName' Value='msgBinCompareCopy' />
                                <om:Property Name='OperationName' Value='Operation_1' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send_3' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='a4965d2c-73d0-4095-ac09-d49128beed77' ParentLink='Scope_Catch' LowerBound='115.1' HigherBound='121.1'>
                        <om:Property Name='ExceptionType' Value='General Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchException_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Throw' OID='97e239d9-8883-4417-8909-6dda86697480' ParentLink='Catch_Statement' LowerBound='118.1' HigherBound='120.1'>
                            <om:Property Name='ThrownReference' Value='General Exception' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ThrowException_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __BizTalk_Orchestration2_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __BizTalk_Orchestration2_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "BizTalk_Orchestration2")
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
                BizTalk_Orchestration2 __svc__ = (BizTalk_Orchestration2)_service;
                __BizTalk_Orchestration2_root_0 __ctx0__ = (__BizTalk_Orchestration2_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.PORT_ERROR != null)
                {
                    __svc__.PORT_ERROR.Close(this, null);
                    __svc__.PORT_ERROR = null;
                }
                if (__svc__.Prot_RCV != null)
                {
                    __svc__.Prot_RCV.Close(this, null);
                    __svc__.Prot_RCV = null;
                }
                if (__svc__.PORT_DIFF != null)
                {
                    __svc__.PORT_DIFF.Close(this, null);
                    __svc__.PORT_DIFF = null;
                }
                if (__svc__.PORT_IDENTITIES != null)
                {
                    __svc__.PORT_IDENTITIES.Close(this, null);
                    __svc__.PORT_IDENTITIES = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __BizTalk_Orchestration2_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __BizTalk_Orchestration2_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "BizTalk_Orchestration2")
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
                BizTalk_Orchestration2 __svc__ = (BizTalk_Orchestration2)_service;
                __BizTalk_Orchestration2_1 __ctx1__ = (__BizTalk_Orchestration2_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__sStatus = null;
                if (__ctx1__ != null)
                    __ctx1__.__sFileName = null;
                if (__ctx1__ != null)
                    __ctx1__.__sTargetPath = null;
                if (__ctx1__ != null)
                    __ctx1__.__ROBinComp = null;
                if (__ctx1__ != null && __ctx1__.__msgBinCompare != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgBinCompare);
                    __ctx1__.__msgBinCompare = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__sFileNames = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("msgBinCompareCopy")]
            public __messagetype_RB_BT_ROBinaryComparison_BinaryCompare __msgBinCompareCopy;
            [Microsoft.XLANGs.Core.UserVariableAttribute("msgBinCompare")]
            public __messagetype_RB_BT_ROBinaryComparison_BinaryCompare __msgBinCompare;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sFileNames")]
            internal System.String __sFileNames;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sFileName")]
            internal System.String __sFileName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ROBinComp")]
            internal RB.BT.ROBinaryComparisonLibrary.FileComparison __ROBinComp;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sTargetPath")]
            internal System.String __sTargetPath;
            [Microsoft.XLANGs.Core.UserVariableAttribute("bIsEqual")]
            internal System.Boolean __bIsEqual;
            [Microsoft.XLANGs.Core.UserVariableAttribute("sStatus")]
            internal System.String __sStatus;
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

                __seg__ = _service._segments[3];
                __seg__.Reset(1);
                __seg__.PredecessorDone(_service);
                return true;
            }

            public override void Finally()
            {
                BizTalk_Orchestration2 __svc__ = (BizTalk_Orchestration2)_service;
                __BizTalk_Orchestration2_1 __ctx1__ = (__BizTalk_Orchestration2_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__msgBinCompareCopy != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgBinCompareCopy);
                    __ctx1__.__msgBinCompareCopy = null;
                }
                base.Finally();
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("Prot_RCV")]
        internal Rec_BinCompPortType Prot_RCV;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("PORT_IDENTITIES")]
        internal PortType_Ident PORT_IDENTITIES;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("PORT_DIFF")]
        internal PortType_DIFF PORT_DIFF;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("PORT_ERROR")]
        internal PortType_ERROR PORT_ERROR;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Rec_BinCompPortType.Operation_1},
                                               typeof(BizTalk_Orchestration2).GetField("Prot_RCV", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration2), "Prot_RCV"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Ident.Operation_1},
                                               typeof(BizTalk_Orchestration2).GetField("PORT_IDENTITIES", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration2), "PORT_IDENTITIES"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_DIFF.Operation_1},
                                               typeof(BizTalk_Orchestration2).GetField("PORT_DIFF", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration2), "PORT_DIFF"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_ERROR.Operation_1},
                                               typeof(BizTalk_Orchestration2).GetField("PORT_ERROR", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration2), "PORT_ERROR"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "137d5bc1-7097-48b0-9224-cc2f14420f34", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "137d5bc1-7097-48b0-9224-cc2f14420f34", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "6e911921-72f5-4715-a493-77369053770d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "f2c6f490-74e2-4b1f-944e-ff01d7d12ddb", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "f2c6f490-74e2-4b1f-944e-ff01d7d12ddb", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "4c38a546-d752-439b-a225-1e72ab238181", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "a9247795-8645-49c7-9a80-2387fe48e557", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "a9247795-8645-49c7-9a80-2387fe48e557", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "ee020a6c-92bc-478d-a79e-db242a339c2d", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "ee020a6c-92bc-478d-a79e-db242a339c2d", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "fe8bac55-1a29-4a63-adb6-dce27b452d27", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "fe8bac55-1a29-4a63-adb6-dce27b452d27", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "d308526d-00ef-4a8f-94cf-89c9f292e176", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "d308526d-00ef-4a8f-94cf-89c9f292e176", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "89a7536f-697e-4c4a-baec-9294fa9c0057", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "89a7536f-697e-4c4a-baec-9294fa9c0057", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "de71c02a-8a5b-4c5f-bf32-b28a2644ab20", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "de71c02a-8a5b-4c5f-bf32-b28a2644ab20", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "4c38a546-d752-439b-a225-1e72ab238181", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "a4965d2c-73d0-4095-ac09-d49128beed77", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "97e239d9-8883-4417-8909-6dda86697480", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "a4965d2c-73d0-4095-ac09-d49128beed77", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "6e911921-72f5-4715-a493-77369053770d", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Throw),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,2,4,4,4,26,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 6,6,6,7,8,8,9,9,10,11,11,11,12,8,8,8,13,13,14,15,15,15,16,16,17,17,18,19,19,19,20,20,22,22,22,22,};
        public static int[] __progressLocation3 = new int[] { 23,23,24,24,25,25,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __BizTalk_Orchestration2_1 __ctx1__ = (__BizTalk_Orchestration2_1)_stateMgrs[1];
            __BizTalk_Orchestration2_root_0 __ctx0__ = (__BizTalk_Orchestration2_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                Prot_RCV = new Rec_BinCompPortType(0, this);
                PORT_IDENTITIES = new PortType_Ident(1, this);
                PORT_DIFF = new PortType_DIFF(2, this);
                PORT_ERROR = new PortType_ERROR(3, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Prot_RCV, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __BizTalk_Orchestration2_1(this);
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
            __BizTalk_Orchestration2_1 __ctx1__ = (__BizTalk_Orchestration2_1)_stateMgrs[1];
            __BizTalk_Orchestration2_root_0 __ctx0__ = (__BizTalk_Orchestration2_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__sFileNames = default(System.String);
                __ctx1__.__sFileName = default(System.String);
                __ctx1__.__ROBinComp = default(RB.BT.ROBinaryComparisonLibrary.FileComparison);
                __ctx1__.__sTargetPath = default(System.String);
                __ctx1__.__bIsEqual = default(System.Boolean);
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
                if (!Prot_RCV.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__msgBinCompare != null)
                    __ctx1__.UnrefMessage(__ctx1__.__msgBinCompare);
                __ctx1__.__msgBinCompare = new __messagetype_RB_BT_ROBinaryComparison_BinaryCompare("msgBinCompare", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__msgBinCompare);
                Prot_RCV.ReceiveMessage(0, __msgEnv__, __ctx1__.__msgBinCompare, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (Prot_RCV != null)
                {
                    Prot_RCV.Close(__ctx1__, __seg__);
                    Prot_RCV = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__msgBinCompare);
                    __edata.PortName = @"Prot_RCV";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__sFileNames = "";
                if (__ctx1__ != null)
                    __ctx1__.__sFileNames = null;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__sFileName = "";
                if (__ctx1__ != null)
                    __ctx1__.__sFileName = null;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__ROBinComp = new RB.BT.ROBinaryComparisonLibrary.FileComparison();
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__sTargetPath = "";
                if (__ctx1__ != null)
                    __ctx1__.__sTargetPath = null;
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__bIsEqual = true;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__sStatus = "";
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                __ctx2__ = new ____scope33_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__sStatus = null;
                if (__ctx1__ != null)
                    __ctx1__.__ROBinComp = null;
                if (__ctx1__ != null && __ctx1__.__msgBinCompare != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgBinCompare);
                    __ctx1__.__msgBinCompare = null;
                }
                if (PORT_ERROR != null)
                {
                    PORT_ERROR.Close(__ctx1__, __seg__);
                    PORT_ERROR = null;
                }
                if (PORT_DIFF != null)
                {
                    PORT_DIFF.Close(__ctx1__, __seg__);
                    PORT_DIFF = null;
                }
                if (PORT_IDENTITIES != null)
                {
                    PORT_IDENTITIES.Close(__ctx1__, __seg__);
                    PORT_IDENTITIES = null;
                }
                Tracker.FireEvent(__eventLocations[26],__eventData[12],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[13],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 18;
            case 18:
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
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __BizTalk_Orchestration2_1 __ctx1__ = (__BizTalk_Orchestration2_1)_stateMgrs[1];
            __BizTalk_Orchestration2_root_0 __ctx0__ = (__BizTalk_Orchestration2_root_0)_stateMgrs[0];

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
                Tracker.FireEvent(__eventLocations[6],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                __ctx1__.__sStatus = __ctx1__.__ROBinComp.TestCompare(__ctx1__.__msgBinCompare.part.TypedValue);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __condition__ = __ctx1__.__sStatus == "Identical";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 14;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                {
                    __messagetype_RB_BT_ROBinaryComparison_BinaryCompare __msgBinCompareCopy = new __messagetype_RB_BT_ROBinaryComparison_BinaryCompare("msgBinCompareCopy", __ctx1__);

                    __msgBinCompareCopy.CopyFrom(__ctx1__.__msgBinCompare);
                    __msgBinCompareCopy.part.SetDistinguishedField("BinaryComparisonStatus", __ctx1__.__sStatus);
                    __msgBinCompareCopy.SetPropertyValue(typeof(FILE.ReceivedFileName), System.IO.Path.GetFileNameWithoutExtension((System.String)__ctx1__.__msgBinCompare.GetPropertyValueThrows(typeof(FILE.ReceivedFileName))));

                    if (__ctx1__.__msgBinCompareCopy != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgBinCompareCopy);
                    __ctx1__.__msgBinCompareCopy = __msgBinCompareCopy;
                    __ctx1__.RefMessage(__ctx1__.__msgBinCompareCopy);
                }
                __ctx1__.__msgBinCompareCopy.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgBinCompareCopy);
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                PORT_IDENTITIES.SendMessage(0, __ctx1__.__msgBinCompareCopy, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgBinCompareCopy);
                    __edata.PortName = @"PORT_IDENTITIES";
                    Tracker.FireEvent(__eventLocations[12],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                __condition__ = __ctx1__.__sStatus == "Different";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 24;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                {
                    __messagetype_RB_BT_ROBinaryComparison_BinaryCompare __msgBinCompareCopy = new __messagetype_RB_BT_ROBinaryComparison_BinaryCompare("msgBinCompareCopy", __ctx1__);

                    __msgBinCompareCopy.CopyFrom(__ctx1__.__msgBinCompare);
                    __msgBinCompareCopy.part.SetDistinguishedField("BinaryComparisonStatus", __ctx1__.__sStatus);
                    __msgBinCompareCopy.SetPropertyValue(typeof(FILE.ReceivedFileName), System.IO.Path.GetFileNameWithoutExtension((System.String)__ctx1__.__msgBinCompare.GetPropertyValueThrows(typeof(FILE.ReceivedFileName))));

                    if (__ctx1__.__msgBinCompareCopy != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgBinCompareCopy);
                    __ctx1__.__msgBinCompareCopy = __msgBinCompareCopy;
                    __ctx1__.RefMessage(__ctx1__.__msgBinCompareCopy);
                }
                __ctx1__.__msgBinCompareCopy.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgBinCompareCopy);
                    Tracker.FireEvent(__eventLocations[14],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                PORT_DIFF.SendMessage(0, __ctx1__.__msgBinCompareCopy, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgBinCompareCopy);
                    __edata.PortName = @"PORT_DIFF";
                    Tracker.FireEvent(__eventLocations[16],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                {
                    __messagetype_RB_BT_ROBinaryComparison_BinaryCompare __msgBinCompareCopy = new __messagetype_RB_BT_ROBinaryComparison_BinaryCompare("msgBinCompareCopy", __ctx1__);

                    __msgBinCompareCopy.CopyFrom(__ctx1__.__msgBinCompare);
                    __msgBinCompareCopy.part.SetDistinguishedField("BinaryComparisonStatus", __ctx1__.__sStatus);
                    __msgBinCompareCopy.SetPropertyValue(typeof(FILE.ReceivedFileName), System.IO.Path.GetFileNameWithoutExtension((System.String)__ctx1__.__msgBinCompare.GetPropertyValueThrows(typeof(FILE.ReceivedFileName))));

                    if (__ctx1__.__msgBinCompareCopy != null)
                        __ctx1__.UnrefMessage(__ctx1__.__msgBinCompareCopy);
                    __ctx1__.__msgBinCompareCopy = __msgBinCompareCopy;
                    __ctx1__.RefMessage(__ctx1__.__msgBinCompareCopy);
                }
                __ctx1__.__msgBinCompareCopy.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__msgBinCompareCopy);
                    Tracker.FireEvent(__eventLocations[18],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                PORT_ERROR.SendMessage(0, __ctx1__.__msgBinCompareCopy, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__msgBinCompareCopy);
                    __edata.PortName = @"PORT_ERROR";
                    Tracker.FireEvent(__eventLocations[20],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__msgBinCompareCopy != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__msgBinCompareCopy);
                    __ctx1__.__msgBinCompareCopy = null;
                }
                Tracker.FireEvent(__eventLocations[22],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 33;
            case 33:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 35;
            case 35:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];

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
                Tracker.FireEvent(__eventLocations[23],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx2__.ExceptionRaised();
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[25],__eventData[11],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __RB_BT_ROBinaryComparison_BinaryCompare__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static RB.BT.ROBinaryComparison.BinaryCompare _schema = new RB.BT.ROBinaryComparison.BinaryCompare();

        public __RB_BT_ROBinaryComparison_BinaryCompare__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "RB.BT.ROBinaryComparison.BinaryCompare",
        new System.Type[]{
            typeof(RB.BT.ROBinaryComparison.BinaryCompare)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__RB_BT_ROBinaryComparison_BinaryCompare__)
        },
        0,
        @"http://RB.BT.ROBinaryComparison.BinaryCompare#BinaryComparison"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_RB_BT_ROBinaryComparison_BinaryCompare : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __RB_BT_ROBinaryComparison_BinaryCompare__ part;

        private void __CreatePartWrappers()
        {
            part = new __RB_BT_ROBinaryComparison_BinaryCompare__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_RB_BT_ROBinaryComparison_BinaryCompare(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
