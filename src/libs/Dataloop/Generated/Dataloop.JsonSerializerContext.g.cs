
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.S3IntegrationConfig, global::Dataloop.GcsIntegrationConfig, global::Dataloop.AzureBlobIntegrationConfig, global::Dataloop.PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath>?), TypeInfoPropertyName = "PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath_9a6ecea9b7debc31")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIComposition>, global::System.Collections.Generic.IList<global::Dataloop.APIPipeline>, global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.IList<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.IList<global::Dataloop.APIDpk>, global::System.Collections.Generic.IList<global::Dataloop.APIApp>, global::System.Collections.Generic.IList<global::Dataloop.APICompute>, global::System.Collections.Generic.IList<global::Dataloop.APIServiceDriver>>?), TypeInfoPropertyName = "APIServiceDriver_c0617c242689fb32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIComposition>, global::System.Collections.Generic.List<global::Dataloop.APIPipeline>, global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.List<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.List<global::Dataloop.APIDpk>, global::System.Collections.Generic.List<global::Dataloop.APIApp>, global::System.Collections.Generic.List<global::Dataloop.APICompute>, global::System.Collections.Generic.List<global::Dataloop.APIServiceDriver>>), TypeInfoPropertyName = "APIServiceDriver_ce74abc722e1be30")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
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
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.S3IntegrationConfig, global::Dataloop.GcsIntegrationConfig, global::Dataloop.AzureBlobIntegrationConfig, global::Dataloop.PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath>?), TypeInfoPropertyName = "PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath_9a6ecea9b7debc31")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIComposition>, global::System.Collections.Generic.IList<global::Dataloop.APIPipeline>, global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.IList<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.IList<global::Dataloop.APIDpk>, global::System.Collections.Generic.IList<global::Dataloop.APIApp>, global::System.Collections.Generic.IList<global::Dataloop.APICompute>, global::System.Collections.Generic.IList<global::Dataloop.APIServiceDriver>>?), TypeInfoPropertyName = "APIServiceDriver_c0617c242689fb32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIComposition>, global::System.Collections.Generic.List<global::Dataloop.APIPipeline>, global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.List<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.List<global::Dataloop.APIDpk>, global::System.Collections.Generic.List<global::Dataloop.APIApp>, global::System.Collections.Generic.List<global::Dataloop.APICompute>, global::System.Collections.Generic.List<global::Dataloop.APIServiceDriver>>), TypeInfoPropertyName = "APIServiceDriver_ce74abc722e1be30")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IS3ApiMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IntegrationTypeMetadata), TypeInfoPropertyName = "IntegrationTypeMetadata2")]
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
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.S3IntegrationConfig, global::Dataloop.GcsIntegrationConfig, global::Dataloop.AzureBlobIntegrationConfig, global::Dataloop.PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath>?), TypeInfoPropertyName = "PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath_9a6ecea9b7debc31")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIComposition>, global::System.Collections.Generic.IList<global::Dataloop.APIPipeline>, global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.IList<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.IList<global::Dataloop.APIDpk>, global::System.Collections.Generic.IList<global::Dataloop.APIApp>, global::System.Collections.Generic.IList<global::Dataloop.APICompute>, global::System.Collections.Generic.IList<global::Dataloop.APIServiceDriver>>?), TypeInfoPropertyName = "APIServiceDriver_c0617c242689fb32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIComposition>, global::System.Collections.Generic.List<global::Dataloop.APIPipeline>, global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.List<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.List<global::Dataloop.APIDpk>, global::System.Collections.Generic.List<global::Dataloop.APIApp>, global::System.Collections.Generic.List<global::Dataloop.APICompute>, global::System.Collections.Generic.List<global::Dataloop.APIServiceDriver>>), TypeInfoPropertyName = "APIServiceDriver_ce74abc722e1be30")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AzureWebhookEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AzureWebhookEventAction), TypeInfoPropertyName = "AzureWebhookEventAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::Dataloop.AzureWebhookEventOperationRequestSource?>), TypeInfoPropertyName = "AnyOfStringAzureWebhookEventOperationRequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AzureWebhookEventOperationRequestSource), TypeInfoPropertyName = "AzureWebhookEventOperationRequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AzureWebhookEventSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AzureWebhookEventSubscriptionTerm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AzureWebhookEventSubscriptionPurchaser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AzureWebhookEventSubscriptionBeneficiary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UsageLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResourceUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.UsageLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UsageReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ResourceUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UsageResourcesReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.BillingResourceKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EditSubscriptionInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RenewSubscriptionInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPISubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APISubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BillingScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CustomSubscriptionInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SubscriptionUpgradeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SubscriptionExtensionInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PaymentDriverTypes), TypeInfoPropertyName = "PaymentDriverTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RangeOrFeatureTier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RangeOrFeatureTierRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OverQuota))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIBillableResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.RangeOrFeatureTier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SubscriptionInput))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ContactAddress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Address))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaxType), TypeInfoPropertyName = "TaxType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaxData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DBBillingAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialBillingAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialBillingAccountTaxData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PaymentDriverType), TypeInfoPropertyName = "PaymentDriverType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DBPaymentDriverConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DBPaymentDriverConfigurationType), TypeInfoPropertyName = "DBPaymentDriverConfigurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreditCard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PaymentMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResourceAuditEventType), TypeInfoPropertyName = "ResourceAuditEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResourceAuditLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResourceAuditLogCtx))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AuditLogsCursorPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ResourceAuditLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AlertStatus), TypeInfoPropertyName = "AlertStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAlert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FieldSort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FieldSortField), TypeInfoPropertyName = "FieldSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FieldSortDirection), TypeInfoPropertyName = "FieldSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.MongoStorageDatasetDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.MongoStorageDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.MongoStorageDatasetDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.MongoAPIUsageEntry))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateOrgBotRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemSpecType?), TypeInfoPropertyName = "NullableItemSpecType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RefType?), TypeInfoPropertyName = "NullableRefType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModalityType?), TypeInfoPropertyName = "NullableModalityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetFileItemType?), TypeInfoPropertyName = "NullableAPIDatasetFileItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<bool?, global::Dataloop.APIDatasetFileItemAnnotated?>?), TypeInfoPropertyName = "NullableAnyOfBooleanAPIDatasetFileItemAnnotated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetFileItemAnnotated?), TypeInfoPropertyName = "NullableAPIDatasetFileItemAnnotated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetDirectoryItemType?), TypeInfoPropertyName = "NullableAPIDatasetDirectoryItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::Dataloop.APIDatasetDirectoryItemExportZip>?), TypeInfoPropertyName = "NullableAnyOfStringAPIDatasetDirectoryItemExportZip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIDatasetFileItem>, global::System.Collections.Generic.IList<global::Dataloop.APIDatasetDirectoryItem>>?), TypeInfoPropertyName = "NullableAnyOfIListAPIDatasetFileItemIListAPIDatasetDirectoryItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetIndexDrivers?), TypeInfoPropertyName = "NullableDatasetIndexDrivers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemRefOperation?), TypeInfoPropertyName = "NullableItemRefOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResource?), TypeInfoPropertyName = "NullableQueryResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReferenceQueryOperation?), TypeInfoPropertyName = "NullableReferenceQueryOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngine?), TypeInfoPropertyName = "NullablePickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OrderBy?), TypeInfoPropertyName = "NullableOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.OrderBy?, global::Dataloop.SortQuery>?), TypeInfoPropertyName = "NullableAnyOfOrderBySortQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DQLResourceQueryQueryEngine?), TypeInfoPropertyName = "NullableDQLResourceQueryQueryEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AddItemMode?), TypeInfoPropertyName = "NullableAddItemMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.ResourceReferenceMetadata, global::Dataloop.PartialAny>?), TypeInfoPropertyName = "NullableAllOfResourceReferenceMetadataPartialAny2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SystemDatasetType?), TypeInfoPropertyName = "NullableSystemDatasetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnnotationType?), TypeInfoPropertyName = "NullableAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RefAnnotationsRefType?), TypeInfoPropertyName = "NullableRefAnnotationsRefType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IRefImageAnnotationsType?), TypeInfoPropertyName = "NullableIRefImageAnnotationsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAnnotationCoordinateTypes?), TypeInfoPropertyName = "NullableAPIAnnotationCoordinateTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RequestSource?), TypeInfoPropertyName = "NullableRequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<bool?, global::Dataloop.S2SetupOptions>?), TypeInfoPropertyName = "NullableAnyOfBooleanS2SetupOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<bool?, global::Dataloop.APIAnnotationEventDeleted?>?), TypeInfoPropertyName = "NullableAnyOfBooleanAPIAnnotationEventDeleted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAnnotationEventDeleted?), TypeInfoPropertyName = "NullableAPIAnnotationEventDeleted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IndexDriver?), TypeInfoPropertyName = "NullableIndexDriver2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetAccessLevel?), TypeInfoPropertyName = "NullableAPIDatasetAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetScope?), TypeInfoPropertyName = "NullableDatasetScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<string, global::Dataloop.SystemDatasetType?>?), TypeInfoPropertyName = "NullableAllOfStringSystemDatasetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateDatasetRequestDriver?), TypeInfoPropertyName = "NullableCreateDatasetRequestDriver2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateDatasetRequestAccessLevel?), TypeInfoPropertyName = "NullableCreateDatasetRequestAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DQLQueryQueryEngine?), TypeInfoPropertyName = "NullableDQLQueryQueryEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExportType?), TypeInfoPropertyName = "NullableExportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExportDatasetOptionsExportVersion?), TypeInfoPropertyName = "NullableExportDatasetOptionsExportVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExportStatus?), TypeInfoPropertyName = "NullableExportStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExportErrorType?), TypeInfoPropertyName = "NullableExportErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIAnnotation, global::Dataloop.APIDataset, global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>?), TypeInfoPropertyName = "NullableAnyOfAPIAnnotationAPIDatasetAPIDatasetFileItemAPIDatasetDirectoryItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResourceItems?), TypeInfoPropertyName = "NullableQueryResourceItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResourceAnnotations?), TypeInfoPropertyName = "NullableQueryResourceAnnotations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResourceDatasets?), TypeInfoPropertyName = "NullableQueryResourceDatasets2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?>?), TypeInfoPropertyName = "NullableAnyOfQueryResourceItemsQueryResourceAnnotationsQueryResourceDatasets2")]
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.S3IntegrationConfig, global::Dataloop.GcsIntegrationConfig, global::Dataloop.AzureBlobIntegrationConfig, global::Dataloop.PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath>?), TypeInfoPropertyName = "PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath_9a6ecea9b7debc31")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIComposition>, global::System.Collections.Generic.IList<global::Dataloop.APIPipeline>, global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.IList<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.IList<global::Dataloop.APIDpk>, global::System.Collections.Generic.IList<global::Dataloop.APIApp>, global::System.Collections.Generic.IList<global::Dataloop.APICompute>, global::System.Collections.Generic.IList<global::Dataloop.APIServiceDriver>>?), TypeInfoPropertyName = "APIServiceDriver_c0617c242689fb32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIComposition>, global::System.Collections.Generic.List<global::Dataloop.APIPipeline>, global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.List<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.List<global::Dataloop.APIDpk>, global::System.Collections.Generic.List<global::Dataloop.APIApp>, global::System.Collections.Generic.List<global::Dataloop.APICompute>, global::System.Collections.Generic.List<global::Dataloop.APIServiceDriver>>), TypeInfoPropertyName = "APIServiceDriver_ce74abc722e1be30")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllowedTypes?), TypeInfoPropertyName = "NullableAllowedTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UnsearchableSchemaReasons?), TypeInfoPropertyName = "NullableUnsearchableSchemaReasons2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SchemaMode?), TypeInfoPropertyName = "NullableSchemaMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.ItemContext>?), TypeInfoPropertyName = "NullableAllOfContextItemContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetItemType?), TypeInfoPropertyName = "NullableDatasetItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.MasterItemSpec, global::Dataloop.ClonedItemSpec>?), TypeInfoPropertyName = "NullableAnyOfMasterItemSpecClonedItemSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnnotationTypeBox?), TypeInfoPropertyName = "NullableAnnotationTypeBox2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnnotationTypeClass?), TypeInfoPropertyName = "NullableAnnotationTypeClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnnotationTypeBinary?), TypeInfoPropertyName = "NullableAnnotationTypeBinary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.AnnotationTypeBox?, global::Dataloop.AnnotationTypeClass?, global::Dataloop.AnnotationTypeBinary?>?), TypeInfoPropertyName = "NullableAnyOfAnnotationTypeBoxAnnotationTypeClassAnnotationTypeBinary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GenerationStrategyType?), TypeInfoPropertyName = "NullableGenerationStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GeneratedDatasetTypes?), TypeInfoPropertyName = "NullableGeneratedDatasetTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OneByOneLatencyBenchmarkModeType?), TypeInfoPropertyName = "NullableOneByOneLatencyBenchmarkModeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ProfilingBenchmarkModeType?), TypeInfoPropertyName = "NullableProfilingBenchmarkModeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ConcurrencyBenchmarkModeType?), TypeInfoPropertyName = "NullableConcurrencyBenchmarkModeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BenchmarkMode?), TypeInfoPropertyName = "NullableBenchmarkMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryTestCases?), TypeInfoPropertyName = "NullableQueryTestCases2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IndexingStrategyType?), TypeInfoPropertyName = "NullableIndexingStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InferDatasetSchemaMode?), TypeInfoPropertyName = "NullableInferDatasetSchemaMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.FeatureFlagsSetContextVariant1, global::Dataloop.FeatureFlagsSetContextVariant2>?), TypeInfoPropertyName = "NullableAnyOfFeatureFlagsSetContextVariant1FeatureFlagsSetContextVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FeatureFlagsSetContextVariant1Type?), TypeInfoPropertyName = "NullableFeatureFlagsSetContextVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FeatureFlagsSetContextVariant2Type?), TypeInfoPropertyName = "NullableFeatureFlagsSetContextVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.DatasetContext>?), TypeInfoPropertyName = "NullableAllOfContextDatasetContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetAccessLevel?), TypeInfoPropertyName = "NullableDatasetAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetSyncStatus?), TypeInfoPropertyName = "NullableDatasetSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SchemaEntryInput?), TypeInfoPropertyName = "NullableSchemaEntryInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>?), TypeInfoPropertyName = "NullableAnyOfSchemaEntryInputVariant2Variant1SchemaEntryInputVariant2Variant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverType?), TypeInfoPropertyName = "NullableDriverType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.DriverContext>?), TypeInfoPropertyName = "NullableAllOfContextDriverContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IntegrationType?), TypeInfoPropertyName = "NullableIntegrationType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>?), TypeInfoPropertyName = "NullableAnyOfEnvUserPasswordAuthenticationKeyFileAuthentication2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.S3DriverPayload, global::Dataloop.GcsDriverPayload, global::Dataloop.AzureBlobDriverPayload, global::Dataloop.PickFilesystemDriverConfigurationMountPath>?), TypeInfoPropertyName = "NullableAnyOfS3DriverPayloadGcsDriverPayloadAzureBlobDriverPayloadPickFilesystemDriverConfigurationMountPath2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.PartialS3DriverPayload, global::Dataloop.PartialGcsDriverPayload, global::Dataloop.PartialAzureBlobDriverPayload>?), TypeInfoPropertyName = "NullableAnyOfPartialS3DriverPayloadPartialGcsDriverPayloadPartialAzureBlobDriverPayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FeatureSetEntityType?), TypeInfoPropertyName = "NullableFeatureSetEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BenchmarkIngestionStrategyType?), TypeInfoPropertyName = "NullableBenchmarkIngestionStrategyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BenchmarkOptionsExportType?), TypeInfoPropertyName = "NullableBenchmarkOptionsExportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SetTaskRefsBenchmarkInputOperation?), TypeInfoPropertyName = "NullableSetTaskRefsBenchmarkInputOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverReadBenchmarkOperationInputScenarioDetails?), TypeInfoPropertyName = "NullableDriverReadBenchmarkOperationInputScenarioDetails2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverWriteBenchmarkOperationInputScenarioDetails?), TypeInfoPropertyName = "NullableDriverWriteBenchmarkOperationInputScenarioDetails2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AttributeType?), TypeInfoPropertyName = "NullableAttributeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>?), TypeInfoPropertyName = "NullableAnyOfAPIOntologyV2APIOntology2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.RecipeV2Context>?), TypeInfoPropertyName = "NullableAllOfContextRecipeV2Context2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecipeV2Input?), TypeInfoPropertyName = "NullableRecipeV2Input2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InstructionAction?), TypeInfoPropertyName = "NullableInstructionAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InstructionScope?), TypeInfoPropertyName = "NullableInstructionScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.ToolInstructionOptions, global::Dataloop.Dictionary>?), TypeInfoPropertyName = "NullableAllOfToolInstructionOptionsDictionary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CustomActionControls?), TypeInfoPropertyName = "NullableCustomActionControls2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.RecipeContext>?), TypeInfoPropertyName = "NullableAllOfContextRecipeContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecipeInput?), TypeInfoPropertyName = "NullableRecipeInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICustomActionControls?), TypeInfoPropertyName = "NullableAPICustomActionControls2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>?), TypeInfoPropertyName = "NullableAnyOfAPIRecipeV2APIRecipe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AssignmentStatus?), TypeInfoPropertyName = "NullableAssignmentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Dictionary, global::Dataloop.AssignmentMetadataSystem>?), TypeInfoPropertyName = "NullableAllOfDictionaryAssignmentMetadataSystem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AssignmentMetadataSystemType?), TypeInfoPropertyName = "NullableAssignmentMetadataSystemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskType?), TypeInfoPropertyName = "NullableTaskType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.AssignmentContext>?), TypeInfoPropertyName = "NullableAllOfContextAssignmentContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ScoreType?), TypeInfoPropertyName = "NullableScoreType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskStatus?), TypeInfoPropertyName = "NullableTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>?), TypeInfoPropertyName = "NullableAnyOfAPITaskSpecAPISpawnTaskSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QualityTaskTypes?), TypeInfoPropertyName = "NullableQualityTaskTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InstructionsDocumentMode?), TypeInfoPropertyName = "NullableInstructionsDocumentMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Dictionary, global::Dataloop.TaskMetadataSystem>?), TypeInfoPropertyName = "NullableAllOfDictionaryTaskMetadataSystem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskContributorsAction?), TypeInfoPropertyName = "NullableTaskContributorsAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIOrg, string>?), TypeInfoPropertyName = "NullableAnyOfAPIOrgString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Role?), TypeInfoPropertyName = "NullableRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIUser>, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfIListAPIUserIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIGroup>, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfIListAPIGroupIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIUser, string>?), TypeInfoPropertyName = "NullableAnyOfAPIUserString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIAccount, string>?), TypeInfoPropertyName = "NullableAnyOfAPIAccountString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OrgPlans?), TypeInfoPropertyName = "NullableOrgPlans2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIIntegration>, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfIListAPIIntegrationIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIProject>, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfIListAPIProjectIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIProjectGuest>, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfIListAPIProjectGuestIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIProject, string>?), TypeInfoPropertyName = "NullableAnyOfAPIProjectString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIIntegration, string>?), TypeInfoPropertyName = "NullableAnyOfAPIIntegrationString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AlertTier?), TypeInfoPropertyName = "NullableAlertTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OrgRole?), TypeInfoPropertyName = "NullableOrgRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.Role?, global::Dataloop.OrgRole?>?), TypeInfoPropertyName = "NullableAnyOfRoleOrgRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DLEntityType?), TypeInfoPropertyName = "NullableDLEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OrgSize?), TypeInfoPropertyName = "NullableOrgSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OrgIndustry?), TypeInfoPropertyName = "NullableOrgIndustry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.OrgRole?, string>?), TypeInfoPropertyName = "NullableAnyOfOrgRoleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IntegrationType2?), TypeInfoPropertyName = "NullableIntegrationType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IntegrationTypeMetadata?), TypeInfoPropertyName = "NullableIntegrationTypeMetadata2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BillingResourceKey?), TypeInfoPropertyName = "NullableBillingResourceKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.MetricGroup?), TypeInfoPropertyName = "NullableMetricGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BillingPeriod?), TypeInfoPropertyName = "NullableBillingPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BillingStatus?), TypeInfoPropertyName = "NullableBillingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ScopeType?), TypeInfoPropertyName = "NullableScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GuestType?), TypeInfoPropertyName = "NullableGuestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.GuestType?, string>?), TypeInfoPropertyName = "NullableAnyOfGuestTypeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.Role?, string, global::Dataloop.APIMembershipRole?>?), TypeInfoPropertyName = "NullableAnyOfRoleStringAPIMembershipRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIMembershipRole?), TypeInfoPropertyName = "NullableAPIMembershipRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UserInterestType?), TypeInfoPropertyName = "NullableUserInterestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ApiKeyType?), TypeInfoPropertyName = "NullableApiKeyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LoginsLogQueryOrder?), TypeInfoPropertyName = "NullableLoginsLogQueryOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LoginsLogQueryOrderBy?), TypeInfoPropertyName = "NullableLoginsLogQueryOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EntityScopeLevel?), TypeInfoPropertyName = "NullableEntityScopeLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelStatus?), TypeInfoPropertyName = "NullableModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<double?, string>?), TypeInfoPropertyName = "NullableAnyOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelInputType?), TypeInfoPropertyName = "NullableModelInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOutputType?), TypeInfoPropertyName = "NullableModelOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOutputTypeVariant2?), TypeInfoPropertyName = "NullableModelOutputTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOutputTypeVariant4?), TypeInfoPropertyName = "NullableModelOutputTypeVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ArtifactType?), TypeInfoPropertyName = "NullableArtifactType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReferenceType?), TypeInfoPropertyName = "NullableReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.NodeMlType?), TypeInfoPropertyName = "NullableNodeMlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>?), TypeInfoPropertyName = "NullableAnyOfItemArtifactLocalArtifact2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOperationTypes?), TypeInfoPropertyName = "NullableModelOperationTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionStatus?), TypeInfoPropertyName = "NullableExecutionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionStatusName?), TypeInfoPropertyName = "NullableExecutionStatusName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EventResourceType?), TypeInfoPropertyName = "NullableEventResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResourceType?), TypeInfoPropertyName = "NullableResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDate?), TypeInfoPropertyName = "NullableIDate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionMode?), TypeInfoPropertyName = "NullableExecutionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionPhase?), TypeInfoPropertyName = "NullableExecutionPhase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OnResetAction?), TypeInfoPropertyName = "NullableOnResetAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.MetricData?), TypeInfoPropertyName = "NullableMetricData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateWebHookDTOHttpMethod?), TypeInfoPropertyName = "NullableCreateWebHookDTOHttpMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateWebHookDTOHttpMethod?), TypeInfoPropertyName = "NullableUpdateWebHookDTOHttpMethod2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ECacheMode?), TypeInfoPropertyName = "NullableECacheMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaaSCacheSize?), TypeInfoPropertyName = "NullableFaaSCacheSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaaSCacheType?), TypeInfoPropertyName = "NullableFaaSCacheType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceLogLevel?), TypeInfoPropertyName = "NullableServiceLogLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LogsListDirection?), TypeInfoPropertyName = "NullableLogsListDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReplicaStatus?), TypeInfoPropertyName = "NullableReplicaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReplicaReason?), TypeInfoPropertyName = "NullableReplicaReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EDebugOptionsStatus?), TypeInfoPropertyName = "NullableEDebugOptionsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReportType?), TypeInfoPropertyName = "NullableReportType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CycleRerunMethod?), TypeInfoPropertyName = "NullableCycleRerunMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PipelineType?), TypeInfoPropertyName = "NullablePipelineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageType?), TypeInfoPropertyName = "NullablePackageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.JobStatusEnum?), TypeInfoPropertyName = "NullableJobStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionsOrderByType?), TypeInfoPropertyName = "NullableExecutionsOrderByType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionsOrderByDirection?), TypeInfoPropertyName = "NullableExecutionsOrderByDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CommandStatus?), TypeInfoPropertyName = "NullableCommandStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CommandsDomain?), TypeInfoPropertyName = "NullableCommandsDomain2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingsValueTypes?), TypeInfoPropertyName = "NullableSettingsValueTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PlatformEntityType?), TypeInfoPropertyName = "NullablePlatformEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.PlatformEntityType?, global::Dataloop.SettingScopeType?>?), TypeInfoPropertyName = "NullableAnyOfPlatformEntityTypeSettingScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingScopeType?), TypeInfoPropertyName = "NullableSettingScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::Dataloop.SettingScopeId?>?), TypeInfoPropertyName = "NullableAnyOfStringSettingScopeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingScopeId?), TypeInfoPropertyName = "NullableSettingScopeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.SettingScopeRole?>?), TypeInfoPropertyName = "NullableAnyOfRoleOrgRoleSettingScopeRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingScopeRole?), TypeInfoPropertyName = "NullableSettingScopeRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingsTypes?), TypeInfoPropertyName = "NullableSettingsTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingsSectionNames?), TypeInfoPropertyName = "NullableSettingsSectionNames2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.PlatformEntityType?, global::Dataloop.PartialSettingScopeType?>?), TypeInfoPropertyName = "NullableAnyOfPlatformEntityTypePartialSettingScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialSettingScopeType?), TypeInfoPropertyName = "NullablePartialSettingScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::Dataloop.PartialSettingScopeId?>?), TypeInfoPropertyName = "NullableAnyOfStringPartialSettingScopeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialSettingScopeId?), TypeInfoPropertyName = "NullablePartialSettingScopeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.PartialSettingScopeRole?>?), TypeInfoPropertyName = "NullableAnyOfRoleOrgRolePartialSettingScopeRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialSettingScopeRole?), TypeInfoPropertyName = "NullablePartialSettingScopeRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIUserSetting, global::Dataloop.APIFeatureFlag>?), TypeInfoPropertyName = "NullableAnyOfAPIUserSettingAPIFeatureFlag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.MigrationSpec?), TypeInfoPropertyName = "NullableMigrationSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RemoveSettingTraceMigrationSpec?), TypeInfoPropertyName = "NullableRemoveSettingTraceMigrationSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AzureWebhookEventAction?), TypeInfoPropertyName = "NullableAzureWebhookEventAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::Dataloop.AzureWebhookEventOperationRequestSource?>?), TypeInfoPropertyName = "NullableAnyOfStringAzureWebhookEventOperationRequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AzureWebhookEventOperationRequestSource?), TypeInfoPropertyName = "NullableAzureWebhookEventOperationRequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PaymentDriverTypes?), TypeInfoPropertyName = "NullablePaymentDriverTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PodType?), TypeInfoPropertyName = "NullablePodType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InvoiceStatus?), TypeInfoPropertyName = "NullableInvoiceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Currency?), TypeInfoPropertyName = "NullableCurrency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaxType?), TypeInfoPropertyName = "NullableTaxType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PaymentDriverType?), TypeInfoPropertyName = "NullablePaymentDriverType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DBPaymentDriverConfigurationType?), TypeInfoPropertyName = "NullableDBPaymentDriverConfigurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResourceAuditEventType?), TypeInfoPropertyName = "NullableResourceAuditEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AlertStatus?), TypeInfoPropertyName = "NullableAlertStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FieldSortField?), TypeInfoPropertyName = "NullableFieldSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FieldSortDirection?), TypeInfoPropertyName = "NullableFieldSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.PartialICompute, global::Dataloop.UpdateComputeRequest2>?), TypeInfoPropertyName = "NullableAllOfPartialIComputeUpdateComputeRequest22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ListExportHistoryRequestSortOrder?), TypeInfoPropertyName = "NullableListExportHistoryRequestSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ListExportHistoryRequestSortBy?), TypeInfoPropertyName = "NullableListExportHistoryRequestSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.DQLResourceQuery, global::Dataloop.AnyOf<global::Dataloop.FilterQuery, global::Dataloop.UpdateQuery, global::Dataloop.DeleteQuery>?>?), TypeInfoPropertyName = "NullableAllOfDQLResourceQueryAnyOfFilterQueryUpdateQueryDeleteQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.FilterQuery, global::Dataloop.UpdateQuery, global::Dataloop.DeleteQuery>?), TypeInfoPropertyName = "NullableAnyOfFilterQueryUpdateQueryDeleteQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryDatasetsRequestTarget?), TypeInfoPropertyName = "NullableQueryDatasetsRequestTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>?), TypeInfoPropertyName = "NullableAllOfDQLResourceQueryFilterQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.MoveItemsRequest, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfMoveItemsRequestIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIAnnotationRequest, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationRequest>>?), TypeInfoPropertyName = "NullableAnyOfAPIAnnotationRequestIListAPIAnnotationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.ImportItemRequest>, global::Dataloop.ImportItemsToDatasetRequest>?), TypeInfoPropertyName = "NullableAnyOfIListImportItemRequestImportItemsToDatasetRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.FeatureSet, global::System.Collections.Generic.IList<global::Dataloop.FeatureSet>>?), TypeInfoPropertyName = "NullableAnyOfFeatureSetIListFeatureSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.FeatureVector, global::System.Collections.Generic.IList<global::Dataloop.FeatureVector>>?), TypeInfoPropertyName = "NullableAnyOfFeatureVectorIListFeatureVector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.MetricRequest, global::System.Collections.Generic.IList<global::Dataloop.MetricRequest>>?), TypeInfoPropertyName = "NullableAnyOfMetricRequestIListMetricRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.PartialCreateModelRequest, global::Dataloop.APICopyEnvironmentSpec>?), TypeInfoPropertyName = "NullableAnyOfPartialCreateModelRequestAPICopyEnvironmentSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.CreateOntologyPayloadV2, global::Dataloop.CreateOntologyPayload>?), TypeInfoPropertyName = "NullableAnyOfCreateOntologyPayloadV2CreateOntologyPayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.RecipeV2Input?, global::Dataloop.RecipeInput?>?), TypeInfoPropertyName = "NullableAnyOfRecipeV2InputRecipeInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.PartialRecipePayloadV2, global::Dataloop.PartialRecipePayload>?), TypeInfoPropertyName = "NullableAnyOfPartialRecipePayloadV2PartialRecipePayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.ResolverPayload, global::Dataloop.IUserContext>?), TypeInfoPropertyName = "NullableAnyOfResolverPayloadIUserContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.PatchFeatureFlagRequest, global::Dataloop.PatchUserSettingRequest>?), TypeInfoPropertyName = "NullableAnyOfPatchFeatureFlagRequestPatchUserSettingRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>?), TypeInfoPropertyName = "NullableAnyOfAPITaskAPICommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<object, global::Dataloop.APICommand>?), TypeInfoPropertyName = "NullableAnyOfObjectAPICommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.APITask>?), TypeInfoPropertyName = "NullableAnyOfAPICommandAPITask2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIApp, object>?), TypeInfoPropertyName = "NullableAnyOfAPIAppObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>?), TypeInfoPropertyName = "NullableAnyOfAPICommandIListAPIAssignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.APIAssignment>?), TypeInfoPropertyName = "NullableAnyOfAPICommandAPIAssignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, object>?), TypeInfoPropertyName = "NullableAnyOfAPICommandObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>?), TypeInfoPropertyName = "NullableAnyOfAPIDatasetFileItemAPIDatasetDirectoryItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIAnnotation, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotation>>?), TypeInfoPropertyName = "NullableAnyOfAPIAnnotationIListAPIAnnotation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.Dataset, global::Dataloop.APIDatasetSchema>?), TypeInfoPropertyName = "NullableAnyOfDatasetAPIDatasetSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, string>?), TypeInfoPropertyName = "NullableAnyOfAPICommandString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.Dataset>?), TypeInfoPropertyName = "NullableAnyOfAPICommandDataset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIExecution, global::Dataloop.PiperSettingsCommands>?), TypeInfoPropertyName = "NullableAnyOfAPIExecutionPiperSettingsCommands2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIExecution, global::Dataloop.APICommand>?), TypeInfoPropertyName = "NullableAnyOfAPIExecutionAPICommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIModel, global::Dataloop.APICommand>?), TypeInfoPropertyName = "NullableAnyOfAPIModelAPICommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.GetAvailableIntegrationsResponseItemVariant1, global::Dataloop.GetAvailableIntegrationsResponseItemVariant2>?), TypeInfoPropertyName = "NullableAnyOfGetAvailableIntegrationsResponseItemVariant1GetAvailableIntegrationsResponseItemVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.APICommand>?), TypeInfoPropertyName = "NullableAnyOfAPIPipelineStateAPICommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIMembership>, object>?), TypeInfoPropertyName = "NullableAnyOfIListAPIMembershipObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.ClientContributor>, object>?), TypeInfoPropertyName = "NullableAnyOfIListClientContributorObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIService, string>?), TypeInfoPropertyName = "NullableAnyOfAPIServiceString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>?), TypeInfoPropertyName = "NullableAnyOfAPIFeatureFlagAPIUserSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIUser, object>?), TypeInfoPropertyName = "NullableAnyOfAPIUserObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PipelineVersionListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.Module>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.UiHook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PiperUiSlot>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIPackage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.CommandError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.CommandStatusHistoryEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DpkAttributeValueDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PreviewsComponentsPatchPipelineTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIUserSetting, global::Dataloop.APIFeatureFlag>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.UsageLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ResourceUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.BillingResourceKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APISubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.RangeOrFeatureTier>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.StorageDatasetDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.FaasUsageServiceInstanceDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.FaasGlobalServiceDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ContactInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.LineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PaymentDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ResourceAuditLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.MongoStorageDatasetDescriptor>))]
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
    internal sealed partial class SourceGenerationContextChunk3 : global::System.Text.Json.Serialization.JsonSerializerContext
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.S3IntegrationConfig, global::Dataloop.GcsIntegrationConfig, global::Dataloop.AzureBlobIntegrationConfig, global::Dataloop.PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath>?), TypeInfoPropertyName = "PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath_9a6ecea9b7debc31")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIComposition>, global::System.Collections.Generic.IList<global::Dataloop.APIPipeline>, global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.IList<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.IList<global::Dataloop.APIDpk>, global::System.Collections.Generic.IList<global::Dataloop.APIApp>, global::System.Collections.Generic.IList<global::Dataloop.APICompute>, global::System.Collections.Generic.IList<global::Dataloop.APIServiceDriver>>?), TypeInfoPropertyName = "APIServiceDriver_c0617c242689fb32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIComposition>, global::System.Collections.Generic.List<global::Dataloop.APIPipeline>, global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>, global::System.Collections.Generic.List<global::Dataloop.ResourceExecution>, global::System.Collections.Generic.List<global::Dataloop.APIDpk>, global::System.Collections.Generic.List<global::Dataloop.APIApp>, global::System.Collections.Generic.List<global::Dataloop.APICompute>, global::System.Collections.Generic.List<global::Dataloop.APIServiceDriver>>), TypeInfoPropertyName = "APIServiceDriver_ce74abc722e1be30")]
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
    internal sealed partial class SourceGenerationContextChunk4 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Dataloop.JsonConverters.IRefImageAnnotationsTypeJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.APIAnnotationCoordinateTypesJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.BenchmarkModeJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.SchemaEntryInputJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.RecipeV2InputJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.RecipeInputJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.IntegrationTypeMetadataJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.ModelOutputTypeJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.IDateJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.MetricDataJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.ComputeMetadataJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.IDpkComponentElementSpecJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.CustomInstallationJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.AppMetadataJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.ComputePluginSpecJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.MigrationSpecJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.RemoveSettingTraceMigrationSpecJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<bool?, global::Dataloop.APIDatasetFileItemAnnotated?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::Dataloop.APIDatasetDirectoryItemExportZip>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIDatasetFileItem>, global::System.Collections.Generic.IList<global::Dataloop.APIDatasetDirectoryItem>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.OrderBy?, global::Dataloop.SortQuery>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.ResourceReferenceMetadata, global::Dataloop.PartialAny>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<bool?, global::Dataloop.S2SetupOptions>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<bool?, global::Dataloop.APIAnnotationEventDeleted?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<string, global::Dataloop.SystemDatasetType?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAnnotation, global::Dataloop.APIDataset, global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.ItemContext>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.MasterItemSpec, global::Dataloop.ClonedItemSpec>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.AnnotationTypeBox?, global::Dataloop.AnnotationTypeClass?, global::Dataloop.AnnotationTypeBinary?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.FeatureFlagsSetContextVariant1, global::Dataloop.FeatureFlagsSetContextVariant2>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.DatasetContext>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.DriverContext>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.S3IntegrationConfig, global::Dataloop.GcsIntegrationConfig, global::Dataloop.AzureBlobIntegrationConfig, global::Dataloop.PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.S3DriverPayload, global::Dataloop.GcsDriverPayload, global::Dataloop.AzureBlobDriverPayload, global::Dataloop.PickFilesystemDriverConfigurationMountPath>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PartialS3DriverPayload, global::Dataloop.PartialGcsDriverPayload, global::Dataloop.PartialAzureBlobDriverPayload>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.RecipeV2Context>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.ToolInstructionOptions, global::Dataloop.Dictionary>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.RecipeContext>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Dictionary, global::Dataloop.AssignmentMetadataSystem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.AssignmentContext>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Dictionary, global::Dataloop.TaskMetadataSystem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIUser>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIGroup>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAccount, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIIntegration>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIUser>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIProject>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIUser>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIGroup>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAccount, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIProjectGuest>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIProject, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIIntegration, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.Role?, global::Dataloop.OrgRole?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.OrgRole?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.GuestType?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIProject, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.Role?, string, global::Dataloop.APIMembershipRole?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>());
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
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PlatformEntityType?, global::Dataloop.SettingScopeType?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::Dataloop.SettingScopeId?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.SettingScopeRole?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PlatformEntityType?, global::Dataloop.PartialSettingScopeType?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::Dataloop.PartialSettingScopeId?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.PartialSettingScopeRole?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUserSetting, global::Dataloop.APIFeatureFlag>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::Dataloop.AzureWebhookEventOperationRequestSource?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.PartialICompute, global::Dataloop.UpdateComputeRequest2>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.DQLResourceQuery, global::Dataloop.AnyOf<global::Dataloop.FilterQuery, global::Dataloop.UpdateQuery, global::Dataloop.DeleteQuery>?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.FilterQuery, global::Dataloop.UpdateQuery, global::Dataloop.DeleteQuery>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.MoveItemsRequest, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAnnotationRequest, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationRequest>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.ImportItemRequest>, global::Dataloop.ImportItemsToDatasetRequest>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.FeatureSet, global::System.Collections.Generic.IList<global::Dataloop.FeatureSet>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.FeatureVector, global::System.Collections.Generic.IList<global::Dataloop.FeatureVector>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAnnotationRequest, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationRequest>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.MetricRequest, global::System.Collections.Generic.IList<global::Dataloop.MetricRequest>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PartialCreateModelRequest, global::Dataloop.APICopyEnvironmentSpec>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.CreateOntologyPayloadV2, global::Dataloop.CreateOntologyPayload>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.RecipeV2Input?, global::Dataloop.RecipeInput?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PartialRecipePayloadV2, global::Dataloop.PartialRecipePayload>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ResolverPayload, global::Dataloop.IUserContext>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PatchFeatureFlagRequest, global::Dataloop.PatchUserSettingRequest>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITask, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<object, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITask, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::Dataloop.APITask>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIApp, object>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::Dataloop.APIAssignment>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::Dataloop.APIAssignment>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, object>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAnnotation, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotation>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.Dataset, global::Dataloop.APIDatasetSchema>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::Dataloop.Dataset>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIExecution, global::Dataloop.PiperSettingsCommands>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIExecution, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAnnotation, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotation>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIModel, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIModel, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.GetAvailableIntegrationsResponseItemVariant1, global::Dataloop.GetAvailableIntegrationsResponseItemVariant2>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIPipelineState, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIMembership>, object>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.ClientContributor>, object>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIService, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIService, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIService, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITask, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<object, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITask, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::Dataloop.APITask>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, object>());
            options.Converters.Add(new global::Dataloop.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Dataloop.ItemSpecType)

                    || typeToConvert == typeof(global::Dataloop.ItemSpecType?)

                    || typeToConvert == typeof(global::Dataloop.RefType)

                    || typeToConvert == typeof(global::Dataloop.RefType?)

                    || typeToConvert == typeof(global::Dataloop.ModalityType)

                    || typeToConvert == typeof(global::Dataloop.ModalityType?)

                    || typeToConvert == typeof(global::Dataloop.APIDatasetFileItemType)

                    || typeToConvert == typeof(global::Dataloop.APIDatasetFileItemType?)

                    || typeToConvert == typeof(global::Dataloop.APIDatasetFileItemAnnotated)

                    || typeToConvert == typeof(global::Dataloop.APIDatasetFileItemAnnotated?)

                    || typeToConvert == typeof(global::Dataloop.APIDatasetDirectoryItemType)

                    || typeToConvert == typeof(global::Dataloop.APIDatasetDirectoryItemType?)

                    || typeToConvert == typeof(global::Dataloop.DatasetIndexDrivers)

                    || typeToConvert == typeof(global::Dataloop.DatasetIndexDrivers?)

                    || typeToConvert == typeof(global::Dataloop.ItemRefOperation)

                    || typeToConvert == typeof(global::Dataloop.ItemRefOperation?)

                    || typeToConvert == typeof(global::Dataloop.QueryResource)

                    || typeToConvert == typeof(global::Dataloop.QueryResource?)

                    || typeToConvert == typeof(global::Dataloop.ReferenceQueryOperation)

                    || typeToConvert == typeof(global::Dataloop.ReferenceQueryOperation?)

                    || typeToConvert == typeof(global::Dataloop.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngine)

                    || typeToConvert == typeof(global::Dataloop.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngine?)

                    || typeToConvert == typeof(global::Dataloop.OrderBy)

                    || typeToConvert == typeof(global::Dataloop.OrderBy?)

                    || typeToConvert == typeof(global::Dataloop.DQLResourceQueryQueryEngine)

                    || typeToConvert == typeof(global::Dataloop.DQLResourceQueryQueryEngine?)

                    || typeToConvert == typeof(global::Dataloop.AddItemMode)

                    || typeToConvert == typeof(global::Dataloop.AddItemMode?)

                    || typeToConvert == typeof(global::Dataloop.SystemDatasetType)

                    || typeToConvert == typeof(global::Dataloop.SystemDatasetType?)

                    || typeToConvert == typeof(global::Dataloop.AnnotationType)

                    || typeToConvert == typeof(global::Dataloop.AnnotationType?)

                    || typeToConvert == typeof(global::Dataloop.RefAnnotationsRefType)

                    || typeToConvert == typeof(global::Dataloop.RefAnnotationsRefType?)

                    || typeToConvert == typeof(global::Dataloop.RequestSource)

                    || typeToConvert == typeof(global::Dataloop.RequestSource?)

                    || typeToConvert == typeof(global::Dataloop.APIAnnotationEventDeleted)

                    || typeToConvert == typeof(global::Dataloop.APIAnnotationEventDeleted?)

                    || typeToConvert == typeof(global::Dataloop.IndexDriver)

                    || typeToConvert == typeof(global::Dataloop.IndexDriver?)

                    || typeToConvert == typeof(global::Dataloop.APIDatasetAccessLevel)

                    || typeToConvert == typeof(global::Dataloop.APIDatasetAccessLevel?)

                    || typeToConvert == typeof(global::Dataloop.DatasetScope)

                    || typeToConvert == typeof(global::Dataloop.DatasetScope?)

                    || typeToConvert == typeof(global::Dataloop.CreateDatasetRequestDriver)

                    || typeToConvert == typeof(global::Dataloop.CreateDatasetRequestDriver?)

                    || typeToConvert == typeof(global::Dataloop.CreateDatasetRequestAccessLevel)

                    || typeToConvert == typeof(global::Dataloop.CreateDatasetRequestAccessLevel?)

                    || typeToConvert == typeof(global::Dataloop.DQLQueryQueryEngine)

                    || typeToConvert == typeof(global::Dataloop.DQLQueryQueryEngine?)

                    || typeToConvert == typeof(global::Dataloop.ExportType)

                    || typeToConvert == typeof(global::Dataloop.ExportType?)

                    || typeToConvert == typeof(global::Dataloop.ExportDatasetOptionsExportVersion)

                    || typeToConvert == typeof(global::Dataloop.ExportDatasetOptionsExportVersion?)

                    || typeToConvert == typeof(global::Dataloop.ExportStatus)

                    || typeToConvert == typeof(global::Dataloop.ExportStatus?)

                    || typeToConvert == typeof(global::Dataloop.ExportErrorType)

                    || typeToConvert == typeof(global::Dataloop.ExportErrorType?)

                    || typeToConvert == typeof(global::Dataloop.QueryResourceItems)

                    || typeToConvert == typeof(global::Dataloop.QueryResourceItems?)

                    || typeToConvert == typeof(global::Dataloop.QueryResourceAnnotations)

                    || typeToConvert == typeof(global::Dataloop.QueryResourceAnnotations?)

                    || typeToConvert == typeof(global::Dataloop.QueryResourceDatasets)

                    || typeToConvert == typeof(global::Dataloop.QueryResourceDatasets?)

                    || typeToConvert == typeof(global::Dataloop.AllowedTypes)

                    || typeToConvert == typeof(global::Dataloop.AllowedTypes?)

                    || typeToConvert == typeof(global::Dataloop.UnsearchableSchemaReasons)

                    || typeToConvert == typeof(global::Dataloop.UnsearchableSchemaReasons?)

                    || typeToConvert == typeof(global::Dataloop.SchemaMode)

                    || typeToConvert == typeof(global::Dataloop.SchemaMode?)

                    || typeToConvert == typeof(global::Dataloop.DatasetItemType)

                    || typeToConvert == typeof(global::Dataloop.DatasetItemType?)

                    || typeToConvert == typeof(global::Dataloop.AnnotationTypeBox)

                    || typeToConvert == typeof(global::Dataloop.AnnotationTypeBox?)

                    || typeToConvert == typeof(global::Dataloop.AnnotationTypeClass)

                    || typeToConvert == typeof(global::Dataloop.AnnotationTypeClass?)

                    || typeToConvert == typeof(global::Dataloop.AnnotationTypeBinary)

                    || typeToConvert == typeof(global::Dataloop.AnnotationTypeBinary?)

                    || typeToConvert == typeof(global::Dataloop.GenerationStrategyType)

                    || typeToConvert == typeof(global::Dataloop.GenerationStrategyType?)

                    || typeToConvert == typeof(global::Dataloop.GeneratedDatasetTypes)

                    || typeToConvert == typeof(global::Dataloop.GeneratedDatasetTypes?)

                    || typeToConvert == typeof(global::Dataloop.OneByOneLatencyBenchmarkModeType)

                    || typeToConvert == typeof(global::Dataloop.OneByOneLatencyBenchmarkModeType?)

                    || typeToConvert == typeof(global::Dataloop.ProfilingBenchmarkModeType)

                    || typeToConvert == typeof(global::Dataloop.ProfilingBenchmarkModeType?)

                    || typeToConvert == typeof(global::Dataloop.ConcurrencyBenchmarkModeType)

                    || typeToConvert == typeof(global::Dataloop.ConcurrencyBenchmarkModeType?)

                    || typeToConvert == typeof(global::Dataloop.QueryTestCases)

                    || typeToConvert == typeof(global::Dataloop.QueryTestCases?)

                    || typeToConvert == typeof(global::Dataloop.IndexingStrategyType)

                    || typeToConvert == typeof(global::Dataloop.IndexingStrategyType?)

                    || typeToConvert == typeof(global::Dataloop.InferDatasetSchemaMode)

                    || typeToConvert == typeof(global::Dataloop.InferDatasetSchemaMode?)

                    || typeToConvert == typeof(global::Dataloop.FeatureFlagsSetContextVariant1Type)

                    || typeToConvert == typeof(global::Dataloop.FeatureFlagsSetContextVariant1Type?)

                    || typeToConvert == typeof(global::Dataloop.FeatureFlagsSetContextVariant2Type)

                    || typeToConvert == typeof(global::Dataloop.FeatureFlagsSetContextVariant2Type?)

                    || typeToConvert == typeof(global::Dataloop.DatasetAccessLevel)

                    || typeToConvert == typeof(global::Dataloop.DatasetAccessLevel?)

                    || typeToConvert == typeof(global::Dataloop.DatasetSyncStatus)

                    || typeToConvert == typeof(global::Dataloop.DatasetSyncStatus?)

                    || typeToConvert == typeof(global::Dataloop.DriverType)

                    || typeToConvert == typeof(global::Dataloop.DriverType?)

                    || typeToConvert == typeof(global::Dataloop.IntegrationType)

                    || typeToConvert == typeof(global::Dataloop.IntegrationType?)

                    || typeToConvert == typeof(global::Dataloop.FeatureSetEntityType)

                    || typeToConvert == typeof(global::Dataloop.FeatureSetEntityType?)

                    || typeToConvert == typeof(global::Dataloop.BenchmarkIngestionStrategyType)

                    || typeToConvert == typeof(global::Dataloop.BenchmarkIngestionStrategyType?)

                    || typeToConvert == typeof(global::Dataloop.BenchmarkOptionsExportType)

                    || typeToConvert == typeof(global::Dataloop.BenchmarkOptionsExportType?)

                    || typeToConvert == typeof(global::Dataloop.SetTaskRefsBenchmarkInputOperation)

                    || typeToConvert == typeof(global::Dataloop.SetTaskRefsBenchmarkInputOperation?)

                    || typeToConvert == typeof(global::Dataloop.DriverReadBenchmarkOperationInputScenarioDetails)

                    || typeToConvert == typeof(global::Dataloop.DriverReadBenchmarkOperationInputScenarioDetails?)

                    || typeToConvert == typeof(global::Dataloop.DriverWriteBenchmarkOperationInputScenarioDetails)

                    || typeToConvert == typeof(global::Dataloop.DriverWriteBenchmarkOperationInputScenarioDetails?)

                    || typeToConvert == typeof(global::Dataloop.AttributeType)

                    || typeToConvert == typeof(global::Dataloop.AttributeType?)

                    || typeToConvert == typeof(global::Dataloop.InstructionAction)

                    || typeToConvert == typeof(global::Dataloop.InstructionAction?)

                    || typeToConvert == typeof(global::Dataloop.InstructionScope)

                    || typeToConvert == typeof(global::Dataloop.InstructionScope?)

                    || typeToConvert == typeof(global::Dataloop.CustomActionControls)

                    || typeToConvert == typeof(global::Dataloop.CustomActionControls?)

                    || typeToConvert == typeof(global::Dataloop.APICustomActionControls)

                    || typeToConvert == typeof(global::Dataloop.APICustomActionControls?)

                    || typeToConvert == typeof(global::Dataloop.AssignmentStatus)

                    || typeToConvert == typeof(global::Dataloop.AssignmentStatus?)

                    || typeToConvert == typeof(global::Dataloop.AssignmentMetadataSystemType)

                    || typeToConvert == typeof(global::Dataloop.AssignmentMetadataSystemType?)

                    || typeToConvert == typeof(global::Dataloop.TaskType)

                    || typeToConvert == typeof(global::Dataloop.TaskType?)

                    || typeToConvert == typeof(global::Dataloop.ScoreType)

                    || typeToConvert == typeof(global::Dataloop.ScoreType?)

                    || typeToConvert == typeof(global::Dataloop.TaskStatus)

                    || typeToConvert == typeof(global::Dataloop.TaskStatus?)

                    || typeToConvert == typeof(global::Dataloop.QualityTaskTypes)

                    || typeToConvert == typeof(global::Dataloop.QualityTaskTypes?)

                    || typeToConvert == typeof(global::Dataloop.InstructionsDocumentMode)

                    || typeToConvert == typeof(global::Dataloop.InstructionsDocumentMode?)

                    || typeToConvert == typeof(global::Dataloop.TaskContributorsAction)

                    || typeToConvert == typeof(global::Dataloop.TaskContributorsAction?)

                    || typeToConvert == typeof(global::Dataloop.Role)

                    || typeToConvert == typeof(global::Dataloop.Role?)

                    || typeToConvert == typeof(global::Dataloop.OrgPlans)

                    || typeToConvert == typeof(global::Dataloop.OrgPlans?)

                    || typeToConvert == typeof(global::Dataloop.AlertTier)

                    || typeToConvert == typeof(global::Dataloop.AlertTier?)

                    || typeToConvert == typeof(global::Dataloop.OrgRole)

                    || typeToConvert == typeof(global::Dataloop.OrgRole?)

                    || typeToConvert == typeof(global::Dataloop.DLEntityType)

                    || typeToConvert == typeof(global::Dataloop.DLEntityType?)

                    || typeToConvert == typeof(global::Dataloop.OrgSize)

                    || typeToConvert == typeof(global::Dataloop.OrgSize?)

                    || typeToConvert == typeof(global::Dataloop.OrgIndustry)

                    || typeToConvert == typeof(global::Dataloop.OrgIndustry?)

                    || typeToConvert == typeof(global::Dataloop.IntegrationType2)

                    || typeToConvert == typeof(global::Dataloop.IntegrationType2?)

                    || typeToConvert == typeof(global::Dataloop.BillingResourceKey)

                    || typeToConvert == typeof(global::Dataloop.BillingResourceKey?)

                    || typeToConvert == typeof(global::Dataloop.MetricGroup)

                    || typeToConvert == typeof(global::Dataloop.MetricGroup?)

                    || typeToConvert == typeof(global::Dataloop.BillingPeriod)

                    || typeToConvert == typeof(global::Dataloop.BillingPeriod?)

                    || typeToConvert == typeof(global::Dataloop.BillingStatus)

                    || typeToConvert == typeof(global::Dataloop.BillingStatus?)

                    || typeToConvert == typeof(global::Dataloop.ScopeType)

                    || typeToConvert == typeof(global::Dataloop.ScopeType?)

                    || typeToConvert == typeof(global::Dataloop.GuestType)

                    || typeToConvert == typeof(global::Dataloop.GuestType?)

                    || typeToConvert == typeof(global::Dataloop.APIMembershipRole)

                    || typeToConvert == typeof(global::Dataloop.APIMembershipRole?)

                    || typeToConvert == typeof(global::Dataloop.UserInterestType)

                    || typeToConvert == typeof(global::Dataloop.UserInterestType?)

                    || typeToConvert == typeof(global::Dataloop.ApiKeyType)

                    || typeToConvert == typeof(global::Dataloop.ApiKeyType?)

                    || typeToConvert == typeof(global::Dataloop.LoginsLogQueryOrder)

                    || typeToConvert == typeof(global::Dataloop.LoginsLogQueryOrder?)

                    || typeToConvert == typeof(global::Dataloop.LoginsLogQueryOrderBy)

                    || typeToConvert == typeof(global::Dataloop.LoginsLogQueryOrderBy?)

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

                    || typeToConvert == typeof(global::Dataloop.ArtifactType)

                    || typeToConvert == typeof(global::Dataloop.ArtifactType?)

                    || typeToConvert == typeof(global::Dataloop.ReferenceType)

                    || typeToConvert == typeof(global::Dataloop.ReferenceType?)

                    || typeToConvert == typeof(global::Dataloop.NodeMlType)

                    || typeToConvert == typeof(global::Dataloop.NodeMlType?)

                    || typeToConvert == typeof(global::Dataloop.ModelOperationTypes)

                    || typeToConvert == typeof(global::Dataloop.ModelOperationTypes?)

                    || typeToConvert == typeof(global::Dataloop.ExecutionStatus)

                    || typeToConvert == typeof(global::Dataloop.ExecutionStatus?)

                    || typeToConvert == typeof(global::Dataloop.EventResourceType)

                    || typeToConvert == typeof(global::Dataloop.EventResourceType?)

                    || typeToConvert == typeof(global::Dataloop.CreateWebHookDTOHttpMethod)

                    || typeToConvert == typeof(global::Dataloop.CreateWebHookDTOHttpMethod?)

                    || typeToConvert == typeof(global::Dataloop.UpdateWebHookDTOHttpMethod)

                    || typeToConvert == typeof(global::Dataloop.UpdateWebHookDTOHttpMethod?)

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

                    || typeToConvert == typeof(global::Dataloop.ECacheMode)

                    || typeToConvert == typeof(global::Dataloop.ECacheMode?)

                    || typeToConvert == typeof(global::Dataloop.FaaSCacheSize)

                    || typeToConvert == typeof(global::Dataloop.FaaSCacheSize?)

                    || typeToConvert == typeof(global::Dataloop.FaaSCacheType)

                    || typeToConvert == typeof(global::Dataloop.FaaSCacheType?)

                    || typeToConvert == typeof(global::Dataloop.ServiceLogLevel)

                    || typeToConvert == typeof(global::Dataloop.ServiceLogLevel?)

                    || typeToConvert == typeof(global::Dataloop.LogsListDirection)

                    || typeToConvert == typeof(global::Dataloop.LogsListDirection?)

                    || typeToConvert == typeof(global::Dataloop.ReplicaStatus)

                    || typeToConvert == typeof(global::Dataloop.ReplicaStatus?)

                    || typeToConvert == typeof(global::Dataloop.ReplicaReason)

                    || typeToConvert == typeof(global::Dataloop.ReplicaReason?)

                    || typeToConvert == typeof(global::Dataloop.EDebugOptionsStatus)

                    || typeToConvert == typeof(global::Dataloop.EDebugOptionsStatus?)

                    || typeToConvert == typeof(global::Dataloop.ReportType)

                    || typeToConvert == typeof(global::Dataloop.ReportType?)

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

                    || typeToConvert == typeof(global::Dataloop.KubernetesServiceType?)

                    || typeToConvert == typeof(global::Dataloop.CycleRerunMethod)

                    || typeToConvert == typeof(global::Dataloop.CycleRerunMethod?)

                    || typeToConvert == typeof(global::Dataloop.PipelineType)

                    || typeToConvert == typeof(global::Dataloop.PipelineType?)

                    || typeToConvert == typeof(global::Dataloop.PackageType)

                    || typeToConvert == typeof(global::Dataloop.PackageType?)

                    || typeToConvert == typeof(global::Dataloop.JobStatusEnum)

                    || typeToConvert == typeof(global::Dataloop.JobStatusEnum?)

                    || typeToConvert == typeof(global::Dataloop.ExecutionsOrderByType)

                    || typeToConvert == typeof(global::Dataloop.ExecutionsOrderByType?)

                    || typeToConvert == typeof(global::Dataloop.ExecutionsOrderByDirection)

                    || typeToConvert == typeof(global::Dataloop.ExecutionsOrderByDirection?)

                    || typeToConvert == typeof(global::Dataloop.CommandStatus)

                    || typeToConvert == typeof(global::Dataloop.CommandStatus?)

                    || typeToConvert == typeof(global::Dataloop.CommandsDomain)

                    || typeToConvert == typeof(global::Dataloop.CommandsDomain?)

                    || typeToConvert == typeof(global::Dataloop.SettingsValueTypes)

                    || typeToConvert == typeof(global::Dataloop.SettingsValueTypes?)

                    || typeToConvert == typeof(global::Dataloop.PlatformEntityType)

                    || typeToConvert == typeof(global::Dataloop.PlatformEntityType?)

                    || typeToConvert == typeof(global::Dataloop.SettingScopeType)

                    || typeToConvert == typeof(global::Dataloop.SettingScopeType?)

                    || typeToConvert == typeof(global::Dataloop.SettingScopeId)

                    || typeToConvert == typeof(global::Dataloop.SettingScopeId?)

                    || typeToConvert == typeof(global::Dataloop.SettingScopeRole)

                    || typeToConvert == typeof(global::Dataloop.SettingScopeRole?)

                    || typeToConvert == typeof(global::Dataloop.SettingsTypes)

                    || typeToConvert == typeof(global::Dataloop.SettingsTypes?)

                    || typeToConvert == typeof(global::Dataloop.SettingsSectionNames)

                    || typeToConvert == typeof(global::Dataloop.SettingsSectionNames?)

                    || typeToConvert == typeof(global::Dataloop.PartialSettingScopeType)

                    || typeToConvert == typeof(global::Dataloop.PartialSettingScopeType?)

                    || typeToConvert == typeof(global::Dataloop.PartialSettingScopeId)

                    || typeToConvert == typeof(global::Dataloop.PartialSettingScopeId?)

                    || typeToConvert == typeof(global::Dataloop.PartialSettingScopeRole)

                    || typeToConvert == typeof(global::Dataloop.PartialSettingScopeRole?)

                    || typeToConvert == typeof(global::Dataloop.AzureWebhookEventAction)

                    || typeToConvert == typeof(global::Dataloop.AzureWebhookEventAction?)

                    || typeToConvert == typeof(global::Dataloop.AzureWebhookEventOperationRequestSource)

                    || typeToConvert == typeof(global::Dataloop.AzureWebhookEventOperationRequestSource?)

                    || typeToConvert == typeof(global::Dataloop.PaymentDriverTypes)

                    || typeToConvert == typeof(global::Dataloop.PaymentDriverTypes?)

                    || typeToConvert == typeof(global::Dataloop.PodType)

                    || typeToConvert == typeof(global::Dataloop.PodType?)

                    || typeToConvert == typeof(global::Dataloop.InvoiceStatus)

                    || typeToConvert == typeof(global::Dataloop.InvoiceStatus?)

                    || typeToConvert == typeof(global::Dataloop.Currency)

                    || typeToConvert == typeof(global::Dataloop.Currency?)

                    || typeToConvert == typeof(global::Dataloop.TaxType)

                    || typeToConvert == typeof(global::Dataloop.TaxType?)

                    || typeToConvert == typeof(global::Dataloop.PaymentDriverType)

                    || typeToConvert == typeof(global::Dataloop.PaymentDriverType?)

                    || typeToConvert == typeof(global::Dataloop.DBPaymentDriverConfigurationType)

                    || typeToConvert == typeof(global::Dataloop.DBPaymentDriverConfigurationType?)

                    || typeToConvert == typeof(global::Dataloop.ResourceAuditEventType)

                    || typeToConvert == typeof(global::Dataloop.ResourceAuditEventType?)

                    || typeToConvert == typeof(global::Dataloop.AlertStatus)

                    || typeToConvert == typeof(global::Dataloop.AlertStatus?)

                    || typeToConvert == typeof(global::Dataloop.FieldSortField)

                    || typeToConvert == typeof(global::Dataloop.FieldSortField?)

                    || typeToConvert == typeof(global::Dataloop.FieldSortDirection)

                    || typeToConvert == typeof(global::Dataloop.FieldSortDirection?)

                    || typeToConvert == typeof(global::Dataloop.ListExportHistoryRequestSortOrder)

                    || typeToConvert == typeof(global::Dataloop.ListExportHistoryRequestSortOrder?)

                    || typeToConvert == typeof(global::Dataloop.ListExportHistoryRequestSortBy)

                    || typeToConvert == typeof(global::Dataloop.ListExportHistoryRequestSortBy?)

                    || typeToConvert == typeof(global::Dataloop.QueryDatasetsRequestTarget)

                    || typeToConvert == typeof(global::Dataloop.QueryDatasetsRequestTarget?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Dataloop.ItemSpecType))
                {
                    return new global::Dataloop.JsonConverters.ItemSpecTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ItemSpecType?))
                {
                    return new global::Dataloop.JsonConverters.ItemSpecTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.RefType))
                {
                    return new global::Dataloop.JsonConverters.RefTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.RefType?))
                {
                    return new global::Dataloop.JsonConverters.RefTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModalityType))
                {
                    return new global::Dataloop.JsonConverters.ModalityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModalityType?))
                {
                    return new global::Dataloop.JsonConverters.ModalityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APIDatasetFileItemType))
                {
                    return new global::Dataloop.JsonConverters.APIDatasetFileItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APIDatasetFileItemType?))
                {
                    return new global::Dataloop.JsonConverters.APIDatasetFileItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APIDatasetFileItemAnnotated))
                {
                    return new global::Dataloop.JsonConverters.APIDatasetFileItemAnnotatedJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APIDatasetFileItemAnnotated?))
                {
                    return new global::Dataloop.JsonConverters.APIDatasetFileItemAnnotatedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APIDatasetDirectoryItemType))
                {
                    return new global::Dataloop.JsonConverters.APIDatasetDirectoryItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APIDatasetDirectoryItemType?))
                {
                    return new global::Dataloop.JsonConverters.APIDatasetDirectoryItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DatasetIndexDrivers))
                {
                    return new global::Dataloop.JsonConverters.DatasetIndexDriversJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DatasetIndexDrivers?))
                {
                    return new global::Dataloop.JsonConverters.DatasetIndexDriversNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ItemRefOperation))
                {
                    return new global::Dataloop.JsonConverters.ItemRefOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ItemRefOperation?))
                {
                    return new global::Dataloop.JsonConverters.ItemRefOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QueryResource))
                {
                    return new global::Dataloop.JsonConverters.QueryResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QueryResource?))
                {
                    return new global::Dataloop.JsonConverters.QueryResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReferenceQueryOperation))
                {
                    return new global::Dataloop.JsonConverters.ReferenceQueryOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReferenceQueryOperation?))
                {
                    return new global::Dataloop.JsonConverters.ReferenceQueryOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngine))
                {
                    return new global::Dataloop.JsonConverters.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngineJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngine?))
                {
                    return new global::Dataloop.JsonConverters.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngineNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OrderBy))
                {
                    return new global::Dataloop.JsonConverters.OrderByJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OrderBy?))
                {
                    return new global::Dataloop.JsonConverters.OrderByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DQLResourceQueryQueryEngine))
                {
                    return new global::Dataloop.JsonConverters.DQLResourceQueryQueryEngineJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DQLResourceQueryQueryEngine?))
                {
                    return new global::Dataloop.JsonConverters.DQLResourceQueryQueryEngineNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AddItemMode))
                {
                    return new global::Dataloop.JsonConverters.AddItemModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AddItemMode?))
                {
                    return new global::Dataloop.JsonConverters.AddItemModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SystemDatasetType))
                {
                    return new global::Dataloop.JsonConverters.SystemDatasetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SystemDatasetType?))
                {
                    return new global::Dataloop.JsonConverters.SystemDatasetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AnnotationType))
                {
                    return new global::Dataloop.JsonConverters.AnnotationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AnnotationType?))
                {
                    return new global::Dataloop.JsonConverters.AnnotationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.RefAnnotationsRefType))
                {
                    return new global::Dataloop.JsonConverters.RefAnnotationsRefTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.RefAnnotationsRefType?))
                {
                    return new global::Dataloop.JsonConverters.RefAnnotationsRefTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.RequestSource))
                {
                    return new global::Dataloop.JsonConverters.RequestSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.RequestSource?))
                {
                    return new global::Dataloop.JsonConverters.RequestSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APIAnnotationEventDeleted))
                {
                    return new global::Dataloop.JsonConverters.APIAnnotationEventDeletedJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APIAnnotationEventDeleted?))
                {
                    return new global::Dataloop.JsonConverters.APIAnnotationEventDeletedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.IndexDriver))
                {
                    return new global::Dataloop.JsonConverters.IndexDriverJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.IndexDriver?))
                {
                    return new global::Dataloop.JsonConverters.IndexDriverNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APIDatasetAccessLevel))
                {
                    return new global::Dataloop.JsonConverters.APIDatasetAccessLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APIDatasetAccessLevel?))
                {
                    return new global::Dataloop.JsonConverters.APIDatasetAccessLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DatasetScope))
                {
                    return new global::Dataloop.JsonConverters.DatasetScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DatasetScope?))
                {
                    return new global::Dataloop.JsonConverters.DatasetScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CreateDatasetRequestDriver))
                {
                    return new global::Dataloop.JsonConverters.CreateDatasetRequestDriverJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CreateDatasetRequestDriver?))
                {
                    return new global::Dataloop.JsonConverters.CreateDatasetRequestDriverNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CreateDatasetRequestAccessLevel))
                {
                    return new global::Dataloop.JsonConverters.CreateDatasetRequestAccessLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CreateDatasetRequestAccessLevel?))
                {
                    return new global::Dataloop.JsonConverters.CreateDatasetRequestAccessLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DQLQueryQueryEngine))
                {
                    return new global::Dataloop.JsonConverters.DQLQueryQueryEngineJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DQLQueryQueryEngine?))
                {
                    return new global::Dataloop.JsonConverters.DQLQueryQueryEngineNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExportType))
                {
                    return new global::Dataloop.JsonConverters.ExportTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExportType?))
                {
                    return new global::Dataloop.JsonConverters.ExportTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExportDatasetOptionsExportVersion))
                {
                    return new global::Dataloop.JsonConverters.ExportDatasetOptionsExportVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExportDatasetOptionsExportVersion?))
                {
                    return new global::Dataloop.JsonConverters.ExportDatasetOptionsExportVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExportStatus))
                {
                    return new global::Dataloop.JsonConverters.ExportStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExportStatus?))
                {
                    return new global::Dataloop.JsonConverters.ExportStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExportErrorType))
                {
                    return new global::Dataloop.JsonConverters.ExportErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExportErrorType?))
                {
                    return new global::Dataloop.JsonConverters.ExportErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QueryResourceItems))
                {
                    return new global::Dataloop.JsonConverters.QueryResourceItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QueryResourceItems?))
                {
                    return new global::Dataloop.JsonConverters.QueryResourceItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QueryResourceAnnotations))
                {
                    return new global::Dataloop.JsonConverters.QueryResourceAnnotationsJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QueryResourceAnnotations?))
                {
                    return new global::Dataloop.JsonConverters.QueryResourceAnnotationsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QueryResourceDatasets))
                {
                    return new global::Dataloop.JsonConverters.QueryResourceDatasetsJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QueryResourceDatasets?))
                {
                    return new global::Dataloop.JsonConverters.QueryResourceDatasetsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AllowedTypes))
                {
                    return new global::Dataloop.JsonConverters.AllowedTypesJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AllowedTypes?))
                {
                    return new global::Dataloop.JsonConverters.AllowedTypesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.UnsearchableSchemaReasons))
                {
                    return new global::Dataloop.JsonConverters.UnsearchableSchemaReasonsJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.UnsearchableSchemaReasons?))
                {
                    return new global::Dataloop.JsonConverters.UnsearchableSchemaReasonsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SchemaMode))
                {
                    return new global::Dataloop.JsonConverters.SchemaModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SchemaMode?))
                {
                    return new global::Dataloop.JsonConverters.SchemaModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DatasetItemType))
                {
                    return new global::Dataloop.JsonConverters.DatasetItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DatasetItemType?))
                {
                    return new global::Dataloop.JsonConverters.DatasetItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AnnotationTypeBox))
                {
                    return new global::Dataloop.JsonConverters.AnnotationTypeBoxJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AnnotationTypeBox?))
                {
                    return new global::Dataloop.JsonConverters.AnnotationTypeBoxNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AnnotationTypeClass))
                {
                    return new global::Dataloop.JsonConverters.AnnotationTypeClassJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AnnotationTypeClass?))
                {
                    return new global::Dataloop.JsonConverters.AnnotationTypeClassNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AnnotationTypeBinary))
                {
                    return new global::Dataloop.JsonConverters.AnnotationTypeBinaryJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AnnotationTypeBinary?))
                {
                    return new global::Dataloop.JsonConverters.AnnotationTypeBinaryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.GenerationStrategyType))
                {
                    return new global::Dataloop.JsonConverters.GenerationStrategyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.GenerationStrategyType?))
                {
                    return new global::Dataloop.JsonConverters.GenerationStrategyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.GeneratedDatasetTypes))
                {
                    return new global::Dataloop.JsonConverters.GeneratedDatasetTypesJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.GeneratedDatasetTypes?))
                {
                    return new global::Dataloop.JsonConverters.GeneratedDatasetTypesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OneByOneLatencyBenchmarkModeType))
                {
                    return new global::Dataloop.JsonConverters.OneByOneLatencyBenchmarkModeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OneByOneLatencyBenchmarkModeType?))
                {
                    return new global::Dataloop.JsonConverters.OneByOneLatencyBenchmarkModeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ProfilingBenchmarkModeType))
                {
                    return new global::Dataloop.JsonConverters.ProfilingBenchmarkModeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ProfilingBenchmarkModeType?))
                {
                    return new global::Dataloop.JsonConverters.ProfilingBenchmarkModeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ConcurrencyBenchmarkModeType))
                {
                    return new global::Dataloop.JsonConverters.ConcurrencyBenchmarkModeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ConcurrencyBenchmarkModeType?))
                {
                    return new global::Dataloop.JsonConverters.ConcurrencyBenchmarkModeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QueryTestCases))
                {
                    return new global::Dataloop.JsonConverters.QueryTestCasesJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QueryTestCases?))
                {
                    return new global::Dataloop.JsonConverters.QueryTestCasesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.IndexingStrategyType))
                {
                    return new global::Dataloop.JsonConverters.IndexingStrategyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.IndexingStrategyType?))
                {
                    return new global::Dataloop.JsonConverters.IndexingStrategyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.InferDatasetSchemaMode))
                {
                    return new global::Dataloop.JsonConverters.InferDatasetSchemaModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.InferDatasetSchemaMode?))
                {
                    return new global::Dataloop.JsonConverters.InferDatasetSchemaModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FeatureFlagsSetContextVariant1Type))
                {
                    return new global::Dataloop.JsonConverters.FeatureFlagsSetContextVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FeatureFlagsSetContextVariant1Type?))
                {
                    return new global::Dataloop.JsonConverters.FeatureFlagsSetContextVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FeatureFlagsSetContextVariant2Type))
                {
                    return new global::Dataloop.JsonConverters.FeatureFlagsSetContextVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FeatureFlagsSetContextVariant2Type?))
                {
                    return new global::Dataloop.JsonConverters.FeatureFlagsSetContextVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DatasetAccessLevel))
                {
                    return new global::Dataloop.JsonConverters.DatasetAccessLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DatasetAccessLevel?))
                {
                    return new global::Dataloop.JsonConverters.DatasetAccessLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DatasetSyncStatus))
                {
                    return new global::Dataloop.JsonConverters.DatasetSyncStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DatasetSyncStatus?))
                {
                    return new global::Dataloop.JsonConverters.DatasetSyncStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DriverType))
                {
                    return new global::Dataloop.JsonConverters.DriverTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DriverType?))
                {
                    return new global::Dataloop.JsonConverters.DriverTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.IntegrationType))
                {
                    return new global::Dataloop.JsonConverters.IntegrationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.IntegrationType?))
                {
                    return new global::Dataloop.JsonConverters.IntegrationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FeatureSetEntityType))
                {
                    return new global::Dataloop.JsonConverters.FeatureSetEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FeatureSetEntityType?))
                {
                    return new global::Dataloop.JsonConverters.FeatureSetEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.BenchmarkIngestionStrategyType))
                {
                    return new global::Dataloop.JsonConverters.BenchmarkIngestionStrategyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.BenchmarkIngestionStrategyType?))
                {
                    return new global::Dataloop.JsonConverters.BenchmarkIngestionStrategyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.BenchmarkOptionsExportType))
                {
                    return new global::Dataloop.JsonConverters.BenchmarkOptionsExportTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.BenchmarkOptionsExportType?))
                {
                    return new global::Dataloop.JsonConverters.BenchmarkOptionsExportTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SetTaskRefsBenchmarkInputOperation))
                {
                    return new global::Dataloop.JsonConverters.SetTaskRefsBenchmarkInputOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SetTaskRefsBenchmarkInputOperation?))
                {
                    return new global::Dataloop.JsonConverters.SetTaskRefsBenchmarkInputOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DriverReadBenchmarkOperationInputScenarioDetails))
                {
                    return new global::Dataloop.JsonConverters.DriverReadBenchmarkOperationInputScenarioDetailsJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DriverReadBenchmarkOperationInputScenarioDetails?))
                {
                    return new global::Dataloop.JsonConverters.DriverReadBenchmarkOperationInputScenarioDetailsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DriverWriteBenchmarkOperationInputScenarioDetails))
                {
                    return new global::Dataloop.JsonConverters.DriverWriteBenchmarkOperationInputScenarioDetailsJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DriverWriteBenchmarkOperationInputScenarioDetails?))
                {
                    return new global::Dataloop.JsonConverters.DriverWriteBenchmarkOperationInputScenarioDetailsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AttributeType))
                {
                    return new global::Dataloop.JsonConverters.AttributeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AttributeType?))
                {
                    return new global::Dataloop.JsonConverters.AttributeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.InstructionAction))
                {
                    return new global::Dataloop.JsonConverters.InstructionActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.InstructionAction?))
                {
                    return new global::Dataloop.JsonConverters.InstructionActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.InstructionScope))
                {
                    return new global::Dataloop.JsonConverters.InstructionScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.InstructionScope?))
                {
                    return new global::Dataloop.JsonConverters.InstructionScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CustomActionControls))
                {
                    return new global::Dataloop.JsonConverters.CustomActionControlsJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CustomActionControls?))
                {
                    return new global::Dataloop.JsonConverters.CustomActionControlsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APICustomActionControls))
                {
                    return new global::Dataloop.JsonConverters.APICustomActionControlsJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APICustomActionControls?))
                {
                    return new global::Dataloop.JsonConverters.APICustomActionControlsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AssignmentStatus))
                {
                    return new global::Dataloop.JsonConverters.AssignmentStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AssignmentStatus?))
                {
                    return new global::Dataloop.JsonConverters.AssignmentStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AssignmentMetadataSystemType))
                {
                    return new global::Dataloop.JsonConverters.AssignmentMetadataSystemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AssignmentMetadataSystemType?))
                {
                    return new global::Dataloop.JsonConverters.AssignmentMetadataSystemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TaskType))
                {
                    return new global::Dataloop.JsonConverters.TaskTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TaskType?))
                {
                    return new global::Dataloop.JsonConverters.TaskTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ScoreType))
                {
                    return new global::Dataloop.JsonConverters.ScoreTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ScoreType?))
                {
                    return new global::Dataloop.JsonConverters.ScoreTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TaskStatus))
                {
                    return new global::Dataloop.JsonConverters.TaskStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TaskStatus?))
                {
                    return new global::Dataloop.JsonConverters.TaskStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QualityTaskTypes))
                {
                    return new global::Dataloop.JsonConverters.QualityTaskTypesJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QualityTaskTypes?))
                {
                    return new global::Dataloop.JsonConverters.QualityTaskTypesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.InstructionsDocumentMode))
                {
                    return new global::Dataloop.JsonConverters.InstructionsDocumentModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.InstructionsDocumentMode?))
                {
                    return new global::Dataloop.JsonConverters.InstructionsDocumentModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TaskContributorsAction))
                {
                    return new global::Dataloop.JsonConverters.TaskContributorsActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TaskContributorsAction?))
                {
                    return new global::Dataloop.JsonConverters.TaskContributorsActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.Role))
                {
                    return new global::Dataloop.JsonConverters.RoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.Role?))
                {
                    return new global::Dataloop.JsonConverters.RoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OrgPlans))
                {
                    return new global::Dataloop.JsonConverters.OrgPlansJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OrgPlans?))
                {
                    return new global::Dataloop.JsonConverters.OrgPlansNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AlertTier))
                {
                    return new global::Dataloop.JsonConverters.AlertTierJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AlertTier?))
                {
                    return new global::Dataloop.JsonConverters.AlertTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OrgRole))
                {
                    return new global::Dataloop.JsonConverters.OrgRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OrgRole?))
                {
                    return new global::Dataloop.JsonConverters.OrgRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DLEntityType))
                {
                    return new global::Dataloop.JsonConverters.DLEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DLEntityType?))
                {
                    return new global::Dataloop.JsonConverters.DLEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OrgSize))
                {
                    return new global::Dataloop.JsonConverters.OrgSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OrgSize?))
                {
                    return new global::Dataloop.JsonConverters.OrgSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OrgIndustry))
                {
                    return new global::Dataloop.JsonConverters.OrgIndustryJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OrgIndustry?))
                {
                    return new global::Dataloop.JsonConverters.OrgIndustryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.IntegrationType2))
                {
                    return new global::Dataloop.JsonConverters.IntegrationType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.IntegrationType2?))
                {
                    return new global::Dataloop.JsonConverters.IntegrationType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.BillingResourceKey))
                {
                    return new global::Dataloop.JsonConverters.BillingResourceKeyJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.BillingResourceKey?))
                {
                    return new global::Dataloop.JsonConverters.BillingResourceKeyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.MetricGroup))
                {
                    return new global::Dataloop.JsonConverters.MetricGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.MetricGroup?))
                {
                    return new global::Dataloop.JsonConverters.MetricGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.BillingPeriod))
                {
                    return new global::Dataloop.JsonConverters.BillingPeriodJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.BillingPeriod?))
                {
                    return new global::Dataloop.JsonConverters.BillingPeriodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.BillingStatus))
                {
                    return new global::Dataloop.JsonConverters.BillingStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.BillingStatus?))
                {
                    return new global::Dataloop.JsonConverters.BillingStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ScopeType))
                {
                    return new global::Dataloop.JsonConverters.ScopeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ScopeType?))
                {
                    return new global::Dataloop.JsonConverters.ScopeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.GuestType))
                {
                    return new global::Dataloop.JsonConverters.GuestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.GuestType?))
                {
                    return new global::Dataloop.JsonConverters.GuestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APIMembershipRole))
                {
                    return new global::Dataloop.JsonConverters.APIMembershipRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APIMembershipRole?))
                {
                    return new global::Dataloop.JsonConverters.APIMembershipRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.UserInterestType))
                {
                    return new global::Dataloop.JsonConverters.UserInterestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.UserInterestType?))
                {
                    return new global::Dataloop.JsonConverters.UserInterestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ApiKeyType))
                {
                    return new global::Dataloop.JsonConverters.ApiKeyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ApiKeyType?))
                {
                    return new global::Dataloop.JsonConverters.ApiKeyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.LoginsLogQueryOrder))
                {
                    return new global::Dataloop.JsonConverters.LoginsLogQueryOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.LoginsLogQueryOrder?))
                {
                    return new global::Dataloop.JsonConverters.LoginsLogQueryOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.LoginsLogQueryOrderBy))
                {
                    return new global::Dataloop.JsonConverters.LoginsLogQueryOrderByJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.LoginsLogQueryOrderBy?))
                {
                    return new global::Dataloop.JsonConverters.LoginsLogQueryOrderByNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Dataloop.ArtifactType))
                {
                    return new global::Dataloop.JsonConverters.ArtifactTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ArtifactType?))
                {
                    return new global::Dataloop.JsonConverters.ArtifactTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReferenceType))
                {
                    return new global::Dataloop.JsonConverters.ReferenceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReferenceType?))
                {
                    return new global::Dataloop.JsonConverters.ReferenceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.NodeMlType))
                {
                    return new global::Dataloop.JsonConverters.NodeMlTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.NodeMlType?))
                {
                    return new global::Dataloop.JsonConverters.NodeMlTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelOperationTypes))
                {
                    return new global::Dataloop.JsonConverters.ModelOperationTypesJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelOperationTypes?))
                {
                    return new global::Dataloop.JsonConverters.ModelOperationTypesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionStatus))
                {
                    return new global::Dataloop.JsonConverters.ExecutionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionStatus?))
                {
                    return new global::Dataloop.JsonConverters.ExecutionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EventResourceType))
                {
                    return new global::Dataloop.JsonConverters.EventResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EventResourceType?))
                {
                    return new global::Dataloop.JsonConverters.EventResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CreateWebHookDTOHttpMethod))
                {
                    return new global::Dataloop.JsonConverters.CreateWebHookDTOHttpMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CreateWebHookDTOHttpMethod?))
                {
                    return new global::Dataloop.JsonConverters.CreateWebHookDTOHttpMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.UpdateWebHookDTOHttpMethod))
                {
                    return new global::Dataloop.JsonConverters.UpdateWebHookDTOHttpMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.UpdateWebHookDTOHttpMethod?))
                {
                    return new global::Dataloop.JsonConverters.UpdateWebHookDTOHttpMethodNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Dataloop.ECacheMode))
                {
                    return new global::Dataloop.JsonConverters.ECacheModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ECacheMode?))
                {
                    return new global::Dataloop.JsonConverters.ECacheModeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Dataloop.ReplicaStatus))
                {
                    return new global::Dataloop.JsonConverters.ReplicaStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReplicaStatus?))
                {
                    return new global::Dataloop.JsonConverters.ReplicaStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReplicaReason))
                {
                    return new global::Dataloop.JsonConverters.ReplicaReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReplicaReason?))
                {
                    return new global::Dataloop.JsonConverters.ReplicaReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EDebugOptionsStatus))
                {
                    return new global::Dataloop.JsonConverters.EDebugOptionsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EDebugOptionsStatus?))
                {
                    return new global::Dataloop.JsonConverters.EDebugOptionsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReportType))
                {
                    return new global::Dataloop.JsonConverters.ReportTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReportType?))
                {
                    return new global::Dataloop.JsonConverters.ReportTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Dataloop.PackageType))
                {
                    return new global::Dataloop.JsonConverters.PackageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PackageType?))
                {
                    return new global::Dataloop.JsonConverters.PackageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.JobStatusEnum))
                {
                    return new global::Dataloop.JsonConverters.JobStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.JobStatusEnum?))
                {
                    return new global::Dataloop.JsonConverters.JobStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionsOrderByType))
                {
                    return new global::Dataloop.JsonConverters.ExecutionsOrderByTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionsOrderByType?))
                {
                    return new global::Dataloop.JsonConverters.ExecutionsOrderByTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionsOrderByDirection))
                {
                    return new global::Dataloop.JsonConverters.ExecutionsOrderByDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionsOrderByDirection?))
                {
                    return new global::Dataloop.JsonConverters.ExecutionsOrderByDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CommandStatus))
                {
                    return new global::Dataloop.JsonConverters.CommandStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CommandStatus?))
                {
                    return new global::Dataloop.JsonConverters.CommandStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CommandsDomain))
                {
                    return new global::Dataloop.JsonConverters.CommandsDomainJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CommandsDomain?))
                {
                    return new global::Dataloop.JsonConverters.CommandsDomainNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingsValueTypes))
                {
                    return new global::Dataloop.JsonConverters.SettingsValueTypesJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingsValueTypes?))
                {
                    return new global::Dataloop.JsonConverters.SettingsValueTypesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PlatformEntityType))
                {
                    return new global::Dataloop.JsonConverters.PlatformEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PlatformEntityType?))
                {
                    return new global::Dataloop.JsonConverters.PlatformEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingScopeType))
                {
                    return new global::Dataloop.JsonConverters.SettingScopeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingScopeType?))
                {
                    return new global::Dataloop.JsonConverters.SettingScopeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingScopeId))
                {
                    return new global::Dataloop.JsonConverters.SettingScopeIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingScopeId?))
                {
                    return new global::Dataloop.JsonConverters.SettingScopeIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingScopeRole))
                {
                    return new global::Dataloop.JsonConverters.SettingScopeRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingScopeRole?))
                {
                    return new global::Dataloop.JsonConverters.SettingScopeRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingsTypes))
                {
                    return new global::Dataloop.JsonConverters.SettingsTypesJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingsTypes?))
                {
                    return new global::Dataloop.JsonConverters.SettingsTypesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingsSectionNames))
                {
                    return new global::Dataloop.JsonConverters.SettingsSectionNamesJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingsSectionNames?))
                {
                    return new global::Dataloop.JsonConverters.SettingsSectionNamesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PartialSettingScopeType))
                {
                    return new global::Dataloop.JsonConverters.PartialSettingScopeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PartialSettingScopeType?))
                {
                    return new global::Dataloop.JsonConverters.PartialSettingScopeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PartialSettingScopeId))
                {
                    return new global::Dataloop.JsonConverters.PartialSettingScopeIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PartialSettingScopeId?))
                {
                    return new global::Dataloop.JsonConverters.PartialSettingScopeIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PartialSettingScopeRole))
                {
                    return new global::Dataloop.JsonConverters.PartialSettingScopeRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PartialSettingScopeRole?))
                {
                    return new global::Dataloop.JsonConverters.PartialSettingScopeRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AzureWebhookEventAction))
                {
                    return new global::Dataloop.JsonConverters.AzureWebhookEventActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AzureWebhookEventAction?))
                {
                    return new global::Dataloop.JsonConverters.AzureWebhookEventActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AzureWebhookEventOperationRequestSource))
                {
                    return new global::Dataloop.JsonConverters.AzureWebhookEventOperationRequestSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AzureWebhookEventOperationRequestSource?))
                {
                    return new global::Dataloop.JsonConverters.AzureWebhookEventOperationRequestSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PaymentDriverTypes))
                {
                    return new global::Dataloop.JsonConverters.PaymentDriverTypesJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PaymentDriverTypes?))
                {
                    return new global::Dataloop.JsonConverters.PaymentDriverTypesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PodType))
                {
                    return new global::Dataloop.JsonConverters.PodTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PodType?))
                {
                    return new global::Dataloop.JsonConverters.PodTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.InvoiceStatus))
                {
                    return new global::Dataloop.JsonConverters.InvoiceStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.InvoiceStatus?))
                {
                    return new global::Dataloop.JsonConverters.InvoiceStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.Currency))
                {
                    return new global::Dataloop.JsonConverters.CurrencyJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.Currency?))
                {
                    return new global::Dataloop.JsonConverters.CurrencyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TaxType))
                {
                    return new global::Dataloop.JsonConverters.TaxTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TaxType?))
                {
                    return new global::Dataloop.JsonConverters.TaxTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PaymentDriverType))
                {
                    return new global::Dataloop.JsonConverters.PaymentDriverTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PaymentDriverType?))
                {
                    return new global::Dataloop.JsonConverters.PaymentDriverTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DBPaymentDriverConfigurationType))
                {
                    return new global::Dataloop.JsonConverters.DBPaymentDriverConfigurationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DBPaymentDriverConfigurationType?))
                {
                    return new global::Dataloop.JsonConverters.DBPaymentDriverConfigurationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ResourceAuditEventType))
                {
                    return new global::Dataloop.JsonConverters.ResourceAuditEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ResourceAuditEventType?))
                {
                    return new global::Dataloop.JsonConverters.ResourceAuditEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AlertStatus))
                {
                    return new global::Dataloop.JsonConverters.AlertStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AlertStatus?))
                {
                    return new global::Dataloop.JsonConverters.AlertStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FieldSortField))
                {
                    return new global::Dataloop.JsonConverters.FieldSortFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FieldSortField?))
                {
                    return new global::Dataloop.JsonConverters.FieldSortFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FieldSortDirection))
                {
                    return new global::Dataloop.JsonConverters.FieldSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FieldSortDirection?))
                {
                    return new global::Dataloop.JsonConverters.FieldSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ListExportHistoryRequestSortOrder))
                {
                    return new global::Dataloop.JsonConverters.ListExportHistoryRequestSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ListExportHistoryRequestSortOrder?))
                {
                    return new global::Dataloop.JsonConverters.ListExportHistoryRequestSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ListExportHistoryRequestSortBy))
                {
                    return new global::Dataloop.JsonConverters.ListExportHistoryRequestSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ListExportHistoryRequestSortBy?))
                {
                    return new global::Dataloop.JsonConverters.ListExportHistoryRequestSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QueryDatasetsRequestTarget))
                {
                    return new global::Dataloop.JsonConverters.QueryDatasetsRequestTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QueryDatasetsRequestTarget?))
                {
                    return new global::Dataloop.JsonConverters.QueryDatasetsRequestTargetNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[5];

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
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new SourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),

                    3 => new SourceGenerationContextChunk3(new global::System.Text.Json.JsonSerializerOptions()),

                    4 => new SourceGenerationContextChunk4(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}