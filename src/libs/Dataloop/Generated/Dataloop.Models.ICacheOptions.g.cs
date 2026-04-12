
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ICacheOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.ICacheOptionsOrg Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("driverId")]
        public string? DriverId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner")]
        public global::Dataloop.ICacheRunner? Runner { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ICacheOptions" /> class.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="driverId"></param>
        /// <param name="runner"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ICacheOptions(
            global::Dataloop.ICacheOptionsOrg org,
            string? driverId,
            global::Dataloop.ICacheRunner? runner)
        {
            this.Org = org ?? throw new global::System.ArgumentNullException(nameof(org));
            this.DriverId = driverId;
            this.Runner = runner;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ICacheOptions" /> class.
        /// </summary>
        public ICacheOptions()
        {
        }
    }
}