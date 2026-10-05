# BizTalk-to-Azure migration assessment

**Status:** Initial repository-based assessment; not an approved target architecture or cutover plan.  
**Evidence reviewed:** The five XML exports in `Exported_binidngs/`, BizTalk project files, the BizTalk deployment project and inventory, and the standalone DBMapper SQL binding. The exported bindings report `FullyBound`; their `Started` service states describe the export snapshot and do not prove current production status.

## 1. Scope and goals

The repository does not establish the migration scope, business priority, Azure region, hosting constraints, or whether this is a rehost-first or modernization program. For planning, treat the five applications with exported bindings as the **initial assessment scope**, not as confirmed production scope:

| Application in binding export | Evidence in repository | Exported endpoints and notable dependencies |
| --- | --- | --- |
| `RB.BT.ROCustomerInterface` | Binding export and BizTalk project | 4 orchestration services; 19 send ports and 2 receive ports in the collections; FILE endpoints plus one WCF-Custom web-service send port. The project declares 4 orchestrations, 20 schemas, 44 maps, and a reference to `RB.ROCustomerInterfaceLibrary`. |
| `FTPIssueTransfer` | Binding export and BizTalk project | 3 orchestration services; 10 send ports and 3 receive ports; FILE and SOAP endpoints, including three SOAP send ports and a SOAP receive port. The project declares 5 orchestrations, 8 schemas, 4 maps, a custom pipeline, a `ChangeMessagePipeline` project reference, and references to `BTLogger` and `FTPLibrary`. |
| `RB.BT.ROBinaryComparison` | Binding export and BizTalk project | 1 orchestration service; 3 FILE send ports and 1 FILE receive port. The project declares 1 orchestration, 2 schemas, and a `RB.BT.ROBinaryComparisonLibrary` project reference. |
| `FTPGetNames` | Binding export and BizTalk project | 1 orchestration service; 1 SOAP receive port. The project declares 1 orchestration and 2 schemas. |
| `RB.BT.ROASAMScheduler` | Binding export only | 2 orchestration services; 1 FILE send port and 4 scheduled receive ports covering AUDI, BMW, DAIMLER, and XPROT flows. No scheduler BizTalk project is present in this checkout. |

The exports contain legacy Windows `D:\` file locations, internal SOAP/WCF service URLs, and schedule URIs. Exact endpoint values should be verified against the deployment environment and should not be treated as approved Azure configuration.

**External-system view from the binding labels:** `FTPIssueTransfer` names Daimler, BMW, and BMW-CC SOAP services; `RB.BT.ROCustomerInterface` has a WCF-Custom endpoint labelled for the HIS `vwid2ttn` service; `FTPGetNames` exposes a SOAP request-response receive endpoint, but its consumers are not identified. The scheduler emits a file for its XPROT handler, while the other observed FILE ports use shared-directory inputs and outputs. These labels are clues for discovery, not confirmation of current ownership, connectivity, or production use.

**Related but unconfirmed scope:** `DBMapper` has a BizTalk project and a separate SQL adapter binding dated 2013, but no matching export under `Exported_binidngs/`. The binding targets `localhost` and names an HIS simulation database, so it is not evidence of a current production dependency. The `RB.ROCustomerInterfaceExport` BizTalk project is also present without a corresponding application export. Confirm whether either project is deployed or in scope before sizing migration work.

## 2. Inventory and deployment gaps

- All five files in `Exported_binidngs/` report `BindingStatus="FullyBound"`; the XML records endpoint counts of 1, 13, 5, 4, and 20 respectively. Those counts are the export metadata, not necessarily a count of port elements (for example, the customer-interface collections contain 21 port elements).
- The bindings record Windows FILE shares, SOAP or WCF integrations, and schedule-triggered work. They do **not** establish actual runtime throughput, message volumes, business criticality, SLAs, current credentials, or whether each configured port is enabled in production.
- `FTPIssueTransfer` includes one dynamic send port whose binding lists many possible adapter types. That list is an adapter catalog, not proof that every listed adapter is used. Treat the concrete FILE and SOAP endpoints as observed configuration and verify actual adapter use with BizTalk administration/runtime exports.
- `Validation-Execution-Engine/BizTalkDeployServerApplication/Binding.xml` is empty (`NoBindings`, zero endpoints). `BizTalkServerInventory.json` points to a separate binding file staged under `bin\\Debug`, rather than sourcing a checked-in application binding. Make environment-specific bindings explicit and reproducible before using the deployment project for migration or cutover.
- Every BizTalk project examined targets .NET Framework 4.7.2. This includes custom .NET libraries and a custom pipeline component, which need compatibility and behavior assessments before replacement or rehosting.
- The scheduler application’s source artifacts are not in this checkout. The ASAM export project and DBMapper must likewise be checked against deployment records before adding them to the committed scope.

## 3. Main migration risks and discovery work

| Risk / hotspot | What repository evidence shows | Required discovery |
| --- | --- | --- |
| File-system coupling | Many ports poll or write to `D:\ASAM-IF-IMPORT\...` paths. | Identify actual shares, file sizes, polling intervals, arrival patterns, naming conventions, archive/retention behavior, locking, and permissions. Decide on Azure Storage or another supported target and prove hybrid access before redesign. |
| SOAP and WCF contracts | `FTPGetNames`, `FTPIssueTransfer`, and `RB.BT.ROCustomerInterface` have SOAP/WCF endpoints. | Confirm consumers, SOAP versions, schemas/WSDL, authentication, TLS, firewall/DNS routes, timeout/retry semantics, and whether clients can be changed. |
| Schedules | The scheduler export has four Schedule-adapter receive ports and a FILE output; its source project is missing. | Obtain scheduler source and production schedule definitions. Record time zone, daylight-saving behavior, missed-run handling, overlap/concurrency behavior, and operational ownership. |
| Custom processing | `FTPIssueTransfer` references a custom pipeline component and shared libraries; binary comparison and customer-interface also depend on custom libraries. | Review source, deployment versions, native/COM dependencies, error behavior, and licensing. Reimplement and test behavior where BizTalk-specific runtime dependencies cannot be retained. |
| Complex transformations and orchestration | Customer-interface declares 44 maps, 20 schemas, and 4 orchestrations; transfer declares multiple maps and orchestrations. | Trace each map/orchestration to business flows, message correlation, transactions, compensation, ordered delivery, and acknowledgement semantics. Identify dormant or duplicate artifacts. |
| Data access | The separate DBMapper SQL binding is old and points to a local simulation database. | Establish if DBMapper is actually deployed; if so, identify the real database, operations, transaction/isolation requirements, polling behavior, identity model, and data residency. |
| Security and environment drift | Binding files contain internal endpoints and machine paths; the deployment binding file is empty. | Inspect all deployed bindings for credentials or sensitive properties; rotate any exposed secrets. Define per-environment endpoints, managed identities/service principals, Key Vault references, network controls, certificate ownership, and audit requirements. |
| Operational equivalence | Binding metadata does not provide volume or recovery objectives. | Obtain representative message samples, peak/average rates, backlog limits, error/replay procedures, duplicate handling, RTO/RPO, monitoring, and on-call expectations. |

## 4. Target options

Microsoft’s current BizTalk migration material describes Azure Logic Apps as a migration target and recommends selecting an approach based on the solution and migrating incrementally. Do not assume a BizTalk binding file can be imported as a production-ready Logic Apps configuration: bindings are discovery evidence, while workflows, connectors, state, identity, deployment, and operations must be designed and validated for the target.

| Option | When it may fit | Trade-offs for this repository |
| --- | --- | --- |
| **Rehost BizTalk on Azure virtual machines as an interim step** | The business requires continuity with limited initial process changes and can retain BizTalk expertise and licensing. | Preserves much of the BizTalk runtime but carries forward Windows/SQL/BizTalk operations and legacy dependencies. It does not deliver a cloud-native redesign or remove the need for a later migration. Validate Microsoft support, licensing, adapter support, topology, and hybrid connectivity before selecting it. |
| **Incrementally modernize on Azure integration services** | The goal is to reduce BizTalk dependency and modernize integration operations. | Assess Logic Apps Standard for workflow integration, with other services (for example, Service Bus, Functions, API Management, and Azure Storage) only where the flow requires them. Rebuild and test semantics; design hybrid connectivity explicitly. More refactoring and contract/behavior testing are required. |
| **Hybrid transition** | Some systems or data must remain on-premises while selected flows move. | Can support phased migration but adds temporary dual operations, routing, identity, monitoring, and duplicate-processing risks. Needs explicit ownership and an exit criterion for each hybrid dependency. |

**Provisional direction:** Unless discovery shows a strong continuity or hosting constraint, plan for incremental modernization rather than assuming a blanket BizTalk rehost. Keep rehosting as a separately costed bridge option, not as an architectural decision already made.

## 5. Provisional migration waves

These are sequencing candidates, subject to scope, usage, and dependency confirmation:

1. **Foundation and discovery:** confirm application owners and deployment status; obtain scheduler source and current environment bindings; collect operational metrics, representative payloads, interface contracts, and security/network requirements. Repair the deployment process so the binding source is explicit and environment-specific.
2. **Pilot candidate — `FTPGetNames`:** the checked-in project and binding show one orchestration and one SOAP receive port, making it a small candidate for validating target deployment, endpoint security, observability, and SOAP contract behavior. Proceed only if it is active, representative enough to prove a valuable pattern, and its consumers can participate in testing.
3. **File and schedule patterns:** assess `RB.BT.ROBinaryComparison` and the scheduler’s file/schedule flows. The scheduler cannot be migrated until its source and schedule behavior are recovered. Preserve file naming, atomicity, ordering, retries, and replay behavior.
4. **Transfer workflows:** decompose `FTPIssueTransfer` by business transaction, including SOAP contracts, custom pipeline behavior, acknowledgements, and file handoffs. Migrate as independently testable slices rather than one application-wide cutover.
5. **Customer-interface and remaining projects:** inventory dependency and usage for the complex customer-interface maps/orchestrations. Confirm scope for DBMapper and `RB.ROCustomerInterfaceExport`; migrate only after their deployed status and downstream dependencies are known.
6. **Cutover and retirement:** use per-flow routing/cutover controls, a defined rollback route, monitored stabilization, and explicit sign-off. Retire BizTalk components only when traffic, replay/backlog, and operational handover criteria are met.

## 6. Connectivity, security, and operations design checklist

- Select Azure region(s), availability/resiliency targets, data residency boundaries, and production/non-production separation.
- Choose and prove the supported connectivity pattern for each on-premises file share, database, and private SOAP/WCF endpoint. Document DNS, routing, firewall rules, certificate trust/renewal, and ownership.
- Store secrets and certificates in an approved secret-management service; use managed identity where supported. Do not copy credentials from binding files into source, workflow definitions, or deployment parameters.
- Externalize endpoint addresses and environment-specific values. Use least-privilege service identities and record access/audit requirements.
- Define message durability, poison-message handling, retries/backoff, idempotency, duplicate detection, ordering, and replay procedures for each integration.
- Specify centralized logs, metrics, traces, business correlation identifiers, dashboards, alert thresholds, retention, and on-call runbooks.
- Establish backup/recovery, deployment promotion, infrastructure-as-code, approval gates, and a rollback plan for every migration wave.

## 7. Equivalence and cutover gates

Do not cut over a flow until business and technical owners approve evidence for:

- Valid, invalid, boundary, large, and representative production-shaped messages; schema validation and transformation output.
- Normal, timeout, transient, permanent, and downstream-unavailable paths; retry count/interval behavior and poison-message recovery.
- Duplicate delivery, idempotency, ordering, correlation, acknowledgements, and partial-failure/replay behavior.
- Schedule timing (including time-zone and daylight-saving transitions), missed/overlapping runs, and peak throughput/backlog recovery.
- Endpoint authentication, authorization, certificates, secret rotation, network restrictions, and audit logging.
- Production monitoring, alert delivery, runbooks, support ownership, rollback, and reconciliation of in-flight messages.

Where dual execution is safe, compare outputs in shadow mode without allowing duplicate side effects. Otherwise compare controlled test/replay inputs and reconcile outputs before directing production traffic to the target.

## 8. Decisions needed from stakeholders

1. Which of the five bound applications are production scope? Are DBMapper and `RB.ROCustomerInterfaceExport` in use? Can the scheduler source and deployed application inventory be supplied?
2. Is the primary objective a fast continuity move, a long-term BizTalk exit, or a hybrid of the two?
3. Must any systems, data, or processing remain on-premises? Which Azure regions and security/compliance controls are mandatory?
4. What are normal/peak volumes, message-size limits, availability target, RTO/RPO, and required retention?
5. Can SOAP consumers or file producers/consumers change contracts, endpoint URLs, or file locations?
6. Who owns each application, customer interface, connection, and operational runbook? What are the acceptable migration windows and rollback limits?

Until these are answered, application priority, Azure service selection, estimates, and cutover dates remain provisional.

## References

- [BizTalk Server migration overview for Azure Logic Apps](https://learn.microsoft.com/azure/logic-apps/biztalk-server-migration-overview)
- [Migration approaches for BizTalk Server to Azure Logic Apps](https://learn.microsoft.com/azure/logic-apps/biztalk-server-migration-approaches)
- [BizTalk Server 2020 lifecycle](https://learn.microsoft.com/lifecycle/products/biztalk-server-2020)
