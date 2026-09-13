
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Dictionary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetIndexDrivers), TypeInfoPropertyName = "DatasetIndexDrivers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CloneDatasetParams))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SystemDatasetType), TypeInfoPropertyName = "SystemDatasetType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ImportItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllowedTypes), TypeInfoPropertyName = "AllowedTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SchemaEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UnsearchableSchemaReasons), TypeInfoPropertyName = "UnsearchableSchemaReasons2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UnsearchableSchemaEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SchemaMode), TypeInfoPropertyName = "SchemaMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SchemaMap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.SchemaEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.UnsearchableSchemaEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Context))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecordMLSplitListKeysNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, double?>), TypeInfoPropertyName = "AnyOfStringDouble2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetFilteredDatasetLabelAggregationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetFilteredDatasetTypeAggregationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.ImportItemRequest>, global::Dataloop.ImportItemsToDatasetRequest>), TypeInfoPropertyName = "AnyOfIListImportItemRequestImportItemsToDatasetRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ImportItemRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ImportItemsToDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SplitMlOperationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIDataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetDatasetsByProjectIdsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ListExportHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIExportHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>), TypeInfoPropertyName = "AnyOfAPIDatasetFileItemAPIDatasetDirectoryItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.Dataset, global::Dataloop.APIDatasetSchema>), TypeInfoPropertyName = "AnyOfDatasetAPIDatasetSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, string>), TypeInfoPropertyName = "AnyOfAPICommandString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.Dataset>), TypeInfoPropertyName = "AnyOfAPICommandDataset2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetIndexDrivers?), TypeInfoPropertyName = "NullableDatasetIndexDrivers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResource?), TypeInfoPropertyName = "NullableQueryResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReferenceQueryOperation?), TypeInfoPropertyName = "NullableReferenceQueryOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngine?), TypeInfoPropertyName = "NullablePickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OrderBy?), TypeInfoPropertyName = "NullableOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.OrderBy?, global::Dataloop.SortQuery>?), TypeInfoPropertyName = "NullableAnyOfOrderBySortQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DQLResourceQueryQueryEngine?), TypeInfoPropertyName = "NullableDQLResourceQueryQueryEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SystemDatasetType?), TypeInfoPropertyName = "NullableSystemDatasetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnnotationType?), TypeInfoPropertyName = "NullableAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RefAnnotationsRefType?), TypeInfoPropertyName = "NullableRefAnnotationsRefType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IRefImageAnnotationsType?), TypeInfoPropertyName = "NullableIRefImageAnnotationsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAnnotationCoordinateTypes?), TypeInfoPropertyName = "NullableAPIAnnotationCoordinateTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RequestSource?), TypeInfoPropertyName = "NullableRequestSource2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllowedTypes?), TypeInfoPropertyName = "NullableAllowedTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UnsearchableSchemaReasons?), TypeInfoPropertyName = "NullableUnsearchableSchemaReasons2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SchemaMode?), TypeInfoPropertyName = "NullableSchemaMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.DatasetContext>?), TypeInfoPropertyName = "NullableAllOfContextDatasetContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetAccessLevel?), TypeInfoPropertyName = "NullableDatasetAccessLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetSyncStatus?), TypeInfoPropertyName = "NullableDatasetSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SchemaEntryInput?), TypeInfoPropertyName = "NullableSchemaEntryInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>?), TypeInfoPropertyName = "NullableAnyOfSchemaEntryInputVariant2Variant1SchemaEntryInputVariant2Variant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, double?>?), TypeInfoPropertyName = "NullableAnyOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ListExportHistoryRequestSortOrder?), TypeInfoPropertyName = "NullableListExportHistoryRequestSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ListExportHistoryRequestSortBy?), TypeInfoPropertyName = "NullableListExportHistoryRequestSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.DQLResourceQuery, global::Dataloop.AnyOf<global::Dataloop.FilterQuery, global::Dataloop.UpdateQuery, global::Dataloop.DeleteQuery>?>?), TypeInfoPropertyName = "NullableAllOfDQLResourceQueryAnyOfFilterQueryUpdateQueryDeleteQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.FilterQuery, global::Dataloop.UpdateQuery, global::Dataloop.DeleteQuery>?), TypeInfoPropertyName = "NullableAnyOfFilterQueryUpdateQueryDeleteQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryDatasetsRequestTarget?), TypeInfoPropertyName = "NullableQueryDatasetsRequestTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>?), TypeInfoPropertyName = "NullableAllOfDQLResourceQueryFilterQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.ImportItemRequest>, global::Dataloop.ImportItemsToDatasetRequest>?), TypeInfoPropertyName = "NullableAnyOfIListImportItemRequestImportItemsToDatasetRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>?), TypeInfoPropertyName = "NullableAnyOfAPIDatasetFileItemAPIDatasetDirectoryItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.Dataset, global::Dataloop.APIDatasetSchema>?), TypeInfoPropertyName = "NullableAnyOfDatasetAPIDatasetSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, string>?), TypeInfoPropertyName = "NullableAnyOfAPICommandString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.Dataset>?), TypeInfoPropertyName = "NullableAnyOfAPICommandDataset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ReferenceQueryRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.NoteMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Dataloop.Point>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.Point>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DatasetDirectoryTree>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIAnnotation, global::Dataloop.APIDataset, global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.SchemaEntryInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.ImportItemRequest>, global::Dataloop.ImportItemsToDatasetRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ImportItemRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIDataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIExportHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>>))]
    internal sealed partial class DatasetsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DatasetsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DatasetsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DatasetsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Dataloop.JsonConverters.IRefImageAnnotationsTypeJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.APIAnnotationCoordinateTypesJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.SchemaEntryInputJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<bool?, global::Dataloop.APIDatasetFileItemAnnotated?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::Dataloop.APIDatasetDirectoryItemExportZip>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIDatasetFileItem>, global::System.Collections.Generic.IList<global::Dataloop.APIDatasetDirectoryItem>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.OrderBy?, global::Dataloop.SortQuery>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<string, global::Dataloop.SystemDatasetType?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAnnotation, global::Dataloop.APIDataset, global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.DatasetContext>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>());
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
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.DQLResourceQuery, global::Dataloop.AnyOf<global::Dataloop.FilterQuery, global::Dataloop.UpdateQuery, global::Dataloop.DeleteQuery>?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.FilterQuery, global::Dataloop.UpdateQuery, global::Dataloop.DeleteQuery>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.ImportItemRequest>, global::Dataloop.ImportItemsToDatasetRequest>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<object, global::Dataloop.APICommand>());
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
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIAnnotation, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotation>>());
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

                    || typeToConvert == typeof(global::Dataloop.SystemDatasetType)

                    || typeToConvert == typeof(global::Dataloop.SystemDatasetType?)

                    || typeToConvert == typeof(global::Dataloop.AnnotationType)

                    || typeToConvert == typeof(global::Dataloop.AnnotationType?)

                    || typeToConvert == typeof(global::Dataloop.RefAnnotationsRefType)

                    || typeToConvert == typeof(global::Dataloop.RefAnnotationsRefType?)

                    || typeToConvert == typeof(global::Dataloop.RequestSource)

                    || typeToConvert == typeof(global::Dataloop.RequestSource?)

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

                    || typeToConvert == typeof(global::Dataloop.DatasetAccessLevel)

                    || typeToConvert == typeof(global::Dataloop.DatasetAccessLevel?)

                    || typeToConvert == typeof(global::Dataloop.DatasetSyncStatus)

                    || typeToConvert == typeof(global::Dataloop.DatasetSyncStatus?)

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
                    0 => new DatasetsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}