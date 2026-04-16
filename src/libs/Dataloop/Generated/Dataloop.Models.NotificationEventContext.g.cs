
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NotificationEventContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public string? Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        public string? Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline")]
        public string? Pipeline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        public string? Service { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node")]
        public string? Node { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskId")]
        public string? TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignmentId")]
        public string? AssignmentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member")]
        public string? Member { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelOperation")]
        public string? ModelOperation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("package")]
        public string? Package { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cycle")]
        public string? Cycle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        public string? Trigger { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationEventContext" /> class.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="org"></param>
        /// <param name="pipeline"></param>
        /// <param name="service"></param>
        /// <param name="node"></param>
        /// <param name="taskId"></param>
        /// <param name="assignmentId"></param>
        /// <param name="userId"></param>
        /// <param name="member"></param>
        /// <param name="creator"></param>
        /// <param name="model"></param>
        /// <param name="modelOperation"></param>
        /// <param name="package"></param>
        /// <param name="cycle"></param>
        /// <param name="trigger"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NotificationEventContext(
            string? project,
            string? org,
            string? pipeline,
            string? service,
            string? node,
            string? taskId,
            string? assignmentId,
            string? userId,
            string? member,
            string? creator,
            string? model,
            string? modelOperation,
            string? package,
            string? cycle,
            string? trigger)
        {
            this.Project = project;
            this.Org = org;
            this.Pipeline = pipeline;
            this.Service = service;
            this.Node = node;
            this.TaskId = taskId;
            this.AssignmentId = assignmentId;
            this.UserId = userId;
            this.Member = member;
            this.Creator = creator;
            this.Model = model;
            this.ModelOperation = modelOperation;
            this.Package = package;
            this.Cycle = cycle;
            this.Trigger = trigger;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationEventContext" /> class.
        /// </summary>
        public NotificationEventContext()
        {
        }
    }
}