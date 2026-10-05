
#pragma warning disable 162

namespace FTPRecordTransfer
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(FTPRecordTransfer.__messagetype_FTPIssueTransfer_StartExportRequest), 
            typeof(FTPRecordTransfer.__messagetype_FTPIssueTransfer_StartExportRequest)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_5 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
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

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(PortType_5),
            typeof(__messagetype_FTPIssueTransfer_StartExportRequest),
            typeof(__messagetype_FTPIssueTransfer_StartExportRequest),
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
            typeof(FTPIssueTransfer.__messagetype_FTPIssueTransfer_TransferResultInformation),
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
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_2 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
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

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_2),
            typeof(FTPIssueTransfer.__messagetype_FTPIssueTransfer_TransferResultInformation),
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
    //#line 340 "D:\ASAM-IF-IMPORT\Import\960 - Sources\PTI8KOR\BTImportSoftware\FTPIssueTransfer\FTPIssueTransfer\StartExport.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "EX_P", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(FTPRecordTransfer.PortType_5),
            typeof(FTPRecordTransfer.PortType_1),
            typeof(FTPRecordTransfer.PortType_2)
        },
        new System.String[] {
            "EX_P",
            "EX_R",
            "EX_R_CPY"
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
    sealed internal class StartExport : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(StartExport));
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

        static StartExport()
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
            _rootContext = new __StartExport_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public StartExport(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "StartExport", tracker)
        {
            ConstructorHelper();
        }

        public StartExport(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "StartExport")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>f0b98ed3-8924-4b12-85e9-667742498b70</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>9b724ee7-8871-406f-a917-e57da6b74875</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>4c9b7088-c102-4682-b0d9-c1abe0329dc4</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Log</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>3a782c69-63c5-4ad5-a0b1-ef864c78eb6d</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>SetLogger</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>f65acc89-027c-413f-9cfd-423df052e7d9</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>d13b7454-2dd6-4a63-adb2-d227eabb12ad</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>46d54810-a7f7-45e8-8aa7-96dc41058398</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>56d01bc4-ae98-484f-a485-7052fe894da9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>8d6a1e29-13f5-43d6-9d74-2144d3070b26</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>3b59feeb-47ba-4b29-a87b-466297936bb2</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>55bb3a4e-6ba0-44c4-99ff-346d9b5a861b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>afb8a5be-3266-4761-bd08-611053860b53</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>0c926a80-42d7-4a15-ace2-ddb528e04ccc</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>176c0997-2b05-41f7-9e38-6eab8ab32673</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>69c11ac5-e61d-4ecb-9e4a-36964d75b382</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Close-Logger</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'StartExport'</ActionName><IsAtomic>0</IsAtomic><Line>340</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>362</Line><Position>22</Position><ShapeID>'9b724ee7-8871-406f-a917-e57da6b74875'</ShapeID>
<Messages>
	<MsgInfo><name>Message_1</name><part>part</part><schema>FTPIssueTransfer.StartExportRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>372</Line><Position>51</Position><ShapeID>'4c9b7088-c102-4682-b0d9-c1abe0329dc4'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>374</Line><Position>18</Position><ShapeID>'3a782c69-63c5-4ad5-a0b1-ef864c78eb6d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>379</Line><Position>27</Position><ShapeID>'f65acc89-027c-413f-9cfd-423df052e7d9'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>391</Line><Position>13</Position><ShapeID>'d13b7454-2dd6-4a63-adb2-d227eabb12ad'</ShapeID>
<Messages>
	<MsgInfo><name>Message_1</name><part>part</part><schema>FTPIssueTransfer.StartExportRequest</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>393</Line><Position>13</Position><ShapeID>'46d54810-a7f7-45e8-8aa7-96dc41058398'</ShapeID>
<Messages>
	<MsgInfo><name>ExportTransferResultInfo_msg</name><part>part</part><schema>FTPIssueTransfer.TransferResultInformation</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Message_1</name><part>part</part><schema>FTPIssueTransfer.StartExportRequest</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>407</Line><Position>13</Position><ShapeID>'0c926a80-42d7-4a15-ace2-ddb528e04ccc'</ShapeID>
<Messages>
	<MsgInfo><name>ExportTransferResultInfo_msg</name><part>part</part><schema>FTPIssueTransfer.TransferResultInformation</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>409</Line><Position>13</Position><ShapeID>'176c0997-2b05-41f7-9e38-6eab8ab32673'</ShapeID>
<Messages>
	<MsgInfo><name>ExportTransferResultInfo_msg</name><part>part</part><schema>FTPIssueTransfer.TransferResultInformation</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>411</Line><Position>32</Position><ShapeID>'69c11ac5-e61d-4ecb-9e4a-36964d75b382'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='42e86bf1-8d3c-4e7c-af83-93c2d4ea247b' LowerBound='1.1' HigherBound='102.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='FTPRecordTransfer' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='88467b86-e524-474e-a899-9a876f213d94' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_5' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='6fb207c2-8583-45f5-8b44-69b8ed5b9710' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='bcbbff8a-012d-4f72-ad7a-d5b5f50155db' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.48'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.StartExportRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='750ac202-3659-4f2d-9972-b9dd584ddda4' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='8.50' HigherBound='8.85'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.StartExportRequest' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='173aac82-a82a-4247-856e-29375bef8410' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='cb414096-3fa8-4d72-b89b-b97a49470289' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='ee26b25b-9d93-40b1-92a4-860b22ea2c65' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.55'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.TransferResultInformation' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='e9e55d4c-ffdd-4ed9-b337-1b72e5bbe79f' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_2' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='b3b98fd6-0958-4013-8bc2-5fdc687bc883' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='f2ebd582-c807-4899-a21d-451df1eb5dce' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.55'>
                    <om:Property Name='Ref' Value='FTPIssueTransfer.TransferResultInformation' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='0934b618-932b-4eba-aca4-75910dc20650' ParentLink='Module_ServiceDeclaration' LowerBound='25.1' HigherBound='101.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='StartExport' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='d4f0f204-4d7a-4726-a28a-cac703e7be0f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='36.1' HigherBound='37.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='RB.BTLoggerLibrary.Logger' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ROLogger' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='23274daa-6e6f-457c-aec7-1a9a4adfb9d2' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='37.1' HigherBound='38.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='RB.BTLoggerLibrary.BTLogger' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ROBTLogger' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='66c8a2d3-a94b-4f04-8f47-8b107b9a7ed0' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='38.1' HigherBound='39.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='InterfaceName' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='0a97a69b-5f53-4526-a728-0e2056b23f22' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='39.1' HigherBound='40.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TargetSystem' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='d754a1f9-a5b2-410d-a21c-6e2899af46ee' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='40.1' HigherBound='41.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='LifeToken4XProt' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='cdb1f755-913e-4136-ac1d-5a3052c9b81a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='41.1' HigherBound='42.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='LifeToken4Files' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='af2481aa-dcbd-4d06-924d-174b1a2fc486' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='42.1' HigherBound='43.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tmp_str1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='18a625ee-b795-4ecc-8e72-9f41c36b96fd' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='43.1' HigherBound='44.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='type' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='097770df-5550-4aac-b8c1-24e65910236d' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='44.1' HigherBound='45.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='tmp_str2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='09262db5-d33b-4b9d-b9d7-5678c32e3c7f' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='Type' Value='FTPIssueTransfer.StartExportRequest' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Message_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='00ee2a15-4e0e-4cc4-9a1e-1ab2b03ba673' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='35.1' HigherBound='36.1'>
                <om:Property Name='Type' Value='FTPIssueTransfer.TransferResultInformation' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ExportTransferResultInfo_msg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='f0b98ed3-8924-4b12-85e9-667742498b70' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='9b724ee7-8871-406f-a917-e57da6b74875' ParentLink='ServiceBody_Statement' LowerBound='47.1' HigherBound='57.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='EX_P' />
                    <om:Property Name='MessageName' Value='Message_1' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='4c9b7088-c102-4682-b0d9-c1abe0329dc4' ParentLink='ServiceBody_Statement' LowerBound='57.1' HigherBound='59.1'>
                    <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;FTPIssueTransfer&quot;,&quot;Export Request received at &quot;+System.String.Format(&quot;{0:yyyyMMdd-HHmmssffffff - }&quot;, System.DateTime.Now));' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Log' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='3a782c69-63c5-4ad5-a0b1-ef864c78eb6d' ParentLink='ServiceBody_Statement' LowerBound='59.1' HigherBound='64.1'>
                    <om:Property Name='Expression' Value='type = &quot;Export&quot;;&#xD;&#xA;ROLogger  = ROBTLogger.GetLogger(Message_1.InterfaceName,Message_1.XProtID, type);&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmssffffff - }&quot;, System.DateTime.Now) + &quot;After receiving Request&quot;,&#xD;&#xA;ROLogger);&#xD;&#xA;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SetLogger' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='f65acc89-027c-413f-9cfd-423df052e7d9' ParentLink='ServiceBody_Statement' LowerBound='64.1' HigherBound='76.1'>
                    <om:Property Name='Expression' Value='InterfaceName = System.Convert.ToString(Message_1.InterfaceName);&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer :InterfaceName  : &quot; + InterfaceName,ROLogger);&#xD;&#xA;TargetSystem = System.Convert.ToString(Message_1.RQ1System);&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer :TargetSystem  : &quot; + TargetSystem,ROLogger);&#xD;&#xA;LifeToken4XProt = &quot;In Progress&quot;;&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer :LifeToken4Xprot  : &quot; + LifeToken4XProt,ROLogger);&#xD;&#xA;tmp_str1 = Message_1.FTPFileNames;&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer :RecordNames  : &quot; + tmp_str1,ROLogger);&#xD;&#xA;LifeToken4Files = ROBTLogger.InsertAllTokenStatus(tmp_str1, &quot;In Progress&quot;,type);&#xD;&#xA;ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : LifeToken4Files  : &quot; + LifeToken4Files,ROLogger);&#xD;&#xA;&#xD;&#xA;' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Expression_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='Send' OID='d13b7454-2dd6-4a63-adb2-d227eabb12ad' ParentLink='ServiceBody_Statement' LowerBound='76.1' HigherBound='78.1'>
                    <om:Property Name='PortName' Value='EX_P' />
                    <om:Property Name='MessageName' Value='Message_1' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='46d54810-a7f7-45e8-8aa7-96dc41058398' ParentLink='ServiceBody_Statement' LowerBound='78.1' HigherBound='92.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='Transform' OID='56d01bc4-ae98-484f-a485-7052fe894da9' ParentLink='ComplexStatement_Statement' LowerBound='81.1' HigherBound='83.1'>
                        <om:Property Name='ClassName' Value='FTPIssueTransfer.Map2TransferResultExp' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='8d6a1e29-13f5-43d6-9d74-2144d3070b26' ParentLink='Transform_InputMessagePartRef' LowerBound='82.100' HigherBound='82.109'>
                            <om:Property Name='MessageRef' Value='Message_1' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='3b59feeb-47ba-4b29-a87b-466297936bb2' ParentLink='Transform_OutputMessagePartRef' LowerBound='82.28' HigherBound='82.56'>
                            <om:Property Name='MessageRef' Value='ExportTransferResultInfo_msg' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageAssignment' OID='55bb3a4e-6ba0-44c4-99ff-346d9b5a861b' ParentLink='ComplexStatement_Statement' LowerBound='83.1' HigherBound='91.1'>
                        <om:Property Name='Expression' Value='ExportTransferResultInfo_msg.LifeToken4XProt = LifeToken4XProt;&#xD;&#xA;ExportTransferResultInfo_msg.LifeToken4Files = LifeToken4Files;&#xD;&#xA;&#xD;&#xA;tmp_str1 = ExportTransferResultInfo_msg.RQ1System;&#xD;&#xA;tmp_str2 = tmp_str1.Substring(tmp_str1.LastIndexOf(&quot;@&quot;)+1);&#xD;&#xA;&#xD;&#xA;ExportTransferResultInfo_msg(FILE.ReceivedFileName) = tmp_str2 + &quot;_&quot; + ExportTransferResultInfo_msg.XProtID + &quot;_005_FTPTransferResult_&quot;;&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='False' />
                        <om:Property Name='Name' Value='MessageAssignment_1' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='MessageRef' OID='afb8a5be-3266-4761-bd08-611053860b53' ParentLink='Construct_MessageRef' LowerBound='79.23' HigherBound='79.51'>
                        <om:Property Name='Ref' Value='ExportTransferResultInfo_msg' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='0c926a80-42d7-4a15-ace2-ddb528e04ccc' ParentLink='ServiceBody_Statement' LowerBound='92.1' HigherBound='94.1'>
                    <om:Property Name='PortName' Value='EX_R' />
                    <om:Property Name='MessageName' Value='ExportTransferResultInfo_msg' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='176c0997-2b05-41f7-9e38-6eab8ab32673' ParentLink='ServiceBody_Statement' LowerBound='94.1' HigherBound='96.1'>
                    <om:Property Name='PortName' Value='EX_R_CPY' />
                    <om:Property Name='MessageName' Value='ExportTransferResultInfo_msg' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_3' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='69c11ac5-e61d-4ecb-9e4a-36964d75b382' ParentLink='ServiceBody_Statement' LowerBound='96.1' HigherBound='99.1'>
                    <om:Property Name='Expression' Value='ROBTLogger.WriteLog(System.String.Format(&quot;{0:yyyyMMdd-HHmmss - }&quot;, System.DateTime.Now) + &quot;FTPIssueTransfer : &quot; + &quot;Export Transfer Result Information file is successfully generated&quot;,ROLogger);&#xD;&#xA;ROBTLogger.CloseLogger(ROLogger);' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Close-Logger' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='c8e907a8-3165-4f8d-b7ab-8618ace7d1b5' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='28.1' HigherBound='30.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='FTPRecordTransfer.PortType_5' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EX_P' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='40964519-e266-4a9e-b8f6-96fc03a02a6c' ParentLink='PortDeclaration_CLRAttribute' LowerBound='28.1' HigherBound='29.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='d15bc405-633e-424f-9f09-babc95f1c891' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='30.1' HigherBound='32.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='30' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='FTPRecordTransfer.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EX_R' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='c296e5e0-9e5a-4d06-b791-fdb8ca4b42a5' ParentLink='PortDeclaration_CLRAttribute' LowerBound='30.1' HigherBound='31.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='287e913a-6892-409f-93ad-f89bdd89b426' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='32.1' HigherBound='34.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='FTPRecordTransfer.PortType_2' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EX_R_CPY' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='2e968c1e-4a3e-42cb-889f-7a89564fc6aa' ParentLink='PortDeclaration_CLRAttribute' LowerBound='32.1' HigherBound='33.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __StartExport_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __StartExport_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "StartExport")
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
                StartExport __svc__ = (StartExport)_service;
                __StartExport_root_0 __ctx0__ = (__StartExport_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.EX_P != null)
                {
                    __svc__.EX_P.Close(this, null);
                    __svc__.EX_P = null;
                }
                if (__svc__.EX_R_CPY != null)
                {
                    __svc__.EX_R_CPY.Close(this, null);
                    __svc__.EX_R_CPY = null;
                }
                if (__svc__.EX_R != null)
                {
                    __svc__.EX_R.Close(this, null);
                    __svc__.EX_R = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __StartExport_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __StartExport_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "StartExport")
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
                StartExport __svc__ = (StartExport)_service;
                __StartExport_1 __ctx1__ = (__StartExport_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__ROLogger = null;
                if (__ctx1__ != null)
                    __ctx1__.__ROBTLogger = null;
                if (__ctx1__ != null)
                    __ctx1__.__tmp_str1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__tmp_str2 = null;
                if (__ctx1__ != null)
                    __ctx1__.__TargetSystem = null;
                if (__ctx1__ != null && __ctx1__.__Message_1 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Message_1);
                    __ctx1__.__Message_1 = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__InterfaceName = null;
                if (__ctx1__ != null && __ctx1__.__ExportTransferResultInfo_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ExportTransferResultInfo_msg);
                    __ctx1__.__ExportTransferResultInfo_msg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__LifeToken4Files = null;
                if (__ctx1__ != null)
                    __ctx1__.__type = null;
                if (__ctx1__ != null)
                    __ctx1__.__LifeToken4XProt = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Message_1")]
            public __messagetype_FTPIssueTransfer_StartExportRequest __Message_1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ExportTransferResultInfo_msg")]
            public FTPIssueTransfer.__messagetype_FTPIssueTransfer_TransferResultInformation __ExportTransferResultInfo_msg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ROLogger")]
            internal RB.BTLoggerLibrary.Logger __ROLogger;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ROBTLogger")]
            internal RB.BTLoggerLibrary.BTLogger __ROBTLogger;
            [Microsoft.XLANGs.Core.UserVariableAttribute("InterfaceName")]
            internal System.String __InterfaceName;
            [Microsoft.XLANGs.Core.UserVariableAttribute("TargetSystem")]
            internal System.String __TargetSystem;
            [Microsoft.XLANGs.Core.UserVariableAttribute("LifeToken4XProt")]
            internal System.String __LifeToken4XProt;
            [Microsoft.XLANGs.Core.UserVariableAttribute("LifeToken4Files")]
            internal System.String __LifeToken4Files;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tmp_str1")]
            internal System.String __tmp_str1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("type")]
            internal System.String __type;
            [Microsoft.XLANGs.Core.UserVariableAttribute("tmp_str2")]
            internal System.String __tmp_str2;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("EX_P")]
        internal PortType_5 EX_P;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("EX_R")]
        internal PortType_1 EX_R;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("EX_R_CPY")]
        internal PortType_2 EX_R_CPY;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_5.Operation_1},
                                               typeof(StartExport).GetField("EX_P", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(StartExport), "EX_P"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_1.Operation_1},
                                               typeof(StartExport).GetField("EX_R", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(StartExport), "EX_R"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_2.Operation_1},
                                               typeof(StartExport).GetField("EX_R_CPY", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(StartExport), "EX_R_CPY"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "9b724ee7-8871-406f-a917-e57da6b74875", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "9b724ee7-8871-406f-a917-e57da6b74875", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "4c9b7088-c102-4682-b0d9-c1abe0329dc4", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "4c9b7088-c102-4682-b0d9-c1abe0329dc4", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "3a782c69-63c5-4ad5-a0b1-ef864c78eb6d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "3a782c69-63c5-4ad5-a0b1-ef864c78eb6d", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "f65acc89-027c-413f-9cfd-423df052e7d9", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "f65acc89-027c-413f-9cfd-423df052e7d9", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "d13b7454-2dd6-4a63-adb2-d227eabb12ad", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "d13b7454-2dd6-4a63-adb2-d227eabb12ad", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "46d54810-a7f7-45e8-8aa7-96dc41058398", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "46d54810-a7f7-45e8-8aa7-96dc41058398", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "0c926a80-42d7-4a15-ace2-ddb528e04ccc", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "0c926a80-42d7-4a15-ace2-ddb528e04ccc", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "176c0997-2b05-41f7-9e38-6eab8ab32673", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "176c0997-2b05-41f7-9e38-6eab8ab32673", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "69c11ac5-e61d-4ecb-9e4a-36964d75b382", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "69c11ac5-e61d-4ecb-9e4a-36964d75b382", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,2,2,2,4,4,5,6,6,7,7,7,8,8,9,9,9,9,9,9,9,9,9,9,10,10,10,11,12,12,13,14,14,14,15,16,16,16,17,18,18,19,19,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __StartExport_1 __ctx1__ = (__StartExport_1)_stateMgrs[1];
            __StartExport_root_0 __ctx0__ = (__StartExport_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                EX_P = new PortType_5(0, this);
                EX_R = new PortType_1(1, this);
                EX_R_CPY = new PortType_2(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], EX_P, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __StartExport_1(this);
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
            __StartExport_1 __ctx1__ = (__StartExport_1)_stateMgrs[1];
            __StartExport_root_0 __ctx0__ = (__StartExport_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__ROLogger = default(RB.BTLoggerLibrary.Logger);
                __ctx1__.__ROBTLogger = default(RB.BTLoggerLibrary.BTLogger);
                __ctx1__.__InterfaceName = default(System.String);
                __ctx1__.__TargetSystem = default(System.String);
                __ctx1__.__LifeToken4XProt = default(System.String);
                __ctx1__.__LifeToken4Files = default(System.String);
                __ctx1__.__tmp_str1 = default(System.String);
                __ctx1__.__type = default(System.String);
                __ctx1__.__tmp_str2 = default(System.String);
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
                if (!EX_P.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Message_1 != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Message_1);
                __ctx1__.__Message_1 = new __messagetype_FTPIssueTransfer_StartExportRequest("Message_1", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Message_1);
                EX_P.ReceiveMessage(0, __msgEnv__, __ctx1__.__Message_1, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Message_1);
                    __edata.PortName = @"EX_P";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__ROBTLogger = new RB.BTLoggerLibrary.BTLogger();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__InterfaceName = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__TargetSystem = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__LifeToken4XProt = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__LifeToken4Files = "";
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__tmp_str1 = "";
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__type = "";
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                __ctx1__.__tmp_str2 = "";
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                System.Diagnostics.EventLog.WriteEntry("FTPIssueTransfer", "Export Request received at " + System.String.Format("{0:yyyyMMdd-HHmmssffffff - }", System.DateTime.Now));
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                __ctx1__.__type = "Export";
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                __ctx1__.__ROLogger = __ctx1__.__ROBTLogger.GetLogger((System.String)__ctx1__.__Message_1.part.GetDistinguishedField("InterfaceName"), (System.String)__ctx1__.__Message_1.part.GetDistinguishedField("XProtID"), __ctx1__.__type);
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmssffffff - }", System.DateTime.Now) + "After receiving Request", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                __ctx1__.__InterfaceName = System.Convert.ToString((System.String)__ctx1__.__Message_1.part.GetDistinguishedField("InterfaceName"));
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
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer :InterfaceName  : " + __ctx1__.__InterfaceName, __ctx1__.__ROLogger);
                if (__ctx1__ != null)
                    __ctx1__.__InterfaceName = null;
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                __ctx1__.__TargetSystem = System.Convert.ToString((System.String)__ctx1__.__Message_1.part.GetDistinguishedField("RQ1System"));
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer :TargetSystem  : " + __ctx1__.__TargetSystem, __ctx1__.__ROLogger);
                if (__ctx1__ != null)
                    __ctx1__.__TargetSystem = null;
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                __ctx1__.__LifeToken4XProt = "In Progress";
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer :LifeToken4Xprot  : " + __ctx1__.__LifeToken4XProt, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                __ctx1__.__tmp_str1 = (System.String)__ctx1__.__Message_1.part.GetDistinguishedField("FTPFileNames");
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer :RecordNames  : " + __ctx1__.__tmp_str1, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 31:
                __ctx1__.__LifeToken4Files = __ctx1__.__ROBTLogger.InsertAllTokenStatus(__ctx1__.__tmp_str1, "In Progress", __ctx1__.__type);
                if (__ctx1__ != null)
                    __ctx1__.__type = null;
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : LifeToken4Files  : " + __ctx1__.__LifeToken4Files, __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 35;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                EX_P.SendMessage(0, __ctx1__.__Message_1, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (EX_P != null)
                {
                    EX_P.Close(__ctx1__, __seg__);
                    EX_P = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Message_1);
                    __edata.PortName = @"EX_P";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 38;
            case 38:
                {
                    FTPIssueTransfer.__messagetype_FTPIssueTransfer_TransferResultInformation __ExportTransferResultInfo_msg = new FTPIssueTransfer.__messagetype_FTPIssueTransfer_TransferResultInformation("ExportTransferResultInfo_msg", __ctx1__);

                    ApplyTransform(typeof(FTPIssueTransfer.Map2TransferResultExp), new object[] {__ExportTransferResultInfo_msg.part}, new object[] {__ctx1__.__Message_1.part});
                    __ExportTransferResultInfo_msg.part.SetDistinguishedField("LifeToken4XProt", __ctx1__.__LifeToken4XProt);
                    if (__ctx1__ != null)
                        __ctx1__.__LifeToken4XProt = null;
                    __ExportTransferResultInfo_msg.part.SetDistinguishedField("LifeToken4Files", __ctx1__.__LifeToken4Files);
                    if (__ctx1__ != null)
                        __ctx1__.__LifeToken4Files = null;
                    __ctx1__.__tmp_str1 = (System.String)__ExportTransferResultInfo_msg.part.GetDistinguishedField("RQ1System");
                    __ctx1__.__tmp_str2 = __ctx1__.__tmp_str1.Substring(__ctx1__.__tmp_str1.LastIndexOf("@") + 1);
                    if (__ctx1__ != null)
                        __ctx1__.__tmp_str1 = null;
                    __ExportTransferResultInfo_msg.SetPropertyValue(typeof(FILE.ReceivedFileName), __ctx1__.__tmp_str2 + "_" + (System.String)__ExportTransferResultInfo_msg.part.GetDistinguishedField("XProtID") + "_005_FTPTransferResult_");
                    if (__ctx1__ != null)
                        __ctx1__.__tmp_str2 = null;

                    if (__ctx1__.__ExportTransferResultInfo_msg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__ExportTransferResultInfo_msg);
                    __ctx1__.__ExportTransferResultInfo_msg = __ExportTransferResultInfo_msg;
                    __ctx1__.RefMessage(__ctx1__.__ExportTransferResultInfo_msg);
                }
                __ctx1__.__ExportTransferResultInfo_msg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__ExportTransferResultInfo_msg);
                    __edata.Messages.Add(__ctx1__.__Message_1);
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Message_1 != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Message_1);
                    __ctx1__.__Message_1 = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 40;
            case 40:
                if ( !PreProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 41;
            case 41:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 42;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                EX_R.SendMessage(0, __ctx1__.__ExportTransferResultInfo_msg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (EX_R != null)
                {
                    EX_R.Close(__ctx1__, __seg__);
                    EX_R = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 43;
            case 43:
                if ( !PreProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__ExportTransferResultInfo_msg);
                    __edata.PortName = @"EX_R";
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 44;
            case 44:
                if ( !PreProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 45;
            case 45:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 46;
            case 46:
                if ( !PreProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                EX_R_CPY.SendMessage(0, __ctx1__.__ExportTransferResultInfo_msg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (EX_R_CPY != null)
                {
                    EX_R_CPY.Close(__ctx1__, __seg__);
                    EX_R_CPY = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 47;
            case 47:
                if ( !PreProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__ExportTransferResultInfo_msg);
                    __edata.PortName = @"EX_R_CPY";
                    Tracker.FireEvent(__eventLocations[17],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__ExportTransferResultInfo_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ExportTransferResultInfo_msg);
                    __ctx1__.__ExportTransferResultInfo_msg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 48;
            case 48:
                if ( !PreProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 49;
            case 49:
                __ctx1__.__ROBTLogger.WriteLog(System.String.Format("{0:yyyyMMdd-HHmmss - }", System.DateTime.Now) + "FTPIssueTransfer : " + "Export Transfer Result Information file is successfully generated", __ctx1__.__ROLogger);
                if ( !PostProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 50;
            case 50:
                if ( !PreProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 51;
            case 51:
                __ctx1__.__ROBTLogger.CloseLogger(__ctx1__.__ROLogger);
                if (__ctx1__ != null)
                    __ctx1__.__ROBTLogger = null;
                if (__ctx1__ != null)
                    __ctx1__.__ROLogger = null;
                if ( !PostProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 52;
            case 52:
                if ( !PreProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 53;
            case 53:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 54 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 54;
            case 54:
                if ( !PreProgressInc( __seg__, __ctx__, 55 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 55;
            case 55:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __FTPIssueTransfer_StartExportRequest__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static FTPIssueTransfer.StartExportRequest _schema = new FTPIssueTransfer.StartExportRequest();

        public __FTPIssueTransfer_StartExportRequest__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "FTPIssueTransfer.StartExportRequest",
        new System.Type[]{
            typeof(FTPIssueTransfer.StartExportRequest)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__FTPIssueTransfer_StartExportRequest__)
        },
        0,
        @"http://FTPIssueTransfer.StartExportRequest#ExportRequest"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_FTPIssueTransfer_StartExportRequest : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __FTPIssueTransfer_StartExportRequest__ part;

        private void __CreatePartWrappers()
        {
            part = new __FTPIssueTransfer_StartExportRequest__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_FTPIssueTransfer_StartExportRequest(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
