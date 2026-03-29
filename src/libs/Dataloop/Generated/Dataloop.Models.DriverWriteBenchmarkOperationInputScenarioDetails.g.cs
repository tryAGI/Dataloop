
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum DriverWriteBenchmarkOperationInputScenarioDetails
    {
        /// <summary>
        /// 
        /// </summary>
        LargeFile,
        /// <summary>
        /// 
        /// </summary>
        MediumFile,
        /// <summary>
        /// 
        /// </summary>
        SmallFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DriverWriteBenchmarkOperationInputScenarioDetailsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DriverWriteBenchmarkOperationInputScenarioDetails value)
        {
            return value switch
            {
                DriverWriteBenchmarkOperationInputScenarioDetails.LargeFile => "largeFile",
                DriverWriteBenchmarkOperationInputScenarioDetails.MediumFile => "mediumFile",
                DriverWriteBenchmarkOperationInputScenarioDetails.SmallFile => "smallFile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DriverWriteBenchmarkOperationInputScenarioDetails? ToEnum(string value)
        {
            return value switch
            {
                "largeFile" => DriverWriteBenchmarkOperationInputScenarioDetails.LargeFile,
                "mediumFile" => DriverWriteBenchmarkOperationInputScenarioDetails.MediumFile,
                "smallFile" => DriverWriteBenchmarkOperationInputScenarioDetails.SmallFile,
                _ => null,
            };
        }
    }
}