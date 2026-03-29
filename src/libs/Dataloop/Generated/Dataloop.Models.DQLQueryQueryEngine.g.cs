
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum DQLQueryQueryEngine
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
    public static class DQLQueryQueryEngineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DQLQueryQueryEngine value)
        {
            return value switch
            {
                DQLQueryQueryEngine.Elasticsearch => "elasticsearch",
                DQLQueryQueryEngine.Json => "json",
                DQLQueryQueryEngine.Mongo => "mongo",
                DQLQueryQueryEngine.Sql => "sql",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DQLQueryQueryEngine? ToEnum(string value)
        {
            return value switch
            {
                "elasticsearch" => DQLQueryQueryEngine.Elasticsearch,
                "json" => DQLQueryQueryEngine.Json,
                "mongo" => DQLQueryQueryEngine.Mongo,
                "sql" => DQLQueryQueryEngine.Sql,
                _ => null,
            };
        }
    }
}