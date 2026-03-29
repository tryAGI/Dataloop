
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class S2SetupOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createUsers")]
        public bool? CreateUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grantUserPermissions")]
        public bool? GrantUserPermissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createDbs")]
        public bool? CreateDbs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setGlobalVars")]
        public bool? SetGlobalVars { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createFunctions")]
        public bool? CreateFunctions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTables")]
        public bool? CreateTables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createIndexes")]
        public bool? CreateIndexes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="S2SetupOptions" /> class.
        /// </summary>
        /// <param name="createUsers"></param>
        /// <param name="grantUserPermissions"></param>
        /// <param name="createDbs"></param>
        /// <param name="setGlobalVars"></param>
        /// <param name="createFunctions"></param>
        /// <param name="createTables"></param>
        /// <param name="createIndexes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public S2SetupOptions(
            bool? createUsers,
            bool? grantUserPermissions,
            bool? createDbs,
            bool? setGlobalVars,
            bool? createFunctions,
            bool? createTables,
            bool? createIndexes)
        {
            this.CreateUsers = createUsers;
            this.GrantUserPermissions = grantUserPermissions;
            this.CreateDbs = createDbs;
            this.SetGlobalVars = setGlobalVars;
            this.CreateFunctions = createFunctions;
            this.CreateTables = createTables;
            this.CreateIndexes = createIndexes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="S2SetupOptions" /> class.
        /// </summary>
        public S2SetupOptions()
        {
        }
    }
}