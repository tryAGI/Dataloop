
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CacheRunner
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redisHost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RedisHost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numReplicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumReplicas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.FaaSCacheSizeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.FaaSCacheSize Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Dataloop.JsonConverters.FaaSCacheTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.FaaSCacheType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minReplica")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MinReplica { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxReplica")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxReplica { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheRunner" /> class.
        /// </summary>
        /// <param name="redisHost"></param>
        /// <param name="numReplicas"></param>
        /// <param name="size"></param>
        /// <param name="type"></param>
        /// <param name="minReplica"></param>
        /// <param name="maxReplica"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CacheRunner(
            string redisHost,
            double numReplicas,
            global::Dataloop.FaaSCacheSize size,
            global::Dataloop.FaaSCacheType type,
            double minReplica,
            double maxReplica)
        {
            this.RedisHost = redisHost ?? throw new global::System.ArgumentNullException(nameof(redisHost));
            this.NumReplicas = numReplicas;
            this.Size = size;
            this.Type = type;
            this.MinReplica = minReplica;
            this.MaxReplica = maxReplica;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheRunner" /> class.
        /// </summary>
        public CacheRunner()
        {
        }
    }
}