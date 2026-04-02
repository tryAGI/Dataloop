
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// # Drive your AI to production with end-to-end data management, automation pipelines and a quality-first data labeling platform.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class DataloopClient : global::Dataloop.IDataloopClient, global::System.IDisposable
    {
        /// <summary>
        /// Main Dataloop Gateway
        /// </summary>
        public const string DefaultBaseUrl = "https://gate.dataloop.ai/api/v1";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Dataloop.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::Dataloop.JsonConverters.ItemSpecTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ItemSpecTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.RefTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.RefTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ModalityTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ModalityTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.APIDatasetFileItemTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.APIDatasetFileItemTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.APIDatasetFileItemAnnotatedJsonConverter(),
                    new global::Dataloop.JsonConverters.APIDatasetFileItemAnnotatedNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.APIDatasetDirectoryItemTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.APIDatasetDirectoryItemTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.DatasetIndexDriversJsonConverter(),
                    new global::Dataloop.JsonConverters.DatasetIndexDriversNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ItemRefOperationJsonConverter(),
                    new global::Dataloop.JsonConverters.ItemRefOperationNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.QueryResourceJsonConverter(),
                    new global::Dataloop.JsonConverters.QueryResourceNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ReferenceQueryOperationJsonConverter(),
                    new global::Dataloop.JsonConverters.ReferenceQueryOperationNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngineJsonConverter(),
                    new global::Dataloop.JsonConverters.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngineNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.OrderByJsonConverter(),
                    new global::Dataloop.JsonConverters.OrderByNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.DQLResourceQueryQueryEngineJsonConverter(),
                    new global::Dataloop.JsonConverters.DQLResourceQueryQueryEngineNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.AddItemModeJsonConverter(),
                    new global::Dataloop.JsonConverters.AddItemModeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.SystemDatasetTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.SystemDatasetTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.AnnotationTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.AnnotationTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.RefAnnotationsRefTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.RefAnnotationsRefTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.RequestSourceJsonConverter(),
                    new global::Dataloop.JsonConverters.RequestSourceNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.APIAnnotationEventDeletedJsonConverter(),
                    new global::Dataloop.JsonConverters.APIAnnotationEventDeletedNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.IndexDriverJsonConverter(),
                    new global::Dataloop.JsonConverters.IndexDriverNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.APIDatasetAccessLevelJsonConverter(),
                    new global::Dataloop.JsonConverters.APIDatasetAccessLevelNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.DatasetScopeJsonConverter(),
                    new global::Dataloop.JsonConverters.DatasetScopeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.CreateDatasetRequestDriverJsonConverter(),
                    new global::Dataloop.JsonConverters.CreateDatasetRequestDriverNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.CreateDatasetRequestAccessLevelJsonConverter(),
                    new global::Dataloop.JsonConverters.CreateDatasetRequestAccessLevelNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.DQLQueryQueryEngineJsonConverter(),
                    new global::Dataloop.JsonConverters.DQLQueryQueryEngineNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ExportTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ExportTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ExportDatasetOptionsExportVersionJsonConverter(),
                    new global::Dataloop.JsonConverters.ExportDatasetOptionsExportVersionNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ExportStatusJsonConverter(),
                    new global::Dataloop.JsonConverters.ExportStatusNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ExportErrorTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ExportErrorTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.QueryResourceItemsJsonConverter(),
                    new global::Dataloop.JsonConverters.QueryResourceItemsNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.QueryResourceAnnotationsJsonConverter(),
                    new global::Dataloop.JsonConverters.QueryResourceAnnotationsNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.QueryResourceDatasetsJsonConverter(),
                    new global::Dataloop.JsonConverters.QueryResourceDatasetsNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.AllowedTypesJsonConverter(),
                    new global::Dataloop.JsonConverters.AllowedTypesNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.UnsearchableSchemaReasonsJsonConverter(),
                    new global::Dataloop.JsonConverters.UnsearchableSchemaReasonsNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.SchemaModeJsonConverter(),
                    new global::Dataloop.JsonConverters.SchemaModeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.DatasetItemTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.DatasetItemTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.AnnotationTypeBoxJsonConverter(),
                    new global::Dataloop.JsonConverters.AnnotationTypeBoxNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.AnnotationTypeClassJsonConverter(),
                    new global::Dataloop.JsonConverters.AnnotationTypeClassNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.AnnotationTypeBinaryJsonConverter(),
                    new global::Dataloop.JsonConverters.AnnotationTypeBinaryNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.GenerationStrategyTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.GenerationStrategyTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.GeneratedDatasetTypesJsonConverter(),
                    new global::Dataloop.JsonConverters.GeneratedDatasetTypesNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.OneByOneLatencyBenchmarkModeTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.OneByOneLatencyBenchmarkModeTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ProfilingBenchmarkModeTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ProfilingBenchmarkModeTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ConcurrencyBenchmarkModeTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ConcurrencyBenchmarkModeTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.QueryTestCasesJsonConverter(),
                    new global::Dataloop.JsonConverters.QueryTestCasesNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.IndexingStrategyTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.IndexingStrategyTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.InferDatasetSchemaModeJsonConverter(),
                    new global::Dataloop.JsonConverters.InferDatasetSchemaModeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.FeatureFlagsSetContextVariant1TypeJsonConverter(),
                    new global::Dataloop.JsonConverters.FeatureFlagsSetContextVariant1TypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.FeatureFlagsSetContextVariant2TypeJsonConverter(),
                    new global::Dataloop.JsonConverters.FeatureFlagsSetContextVariant2TypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.DatasetAccessLevelJsonConverter(),
                    new global::Dataloop.JsonConverters.DatasetAccessLevelNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.DatasetSyncStatusJsonConverter(),
                    new global::Dataloop.JsonConverters.DatasetSyncStatusNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.DriverTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.DriverTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.IntegrationTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.IntegrationTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.FeatureSetEntityTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.FeatureSetEntityTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.BenchmarkIngestionStrategyTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.BenchmarkIngestionStrategyTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.BenchmarkOptionsExportTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.BenchmarkOptionsExportTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.SetTaskRefsBenchmarkInputOperationJsonConverter(),
                    new global::Dataloop.JsonConverters.SetTaskRefsBenchmarkInputOperationNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.DriverReadBenchmarkOperationInputScenarioDetailsJsonConverter(),
                    new global::Dataloop.JsonConverters.DriverReadBenchmarkOperationInputScenarioDetailsNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.DriverWriteBenchmarkOperationInputScenarioDetailsJsonConverter(),
                    new global::Dataloop.JsonConverters.DriverWriteBenchmarkOperationInputScenarioDetailsNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.AttributeTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.AttributeTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.InstructionActionJsonConverter(),
                    new global::Dataloop.JsonConverters.InstructionActionNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.InstructionScopeJsonConverter(),
                    new global::Dataloop.JsonConverters.InstructionScopeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.CustomActionControlsJsonConverter(),
                    new global::Dataloop.JsonConverters.CustomActionControlsNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.APICustomActionControlsJsonConverter(),
                    new global::Dataloop.JsonConverters.APICustomActionControlsNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.AssignmentStatusJsonConverter(),
                    new global::Dataloop.JsonConverters.AssignmentStatusNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.AssignmentMetadataSystemTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.AssignmentMetadataSystemTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.TaskTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.TaskTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ScoreTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ScoreTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.TaskStatusJsonConverter(),
                    new global::Dataloop.JsonConverters.TaskStatusNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.QualityTaskTypesJsonConverter(),
                    new global::Dataloop.JsonConverters.QualityTaskTypesNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.InstructionsDocumentModeJsonConverter(),
                    new global::Dataloop.JsonConverters.InstructionsDocumentModeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.TaskContributorsActionJsonConverter(),
                    new global::Dataloop.JsonConverters.TaskContributorsActionNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.RoleJsonConverter(),
                    new global::Dataloop.JsonConverters.RoleNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.OrgPlansJsonConverter(),
                    new global::Dataloop.JsonConverters.OrgPlansNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.AlertTierJsonConverter(),
                    new global::Dataloop.JsonConverters.AlertTierNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.OrgRoleJsonConverter(),
                    new global::Dataloop.JsonConverters.OrgRoleNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.DLEntityTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.DLEntityTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.OrgSizeJsonConverter(),
                    new global::Dataloop.JsonConverters.OrgSizeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.OrgIndustryJsonConverter(),
                    new global::Dataloop.JsonConverters.OrgIndustryNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.IntegrationType2JsonConverter(),
                    new global::Dataloop.JsonConverters.IntegrationType2NullableJsonConverter(),
                    new global::Dataloop.JsonConverters.BillingResourceKeyJsonConverter(),
                    new global::Dataloop.JsonConverters.BillingResourceKeyNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.MetricGroupJsonConverter(),
                    new global::Dataloop.JsonConverters.MetricGroupNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.BillingPeriodJsonConverter(),
                    new global::Dataloop.JsonConverters.BillingPeriodNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.BillingStatusJsonConverter(),
                    new global::Dataloop.JsonConverters.BillingStatusNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ScopeTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ScopeTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.GuestTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.GuestTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.APIMembershipRoleJsonConverter(),
                    new global::Dataloop.JsonConverters.APIMembershipRoleNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.UserInterestTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.UserInterestTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ApiKeyTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ApiKeyTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.LoginsLogQueryOrderJsonConverter(),
                    new global::Dataloop.JsonConverters.LoginsLogQueryOrderNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.LoginsLogQueryOrderByJsonConverter(),
                    new global::Dataloop.JsonConverters.LoginsLogQueryOrderByNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.EntityScopeLevelJsonConverter(),
                    new global::Dataloop.JsonConverters.EntityScopeLevelNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ModelStatusJsonConverter(),
                    new global::Dataloop.JsonConverters.ModelStatusNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ModelInputTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ModelInputTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ModelOutputTypeVariant2JsonConverter(),
                    new global::Dataloop.JsonConverters.ModelOutputTypeVariant2NullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ModelOutputTypeVariant4JsonConverter(),
                    new global::Dataloop.JsonConverters.ModelOutputTypeVariant4NullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ArtifactTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ArtifactTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ReferenceTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ReferenceTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.NodeMlTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.NodeMlTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ModelOperationTypesJsonConverter(),
                    new global::Dataloop.JsonConverters.ModelOperationTypesNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ExecutionStatusJsonConverter(),
                    new global::Dataloop.JsonConverters.ExecutionStatusNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.EventResourceTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.EventResourceTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.CreateWebHookDTOHttpMethodJsonConverter(),
                    new global::Dataloop.JsonConverters.CreateWebHookDTOHttpMethodNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.UpdateWebHookDTOHttpMethodJsonConverter(),
                    new global::Dataloop.JsonConverters.UpdateWebHookDTOHttpMethodNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.OnResetActionJsonConverter(),
                    new global::Dataloop.JsonConverters.OnResetActionNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ServiceTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ServiceTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.CrashloopActionJsonConverter(),
                    new global::Dataloop.JsonConverters.CrashloopActionNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.CrashloopReasonJsonConverter(),
                    new global::Dataloop.JsonConverters.CrashloopReasonNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ServiceModeTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ServiceModeTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.PackageResourceTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.PackageResourceTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ExecutionHookValueFromJsonConverter(),
                    new global::Dataloop.JsonConverters.ExecutionHookValueFromNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ExecutionHookTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ExecutionHookTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.UiBindingResourceJsonConverter(),
                    new global::Dataloop.JsonConverters.UiBindingResourceNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.UiBindingPanelJsonConverter(),
                    new global::Dataloop.JsonConverters.UiBindingPanelNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ExecutionPostActionTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ExecutionPostActionTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ExecutionStatusNameJsonConverter(),
                    new global::Dataloop.JsonConverters.ExecutionStatusNameNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ResourceTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ResourceTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.TriggerTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.TriggerTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ECacheModeJsonConverter(),
                    new global::Dataloop.JsonConverters.ECacheModeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.FaaSCacheSizeJsonConverter(),
                    new global::Dataloop.JsonConverters.FaaSCacheSizeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.FaaSCacheTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.FaaSCacheTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ServiceLogLevelJsonConverter(),
                    new global::Dataloop.JsonConverters.ServiceLogLevelNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.LogsListDirectionJsonConverter(),
                    new global::Dataloop.JsonConverters.LogsListDirectionNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ReplicaStatusJsonConverter(),
                    new global::Dataloop.JsonConverters.ReplicaStatusNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ReplicaReasonJsonConverter(),
                    new global::Dataloop.JsonConverters.ReplicaReasonNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.EDebugOptionsStatusJsonConverter(),
                    new global::Dataloop.JsonConverters.EDebugOptionsStatusNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ReportTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ReportTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ServiceDriverTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ServiceDriverTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.DataloopPodTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.DataloopPodTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ComputeMetadataVariant2ServeAgentGatewayJsonConverter(),
                    new global::Dataloop.JsonConverters.ComputeMetadataVariant2ServeAgentGatewayNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.CompositionElementStatusJsonConverter(),
                    new global::Dataloop.JsonConverters.CompositionElementStatusNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.CompositionStatusJsonConverter(),
                    new global::Dataloop.JsonConverters.CompositionStatusNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.TriggerResourceTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.TriggerResourceTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.TriggerActionTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.TriggerActionTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ExecutionModeJsonConverter(),
                    new global::Dataloop.JsonConverters.ExecutionModeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.TriggerOperationTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.TriggerOperationTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ECompositionPackageStatusJsonConverter(),
                    new global::Dataloop.JsonConverters.ECompositionPackageStatusNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.PackageConfigTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.PackageConfigTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.PackageRequirementOperatorJsonConverter(),
                    new global::Dataloop.JsonConverters.PackageRequirementOperatorNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.CodebaseTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.CodebaseTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ChannelTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ChannelTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.CompositionChannelStatusJsonConverter(),
                    new global::Dataloop.JsonConverters.CompositionChannelStatusNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.TemplateKindJsonConverter(),
                    new global::Dataloop.JsonConverters.TemplateKindNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.NodeTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.NodeTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.StartNodeTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.StartNodeTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ResumePipelineOptionJsonConverter(),
                    new global::Dataloop.JsonConverters.ResumePipelineOptionNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.PipelineFromTemplateStateJsonConverter(),
                    new global::Dataloop.JsonConverters.PipelineFromTemplateStateNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ICompositionDatasetStateDatasetIndexDriverJsonConverter(),
                    new global::Dataloop.JsonConverters.ICompositionDatasetStateDatasetIndexDriverNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ICompositionDatasetStateDatasetShareLevelJsonConverter(),
                    new global::Dataloop.JsonConverters.ICompositionDatasetStateDatasetShareLevelNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.DpkDatasetOntologyTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.DpkDatasetOntologyTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ExecutionPhaseJsonConverter(),
                    new global::Dataloop.JsonConverters.ExecutionPhaseNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ENodeStatusJsonConverter(),
                    new global::Dataloop.JsonConverters.ENodeStatusNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.EPipelineStatusJsonConverter(),
                    new global::Dataloop.JsonConverters.EPipelineStatusNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.EDpkScopeJsonConverter(),
                    new global::Dataloop.JsonConverters.EDpkScopeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.EComponentServiceOperationJsonConverter(),
                    new global::Dataloop.JsonConverters.EComponentServiceOperationNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.FilterFrequencyTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.FilterFrequencyTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.InvokeTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.InvokeTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.CustomNodeScopeJsonConverter(),
                    new global::Dataloop.JsonConverters.CustomNodeScopeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.EComponentElementTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.EComponentElementTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.EAppScopeJsonConverter(),
                    new global::Dataloop.JsonConverters.EAppScopeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.EComputeTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.EComputeTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.EComputeStatusJsonConverter(),
                    new global::Dataloop.JsonConverters.EComputeStatusNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.EClusterProviderJsonConverter(),
                    new global::Dataloop.JsonConverters.EClusterProviderNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.EComputePluginJsonConverter(),
                    new global::Dataloop.JsonConverters.EComputePluginNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.EStorageTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.EStorageTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.KubernetesServiceTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.KubernetesServiceTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.EComputeConsumptionMethodJsonConverter(),
                    new global::Dataloop.JsonConverters.EComputeConsumptionMethodNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.CycleRerunMethodJsonConverter(),
                    new global::Dataloop.JsonConverters.CycleRerunMethodNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.PackageTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.PackageTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.JobStatusEnumJsonConverter(),
                    new global::Dataloop.JsonConverters.JobStatusEnumNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ExecutionsOrderByTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ExecutionsOrderByTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ExecutionsOrderByDirectionJsonConverter(),
                    new global::Dataloop.JsonConverters.ExecutionsOrderByDirectionNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.CommandStatusJsonConverter(),
                    new global::Dataloop.JsonConverters.CommandStatusNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.CommandsDomainJsonConverter(),
                    new global::Dataloop.JsonConverters.CommandsDomainNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.PipelineTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.PipelineTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.SettingsValueTypesJsonConverter(),
                    new global::Dataloop.JsonConverters.SettingsValueTypesNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.PlatformEntityTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.PlatformEntityTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.SettingScopeTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.SettingScopeTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.SettingScopeIdJsonConverter(),
                    new global::Dataloop.JsonConverters.SettingScopeIdNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.SettingScopeRoleJsonConverter(),
                    new global::Dataloop.JsonConverters.SettingScopeRoleNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.SettingsTypesJsonConverter(),
                    new global::Dataloop.JsonConverters.SettingsTypesNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.SettingsSectionNamesJsonConverter(),
                    new global::Dataloop.JsonConverters.SettingsSectionNamesNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.PartialSettingScopeTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.PartialSettingScopeTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.PartialSettingScopeIdJsonConverter(),
                    new global::Dataloop.JsonConverters.PartialSettingScopeIdNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.PartialSettingScopeRoleJsonConverter(),
                    new global::Dataloop.JsonConverters.PartialSettingScopeRoleNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.PodTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.PodTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.AlertStatusJsonConverter(),
                    new global::Dataloop.JsonConverters.AlertStatusNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.FieldSortFieldJsonConverter(),
                    new global::Dataloop.JsonConverters.FieldSortFieldNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.FieldSortDirectionJsonConverter(),
                    new global::Dataloop.JsonConverters.FieldSortDirectionNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ResourceAuditEventTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.ResourceAuditEventTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.TaxTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.TaxTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.PaymentDriverTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.PaymentDriverTypeNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.InvoiceStatusJsonConverter(),
                    new global::Dataloop.JsonConverters.InvoiceStatusNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.CurrencyJsonConverter(),
                    new global::Dataloop.JsonConverters.CurrencyNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.PaymentDriverTypesJsonConverter(),
                    new global::Dataloop.JsonConverters.PaymentDriverTypesNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.AzureWebhookEventActionJsonConverter(),
                    new global::Dataloop.JsonConverters.AzureWebhookEventActionNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.AzureWebhookEventOperationRequestSourceJsonConverter(),
                    new global::Dataloop.JsonConverters.AzureWebhookEventOperationRequestSourceNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ListExportHistoryRequestSortOrderJsonConverter(),
                    new global::Dataloop.JsonConverters.ListExportHistoryRequestSortOrderNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.ListExportHistoryRequestSortByJsonConverter(),
                    new global::Dataloop.JsonConverters.ListExportHistoryRequestSortByNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.QueryDatasetsRequestTargetJsonConverter(),
                    new global::Dataloop.JsonConverters.QueryDatasetsRequestTargetNullableJsonConverter(),
                    new global::Dataloop.JsonConverters.IRefImageAnnotationsTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.APIAnnotationCoordinateTypesJsonConverter(),
                    new global::Dataloop.JsonConverters.BenchmarkModeJsonConverter(),
                    new global::Dataloop.JsonConverters.SchemaEntryInputJsonConverter(),
                    new global::Dataloop.JsonConverters.RecipeV2InputJsonConverter(),
                    new global::Dataloop.JsonConverters.RecipeInputJsonConverter(),
                    new global::Dataloop.JsonConverters.ModelOutputTypeJsonConverter(),
                    new global::Dataloop.JsonConverters.IDateJsonConverter(),
                    new global::Dataloop.JsonConverters.MetricDataJsonConverter(),
                    new global::Dataloop.JsonConverters.ComputeMetadataJsonConverter(),
                    new global::Dataloop.JsonConverters.IDpkComponentElementSpecJsonConverter(),
                    new global::Dataloop.JsonConverters.CustomInstallationJsonConverter(),
                    new global::Dataloop.JsonConverters.AppMetadataJsonConverter(),
                    new global::Dataloop.JsonConverters.MigrationSpecJsonConverter(),
                    new global::Dataloop.JsonConverters.RemoveSettingTraceMigrationSpecJsonConverter(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<bool?, global::Dataloop.APIDatasetFileItemAnnotated?>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::Dataloop.APIDatasetDirectoryItemExportZip>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIDatasetFileItem>, global::System.Collections.Generic.IList<global::Dataloop.APIDatasetDirectoryItem>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.OrderBy?, global::Dataloop.SortQuery>(),
                    new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.ResourceReferenceMetadata, global::Dataloop.PartialAny>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<bool?, global::Dataloop.S2SetupOptions>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<bool?, global::Dataloop.APIAnnotationEventDeleted?>(),
                    new global::Dataloop.JsonConverters.AllOfJsonConverter<string, global::Dataloop.SystemDatasetType?>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAnnotation, global::Dataloop.APIDataset, global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?>(),
                    new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.ItemContext>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.MasterItemSpec, global::Dataloop.ClonedItemSpec>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.AnnotationTypeBox?, global::Dataloop.AnnotationTypeClass?, global::Dataloop.AnnotationTypeBinary?>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.FeatureFlagsSetContextVariant1, global::Dataloop.FeatureFlagsSetContextVariant2>(),
                    new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.DatasetContext>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>(),
                    new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.DriverContext>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.S3IntegrationConfig, global::Dataloop.GcsIntegrationConfig, global::Dataloop.AzureBlobIntegrationConfig, global::Dataloop.PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.S3DriverPayload, global::Dataloop.GcsDriverPayload, global::Dataloop.AzureBlobDriverPayload, global::Dataloop.PickFilesystemDriverConfigurationMountPath>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PartialS3DriverPayload, global::Dataloop.PartialGcsDriverPayload, global::Dataloop.PartialAzureBlobDriverPayload>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>(),
                    new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.RecipeV2Context>(),
                    new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.ToolInstructionOptions, global::Dataloop.Dictionary>(),
                    new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.RecipeContext>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>(),
                    new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Dictionary, global::Dataloop.AssignmentMetadataSystem>(),
                    new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.AssignmentContext>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>(),
                    new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Dictionary, global::Dataloop.TaskMetadataSystem>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIUser>, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIGroup>, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAccount, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIIntegration>, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIUser>, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIProject>, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIUser>, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIGroup>, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAccount, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIProjectGuest>, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIProject, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIIntegration, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.Role?, global::Dataloop.OrgRole?>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.OrgRole?, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.GuestType?, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIProject, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.Role?, string, global::Dataloop.APIMembershipRole?>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>(),
                    new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.ServiceMetadataUser, global::Dataloop.Dictionary>(),
                    new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.ServiceMetadataSystem, global::Dataloop.SystemRefs, global::Dataloop.Dictionary>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>(),
                    new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.ServiceContext>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ICompositionError, string>(),
                    new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.ExecutionContext>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.IExternalMonitoringConfig, global::Dataloop.IHpaControllerConfig, global::Dataloop.Dictionary, global::Dataloop.IStorageDriverConfig>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIComposition>, global::System.Collections.Generic.IList<global::Dataloop.APIPipeline>, global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.IList<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.IList<global::Dataloop.APIDpk>, global::System.Collections.Generic.IList<global::Dataloop.APIApp>, global::System.Collections.Generic.IList<global::Dataloop.APICompute>, global::System.Collections.Generic.IList<global::Dataloop.APIServiceDriver>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PlatformEntityType?, global::Dataloop.SettingScopeType?>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::Dataloop.SettingScopeId?>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.SettingScopeRole?>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PlatformEntityType?, global::Dataloop.PartialSettingScopeType?>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::Dataloop.PartialSettingScopeId?>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.PartialSettingScopeRole?>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUserSetting, global::Dataloop.APIFeatureFlag>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::Dataloop.AzureWebhookEventOperationRequestSource?>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.PartialICompute, global::Dataloop.UpdateComputeRequest2>(),
                    new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.DQLResourceQuery, global::Dataloop.AnyOf<global::Dataloop.FilterQuery, global::Dataloop.UpdateQuery, global::Dataloop.DeleteQuery>?>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.FilterQuery, global::Dataloop.UpdateQuery, global::Dataloop.DeleteQuery>(),
                    new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.MoveItemsRequest, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAnnotationRequest, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationRequest>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.ImportItemRequest>, global::Dataloop.ImportItemsToDatasetRequest>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.FeatureSet, global::System.Collections.Generic.IList<global::Dataloop.FeatureSet>>(),
                    new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.FeatureVector, global::System.Collections.Generic.IList<global::Dataloop.FeatureVector>>(),
                    new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAnnotationRequest, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationRequest>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.MetricRequest, global::System.Collections.Generic.IList<global::Dataloop.MetricRequest>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PartialCreateModelRequest, global::Dataloop.APICopyEnvironmentSpec>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.CreateOntologyPayloadV2, global::Dataloop.CreateOntologyPayload>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.RecipeV2Input?, global::Dataloop.RecipeInput?>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PartialRecipePayloadV2, global::Dataloop.PartialRecipePayload>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ResolverPayload, global::Dataloop.IUserContext>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PatchFeatureFlagRequest, global::Dataloop.PatchUserSettingRequest>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITask, global::Dataloop.APICommand>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<object, global::Dataloop.APICommand>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITask, global::Dataloop.APICommand>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::Dataloop.APITask>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIApp, object>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::Dataloop.APIAssignment>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::Dataloop.APIAssignment>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, object>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAnnotation, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotation>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.Dataset, global::Dataloop.APIDatasetSchema>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::Dataloop.Dataset>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIExecution, global::Dataloop.PiperSettingsCommands>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIExecution, global::Dataloop.APICommand>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAnnotation, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotation>>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIModel, global::Dataloop.APICommand>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIModel, global::Dataloop.APICommand>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.GetAvailableIntegrationsResponseItemVariant1, global::Dataloop.GetAvailableIntegrationsResponseItemVariant2>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIPipelineState, global::Dataloop.APICommand>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIMembership>, object>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.ClientContributor>, object>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIService, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIService, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIService, string>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITask, global::Dataloop.APICommand>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<object, global::Dataloop.APICommand>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITask, global::Dataloop.APICommand>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::Dataloop.APITask>(),
                    new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, object>(),
                    new global::Dataloop.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public APIKeysClient APIKeys => new APIKeysClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AccountsClient Accounts => new AccountsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ActivitiesClient Activities => new ActivitiesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnnotationLogsClient AnnotationLogs => new AnnotationLogsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnnotationTasksClient AnnotationTasks => new AnnotationTasksClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsClient Annotations => new AnnotationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AppsClient Apps => new AppsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AssignmentsClient Assignments => new AssignmentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AuditClient Audit => new AuditClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BillingClient Billing => new BillingClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CompositionsClient Compositions => new CompositionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ComputeClient Compute => new ComputeClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetItemAnnotationsClient DatasetItemAnnotations => new DatasetItemAnnotationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetItemsClient DatasetItems => new DatasetItemsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetStorageClient DatasetStorage => new DatasetStorageClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DpkClient Dpk => new DpkClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ExecutionsClient Executions => new ExecutionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FeatureSetsClient FeatureSets => new FeatureSetsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FeatureVectorsClient FeatureVectors => new FeatureVectorsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public GroupsClient Groups => new GroupsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public GuestsClient Guests => new GuestsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public InstanceCatalogClient InstanceCatalog => new InstanceCatalogClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public IntegrationsClient Integrations => new IntegrationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public InvoicesClient Invoices => new InvoicesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ItemAnnotationsClient ItemAnnotations => new ItemAnnotationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ItemsClient Items => new ItemsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LabelsClient Labels => new LabelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelMetricsClient ModelMetrics => new ModelMetricsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OntologiesClient Ontologies => new OntologiesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OrgIntegrationsClient OrgIntegrations => new OrgIntegrationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OrganizationsClient Organizations => new OrganizationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PackagesClient Packages => new PackagesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PipelinesClient Pipelines => new PipelinesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PipelinesQueryClient PipelinesQuery => new PipelinesQueryClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PipelinesTemplatesClient PipelinesTemplates => new PipelinesTemplatesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PiperMiscClient PiperMisc => new PiperMiscClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PlansClient Plans => new PlansClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects => new ProjectsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public QueryClient Query => new QueryClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RecipesClient Recipes => new RecipesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ScoresClient Scores => new ScoresClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ServiceDriversClient ServiceDrivers => new ServiceDriversClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ServicesClient Services => new ServicesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ServicesMetricClient ServicesMetric => new ServicesMetricClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SettingsClient Settings => new SettingsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StorageDriversClient StorageDrivers => new StorageDriversClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StructuresClient Structures => new StructuresClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionsClient Subscriptions => new SubscriptionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TasksClient Tasks => new TasksClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TriggerResourceInformationClient TriggerResourceInformation => new TriggerResourceInformationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TriggersClient Triggers => new TriggersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsageClient Usage => new UsageClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users => new UsersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VersionClient Version => new VersionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WebHooksClient WebHooks => new WebHooksClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the DataloopClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public DataloopClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Dataloop.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Dataloop.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}