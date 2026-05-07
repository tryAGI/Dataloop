
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
            typeof(global::Dataloop.JsonConverters.ItemSpecTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ItemSpecTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.RefTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.RefTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ModalityTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ModalityTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.APIDatasetFileItemTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.APIDatasetFileItemTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.APIDatasetFileItemAnnotatedJsonConverter),

            typeof(global::Dataloop.JsonConverters.APIDatasetFileItemAnnotatedNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.APIDatasetDirectoryItemTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.APIDatasetDirectoryItemTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.DatasetIndexDriversJsonConverter),

            typeof(global::Dataloop.JsonConverters.DatasetIndexDriversNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ItemRefOperationJsonConverter),

            typeof(global::Dataloop.JsonConverters.ItemRefOperationNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.QueryResourceJsonConverter),

            typeof(global::Dataloop.JsonConverters.QueryResourceNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ReferenceQueryOperationJsonConverter),

            typeof(global::Dataloop.JsonConverters.ReferenceQueryOperationNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngineJsonConverter),

            typeof(global::Dataloop.JsonConverters.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngineNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.OrderByJsonConverter),

            typeof(global::Dataloop.JsonConverters.OrderByNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.DQLResourceQueryQueryEngineJsonConverter),

            typeof(global::Dataloop.JsonConverters.DQLResourceQueryQueryEngineNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.AddItemModeJsonConverter),

            typeof(global::Dataloop.JsonConverters.AddItemModeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.SystemDatasetTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.SystemDatasetTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.AnnotationTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.AnnotationTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.RefAnnotationsRefTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.RefAnnotationsRefTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.RequestSourceJsonConverter),

            typeof(global::Dataloop.JsonConverters.RequestSourceNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.APIAnnotationEventDeletedJsonConverter),

            typeof(global::Dataloop.JsonConverters.APIAnnotationEventDeletedNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.IndexDriverJsonConverter),

            typeof(global::Dataloop.JsonConverters.IndexDriverNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.APIDatasetAccessLevelJsonConverter),

            typeof(global::Dataloop.JsonConverters.APIDatasetAccessLevelNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.DatasetScopeJsonConverter),

            typeof(global::Dataloop.JsonConverters.DatasetScopeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.CreateDatasetRequestDriverJsonConverter),

            typeof(global::Dataloop.JsonConverters.CreateDatasetRequestDriverNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.CreateDatasetRequestAccessLevelJsonConverter),

            typeof(global::Dataloop.JsonConverters.CreateDatasetRequestAccessLevelNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.DQLQueryQueryEngineJsonConverter),

            typeof(global::Dataloop.JsonConverters.DQLQueryQueryEngineNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExportTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExportTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExportDatasetOptionsExportVersionJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExportDatasetOptionsExportVersionNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExportStatusJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExportStatusNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExportErrorTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExportErrorTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.QueryResourceItemsJsonConverter),

            typeof(global::Dataloop.JsonConverters.QueryResourceItemsNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.QueryResourceAnnotationsJsonConverter),

            typeof(global::Dataloop.JsonConverters.QueryResourceAnnotationsNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.QueryResourceDatasetsJsonConverter),

            typeof(global::Dataloop.JsonConverters.QueryResourceDatasetsNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.AllowedTypesJsonConverter),

            typeof(global::Dataloop.JsonConverters.AllowedTypesNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.UnsearchableSchemaReasonsJsonConverter),

            typeof(global::Dataloop.JsonConverters.UnsearchableSchemaReasonsNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.SchemaModeJsonConverter),

            typeof(global::Dataloop.JsonConverters.SchemaModeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.DatasetItemTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.DatasetItemTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.AnnotationTypeBoxJsonConverter),

            typeof(global::Dataloop.JsonConverters.AnnotationTypeBoxNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.AnnotationTypeClassJsonConverter),

            typeof(global::Dataloop.JsonConverters.AnnotationTypeClassNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.AnnotationTypeBinaryJsonConverter),

            typeof(global::Dataloop.JsonConverters.AnnotationTypeBinaryNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.GenerationStrategyTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.GenerationStrategyTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.GeneratedDatasetTypesJsonConverter),

            typeof(global::Dataloop.JsonConverters.GeneratedDatasetTypesNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.OneByOneLatencyBenchmarkModeTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.OneByOneLatencyBenchmarkModeTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ProfilingBenchmarkModeTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ProfilingBenchmarkModeTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ConcurrencyBenchmarkModeTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ConcurrencyBenchmarkModeTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.QueryTestCasesJsonConverter),

            typeof(global::Dataloop.JsonConverters.QueryTestCasesNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.IndexingStrategyTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.IndexingStrategyTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.InferDatasetSchemaModeJsonConverter),

            typeof(global::Dataloop.JsonConverters.InferDatasetSchemaModeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.FeatureFlagsSetContextVariant1TypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.FeatureFlagsSetContextVariant1TypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.FeatureFlagsSetContextVariant2TypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.FeatureFlagsSetContextVariant2TypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.DatasetAccessLevelJsonConverter),

            typeof(global::Dataloop.JsonConverters.DatasetAccessLevelNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.DatasetSyncStatusJsonConverter),

            typeof(global::Dataloop.JsonConverters.DatasetSyncStatusNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.DriverTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.DriverTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.IntegrationTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.IntegrationTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.FeatureSetEntityTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.FeatureSetEntityTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.BenchmarkIngestionStrategyTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.BenchmarkIngestionStrategyTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.BenchmarkOptionsExportTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.BenchmarkOptionsExportTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.SetTaskRefsBenchmarkInputOperationJsonConverter),

            typeof(global::Dataloop.JsonConverters.SetTaskRefsBenchmarkInputOperationNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.DriverReadBenchmarkOperationInputScenarioDetailsJsonConverter),

            typeof(global::Dataloop.JsonConverters.DriverReadBenchmarkOperationInputScenarioDetailsNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.DriverWriteBenchmarkOperationInputScenarioDetailsJsonConverter),

            typeof(global::Dataloop.JsonConverters.DriverWriteBenchmarkOperationInputScenarioDetailsNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.AttributeTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.AttributeTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.InstructionActionJsonConverter),

            typeof(global::Dataloop.JsonConverters.InstructionActionNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.InstructionScopeJsonConverter),

            typeof(global::Dataloop.JsonConverters.InstructionScopeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.CustomActionControlsJsonConverter),

            typeof(global::Dataloop.JsonConverters.CustomActionControlsNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.APICustomActionControlsJsonConverter),

            typeof(global::Dataloop.JsonConverters.APICustomActionControlsNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.AssignmentStatusJsonConverter),

            typeof(global::Dataloop.JsonConverters.AssignmentStatusNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.AssignmentMetadataSystemTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.AssignmentMetadataSystemTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.TaskTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.TaskTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ScoreTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ScoreTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.TaskStatusJsonConverter),

            typeof(global::Dataloop.JsonConverters.TaskStatusNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.QualityTaskTypesJsonConverter),

            typeof(global::Dataloop.JsonConverters.QualityTaskTypesNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.InstructionsDocumentModeJsonConverter),

            typeof(global::Dataloop.JsonConverters.InstructionsDocumentModeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.TaskContributorsActionJsonConverter),

            typeof(global::Dataloop.JsonConverters.TaskContributorsActionNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.RoleJsonConverter),

            typeof(global::Dataloop.JsonConverters.RoleNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.OrgPlansJsonConverter),

            typeof(global::Dataloop.JsonConverters.OrgPlansNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.AlertTierJsonConverter),

            typeof(global::Dataloop.JsonConverters.AlertTierNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.OrgRoleJsonConverter),

            typeof(global::Dataloop.JsonConverters.OrgRoleNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.DLEntityTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.DLEntityTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.OrgSizeJsonConverter),

            typeof(global::Dataloop.JsonConverters.OrgSizeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.OrgIndustryJsonConverter),

            typeof(global::Dataloop.JsonConverters.OrgIndustryNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.IntegrationType2JsonConverter),

            typeof(global::Dataloop.JsonConverters.IntegrationType2NullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.BillingResourceKeyJsonConverter),

            typeof(global::Dataloop.JsonConverters.BillingResourceKeyNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.MetricGroupJsonConverter),

            typeof(global::Dataloop.JsonConverters.MetricGroupNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.BillingPeriodJsonConverter),

            typeof(global::Dataloop.JsonConverters.BillingPeriodNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.BillingStatusJsonConverter),

            typeof(global::Dataloop.JsonConverters.BillingStatusNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ScopeTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ScopeTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.GuestTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.GuestTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.APIMembershipRoleJsonConverter),

            typeof(global::Dataloop.JsonConverters.APIMembershipRoleNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.UserInterestTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.UserInterestTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ApiKeyTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ApiKeyTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.LoginsLogQueryOrderJsonConverter),

            typeof(global::Dataloop.JsonConverters.LoginsLogQueryOrderNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.LoginsLogQueryOrderByJsonConverter),

            typeof(global::Dataloop.JsonConverters.LoginsLogQueryOrderByNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.EntityScopeLevelJsonConverter),

            typeof(global::Dataloop.JsonConverters.EntityScopeLevelNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ModelStatusJsonConverter),

            typeof(global::Dataloop.JsonConverters.ModelStatusNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ModelInputTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ModelInputTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ModelOutputTypeVariant2JsonConverter),

            typeof(global::Dataloop.JsonConverters.ModelOutputTypeVariant2NullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ModelOutputTypeVariant4JsonConverter),

            typeof(global::Dataloop.JsonConverters.ModelOutputTypeVariant4NullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ArtifactTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ArtifactTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ReferenceTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ReferenceTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.NodeMlTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.NodeMlTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ModelOperationTypesJsonConverter),

            typeof(global::Dataloop.JsonConverters.ModelOperationTypesNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExecutionStatusJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExecutionStatusNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.EventResourceTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.EventResourceTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.CreateWebHookDTOHttpMethodJsonConverter),

            typeof(global::Dataloop.JsonConverters.CreateWebHookDTOHttpMethodNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.UpdateWebHookDTOHttpMethodJsonConverter),

            typeof(global::Dataloop.JsonConverters.UpdateWebHookDTOHttpMethodNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.OnResetActionJsonConverter),

            typeof(global::Dataloop.JsonConverters.OnResetActionNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ServiceTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ServiceTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.CrashloopActionJsonConverter),

            typeof(global::Dataloop.JsonConverters.CrashloopActionNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.CrashloopReasonJsonConverter),

            typeof(global::Dataloop.JsonConverters.CrashloopReasonNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ServiceModeTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ServiceModeTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.EComputeConsumptionMethodJsonConverter),

            typeof(global::Dataloop.JsonConverters.EComputeConsumptionMethodNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.PackageResourceTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.PackageResourceTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExecutionHookValueFromJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExecutionHookValueFromNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExecutionHookTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExecutionHookTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.UiBindingResourceJsonConverter),

            typeof(global::Dataloop.JsonConverters.UiBindingResourceNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.UiBindingPanelJsonConverter),

            typeof(global::Dataloop.JsonConverters.UiBindingPanelNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExecutionPostActionTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExecutionPostActionTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExecutionStatusNameJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExecutionStatusNameNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ResourceTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ResourceTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.TriggerTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.TriggerTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ECacheModeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ECacheModeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.FaaSCacheSizeJsonConverter),

            typeof(global::Dataloop.JsonConverters.FaaSCacheSizeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.FaaSCacheTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.FaaSCacheTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ServiceLogLevelJsonConverter),

            typeof(global::Dataloop.JsonConverters.ServiceLogLevelNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.LogsListDirectionJsonConverter),

            typeof(global::Dataloop.JsonConverters.LogsListDirectionNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ReplicaStatusJsonConverter),

            typeof(global::Dataloop.JsonConverters.ReplicaStatusNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ReplicaReasonJsonConverter),

            typeof(global::Dataloop.JsonConverters.ReplicaReasonNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.EDebugOptionsStatusJsonConverter),

            typeof(global::Dataloop.JsonConverters.EDebugOptionsStatusNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ReportTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ReportTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ServiceDriverTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ServiceDriverTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.DataloopPodTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.DataloopPodTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ComputeMetadataVariant2ServeAgentGatewayJsonConverter),

            typeof(global::Dataloop.JsonConverters.ComputeMetadataVariant2ServeAgentGatewayNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.CompositionElementStatusJsonConverter),

            typeof(global::Dataloop.JsonConverters.CompositionElementStatusNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.CompositionStatusJsonConverter),

            typeof(global::Dataloop.JsonConverters.CompositionStatusNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.TriggerResourceTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.TriggerResourceTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.TriggerActionTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.TriggerActionTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExecutionModeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExecutionModeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.TriggerOperationTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.TriggerOperationTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ECompositionPackageStatusJsonConverter),

            typeof(global::Dataloop.JsonConverters.ECompositionPackageStatusNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.PackageConfigTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.PackageConfigTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.PackageRequirementOperatorJsonConverter),

            typeof(global::Dataloop.JsonConverters.PackageRequirementOperatorNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.CodebaseTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.CodebaseTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ChannelTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ChannelTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.CompositionChannelStatusJsonConverter),

            typeof(global::Dataloop.JsonConverters.CompositionChannelStatusNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.TemplateKindJsonConverter),

            typeof(global::Dataloop.JsonConverters.TemplateKindNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.NodeTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.NodeTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.StartNodeTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.StartNodeTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ResumePipelineOptionJsonConverter),

            typeof(global::Dataloop.JsonConverters.ResumePipelineOptionNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.PipelineFromTemplateStateJsonConverter),

            typeof(global::Dataloop.JsonConverters.PipelineFromTemplateStateNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ICompositionDatasetStateDatasetIndexDriverJsonConverter),

            typeof(global::Dataloop.JsonConverters.ICompositionDatasetStateDatasetIndexDriverNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ICompositionDatasetStateDatasetShareLevelJsonConverter),

            typeof(global::Dataloop.JsonConverters.ICompositionDatasetStateDatasetShareLevelNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.DpkDatasetOntologyTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.DpkDatasetOntologyTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExecutionPhaseJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExecutionPhaseNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ENodeStatusJsonConverter),

            typeof(global::Dataloop.JsonConverters.ENodeStatusNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.EPipelineStatusJsonConverter),

            typeof(global::Dataloop.JsonConverters.EPipelineStatusNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.EDpkScopeJsonConverter),

            typeof(global::Dataloop.JsonConverters.EDpkScopeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.EComponentServiceOperationJsonConverter),

            typeof(global::Dataloop.JsonConverters.EComponentServiceOperationNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.FilterFrequencyTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.FilterFrequencyTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.InvokeTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.InvokeTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.CustomNodeScopeJsonConverter),

            typeof(global::Dataloop.JsonConverters.CustomNodeScopeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.EComponentElementTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.EComponentElementTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.EAppScopeJsonConverter),

            typeof(global::Dataloop.JsonConverters.EAppScopeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.EComputeTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.EComputeTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.EComputeStatusJsonConverter),

            typeof(global::Dataloop.JsonConverters.EComputeStatusNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.EClusterProviderJsonConverter),

            typeof(global::Dataloop.JsonConverters.EClusterProviderNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.EComputePluginJsonConverter),

            typeof(global::Dataloop.JsonConverters.EComputePluginNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.EStorageTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.EStorageTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.KubernetesServiceTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.KubernetesServiceTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.CycleRerunMethodJsonConverter),

            typeof(global::Dataloop.JsonConverters.CycleRerunMethodNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.PackageTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.PackageTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.JobStatusEnumJsonConverter),

            typeof(global::Dataloop.JsonConverters.JobStatusEnumNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExecutionsOrderByTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExecutionsOrderByTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExecutionsOrderByDirectionJsonConverter),

            typeof(global::Dataloop.JsonConverters.ExecutionsOrderByDirectionNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.CommandStatusJsonConverter),

            typeof(global::Dataloop.JsonConverters.CommandStatusNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.CommandsDomainJsonConverter),

            typeof(global::Dataloop.JsonConverters.CommandsDomainNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.PipelineTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.PipelineTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.SettingsValueTypesJsonConverter),

            typeof(global::Dataloop.JsonConverters.SettingsValueTypesNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.PlatformEntityTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.PlatformEntityTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.SettingScopeTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.SettingScopeTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.SettingScopeIdJsonConverter),

            typeof(global::Dataloop.JsonConverters.SettingScopeIdNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.SettingScopeRoleJsonConverter),

            typeof(global::Dataloop.JsonConverters.SettingScopeRoleNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.SettingsTypesJsonConverter),

            typeof(global::Dataloop.JsonConverters.SettingsTypesNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.SettingsSectionNamesJsonConverter),

            typeof(global::Dataloop.JsonConverters.SettingsSectionNamesNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.PartialSettingScopeTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.PartialSettingScopeTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.PartialSettingScopeIdJsonConverter),

            typeof(global::Dataloop.JsonConverters.PartialSettingScopeIdNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.PartialSettingScopeRoleJsonConverter),

            typeof(global::Dataloop.JsonConverters.PartialSettingScopeRoleNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.PodTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.PodTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.AlertStatusJsonConverter),

            typeof(global::Dataloop.JsonConverters.AlertStatusNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.FieldSortFieldJsonConverter),

            typeof(global::Dataloop.JsonConverters.FieldSortFieldNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.FieldSortDirectionJsonConverter),

            typeof(global::Dataloop.JsonConverters.FieldSortDirectionNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ResourceAuditEventTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.ResourceAuditEventTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.TaxTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.TaxTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.PaymentDriverTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.PaymentDriverTypeNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.InvoiceStatusJsonConverter),

            typeof(global::Dataloop.JsonConverters.InvoiceStatusNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.CurrencyJsonConverter),

            typeof(global::Dataloop.JsonConverters.CurrencyNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.PaymentDriverTypesJsonConverter),

            typeof(global::Dataloop.JsonConverters.PaymentDriverTypesNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.AzureWebhookEventActionJsonConverter),

            typeof(global::Dataloop.JsonConverters.AzureWebhookEventActionNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.AzureWebhookEventOperationRequestSourceJsonConverter),

            typeof(global::Dataloop.JsonConverters.AzureWebhookEventOperationRequestSourceNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ListExportHistoryRequestSortOrderJsonConverter),

            typeof(global::Dataloop.JsonConverters.ListExportHistoryRequestSortOrderNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.ListExportHistoryRequestSortByJsonConverter),

            typeof(global::Dataloop.JsonConverters.ListExportHistoryRequestSortByNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.QueryDatasetsRequestTargetJsonConverter),

            typeof(global::Dataloop.JsonConverters.QueryDatasetsRequestTargetNullableJsonConverter),

            typeof(global::Dataloop.JsonConverters.IRefImageAnnotationsTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.APIAnnotationCoordinateTypesJsonConverter),

            typeof(global::Dataloop.JsonConverters.BenchmarkModeJsonConverter),

            typeof(global::Dataloop.JsonConverters.SchemaEntryInputJsonConverter),

            typeof(global::Dataloop.JsonConverters.RecipeV2InputJsonConverter),

            typeof(global::Dataloop.JsonConverters.RecipeInputJsonConverter),

            typeof(global::Dataloop.JsonConverters.ModelOutputTypeJsonConverter),

            typeof(global::Dataloop.JsonConverters.IDateJsonConverter),

            typeof(global::Dataloop.JsonConverters.MetricDataJsonConverter),

            typeof(global::Dataloop.JsonConverters.ComputeMetadataJsonConverter),

            typeof(global::Dataloop.JsonConverters.IDpkComponentElementSpecJsonConverter),

            typeof(global::Dataloop.JsonConverters.CustomInstallationJsonConverter),

            typeof(global::Dataloop.JsonConverters.AppMetadataJsonConverter),

            typeof(global::Dataloop.JsonConverters.ComputePluginSpecJsonConverter),

            typeof(global::Dataloop.JsonConverters.MigrationSpecJsonConverter),

            typeof(global::Dataloop.JsonConverters.RemoveSettingTraceMigrationSpecJsonConverter),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<bool?, global::Dataloop.APIDatasetFileItemAnnotated?>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::Dataloop.APIDatasetDirectoryItemExportZip>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIDatasetFileItem>, global::System.Collections.Generic.IList<global::Dataloop.APIDatasetDirectoryItem>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.OrderBy?, global::Dataloop.SortQuery>),

            typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.ResourceReferenceMetadata, global::Dataloop.PartialAny>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<bool?, global::Dataloop.S2SetupOptions>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<bool?, global::Dataloop.APIAnnotationEventDeleted?>),

            typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<string, global::Dataloop.SystemDatasetType?>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAnnotation, global::Dataloop.APIDataset, global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?>),

            typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.ItemContext>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.MasterItemSpec, global::Dataloop.ClonedItemSpec>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.AnnotationTypeBox?, global::Dataloop.AnnotationTypeClass?, global::Dataloop.AnnotationTypeBinary?>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.FeatureFlagsSetContextVariant1, global::Dataloop.FeatureFlagsSetContextVariant2>),

            typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.DatasetContext>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>),

            typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.DriverContext>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.S3IntegrationConfig, global::Dataloop.GcsIntegrationConfig, global::Dataloop.AzureBlobIntegrationConfig, global::Dataloop.PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.S3DriverPayload, global::Dataloop.GcsDriverPayload, global::Dataloop.AzureBlobDriverPayload, global::Dataloop.PickFilesystemDriverConfigurationMountPath>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PartialS3DriverPayload, global::Dataloop.PartialGcsDriverPayload, global::Dataloop.PartialAzureBlobDriverPayload>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>),

            typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.RecipeV2Context>),

            typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.ToolInstructionOptions, global::Dataloop.Dictionary>),

            typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.RecipeContext>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>),

            typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Dictionary, global::Dataloop.AssignmentMetadataSystem>),

            typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.AssignmentContext>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>),

            typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Dictionary, global::Dataloop.TaskMetadataSystem>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIUser>, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIGroup>, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAccount, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIIntegration>, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIUser>, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIProject>, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIUser>, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIGroup>, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAccount, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIProjectGuest>, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIProject, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIIntegration, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.Role?, global::Dataloop.OrgRole?>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.OrgRole?, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.GuestType?, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIProject, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.Role?, string, global::Dataloop.APIMembershipRole?>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>),

            typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.ServiceMetadataUser, global::Dataloop.Dictionary>),

            typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.ServiceMetadataSystem, global::Dataloop.SystemRefs, global::Dataloop.Dictionary>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.ServiceContext>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ICompositionError, string>),

            typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.ExecutionContext>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.IExternalMonitoringConfig, global::Dataloop.IHpaControllerConfig, global::Dataloop.Dictionary, global::Dataloop.IStorageDriverConfig, global::Dataloop.IComputeNfsPluginConfig>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIComposition>, global::System.Collections.Generic.IList<global::Dataloop.APIPipeline>, global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.IList<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.IList<global::Dataloop.APIDpk>, global::System.Collections.Generic.IList<global::Dataloop.APIApp>, global::System.Collections.Generic.IList<global::Dataloop.APICompute>, global::System.Collections.Generic.IList<global::Dataloop.APIServiceDriver>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PlatformEntityType?, global::Dataloop.SettingScopeType?>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::Dataloop.SettingScopeId?>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.SettingScopeRole?>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PlatformEntityType?, global::Dataloop.PartialSettingScopeType?>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::Dataloop.PartialSettingScopeId?>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.PartialSettingScopeRole?>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUserSetting, global::Dataloop.APIFeatureFlag>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::Dataloop.AzureWebhookEventOperationRequestSource?>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.PartialICompute, global::Dataloop.UpdateComputeRequest2>),

            typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.DQLResourceQuery, global::Dataloop.AnyOf<global::Dataloop.FilterQuery, global::Dataloop.UpdateQuery, global::Dataloop.DeleteQuery>?>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.FilterQuery, global::Dataloop.UpdateQuery, global::Dataloop.DeleteQuery>),

            typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.MoveItemsRequest, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAnnotationRequest, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationRequest>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.ImportItemRequest>, global::Dataloop.ImportItemsToDatasetRequest>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.FeatureSet, global::System.Collections.Generic.IList<global::Dataloop.FeatureSet>>),

            typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.FeatureVector, global::System.Collections.Generic.IList<global::Dataloop.FeatureVector>>),

            typeof(global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAnnotationRequest, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationRequest>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.MetricRequest, global::System.Collections.Generic.IList<global::Dataloop.MetricRequest>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PartialCreateModelRequest, global::Dataloop.APICopyEnvironmentSpec>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.CreateOntologyPayloadV2, global::Dataloop.CreateOntologyPayload>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.RecipeV2Input?, global::Dataloop.RecipeInput?>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PartialRecipePayloadV2, global::Dataloop.PartialRecipePayload>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ResolverPayload, global::Dataloop.IUserContext>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PatchFeatureFlagRequest, global::Dataloop.PatchUserSettingRequest>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITask, global::Dataloop.APICommand>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<object, global::Dataloop.APICommand>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITask, global::Dataloop.APICommand>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::Dataloop.APITask>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIApp, object>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::Dataloop.APIAssignment>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::Dataloop.APIAssignment>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, object>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAnnotation, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotation>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.Dataset, global::Dataloop.APIDatasetSchema>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::Dataloop.Dataset>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIExecution, global::Dataloop.PiperSettingsCommands>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIExecution, global::Dataloop.APICommand>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAnnotation, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotation>>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIModel, global::Dataloop.APICommand>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIModel, global::Dataloop.APICommand>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.GetAvailableIntegrationsResponseItemVariant1, global::Dataloop.GetAvailableIntegrationsResponseItemVariant2>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIPipelineState, global::Dataloop.APICommand>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIMembership>, object>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.ClientContributor>, object>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIService, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIService, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIService, string>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITask, global::Dataloop.APICommand>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<object, global::Dataloop.APICommand>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITask, global::Dataloop.APICommand>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::Dataloop.APITask>),

            typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, object>),

            typeof(global::Dataloop.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemSpecType), TypeInfoPropertyName = "ItemSpecType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RefType), TypeInfoPropertyName = "RefType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModalityType), TypeInfoPropertyName = "ModalityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModality))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APISystemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APISystemMetadataSystem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetFileItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetFileItemType), TypeInfoPropertyName = "APIDatasetFileItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<bool?, global::Dataloop.APIDatasetFileItemAnnotated?>), TypeInfoPropertyName = "AnyOfBooleanAPIDatasetFileItemAnnotated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetFileItemAnnotated), TypeInfoPropertyName = "APIDatasetFileItemAnnotated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetDirectoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetDirectoryItemType), TypeInfoPropertyName = "APIDatasetDirectoryItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetDirectoryItemExport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::Dataloop.APIDatasetDirectoryItemExportZip>), TypeInfoPropertyName = "AnyOfStringAPIDatasetDirectoryItemExportZip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetDirectoryItemExportZip))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialAPIDatasetItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetItemCursor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIDatasetFileItem>, global::System.Collections.Generic.IList<global::Dataloop.APIDatasetDirectoryItem>>), TypeInfoPropertyName = "AnyOfIListAPIDatasetFileItemIListAPIDatasetDirectoryItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIDatasetFileItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIDatasetDirectoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Dictionary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetIndexDrivers), TypeInfoPropertyName = "DatasetIndexDrivers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CloneDatasetParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemCloneRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemMergeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskItemStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemRefOperation), TypeInfoPropertyName = "ItemRefOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemRefsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemRefsUpdateBulkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResource), TypeInfoPropertyName = "QueryResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.JoinQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.JoinQueryOn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReferenceQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReferenceQueryOperation), TypeInfoPropertyName = "ReferenceQueryOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ReferenceQueryRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReferenceQueryRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngine), TypeInfoPropertyName = "PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IntersectQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OrderBy), TypeInfoPropertyName = "OrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SortQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.OrderBy?, global::Dataloop.SortQuery>), TypeInfoPropertyName = "AnyOfOrderBySortQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DQLResourceQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DQLResourceQueryQueryEngine), TypeInfoPropertyName = "DQLResourceQueryQueryEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DQLResourceQuerySign))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AddItemMode), TypeInfoPropertyName = "AddItemMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialAny))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResourceReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.ResourceReferenceMetadata, global::Dataloop.PartialAny>), TypeInfoPropertyName = "AllOfResourceReferenceMetadataPartialAny2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResourceReferenceMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Modality))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SystemDatasetType), TypeInfoPropertyName = "SystemDatasetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecordStringString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecordCollectionKeysBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecordMLSplitListKeysBoolean))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemSystemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ItemSystemMetadataTaskStatusLogItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemSystemMetadataTaskStatusLogItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ResourceReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ItemLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.Modality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialItemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateItemMetadataOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateItemMetadataOptionsUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnnotationType), TypeInfoPropertyName = "AnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Point))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.NoteMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CoordinatesNote))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.NoteMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APINoteAnnotationCoordinatesV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PoseCoordinates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.Point>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EllipseCoordinatesV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CubeCoordinatesV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemDescriptionCoordinates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RefAnnotationsRefType), TypeInfoPropertyName = "RefAnnotationsRefType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IBaseRefAnnotationCoordinates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IRefImageAnnotationsType), TypeInfoPropertyName = "IRefImageAnnotationsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAnnotationCoordinateTypes), TypeInfoPropertyName = "APIAnnotationCoordinateTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RequestSource), TypeInfoPropertyName = "RequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateAnnotationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SetupReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.S2SetupOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BootstrapSetupInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<bool?, global::Dataloop.S2SetupOptions>), TypeInfoPropertyName = "AnyOfBooleanS2SetupOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAnnotationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialAPIAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAnnotationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<bool?, global::Dataloop.APIAnnotationEventDeleted?>), TypeInfoPropertyName = "AnyOfBooleanAPIAnnotationEventDeleted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAnnotationEventDeleted), TypeInfoPropertyName = "APIAnnotationEventDeleted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationEvent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExpirationOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IndexDriver), TypeInfoPropertyName = "IndexDriver2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetAccessLevel), TypeInfoPropertyName = "APIDatasetAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetEtlOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetScope), TypeInfoPropertyName = "DatasetScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CollectionEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.CollectionEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetSystemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<string, global::Dataloop.SystemDatasetType?>), TypeInfoPropertyName = "AllOfStringSystemDatasetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateDatasetRequestDriver), TypeInfoPropertyName = "CreateDatasetRequestDriver2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateDatasetRequestAccessLevel), TypeInfoPropertyName = "CreateDatasetRequestAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DQLQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DQLQueryQueryEngine), TypeInfoPropertyName = "DQLQueryQueryEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CloneDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.MergeDatasetParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.MergeDatasetsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialAPIDatasetPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetDirectoryTree))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DatasetDirectoryTree>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExportType), TypeInfoPropertyName = "ExportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExportDatasetOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExportDatasetOptionsAnnotations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExportDatasetOptionsExportVersion), TypeInfoPropertyName = "ExportDatasetOptionsExportVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExportStatus), TypeInfoPropertyName = "ExportStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExportErrorType), TypeInfoPropertyName = "ExportErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIExportHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ClassifyFilteredItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ClassifyFilteredItemsQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ClassifyFilteredItemsAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPIAnnotationOrAPIDatasetOrAPIDatasetFileItemOrAPIDatasetDirectoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIAnnotation, global::Dataloop.APIDataset, global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIAnnotation, global::Dataloop.APIDataset, global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>), TypeInfoPropertyName = "AnyOfAPIAnnotationAPIDatasetAPIDatasetFileItemAPIDatasetDirectoryItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResourceItems), TypeInfoPropertyName = "QueryResourceItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResourceAnnotations), TypeInfoPropertyName = "QueryResourceAnnotations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResourceDatasets), TypeInfoPropertyName = "QueryResourceDatasets2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FilterQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FilterQueryContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?>), TypeInfoPropertyName = "AnyOfQueryResourceItemsQueryResourceAnnotationsQueryResourceDatasets2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateQueryContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DeleteQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DeleteQueryContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickTranslatedQueryExcludeKeyofTranslatedQueryIntersectOrExceptOrSortOrLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DqlLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TranslatedQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RestoreAnnotationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.RestoreAnnotationsRequestAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RestoreAnnotationsRequestAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ImportItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllowedTypes), TypeInfoPropertyName = "AllowedTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SchemaEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UnsearchableSchemaReasons), TypeInfoPropertyName = "UnsearchableSchemaReasons2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UnsearchableSchemaEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SchemaMode), TypeInfoPropertyName = "SchemaMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SchemaMap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.SchemaEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.UnsearchableSchemaEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.MigrateDatasetsIndexOperationInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CleanDatasetsDataSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Boolean), TypeInfoPropertyName = "Boolean_Dataloop_Boolean")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateGCSBucketsOperationInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemRevision))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.MasterItemSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ClonedItemSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Context))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AuthZBlockItemContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.ItemContext>), TypeInfoPropertyName = "AllOfContextItemContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecordStringResourceReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetItemType), TypeInfoPropertyName = "DatasetItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ItemRevision>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.MasterItemSpec, global::Dataloop.ClonedItemSpec>), TypeInfoPropertyName = "AnyOfMasterItemSpecClonedItemSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnnotationTypeBox), TypeInfoPropertyName = "AnnotationTypeBox2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnnotationTypeClass), TypeInfoPropertyName = "AnnotationTypeClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnnotationTypeBinary), TypeInfoPropertyName = "AnnotationTypeBinary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialMsNumberbytes3Anumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickDataStreamConfigAnyMaxConcurrentReadersOrRetentionOrCompression))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GenerateDatasetOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GenerateDatasetOptionsTopics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GenerateDatasetOptionsMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GenerateDatasetOptionsAnnotations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GenerateDatasetOptionsAnnotationsMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.AnnotationTypeBox?, global::Dataloop.AnnotationTypeClass?, global::Dataloop.AnnotationTypeBinary?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.AnnotationTypeBox?, global::Dataloop.AnnotationTypeClass?, global::Dataloop.AnnotationTypeBinary?>), TypeInfoPropertyName = "AnyOfAnnotationTypeBoxAnnotationTypeClassAnnotationTypeBinary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GenerateDatasetOptionsOutputStream))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GenerationStrategyType), TypeInfoPropertyName = "GenerationStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickStartInputAnyMaxBytesOrMaxMessages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GeneratedDatasetTypes), TypeInfoPropertyName = "GeneratedDatasetTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecordStringPickGenerateDatasetCommandIdOrStatusOrError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OneByOneLatencyBenchmarkMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OneByOneLatencyBenchmarkModeType), TypeInfoPropertyName = "OneByOneLatencyBenchmarkModeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ProfilingBenchmarkMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ProfilingBenchmarkModeType), TypeInfoPropertyName = "ProfilingBenchmarkModeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ConcurrencyBenchmarkMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ConcurrencyBenchmarkModeType), TypeInfoPropertyName = "ConcurrencyBenchmarkModeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BenchmarkMode), TypeInfoPropertyName = "BenchmarkMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryTestCases), TypeInfoPropertyName = "QueryTestCases2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IndexingStrategyType), TypeInfoPropertyName = "IndexingStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ITermConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickQueryGeneratorInputAvoidDbCacheOrSelectIdsOnlyOrJoinTermsOrPageSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ITermConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InferDatasetSchemaMode), TypeInfoPropertyName = "InferDatasetSchemaMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FeatureFlagsSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.FeatureFlagsSetContextVariant1, global::Dataloop.FeatureFlagsSetContextVariant2>), TypeInfoPropertyName = "AnyOfFeatureFlagsSetContextVariant1FeatureFlagsSetContextVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FeatureFlagsSetContextVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FeatureFlagsSetContextVariant1Type), TypeInfoPropertyName = "FeatureFlagsSetContextVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FeatureFlagsSetContextVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FeatureFlagsSetContextVariant2Type), TypeInfoPropertyName = "FeatureFlagsSetContextVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetDeletionInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AuthZBlockDatasetContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.DatasetContext>), TypeInfoPropertyName = "AllOfContextDatasetContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetSchemaMap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.S2ItemMetadataSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetAccessLevel), TypeInfoPropertyName = "DatasetAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetSyncStatus), TypeInfoPropertyName = "DatasetSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SchemaEntryInput), TypeInfoPropertyName = "SchemaEntryInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SchemaEntryInputVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>), TypeInfoPropertyName = "AnyOfSchemaEntryInputVariant2Variant1SchemaEntryInputVariant2Variant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SchemaEntryInputVariant2Variant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SchemaEntryInputVariant2Variant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateItemsSchemaInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateItemsSchemaInputSchemaKeys))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.SchemaEntryInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateItemsSchemaInputUnsearchablePaths))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateItemsSchemaInputIndexingOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EditItemsSchemaModeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.MigrateStorageDriverOperationInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecordMLSplitListKeysNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverType), TypeInfoPropertyName = "DriverType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDriverConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.S3IntegrationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GcsIntegrationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AzureBlobIntegrationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverMetadataSystem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AuthZBlockDriverContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.DriverContext>), TypeInfoPropertyName = "AllOfContextDriverContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IntegrationType), TypeInfoPropertyName = "IntegrationType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EnvUserPasswordAuthentication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.KeyFileAuthentication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>), TypeInfoPropertyName = "AnyOfEnvUserPasswordAuthenticationKeyFileAuthentication2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.S3DriverPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GcsDriverPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AzureBlobDriverPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickFilesystemDriverConfigurationMountPath))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.S3IntegrationConfig, global::Dataloop.GcsIntegrationConfig, global::Dataloop.AzureBlobIntegrationConfig, global::Dataloop.PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath>), TypeInfoPropertyName = "PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath_0d00ddf7f57241a7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.S3DriverPayload, global::Dataloop.GcsDriverPayload, global::Dataloop.AzureBlobDriverPayload, global::Dataloop.PickFilesystemDriverConfigurationMountPath>), TypeInfoPropertyName = "AnyOfS3DriverPayloadGcsDriverPayloadAzureBlobDriverPayloadPickFilesystemDriverConfigurationMountPath2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecordStringLabelStringdrivers3f3AAPIDriverConfigurationArraydriverId3f3Astring))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialS3DriverPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialGcsDriverPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialAzureBlobDriverPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialDriverPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.PartialS3DriverPayload, global::Dataloop.PartialGcsDriverPayload, global::Dataloop.PartialAzureBlobDriverPayload>), TypeInfoPropertyName = "AnyOfPartialS3DriverPayloadPartialGcsDriverPayloadPartialAzureBlobDriverPayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateDriversIntegrationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.UpdateDriversIntegrationResultError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateDriversIntegrationResultError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIFeatureSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPIFeatureSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIFeatureSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FeatureSetEntityType), TypeInfoPropertyName = "FeatureSetEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FeatureSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialFeatureSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIFeatureVector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FeatureVector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPIFeatureVector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIFeatureVector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.AggregateProjectVectorsCountResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AggregateProjectVectorsCountResultItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AggregateProjectVectorsCountInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ProjectStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EditItemsStressInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IUploadItemsBenchmarkInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IndexDriver>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BenchmarkIngestionStrategyType), TypeInfoPropertyName = "BenchmarkIngestionStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GeneratedDatasetConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AddItemsOperationInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AddAnnotationsOperationInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UploadItemsBenchmarkCommandV2Input))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UploadItemsBenchmarkCommandV2InputUploadFileConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BenchmarkOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BenchmarkOptionsExportType), TypeInfoPropertyName = "BenchmarkOptionsExportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SetTaskRefsBenchmarkInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SetTaskRefsBenchmarkInputOperation), TypeInfoPropertyName = "SetTaskRefsBenchmarkInputOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SetTaskRefsStatusBenchmarkInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BulkCreateAnnotationsBenchmarkInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverReadBenchmarkOperationInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverReadBenchmarkOperationInputScenarioDetails), TypeInfoPropertyName = "DriverReadBenchmarkOperationInputScenarioDetails2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverWriteBenchmarkOperationInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverWriteBenchmarkOperationInputScenarioDetails), TypeInfoPropertyName = "DriverWriteBenchmarkOperationInputScenarioDetails2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIOntologyV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APILabelTree))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APILabelTree>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APILabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APILabelDisplayImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APILabelDisplayData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIOntology))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateOntologyPayloadV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LabelDisplayImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LabelDisplayData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateLabelPayloadV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateLabelPayloadTreeV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.CreateLabelPayloadTreeV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateOntologyPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIOntologyConfigurationV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateLabelPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AddLabelsNodePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.CreateLabelPayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateLabelsNodePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AttributeType), TypeInfoPropertyName = "AttributeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AttributeCreationPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpsertRequestPayloadAttributeCreationPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.AttributeCreationPayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIOntologyCursor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>), TypeInfoPropertyName = "AnyOfAPIOntologyV2APIOntology2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APILabelScopeV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIToolOptionsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecipeType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIRecipeV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIRecipeV2Ontology))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.APIToolOptionsV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIRecipe))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LabelScopeV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntology))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntologyOntology))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ToolOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Metadata2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecipeV2Context))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AuthZBlockRecipeV2Context))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.RecipeV2Context>), TypeInfoPropertyName = "AllOfContextRecipeV2Context2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialRecipeV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialRecipeV2Ontology))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.ToolOptions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecipeV2Input), TypeInfoPropertyName = "RecipeV2Input2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickRecipeTitleOrProjectIdsOrOntologyIds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InstructionAction), TypeInfoPropertyName = "InstructionAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InstructionScope), TypeInfoPropertyName = "InstructionScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ToolInstruction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.ToolInstructionOptions, global::Dataloop.Dictionary>), TypeInfoPropertyName = "AllOfToolInstructionOptionsDictionary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ToolInstructionOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GoodExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ToolInstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Example))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CustomAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.CustomActionTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CustomActionTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CustomActionControls), TypeInfoPropertyName = "CustomActionControls2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecipeContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AuthZBlockRecipeContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.RecipeContext>), TypeInfoPropertyName = "AllOfContextRecipeContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialRecipe))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialRecipeExamples))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.Example>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.GoodExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.CustomAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecipeInput), TypeInfoPropertyName = "RecipeInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClientLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LabelTree))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.LabelTree>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CloneRecipePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialRecipePayloadV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIInstruction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIGoodExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIInstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIBadExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICustomAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APICustomActionTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICustomActionTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICustomActionControls), TypeInfoPropertyName = "APICustomActionControls2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialRecipePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialRecipePayloadExamples))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIBadExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIGoodExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APICustomAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPIRecipeV2OrAPIRecipe))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>), TypeInfoPropertyName = "AnyOfAPIRecipeV2APIRecipe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AssignmentStatus), TypeInfoPropertyName = "AssignmentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAssignmentRemoveItemsProcess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAssignmentRedistributeProcess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialAssignmentPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAssignmentCursor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReassignAssignmentPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AssignmentWorkload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RedistributeAssignmentPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.AssignmentWorkload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BatchAssignmentPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AssignmentStatusPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AssignmentMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Dictionary, global::Dataloop.AssignmentMetadataSystem>), TypeInfoPropertyName = "AllOfDictionaryAssignmentMetadataSystem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AssignmentMetadataSystem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AssignmentMetadataSystemType), TypeInfoPropertyName = "AssignmentMetadataSystemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskType), TypeInfoPropertyName = "TaskType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AssignmentContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AuthZBlockAssignmentContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.AssignmentContext>), TypeInfoPropertyName = "AllOfContextAssignmentContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialAssignmentRedistributeProcess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialAssignmentRemoveItemsProcess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APILabelV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APILabelTreeNodeV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPILabelTreeNodeV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APILabelTreeNodeV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FilterQueryInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FilterQueryInputContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FilterQueryInputReferences))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.FilterQueryInputReferencesRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FilterQueryInputReferencesRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateLabelNodePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAttributeSection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateAttributePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateAttributePayloadScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPIAttributeSection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIAttributeSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIUpdateAttributePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIUpdateAttributePayloadScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIStructure))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateStructurePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIUpdateStructurePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPIStructure))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIStructure>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ScoreType), TypeInfoPropertyName = "ScoreType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIScoreContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Score))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ScoreContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ScoreParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ScoreParametersScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ScoreParametersScoreContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ScoreParametersOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DeleteTaskItemScoresPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DeleteTaskItemScoresPayloadContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APITaskSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APISpawnTaskSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskStatus), TypeInfoPropertyName = "TaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Description))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APITask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>), TypeInfoPropertyName = "AnyOfAPITaskSpecAPISpawnTaskSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskWorkload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryFilterContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QualityTaskTypes), TypeInfoPropertyName = "QualityTaskTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InstructionsDocumentMode), TypeInfoPropertyName = "InstructionsDocumentMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialTaskInstructionsDocumentDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Dictionary, global::Dataloop.TaskMetadataSystem>), TypeInfoPropertyName = "AllOfDictionaryTaskMetadataSystem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskMetadataSystem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.TaskWorkload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickDescriptionContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskPayloadCheckIfExist))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AddToTaskPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RemoveFromTaskPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialTaskPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskContributorsAction), TypeInfoPropertyName = "TaskContributorsAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateContributorsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APITaskCursor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APITask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskRelativeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskQueueDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DeleteTaskPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAny))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APITaskCounters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.WorkflowsCounters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GroupCtx))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.GroupCtx>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIOrg, string>), TypeInfoPropertyName = "AnyOfAPIOrgString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIOrg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIUserGuest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Role), TypeInfoPropertyName = "Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIUser>, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfIListAPIUserIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIGroup>, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfIListAPIGroupIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIUser, string>), TypeInfoPropertyName = "AnyOfAPIUserString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIAccount, string>), TypeInfoPropertyName = "AnyOfAPIAccountString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OrgPlans), TypeInfoPropertyName = "OrgPlans2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIIntegration>, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfIListAPIIntegrationIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIProject>, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfIListAPIProjectIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FeatureConstraint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.FeatureConstraint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIProjectGuest>, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfIListAPIProjectGuestIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIProjectGuest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIProjectGuest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIProject, string>), TypeInfoPropertyName = "AnyOfAPIProjectString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIIntegrationMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIIntegrationMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIIntegration, string>), TypeInfoPropertyName = "AnyOfAPIIntegrationString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateAccountRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIGoogleMarketplaceAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EditAccountRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AlertTier), TypeInfoPropertyName = "AlertTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OrgRole), TypeInfoPropertyName = "OrgRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RoleEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.Role?, global::Dataloop.OrgRole?>), TypeInfoPropertyName = "AnyOfRoleOrgRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateBotPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateGroupPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PatchGroupPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DLEntityType), TypeInfoPropertyName = "DLEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AuthUserAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OrgSize), TypeInfoPropertyName = "OrgSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OrgIndustry), TypeInfoPropertyName = "OrgIndustry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIOrgUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.OrgRole?, string>), TypeInfoPropertyName = "AnyOfOrgRoleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIOrgDomain))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IntegrationType2), TypeInfoPropertyName = "IntegrationType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IKeyValueMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IntegrationMetadataBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IntegrationBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IntegrationMetadataBody>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IntegrationBodyCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BillingResourceKey), TypeInfoPropertyName = "BillingResourceKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.MetricGroup), TypeInfoPropertyName = "MetricGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BillingResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Plan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.BillingResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BillingPeriod), TypeInfoPropertyName = "BillingPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BillingStatus), TypeInfoPropertyName = "BillingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ScopeType), TypeInfoPropertyName = "ScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APISubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APISubscriptionScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GuestType), TypeInfoPropertyName = "GuestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIGuest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.GuestType?, string>), TypeInfoPropertyName = "AnyOfGuestTypeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateGuestPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateProjectPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIMembership))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.Role?, string, global::Dataloop.APIMembershipRole?>), TypeInfoPropertyName = "AnyOfRoleStringAPIMembershipRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIMembershipRole), TypeInfoPropertyName = "APIMembershipRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UserInterestType), TypeInfoPropertyName = "UserInterestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AddMembersBatchPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ClientContributor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ClientContributorGuest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AddMemberPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PatchMemberPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateMyDetailsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIHashUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ApiKeyType), TypeInfoPropertyName = "ApiKeyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APILogin))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPILogin))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APILogin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LoginsLogQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LoginsLogQueryOrder), TypeInfoPropertyName = "LoginsLogQueryOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LoginsLogQueryOrderBy), TypeInfoPropertyName = "LoginsLogQueryOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EntityScopeLevel), TypeInfoPropertyName = "EntityScopeLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelStatus), TypeInfoPropertyName = "ModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModelConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<double?, string>), TypeInfoPropertyName = "AnyOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelInputType), TypeInfoPropertyName = "ModelInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOutputType), TypeInfoPropertyName = "ModelOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOutputTypeVariant2), TypeInfoPropertyName = "ModelOutputTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOutputTypeVariant4), TypeInfoPropertyName = "ModelOutputTypeVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ArtifactType), TypeInfoPropertyName = "ArtifactType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemArtifact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LocalArtifact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EntityContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOperationMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModelMetadataSubsets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModelMetadataAnnotationsSubsets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReferenceType), TypeInfoPropertyName = "ReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EntityReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.NodeMlType), TypeInfoPropertyName = "NodeMlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModelMetadataSystem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.EntityReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModelMetadataSystemMlType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModelMetadataSystemCloneCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModelMetadataSystemEmbedDatasets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModelMetadataSystemReloadServices))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModelMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IAppDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelStatusLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>), TypeInfoPropertyName = "AnyOfItemArtifactLocalArtifact2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ModelStatusLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPISetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PatchModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOperationTypes), TypeInfoPropertyName = "ModelOperationTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionStatus), TypeInfoPropertyName = "ExecutionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionStatusReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionStatusName), TypeInfoPropertyName = "ExecutionStatusName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionPipelineStateReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EventResourceType), TypeInfoPropertyName = "EventResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemStatusEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemStatusEventStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionEventContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResourceType), TypeInfoPropertyName = "ResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDate), TypeInfoPropertyName = "IDate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.JssdkDictionary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Execution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionFeedbackQueue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ExecutionStatusReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionPipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AuthZBlockExecutionContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ExecutionResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionMode), TypeInfoPropertyName = "ExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionSyncReplyTo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionHook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionPhase), TypeInfoPropertyName = "ExecutionPhase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OnResetAction), TypeInfoPropertyName = "OnResetAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialAPIEmbedDatasetsSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialAPIEmbedDatasetsSpecConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialCreateModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICopyEnvironmentSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.ModelJoinMap2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelJoinMap2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PrecisionRecallInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LineData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.MatrixData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SummaryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.MetricData), TypeInfoPropertyName = "MetricData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.MetricRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PrivateRegistry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceDriver))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AutoscalersDriverZombies))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIWebHook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.WebHooksPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIWebHook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateWebHookDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateWebHookDTOHttpMethod), TypeInfoPropertyName = "CreateWebHookDTOHttpMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateWebHookDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateWebHookDTOHttpMethod), TypeInfoPropertyName = "UpdateWebHookDTOHttpMethod2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIService))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIExecutionSyncReplyTo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UiSlot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.ActivitiesDescriptor2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ActivitiesDescriptor2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.ActivitiesDescriptorFunctions2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ActivitiesDescriptorFunctions2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIExecution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerType), TypeInfoPropertyName = "TriggerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EntityReferenceMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APITrigger))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggersPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APITrigger>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateTriggerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerResourceInformationItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerResourceInformationPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.TriggerResourceInformationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TriggerResourceInformationQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AgentNotificationPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AgentNotificationPayloadAgentInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ECacheMode), TypeInfoPropertyName = "ECacheMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaaSCacheSize), TypeInfoPropertyName = "FaaSCacheSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaaSCacheType), TypeInfoPropertyName = "FaaSCacheType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICacheRunner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICacheOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICacheOptionsOrg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServicesPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIService>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIServicePatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceLogLevel), TypeInfoPropertyName = "ServiceLogLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceLogEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceLogsPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ServiceLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LogsListDirection), TypeInfoPropertyName = "LogsListDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LogQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReplicaStatus), TypeInfoPropertyName = "ReplicaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIReplicaStatusUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReplicaReason), TypeInfoPropertyName = "ReplicaReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceRuntimeStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIServiceStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ServiceRuntimeStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EDebugOptionsStatus), TypeInfoPropertyName = "EDebugOptionsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DebugSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReportType), TypeInfoPropertyName = "ReportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BaseReportMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IServiceScaler))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IInvoke))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIComposition>, global::System.Collections.Generic.IList<global::Dataloop.APIPipeline>, global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.IList<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.IList<global::Dataloop.APIDpk>, global::System.Collections.Generic.IList<global::Dataloop.APIApp>, global::System.Collections.Generic.IList<global::Dataloop.APICompute>, global::System.Collections.Generic.IList<global::Dataloop.APIServiceDriver>>), TypeInfoPropertyName = "APIServiceDriver_0708f4328c68aea5")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPIPipelineState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIPipelineState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CycleRerunMethod), TypeInfoPropertyName = "CycleRerunMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IRerunCycleOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.JsExecuteOptionsBatchQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.JsExecuteOptionsBatchQueryContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IExecuteOptionsBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IRerunCycleBatchOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIPipelineTemplate2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIPipelineTemplateTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPIPipelineTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APITemplateQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryStringTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TemplateQuery))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIPipelineVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPIPipelineVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIPipelineVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutePipelinePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecuteOptionsBatchQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecuteOptionsBatchQueryContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecuteOptionsBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecuteOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.NodeDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CompositionStatusDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPIPipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PipelineNodeCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Module))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UiHook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PiperUiSlot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageType), TypeInfoPropertyName = "PackageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIPackage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.Module>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.UiHook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.PiperUiSlot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackagesPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIPackage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.JobMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.JobRuntime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.JobStatusEnum), TypeInfoPropertyName = "JobStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.JobStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Job))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionsPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionsOrderByType), TypeInfoPropertyName = "ExecutionsOrderByType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionsOrderByDirection), TypeInfoPropertyName = "ExecutionsOrderByDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CommandError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CommandStatus), TypeInfoPropertyName = "CommandStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CommandStatusHistoryEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.HttpContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CommandCtx))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ChildrenCommandsProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.CommandError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CommandsDomain), TypeInfoPropertyName = "CommandsDomain2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PiperSettingsCommands))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.CommandStatusHistoryEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PiperSettingsCommandsTrackingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PiperSettingsCommandsRetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIExecutionPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.WorkloadParams))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AgentCtx))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialICompute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IPostComposition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPIComposition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIPostApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIPatchApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PipelineType), TypeInfoPropertyName = "PipelineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ITextSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IPipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IPipelineTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingsValueTypes), TypeInfoPropertyName = "SettingsValueTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PlatformEntityType), TypeInfoPropertyName = "PlatformEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.PlatformEntityType?, global::Dataloop.SettingScopeType?>), TypeInfoPropertyName = "AnyOfPlatformEntityTypeSettingScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingScopeType), TypeInfoPropertyName = "SettingScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::Dataloop.SettingScopeId?>), TypeInfoPropertyName = "AnyOfStringSettingScopeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingScopeId), TypeInfoPropertyName = "SettingScopeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.SettingScopeRole?>), TypeInfoPropertyName = "AnyOfRoleOrgRoleSettingScopeRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingScopeRole), TypeInfoPropertyName = "SettingScopeRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingsTypes), TypeInfoPropertyName = "SettingsTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIFeatureFlag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingsSectionNames), TypeInfoPropertyName = "SettingsSectionNames2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIUserSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IUserContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResolverPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateSettingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateFeatureFlagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateUserSettingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialSettingScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.PlatformEntityType?, global::Dataloop.PartialSettingScopeType?>), TypeInfoPropertyName = "AnyOfPlatformEntityTypePartialSettingScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialSettingScopeType), TypeInfoPropertyName = "PartialSettingScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::Dataloop.PartialSettingScopeId?>), TypeInfoPropertyName = "AnyOfStringPartialSettingScopeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialSettingScopeId), TypeInfoPropertyName = "PartialSettingScopeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.PartialSettingScopeRole?>), TypeInfoPropertyName = "AnyOfRoleOrgRolePartialSettingScopeRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialSettingScopeRole), TypeInfoPropertyName = "PartialSettingScopeRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PatchFeatureFlagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PatchUserSettingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPIUserSettingOrAPIFeatureFlag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIUserSetting, global::Dataloop.APIFeatureFlag>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIUserSetting, global::Dataloop.APIFeatureFlag>), TypeInfoPropertyName = "AnyOfAPIUserSettingAPIFeatureFlag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.MigrationSpec), TypeInfoPropertyName = "MigrationSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.MigrationSpecVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RemoveSettingTraceMigrationSpec), TypeInfoPropertyName = "RemoveSettingTraceMigrationSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RemoveSettingTraceMigrationSpecVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UIHours))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICallResourceDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICallSourceDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.APICallResourceDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICallDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.StorageModificationSourceDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.StorageModificationDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.StorageDatasetDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.StorageDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.StorageDatasetDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PodType), TypeInfoPropertyName = "PodType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaasUsageServiceInstanceDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaasGlobalServiceDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaasUsageDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.FaasUsageServiceInstanceDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.FaasGlobalServiceDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemsCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IngestedDatapointsDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIUsageEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AlertStatus), TypeInfoPropertyName = "AlertStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAlert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FieldSort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FieldSortField), TypeInfoPropertyName = "FieldSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FieldSortDirection), TypeInfoPropertyName = "FieldSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResourceAuditEventType), TypeInfoPropertyName = "ResourceAuditEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResourceAuditLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResourceAuditLogCtx))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AuditLogsCursorPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ResourceAuditLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Address))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaxType), TypeInfoPropertyName = "TaxType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaxData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DBBillingAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialBillingAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialBillingAccountTaxData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PaymentDriverType), TypeInfoPropertyName = "PaymentDriverType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DBPaymentDriverConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreditCard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PaymentMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ContactAddress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ContactInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LineItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InvoiceStatus), TypeInfoPropertyName = "InvoiceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Currency), TypeInfoPropertyName = "Currency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PaymentDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Invoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ContactInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.LineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InvoiceBilledPeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.PaymentDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RangeOrFeatureTier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RangeOrFeatureTierRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OverQuota))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIBillableResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.RangeOrFeatureTier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BillingScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SubscriptionInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EditSubscriptionInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RenewSubscriptionInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPISubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APISubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CustomSubscriptionInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SubscriptionUpgradeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SubscriptionExtensionInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PaymentDriverTypes), TypeInfoPropertyName = "PaymentDriverTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UsageLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResourceUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.UsageLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UsageReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ResourceUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UsageResourcesReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.BillingResourceKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AzureWebhookEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AzureWebhookEventAction), TypeInfoPropertyName = "AzureWebhookEventAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::Dataloop.AzureWebhookEventOperationRequestSource?>), TypeInfoPropertyName = "AnyOfStringAzureWebhookEventOperationRequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AzureWebhookEventOperationRequestSource), TypeInfoPropertyName = "AzureWebhookEventOperationRequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AzureWebhookEventSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AzureWebhookEventSubscriptionTerm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AzureWebhookEventSubscriptionPurchaser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AzureWebhookEventSubscriptionBeneficiary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ArchiveAnnotationToStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RestoreArchivedAnnotationToDBRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetProjectsActiveCountersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetCountersForProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResolveTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SetItemStatusBulkTaskRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SetItemStatusBulkAssignmentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetAssignmentFieldsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryAuditLogsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateAlertRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ListAccountAlertsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InstallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UninstallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.PartialICompute, global::Dataloop.UpdateComputeRequest2>), TypeInfoPropertyName = "AllOfPartialIComputeUpdateComputeRequest22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateComputeRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SchemaCleanupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetDatasetsByProjectIdsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ListExportHistoryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ListExportHistoryRequestSortOrder), TypeInfoPropertyName = "ListExportHistoryRequestSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ListExportHistoryRequestSortBy), TypeInfoPropertyName = "ListExportHistoryRequestSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.DQLResourceQuery, global::Dataloop.AnyOf<global::Dataloop.FilterQuery, global::Dataloop.UpdateQuery, global::Dataloop.DeleteQuery>?>), TypeInfoPropertyName = "AllOfDQLResourceQueryAnyOfFilterQueryUpdateQueryDeleteQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.FilterQuery, global::Dataloop.UpdateQuery, global::Dataloop.DeleteQuery>), TypeInfoPropertyName = "AnyOfFilterQueryUpdateQueryDeleteQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryDatasetsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryDatasetsRequestTarget), TypeInfoPropertyName = "QueryDatasetsRequestTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>), TypeInfoPropertyName = "AllOfDQLResourceQueryFilterQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RestoreDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RemoveItemsByQueryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BulkUpdateMetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BullkGenerateAnnotationThumbnailsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BullkGenerateAnnotationThumbnailsRequestOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateItemCollectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AddItemsToItemCollectionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RemoveItemsFromItemCollectionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RenameItemCollectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InvalidateAnnotationThumbnailsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.MoveItemsRequest, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfMoveItemsRequestIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.MoveItemsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIAnnotationRequest, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationRequest>>), TypeInfoPropertyName = "AnyOfAPIAnnotationRequestIListAPIAnnotationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ArchiveDatasetItemAnnotationToStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RestoreArchivedDatasetItemAnnotationToDBRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetFilteredDatasetLabelAggregationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetFilteredDatasetTypeAggregationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.ImportItemRequest>, global::Dataloop.ImportItemsToDatasetRequest>), TypeInfoPropertyName = "AnyOfIListImportItemRequestImportItemsToDatasetRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ImportItemRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ImportItemsToDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SplitMlOperationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.MigrateDriversIntegrationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CheckStorageDriversIntegrationByIntegrationIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.NackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PushProgressRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateExecutionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.FeatureSet, global::System.Collections.Generic.IList<global::Dataloop.FeatureSet>>), TypeInfoPropertyName = "AnyOfFeatureSetIListFeatureSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.FeatureSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.FeatureVector, global::System.Collections.Generic.IList<global::Dataloop.FeatureVector>>), TypeInfoPropertyName = "AnyOfFeatureVectorIListFeatureVector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.FeatureVector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AddGroupMemberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateGroupOwnerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AddSubGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ArchiveItemAnnotationToStorageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RestoreArchivedItemAnnotationToDBRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.MetricRequest, global::System.Collections.Generic.IList<global::Dataloop.MetricRequest>>), TypeInfoPropertyName = "AnyOfMetricRequestIListMetricRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.MetricRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GenerateModelMetricsReportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelsExecutionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelsServicesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.PartialCreateModelRequest, global::Dataloop.APICopyEnvironmentSpec>), TypeInfoPropertyName = "AnyOfPartialCreateModelRequestAPICopyEnvironmentSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DeployModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateModelDeploymentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExtractItemFeaturesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExtractItemFeaturesRequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExtractItemFeaturesRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EvaluateModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EvaluateModelRequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EvaluateModelRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelPredictionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelPredictionRequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelPredictionRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TrainModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.CreateOntologyPayloadV2, global::Dataloop.CreateOntologyPayload>), TypeInfoPropertyName = "AnyOfCreateOntologyPayloadV2CreateOntologyPayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DeleteAttributesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.UpdateLabelNodePayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateOrgRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PatchOrgRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateIntegrationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AddOrgMembersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PatchOrgMemberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateOrgPlanRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InstallRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UninstallRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LogsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryBillingMetricsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateProjectGuestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AddOrgToGuestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PatchProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SetProjectAccountRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AddOrgToProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AddGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryEntitiesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.RecipeV2Input?, global::Dataloop.RecipeInput?>), TypeInfoPropertyName = "AnyOfRecipeV2InputRecipeInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.PartialRecipePayloadV2, global::Dataloop.PartialRecipePayload>), TypeInfoPropertyName = "AnyOfPartialRecipePayloadV2PartialRecipePayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateScoresRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.Score>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SetDefaultRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.GetGlobalServicesRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetGlobalServicesRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.BaseReportMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RolloutServiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.ResolverPayload, global::Dataloop.IUserContext>), TypeInfoPropertyName = "AnyOfResolverPayloadIUserContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.PatchFeatureFlagRequest, global::Dataloop.PatchUserSettingRequest>), TypeInfoPropertyName = "AnyOfPatchFeatureFlagRequestPatchUserSettingRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DeleteSettingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetProjectsActiveCountersRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetCountersForProjectRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateUserOrgRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>), TypeInfoPropertyName = "AnyOfAPITaskAPICommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<object, global::Dataloop.APICommand>), TypeInfoPropertyName = "AnyOfObjectAPICommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.TaskRelativeInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.APITask>), TypeInfoPropertyName = "AnyOfAPICommandAPITask2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DpkAttributesDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIApp, object>), TypeInfoPropertyName = "AnyOfAPIAppObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>), TypeInfoPropertyName = "AnyOfAPICommandIListAPIAssignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.APIAssignment>), TypeInfoPropertyName = "AnyOfAPICommandAPIAssignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIUsageEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIAlert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DBPaymentDriverConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.PaymentMethod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, object>), TypeInfoPropertyName = "AnyOfAPICommandObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIDataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetDatasetsByProjectIdsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ListExportHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIExportHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>), TypeInfoPropertyName = "AnyOfAPIDatasetFileItemAPIDatasetDirectoryItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIAnnotation, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotation>>), TypeInfoPropertyName = "AnyOfAPIAnnotationIListAPIAnnotation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.Dataset, global::Dataloop.APIDatasetSchema>), TypeInfoPropertyName = "AnyOfDatasetAPIDatasetSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, string>), TypeInfoPropertyName = "AnyOfAPICommandString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.Dataset>), TypeInfoPropertyName = "AnyOfAPICommandDataset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIDriverConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIExecution, global::Dataloop.PiperSettingsCommands>), TypeInfoPropertyName = "AnyOfAPIExecutionPiperSettingsCommands2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIExecution, global::Dataloop.APICommand>), TypeInfoPropertyName = "AnyOfAPIExecutionAPICommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.AuthUserAttributes>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.Invoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PublishModelMetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.Error>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelsDatasetsCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIModel, global::Dataloop.APICommand>), TypeInfoPropertyName = "AnyOfAPIModelAPICommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.GetAvailableIntegrationsResponseItemVariant1, global::Dataloop.GetAvailableIntegrationsResponseItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.GetAvailableIntegrationsResponseItemVariant1, global::Dataloop.GetAvailableIntegrationsResponseItemVariant2>), TypeInfoPropertyName = "AnyOfGetAvailableIntegrationsResponseItemVariant1GetAvailableIntegrationsResponseItemVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetAvailableIntegrationsResponseItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.GetAvailableIntegrationsResponseItemVariant1Option>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetAvailableIntegrationsResponseItemVariant1Option))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetAvailableIntegrationsResponseItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.GetAvailableIntegrationsResponseItemVariant2Option>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetAvailableIntegrationsResponseItemVariant2Option))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIOrgUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.QueryPipelineTableResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryPipelineTableResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryPipelineTableResponseItemTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.APICommand>), TypeInfoPropertyName = "AnyOfAPIPipelineStateAPICommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TerminateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.PipelineExecutionLogs>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.Plan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIBillableResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIGuest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIMembership>, object>), TypeInfoPropertyName = "AnyOfIListAPIMembershipObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIMembership>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.ClientContributor>, object>), TypeInfoPropertyName = "AnyOfIListClientContributorObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ClientContributor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryConfusionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetTaskScoresResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetTaskAnnotationScoresResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetTaskItemScoresResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.GetGlobalServicesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetGlobalServicesResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.APIServiceStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIService, string>), TypeInfoPropertyName = "AnyOfAPIServiceString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceStreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetServiceIntegrationEnvResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.GetServiceIntegrationEnvResponseEnvItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetServiceIntegrationEnvResponseEnvItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>), TypeInfoPropertyName = "AnyOfAPIFeatureFlagAPIUserSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.UsageReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.GetMyGroupProjectsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetMyGroupProjectsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIUser, object>), TypeInfoPropertyName = "AnyOfAPIUserObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIDatasetFileItem>, global::System.Collections.Generic.List<global::Dataloop.APIDatasetDirectoryItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIDatasetFileItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIDatasetDirectoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ReferenceQueryRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ItemSystemMetadataTaskStatusLogItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ResourceReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ItemLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.Modality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.NoteMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Dataloop.Point>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.Point>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIAnnotationRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Dataloop.APIAnnotationEvent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIAnnotationEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DatasetDirectoryTree>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIAnnotation, global::Dataloop.APIDataset, global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.RestoreAnnotationsRequestAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ItemRevision>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.AnnotationTypeBox?, global::Dataloop.AnnotationTypeClass?, global::Dataloop.AnnotationTypeBinary?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ITermConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.SchemaEntryInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.UpdateDriversIntegrationResultError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIFeatureSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIFeatureVector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AggregateProjectVectorsCountResultItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IndexDriver>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APILabelTree>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.CreateLabelPayloadTreeV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.CreateLabelPayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AttributeCreationPayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ToolInstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.CustomActionTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.Example>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.GoodExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.CustomAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.LabelTree>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIInstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APICustomActionTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIBadExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIGoodExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APICustomAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AssignmentWorkload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APILabelTreeNodeV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.FilterQueryInputReferencesRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIAttributeSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIStructure>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.TaskWorkload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APITask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.GroupCtx>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIUser>, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIGroup>, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIIntegration>, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIProject>, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.FeatureConstraint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIProjectGuest>, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIProjectGuest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIIntegrationMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IntegrationMetadataBody>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.BillingResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APILogin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.EntityReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ModelStatusLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ExecutionStatusReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ExecutionResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIWebHook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.Panel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ServiceIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PackageIO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DisplayScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DLFunctionDefaultInputSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DLFunctionInputOptionsSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIExecution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APITrigger>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.TriggerResourceInformationItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIService>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ServiceLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ServiceRuntimeStatus>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIComposition>, global::System.Collections.Generic.List<global::Dataloop.APIPipeline>, global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.List<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.List<global::Dataloop.APIDpk>, global::System.Collections.Generic.List<global::Dataloop.APIApp>, global::System.Collections.Generic.List<global::Dataloop.APICompute>, global::System.Collections.Generic.List<global::Dataloop.APIServiceDriver>>), TypeInfoPropertyName = "APIServiceDriver_ce74abc722e1be30")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIComposition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIPipeline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ResourceExecution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIDpk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APICompute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIServiceDriver>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIPipelineState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ExecutionLogs>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IExecutionCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IPipelineExecutionCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.INodeExecutionCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.INodeExecutionStatistics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIPipelineVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.Module>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.UiHook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PiperUiSlot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIPackage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.CommandError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.CommandStatusHistoryEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DpkAttributeValueDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PreviewsComponentsPatchPipelineTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIUserSetting, global::Dataloop.APIFeatureFlag>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.StorageDatasetDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.FaasUsageServiceInstanceDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.FaasGlobalServiceDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ResourceAuditLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ContactInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.LineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PaymentDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.RangeOrFeatureTier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APISubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.UsageLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ResourceUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.BillingResourceKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.MoveItemsRequest, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIAnnotationRequest, global::System.Collections.Generic.List<global::Dataloop.APIAnnotationRequest>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.ImportItemRequest>, global::Dataloop.ImportItemsToDatasetRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ImportItemRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.FeatureSet, global::System.Collections.Generic.List<global::Dataloop.FeatureSet>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.FeatureSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.FeatureVector, global::System.Collections.Generic.List<global::Dataloop.FeatureVector>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.FeatureVector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.MetricRequest, global::System.Collections.Generic.List<global::Dataloop.MetricRequest>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.MetricRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.UpdateLabelNodePayload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.Score>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.GetGlobalServicesRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.BaseReportMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.TaskRelativeInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIApiKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DpkAttributesDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, global::System.Collections.Generic.List<global::Dataloop.APIAssignment>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIUsageEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIAlert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DBPaymentDriverConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PaymentMethod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIDataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIExportHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIAnnotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIAnnotation, global::System.Collections.Generic.List<global::Dataloop.APIAnnotation>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIDriverConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AuthUserAttributes>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.Invoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.GetAvailableIntegrationsResponseItemVariant1, global::Dataloop.GetAvailableIntegrationsResponseItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.GetAvailableIntegrationsResponseItemVariant1Option>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.GetAvailableIntegrationsResponseItemVariant2Option>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIOrgUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.QueryPipelineTableResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PipelineExecutionLogs>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.Plan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIBillableResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIGuest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIMembership>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIMembership>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.ClientContributor>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ClientContributor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.GetGlobalServicesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.GetServiceIntegrationEnvResponseEnvItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.UsageReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.GetMyGroupProjectsResponseItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}