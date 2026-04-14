
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IPostComposition
    {
        /// <summary>
        /// The user cluster driver id - defining the compute cluster the server should connect to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driverId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DriverId { get; set; }

        /// <summary>
        /// Array of channels details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionChannel>? Channels { get; set; }

        /// <summary>
        /// An array of services
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Dataloop.APIServiceCompositionElement> Spec { get; set; }

        /// <summary>
        /// An array of tasks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionTask>? Tasks { get; set; }

        /// <summary>
        /// An array of packages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionPackage>? Packages { get; set; }

        /// <summary>
        /// An array of triggers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public global::System.Collections.Generic.IList<global::Dataloop.ICompositionTrigger>? Triggers { get; set; }

        /// <summary>
        /// The project where the composition should be install the entities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The composition name
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
        /// Initializes a new instance of the <see cref="IPostComposition" /> class.
        /// </summary>
        /// <param name="driverId">
        /// The user cluster driver id - defining the compute cluster the server should connect to
        /// </param>
        /// <param name="spec">
        /// An array of services
        /// </param>
        /// <param name="projectId">
        /// The project where the composition should be install the entities
        /// </param>
        /// <param name="name">
        /// The composition name
        /// </param>
        /// <param name="channels">
        /// Array of channels details
        /// </param>
        /// <param name="tasks">
        /// An array of tasks
        /// </param>
        /// <param name="packages">
        /// An array of packages
        /// </param>
        /// <param name="triggers">
        /// An array of triggers
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IPostComposition(
            string driverId,
            global::System.Collections.Generic.IList<global::Dataloop.APIServiceCompositionElement> spec,
            string projectId,
            string name,
            global::System.Collections.Generic.IList<global::Dataloop.ICompositionChannel>? channels,
            global::System.Collections.Generic.IList<global::Dataloop.ICompositionTask>? tasks,
            global::System.Collections.Generic.IList<global::Dataloop.ICompositionPackage>? packages,
            global::System.Collections.Generic.IList<global::Dataloop.ICompositionTrigger>? triggers)
        {
            this.DriverId = driverId ?? throw new global::System.ArgumentNullException(nameof(driverId));
            this.Channels = channels;
            this.Spec = spec ?? throw new global::System.ArgumentNullException(nameof(spec));
            this.Tasks = tasks;
            this.Packages = packages;
            this.Triggers = triggers;
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IPostComposition" /> class.
        /// </summary>
        public IPostComposition()
        {
        }
    }
}