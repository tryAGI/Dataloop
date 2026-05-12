
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemSpecType? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RefType? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModalityType? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIModality? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APISystemMetadata? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APISystemMetadataSystem? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIModality>? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIDatasetFileItem? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIDatasetFileItemType? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<bool?, global::Dataloop.APIDatasetFileItemAnnotated?>? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIDatasetFileItemAnnotated? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIDatasetDirectoryItem? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIDatasetDirectoryItemType? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIDatasetDirectoryItemExport? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<string, global::Dataloop.APIDatasetDirectoryItemExportZip>? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIDatasetDirectoryItemExportZip? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialAPIDatasetItem? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIDatasetItemCursor? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIDatasetFileItem>, global::System.Collections.Generic.IList<global::Dataloop.APIDatasetDirectoryItem>>? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIDatasetFileItem>? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIDatasetDirectoryItem>? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Dictionary? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APICommand? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DatasetIndexDrivers? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CloneDatasetParams? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemCloneRequest? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemMergeRequest? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaskItemStatus? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemRefOperation? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemRefsUpdateRequest? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemRefsUpdateBulkRequest? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryResource? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.JoinQuery? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.JoinQueryOn? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ReferenceQuery? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ReferenceQueryOperation? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ReferenceQueryRef>? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ReferenceQueryRef? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelect? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngine? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IntersectQuery? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.OrderBy? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SortQuery? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.OrderBy?, global::Dataloop.SortQuery>? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DQLResourceQuery? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DQLResourceQueryQueryEngine? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DQLResourceQuerySign? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddItemMode? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialAny? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ResourceReference? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.ResourceReferenceMetadata, global::Dataloop.PartialAny>? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ResourceReferenceMetadata? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemLink? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Modality? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SystemDatasetType? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RecordStringString? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RecordCollectionKeysBoolean? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RecordMLSplitListKeysBoolean? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemSystemMetadata? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ItemSystemMetadataTaskStatusLogItem>? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemSystemMetadataTaskStatusLogItem? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ResourceReference>? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ItemLink>? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.Modality>? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialItemMetadata? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateItemMetadataOptions? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateItemMetadataOptionsUpdate? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnnotationType? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Point? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.NoteMessage? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CoordinatesNote? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.NoteMessage>? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APINoteAnnotationCoordinatesV1? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PoseCoordinates? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.Point>? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EllipseCoordinatesV1? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CubeCoordinatesV1? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemDescriptionCoordinates? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RefAnnotationsRefType? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IBaseRefAnnotationCoordinates? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IRefImageAnnotationsType? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIAnnotationCoordinateTypes? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RequestSource? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIAnnotation? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIMetadata? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateAnnotationRequest? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SetupReport? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.S2SetupOptions? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BootstrapSetupInput? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<bool?, global::Dataloop.S2SetupOptions>? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIAnnotationRequest? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationRequest>? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialAPIAnnotation? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIAnnotationEvent? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<bool?, global::Dataloop.APIAnnotationEventDeleted?>? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIAnnotationEventDeleted? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationEvent>>? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationEvent>? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExpirationOptions? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IndexDriver? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIDataset? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIDatasetAccessLevel? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DatasetEtlOptions? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DatasetScope? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CollectionEntry? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.CollectionEntry>? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DatasetSystemMetadata? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<string, global::Dataloop.SystemDatasetType?>? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DatasetMetadata? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateDatasetRequest? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateDatasetRequestDriver? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateDatasetRequestAccessLevel? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DQLQuery? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DQLQueryQueryEngine? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CloneDatasetRequest? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MergeDatasetParams? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MergeDatasetsRequest? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialAPIDatasetPayload? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DatasetDirectoryTree? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DatasetDirectoryTree>? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExportType? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExportDatasetOptions? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExportDatasetOptionsAnnotations? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExportDatasetOptionsExportVersion? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExportStatus? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExportErrorType? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIExportHistory? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ClassifyFilteredItems? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ClassifyFilteredItemsQuery? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ClassifyFilteredItemsAnnotation? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIAnnotationOrAPIDatasetOrAPIDatasetFileItemOrAPIDatasetDirectoryItem? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIAnnotation, global::Dataloop.APIDataset, global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>>? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIAnnotation, global::Dataloop.APIDataset, global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryResourceItems? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryResourceAnnotations? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryResourceDatasets? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FilterQuery? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FilterQueryContext? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?>? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateQuery? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateQueryContext? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DeleteQuery? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DeleteQueryContext? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PickTranslatedQueryExcludeKeyofTranslatedQueryIntersectOrExceptOrSortOrLimit? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DqlLimit? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TranslatedQuery? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RestoreAnnotationsRequest? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.RestoreAnnotationsRequestAnnotation>? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RestoreAnnotationsRequestAnnotation? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ImportItemRequest? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllowedTypes? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SchemaEntry? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UnsearchableSchemaReasons? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UnsearchableSchemaEntry? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SchemaMode? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SchemaMap? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.SchemaEntry>? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.UnsearchableSchemaEntry>? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MigrateDatasetsIndexOperationInput? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CleanDatasetsDataSpec? Type167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateGCSBucketsOperationInput? Type168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemMetadata? Type169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemRevision? Type170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MasterItemSpec? Type171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ClonedItemSpec? Type172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Context? Type173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemContext? Type174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AuthZBlockItemContext? Type175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.ItemContext>? Type176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RecordStringResourceReference? Type177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DatasetItem? Type178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DatasetItemType? Type179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ItemRevision>? Type180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.MasterItemSpec, global::Dataloop.ClonedItemSpec>? Type181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnnotationTypeBox? Type182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnnotationTypeClass? Type183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnnotationTypeBinary? Type184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialMsNumberbytes3Anumber? Type185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PickDataStreamConfigAnyMaxConcurrentReadersOrRetentionOrCompression? Type186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GenerateDatasetOptions? Type187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GenerateDatasetOptionsTopics? Type188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GenerateDatasetOptionsMetadata? Type189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GenerateDatasetOptionsAnnotations? Type191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GenerateDatasetOptionsAnnotationsMetadata? Type192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.AnnotationTypeBox?, global::Dataloop.AnnotationTypeClass?, global::Dataloop.AnnotationTypeBinary?>>? Type193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.AnnotationTypeBox?, global::Dataloop.AnnotationTypeClass?, global::Dataloop.AnnotationTypeBinary?>? Type194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GenerateDatasetOptionsOutputStream? Type195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GenerationStrategyType? Type196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PickStartInputAnyMaxBytesOrMaxMessages? Type197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GeneratedDatasetTypes? Type198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RecordStringPickGenerateDatasetCommandIdOrStatusOrError? Type199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.OneByOneLatencyBenchmarkMode? Type200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.OneByOneLatencyBenchmarkModeType? Type201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ProfilingBenchmarkMode? Type202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ProfilingBenchmarkModeType? Type203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ConcurrencyBenchmarkMode? Type204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ConcurrencyBenchmarkModeType? Type205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BenchmarkMode? Type206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryTestCases? Type207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IndexingStrategyType? Type208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ITermConfiguration? Type209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PickQueryGeneratorInputAvoidDbCacheOrSelectIdsOnlyOrJoinTermsOrPageSize? Type210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ITermConfiguration>? Type211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.InferDatasetSchemaMode? Type212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FeatureFlagsSet? Type213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.FeatureFlagsSetContextVariant1, global::Dataloop.FeatureFlagsSetContextVariant2>? Type214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FeatureFlagsSetContextVariant1? Type215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FeatureFlagsSetContextVariant1Type? Type216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FeatureFlagsSetContextVariant2? Type217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FeatureFlagsSetContextVariant2Type? Type218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DatasetDeletionInformation? Type219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DatasetContext? Type220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AuthZBlockDatasetContext? Type221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.DatasetContext>? Type222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DatasetSchemaMap? Type223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.S2ItemMetadataSchema? Type224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Dataset? Type225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DatasetAccessLevel? Type226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DatasetSyncStatus? Type227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIDatasetSchema? Type228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SchemaEntryInput? Type229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SchemaEntryInputVariant1? Type230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>? Type231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SchemaEntryInputVariant2Variant1? Type232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SchemaEntryInputVariant2Variant2? Type233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateItemsSchemaInput? Type234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateItemsSchemaInputSchemaKeys? Type235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.SchemaEntryInput>? Type236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateItemsSchemaInputUnsearchablePaths? Type237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateItemsSchemaInputIndexingOptions? Type238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EditItemsSchemaModeInput? Type239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MigrateStorageDriverOperationInput? Type240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RecordMLSplitListKeysNumber? Type241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverType? Type242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIDriverConfiguration? Type243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.S3IntegrationConfig? Type244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GcsIntegrationConfig? Type245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AzureBlobIntegrationConfig? Type246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverMetadata? Type247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverMetadataSystem? Type248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverContext? Type249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AuthZBlockDriverContext? Type250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.DriverContext>? Type251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IntegrationType? Type252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EnvUserPasswordAuthentication? Type253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.KeyFileAuthentication? Type254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PickS3DriverPayloadExcludeKeyofS3DriverPayloadPath? Type255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.EnvUserPasswordAuthentication, global::Dataloop.KeyFileAuthentication>? Type256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.S3DriverPayload? Type257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GcsDriverPayload? Type258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AzureBlobDriverPayload? Type259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PickFilesystemDriverConfigurationMountPath? Type260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverPayload? Type261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.S3DriverPayload, global::Dataloop.GcsDriverPayload, global::Dataloop.AzureBlobDriverPayload, global::Dataloop.PickFilesystemDriverConfigurationMountPath>? Type262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RecordStringLabelStringdrivers3f3AAPIDriverConfigurationArraydriverId3f3Astring? Type263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialS3DriverPayload? Type264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialGcsDriverPayload? Type265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialAzureBlobDriverPayload? Type266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialDriverPayload? Type267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.PartialS3DriverPayload, global::Dataloop.PartialGcsDriverPayload, global::Dataloop.PartialAzureBlobDriverPayload>? Type268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIFeatureSet? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIFeatureSet? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIFeatureSet>? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FeatureSetEntityType? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FeatureSet? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialFeatureSet? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIFeatureVector? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FeatureVector? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIFeatureVector? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIFeatureVector>? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AggregateProjectVectorsCountResultItem>? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AggregateProjectVectorsCountResultItem? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AggregateProjectVectorsCountInput? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ProjectStorageRequest? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EditItemsStressInput? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IUploadItemsBenchmarkInput? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IndexDriver>? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BenchmarkIngestionStrategyType? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GeneratedDatasetConfig? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddItemsOperationInput? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddAnnotationsOperationInput? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UploadItemsBenchmarkCommandV2Input? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UploadItemsBenchmarkCommandV2InputUploadFileConfig? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BenchmarkOptions? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BenchmarkOptionsExportType? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SetTaskRefsBenchmarkInput? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SetTaskRefsBenchmarkInputOperation? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SetTaskRefsStatusBenchmarkInput? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BulkCreateAnnotationsBenchmarkInput? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverReadBenchmarkOperationInput? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverReadBenchmarkOperationInputScenarioDetails? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverWriteBenchmarkOperationInput? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverWriteBenchmarkOperationInputScenarioDetails? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIOntologyV2? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APILabelTree? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APILabelTree>? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APILabel? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APILabelDisplayImage? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APILabelDisplayData? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIOntology? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateOntologyPayloadV2? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LabelDisplayImage? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LabelDisplayData? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateLabelPayloadV1? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateLabelPayloadTreeV1? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.CreateLabelPayloadTreeV1>? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateOntologyPayload? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIOntologyConfigurationV2? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateLabelPayload? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddLabelsNodePayload? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.CreateLabelPayload>? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateLabelsNodePayload? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AttributeType? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AttributeCreationPayload? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpsertRequestPayloadAttributeCreationPayload? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AttributeCreationPayload>? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIOntologyCursor? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>>? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APILabelScopeV2? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIToolOptionsV2? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RecipeType? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIRecipeV2? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIRecipeV2Ontology? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.APIToolOptionsV2>? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIRecipe? Type335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LabelScopeV2? Type336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntology? Type337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntologyOntology? Type338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ToolOptions? Type339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Metadata2? Type340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RecipeV2Context? Type341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AuthZBlockRecipeV2Context? Type342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.RecipeV2Context>? Type343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialRecipeV2? Type344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialRecipeV2Ontology? Type345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.ToolOptions>? Type346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RecipeV2Input? Type347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PickRecipeTitleOrProjectIdsOrOntologyIds? Type348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.InstructionAction? Type349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.InstructionScope? Type350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ToolInstruction? Type351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.ToolInstructionOptions, global::Dataloop.Dictionary>? Type352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ToolInstructionOptions? Type353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GoodExample? Type354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ToolInstruction>? Type355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Example? Type356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CustomAction? Type357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.CustomActionTarget>? Type358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CustomActionTarget? Type359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CustomActionControls? Type360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RecipeContext? Type361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AuthZBlockRecipeContext? Type362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.RecipeContext>? Type363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialRecipe? Type364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialRecipeExamples? Type365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.Example>? Type366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.GoodExample>? Type367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.CustomAction>? Type368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RecipeInput? Type369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClientLabel? Type370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LabelTree? Type371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.LabelTree>? Type372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CloneRecipePayload? Type373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialRecipePayloadV2? Type374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIInstruction? Type375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIGoodExample? Type376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIInstruction>? Type377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIBadExample? Type378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APICustomAction? Type379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APICustomActionTarget>? Type380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APICustomActionTarget? Type381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APICustomActionControls? Type382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialRecipePayload? Type383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialRecipePayloadExamples? Type384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIBadExample>? Type385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIGoodExample>? Type386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APICustomAction>? Type387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIRecipeV2OrAPIRecipe? Type388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>>? Type389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>? Type390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AssignmentStatus? Type391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemStatus? Type392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIAssignment? Type393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIAssignmentRemoveItemsProcess? Type394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIAssignmentRedistributeProcess? Type395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialAssignmentPayload? Type396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIAssignmentCursor? Type397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>? Type398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ReassignAssignmentPayload? Type399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AssignmentWorkload? Type400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RedistributeAssignmentPayload? Type401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AssignmentWorkload>? Type402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BatchAssignmentPayload? Type403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AssignmentStatusPayload? Type404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AssignmentMetadata? Type405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.Dictionary, global::Dataloop.AssignmentMetadataSystem>? Type406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AssignmentMetadataSystem? Type407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AssignmentMetadataSystemType? Type408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaskType? Type409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AssignmentContext? Type410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AuthZBlockAssignmentContext? Type411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.AssignmentContext>? Type412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialAssignment? Type413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialAssignmentRedistributeProcess? Type414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialAssignmentRemoveItemsProcess? Type415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APILabelV2? Type416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APILabelTreeNodeV2? Type417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPILabelTreeNodeV2? Type418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APILabelTreeNodeV2>? Type419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FilterQueryInput? Type420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FilterQueryInputContext? Type421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FilterQueryInputReferences? Type422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.FilterQueryInputReferencesRef>? Type423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FilterQueryInputReferencesRef? Type424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateLabelNodePayload? Type425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIAttributeSection? Type426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateAttributePayload? Type427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateAttributePayloadScope? Type428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIAttributeSection? Type429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIAttributeSection>? Type430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIUpdateAttributePayload? Type431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIUpdateAttributePayloadScope? Type432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIStructure? Type433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type434 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateStructurePayload? Type435 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIUpdateStructurePayload? Type436 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIStructure? Type437 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIStructure>? Type438 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ScoreType? Type439 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIScore? Type440 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIScoreContext? Type441 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Score? Type442 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ScoreContext? Type443 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ScoreParameters? Type444 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ScoreParametersScore? Type445 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ScoreParametersScoreContext? Type446 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type447 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ScoreParametersOptions? Type448 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DeleteTaskItemScoresPayload? Type449 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DeleteTaskItemScoresPayloadContext? Type450 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APITaskSpec? Type451 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APISpawnTaskSpec? Type452 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaskStatus? Type453 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemAction? Type454 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Description? Type455 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APITask? Type456 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>? Type457 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ItemAction>? Type458 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaskWorkload? Type459 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryFilter? Type460 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryFilterContext? Type461 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QualityTaskTypes? Type462 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.InstructionsDocumentMode? Type463 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialTaskInstructionsDocumentDetails? Type464 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaskMetadata? Type465 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.Dictionary, global::Dataloop.TaskMetadataSystem>? Type466 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaskMetadataSystem? Type467 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.TaskWorkload>? Type468 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PickDescriptionContent? Type469 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaskPayload? Type470 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaskPayloadCheckIfExist? Type471 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddToTaskPayload? Type472 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RemoveFromTaskPayload? Type473 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialTaskPayload? Type474 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaskContributorsAction? Type475 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateContributorsPayload? Type476 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APITaskCursor? Type477 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APITask>? Type478 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaskRelativeInput? Type479 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaskQueueDetails? Type480 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DeleteTaskPayload? Type481 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAny? Type482 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APITaskCounters? Type483 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.WorkflowsCounters? Type484 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GroupCtx? Type485 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIUser? Type486 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.GroupCtx>? Type487 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIOrg, string>? Type488 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIOrg? Type489 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIUserGuest? Type490 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Role? Type491 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIUser>, global::System.Collections.Generic.IList<string>>? Type492 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIUser>? Type493 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIGroup>, global::System.Collections.Generic.IList<string>>? Type494 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIGroup>? Type495 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIGroup? Type496 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIUser, string>? Type497 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIAccount, string>? Type498 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIAccount? Type499 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.OrgPlans? Type500 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIIntegration>, global::System.Collections.Generic.IList<string>>? Type501 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIIntegration>? Type502 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIIntegration? Type503 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIProject>, global::System.Collections.Generic.IList<string>>? Type504 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIProject>? Type505 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIProject? Type506 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FeatureConstraint? Type507 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.FeatureConstraint>? Type508 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIProjectGuest>, global::System.Collections.Generic.IList<string>>? Type509 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIProjectGuest>? Type510 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIProjectGuest? Type511 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIProject, string>? Type512 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIIntegrationMetadata>? Type513 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIIntegrationMetadata? Type514 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIIntegration, string>? Type515 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateAccountRequest? Type516 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIGoogleMarketplaceAccount? Type517 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EditAccountRequest? Type518 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AlertTier? Type519 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.OrgRole? Type520 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RoleEntry? Type521 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.Role?, global::Dataloop.OrgRole?>? Type522 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateBotPayload? Type523 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateGroupPayload? Type524 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PatchGroupPayload? Type525 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DLEntityType? Type526 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AuthUserAttributes? Type527 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.OrgSize? Type528 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.OrgIndustry? Type529 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIOrgUser? Type530 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.OrgRole?, string>? Type531 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIOrgDomain? Type532 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IntegrationType2? Type533 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IKeyValueMetadata? Type534 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IntegrationMetadataBody? Type535 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IntegrationBody? Type536 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IntegrationMetadataBody>? Type537 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IntegrationBodyCredentials? Type538 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BillingResourceKey? Type539 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MetricGroup? Type540 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BillingResource? Type541 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Plan? Type542 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.BillingResource>? Type543 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BillingPeriod? Type544 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BillingStatus? Type545 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ScopeType? Type546 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APISubscription? Type547 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APISubscriptionScope? Type548 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GuestType? Type549 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIGuest? Type550 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.GuestType?, string>? Type551 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateGuestPayload? Type552 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateProjectPayload? Type553 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIMembership? Type554 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.Role?, string, global::Dataloop.APIMembershipRole?>? Type555 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIMembershipRole? Type556 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UserInterestType? Type557 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddMembersBatchPayload? Type558 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ClientContributor? Type559 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ClientContributorGuest? Type560 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddMemberPayload? Type561 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PatchMemberPayload? Type562 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateMyDetailsPayload? Type563 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIHashUser? Type564 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ApiKeyType? Type565 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIApiKey? Type566 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APILogin? Type567 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPILogin? Type568 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APILogin>? Type569 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LoginsLogQuery? Type570 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LoginsLogQueryOrder? Type571 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LoginsLogQueryOrderBy? Type572 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EntityScopeLevel? Type573 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelStatus? Type574 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIModelConfiguration? Type575 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<double?, string>? Type576 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelInputType? Type577 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelOutputType? Type578 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelOutputTypeVariant2? Type579 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelOutputTypeVariant4? Type580 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ArtifactType? Type581 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemArtifact? Type582 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LocalArtifact? Type583 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EntityContext? Type584 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelOperationMetadata? Type585 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIModelMetadataSubsets? Type586 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIModelMetadataAnnotationsSubsets? Type587 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ReferenceType? Type588 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EntityReference? Type589 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.NodeMlType? Type590 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIModelMetadataSystem? Type591 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.EntityReference>? Type592 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIModelMetadataSystemMlType? Type593 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIModelMetadataSystemCloneCommand? Type594 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIModelMetadataSystemEmbedDatasets? Type595 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIModelMetadataSystemReloadServices? Type596 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIModelMetadata? Type597 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IAppDefinition? Type598 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelStatusLog? Type599 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIModel? Type600 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>>? Type601 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>? Type602 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ModelStatusLog>? Type603 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPISetting? Type604 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIModel>? Type605 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateModelRequest? Type606 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PatchModelRequest? Type607 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelOperationTypes? Type608 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryModel? Type609 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionStatus? Type610 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionStatusReport? Type611 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionStatusName? Type612 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionPipelineStateReference? Type613 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionModel? Type614 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EventResourceType? Type615 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemStatusEvent? Type616 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemStatusEventStatus? Type617 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionEventContext? Type618 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ResourceType? Type619 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDate? Type620 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.JssdkDictionary? Type621 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Execution? Type622 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionFeedbackQueue? Type623 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ExecutionStatusReport>? Type624 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionPipeline? Type625 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AuthZBlockExecutionContext? Type626 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ExecutionResource>? Type627 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionResource? Type628 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionMode? Type629 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionSyncReplyTo? Type630 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionHook? Type631 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionPhase? Type632 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.OnResetAction? Type633 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialAPIEmbedDatasetsSpec? Type634 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialAPIEmbedDatasetsSpecConfig? Type635 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialCreateModelRequest? Type636 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APICopyEnvironmentSpec? Type637 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.ModelJoinMap2>? Type638 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelJoinMap2? Type639 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PrecisionRecallInputRequest? Type640 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Error? Type641 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LineData? Type642 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MatrixData? Type643 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type644 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SummaryData? Type645 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MetricData? Type646 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MetricRequest? Type647 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PrivateRegistry? Type648 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceDriver? Type649 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AutoscalersDriverZombies? Type650 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIWebHook? Type651 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.WebHooksPage? Type652 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIWebHook>? Type653 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateWebHookDTO? Type654 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateWebHookDTOHttpMethod? Type655 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateWebHookDTO? Type656 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateWebHookDTOHttpMethod? Type657 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceRuntime? Type658 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceVersions? Type659 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Panel? Type660 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IServiceAppConfig? Type661 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceType? Type662 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CrashloopAction? Type663 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CrashloopReason? Type664 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Crashloop? Type665 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceModeType? Type666 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceMode? Type667 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SystemRefs? Type668 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceMetadata? Type669 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.ServiceMetadataUser, global::Dataloop.Dictionary>? Type670 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceMetadataUser? Type671 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceMetadataMl? Type672 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.ServiceMetadataSystem, global::Dataloop.SystemRefs, global::Dataloop.Dictionary>? Type673 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceMetadataSystem? Type674 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IServiceGeneralSettings? Type675 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceIntegration? Type676 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIService? Type677 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.Panel>? Type678 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ServiceIntegration>? Type679 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PackageResourceType? Type680 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionHookValueFrom? Type681 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionHookType? Type682 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PackageIO? Type683 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PackageIOIntegration? Type684 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UiBindingResource? Type685 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UiBindingPanel? Type686 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DisplayScope? Type687 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionPostActionType? Type688 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionPostAction? Type689 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DLFunctionDefaultInputSpec? Type690 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DLFunctionInputOptionsSpec? Type691 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DLFunction? Type692 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PackageIO>? Type693 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DisplayScope>? Type694 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DLFunctionDefaultInputSpec>? Type695 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DLFunctionInputOptionsSpec>? Type696 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPipelineExecution? Type697 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIExecution? Type698 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIExecutionSyncReplyTo? Type699 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UiSlot? Type700 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.ActivitiesDescriptor2>? Type701 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ActivitiesDescriptor2? Type702 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.ActivitiesDescriptorFunctions2>? Type703 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ActivitiesDescriptorFunctions2? Type704 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIExecution>? Type705 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TriggerType? Type706 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EntityReferenceMetadata? Type707 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APITrigger? Type708 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TriggersPage? Type709 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APITrigger>? Type710 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateTriggerRequest? Type711 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TriggerResourceInformationItem? Type712 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TriggerResourceInformationPage? Type713 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.TriggerResourceInformationItem>? Type714 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TriggerResourceInformationQuery? Type715 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AgentNotificationPayload? Type716 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AgentNotificationPayloadAgentInfo? Type717 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ECacheMode? Type718 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FaaSCacheSize? Type719 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FaaSCacheType? Type720 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICacheRunner? Type721 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICacheOptions? Type722 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICacheOptionsOrg? Type723 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServicesPage? Type724 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIService>? Type725 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIServicePatch? Type726 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceLogLevel? Type727 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceLogEntry? Type728 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceLogsPage? Type729 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ServiceLogEntry>? Type730 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LogsListDirection? Type731 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LogQuery? Type732 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ReplicaStatus? Type733 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIReplicaStatusUpdate? Type734 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ReplicaReason? Type735 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceRuntimeStatus? Type736 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIServiceStatus? Type737 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ServiceRuntimeStatus>? Type738 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EDebugOptionsStatus? Type739 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DebugSession? Type740 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ReportType? Type741 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BaseReportMessage? Type742 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IServiceScaler? Type743 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceDriverType? Type744 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IComputeContext? Type745 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DataloopPodType? Type746 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverCondition? Type747 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverToleration? Type748 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverTolerationConditions? Type749 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DriverCondition>? Type750 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverNodeSelector? Type751 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverNodeSelectorConditions? Type752 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CacheRunner? Type753 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ComputeMetadata? Type754 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ComputeMetadataVariant2? Type755 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ComputeMetadataVariant2ServeAgentGateway? Type756 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DriverNodeSelector>? Type757 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DriverToleration>? Type758 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DataloopPodType>? Type759 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIServiceDriver? Type760 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CompositionElementStatus? Type761 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIServiceCompositionElement? Type762 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIServiceCompositionElementState? Type763 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CompositionStatus? Type764 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionError? Type765 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionErrorContext? Type766 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TriggerResourceType? Type767 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TriggerActionType? Type768 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TriggerOperationType? Type769 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TriggerOperation? Type770 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionTrigger? Type771 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionTriggerSpec? Type772 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.TriggerActionType>? Type773 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ECompositionPackageStatus? Type774 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialModule? Type775 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DLFunction>? Type776 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PackageConfigType? Type777 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PackageRequirementOperator? Type778 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PackageRequirement? Type779 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CodebaseType? Type780 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Codebase? Type781 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionPackage? Type782 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionPackageState? Type783 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PackageRequirement>? Type784 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionTask? Type785 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionTaskState? Type786 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelConfiguration? Type787 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IModel? Type788 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.Dictionary>? Type789 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionElementState? Type790 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceConfig? Type791 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APICompositionModel? Type792 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ChannelType? Type793 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CompositionChannelStatus? Type794 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.NotificationEntityContext? Type795 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FilterTarget? Type796 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.NotificationEventContext? Type797 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionFilter? Type798 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionFilterState? Type799 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionChannel? Type800 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionChannelMetadata? Type801 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionChannelState? Type802 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionFilter>? Type803 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TemplateKind? Type804 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.INodeConfig? Type805 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.INodeConfigPackage? Type806 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.NodeNamespace? Type807 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PortIO? Type808 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.NodeType? Type809 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PipelineNodeDescriptor? Type810 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PortIO>? Type811 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PipelineNodeSource? Type812 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PipelineNodeTarget? Type813 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PipelineConnection? Type814 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.StartNodeType? Type815 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ITriggerSpec? Type816 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ITriggerSpecSpec? Type817 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IStartNode? Type818 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ResumePipelineOption? Type819 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPipelineSettings? Type820 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPipelineSettingsLastUpdate? Type821 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PipelineVariable? Type822 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PipelineFromTemplateState? Type823 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionPipelineTemplate? Type824 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PipelineNodeDescriptor>? Type825 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PipelineConnection>? Type826 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IStartNode>? Type827 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PipelineVariable>? Type828 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionPipelineTemplateTemplate? Type829 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionPipelineTemplateState? Type830 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionDatasetState? Type831 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionDatasetStateDataset? Type832 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionDatasetStateDatasetIndexDriver? Type833 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionDatasetStateDatasetShareLevel? Type834 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionDatasetStateDatasetExport? Type835 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type836 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionDatasetStateDatasetAnnotation>? Type837 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionDatasetStateDatasetAnnotation? Type838 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TextSearch? Type839 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MqDetails? Type840 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceContext? Type841 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AuthZBlockServiceContext? Type842 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.ServiceContext>? Type843 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialService? Type844 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DpkDatasetOntologyType? Type845 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionDataset? Type846 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionDatasetOntology? Type847 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionDatasetInvoke? Type848 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIComposition? Type849 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIServiceCompositionElement>? Type850 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.ICompositionError, string>? Type851 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionTrigger>? Type852 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionPackage>? Type853 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionTask>? Type854 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APICompositionModel>? Type855 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionChannel>? Type856 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionPipelineTemplate>? Type857 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionDataset>? Type858 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIPipeline? Type859 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIPipelineTemplate? Type860 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionContext? Type861 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.ExecutionContext>? Type862 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialExecution? Type863 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<string, double?>? Type864 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialExecutionSyncReplyTo? Type865 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ENodeStatus? Type866 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPipelineNodeState? Type867 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EPipelineStatus? Type868 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.INodeTransitionError? Type869 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIPipelineState? Type870 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Dataloop.PartialExecution>>? Type871 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PartialExecution>? Type872 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IPipelineNodeState>? Type873 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.INodeTransitionError>? Type874 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPipelineState? Type875 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? Type876 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ResourceExecution? Type877 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EDpkScope? Type878 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkMetadata? Type879 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkMetadataCommands? Type880 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IAppContext? Type881 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkInitialContext? Type882 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentPanel? Type883 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentPanelSupportedSlot>? Type884 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentPanelSupportedSlot? Type885 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentModel? Type886 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentModelComputeConfigs? Type887 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.JsServiceVersions? Type888 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentModule? Type889 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EComponentServiceOperation? Type890 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentTrigger? Type891 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentTriggerSpec? Type892 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentService? Type893 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentToolbars? Type894 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FilterFrequencyType? Type895 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FilterFrequency? Type896 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkFilter? Type897 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkChannel? Type898 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkChannelMetadata? Type899 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkFilter>? Type900 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComputeConfigs? Type901 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.InvokeType? Type902 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ToolbarInvoke? Type903 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CustomNodeScope? Type904 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IInvoke? Type905 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPipelineNode? Type906 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkPipelineTemplate? Type907 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkPipelineTemplateTemplate? Type908 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentDataset? Type909 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentDatasetOntology? Type910 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentDatasetInvoke? Type911 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentIntegrations? Type912 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DpkComponents? Type913 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentIntegrations>? Type914 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentDataset>? Type915 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkPipelineTemplate>? Type916 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IPipelineNode>? Type917 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComputeConfigs>? Type918 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkChannel>? Type919 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentToolbars>? Type920 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentService>? Type921 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentTrigger>? Type922 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentModule>? Type923 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentModel>? Type924 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentPanel>? Type925 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EComponentElementType? Type926 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkPipelineNode? Type927 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentElementSpec? Type928 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IComponentElement? Type929 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>? Type930 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkDependency? Type931 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>? Type932 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkDependency>? Type933 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIDpk? Type934 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EAppScope? Type935 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialAPIDpk? Type936 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PickAPIDpkDependencies? Type937 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CustomInstallation? Type938 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CustomInstallationVariant2? Type939 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AppCommandsReference? Type940 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AppMetadata? Type941 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AppMetadataVariant2? Type942 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AppMetadataVariant2System? Type943 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IAppGeneralSettings? Type944 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIApp? Type945 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EComputeType? Type946 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EComputeStatus? Type947 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EClusterProvider? Type948 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Toleration? Type949 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.INodePoolDeploymentResources? Type950 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.INodePoolDeploymentResourcesRequests? Type951 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.INodePoolDeploymentResourcesLimits? Type952 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.INodePool? Type953 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.Toleration>? Type954 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EComputePlugin? Type955 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IExternalMonitoringConfig? Type956 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IHpaControllerConfig? Type957 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EStorageType? Type958 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IStorage? Type959 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IStorageDriverConfig? Type960 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IStorage>? Type961 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IComputeNfsPluginConfig? Type962 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.KubernetesServiceType? Type963 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2>? Type964 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ComputePluginResourceManifests2? Type965 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ComputePluginResourceManifestsSpec? Type966 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ComputePluginResourceManifestsSpecResources? Type967 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ComputePluginSpec? Type968 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ComputePluginSpecVariant2? Type969 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IComputePlugin? Type970 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.IExternalMonitoringConfig, global::Dataloop.IHpaControllerConfig, global::Dataloop.Dictionary, global::Dataloop.IStorageDriverConfig, global::Dataloop.IComputeNfsPluginConfig>? Type971 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IComputeAuthentication? Type972 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IComputeAuthenticationIntegration? Type973 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterVolume? Type974 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterVolumePersistentVolumeClaim? Type975 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterVolumeHostPath? Type976 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterVolumeConfigMap? Type977 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IClusterVolumeConfigMapItem>? Type978 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterVolumeConfigMapItem? Type979 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterVolumeSecret? Type980 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IClusterVolumeSecretItem>? Type981 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterVolumeSecretItem? Type982 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterVolumeNfs? Type983 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDeploymentSecurityContext? Type984 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterEnvironmentVariable? Type985 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterEnvironmentVariableValueFrom? Type986 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterEnvironmentVariableValueFromConfigMapKeyRef? Type987 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterEnvironmentVariableValueFromSecretKeyRef? Type988 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterEnvironmentVariableValueFromFieldRef? Type989 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IComputeRegistry? Type990 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDeploymentConfiguration? Type991 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IClusterVolume>? Type992 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IClusterEnvironmentVariable>? Type993 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDeploymentConfigurationDefaultResources? Type994 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDeploymentConfigurationDefaultResourcesLimits? Type995 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDeploymentConfigurationDefaultResourcesRequests? Type996 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IRunAiConfig? Type997 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IComputeCluster? Type998 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.INodePool>? Type999 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IComputePlugin>? Type1000 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EComputeConsumptionMethod? Type1001 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IComputeSettings? Type1002 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APICompute? Type1003 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IComputeContext>? Type1004 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageT? Type1005 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIComposition>? Type1006 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIPipeline>? Type1007 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>? Type1008 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>? Type1009 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ResourceExecution>? Type1010 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIDpk>? Type1011 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIApp>? Type1012 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APICompute>? Type1013 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIServiceDriver>? Type1014 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryString? Type1015 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIPipelineState? Type1016 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIPipelineState>? Type1017 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CycleRerunMethod? Type1018 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IRerunCycleOptions? Type1019 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.JsExecuteOptionsBatchQuery? Type1020 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.JsExecuteOptionsBatchQueryContext? Type1021 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IExecuteOptionsBatch? Type1022 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IRerunCycleBatchOptions? Type1023 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIPipelineTemplate2? Type1024 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIPipelineTemplateTemplate? Type1025 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIPipelineTemplate? Type1026 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APITemplateQuery? Type1027 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryStringTemplate? Type1028 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TemplateQuery? Type1029 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionLogs? Type1030 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PipelineExecutionLogs? Type1031 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ExecutionLogs>? Type1032 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPostPipeline? Type1033 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPipelineExecutionCount? Type1034 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IExecutionCount? Type1035 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.INodeExecutionCount? Type1036 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IExecutionCount>? Type1037 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IExecutionStatistics? Type1038 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.INodeExecutionStatistics? Type1039 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPipelineStatistics? Type1040 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IPipelineExecutionCount>? Type1041 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.INodeExecutionCount>? Type1042 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.INodeExecutionStatistics>? Type1043 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutePipelinePayload? Type1044 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecuteOptionsBatchQuery? Type1045 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecuteOptionsBatchQueryContext? Type1046 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecuteOptionsBatch? Type1047 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecuteOptions? Type1048 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.NodeDescriptor? Type1049 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CompositionStatusDescriptor? Type1050 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIPipeline? Type1051 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PipelineNodeCategory? Type1052 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Module? Type1053 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UiHook? Type1054 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PiperUiSlot? Type1055 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PackageType? Type1056 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PackageMetadata? Type1057 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIPackage? Type1058 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.Module>? Type1059 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.UiHook>? Type1060 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PiperUiSlot>? Type1061 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PackagesPage? Type1062 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIPackage>? Type1063 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.JobMetadata? Type1064 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.JobRuntime? Type1065 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.JobStatusEnum? Type1066 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.JobStatus? Type1067 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Job? Type1068 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialJob? Type1069 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionsPage? Type1070 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionsOrderByType? Type1071 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionsOrderByDirection? Type1072 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CommandError? Type1073 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CommandStatus? Type1074 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CommandStatusHistoryEntry? Type1075 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.HttpContext? Type1076 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CommandCtx? Type1077 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ChildrenCommandsProgress? Type1078 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.CommandError>? Type1079 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CommandsDomain? Type1080 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PiperSettingsCommands? Type1081 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.CommandStatusHistoryEntry>? Type1082 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PiperSettingsCommandsTrackingInfo? Type1083 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PiperSettingsCommandsRetry? Type1084 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIExecutionPatch? Type1085 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.WorkloadParams? Type1086 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIPostDpk? Type1087 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIDpk? Type1088 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DpkAttributeValueDefinition? Type1089 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DpkAttributeValueDefinitionIcon? Type1090 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DpkAttributeValueDefinitionColor? Type1091 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DpkAttributesDefinition? Type1092 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DpkAttributeValueDefinition>? Type1093 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PreviewsComponentsPatch? Type1094 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PreviewsComponentsPatchPipelineTemplate>? Type1095 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PreviewsComponentsPatchPipelineTemplate? Type1096 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIPatchDpk? Type1097 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AgentCtx? Type1098 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompute? Type1099 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialICompute? Type1100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPostComposition? Type1101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIComposition? Type1102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIPostApp? Type1103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIPatchApp? Type1104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PipelineType? Type1105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ITextSearch? Type1106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPipeline? Type1107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPipelineTemplate? Type1108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IVersion? Type1109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SettingsValueTypes? Type1110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PlatformEntityType? Type1111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SettingScope? Type1112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.PlatformEntityType?, global::Dataloop.SettingScopeType?>? Type1113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SettingScopeType? Type1114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<string, global::Dataloop.SettingScopeId?>? Type1115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SettingScopeId? Type1116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.SettingScopeRole?>? Type1117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SettingScopeRole? Type1118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SettingsTypes? Type1119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIFeatureFlag? Type1120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SettingsSectionNames? Type1121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIUserSetting? Type1122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IUserContext? Type1123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ResolverPayload? Type1124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateSettingRequest? Type1125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateFeatureFlagRequest? Type1126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateUserSettingRequest? Type1127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialSettingScope? Type1128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.PlatformEntityType?, global::Dataloop.PartialSettingScopeType?>? Type1129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialSettingScopeType? Type1130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<string, global::Dataloop.PartialSettingScopeId?>? Type1131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialSettingScopeId? Type1132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.PartialSettingScopeRole?>? Type1133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialSettingScopeRole? Type1134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PatchFeatureFlagRequest? Type1135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PatchUserSettingRequest? Type1136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIUserSettingOrAPIFeatureFlag? Type1137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIUserSetting, global::Dataloop.APIFeatureFlag>>? Type1138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIUserSetting, global::Dataloop.APIFeatureFlag>? Type1139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MigrationSpec? Type1140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MigrationSpecVariant2? Type1141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RemoveSettingTraceMigrationSpec? Type1142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RemoveSettingTraceMigrationSpecVariant2? Type1143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UIHours? Type1144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APICallResourceDescriptor? Type1145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APICallSourceDescriptor? Type1146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.APICallResourceDescriptor>? Type1147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APICallDescriptor? Type1148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.StorageModificationSourceDescriptor? Type1149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.StorageModificationDescriptor? Type1150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.StorageDatasetDescriptor? Type1151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.StorageDescriptor? Type1152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.StorageDatasetDescriptor>? Type1153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PodType? Type1154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FaasUsageServiceInstanceDescriptor? Type1155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FaasGlobalServiceDescriptor? Type1156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FaasUsageDescriptor? Type1157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.FaasUsageServiceInstanceDescriptor>? Type1158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.FaasGlobalServiceDescriptor>? Type1159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemsCount? Type1160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IngestedDatapointsDescriptor? Type1161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIUsageEntry? Type1162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AlertStatus? Type1163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIAlert? Type1164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FieldSort? Type1165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FieldSortField? Type1166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FieldSortDirection? Type1167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ResourceAuditEventType? Type1168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ResourceAuditLog? Type1169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ResourceAuditLogCtx? Type1170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AuditLogsCursorPage? Type1171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ResourceAuditLog>? Type1172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Address? Type1173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaxType? Type1174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaxData? Type1175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DBBillingAccount? Type1176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialBillingAccount? Type1177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialBillingAccountTaxData? Type1178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PaymentDriverType? Type1179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DBPaymentDriverConfiguration? Type1180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreditCard? Type1181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PaymentMethod? Type1182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ContactAddress? Type1183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ContactInfo? Type1184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LineItem? Type1185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.InvoiceStatus? Type1186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Currency? Type1187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PaymentDetails? Type1188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Invoice? Type1189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ContactInfo>? Type1190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.LineItem>? Type1191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.InvoiceBilledPeriod? Type1192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PaymentDetails>? Type1193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RangeOrFeatureTier? Type1194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RangeOrFeatureTierRange? Type1195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.OverQuota? Type1196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIBillableResource? Type1197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.RangeOrFeatureTier>? Type1198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BillingScope? Type1199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SubscriptionInput? Type1200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EditSubscriptionInput? Type1201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RenewSubscriptionInput? Type1202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPISubscription? Type1203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APISubscription>? Type1204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CustomSubscriptionInput? Type1205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SubscriptionUpgradeInput? Type1206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SubscriptionExtensionInput? Type1207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PaymentDriverTypes? Type1208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UsageLog? Type1209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ResourceUsage? Type1210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.UsageLog>? Type1211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UsageReport? Type1212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ResourceUsage>? Type1213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UsageResourcesReport? Type1214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.BillingResourceKey>? Type1215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AzureWebhookEvent? Type1216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AzureWebhookEventAction? Type1217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<string, global::Dataloop.AzureWebhookEventOperationRequestSource?>? Type1218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AzureWebhookEventOperationRequestSource? Type1219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AzureWebhookEventSubscription? Type1220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AzureWebhookEventSubscriptionTerm? Type1221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AzureWebhookEventSubscriptionPurchaser? Type1222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AzureWebhookEventSubscriptionBeneficiary? Type1223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ArchiveAnnotationToStorageRequest? Type1224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RestoreArchivedAnnotationToDBRequest? Type1225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetProjectsActiveCountersRequest? Type1226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetCountersForProjectRequest? Type1227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateApiKeyRequest? Type1228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ResolveTemplateRequest? Type1229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SetItemStatusBulkTaskRequest? Type1230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SetItemStatusBulkAssignmentRequest? Type1231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetAssignmentFieldsRequest? Type1232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryAuditLogsRequest? Type1233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateAlertRequest? Type1234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ListAccountAlertsRequest? Type1235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.InstallRequest? Type1236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UninstallRequest? Type1237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.PartialICompute, global::Dataloop.UpdateComputeRequest2>? Type1238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateComputeRequest2? Type1239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SchemaCleanupRequest? Type1240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetDatasetsByProjectIdsRequest? Type1241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ListExportHistoryRequest? Type1242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ListExportHistoryRequestSortOrder? Type1243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ListExportHistoryRequestSortBy? Type1244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.DQLResourceQuery, global::Dataloop.AnyOf<global::Dataloop.FilterQuery, global::Dataloop.UpdateQuery, global::Dataloop.DeleteQuery>?>? Type1245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.FilterQuery, global::Dataloop.UpdateQuery, global::Dataloop.DeleteQuery>? Type1246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryDatasetsRequest? Type1247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryDatasetsRequestTarget? Type1248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>? Type1249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RestoreDatasetRequest? Type1250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RemoveItemsByQueryRequest? Type1251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BulkUpdateMetadataRequest? Type1252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BullkGenerateAnnotationThumbnailsRequest? Type1253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BullkGenerateAnnotationThumbnailsRequestOptions? Type1254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateItemCollectionRequest? Type1255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddItemsToItemCollectionsRequest? Type1256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RemoveItemsFromItemCollectionsRequest? Type1257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RenameItemCollectionRequest? Type1258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.InvalidateAnnotationThumbnailsRequest? Type1259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.MoveItemsRequest, global::System.Collections.Generic.IList<string>>? Type1260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MoveItemsRequest? Type1261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIAnnotationRequest, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationRequest>>? Type1262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ArchiveDatasetItemAnnotationToStorageRequest? Type1263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RestoreArchivedDatasetItemAnnotationToDBRequest? Type1264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetFilteredDatasetLabelAggregationRequest? Type1265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetFilteredDatasetTypeAggregationRequest? Type1266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.ImportItemRequest>, global::Dataloop.ImportItemsToDatasetRequest>? Type1267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ImportItemRequest>? Type1268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ImportItemsToDatasetRequest? Type1269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SplitMlOperationRequest? Type1270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CheckStorageDriversIntegrationByIntegrationIdRequest? Type1271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.NackRequest? Type1272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PushProgressRequest? Type1273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateExecutionRequest? Type1274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.FeatureSet, global::System.Collections.Generic.IList<global::Dataloop.FeatureSet>>? Type1275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.FeatureSet>? Type1276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.FeatureVector, global::System.Collections.Generic.IList<global::Dataloop.FeatureVector>>? Type1277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.FeatureVector>? Type1278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddGroupMemberRequest? Type1279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateGroupOwnerRequest? Type1280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddSubGroupRequest? Type1281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ArchiveItemAnnotationToStorageRequest? Type1282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RestoreArchivedItemAnnotationToDBRequest? Type1283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.MetricRequest, global::System.Collections.Generic.IList<global::Dataloop.MetricRequest>>? Type1284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.MetricRequest>? Type1285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GenerateModelMetricsReportRequest? Type1286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelsExecutionsRequest? Type1287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelsServicesRequest? Type1288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.PartialCreateModelRequest, global::Dataloop.APICopyEnvironmentSpec>? Type1289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DeployModelRequest? Type1290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateModelDeploymentRequest? Type1291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExtractItemFeaturesRequest? Type1292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExtractItemFeaturesRequestConfig? Type1293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExtractItemFeaturesRequestInput? Type1294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EvaluateModelRequest? Type1295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EvaluateModelRequestConfig? Type1296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EvaluateModelRequestInput? Type1297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelPredictionRequest? Type1298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelPredictionRequestConfig? Type1299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelPredictionRequestInput? Type1300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TrainModelRequest? Type1301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.CreateOntologyPayloadV2, global::Dataloop.CreateOntologyPayload>? Type1302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DeleteAttributesRequest? Type1303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.UpdateLabelNodePayload>? Type1304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateOrgRequest? Type1305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PatchOrgRequest? Type1306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateIntegrationRequest? Type1307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddOrgMembersRequest? Type1308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PatchOrgMemberRequest? Type1309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateOrgPlanRequest? Type1310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.InstallRequest2? Type1311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UninstallRequest2? Type1312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LogsRequest? Type1313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryBillingMetricsRequest? Type1314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateProjectGuestRequest? Type1315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddOrgToGuestRequest? Type1316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PatchProjectRequest? Type1317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SetProjectAccountRequest? Type1318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddOrgToProjectRequest? Type1319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddGroupRequest? Type1320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateGroupRequest? Type1321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryEntitiesRequest? Type1322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.RecipeV2Input?, global::Dataloop.RecipeInput?>? Type1323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.PartialRecipePayloadV2, global::Dataloop.PartialRecipePayload>? Type1324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateScoresRequest? Type1325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.Score>? Type1326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SetDefaultRequest? Type1327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.GetGlobalServicesRequestItem>? Type1328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetGlobalServicesRequestItem? Type1329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.BaseReportMessage>? Type1330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RolloutServiceRequest? Type1331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.ResolverPayload, global::Dataloop.IUserContext>? Type1332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.PatchFeatureFlagRequest, global::Dataloop.PatchUserSettingRequest>? Type1333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DeleteSettingRequest? Type1334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetProjectsActiveCountersRequest2? Type1335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetCountersForProjectRequest2? Type1336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateUserOrgRequest? Type1337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIAccount>? Type1338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>? Type1339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<object, global::Dataloop.APICommand>? Type1340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.TaskRelativeInput>? Type1341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.APITask>? Type1342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIApiKey>? Type1343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateApiKeyResponse? Type1344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DpkAttributesDefinition>? Type1345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateResponse? Type1346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIApp, object>? Type1347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>? Type1348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.APIAssignment>? Type1349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIUsageEntry>? Type1350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIAlert>? Type1351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DBPaymentDriverConfiguration>? Type1352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PaymentMethod>? Type1353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APICommand, object>? Type1354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIDataset>? Type1355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetDatasetsByProjectIdsResponse? Type1356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ListExportHistoryResponse? Type1357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIExportHistory>? Type1358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>? Type1359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIAnnotation>? Type1360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIAnnotation, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotation>>? Type1361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>>? Type1362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.Dataset, global::Dataloop.APIDatasetSchema>? Type1363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APICommand, string>? Type1364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.Dataset>? Type1365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIDriverConfiguration>? Type1366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIExecution, global::Dataloop.PiperSettingsCommands>? Type1367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIExecution, global::Dataloop.APICommand>? Type1368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AuthUserAttributes>? Type1369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.Invoice>? Type1370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PublishModelMetricsResponse? Type1371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.Error>? Type1372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelsDatasetsCountResponse? Type1373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIModel, global::Dataloop.APICommand>? Type1374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIOrg>? Type1375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.GetAvailableIntegrationsResponseItemVariant1, global::Dataloop.GetAvailableIntegrationsResponseItemVariant2>>? Type1376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.GetAvailableIntegrationsResponseItemVariant1, global::Dataloop.GetAvailableIntegrationsResponseItemVariant2>? Type1377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetAvailableIntegrationsResponseItemVariant1? Type1378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.GetAvailableIntegrationsResponseItemVariant1Option>? Type1379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetAvailableIntegrationsResponseItemVariant1Option? Type1380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetAvailableIntegrationsResponseItemVariant2? Type1381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.GetAvailableIntegrationsResponseItemVariant2Option>? Type1382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetAvailableIntegrationsResponseItemVariant2Option? Type1383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIOrgUser>? Type1384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.QueryPipelineTableResponseItem>? Type1385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryPipelineTableResponseItem? Type1386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryPipelineTableResponseItemTemplate? Type1387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.APICommand>? Type1388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TerminateResponse? Type1389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PipelineExecutionLogs>? Type1390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.Plan>? Type1391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIBillableResource>? Type1392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIGuest>? Type1393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIMembership>, object>? Type1394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIMembership>? Type1395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.ClientContributor>, object>? Type1396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ClientContributor>? Type1397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIScore>? Type1398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryConfusionResponse? Type1399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetTaskScoresResponse? Type1400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetTaskAnnotationScoresResponse? Type1401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetTaskItemScoresResponse? Type1402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.GetGlobalServicesResponseItem>? Type1403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetGlobalServicesResponseItem? Type1404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.APIServiceStatus>? Type1405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIService, string>? Type1406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceStreamResponse? Type1407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetServiceIntegrationEnvResponse? Type1408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.GetServiceIntegrationEnvResponseEnvItem>? Type1409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetServiceIntegrationEnvResponseEnvItem? Type1410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>? Type1411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>>? Type1412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.UsageReport>? Type1413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.GetMyGroupProjectsResponseItem>? Type1414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetMyGroupProjectsResponseItem? Type1415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIUser, object>? Type1416 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIModality>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIDatasetFileItem>, global::System.Collections.Generic.List<global::Dataloop.APIDatasetDirectoryItem>>? ListType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIDatasetFileItem>? ListType3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIDatasetDirectoryItem>? ListType4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ReferenceQueryRef>? ListType5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ItemSystemMetadataTaskStatusLogItem>? ListType6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ResourceReference>? ListType7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ItemLink>? ListType8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.Modality>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.NoteMessage>? ListType11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Dataloop.Point>>? ListType12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.Point>? ListType13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIAnnotationRequest>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Dataloop.APIAnnotationEvent>>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIAnnotationEvent>? ListType16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DatasetDirectoryTree>? ListType17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIAnnotation, global::Dataloop.APIDataset, global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>>? ListType18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.RestoreAnnotationsRequestAnnotation>? ListType19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ItemRevision>? ListType20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.AnnotationTypeBox?, global::Dataloop.AnnotationTypeClass?, global::Dataloop.AnnotationTypeBinary?>>? ListType22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ITermConfiguration>? ListType23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.SchemaEntryInput>? ListType24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIFeatureSet>? ListType25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIFeatureVector>? ListType26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AggregateProjectVectorsCountResultItem>? ListType27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IndexDriver>? ListType28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APILabelTree>? ListType29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.CreateLabelPayloadTreeV1>? ListType30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.CreateLabelPayload>? ListType31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AttributeCreationPayload>? ListType32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>>? ListType33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ToolInstruction>? ListType34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.CustomActionTarget>? ListType35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.Example>? ListType36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.GoodExample>? ListType37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.CustomAction>? ListType38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.LabelTree>? ListType39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIInstruction>? ListType40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APICustomActionTarget>? ListType41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIBadExample>? ListType42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIGoodExample>? ListType43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APICustomAction>? ListType44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>>? ListType45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIAssignment>? ListType46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AssignmentWorkload>? ListType47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APILabelTreeNodeV2>? ListType48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.FilterQueryInputReferencesRef>? ListType49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIAttributeSection>? ListType50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIStructure>? ListType52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ItemAction>? ListType54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.TaskWorkload>? ListType55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APITask>? ListType56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.GroupCtx>? ListType57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIUser>, global::System.Collections.Generic.List<string>>? ListType58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIUser>? ListType59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIGroup>, global::System.Collections.Generic.List<string>>? ListType60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIGroup>? ListType61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIIntegration>, global::System.Collections.Generic.List<string>>? ListType62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIIntegration>? ListType63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIProject>, global::System.Collections.Generic.List<string>>? ListType64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIProject>? ListType65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.FeatureConstraint>? ListType66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIProjectGuest>, global::System.Collections.Generic.List<string>>? ListType67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIProjectGuest>? ListType68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIIntegrationMetadata>? ListType69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IntegrationMetadataBody>? ListType70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.BillingResource>? ListType71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APILogin>? ListType72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.EntityReference>? ListType73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>>? ListType74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ModelStatusLog>? ListType75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIModel>? ListType76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ExecutionStatusReport>? ListType77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ExecutionResource>? ListType78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIWebHook>? ListType80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.Panel>? ListType81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ServiceIntegration>? ListType82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PackageIO>? ListType83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DisplayScope>? ListType84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DLFunctionDefaultInputSpec>? ListType85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DLFunctionInputOptionsSpec>? ListType86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIExecution>? ListType87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APITrigger>? ListType88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.TriggerResourceInformationItem>? ListType89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIService>? ListType90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ServiceLogEntry>? ListType91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ServiceRuntimeStatus>? ListType92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DriverCondition>? ListType93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DriverNodeSelector>? ListType94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DriverToleration>? ListType95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DataloopPodType>? ListType96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.TriggerActionType>? ListType97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DLFunction>? ListType98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PackageRequirement>? ListType99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.Dictionary>? ListType100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ICompositionFilter>? ListType101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PortIO>? ListType102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PipelineNodeDescriptor>? ListType103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PipelineConnection>? ListType104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IStartNode>? ListType105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PipelineVariable>? ListType106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ICompositionDatasetStateDatasetAnnotation>? ListType107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIServiceCompositionElement>? ListType108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ICompositionTrigger>? ListType109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ICompositionPackage>? ListType110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ICompositionTask>? ListType111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APICompositionModel>? ListType112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ICompositionChannel>? ListType113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ICompositionPipelineTemplate>? ListType114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ICompositionDataset>? ListType115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Dataloop.PartialExecution>>? ListType116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PartialExecution>? ListType117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IPipelineNodeState>? ListType118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.INodeTransitionError>? ListType119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkComponentPanelSupportedSlot>? ListType120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkFilter>? ListType121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkComponentIntegrations>? ListType122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkComponentDataset>? ListType123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkPipelineTemplate>? ListType124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IPipelineNode>? ListType125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkComputeConfigs>? ListType126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkChannel>? ListType127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkComponentToolbars>? ListType128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkComponentService>? ListType129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkComponentTrigger>? ListType130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkComponentModule>? ListType131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkComponentModel>? ListType132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkComponentPanel>? ListType133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkDependency>? ListType134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.Toleration>? ListType135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IStorage>? ListType136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IClusterVolumeConfigMapItem>? ListType137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IClusterVolumeSecretItem>? ListType138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IClusterVolume>? ListType139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IClusterEnvironmentVariable>? ListType140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.INodePool>? ListType141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IComputePlugin>? ListType142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IComputeContext>? ListType143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIComposition>? ListType144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIPipeline>? ListType145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>? ListType146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ResourceExecution>? ListType147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIDpk>? ListType148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIApp>? ListType149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APICompute>? ListType150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIServiceDriver>? ListType151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIPipelineState>? ListType152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ExecutionLogs>? ListType153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IExecutionCount>? ListType154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IPipelineExecutionCount>? ListType155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.INodeExecutionCount>? ListType156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.INodeExecutionStatistics>? ListType157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.Module>? ListType158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.UiHook>? ListType159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PiperUiSlot>? ListType160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIPackage>? ListType161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.CommandError>? ListType162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.CommandStatusHistoryEntry>? ListType163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DpkAttributeValueDefinition>? ListType164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PreviewsComponentsPatchPipelineTemplate>? ListType165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIUserSetting, global::Dataloop.APIFeatureFlag>>? ListType166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.StorageDatasetDescriptor>? ListType167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.FaasUsageServiceInstanceDescriptor>? ListType168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.FaasGlobalServiceDescriptor>? ListType169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ResourceAuditLog>? ListType170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ContactInfo>? ListType171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.LineItem>? ListType172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PaymentDetails>? ListType173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.RangeOrFeatureTier>? ListType174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APISubscription>? ListType175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.UsageLog>? ListType176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ResourceUsage>? ListType177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.BillingResourceKey>? ListType178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.MoveItemsRequest, global::System.Collections.Generic.List<string>>? ListType179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIAnnotationRequest, global::System.Collections.Generic.List<global::Dataloop.APIAnnotationRequest>>? ListType180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.ImportItemRequest>, global::Dataloop.ImportItemsToDatasetRequest>? ListType181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ImportItemRequest>? ListType182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.FeatureSet, global::System.Collections.Generic.List<global::Dataloop.FeatureSet>>? ListType183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.FeatureSet>? ListType184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.FeatureVector, global::System.Collections.Generic.List<global::Dataloop.FeatureVector>>? ListType185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.FeatureVector>? ListType186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.MetricRequest, global::System.Collections.Generic.List<global::Dataloop.MetricRequest>>? ListType187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.MetricRequest>? ListType188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.UpdateLabelNodePayload>? ListType189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.Score>? ListType190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.GetGlobalServicesRequestItem>? ListType191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.BaseReportMessage>? ListType192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIAccount>? ListType193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.TaskRelativeInput>? ListType194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIApiKey>? ListType195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DpkAttributesDefinition>? ListType196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APICommand, global::System.Collections.Generic.List<global::Dataloop.APIAssignment>>? ListType197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIUsageEntry>? ListType198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIAlert>? ListType199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DBPaymentDriverConfiguration>? ListType200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PaymentMethod>? ListType201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIDataset>? ListType202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIExportHistory>? ListType203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIAnnotation>? ListType204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIAnnotation, global::System.Collections.Generic.List<global::Dataloop.APIAnnotation>>? ListType205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>>? ListType206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIDriverConfiguration>? ListType207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AuthUserAttributes>? ListType208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.Invoice>? ListType209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIOrg>? ListType210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.GetAvailableIntegrationsResponseItemVariant1, global::Dataloop.GetAvailableIntegrationsResponseItemVariant2>>? ListType211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.GetAvailableIntegrationsResponseItemVariant1Option>? ListType212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.GetAvailableIntegrationsResponseItemVariant2Option>? ListType213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIOrgUser>? ListType214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.QueryPipelineTableResponseItem>? ListType215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PipelineExecutionLogs>? ListType216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.Plan>? ListType217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIBillableResource>? ListType218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIGuest>? ListType219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIMembership>, object>? ListType220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIMembership>? ListType221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.ClientContributor>, object>? ListType222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ClientContributor>? ListType223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIScore>? ListType224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.GetGlobalServicesResponseItem>? ListType225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.GetServiceIntegrationEnvResponseEnvItem>? ListType226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>>? ListType227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.UsageReport>? ListType228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.GetMyGroupProjectsResponseItem>? ListType229 { get; set; }
    }
}