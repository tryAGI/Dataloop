
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueryResourceDatasets
    {
        /// <summary>
        /// 
        /// </summary>
        Datasets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryResourceDatasetsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryResourceDatasets value)
        {
            return value switch
            {
                QueryResourceDatasets.Datasets => "datasets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryResourceDatasets? ToEnum(string value)
        {
            return value switch
            {
                "datasets" => QueryResourceDatasets.Datasets,
                _ => null,
            };
        }
    }
}