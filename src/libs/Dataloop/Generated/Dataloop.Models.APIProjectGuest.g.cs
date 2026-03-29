
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIProjectGuest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIProject, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AnyOf<global::Dataloop.APIProject, string> Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guestOrg")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIOrg, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AnyOf<global::Dataloop.APIOrg, string> GuestOrg { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUser, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.AnyOf<global::Dataloop.APIUser, string> Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIProjectGuest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="project"></param>
        /// <param name="guestOrg"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="creator"></param>
        /// <param name="url"></param>
        /// <param name="archived"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIProjectGuest(
            string id,
            double createdAt,
            double updatedAt,
            global::Dataloop.AnyOf<global::Dataloop.APIProject, string> project,
            global::Dataloop.AnyOf<global::Dataloop.APIOrg, string> guestOrg,
            string name,
            string type,
            global::Dataloop.AnyOf<global::Dataloop.APIUser, string> creator,
            string? url,
            bool? archived)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Project = project;
            this.GuestOrg = guestOrg;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Creator = creator;
            this.Archived = archived;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIProjectGuest" /> class.
        /// </summary>
        public APIProjectGuest()
        {
        }
    }
}