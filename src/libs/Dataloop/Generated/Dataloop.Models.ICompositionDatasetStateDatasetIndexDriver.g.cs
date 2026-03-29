
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ICompositionDatasetStateDatasetIndexDriver
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ICompositionDatasetStateDatasetIndexDriverExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ICompositionDatasetStateDatasetIndexDriver value)
        {
            return value switch
            {
                ICompositionDatasetStateDatasetIndexDriver.V1 => "v1",
                ICompositionDatasetStateDatasetIndexDriver.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ICompositionDatasetStateDatasetIndexDriver? ToEnum(string value)
        {
            return value switch
            {
                "v1" => ICompositionDatasetStateDatasetIndexDriver.V1,
                "v2" => ICompositionDatasetStateDatasetIndexDriver.V2,
                _ => null,
            };
        }
    }
}