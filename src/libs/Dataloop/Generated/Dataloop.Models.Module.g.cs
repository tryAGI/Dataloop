
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Module
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entryPoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntryPoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("className")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClassName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initInputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.PackageIO> InitInputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.DLFunction> Functions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Module" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="entryPoint"></param>
        /// <param name="className"></param>
        /// <param name="initInputs"></param>
        /// <param name="functions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Module(
            string name,
            string entryPoint,
            string className,
            global::System.Collections.Generic.IList<global::Dataloop.PackageIO> initInputs,
            global::System.Collections.Generic.IList<global::Dataloop.DLFunction> functions)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.EntryPoint = entryPoint ?? throw new global::System.ArgumentNullException(nameof(entryPoint));
            this.ClassName = className ?? throw new global::System.ArgumentNullException(nameof(className));
            this.InitInputs = initInputs ?? throw new global::System.ArgumentNullException(nameof(initInputs));
            this.Functions = functions ?? throw new global::System.ArgumentNullException(nameof(functions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Module" /> class.
        /// </summary>
        public Module()
        {
        }
    }
}