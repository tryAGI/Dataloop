
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadItemsBenchmarkCommandV2Input
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexDriver")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.IndexDriverJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.IndexDriver IndexDriver { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ItemsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batchSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BatchSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Concurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gateUrl")]
        public string? GateUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadFileConfig")]
        public global::Dataloop.UploadItemsBenchmarkCommandV2InputUploadFileConfig? UploadFileConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadItemsBenchmarkCommandV2Input" /> class.
        /// </summary>
        /// <param name="indexDriver"></param>
        /// <param name="itemsCount"></param>
        /// <param name="batchSize"></param>
        /// <param name="concurrency"></param>
        /// <param name="gateUrl"></param>
        /// <param name="uploadFileConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadItemsBenchmarkCommandV2Input(
            global::Dataloop.IndexDriver indexDriver,
            double itemsCount,
            double batchSize,
            double concurrency,
            string? gateUrl,
            global::Dataloop.UploadItemsBenchmarkCommandV2InputUploadFileConfig? uploadFileConfig)
        {
            this.IndexDriver = indexDriver;
            this.ItemsCount = itemsCount;
            this.BatchSize = batchSize;
            this.Concurrency = concurrency;
            this.GateUrl = gateUrl;
            this.UploadFileConfig = uploadFileConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadItemsBenchmarkCommandV2Input" /> class.
        /// </summary>
        public UploadItemsBenchmarkCommandV2Input()
        {
        }
    }
}