
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
        public global::Dataloop.UpdateDriversIntegrationResult? Type269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.UpdateDriversIntegrationResultError>? Type270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateDriversIntegrationResultError? Type271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIFeatureSet? Type272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIFeatureSet? Type273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIFeatureSet>? Type274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FeatureSetEntityType? Type275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FeatureSet? Type276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialFeatureSet? Type277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIFeatureVector? Type278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FeatureVector? Type279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIFeatureVector? Type281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIFeatureVector>? Type282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AggregateProjectVectorsCountResultItem>? Type283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AggregateProjectVectorsCountResultItem? Type284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AggregateProjectVectorsCountInput? Type285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ProjectStorageRequest? Type286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EditItemsStressInput? Type287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IUploadItemsBenchmarkInput? Type288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IndexDriver>? Type289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BenchmarkIngestionStrategyType? Type290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GeneratedDatasetConfig? Type291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddItemsOperationInput? Type292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddAnnotationsOperationInput? Type293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UploadItemsBenchmarkCommandV2Input? Type294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UploadItemsBenchmarkCommandV2InputUploadFileConfig? Type295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BenchmarkOptions? Type296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BenchmarkOptionsExportType? Type297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SetTaskRefsBenchmarkInput? Type298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SetTaskRefsBenchmarkInputOperation? Type299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SetTaskRefsStatusBenchmarkInput? Type300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BulkCreateAnnotationsBenchmarkInput? Type301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverReadBenchmarkOperationInput? Type302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverReadBenchmarkOperationInputScenarioDetails? Type303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverWriteBenchmarkOperationInput? Type304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverWriteBenchmarkOperationInputScenarioDetails? Type305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIOntologyV2? Type306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APILabelTree? Type307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APILabelTree>? Type308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APILabel? Type309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APILabelDisplayImage? Type310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APILabelDisplayData? Type311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIOntology? Type312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateOntologyPayloadV2? Type313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LabelDisplayImage? Type314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LabelDisplayData? Type315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateLabelPayloadV1? Type316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateLabelPayloadTreeV1? Type317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.CreateLabelPayloadTreeV1>? Type318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateOntologyPayload? Type319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIOntologyConfigurationV2? Type320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateLabelPayload? Type321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddLabelsNodePayload? Type322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.CreateLabelPayload>? Type323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateLabelsNodePayload? Type324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AttributeType? Type325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AttributeCreationPayload? Type326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpsertRequestPayloadAttributeCreationPayload? Type327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AttributeCreationPayload>? Type328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIOntologyCursor? Type329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>>? Type330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>? Type331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APILabelScopeV2? Type332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIToolOptionsV2? Type333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RecipeType? Type334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIRecipeV2? Type335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIRecipeV2Ontology? Type336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.APIToolOptionsV2>? Type337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIRecipe? Type338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LabelScopeV2? Type339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntology? Type340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntologyOntology? Type341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ToolOptions? Type342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Metadata2? Type343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RecipeV2Context? Type344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AuthZBlockRecipeV2Context? Type345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.RecipeV2Context>? Type346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialRecipeV2? Type347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialRecipeV2Ontology? Type348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.ToolOptions>? Type349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RecipeV2Input? Type350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PickRecipeTitleOrProjectIdsOrOntologyIds? Type351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.InstructionAction? Type352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.InstructionScope? Type353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ToolInstruction? Type354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.ToolInstructionOptions, global::Dataloop.Dictionary>? Type355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ToolInstructionOptions? Type356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GoodExample? Type357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ToolInstruction>? Type358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Example? Type359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CustomAction? Type360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.CustomActionTarget>? Type361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CustomActionTarget? Type362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CustomActionControls? Type363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RecipeContext? Type364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AuthZBlockRecipeContext? Type365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.RecipeContext>? Type366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialRecipe? Type367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialRecipeExamples? Type368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.Example>? Type369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.GoodExample>? Type370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.CustomAction>? Type371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RecipeInput? Type372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClientLabel? Type373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LabelTree? Type374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.LabelTree>? Type375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CloneRecipePayload? Type376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialRecipePayloadV2? Type377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIInstruction? Type378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIGoodExample? Type379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIInstruction>? Type380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIBadExample? Type381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APICustomAction? Type382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APICustomActionTarget>? Type383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APICustomActionTarget? Type384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APICustomActionControls? Type385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialRecipePayload? Type386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialRecipePayloadExamples? Type387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIBadExample>? Type388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIGoodExample>? Type389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APICustomAction>? Type390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIRecipeV2OrAPIRecipe? Type391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>>? Type392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>? Type393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AssignmentStatus? Type394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemStatus? Type395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIAssignment? Type396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIAssignmentRemoveItemsProcess? Type397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIAssignmentRedistributeProcess? Type398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialAssignmentPayload? Type399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIAssignmentCursor? Type400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>? Type401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ReassignAssignmentPayload? Type402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AssignmentWorkload? Type403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RedistributeAssignmentPayload? Type404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AssignmentWorkload>? Type405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BatchAssignmentPayload? Type406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AssignmentStatusPayload? Type407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AssignmentMetadata? Type408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.Dictionary, global::Dataloop.AssignmentMetadataSystem>? Type409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AssignmentMetadataSystem? Type410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AssignmentMetadataSystemType? Type411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaskType? Type412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AssignmentContext? Type413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AuthZBlockAssignmentContext? Type414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.AssignmentContext>? Type415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialAssignment? Type416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialAssignmentRedistributeProcess? Type417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialAssignmentRemoveItemsProcess? Type418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APILabelV2? Type419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APILabelTreeNodeV2? Type420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPILabelTreeNodeV2? Type421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APILabelTreeNodeV2>? Type422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FilterQueryInput? Type423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FilterQueryInputContext? Type424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FilterQueryInputReferences? Type425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.FilterQueryInputReferencesRef>? Type426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FilterQueryInputReferencesRef? Type427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateLabelNodePayload? Type428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIAttributeSection? Type429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateAttributePayload? Type430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateAttributePayloadScope? Type431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIAttributeSection? Type432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIAttributeSection>? Type433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIUpdateAttributePayload? Type434 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIUpdateAttributePayloadScope? Type435 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIStructure? Type436 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type437 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateStructurePayload? Type438 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIUpdateStructurePayload? Type439 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIStructure? Type440 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIStructure>? Type441 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ScoreType? Type442 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIScore? Type443 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIScoreContext? Type444 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Score? Type445 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ScoreContext? Type446 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ScoreParameters? Type447 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ScoreParametersScore? Type448 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ScoreParametersScoreContext? Type449 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type450 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ScoreParametersOptions? Type451 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DeleteTaskItemScoresPayload? Type452 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DeleteTaskItemScoresPayloadContext? Type453 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APITaskSpec? Type454 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APISpawnTaskSpec? Type455 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaskStatus? Type456 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemAction? Type457 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Description? Type458 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APITask? Type459 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>? Type460 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ItemAction>? Type461 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaskWorkload? Type462 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryFilter? Type463 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryFilterContext? Type464 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QualityTaskTypes? Type465 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.InstructionsDocumentMode? Type466 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialTaskInstructionsDocumentDetails? Type467 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaskMetadata? Type468 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.Dictionary, global::Dataloop.TaskMetadataSystem>? Type469 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaskMetadataSystem? Type470 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.TaskWorkload>? Type471 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PickDescriptionContent? Type472 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaskPayload? Type473 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaskPayloadCheckIfExist? Type474 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddToTaskPayload? Type475 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RemoveFromTaskPayload? Type476 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialTaskPayload? Type477 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaskContributorsAction? Type478 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateContributorsPayload? Type479 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APITaskCursor? Type480 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APITask>? Type481 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaskRelativeInput? Type482 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaskQueueDetails? Type483 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DeleteTaskPayload? Type484 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAny? Type485 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APITaskCounters? Type486 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.WorkflowsCounters? Type487 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GroupCtx? Type488 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIUser? Type489 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.GroupCtx>? Type490 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIOrg, string>? Type491 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIOrg? Type492 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIUserGuest? Type493 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Role? Type494 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIUser>, global::System.Collections.Generic.IList<string>>? Type495 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIUser>? Type496 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIGroup>, global::System.Collections.Generic.IList<string>>? Type497 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIGroup>? Type498 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIGroup? Type499 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIUser, string>? Type500 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIAccount, string>? Type501 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIAccount? Type502 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.OrgPlans? Type503 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIIntegration>, global::System.Collections.Generic.IList<string>>? Type504 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIIntegration>? Type505 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIIntegration? Type506 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIProject>, global::System.Collections.Generic.IList<string>>? Type507 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIProject>? Type508 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIProject? Type509 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FeatureConstraint? Type510 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.FeatureConstraint>? Type511 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIProjectGuest>, global::System.Collections.Generic.IList<string>>? Type512 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIProjectGuest>? Type513 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIProjectGuest? Type514 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIProject, string>? Type515 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIIntegrationMetadata>? Type516 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIIntegrationMetadata? Type517 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIIntegration, string>? Type518 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateAccountRequest? Type519 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIGoogleMarketplaceAccount? Type520 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EditAccountRequest? Type521 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AlertTier? Type522 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.OrgRole? Type523 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RoleEntry? Type524 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.Role?, global::Dataloop.OrgRole?>? Type525 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateBotPayload? Type526 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateGroupPayload? Type527 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PatchGroupPayload? Type528 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DLEntityType? Type529 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AuthUserAttributes? Type530 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.OrgSize? Type531 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.OrgIndustry? Type532 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIOrgUser? Type533 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.OrgRole?, string>? Type534 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIOrgDomain? Type535 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IntegrationType2? Type536 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IKeyValueMetadata? Type537 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IS3ApiMetadata? Type538 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IntegrationTypeMetadata? Type539 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IntegrationMetadataBody? Type540 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IntegrationBody? Type541 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IntegrationMetadataBody>? Type542 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IntegrationBodyCredentials? Type543 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BillingResourceKey? Type544 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MetricGroup? Type545 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BillingResource? Type546 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Plan? Type547 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.BillingResource>? Type548 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BillingPeriod? Type549 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BillingStatus? Type550 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ScopeType? Type551 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APISubscription? Type552 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APISubscriptionScope? Type553 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GuestType? Type554 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIGuest? Type555 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.GuestType?, string>? Type556 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateGuestPayload? Type557 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateProjectPayload? Type558 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIMembership? Type559 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.Role?, string, global::Dataloop.APIMembershipRole?>? Type560 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIMembershipRole? Type561 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UserInterestType? Type562 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddMembersBatchPayload? Type563 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ClientContributor? Type564 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ClientContributorGuest? Type565 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddMemberPayload? Type566 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PatchMemberPayload? Type567 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateMyDetailsPayload? Type568 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIHashUser? Type569 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ApiKeyType? Type570 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIApiKey? Type571 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APILogin? Type572 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPILogin? Type573 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APILogin>? Type574 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LoginsLogQuery? Type575 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LoginsLogQueryOrder? Type576 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LoginsLogQueryOrderBy? Type577 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EntityScopeLevel? Type578 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelStatus? Type579 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIModelConfiguration? Type580 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<double?, string>? Type581 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelInputType? Type582 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelOutputType? Type583 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelOutputTypeVariant2? Type584 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelOutputTypeVariant4? Type585 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ArtifactType? Type586 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemArtifact? Type587 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LocalArtifact? Type588 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EntityContext? Type589 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelOperationMetadata? Type590 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIModelMetadataSubsets? Type591 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIModelMetadataAnnotationsSubsets? Type592 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ReferenceType? Type593 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EntityReference? Type594 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.NodeMlType? Type595 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIModelMetadataSystem? Type596 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.EntityReference>? Type597 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIModelMetadataSystemMlType? Type598 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIModelMetadataSystemCloneCommand? Type599 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIModelMetadataSystemEmbedDatasets? Type600 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIModelMetadataSystemReloadServices? Type601 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIModelMetadata? Type602 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IAppDefinition? Type603 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelStatusLog? Type604 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIModel? Type605 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>>? Type606 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>? Type607 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ModelStatusLog>? Type608 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPISetting? Type609 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIModel>? Type610 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateModelRequest? Type611 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PatchModelRequest? Type612 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelOperationTypes? Type613 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryModel? Type614 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionStatus? Type615 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionStatusReport? Type616 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionStatusName? Type617 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionPipelineStateReference? Type618 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionModel? Type619 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EventResourceType? Type620 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemStatusEvent? Type621 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemStatusEventStatus? Type622 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionEventContext? Type623 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ResourceType? Type624 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDate? Type625 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.JssdkDictionary? Type626 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Execution? Type627 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionFeedbackQueue? Type628 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ExecutionStatusReport>? Type629 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionPipeline? Type630 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AuthZBlockExecutionContext? Type631 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ExecutionResource>? Type632 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionResource? Type633 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionMode? Type634 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionSyncReplyTo? Type635 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionHook? Type636 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionPhase? Type637 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.OnResetAction? Type638 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialAPIEmbedDatasetsSpec? Type639 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialAPIEmbedDatasetsSpecConfig? Type640 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialCreateModelRequest? Type641 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APICopyEnvironmentSpec? Type642 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.ModelJoinMap2>? Type643 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelJoinMap2? Type644 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PrecisionRecallInputRequest? Type645 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Error? Type646 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LineData? Type647 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MatrixData? Type648 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type649 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SummaryData? Type650 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MetricData? Type651 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MetricRequest? Type652 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PrivateRegistry? Type653 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceDriver? Type654 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AutoscalersDriverZombies? Type655 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIWebHook? Type656 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.WebHooksPage? Type657 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIWebHook>? Type658 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateWebHookDTO? Type659 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateWebHookDTOHttpMethod? Type660 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateWebHookDTO? Type661 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateWebHookDTOHttpMethod? Type662 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceRuntime? Type663 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceVersions? Type664 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Panel? Type665 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IServiceAppConfig? Type666 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceType? Type667 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CrashloopAction? Type668 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CrashloopReason? Type669 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Crashloop? Type670 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceModeType? Type671 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceMode? Type672 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EComputeConsumptionMethod? Type673 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SystemRefs? Type674 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceMetadata? Type675 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.ServiceMetadataUser, global::Dataloop.Dictionary>? Type676 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceMetadataUser? Type677 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceMetadataMl? Type678 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.ServiceMetadataSystem, global::Dataloop.SystemRefs, global::Dataloop.Dictionary>? Type679 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceMetadataSystem? Type680 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IServiceGeneralSettings? Type681 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceIntegration? Type682 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIService? Type683 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.Panel>? Type684 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ServiceIntegration>? Type685 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PackageResourceType? Type686 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionHookValueFrom? Type687 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionHookType? Type688 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PackageIO? Type689 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PackageIOIntegration? Type690 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UiBindingResource? Type691 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UiBindingPanel? Type692 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DisplayScope? Type693 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionPostActionType? Type694 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionPostAction? Type695 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DLFunctionDefaultInputSpec? Type696 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DLFunctionInputOptionsSpec? Type697 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DLFunction? Type698 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PackageIO>? Type699 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DisplayScope>? Type700 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DLFunctionDefaultInputSpec>? Type701 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DLFunctionInputOptionsSpec>? Type702 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPipelineExecution? Type703 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIExecution? Type704 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIExecutionSyncReplyTo? Type705 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UiSlot? Type706 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.ActivitiesDescriptor2>? Type707 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ActivitiesDescriptor2? Type708 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.ActivitiesDescriptorFunctions2>? Type709 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ActivitiesDescriptorFunctions2? Type710 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIExecution>? Type711 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TriggerType? Type712 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EntityReferenceMetadata? Type713 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APITrigger? Type714 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TriggersPage? Type715 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APITrigger>? Type716 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateTriggerRequest? Type717 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TriggerResourceInformationItem? Type718 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TriggerResourceInformationPage? Type719 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.TriggerResourceInformationItem>? Type720 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TriggerResourceInformationQuery? Type721 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AgentNotificationPayload? Type722 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AgentNotificationPayloadAgentInfo? Type723 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ECacheMode? Type724 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FaaSCacheSize? Type725 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FaaSCacheType? Type726 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICacheRunner? Type727 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICacheOptions? Type728 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICacheOptionsOrg? Type729 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServicesPage? Type730 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIService>? Type731 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIServicePatch? Type732 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceLogLevel? Type733 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceLogEntry? Type734 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceLogsPage? Type735 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ServiceLogEntry>? Type736 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LogsListDirection? Type737 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LogQuery? Type738 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ReplicaStatus? Type739 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIReplicaStatusUpdate? Type740 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ReplicaReason? Type741 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceRuntimeStatus? Type742 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIServiceStatus? Type743 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ServiceRuntimeStatus>? Type744 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EDebugOptionsStatus? Type745 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DebugSession? Type746 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ReportType? Type747 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BaseReportMessage? Type748 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IServiceScaler? Type749 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceDriverType? Type750 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IComputeContext? Type751 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DataloopPodType? Type752 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverCondition? Type753 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverToleration? Type754 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverTolerationConditions? Type755 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DriverCondition>? Type756 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverNodeSelector? Type757 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DriverNodeSelectorConditions? Type758 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CacheRunner? Type759 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ComputeMetadata? Type760 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ComputeMetadataVariant2? Type761 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ComputeMetadataVariant2ServeAgentGateway? Type762 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DriverNodeSelector>? Type763 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DriverToleration>? Type764 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DataloopPodType>? Type765 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIServiceDriver? Type766 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CompositionElementStatus? Type767 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIServiceCompositionElement? Type768 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIServiceCompositionElementState? Type769 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CompositionStatus? Type770 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionError? Type771 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionErrorContext? Type772 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TriggerResourceType? Type773 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TriggerActionType? Type774 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TriggerOperationType? Type775 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TriggerOperation? Type776 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionTrigger? Type777 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionTriggerSpec? Type778 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.TriggerActionType>? Type779 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ECompositionPackageStatus? Type780 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialModule? Type781 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DLFunction>? Type782 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PackageConfigType? Type783 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PackageRequirementOperator? Type784 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PackageRequirement? Type785 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CodebaseType? Type786 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Codebase? Type787 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionPackage? Type788 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionPackageState? Type789 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PackageRequirement>? Type790 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionTask? Type791 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionTaskState? Type792 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelConfiguration? Type793 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IModel? Type794 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.Dictionary>? Type795 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionElementState? Type796 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceConfig? Type797 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APICompositionModel? Type798 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ChannelType? Type799 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CompositionChannelStatus? Type800 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.NotificationEntityContext? Type801 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FilterTarget? Type802 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.NotificationEventContext? Type803 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionFilter? Type804 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionFilterState? Type805 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionChannel? Type806 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionChannelMetadata? Type807 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionChannelState? Type808 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionFilter>? Type809 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TemplateKind? Type810 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.INodeConfig? Type811 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.INodeConfigPackage? Type812 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.NodeNamespace? Type813 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PortIO? Type814 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.NodeType? Type815 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PipelineNodeDescriptor? Type816 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PortIO>? Type817 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PipelineNodeSource? Type818 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PipelineNodeTarget? Type819 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PipelineConnection? Type820 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.StartNodeType? Type821 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ITriggerSpec? Type822 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ITriggerSpecSpec? Type823 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IStartNode? Type824 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ResumePipelineOption? Type825 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPipelineSettings? Type826 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPipelineSettingsLastUpdate? Type827 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PipelineVariable? Type828 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PipelineFromTemplateState? Type829 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionPipelineTemplate? Type830 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PipelineNodeDescriptor>? Type831 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PipelineConnection>? Type832 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IStartNode>? Type833 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PipelineVariable>? Type834 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionPipelineTemplateTemplate? Type835 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionPipelineTemplateState? Type836 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionDatasetState? Type837 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionDatasetStateDataset? Type838 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionDatasetStateDatasetIndexDriver? Type839 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionDatasetStateDatasetShareLevel? Type840 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionDatasetStateDatasetExport? Type841 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type842 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionDatasetStateDatasetAnnotation>? Type843 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionDatasetStateDatasetAnnotation? Type844 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TextSearch? Type845 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MqDetails? Type846 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceContext? Type847 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AuthZBlockServiceContext? Type848 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.ServiceContext>? Type849 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialService? Type850 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DpkDatasetOntologyType? Type851 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionDataset? Type852 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionDatasetOntology? Type853 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompositionDatasetInvoke? Type854 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIComposition? Type855 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIServiceCompositionElement>? Type856 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.ICompositionError, string>? Type857 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionTrigger>? Type858 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionPackage>? Type859 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionTask>? Type860 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APICompositionModel>? Type861 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionChannel>? Type862 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionPipelineTemplate>? Type863 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionDataset>? Type864 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIPipeline? Type865 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIPipelineTemplate? Type866 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionContext? Type867 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.ExecutionContext>? Type868 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialExecution? Type869 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<string, double?>? Type870 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialExecutionSyncReplyTo? Type871 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ENodeStatus? Type872 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPipelineNodeState? Type873 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EPipelineStatus? Type874 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.INodeTransitionError? Type875 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIPipelineState? Type876 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Dataloop.PartialExecution>>? Type877 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PartialExecution>? Type878 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IPipelineNodeState>? Type879 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.INodeTransitionError>? Type880 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPipelineState? Type881 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<double?, global::System.Collections.Generic.Dictionary<string, double>>? Type882 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ResourceExecution? Type883 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EDpkScope? Type884 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkMetadata? Type885 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkMetadataCommands? Type886 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IAppContext? Type887 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkInitialContext? Type888 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentPanel? Type889 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentPanelSupportedSlot>? Type890 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentPanelSupportedSlot? Type891 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentModel? Type892 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentModelComputeConfigs? Type893 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.JsServiceVersions? Type894 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentModule? Type895 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EComponentServiceOperation? Type896 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentTrigger? Type897 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentTriggerSpec? Type898 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentService? Type899 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentToolbars? Type900 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FilterFrequencyType? Type901 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FilterFrequency? Type902 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkFilter? Type903 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkChannel? Type904 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkChannelMetadata? Type905 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkFilter>? Type906 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComputeConfigs? Type907 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.InvokeType? Type908 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ToolbarInvoke? Type909 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CustomNodeScope? Type910 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IInvoke? Type911 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPipelineNode? Type912 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkPipelineTemplate? Type913 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkPipelineTemplateTemplate? Type914 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentDataset? Type915 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentDatasetOntology? Type916 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentDatasetInvoke? Type917 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentIntegrations? Type918 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DpkComponents? Type919 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentIntegrations>? Type920 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentDataset>? Type921 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkPipelineTemplate>? Type922 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IPipelineNode>? Type923 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComputeConfigs>? Type924 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkChannel>? Type925 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentToolbars>? Type926 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentService>? Type927 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentTrigger>? Type928 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentModule>? Type929 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentModel>? Type930 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkComponentPanel>? Type931 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EComponentElementType? Type932 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkPipelineNode? Type933 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkComponentElementSpec? Type934 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IComponentElement? Type935 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>? Type936 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDpkDependency? Type937 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.DpkComponents, global::System.Collections.Generic.Dictionary<string, global::Dataloop.IComponentElement>>? Type938 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IDpkDependency>? Type939 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIDpk? Type940 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EAppScope? Type941 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialAPIDpk? Type942 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PickAPIDpkDependencies? Type943 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CustomInstallation? Type944 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CustomInstallationVariant2? Type945 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AppCommandsReference? Type946 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AppMetadata? Type947 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AppMetadataVariant2? Type948 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AppMetadataVariant2System? Type949 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IAppGeneralSettings? Type950 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIApp? Type951 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EComputeType? Type952 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EComputeStatus? Type953 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EClusterProvider? Type954 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Toleration? Type955 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.INodePoolDeploymentResources? Type956 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.INodePoolDeploymentResourcesRequests? Type957 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.INodePoolDeploymentResourcesLimits? Type958 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.INodePool? Type959 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.Toleration>? Type960 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EComputePlugin? Type961 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IExternalMonitoringConfig? Type962 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IHpaControllerConfig? Type963 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EStorageType? Type964 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IStorage? Type965 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IStorageDriverConfig? Type966 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IStorage>? Type967 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IComputeNfsPluginConfig? Type968 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.KubernetesServiceType? Type969 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2>? Type970 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ComputePluginResourceManifests2? Type971 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ComputePluginResourceManifestsSpec? Type972 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ComputePluginResourceManifestsSpecResources? Type973 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ComputePluginSpec? Type974 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ComputePluginSpecVariant2? Type975 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IComputePlugin? Type976 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.IExternalMonitoringConfig, global::Dataloop.IHpaControllerConfig, global::Dataloop.Dictionary, global::Dataloop.IStorageDriverConfig, global::Dataloop.IComputeNfsPluginConfig>? Type977 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IComputeAuthentication? Type978 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IComputeAuthenticationIntegration? Type979 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterVolume? Type980 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterVolumePersistentVolumeClaim? Type981 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterVolumeHostPath? Type982 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterVolumeConfigMap? Type983 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IClusterVolumeConfigMapItem>? Type984 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterVolumeConfigMapItem? Type985 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterVolumeSecret? Type986 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IClusterVolumeSecretItem>? Type987 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterVolumeSecretItem? Type988 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterVolumeNfs? Type989 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDeploymentSecurityContext? Type990 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterEnvironmentVariable? Type991 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterEnvironmentVariableValueFrom? Type992 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterEnvironmentVariableValueFromConfigMapKeyRef? Type993 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterEnvironmentVariableValueFromSecretKeyRef? Type994 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IClusterEnvironmentVariableValueFromFieldRef? Type995 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IComputeRegistry? Type996 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDeploymentConfiguration? Type997 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IClusterVolume>? Type998 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IClusterEnvironmentVariable>? Type999 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDeploymentConfigurationDefaultResources? Type1000 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDeploymentConfigurationDefaultResourcesLimits? Type1001 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IDeploymentConfigurationDefaultResourcesRequests? Type1002 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IRunAiConfig? Type1003 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IComputeCluster? Type1004 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.INodePool>? Type1005 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IComputePlugin>? Type1006 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IComputeSettings? Type1007 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APICompute? Type1008 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IComputeContext>? Type1009 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageT? Type1010 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIComposition>? Type1011 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIPipeline>? Type1012 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>? Type1013 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>? Type1014 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ResourceExecution>? Type1015 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIDpk>? Type1016 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIApp>? Type1017 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APICompute>? Type1018 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIServiceDriver>? Type1019 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryString? Type1020 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIPipelineState? Type1021 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIPipelineState>? Type1022 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CycleRerunMethod? Type1023 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IRerunCycleOptions? Type1024 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.JsExecuteOptionsBatchQuery? Type1025 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.JsExecuteOptionsBatchQueryContext? Type1026 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IExecuteOptionsBatch? Type1027 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IRerunCycleBatchOptions? Type1028 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIPipelineTemplate2? Type1029 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIPipelineTemplateTemplate? Type1030 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIPipelineTemplate? Type1031 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APITemplateQuery? Type1032 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryStringTemplate? Type1033 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TemplateQuery? Type1034 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionLogs? Type1035 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PipelineExecutionLogs? Type1036 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ExecutionLogs>? Type1037 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPostPipeline? Type1038 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPipelineExecutionCount? Type1039 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IExecutionCount? Type1040 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.INodeExecutionCount? Type1041 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IExecutionCount>? Type1042 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IExecutionStatistics? Type1043 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.INodeExecutionStatistics? Type1044 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPipelineStatistics? Type1045 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.IPipelineExecutionCount>? Type1046 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.INodeExecutionCount>? Type1047 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.INodeExecutionStatistics>? Type1048 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PipelineType? Type1049 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ITextSearch? Type1050 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialIPipeline? Type1051 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialIPipelineTemplate? Type1052 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PipelineVersionListItem? Type1053 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPagePipelineVersionListItem? Type1054 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PipelineVersionListItem>? Type1055 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIPipelineVersion? Type1056 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutePipelinePayload? Type1057 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecuteOptionsBatchQuery? Type1058 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecuteOptionsBatchQueryContext? Type1059 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecuteOptionsBatch? Type1060 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecuteOptions? Type1061 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.NodeDescriptor? Type1062 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CompositionStatusDescriptor? Type1063 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIPipeline? Type1064 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PipelineNodeCategory? Type1065 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Module? Type1066 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UiHook? Type1067 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PiperUiSlot? Type1068 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PackageType? Type1069 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PackageMetadata? Type1070 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIPackage? Type1071 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.Module>? Type1072 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.UiHook>? Type1073 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PiperUiSlot>? Type1074 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PackagesPage? Type1075 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIPackage>? Type1076 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.JobMetadata? Type1077 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.JobRuntime? Type1078 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.JobStatusEnum? Type1079 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.JobStatus? Type1080 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Job? Type1081 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialJob? Type1082 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionsPage? Type1083 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionsOrderByType? Type1084 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExecutionsOrderByDirection? Type1085 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CommandError? Type1086 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CommandStatus? Type1087 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CommandStatusHistoryEntry? Type1088 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.HttpContext? Type1089 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CommandCtx? Type1090 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ChildrenCommandsProgress? Type1091 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.CommandError>? Type1092 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CommandsDomain? Type1093 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PiperSettingsCommands? Type1094 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.CommandStatusHistoryEntry>? Type1095 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PiperSettingsCommandsTrackingInfo? Type1096 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PiperSettingsCommandsRetry? Type1097 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIExecutionPatch? Type1098 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.WorkloadParams? Type1099 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIPostDpk? Type1100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIDpk? Type1101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DpkAttributeValueDefinition? Type1102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DpkAttributeValueDefinitionIcon? Type1103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DpkAttributeValueDefinitionColor? Type1104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DpkAttributesDefinition? Type1105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DpkAttributeValueDefinition>? Type1106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PreviewsComponentsPatch? Type1107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PreviewsComponentsPatchPipelineTemplate>? Type1108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PreviewsComponentsPatchPipelineTemplate? Type1109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIPatchDpk? Type1110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AgentCtx? Type1111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ICompute? Type1112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialICompute? Type1113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPostComposition? Type1114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIComposition? Type1115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIPostApp? Type1116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIPatchApp? Type1117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPipeline? Type1118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IPipelineTemplate? Type1119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IVersion? Type1120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SettingsValueTypes? Type1121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PlatformEntityType? Type1122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SettingScope? Type1123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.PlatformEntityType?, global::Dataloop.SettingScopeType?>? Type1124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SettingScopeType? Type1125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<string, global::Dataloop.SettingScopeId?>? Type1126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SettingScopeId? Type1127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.SettingScopeRole?>? Type1128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SettingScopeRole? Type1129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SettingsTypes? Type1130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIFeatureFlag? Type1131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SettingsSectionNames? Type1132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIUserSetting? Type1133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IUserContext? Type1134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ResolverPayload? Type1135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateSettingRequest? Type1136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateFeatureFlagRequest? Type1137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateUserSettingRequest? Type1138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialSettingScope? Type1139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.PlatformEntityType?, global::Dataloop.PartialSettingScopeType?>? Type1140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialSettingScopeType? Type1141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<string, global::Dataloop.PartialSettingScopeId?>? Type1142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialSettingScopeId? Type1143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.PartialSettingScopeRole?>? Type1144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialSettingScopeRole? Type1145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PatchFeatureFlagRequest? Type1146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PatchUserSettingRequest? Type1147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPIUserSettingOrAPIFeatureFlag? Type1148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIUserSetting, global::Dataloop.APIFeatureFlag>>? Type1149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIUserSetting, global::Dataloop.APIFeatureFlag>? Type1150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MigrationSpec? Type1151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MigrationSpecVariant2? Type1152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RemoveSettingTraceMigrationSpec? Type1153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RemoveSettingTraceMigrationSpecVariant2? Type1154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AzureWebhookEvent? Type1155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AzureWebhookEventAction? Type1156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<string, global::Dataloop.AzureWebhookEventOperationRequestSource?>? Type1157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AzureWebhookEventOperationRequestSource? Type1158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AzureWebhookEventSubscription? Type1159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AzureWebhookEventSubscriptionTerm? Type1160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AzureWebhookEventSubscriptionPurchaser? Type1161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AzureWebhookEventSubscriptionBeneficiary? Type1162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UsageLog? Type1163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ResourceUsage? Type1164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.UsageLog>? Type1165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UsageReport? Type1166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ResourceUsage>? Type1167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UsageResourcesReport? Type1168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.BillingResourceKey>? Type1169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EditSubscriptionInput? Type1170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RenewSubscriptionInput? Type1171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CursorPageAPISubscription? Type1172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APISubscription>? Type1173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BillingScope? Type1174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CustomSubscriptionInput? Type1175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SubscriptionUpgradeInput? Type1176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SubscriptionExtensionInput? Type1177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PaymentDriverTypes? Type1178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RangeOrFeatureTier? Type1179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RangeOrFeatureTierRange? Type1180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.OverQuota? Type1181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIBillableResource? Type1182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.RangeOrFeatureTier>? Type1183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SubscriptionInput? Type1184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UIHours? Type1185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APICallResourceDescriptor? Type1186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APICallSourceDescriptor? Type1187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.APICallResourceDescriptor>? Type1188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APICallDescriptor? Type1189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.StorageModificationSourceDescriptor? Type1190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.StorageModificationDescriptor? Type1191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.StorageDatasetDescriptor? Type1192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.StorageDescriptor? Type1193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.StorageDatasetDescriptor>? Type1194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PodType? Type1195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FaasUsageServiceInstanceDescriptor? Type1196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FaasGlobalServiceDescriptor? Type1197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FaasUsageDescriptor? Type1198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.FaasUsageServiceInstanceDescriptor>? Type1199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.FaasGlobalServiceDescriptor>? Type1200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ItemsCount? Type1201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IngestedDatapointsDescriptor? Type1202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIUsageEntry? Type1203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ContactAddress? Type1204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Address? Type1205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ContactInfo? Type1206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LineItem? Type1207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.InvoiceStatus? Type1208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Currency? Type1209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PaymentDetails? Type1210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.Invoice? Type1211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ContactInfo>? Type1212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.LineItem>? Type1213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.InvoiceBilledPeriod? Type1214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PaymentDetails>? Type1215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaxType? Type1216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TaxData? Type1217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DBBillingAccount? Type1218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialBillingAccount? Type1219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PartialBillingAccountTaxData? Type1220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PaymentDriverType? Type1221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DBPaymentDriverConfiguration? Type1222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DBPaymentDriverConfigurationType? Type1223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreditCard? Type1224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PaymentMethod? Type1225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ResourceAuditEventType? Type1226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ResourceAuditLog? Type1227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ResourceAuditLogCtx? Type1228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AuditLogsCursorPage? Type1229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ResourceAuditLog>? Type1230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AlertStatus? Type1231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.APIAlert? Type1232 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FieldSort? Type1233 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FieldSortField? Type1234 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.FieldSortDirection? Type1235 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MongoStorageDatasetDescriptor? Type1236 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MongoStorageDescriptor? Type1237 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.MongoStorageDatasetDescriptor>? Type1238 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MongoAPIUsageEntry? Type1239 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ArchiveAnnotationToStorageRequest? Type1240 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RestoreArchivedAnnotationToDBRequest? Type1241 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetProjectsActiveCountersRequest? Type1242 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetCountersForProjectRequest? Type1243 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateApiKeyRequest? Type1244 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ResolveTemplateRequest? Type1245 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SetItemStatusBulkTaskRequest? Type1246 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SetItemStatusBulkAssignmentRequest? Type1247 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetAssignmentFieldsRequest? Type1248 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryAuditLogsRequest? Type1249 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateAlertRequest? Type1250 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ListAccountAlertsRequest? Type1251 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.InstallRequest? Type1252 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UninstallRequest? Type1253 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.PartialICompute, global::Dataloop.UpdateComputeRequest2>? Type1254 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateComputeRequest2? Type1255 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SchemaCleanupRequest? Type1256 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetDatasetsByProjectIdsRequest? Type1257 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ListExportHistoryRequest? Type1258 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ListExportHistoryRequestSortOrder? Type1259 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ListExportHistoryRequestSortBy? Type1260 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.DQLResourceQuery, global::Dataloop.AnyOf<global::Dataloop.FilterQuery, global::Dataloop.UpdateQuery, global::Dataloop.DeleteQuery>?>? Type1261 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.FilterQuery, global::Dataloop.UpdateQuery, global::Dataloop.DeleteQuery>? Type1262 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryDatasetsRequest? Type1263 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryDatasetsRequestTarget? Type1264 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AllOf<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>? Type1265 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RestoreDatasetRequest? Type1266 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RemoveItemsByQueryRequest? Type1267 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BulkUpdateMetadataRequest? Type1268 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BullkGenerateAnnotationThumbnailsRequest? Type1269 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.BullkGenerateAnnotationThumbnailsRequestOptions? Type1270 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateItemCollectionRequest? Type1271 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddItemsToItemCollectionsRequest? Type1272 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RemoveItemsFromItemCollectionsRequest? Type1273 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RenameItemCollectionRequest? Type1274 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.InvalidateAnnotationThumbnailsRequest? Type1275 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.MoveItemsRequest, global::System.Collections.Generic.IList<string>>? Type1276 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MoveItemsRequest? Type1277 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIAnnotationRequest, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationRequest>>? Type1278 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ArchiveDatasetItemAnnotationToStorageRequest? Type1279 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RestoreArchivedDatasetItemAnnotationToDBRequest? Type1280 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetFilteredDatasetLabelAggregationRequest? Type1281 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetFilteredDatasetTypeAggregationRequest? Type1282 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.ImportItemRequest>, global::Dataloop.ImportItemsToDatasetRequest>? Type1283 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ImportItemRequest>? Type1284 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ImportItemsToDatasetRequest? Type1285 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SplitMlOperationRequest? Type1286 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.MigrateDriversIntegrationRequest? Type1287 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CheckStorageDriversIntegrationByIntegrationIdRequest? Type1288 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.NackRequest? Type1289 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PushProgressRequest? Type1290 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateExecutionRequest? Type1291 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.FeatureSet, global::System.Collections.Generic.IList<global::Dataloop.FeatureSet>>? Type1292 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.FeatureSet>? Type1293 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.FeatureVector, global::System.Collections.Generic.IList<global::Dataloop.FeatureVector>>? Type1294 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.FeatureVector>? Type1295 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddGroupMemberRequest? Type1296 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateGroupOwnerRequest? Type1297 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddSubGroupRequest? Type1298 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ArchiveItemAnnotationToStorageRequest? Type1299 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RestoreArchivedItemAnnotationToDBRequest? Type1300 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.MetricRequest, global::System.Collections.Generic.IList<global::Dataloop.MetricRequest>>? Type1301 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.MetricRequest>? Type1302 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GenerateModelMetricsReportRequest? Type1303 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelsExecutionsRequest? Type1304 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelsServicesRequest? Type1305 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.PartialCreateModelRequest, global::Dataloop.APICopyEnvironmentSpec>? Type1306 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DeployModelRequest? Type1307 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateModelDeploymentRequest? Type1308 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExtractItemFeaturesRequest? Type1309 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExtractItemFeaturesRequestConfig? Type1310 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ExtractItemFeaturesRequestInput? Type1311 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EvaluateModelRequest? Type1312 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EvaluateModelRequestConfig? Type1313 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.EvaluateModelRequestInput? Type1314 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelPredictionRequest? Type1315 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelPredictionRequestConfig? Type1316 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelPredictionRequestInput? Type1317 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TrainModelRequest? Type1318 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.CreateOntologyPayloadV2, global::Dataloop.CreateOntologyPayload>? Type1319 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DeleteAttributesRequest? Type1320 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.UpdateLabelNodePayload>? Type1321 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateOrgRequest? Type1322 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PatchOrgRequest? Type1323 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateOrgBotRequest? Type1324 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateIntegrationRequest? Type1325 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddOrgMembersRequest? Type1326 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PatchOrgMemberRequest? Type1327 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateOrgPlanRequest? Type1328 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.InstallRequest2? Type1329 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UninstallRequest2? Type1330 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.LogsRequest? Type1331 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryBillingMetricsRequest? Type1332 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateProjectGuestRequest? Type1333 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddOrgToGuestRequest? Type1334 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PatchProjectRequest? Type1335 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SetProjectAccountRequest? Type1336 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddOrgToProjectRequest? Type1337 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AddGroupRequest? Type1338 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateGroupRequest? Type1339 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryEntitiesRequest? Type1340 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.RecipeV2Input?, global::Dataloop.RecipeInput?>? Type1341 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.PartialRecipePayloadV2, global::Dataloop.PartialRecipePayload>? Type1342 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateScoresRequest? Type1343 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.Score>? Type1344 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.SetDefaultRequest? Type1345 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.GetGlobalServicesRequestItem>? Type1346 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetGlobalServicesRequestItem? Type1347 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.BaseReportMessage>? Type1348 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.RolloutServiceRequest? Type1349 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.ResolverPayload, global::Dataloop.IUserContext>? Type1350 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.PatchFeatureFlagRequest, global::Dataloop.PatchUserSettingRequest>? Type1351 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.DeleteSettingRequest? Type1352 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetProjectsActiveCountersRequest2? Type1353 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetCountersForProjectRequest2? Type1354 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateUserOrgRequest? Type1355 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIAccount>? Type1356 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>? Type1357 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<object, global::Dataloop.APICommand>? Type1358 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.TaskRelativeInput>? Type1359 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.APITask>? Type1360 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIApiKey>? Type1361 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CreateApiKeyResponse? Type1362 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DpkAttributesDefinition>? Type1363 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.UpdateResponse? Type1364 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIApp, object>? Type1365 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>? Type1366 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.APIAssignment>? Type1367 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIUsageEntry>? Type1368 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIAlert>? Type1369 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.DBPaymentDriverConfiguration>? Type1370 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PaymentMethod>? Type1371 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APICommand, object>? Type1372 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIDataset>? Type1373 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetDatasetsByProjectIdsResponse? Type1374 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ListExportHistoryResponse? Type1375 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIExportHistory>? Type1376 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>? Type1377 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIAnnotation>? Type1378 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIAnnotation, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotation>>? Type1379 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>>? Type1380 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.Dataset, global::Dataloop.APIDatasetSchema>? Type1381 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APICommand, string>? Type1382 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.Dataset>? Type1383 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIDriverConfiguration>? Type1384 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIExecution, global::Dataloop.PiperSettingsCommands>? Type1385 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIExecution, global::Dataloop.APICommand>? Type1386 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AuthUserAttributes>? Type1387 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.Invoice>? Type1388 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PublishModelMetricsResponse? Type1389 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.Error>? Type1390 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ModelsDatasetsCountResponse? Type1391 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIModel, global::Dataloop.APICommand>? Type1392 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIOrg>? Type1393 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.GetAvailableIntegrationsResponseItemVariant1, global::Dataloop.GetAvailableIntegrationsResponseItemVariant2>>? Type1394 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.GetAvailableIntegrationsResponseItemVariant1, global::Dataloop.GetAvailableIntegrationsResponseItemVariant2>? Type1395 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetAvailableIntegrationsResponseItemVariant1? Type1396 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.GetAvailableIntegrationsResponseItemVariant1Option>? Type1397 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetAvailableIntegrationsResponseItemVariant1Option? Type1398 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetAvailableIntegrationsResponseItemVariant2? Type1399 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.GetAvailableIntegrationsResponseItemVariant2Option>? Type1400 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetAvailableIntegrationsResponseItemVariant2Option? Type1401 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIOrgUser>? Type1402 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.QueryPipelineTableResponseItem>? Type1403 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryPipelineTableResponseItem? Type1404 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryPipelineTableResponseItemTemplate? Type1405 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.APICommand>? Type1406 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.TerminateResponse? Type1407 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.PipelineExecutionLogs>? Type1408 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.Plan>? Type1409 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIBillableResource>? Type1410 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIGuest>? Type1411 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIMembership>, object>? Type1412 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIMembership>? Type1413 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.ClientContributor>, object>? Type1414 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.ClientContributor>? Type1415 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.APIScore>? Type1416 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.QueryConfusionResponse? Type1417 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetTaskScoresResponse? Type1418 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetTaskAnnotationScoresResponse? Type1419 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetTaskItemScoresResponse? Type1420 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.GetGlobalServicesResponseItem>? Type1421 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetGlobalServicesResponseItem? Type1422 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.APIServiceStatus>? Type1423 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIService, string>? Type1424 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.ServiceStreamResponse? Type1425 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetServiceIntegrationEnvResponse? Type1426 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.GetServiceIntegrationEnvResponseEnvItem>? Type1427 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetServiceIntegrationEnvResponseEnvItem? Type1428 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>? Type1429 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>>? Type1430 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.UsageReport>? Type1431 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Dataloop.GetMyGroupProjectsResponseItem>? Type1432 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.GetMyGroupProjectsResponseItem? Type1433 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIUser, object>? Type1434 { get; set; }

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
        public global::System.Collections.Generic.List<global::Dataloop.UpdateDriversIntegrationResultError>? ListType25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIFeatureSet>? ListType26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIFeatureVector>? ListType27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AggregateProjectVectorsCountResultItem>? ListType28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IndexDriver>? ListType29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APILabelTree>? ListType30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.CreateLabelPayloadTreeV1>? ListType31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.CreateLabelPayload>? ListType32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AttributeCreationPayload>? ListType33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIOntologyV2, global::Dataloop.APIOntology>>? ListType34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ToolInstruction>? ListType35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.CustomActionTarget>? ListType36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.Example>? ListType37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.GoodExample>? ListType38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.CustomAction>? ListType39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.LabelTree>? ListType40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIInstruction>? ListType41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APICustomActionTarget>? ListType42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIBadExample>? ListType43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIGoodExample>? ListType44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APICustomAction>? ListType45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>>? ListType46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIAssignment>? ListType47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AssignmentWorkload>? ListType48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APILabelTreeNodeV2>? ListType49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.FilterQueryInputReferencesRef>? ListType50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIAttributeSection>? ListType51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIStructure>? ListType53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ItemAction>? ListType55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.TaskWorkload>? ListType56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APITask>? ListType57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.GroupCtx>? ListType58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIUser>, global::System.Collections.Generic.List<string>>? ListType59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIUser>? ListType60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIGroup>, global::System.Collections.Generic.List<string>>? ListType61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIGroup>? ListType62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIIntegration>, global::System.Collections.Generic.List<string>>? ListType63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIIntegration>? ListType64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIProject>, global::System.Collections.Generic.List<string>>? ListType65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIProject>? ListType66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.FeatureConstraint>? ListType67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIProjectGuest>, global::System.Collections.Generic.List<string>>? ListType68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIProjectGuest>? ListType69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIIntegrationMetadata>? ListType70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IntegrationMetadataBody>? ListType71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.BillingResource>? ListType72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APILogin>? ListType73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.EntityReference>? ListType74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>>? ListType75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ModelStatusLog>? ListType76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIModel>? ListType77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ExecutionStatusReport>? ListType78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ExecutionResource>? ListType79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIWebHook>? ListType81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.Panel>? ListType82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ServiceIntegration>? ListType83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PackageIO>? ListType84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DisplayScope>? ListType85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DLFunctionDefaultInputSpec>? ListType86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DLFunctionInputOptionsSpec>? ListType87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIExecution>? ListType88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APITrigger>? ListType89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.TriggerResourceInformationItem>? ListType90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIService>? ListType91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ServiceLogEntry>? ListType92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ServiceRuntimeStatus>? ListType93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DriverCondition>? ListType94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DriverNodeSelector>? ListType95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DriverToleration>? ListType96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DataloopPodType>? ListType97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.TriggerActionType>? ListType98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DLFunction>? ListType99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PackageRequirement>? ListType100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.Dictionary>? ListType101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ICompositionFilter>? ListType102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PortIO>? ListType103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PipelineNodeDescriptor>? ListType104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PipelineConnection>? ListType105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IStartNode>? ListType106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PipelineVariable>? ListType107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ICompositionDatasetStateDatasetAnnotation>? ListType108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIServiceCompositionElement>? ListType109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ICompositionTrigger>? ListType110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ICompositionPackage>? ListType111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ICompositionTask>? ListType112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APICompositionModel>? ListType113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ICompositionChannel>? ListType114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ICompositionPipelineTemplate>? ListType115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ICompositionDataset>? ListType116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Dataloop.PartialExecution>>? ListType117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PartialExecution>? ListType118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IPipelineNodeState>? ListType119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.INodeTransitionError>? ListType120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkComponentPanelSupportedSlot>? ListType121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkFilter>? ListType122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkComponentIntegrations>? ListType123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkComponentDataset>? ListType124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkPipelineTemplate>? ListType125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IPipelineNode>? ListType126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkComputeConfigs>? ListType127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkChannel>? ListType128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkComponentToolbars>? ListType129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkComponentService>? ListType130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkComponentTrigger>? ListType131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkComponentModule>? ListType132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkComponentModel>? ListType133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkComponentPanel>? ListType134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IDpkDependency>? ListType135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.Toleration>? ListType136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IStorage>? ListType137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IClusterVolumeConfigMapItem>? ListType138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IClusterVolumeSecretItem>? ListType139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IClusterVolume>? ListType140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IClusterEnvironmentVariable>? ListType141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.INodePool>? ListType142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IComputePlugin>? ListType143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IComputeContext>? ListType144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIComposition>? ListType145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIPipeline>? ListType146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIPipelineState, global::Dataloop.IPipelineState>>? ListType147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ResourceExecution>? ListType148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIDpk>? ListType149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIApp>? ListType150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APICompute>? ListType151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIServiceDriver>? ListType152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIPipelineState>? ListType153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ExecutionLogs>? ListType154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IExecutionCount>? ListType155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.IPipelineExecutionCount>? ListType156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.INodeExecutionCount>? ListType157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.INodeExecutionStatistics>? ListType158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PipelineVersionListItem>? ListType159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.Module>? ListType160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.UiHook>? ListType161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PiperUiSlot>? ListType162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIPackage>? ListType163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.CommandError>? ListType164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.CommandStatusHistoryEntry>? ListType165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DpkAttributeValueDefinition>? ListType166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PreviewsComponentsPatchPipelineTemplate>? ListType167 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIUserSetting, global::Dataloop.APIFeatureFlag>>? ListType168 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.UsageLog>? ListType169 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ResourceUsage>? ListType170 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.BillingResourceKey>? ListType171 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APISubscription>? ListType172 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.RangeOrFeatureTier>? ListType173 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.StorageDatasetDescriptor>? ListType174 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.FaasUsageServiceInstanceDescriptor>? ListType175 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.FaasGlobalServiceDescriptor>? ListType176 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ContactInfo>? ListType177 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.LineItem>? ListType178 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PaymentDetails>? ListType179 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ResourceAuditLog>? ListType180 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.MongoStorageDatasetDescriptor>? ListType181 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.MoveItemsRequest, global::System.Collections.Generic.List<string>>? ListType182 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIAnnotationRequest, global::System.Collections.Generic.List<global::Dataloop.APIAnnotationRequest>>? ListType183 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.ImportItemRequest>, global::Dataloop.ImportItemsToDatasetRequest>? ListType184 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ImportItemRequest>? ListType185 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.FeatureSet, global::System.Collections.Generic.List<global::Dataloop.FeatureSet>>? ListType186 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.FeatureSet>? ListType187 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.FeatureVector, global::System.Collections.Generic.List<global::Dataloop.FeatureVector>>? ListType188 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.FeatureVector>? ListType189 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.MetricRequest, global::System.Collections.Generic.List<global::Dataloop.MetricRequest>>? ListType190 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.MetricRequest>? ListType191 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.UpdateLabelNodePayload>? ListType192 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.Score>? ListType193 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.GetGlobalServicesRequestItem>? ListType194 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.BaseReportMessage>? ListType195 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIAccount>? ListType196 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.TaskRelativeInput>? ListType197 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIApiKey>? ListType198 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DpkAttributesDefinition>? ListType199 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APICommand, global::System.Collections.Generic.List<global::Dataloop.APIAssignment>>? ListType200 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIUsageEntry>? ListType201 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIAlert>? ListType202 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.DBPaymentDriverConfiguration>? ListType203 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PaymentMethod>? ListType204 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIDataset>? ListType205 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIExportHistory>? ListType206 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIAnnotation>? ListType207 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::Dataloop.APIAnnotation, global::System.Collections.Generic.List<global::Dataloop.APIAnnotation>>? ListType208 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>>? ListType209 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIDriverConfiguration>? ListType210 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AuthUserAttributes>? ListType211 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.Invoice>? ListType212 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIOrg>? ListType213 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.GetAvailableIntegrationsResponseItemVariant1, global::Dataloop.GetAvailableIntegrationsResponseItemVariant2>>? ListType214 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.GetAvailableIntegrationsResponseItemVariant1Option>? ListType215 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.GetAvailableIntegrationsResponseItemVariant2Option>? ListType216 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIOrgUser>? ListType217 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.QueryPipelineTableResponseItem>? ListType218 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.PipelineExecutionLogs>? ListType219 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.Plan>? ListType220 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIBillableResource>? ListType221 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIGuest>? ListType222 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIMembership>, object>? ListType223 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIMembership>? ListType224 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.ClientContributor>, object>? ListType225 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.ClientContributor>? ListType226 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.APIScore>? ListType227 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.GetGlobalServicesResponseItem>? ListType228 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.GetServiceIntegrationEnvResponseEnvItem>? ListType229 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>>? ListType230 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.UsageReport>? ListType231 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.GetMyGroupProjectsResponseItem>? ListType232 { get; set; }
    }
}