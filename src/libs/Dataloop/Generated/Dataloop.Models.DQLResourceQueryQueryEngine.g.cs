
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum DQLResourceQueryQueryEngine
    {
        /// <summary>
        /// 
        /// </summary>
        Elasticsearch,
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Mongo,
        /// <summary>
        /// 
        /// </summary>
        Sql,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DQLResourceQueryQueryEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DQLResourceQueryQueryEngine value)
        {
            return value switch
            {
                DQLResourceQueryQueryEngine.Elasticsearch => "elasticsearch",
                DQLResourceQueryQueryEngine.Json => "json",
                DQLResourceQueryQueryEngine.Mongo => "mongo",
                DQLResourceQueryQueryEngine.Sql => "sql",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DQLResourceQueryQueryEngine? ToEnum(string value)
        {
            return value switch
            {
                "elasticsearch" => DQLResourceQueryQueryEngine.Elasticsearch,
                "json" => DQLResourceQueryQueryEngine.Json,
                "mongo" => DQLResourceQueryQueryEngine.Mongo,
                "sql" => DQLResourceQueryQueryEngine.Sql,
                _ => null,
            };
        }
    }
}