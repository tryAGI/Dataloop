
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIComposition>, global::System.Collections.Generic.IList<global::Dataloop.APIPipeline>, global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.IList<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.IList<global::Dataloop.APIDpk>, global::System.Collections.Generic.IList<global::Dataloop.APIApp>, global::System.Collections.Generic.IList<global::Dataloop.APICompute>, global::System.Collections.Generic.IList<global::Dataloop.APIServiceDriver>>), TypeInfoPropertyName = "APIServiceDriver_0708f4328c68aea5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIComposition>, global::System.Collections.Generic.IList<global::Dataloop.APIPipeline>, global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.IList<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.IList<global::Dataloop.APIDpk>, global::System.Collections.Generic.IList<global::Dataloop.APIApp>, global::System.Collections.Generic.IList<global::Dataloop.APICompute>, global::System.Collections.Generic.IList<global::Dataloop.APIServiceDriver>>?), TypeInfoPropertyName = "APIServiceDriver_c0617c242689fb32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIComposition>, global::System.Collections.Generic.List<global::Dataloop.APIPipeline>, global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.List<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.List<global::Dataloop.APIDpk>, global::System.Collections.Generic.List<global::Dataloop.APIApp>, global::System.Collections.Generic.List<global::Dataloop.APICompute>, global::System.Collections.Generic.List<global::Dataloop.APIServiceDriver>>), TypeInfoPropertyName = "APIServiceDriver_ce74abc722e1be30")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResource), TypeInfoPropertyName = "QueryResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnnotationType), TypeInfoPropertyName = "AnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RequestSource), TypeInfoPropertyName = "RequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Context))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskType), TypeInfoPropertyName = "TaskType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskStatus), TypeInfoPropertyName = "TaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskWorkload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.TaskWorkload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Role), TypeInfoPropertyName = "Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EntityScopeLevel), TypeInfoPropertyName = "EntityScopeLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelStatus), TypeInfoPropertyName = "ModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<double?, string>), TypeInfoPropertyName = "AnyOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelInputType), TypeInfoPropertyName = "ModelInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOutputType), TypeInfoPropertyName = "ModelOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOutputTypeVariant2), TypeInfoPropertyName = "ModelOutputTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOutputTypeVariant4), TypeInfoPropertyName = "ModelOutputTypeVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EntityContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReferenceType), TypeInfoPropertyName = "ReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EntityReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.EntityReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IAppDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOperationTypes), TypeInfoPropertyName = "ModelOperationTypes2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceRuntime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Panel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IServiceAppConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceType), TypeInfoPropertyName = "ServiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CrashloopAction), TypeInfoPropertyName = "CrashloopAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CrashloopReason), TypeInfoPropertyName = "CrashloopReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Crashloop))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceModeType), TypeInfoPropertyName = "ServiceModeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComputeConsumptionMethod), TypeInfoPropertyName = "EComputeConsumptionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SystemRefs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.ServiceMetadataUser, global::Dataloop.Dictionary>), TypeInfoPropertyName = "AllOfServiceMetadataUserDictionary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceMetadataUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceMetadataMl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.ServiceMetadataSystem, global::Dataloop.SystemRefs, global::Dataloop.Dictionary>), TypeInfoPropertyName = "AllOfServiceMetadataSystemSystemRefsDictionary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceMetadataSystem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IServiceGeneralSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.Panel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ServiceIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageResourceType), TypeInfoPropertyName = "PackageResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionHookValueFrom), TypeInfoPropertyName = "ExecutionHookValueFrom2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionHookType), TypeInfoPropertyName = "ExecutionHookType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageIO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageIOIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UiBindingResource), TypeInfoPropertyName = "UiBindingResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UiBindingPanel), TypeInfoPropertyName = "UiBindingPanel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DisplayScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionPostActionType), TypeInfoPropertyName = "ExecutionPostActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionPostAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DLFunctionDefaultInputSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DLFunctionInputOptionsSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DLFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.PackageIO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DisplayScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DLFunctionDefaultInputSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DLFunctionInputOptionsSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IPipelineExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerType), TypeInfoPropertyName = "TriggerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EntityReferenceMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaaSCacheSize), TypeInfoPropertyName = "FaaSCacheSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaaSCacheType), TypeInfoPropertyName = "FaaSCacheType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceDriverType), TypeInfoPropertyName = "ServiceDriverType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IComputeContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DataloopPodType), TypeInfoPropertyName = "DataloopPodType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverToleration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverTolerationConditions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DriverCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverNodeSelector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverNodeSelectorConditions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CacheRunner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputeMetadata), TypeInfoPropertyName = "ComputeMetadata2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputeMetadataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputeMetadataVariant2ServeAgentGateway), TypeInfoPropertyName = "ComputeMetadataVariant2ServeAgentGateway2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DriverNodeSelector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DriverToleration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DataloopPodType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIServiceDriver))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CompositionElementStatus), TypeInfoPropertyName = "CompositionElementStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIServiceCompositionElement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIServiceCompositionElementState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CompositionStatus), TypeInfoPropertyName = "CompositionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionErrorContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerResourceType), TypeInfoPropertyName = "TriggerResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerActionType), TypeInfoPropertyName = "TriggerActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerOperationType), TypeInfoPropertyName = "TriggerOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionTrigger))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionTriggerSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.TriggerActionType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ECompositionPackageStatus), TypeInfoPropertyName = "ECompositionPackageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialModule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DLFunction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageConfigType), TypeInfoPropertyName = "PackageConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageRequirementOperator), TypeInfoPropertyName = "PackageRequirementOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CodebaseType), TypeInfoPropertyName = "CodebaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Codebase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionPackage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionPackageState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.PackageRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionTaskState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.Dictionary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionElementState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICompositionModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ChannelType), TypeInfoPropertyName = "ChannelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CompositionChannelStatus), TypeInfoPropertyName = "CompositionChannelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.NotificationEntityContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FilterTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.NotificationEventContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionFilterState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionChannelMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionChannelState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ICompositionFilter>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionPipelineTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.PipelineNodeDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.PipelineConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IStartNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.PipelineVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionPipelineTemplateTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionPipelineTemplateState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionDatasetState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionDatasetStateDataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionDatasetStateDatasetIndexDriver), TypeInfoPropertyName = "ICompositionDatasetStateDatasetIndexDriver2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionDatasetStateDatasetShareLevel), TypeInfoPropertyName = "ICompositionDatasetStateDatasetShareLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionDatasetStateDatasetExport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ICompositionDatasetStateDatasetAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionDatasetStateDatasetAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TextSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.MqDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AuthZBlockServiceContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.ServiceContext>), TypeInfoPropertyName = "AllOfContextServiceContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialService))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DpkDatasetOntologyType), TypeInfoPropertyName = "DpkDatasetOntologyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionDataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionDatasetOntology))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionDatasetInvoke))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIComposition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIServiceCompositionElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.ICompositionError, string>), TypeInfoPropertyName = "AnyOfICompositionErrorString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ICompositionTrigger>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ICompositionPackage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ICompositionTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APICompositionModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ICompositionChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ICompositionPipelineTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ICompositionDataset>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IPipelineState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<double?, global::System.Collections.Generic.Dictionary<string, double>>), TypeInfoPropertyName = "AnyOfDoubleDictionaryStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResourceExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EDpkScope), TypeInfoPropertyName = "EDpkScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkMetadataCommands))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IAppContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkInitialContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkComponentPanel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentPanelSupportedSlot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkComponentPanelSupportedSlot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkComponentModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkComponentModelComputeConfigs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.JsServiceVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkComponentModule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComponentServiceOperation), TypeInfoPropertyName = "EComponentServiceOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkComponentTrigger))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkComponentTriggerSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkComponentService))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkComponentToolbars))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FilterFrequencyType), TypeInfoPropertyName = "FilterFrequencyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FilterFrequency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkChannelMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IDpkFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkComputeConfigs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InvokeType), TypeInfoPropertyName = "InvokeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ToolbarInvoke))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CustomNodeScope), TypeInfoPropertyName = "CustomNodeScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IPipelineNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkPipelineTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkPipelineTemplateTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkComponentDataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkComponentDatasetOntology))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkComponentDatasetInvoke))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkComponentIntegrations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DpkComponents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentIntegrations>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentDataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IDpkPipelineTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IPipelineNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IDpkComputeConfigs>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IDpkChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentToolbars>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentService>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentTrigger>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentModule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentPanel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComponentElementType), TypeInfoPropertyName = "EComponentElementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkPipelineNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkComponentElementSpec), TypeInfoPropertyName = "IDpkComponentElementSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IComponentElement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkDependency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>), TypeInfoPropertyName = "AnyOfDpkComponentsDictionaryStringIComponentElement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IDpkDependency>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDpk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EAppScope), TypeInfoPropertyName = "EAppScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialAPIDpk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickAPIDpkDependencies))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CustomInstallation), TypeInfoPropertyName = "CustomInstallation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CustomInstallationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AppCommandsReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AppMetadata), TypeInfoPropertyName = "AppMetadata2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AppMetadataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AppMetadataVariant2System))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IAppGeneralSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComputeType), TypeInfoPropertyName = "EComputeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComputeStatus), TypeInfoPropertyName = "EComputeStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EClusterProvider), TypeInfoPropertyName = "EClusterProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Toleration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.INodePoolDeploymentResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.INodePoolDeploymentResourcesRequests))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.INodePoolDeploymentResourcesLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.INodePool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.Toleration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComputePlugin), TypeInfoPropertyName = "EComputePlugin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IExternalMonitoringConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IHpaControllerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EStorageType), TypeInfoPropertyName = "EStorageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IStorageDriverConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IComputeNfsPluginConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.KubernetesServiceType), TypeInfoPropertyName = "KubernetesServiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputePluginResourceManifests2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputePluginResourceManifestsSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputePluginResourceManifestsSpecResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputePluginSpec), TypeInfoPropertyName = "ComputePluginSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputePluginSpecVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IComputePlugin))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.IExternalMonitoringConfig, global::Dataloop.IHpaControllerConfig, global::Dataloop.Dictionary, global::Dataloop.IStorageDriverConfig, global::Dataloop.IComputeNfsPluginConfig>), TypeInfoPropertyName = "AnyOfIExternalMonitoringConfigIHpaControllerConfigDictionaryIStorageDriverConfigIComputeNfsPluginConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IComputeAuthentication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IComputeAuthenticationIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterVolume))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterVolumePersistentVolumeClaim))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterVolumeHostPath))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterVolumeConfigMap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IClusterVolumeConfigMapItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterVolumeConfigMapItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterVolumeSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IClusterVolumeSecretItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterVolumeSecretItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterVolumeNfs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDeploymentSecurityContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterEnvironmentVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterEnvironmentVariableValueFrom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterEnvironmentVariableValueFromConfigMapKeyRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterEnvironmentVariableValueFromSecretKeyRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterEnvironmentVariableValueFromFieldRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IComputeRegistry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDeploymentConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IClusterVolume>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IClusterEnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDeploymentConfigurationDefaultResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDeploymentConfigurationDefaultResourcesLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDeploymentConfigurationDefaultResourcesRequests))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IRunAiConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IComputeCluster))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.INodePool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IComputePlugin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IComputeSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICompute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IComputeContext>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageT))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIComposition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIPipeline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>), TypeInfoPropertyName = "AnyOfAPIPipelineStateIPipelineState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ResourceExecution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIDpk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APICompute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIServiceDriver>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.QueryPipelineTableResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryPipelineTableResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryPipelineTableResponseItemTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResource?), TypeInfoPropertyName = "NullableQueryResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnnotationType?), TypeInfoPropertyName = "NullableAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RequestSource?), TypeInfoPropertyName = "NullableRequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskType?), TypeInfoPropertyName = "NullableTaskType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskStatus?), TypeInfoPropertyName = "NullableTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Role?), TypeInfoPropertyName = "NullableRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EntityScopeLevel?), TypeInfoPropertyName = "NullableEntityScopeLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelStatus?), TypeInfoPropertyName = "NullableModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<double?, string>?), TypeInfoPropertyName = "NullableAnyOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelInputType?), TypeInfoPropertyName = "NullableModelInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOutputType?), TypeInfoPropertyName = "NullableModelOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOutputTypeVariant2?), TypeInfoPropertyName = "NullableModelOutputTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOutputTypeVariant4?), TypeInfoPropertyName = "NullableModelOutputTypeVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReferenceType?), TypeInfoPropertyName = "NullableReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOperationTypes?), TypeInfoPropertyName = "NullableModelOperationTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionStatusName?), TypeInfoPropertyName = "NullableExecutionStatusName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResourceType?), TypeInfoPropertyName = "NullableResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionMode?), TypeInfoPropertyName = "NullableExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionPhase?), TypeInfoPropertyName = "NullableExecutionPhase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OnResetAction?), TypeInfoPropertyName = "NullableOnResetAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceType?), TypeInfoPropertyName = "NullableServiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CrashloopAction?), TypeInfoPropertyName = "NullableCrashloopAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CrashloopReason?), TypeInfoPropertyName = "NullableCrashloopReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceModeType?), TypeInfoPropertyName = "NullableServiceModeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComputeConsumptionMethod?), TypeInfoPropertyName = "NullableEComputeConsumptionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.ServiceMetadataUser, global::Dataloop.Dictionary>?), TypeInfoPropertyName = "NullableAllOfServiceMetadataUserDictionary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.ServiceMetadataSystem, global::Dataloop.SystemRefs, global::Dataloop.Dictionary>?), TypeInfoPropertyName = "NullableAllOfServiceMetadataSystemSystemRefsDictionary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageResourceType?), TypeInfoPropertyName = "NullablePackageResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionHookValueFrom?), TypeInfoPropertyName = "NullableExecutionHookValueFrom2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionHookType?), TypeInfoPropertyName = "NullableExecutionHookType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UiBindingResource?), TypeInfoPropertyName = "NullableUiBindingResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UiBindingPanel?), TypeInfoPropertyName = "NullableUiBindingPanel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionPostActionType?), TypeInfoPropertyName = "NullableExecutionPostActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerType?), TypeInfoPropertyName = "NullableTriggerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaaSCacheSize?), TypeInfoPropertyName = "NullableFaaSCacheSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaaSCacheType?), TypeInfoPropertyName = "NullableFaaSCacheType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceDriverType?), TypeInfoPropertyName = "NullableServiceDriverType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DataloopPodType?), TypeInfoPropertyName = "NullableDataloopPodType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputeMetadata?), TypeInfoPropertyName = "NullableComputeMetadata2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputeMetadataVariant2ServeAgentGateway?), TypeInfoPropertyName = "NullableComputeMetadataVariant2ServeAgentGateway2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CompositionElementStatus?), TypeInfoPropertyName = "NullableCompositionElementStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CompositionStatus?), TypeInfoPropertyName = "NullableCompositionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerResourceType?), TypeInfoPropertyName = "NullableTriggerResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerActionType?), TypeInfoPropertyName = "NullableTriggerActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerOperationType?), TypeInfoPropertyName = "NullableTriggerOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ECompositionPackageStatus?), TypeInfoPropertyName = "NullableECompositionPackageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageConfigType?), TypeInfoPropertyName = "NullablePackageConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageRequirementOperator?), TypeInfoPropertyName = "NullablePackageRequirementOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CodebaseType?), TypeInfoPropertyName = "NullableCodebaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ChannelType?), TypeInfoPropertyName = "NullableChannelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CompositionChannelStatus?), TypeInfoPropertyName = "NullableCompositionChannelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TemplateKind?), TypeInfoPropertyName = "NullableTemplateKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.NodeType?), TypeInfoPropertyName = "NullableNodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.StartNodeType?), TypeInfoPropertyName = "NullableStartNodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResumePipelineOption?), TypeInfoPropertyName = "NullableResumePipelineOption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PipelineFromTemplateState?), TypeInfoPropertyName = "NullablePipelineFromTemplateState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionDatasetStateDatasetIndexDriver?), TypeInfoPropertyName = "NullableICompositionDatasetStateDatasetIndexDriver2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompositionDatasetStateDatasetShareLevel?), TypeInfoPropertyName = "NullableICompositionDatasetStateDatasetShareLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.ServiceContext>?), TypeInfoPropertyName = "NullableAllOfContextServiceContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DpkDatasetOntologyType?), TypeInfoPropertyName = "NullableDpkDatasetOntologyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.ICompositionError, string>?), TypeInfoPropertyName = "NullableAnyOfICompositionErrorString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.ExecutionContext>?), TypeInfoPropertyName = "NullableAllOfContextExecutionContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, double?>?), TypeInfoPropertyName = "NullableAnyOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ENodeStatus?), TypeInfoPropertyName = "NullableENodeStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EPipelineStatus?), TypeInfoPropertyName = "NullableEPipelineStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<double?, global::System.Collections.Generic.Dictionary<string, double>>?), TypeInfoPropertyName = "NullableAnyOfDoubleDictionaryStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EDpkScope?), TypeInfoPropertyName = "NullableEDpkScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComponentServiceOperation?), TypeInfoPropertyName = "NullableEComponentServiceOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FilterFrequencyType?), TypeInfoPropertyName = "NullableFilterFrequencyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InvokeType?), TypeInfoPropertyName = "NullableInvokeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CustomNodeScope?), TypeInfoPropertyName = "NullableCustomNodeScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComponentElementType?), TypeInfoPropertyName = "NullableEComponentElementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkComponentElementSpec?), TypeInfoPropertyName = "NullableIDpkComponentElementSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>?), TypeInfoPropertyName = "NullableAnyOfDpkComponentsDictionaryStringIComponentElement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EAppScope?), TypeInfoPropertyName = "NullableEAppScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CustomInstallation?), TypeInfoPropertyName = "NullableCustomInstallation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AppMetadata?), TypeInfoPropertyName = "NullableAppMetadata2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComputeType?), TypeInfoPropertyName = "NullableEComputeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComputeStatus?), TypeInfoPropertyName = "NullableEComputeStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EClusterProvider?), TypeInfoPropertyName = "NullableEClusterProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComputePlugin?), TypeInfoPropertyName = "NullableEComputePlugin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EStorageType?), TypeInfoPropertyName = "NullableEStorageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.KubernetesServiceType?), TypeInfoPropertyName = "NullableKubernetesServiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputePluginSpec?), TypeInfoPropertyName = "NullableComputePluginSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.IExternalMonitoringConfig, global::Dataloop.IHpaControllerConfig, global::Dataloop.Dictionary, global::Dataloop.IStorageDriverConfig, global::Dataloop.IComputeNfsPluginConfig>?), TypeInfoPropertyName = "NullableAnyOfIExternalMonitoringConfigIHpaControllerConfigDictionaryIStorageDriverConfigIComputeNfsPluginConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>?), TypeInfoPropertyName = "NullableAnyOfAPIPipelineStateIPipelineState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.TaskWorkload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.EntityReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ExecutionStatusReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ExecutionResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.Panel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ServiceIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PackageIO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DisplayScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DLFunctionDefaultInputSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DLFunctionInputOptionsSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DriverCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DriverNodeSelector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DriverToleration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DataloopPodType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.TriggerActionType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DLFunction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PackageRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.Dictionary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ICompositionFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PortIO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PipelineNodeDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PipelineConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IStartNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PipelineVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ICompositionDatasetStateDatasetAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIServiceCompositionElement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ICompositionTrigger>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ICompositionPackage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ICompositionTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APICompositionModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ICompositionChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ICompositionPipelineTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ICompositionDataset>))]
    internal sealed partial class PipelinesQuerySourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIComposition>, global::System.Collections.Generic.IList<global::Dataloop.APIPipeline>, global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.IList<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.IList<global::Dataloop.APIDpk>, global::System.Collections.Generic.IList<global::Dataloop.APIApp>, global::System.Collections.Generic.IList<global::Dataloop.APICompute>, global::System.Collections.Generic.IList<global::Dataloop.APIServiceDriver>>), TypeInfoPropertyName = "APIServiceDriver_0708f4328c68aea5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIComposition>, global::System.Collections.Generic.IList<global::Dataloop.APIPipeline>, global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.IList<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.IList<global::Dataloop.APIDpk>, global::System.Collections.Generic.IList<global::Dataloop.APIApp>, global::System.Collections.Generic.IList<global::Dataloop.APICompute>, global::System.Collections.Generic.IList<global::Dataloop.APIServiceDriver>>?), TypeInfoPropertyName = "APIServiceDriver_c0617c242689fb32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIComposition>, global::System.Collections.Generic.List<global::Dataloop.APIPipeline>, global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.List<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.List<global::Dataloop.APIDpk>, global::System.Collections.Generic.List<global::Dataloop.APIApp>, global::System.Collections.Generic.List<global::Dataloop.APICompute>, global::System.Collections.Generic.List<global::Dataloop.APIServiceDriver>>), TypeInfoPropertyName = "APIServiceDriver_ce74abc722e1be30")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Dataloop.PartialExecution>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PartialExecution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IPipelineNodeState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.INodeTransitionError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IDpkComponentPanelSupportedSlot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IDpkFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IDpkComponentIntegrations>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IDpkComponentDataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IDpkPipelineTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IPipelineNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IDpkComputeConfigs>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IDpkChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IDpkComponentToolbars>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IDpkComponentService>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IDpkComponentTrigger>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IDpkComponentModule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IDpkComponentModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IDpkComponentPanel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IDpkDependency>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.Toleration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IClusterVolumeConfigMapItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IClusterVolumeSecretItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IClusterVolume>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IClusterEnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.INodePool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IComputePlugin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IComputeContext>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIComposition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIPipeline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ResourceExecution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIDpk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APICompute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIServiceDriver>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.QueryPipelineTableResponseItem>))]
    internal sealed partial class PipelinesQuerySourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PipelinesQuerySourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PipelinesQuerySourceGenerationContext Default { get; } = new(DefaultOptions);

        private PipelinesQuerySourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Dataloop.JsonConverters.ModelOutputTypeJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.ComputeMetadataJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.IDpkComponentElementSpecJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.CustomInstallationJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.AppMetadataJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.ComputePluginSpecJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.ServiceMetadataUser, global::Dataloop.Dictionary>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.ServiceMetadataSystem, global::Dataloop.SystemRefs, global::Dataloop.Dictionary>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.ServiceContext>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ICompositionError, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.ExecutionContext>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.IExternalMonitoringConfig, global::Dataloop.IHpaControllerConfig, global::Dataloop.Dictionary, global::Dataloop.IStorageDriverConfig, global::Dataloop.IComputeNfsPluginConfig>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIComposition>, global::System.Collections.Generic.IList<global::Dataloop.APIPipeline>, global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.IList<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.IList<global::Dataloop.APIDpk>, global::System.Collections.Generic.IList<global::Dataloop.APIApp>, global::System.Collections.Generic.IList<global::Dataloop.APICompute>, global::System.Collections.Generic.IList<global::Dataloop.APIServiceDriver>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>());
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
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIApp, object>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
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

                    || typeToConvert == typeof(global::Dataloop.AnnotationType)

                    || typeToConvert == typeof(global::Dataloop.AnnotationType?)

                    || typeToConvert == typeof(global::Dataloop.RequestSource)

                    || typeToConvert == typeof(global::Dataloop.RequestSource?)

                    || typeToConvert == typeof(global::Dataloop.TaskType)

                    || typeToConvert == typeof(global::Dataloop.TaskType?)

                    || typeToConvert == typeof(global::Dataloop.TaskStatus)

                    || typeToConvert == typeof(global::Dataloop.TaskStatus?)

                    || typeToConvert == typeof(global::Dataloop.Role)

                    || typeToConvert == typeof(global::Dataloop.Role?)

                    || typeToConvert == typeof(global::Dataloop.EntityScopeLevel)

                    || typeToConvert == typeof(global::Dataloop.EntityScopeLevel?)

                    || typeToConvert == typeof(global::Dataloop.ModelStatus)

                    || typeToConvert == typeof(global::Dataloop.ModelStatus?)

                    || typeToConvert == typeof(global::Dataloop.ModelInputType)

                    || typeToConvert == typeof(global::Dataloop.ModelInputType?)

                    || typeToConvert == typeof(global::Dataloop.ModelOutputTypeVariant2)

                    || typeToConvert == typeof(global::Dataloop.ModelOutputTypeVariant2?)

                    || typeToConvert == typeof(global::Dataloop.ModelOutputTypeVariant4)

                    || typeToConvert == typeof(global::Dataloop.ModelOutputTypeVariant4?)

                    || typeToConvert == typeof(global::Dataloop.ReferenceType)

                    || typeToConvert == typeof(global::Dataloop.ReferenceType?)

                    || typeToConvert == typeof(global::Dataloop.ModelOperationTypes)

                    || typeToConvert == typeof(global::Dataloop.ModelOperationTypes?)

                    || typeToConvert == typeof(global::Dataloop.OnResetAction)

                    || typeToConvert == typeof(global::Dataloop.OnResetAction?)

                    || typeToConvert == typeof(global::Dataloop.ServiceType)

                    || typeToConvert == typeof(global::Dataloop.ServiceType?)

                    || typeToConvert == typeof(global::Dataloop.CrashloopAction)

                    || typeToConvert == typeof(global::Dataloop.CrashloopAction?)

                    || typeToConvert == typeof(global::Dataloop.CrashloopReason)

                    || typeToConvert == typeof(global::Dataloop.CrashloopReason?)

                    || typeToConvert == typeof(global::Dataloop.ServiceModeType)

                    || typeToConvert == typeof(global::Dataloop.ServiceModeType?)

                    || typeToConvert == typeof(global::Dataloop.EComputeConsumptionMethod)

                    || typeToConvert == typeof(global::Dataloop.EComputeConsumptionMethod?)

                    || typeToConvert == typeof(global::Dataloop.PackageResourceType)

                    || typeToConvert == typeof(global::Dataloop.PackageResourceType?)

                    || typeToConvert == typeof(global::Dataloop.ExecutionHookValueFrom)

                    || typeToConvert == typeof(global::Dataloop.ExecutionHookValueFrom?)

                    || typeToConvert == typeof(global::Dataloop.ExecutionHookType)

                    || typeToConvert == typeof(global::Dataloop.ExecutionHookType?)

                    || typeToConvert == typeof(global::Dataloop.UiBindingResource)

                    || typeToConvert == typeof(global::Dataloop.UiBindingResource?)

                    || typeToConvert == typeof(global::Dataloop.UiBindingPanel)

                    || typeToConvert == typeof(global::Dataloop.UiBindingPanel?)

                    || typeToConvert == typeof(global::Dataloop.ExecutionPostActionType)

                    || typeToConvert == typeof(global::Dataloop.ExecutionPostActionType?)

                    || typeToConvert == typeof(global::Dataloop.ExecutionStatusName)

                    || typeToConvert == typeof(global::Dataloop.ExecutionStatusName?)

                    || typeToConvert == typeof(global::Dataloop.ResourceType)

                    || typeToConvert == typeof(global::Dataloop.ResourceType?)

                    || typeToConvert == typeof(global::Dataloop.TriggerType)

                    || typeToConvert == typeof(global::Dataloop.TriggerType?)

                    || typeToConvert == typeof(global::Dataloop.FaaSCacheSize)

                    || typeToConvert == typeof(global::Dataloop.FaaSCacheSize?)

                    || typeToConvert == typeof(global::Dataloop.FaaSCacheType)

                    || typeToConvert == typeof(global::Dataloop.FaaSCacheType?)

                    || typeToConvert == typeof(global::Dataloop.ServiceDriverType)

                    || typeToConvert == typeof(global::Dataloop.ServiceDriverType?)

                    || typeToConvert == typeof(global::Dataloop.DataloopPodType)

                    || typeToConvert == typeof(global::Dataloop.DataloopPodType?)

                    || typeToConvert == typeof(global::Dataloop.ComputeMetadataVariant2ServeAgentGateway)

                    || typeToConvert == typeof(global::Dataloop.ComputeMetadataVariant2ServeAgentGateway?)

                    || typeToConvert == typeof(global::Dataloop.CompositionElementStatus)

                    || typeToConvert == typeof(global::Dataloop.CompositionElementStatus?)

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

                    || typeToConvert == typeof(global::Dataloop.ECompositionPackageStatus)

                    || typeToConvert == typeof(global::Dataloop.ECompositionPackageStatus?)

                    || typeToConvert == typeof(global::Dataloop.PackageConfigType)

                    || typeToConvert == typeof(global::Dataloop.PackageConfigType?)

                    || typeToConvert == typeof(global::Dataloop.PackageRequirementOperator)

                    || typeToConvert == typeof(global::Dataloop.PackageRequirementOperator?)

                    || typeToConvert == typeof(global::Dataloop.CodebaseType)

                    || typeToConvert == typeof(global::Dataloop.CodebaseType?)

                    || typeToConvert == typeof(global::Dataloop.ChannelType)

                    || typeToConvert == typeof(global::Dataloop.ChannelType?)

                    || typeToConvert == typeof(global::Dataloop.CompositionChannelStatus)

                    || typeToConvert == typeof(global::Dataloop.CompositionChannelStatus?)

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

                    || typeToConvert == typeof(global::Dataloop.ICompositionDatasetStateDatasetIndexDriver)

                    || typeToConvert == typeof(global::Dataloop.ICompositionDatasetStateDatasetIndexDriver?)

                    || typeToConvert == typeof(global::Dataloop.ICompositionDatasetStateDatasetShareLevel)

                    || typeToConvert == typeof(global::Dataloop.ICompositionDatasetStateDatasetShareLevel?)

                    || typeToConvert == typeof(global::Dataloop.DpkDatasetOntologyType)

                    || typeToConvert == typeof(global::Dataloop.DpkDatasetOntologyType?)

                    || typeToConvert == typeof(global::Dataloop.ExecutionPhase)

                    || typeToConvert == typeof(global::Dataloop.ExecutionPhase?)

                    || typeToConvert == typeof(global::Dataloop.ENodeStatus)

                    || typeToConvert == typeof(global::Dataloop.ENodeStatus?)

                    || typeToConvert == typeof(global::Dataloop.EPipelineStatus)

                    || typeToConvert == typeof(global::Dataloop.EPipelineStatus?)

                    || typeToConvert == typeof(global::Dataloop.EDpkScope)

                    || typeToConvert == typeof(global::Dataloop.EDpkScope?)

                    || typeToConvert == typeof(global::Dataloop.EComponentServiceOperation)

                    || typeToConvert == typeof(global::Dataloop.EComponentServiceOperation?)

                    || typeToConvert == typeof(global::Dataloop.FilterFrequencyType)

                    || typeToConvert == typeof(global::Dataloop.FilterFrequencyType?)

                    || typeToConvert == typeof(global::Dataloop.InvokeType)

                    || typeToConvert == typeof(global::Dataloop.InvokeType?)

                    || typeToConvert == typeof(global::Dataloop.CustomNodeScope)

                    || typeToConvert == typeof(global::Dataloop.CustomNodeScope?)

                    || typeToConvert == typeof(global::Dataloop.EComponentElementType)

                    || typeToConvert == typeof(global::Dataloop.EComponentElementType?)

                    || typeToConvert == typeof(global::Dataloop.EAppScope)

                    || typeToConvert == typeof(global::Dataloop.EAppScope?)

                    || typeToConvert == typeof(global::Dataloop.EComputeType)

                    || typeToConvert == typeof(global::Dataloop.EComputeType?)

                    || typeToConvert == typeof(global::Dataloop.EComputeStatus)

                    || typeToConvert == typeof(global::Dataloop.EComputeStatus?)

                    || typeToConvert == typeof(global::Dataloop.EClusterProvider)

                    || typeToConvert == typeof(global::Dataloop.EClusterProvider?)

                    || typeToConvert == typeof(global::Dataloop.EComputePlugin)

                    || typeToConvert == typeof(global::Dataloop.EComputePlugin?)

                    || typeToConvert == typeof(global::Dataloop.EStorageType)

                    || typeToConvert == typeof(global::Dataloop.EStorageType?)

                    || typeToConvert == typeof(global::Dataloop.KubernetesServiceType)

                    || typeToConvert == typeof(global::Dataloop.KubernetesServiceType?);
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

                if (typeToConvert == typeof(global::Dataloop.AnnotationType))
                {
                    return new global::Dataloop.JsonConverters.AnnotationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AnnotationType?))
                {
                    return new global::Dataloop.JsonConverters.AnnotationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.RequestSource))
                {
                    return new global::Dataloop.JsonConverters.RequestSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.RequestSource?))
                {
                    return new global::Dataloop.JsonConverters.RequestSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TaskType))
                {
                    return new global::Dataloop.JsonConverters.TaskTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TaskType?))
                {
                    return new global::Dataloop.JsonConverters.TaskTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TaskStatus))
                {
                    return new global::Dataloop.JsonConverters.TaskStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TaskStatus?))
                {
                    return new global::Dataloop.JsonConverters.TaskStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.Role))
                {
                    return new global::Dataloop.JsonConverters.RoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.Role?))
                {
                    return new global::Dataloop.JsonConverters.RoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EntityScopeLevel))
                {
                    return new global::Dataloop.JsonConverters.EntityScopeLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EntityScopeLevel?))
                {
                    return new global::Dataloop.JsonConverters.EntityScopeLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelStatus))
                {
                    return new global::Dataloop.JsonConverters.ModelStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelStatus?))
                {
                    return new global::Dataloop.JsonConverters.ModelStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelInputType))
                {
                    return new global::Dataloop.JsonConverters.ModelInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelInputType?))
                {
                    return new global::Dataloop.JsonConverters.ModelInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelOutputTypeVariant2))
                {
                    return new global::Dataloop.JsonConverters.ModelOutputTypeVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelOutputTypeVariant2?))
                {
                    return new global::Dataloop.JsonConverters.ModelOutputTypeVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelOutputTypeVariant4))
                {
                    return new global::Dataloop.JsonConverters.ModelOutputTypeVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelOutputTypeVariant4?))
                {
                    return new global::Dataloop.JsonConverters.ModelOutputTypeVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReferenceType))
                {
                    return new global::Dataloop.JsonConverters.ReferenceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReferenceType?))
                {
                    return new global::Dataloop.JsonConverters.ReferenceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelOperationTypes))
                {
                    return new global::Dataloop.JsonConverters.ModelOperationTypesJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelOperationTypes?))
                {
                    return new global::Dataloop.JsonConverters.ModelOperationTypesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OnResetAction))
                {
                    return new global::Dataloop.JsonConverters.OnResetActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OnResetAction?))
                {
                    return new global::Dataloop.JsonConverters.OnResetActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ServiceType))
                {
                    return new global::Dataloop.JsonConverters.ServiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ServiceType?))
                {
                    return new global::Dataloop.JsonConverters.ServiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CrashloopAction))
                {
                    return new global::Dataloop.JsonConverters.CrashloopActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CrashloopAction?))
                {
                    return new global::Dataloop.JsonConverters.CrashloopActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CrashloopReason))
                {
                    return new global::Dataloop.JsonConverters.CrashloopReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CrashloopReason?))
                {
                    return new global::Dataloop.JsonConverters.CrashloopReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ServiceModeType))
                {
                    return new global::Dataloop.JsonConverters.ServiceModeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ServiceModeType?))
                {
                    return new global::Dataloop.JsonConverters.ServiceModeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EComputeConsumptionMethod))
                {
                    return new global::Dataloop.JsonConverters.EComputeConsumptionMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EComputeConsumptionMethod?))
                {
                    return new global::Dataloop.JsonConverters.EComputeConsumptionMethodNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Dataloop.UiBindingResource))
                {
                    return new global::Dataloop.JsonConverters.UiBindingResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.UiBindingResource?))
                {
                    return new global::Dataloop.JsonConverters.UiBindingResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.UiBindingPanel))
                {
                    return new global::Dataloop.JsonConverters.UiBindingPanelJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.UiBindingPanel?))
                {
                    return new global::Dataloop.JsonConverters.UiBindingPanelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionPostActionType))
                {
                    return new global::Dataloop.JsonConverters.ExecutionPostActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionPostActionType?))
                {
                    return new global::Dataloop.JsonConverters.ExecutionPostActionTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Dataloop.FaaSCacheSize))
                {
                    return new global::Dataloop.JsonConverters.FaaSCacheSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FaaSCacheSize?))
                {
                    return new global::Dataloop.JsonConverters.FaaSCacheSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FaaSCacheType))
                {
                    return new global::Dataloop.JsonConverters.FaaSCacheTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FaaSCacheType?))
                {
                    return new global::Dataloop.JsonConverters.FaaSCacheTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ServiceDriverType))
                {
                    return new global::Dataloop.JsonConverters.ServiceDriverTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ServiceDriverType?))
                {
                    return new global::Dataloop.JsonConverters.ServiceDriverTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DataloopPodType))
                {
                    return new global::Dataloop.JsonConverters.DataloopPodTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DataloopPodType?))
                {
                    return new global::Dataloop.JsonConverters.DataloopPodTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ComputeMetadataVariant2ServeAgentGateway))
                {
                    return new global::Dataloop.JsonConverters.ComputeMetadataVariant2ServeAgentGatewayJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ComputeMetadataVariant2ServeAgentGateway?))
                {
                    return new global::Dataloop.JsonConverters.ComputeMetadataVariant2ServeAgentGatewayNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CompositionElementStatus))
                {
                    return new global::Dataloop.JsonConverters.CompositionElementStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CompositionElementStatus?))
                {
                    return new global::Dataloop.JsonConverters.CompositionElementStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Dataloop.ECompositionPackageStatus))
                {
                    return new global::Dataloop.JsonConverters.ECompositionPackageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ECompositionPackageStatus?))
                {
                    return new global::Dataloop.JsonConverters.ECompositionPackageStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Dataloop.ChannelType))
                {
                    return new global::Dataloop.JsonConverters.ChannelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ChannelType?))
                {
                    return new global::Dataloop.JsonConverters.ChannelTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CompositionChannelStatus))
                {
                    return new global::Dataloop.JsonConverters.CompositionChannelStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CompositionChannelStatus?))
                {
                    return new global::Dataloop.JsonConverters.CompositionChannelStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Dataloop.ICompositionDatasetStateDatasetIndexDriver))
                {
                    return new global::Dataloop.JsonConverters.ICompositionDatasetStateDatasetIndexDriverJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ICompositionDatasetStateDatasetIndexDriver?))
                {
                    return new global::Dataloop.JsonConverters.ICompositionDatasetStateDatasetIndexDriverNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ICompositionDatasetStateDatasetShareLevel))
                {
                    return new global::Dataloop.JsonConverters.ICompositionDatasetStateDatasetShareLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ICompositionDatasetStateDatasetShareLevel?))
                {
                    return new global::Dataloop.JsonConverters.ICompositionDatasetStateDatasetShareLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DpkDatasetOntologyType))
                {
                    return new global::Dataloop.JsonConverters.DpkDatasetOntologyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DpkDatasetOntologyType?))
                {
                    return new global::Dataloop.JsonConverters.DpkDatasetOntologyTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Dataloop.EDpkScope))
                {
                    return new global::Dataloop.JsonConverters.EDpkScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EDpkScope?))
                {
                    return new global::Dataloop.JsonConverters.EDpkScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EComponentServiceOperation))
                {
                    return new global::Dataloop.JsonConverters.EComponentServiceOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EComponentServiceOperation?))
                {
                    return new global::Dataloop.JsonConverters.EComponentServiceOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FilterFrequencyType))
                {
                    return new global::Dataloop.JsonConverters.FilterFrequencyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FilterFrequencyType?))
                {
                    return new global::Dataloop.JsonConverters.FilterFrequencyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.InvokeType))
                {
                    return new global::Dataloop.JsonConverters.InvokeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.InvokeType?))
                {
                    return new global::Dataloop.JsonConverters.InvokeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CustomNodeScope))
                {
                    return new global::Dataloop.JsonConverters.CustomNodeScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CustomNodeScope?))
                {
                    return new global::Dataloop.JsonConverters.CustomNodeScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EComponentElementType))
                {
                    return new global::Dataloop.JsonConverters.EComponentElementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EComponentElementType?))
                {
                    return new global::Dataloop.JsonConverters.EComponentElementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EAppScope))
                {
                    return new global::Dataloop.JsonConverters.EAppScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EAppScope?))
                {
                    return new global::Dataloop.JsonConverters.EAppScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EComputeType))
                {
                    return new global::Dataloop.JsonConverters.EComputeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EComputeType?))
                {
                    return new global::Dataloop.JsonConverters.EComputeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EComputeStatus))
                {
                    return new global::Dataloop.JsonConverters.EComputeStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EComputeStatus?))
                {
                    return new global::Dataloop.JsonConverters.EComputeStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EClusterProvider))
                {
                    return new global::Dataloop.JsonConverters.EClusterProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EClusterProvider?))
                {
                    return new global::Dataloop.JsonConverters.EClusterProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EComputePlugin))
                {
                    return new global::Dataloop.JsonConverters.EComputePluginJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EComputePlugin?))
                {
                    return new global::Dataloop.JsonConverters.EComputePluginNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EStorageType))
                {
                    return new global::Dataloop.JsonConverters.EStorageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EStorageType?))
                {
                    return new global::Dataloop.JsonConverters.EStorageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.KubernetesServiceType))
                {
                    return new global::Dataloop.JsonConverters.KubernetesServiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.KubernetesServiceType?))
                {
                    return new global::Dataloop.JsonConverters.KubernetesServiceTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new PipelinesQuerySourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new PipelinesQuerySourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}