
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class INodeConfigPackage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codebaseFilename")]
        public string? CodebaseFilename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codebase")]
        public global::Dataloop.Codebase? Codebase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirementsFilename")]
        public string? RequirementsFilename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirements")]
        public global::System.Collections.Generic.IList<global::Dataloop.PackageRequirement>? Requirements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entryFile")]
        public string? EntryFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.PackageConfigTypeJsonConverter))]
        public global::Dataloop.PackageConfigType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="INodeConfigPackage" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="codebaseFilename"></param>
        /// <param name="codebase"></param>
        /// <param name="requirementsFilename"></param>
        /// <param name="requirements"></param>
        /// <param name="code"></param>
        /// <param name="entryFile"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public INodeConfigPackage(
            string name,
            string? codebaseFilename,
            global::Dataloop.Codebase? codebase,
            string? requirementsFilename,
            global::System.Collections.Generic.IList<global::Dataloop.PackageRequirement>? requirements,
            string? code,
            string? entryFile,
            global::Dataloop.PackageConfigType? type)
        {
            this.CodebaseFilename = codebaseFilename;
            this.Codebase = codebase;
            this.RequirementsFilename = requirementsFilename;
            this.Requirements = requirements;
            this.Code = code;
            this.EntryFile = entryFile;
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="INodeConfigPackage" /> class.
        /// </summary>
        public INodeConfigPackage()
        {
        }
    }
}