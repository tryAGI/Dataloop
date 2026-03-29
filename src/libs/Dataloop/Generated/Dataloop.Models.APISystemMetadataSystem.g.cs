
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APISystemMetadataSystem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modalities")]
        public global::System.Collections.Generic.IList<global::Dataloop.APIModality>? Modalities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public double? Width { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public double? Height { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalPath")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Encoding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimetype")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mimetype { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Originalname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APISystemMetadataSystem" /> class.
        /// </summary>
        /// <param name="originalPath"></param>
        /// <param name="encoding"></param>
        /// <param name="size"></param>
        /// <param name="mimetype"></param>
        /// <param name="originalname"></param>
        /// <param name="modalities"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APISystemMetadataSystem(
            string originalPath,
            string encoding,
            double size,
            string mimetype,
            string originalname,
            global::System.Collections.Generic.IList<global::Dataloop.APIModality>? modalities,
            double? width,
            double? height)
        {
            this.Modalities = modalities;
            this.Width = width;
            this.Height = height;
            this.OriginalPath = originalPath ?? throw new global::System.ArgumentNullException(nameof(originalPath));
            this.Encoding = encoding ?? throw new global::System.ArgumentNullException(nameof(encoding));
            this.Size = size;
            this.Mimetype = mimetype ?? throw new global::System.ArgumentNullException(nameof(mimetype));
            this.Originalname = originalname ?? throw new global::System.ArgumentNullException(nameof(originalname));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APISystemMetadataSystem" /> class.
        /// </summary>
        public APISystemMetadataSystem()
        {
        }
    }
}