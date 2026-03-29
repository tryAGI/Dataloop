
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueryDatasetsRequestTarget
    {
        /// <summary>
        /// 
        /// </summary>
        LanceDB,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryDatasetsRequestTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryDatasetsRequestTarget value)
        {
            return value switch
            {
                QueryDatasetsRequestTarget.LanceDB => "lanceDB",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryDatasetsRequestTarget? ToEnum(string value)
        {
            return value switch
            {
                "lanceDB" => QueryDatasetsRequestTarget.LanceDB,
                _ => null,
            };
        }
    }
}