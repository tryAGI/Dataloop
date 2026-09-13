
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResource), TypeInfoPropertyName = "QueryResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnnotationType), TypeInfoPropertyName = "AnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Context))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionMode), TypeInfoPropertyName = "ExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionHook))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerType), TypeInfoPropertyName = "TriggerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CompositionStatus), TypeInfoPropertyName = "CompositionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerResourceType), TypeInfoPropertyName = "TriggerResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerActionType), TypeInfoPropertyName = "TriggerActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerOperationType), TypeInfoPropertyName = "TriggerOperationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.TriggerActionType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DLFunction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageConfigType), TypeInfoPropertyName = "PackageConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageRequirementOperator), TypeInfoPropertyName = "PackageRequirementOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CodebaseType), TypeInfoPropertyName = "CodebaseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Codebase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.PackageRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.Dictionary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.NotificationEntityContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FilterTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.NotificationEventContext))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TextSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.MqDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AuthZBlockServiceContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.ServiceContext>), TypeInfoPropertyName = "AllOfContextServiceContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialService))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DpkDatasetOntologyType), TypeInfoPropertyName = "DpkDatasetOntologyType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIDpk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIPostDpk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPIDpk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DpkAttributeValueDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DpkAttributeValueDefinitionIcon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DpkAttributeValueDefinitionColor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DpkAttributesDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DpkAttributeValueDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PreviewsComponentsPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.PreviewsComponentsPatchPipelineTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PreviewsComponentsPatchPipelineTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIPatchDpk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DpkAttributesDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResource?), TypeInfoPropertyName = "NullableQueryResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnnotationType?), TypeInfoPropertyName = "NullableAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionMode?), TypeInfoPropertyName = "NullableExecutionMode2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.ServiceContext>?), TypeInfoPropertyName = "NullableAllOfContextServiceContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DpkDatasetOntologyType?), TypeInfoPropertyName = "NullableDpkDatasetOntologyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EDpkScope?), TypeInfoPropertyName = "NullableEDpkScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComponentServiceOperation?), TypeInfoPropertyName = "NullableEComponentServiceOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FilterFrequencyType?), TypeInfoPropertyName = "NullableFilterFrequencyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InvokeType?), TypeInfoPropertyName = "NullableInvokeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CustomNodeScope?), TypeInfoPropertyName = "NullableCustomNodeScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComponentElementType?), TypeInfoPropertyName = "NullableEComponentElementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDpkComponentElementSpec?), TypeInfoPropertyName = "NullableIDpkComponentElementSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>?), TypeInfoPropertyName = "NullableAnyOfDpkComponentsDictionaryStringIComponentElement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.EntityReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.Panel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ServiceIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PackageIO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DisplayScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DLFunctionDefaultInputSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DLFunctionInputOptionsSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.TriggerActionType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DLFunction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PackageRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.Dictionary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PortIO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PipelineNodeDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PipelineConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IStartNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PipelineVariable>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIDpk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DpkAttributeValueDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PreviewsComponentsPatchPipelineTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DpkAttributesDefinition>))]
    internal sealed partial class DpkSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DpkSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DpkSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DpkSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Dataloop.JsonConverters.IDpkComponentElementSpecJsonConverter());
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
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>());
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

                    || typeToConvert == typeof(global::Dataloop.TriggerType)

                    || typeToConvert == typeof(global::Dataloop.TriggerType?)

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

                    || typeToConvert == typeof(global::Dataloop.DpkDatasetOntologyType)

                    || typeToConvert == typeof(global::Dataloop.DpkDatasetOntologyType?)

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

                    || typeToConvert == typeof(global::Dataloop.EComponentElementType?);
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

                if (typeToConvert == typeof(global::Dataloop.TriggerType))
                {
                    return new global::Dataloop.JsonConverters.TriggerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TriggerType?))
                {
                    return new global::Dataloop.JsonConverters.TriggerTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Dataloop.DpkDatasetOntologyType))
                {
                    return new global::Dataloop.JsonConverters.DpkDatasetOntologyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DpkDatasetOntologyType?))
                {
                    return new global::Dataloop.JsonConverters.DpkDatasetOntologyTypeNullableJsonConverter();
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
                    0 => new DpkSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}