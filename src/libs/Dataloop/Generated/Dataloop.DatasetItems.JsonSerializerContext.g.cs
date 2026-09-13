
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskItemStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemRefOperation), TypeInfoPropertyName = "ItemRefOperation2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>), TypeInfoPropertyName = "AnyOfAPIDatasetFileItemAPIDatasetDirectoryItem2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.MoveItemsRequest, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfMoveItemsRequestIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>?), TypeInfoPropertyName = "NullableAnyOfAPIDatasetFileItemAPIDatasetDirectoryItem2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.MoveItemsRequest, global::System.Collections.Generic.List<string>>))]
    internal sealed partial class DatasetItemsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DatasetItemsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DatasetItemsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DatasetItemsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<bool?, global::Dataloop.APIDatasetFileItemAnnotated?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::Dataloop.APIDatasetDirectoryItemExportZip>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIDatasetFileItem>, global::System.Collections.Generic.IList<global::Dataloop.APIDatasetDirectoryItem>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.OrderBy?, global::Dataloop.SortQuery>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.ResourceReferenceMetadata, global::Dataloop.PartialAny>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<string, global::Dataloop.SystemDatasetType?>());
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
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.MoveItemsRequest, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<object, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, object>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
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

                    || typeToConvert == typeof(global::Dataloop.SystemDatasetType?);
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
                    0 => new DatasetItemsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}