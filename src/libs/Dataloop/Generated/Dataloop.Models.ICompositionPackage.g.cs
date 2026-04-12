
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ICompositionPackage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public global::Dataloop.ICompositionPackageState? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageId")]
        public string? PackageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codebaseId")]
        public string? CodebaseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entryFile")]
        public string? EntryFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("module")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.PartialModule Module { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.PackageConfigTypeJsonConverter))]
        public global::Dataloop.PackageConfigType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirements")]
        public global::System.Collections.Generic.IList<global::Dataloop.PackageRequirement>? Requirements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codebase")]
        public global::Dataloop.Codebase? Codebase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeId")]
        public string? NodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionPackage" /> class.
        /// </summary>
        /// <param name="module">
        /// Make all properties in T optional
        /// </param>
        /// <param name="name"></param>
        /// <param name="state"></param>
        /// <param name="packageId"></param>
        /// <param name="codebaseId"></param>
        /// <param name="entryFile"></param>
        /// <param name="code"></param>
        /// <param name="type"></param>
        /// <param name="requirements"></param>
        /// <param name="codebase"></param>
        /// <param name="nodeId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ICompositionPackage(
            global::Dataloop.PartialModule module,
            string name,
            global::Dataloop.ICompositionPackageState? state,
            string? packageId,
            string? codebaseId,
            string? entryFile,
            string? code,
            global::Dataloop.PackageConfigType? type,
            global::System.Collections.Generic.IList<global::Dataloop.PackageRequirement>? requirements,
            global::Dataloop.Codebase? codebase,
            string? nodeId)
        {
            this.State = state;
            this.PackageId = packageId;
            this.CodebaseId = codebaseId;
            this.EntryFile = entryFile;
            this.Code = code;
            this.Module = module ?? throw new global::System.ArgumentNullException(nameof(module));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Requirements = requirements;
            this.Codebase = codebase;
            this.NodeId = nodeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ICompositionPackage" /> class.
        /// </summary>
        public ICompositionPackage()
        {
        }
    }
}