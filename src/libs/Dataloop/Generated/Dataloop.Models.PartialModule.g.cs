
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialModule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entryPoint")]
        public string? EntryPoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("className")]
        public string? ClassName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initInputs")]
        public global::System.Collections.Generic.IList<global::Dataloop.PackageIO>? InitInputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        public global::System.Collections.Generic.IList<global::Dataloop.DLFunction>? Functions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialModule" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="entryPoint"></param>
        /// <param name="className"></param>
        /// <param name="initInputs"></param>
        /// <param name="functions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialModule(
            string? name,
            string? entryPoint,
            string? className,
            global::System.Collections.Generic.IList<global::Dataloop.PackageIO>? initInputs,
            global::System.Collections.Generic.IList<global::Dataloop.DLFunction>? functions)
        {
            this.Name = name;
            this.EntryPoint = entryPoint;
            this.ClassName = className;
            this.InitInputs = initInputs;
            this.Functions = functions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialModule" /> class.
        /// </summary>
        public PartialModule()
        {
        }
    }
}