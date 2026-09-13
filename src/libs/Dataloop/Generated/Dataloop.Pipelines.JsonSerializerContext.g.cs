
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Dataloop
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Dictionary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResource), TypeInfoPropertyName = "QueryResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RequestSource), TypeInfoPropertyName = "RequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Boolean), TypeInfoPropertyName = "Boolean_Dataloop_Boolean")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Context))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IAppDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionStatusReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionStatusName), TypeInfoPropertyName = "ExecutionStatusName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemStatusEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemStatusEventStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionEventContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResourceType), TypeInfoPropertyName = "ResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ExecutionStatusReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AuthZBlockExecutionContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ExecutionResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionMode), TypeInfoPropertyName = "ExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionHook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionPhase), TypeInfoPropertyName = "ExecutionPhase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OnResetAction), TypeInfoPropertyName = "OnResetAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageResourceType), TypeInfoPropertyName = "PackageResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionHookValueFrom), TypeInfoPropertyName = "ExecutionHookValueFrom2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionHookType), TypeInfoPropertyName = "ExecutionHookType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IPipelineExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerType), TypeInfoPropertyName = "TriggerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceLogLevel), TypeInfoPropertyName = "ServiceLogLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceLogEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ServiceLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LogsListDirection), TypeInfoPropertyName = "LogsListDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LogQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CompositionStatus), TypeInfoPropertyName = "CompositionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerResourceType), TypeInfoPropertyName = "TriggerResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerActionType), TypeInfoPropertyName = "TriggerActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerOperationType), TypeInfoPropertyName = "TriggerOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.TriggerActionType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageConfigType), TypeInfoPropertyName = "PackageConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageRequirementOperator), TypeInfoPropertyName = "PackageRequirementOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CodebaseType), TypeInfoPropertyName = "CodebaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Codebase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.PackageRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TemplateKind), TypeInfoPropertyName = "TemplateKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.INodeConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.INodeConfigPackage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.NodeNamespace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PortIO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.NodeType), TypeInfoPropertyName = "NodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PipelineNodeDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.PortIO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PipelineNodeSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PipelineNodeTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PipelineConnection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.StartNodeType), TypeInfoPropertyName = "StartNodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ITriggerSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ITriggerSpecSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IStartNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResumePipelineOption), TypeInfoPropertyName = "ResumePipelineOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IPipelineSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IPipelineSettingsLastUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PipelineVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PipelineFromTemplateState), TypeInfoPropertyName = "PipelineFromTemplateState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.PipelineNodeDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.PipelineConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IStartNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.PipelineVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIPipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIPipelineTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.ExecutionContext>), TypeInfoPropertyName = "AllOfContextExecutionContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, double?>), TypeInfoPropertyName = "AnyOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialExecutionSyncReplyTo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ENodeStatus), TypeInfoPropertyName = "ENodeStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IPipelineNodeState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EPipelineStatus), TypeInfoPropertyName = "EPipelineStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.INodeTransitionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIPipelineState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Dataloop.PartialExecution>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.PartialExecution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IPipelineNodeState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.INodeTransitionError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIPipeline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPIPipelineState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIPipelineState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CycleRerunMethod), TypeInfoPropertyName = "CycleRerunMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IRerunCycleOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.JsExecuteOptionsBatchQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.JsExecuteOptionsBatchQueryContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IExecuteOptionsBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IRerunCycleBatchOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionLogs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PipelineExecutionLogs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ExecutionLogs>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IPostPipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IPipelineExecutionCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IExecutionCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.INodeExecutionCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IExecutionCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IExecutionStatistics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.INodeExecutionStatistics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IPipelineStatistics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IPipelineExecutionCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.INodeExecutionCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.INodeExecutionStatistics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PipelineType), TypeInfoPropertyName = "PipelineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ITextSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialIPipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialIPipelineTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PipelineVersionListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPagePipelineVersionListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.PipelineVersionListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIPipelineVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutePipelinePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecuteOptionsBatchQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecuteOptionsBatchQueryContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecuteOptionsBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecuteOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.NodeDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CompositionStatusDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPIPipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PipelineNodeCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InstallRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UninstallRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LogsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.APICommand>), TypeInfoPropertyName = "AnyOfAPIPipelineStateAPICommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TerminateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.PipelineExecutionLogs>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResource?), TypeInfoPropertyName = "NullableQueryResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RequestSource?), TypeInfoPropertyName = "NullableRequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionStatusName?), TypeInfoPropertyName = "NullableExecutionStatusName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResourceType?), TypeInfoPropertyName = "NullableResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionMode?), TypeInfoPropertyName = "NullableExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionPhase?), TypeInfoPropertyName = "NullableExecutionPhase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OnResetAction?), TypeInfoPropertyName = "NullableOnResetAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageResourceType?), TypeInfoPropertyName = "NullablePackageResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionHookValueFrom?), TypeInfoPropertyName = "NullableExecutionHookValueFrom2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionHookType?), TypeInfoPropertyName = "NullableExecutionHookType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerType?), TypeInfoPropertyName = "NullableTriggerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceLogLevel?), TypeInfoPropertyName = "NullableServiceLogLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LogsListDirection?), TypeInfoPropertyName = "NullableLogsListDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CompositionStatus?), TypeInfoPropertyName = "NullableCompositionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerResourceType?), TypeInfoPropertyName = "NullableTriggerResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerActionType?), TypeInfoPropertyName = "NullableTriggerActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerOperationType?), TypeInfoPropertyName = "NullableTriggerOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageConfigType?), TypeInfoPropertyName = "NullablePackageConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageRequirementOperator?), TypeInfoPropertyName = "NullablePackageRequirementOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CodebaseType?), TypeInfoPropertyName = "NullableCodebaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TemplateKind?), TypeInfoPropertyName = "NullableTemplateKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.NodeType?), TypeInfoPropertyName = "NullableNodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.StartNodeType?), TypeInfoPropertyName = "NullableStartNodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResumePipelineOption?), TypeInfoPropertyName = "NullableResumePipelineOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PipelineFromTemplateState?), TypeInfoPropertyName = "NullablePipelineFromTemplateState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.ExecutionContext>?), TypeInfoPropertyName = "NullableAllOfContextExecutionContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, double?>?), TypeInfoPropertyName = "NullableAnyOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ENodeStatus?), TypeInfoPropertyName = "NullableENodeStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EPipelineStatus?), TypeInfoPropertyName = "NullableEPipelineStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CycleRerunMethod?), TypeInfoPropertyName = "NullableCycleRerunMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PipelineType?), TypeInfoPropertyName = "NullablePipelineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.APICommand>?), TypeInfoPropertyName = "NullableAnyOfAPIPipelineStateAPICommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ExecutionStatusReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ExecutionResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ServiceLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.TriggerActionType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PackageRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PortIO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PipelineNodeDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PipelineConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IStartNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PipelineVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Dataloop.PartialExecution>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PartialExecution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IPipelineNodeState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.INodeTransitionError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIPipeline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIPipelineState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ExecutionLogs>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IExecutionCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IPipelineExecutionCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.INodeExecutionCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.INodeExecutionStatistics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PipelineVersionListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PipelineExecutionLogs>))]
    internal sealed partial class PipelinesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PipelinesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PipelinesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private PipelinesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.ExecutionContext>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<object, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, object>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIPipelineState, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<object, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Dataloop.QueryResource)

                    || typeToConvert == typeof(global::Dataloop.QueryResource?)

                    || typeToConvert == typeof(global::Dataloop.RequestSource)

                    || typeToConvert == typeof(global::Dataloop.RequestSource?)

                    || typeToConvert == typeof(global::Dataloop.OnResetAction)

                    || typeToConvert == typeof(global::Dataloop.OnResetAction?)

                    || typeToConvert == typeof(global::Dataloop.PackageResourceType)

                    || typeToConvert == typeof(global::Dataloop.PackageResourceType?)

                    || typeToConvert == typeof(global::Dataloop.ExecutionHookValueFrom)

                    || typeToConvert == typeof(global::Dataloop.ExecutionHookValueFrom?)

                    || typeToConvert == typeof(global::Dataloop.ExecutionHookType)

                    || typeToConvert == typeof(global::Dataloop.ExecutionHookType?)

                    || typeToConvert == typeof(global::Dataloop.ExecutionStatusName)

                    || typeToConvert == typeof(global::Dataloop.ExecutionStatusName?)

                    || typeToConvert == typeof(global::Dataloop.ResourceType)

                    || typeToConvert == typeof(global::Dataloop.ResourceType?)

                    || typeToConvert == typeof(global::Dataloop.TriggerType)

                    || typeToConvert == typeof(global::Dataloop.TriggerType?)

                    || typeToConvert == typeof(global::Dataloop.ServiceLogLevel)

                    || typeToConvert == typeof(global::Dataloop.ServiceLogLevel?)

                    || typeToConvert == typeof(global::Dataloop.LogsListDirection)

                    || typeToConvert == typeof(global::Dataloop.LogsListDirection?)

                    || typeToConvert == typeof(global::Dataloop.CompositionStatus)

                    || typeToConvert == typeof(global::Dataloop.CompositionStatus?)

                    || typeToConvert == typeof(global::Dataloop.TriggerResourceType)

                    || typeToConvert == typeof(global::Dataloop.TriggerResourceType?)

                    || typeToConvert == typeof(global::Dataloop.TriggerActionType)

                    || typeToConvert == typeof(global::Dataloop.TriggerActionType?)

                    || typeToConvert == typeof(global::Dataloop.ExecutionMode)

                    || typeToConvert == typeof(global::Dataloop.ExecutionMode?)

                    || typeToConvert == typeof(global::Dataloop.TriggerOperationType)

                    || typeToConvert == typeof(global::Dataloop.TriggerOperationType?)

                    || typeToConvert == typeof(global::Dataloop.PackageConfigType)

                    || typeToConvert == typeof(global::Dataloop.PackageConfigType?)

                    || typeToConvert == typeof(global::Dataloop.PackageRequirementOperator)

                    || typeToConvert == typeof(global::Dataloop.PackageRequirementOperator?)

                    || typeToConvert == typeof(global::Dataloop.CodebaseType)

                    || typeToConvert == typeof(global::Dataloop.CodebaseType?)

                    || typeToConvert == typeof(global::Dataloop.TemplateKind)

                    || typeToConvert == typeof(global::Dataloop.TemplateKind?)

                    || typeToConvert == typeof(global::Dataloop.NodeType)

                    || typeToConvert == typeof(global::Dataloop.NodeType?)

                    || typeToConvert == typeof(global::Dataloop.StartNodeType)

                    || typeToConvert == typeof(global::Dataloop.StartNodeType?)

                    || typeToConvert == typeof(global::Dataloop.ResumePipelineOption)

                    || typeToConvert == typeof(global::Dataloop.ResumePipelineOption?)

                    || typeToConvert == typeof(global::Dataloop.PipelineFromTemplateState)

                    || typeToConvert == typeof(global::Dataloop.PipelineFromTemplateState?)

                    || typeToConvert == typeof(global::Dataloop.ExecutionPhase)

                    || typeToConvert == typeof(global::Dataloop.ExecutionPhase?)

                    || typeToConvert == typeof(global::Dataloop.ENodeStatus)

                    || typeToConvert == typeof(global::Dataloop.ENodeStatus?)

                    || typeToConvert == typeof(global::Dataloop.EPipelineStatus)

                    || typeToConvert == typeof(global::Dataloop.EPipelineStatus?)

                    || typeToConvert == typeof(global::Dataloop.CycleRerunMethod)

                    || typeToConvert == typeof(global::Dataloop.CycleRerunMethod?)

                    || typeToConvert == typeof(global::Dataloop.PipelineType)

                    || typeToConvert == typeof(global::Dataloop.PipelineType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Dataloop.QueryResource))
                {
                    return new global::Dataloop.JsonConverters.QueryResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QueryResource?))
                {
                    return new global::Dataloop.JsonConverters.QueryResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.RequestSource))
                {
                    return new global::Dataloop.JsonConverters.RequestSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.RequestSource?))
                {
                    return new global::Dataloop.JsonConverters.RequestSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OnResetAction))
                {
                    return new global::Dataloop.JsonConverters.OnResetActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OnResetAction?))
                {
                    return new global::Dataloop.JsonConverters.OnResetActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PackageResourceType))
                {
                    return new global::Dataloop.JsonConverters.PackageResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PackageResourceType?))
                {
                    return new global::Dataloop.JsonConverters.PackageResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionHookValueFrom))
                {
                    return new global::Dataloop.JsonConverters.ExecutionHookValueFromJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionHookValueFrom?))
                {
                    return new global::Dataloop.JsonConverters.ExecutionHookValueFromNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionHookType))
                {
                    return new global::Dataloop.JsonConverters.ExecutionHookTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionHookType?))
                {
                    return new global::Dataloop.JsonConverters.ExecutionHookTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionStatusName))
                {
                    return new global::Dataloop.JsonConverters.ExecutionStatusNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionStatusName?))
                {
                    return new global::Dataloop.JsonConverters.ExecutionStatusNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ResourceType))
                {
                    return new global::Dataloop.JsonConverters.ResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ResourceType?))
                {
                    return new global::Dataloop.JsonConverters.ResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TriggerType))
                {
                    return new global::Dataloop.JsonConverters.TriggerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TriggerType?))
                {
                    return new global::Dataloop.JsonConverters.TriggerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ServiceLogLevel))
                {
                    return new global::Dataloop.JsonConverters.ServiceLogLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ServiceLogLevel?))
                {
                    return new global::Dataloop.JsonConverters.ServiceLogLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.LogsListDirection))
                {
                    return new global::Dataloop.JsonConverters.LogsListDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.LogsListDirection?))
                {
                    return new global::Dataloop.JsonConverters.LogsListDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CompositionStatus))
                {
                    return new global::Dataloop.JsonConverters.CompositionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CompositionStatus?))
                {
                    return new global::Dataloop.JsonConverters.CompositionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TriggerResourceType))
                {
                    return new global::Dataloop.JsonConverters.TriggerResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TriggerResourceType?))
                {
                    return new global::Dataloop.JsonConverters.TriggerResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TriggerActionType))
                {
                    return new global::Dataloop.JsonConverters.TriggerActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TriggerActionType?))
                {
                    return new global::Dataloop.JsonConverters.TriggerActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionMode))
                {
                    return new global::Dataloop.JsonConverters.ExecutionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionMode?))
                {
                    return new global::Dataloop.JsonConverters.ExecutionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TriggerOperationType))
                {
                    return new global::Dataloop.JsonConverters.TriggerOperationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TriggerOperationType?))
                {
                    return new global::Dataloop.JsonConverters.TriggerOperationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PackageConfigType))
                {
                    return new global::Dataloop.JsonConverters.PackageConfigTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PackageConfigType?))
                {
                    return new global::Dataloop.JsonConverters.PackageConfigTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PackageRequirementOperator))
                {
                    return new global::Dataloop.JsonConverters.PackageRequirementOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PackageRequirementOperator?))
                {
                    return new global::Dataloop.JsonConverters.PackageRequirementOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CodebaseType))
                {
                    return new global::Dataloop.JsonConverters.CodebaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CodebaseType?))
                {
                    return new global::Dataloop.JsonConverters.CodebaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TemplateKind))
                {
                    return new global::Dataloop.JsonConverters.TemplateKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TemplateKind?))
                {
                    return new global::Dataloop.JsonConverters.TemplateKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.NodeType))
                {
                    return new global::Dataloop.JsonConverters.NodeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.NodeType?))
                {
                    return new global::Dataloop.JsonConverters.NodeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.StartNodeType))
                {
                    return new global::Dataloop.JsonConverters.StartNodeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.StartNodeType?))
                {
                    return new global::Dataloop.JsonConverters.StartNodeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ResumePipelineOption))
                {
                    return new global::Dataloop.JsonConverters.ResumePipelineOptionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ResumePipelineOption?))
                {
                    return new global::Dataloop.JsonConverters.ResumePipelineOptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PipelineFromTemplateState))
                {
                    return new global::Dataloop.JsonConverters.PipelineFromTemplateStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PipelineFromTemplateState?))
                {
                    return new global::Dataloop.JsonConverters.PipelineFromTemplateStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionPhase))
                {
                    return new global::Dataloop.JsonConverters.ExecutionPhaseJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionPhase?))
                {
                    return new global::Dataloop.JsonConverters.ExecutionPhaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ENodeStatus))
                {
                    return new global::Dataloop.JsonConverters.ENodeStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ENodeStatus?))
                {
                    return new global::Dataloop.JsonConverters.ENodeStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EPipelineStatus))
                {
                    return new global::Dataloop.JsonConverters.EPipelineStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EPipelineStatus?))
                {
                    return new global::Dataloop.JsonConverters.EPipelineStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CycleRerunMethod))
                {
                    return new global::Dataloop.JsonConverters.CycleRerunMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CycleRerunMethod?))
                {
                    return new global::Dataloop.JsonConverters.CycleRerunMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PipelineType))
                {
                    return new global::Dataloop.JsonConverters.PipelineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PipelineType?))
                {
                    return new global::Dataloop.JsonConverters.PipelineTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new PipelinesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}