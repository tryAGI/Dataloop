
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum DriverReadBenchmarkOperationInputScenarioDetails
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
    public static class DriverReadBenchmarkOperationInputScenarioDetailsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DriverReadBenchmarkOperationInputScenarioDetails value)
        {
            return value switch
            {
                DriverReadBenchmarkOperationInputScenarioDetails.LargeFile => "largeFile",
                DriverReadBenchmarkOperationInputScenarioDetails.MediumFile => "mediumFile",
                DriverReadBenchmarkOperationInputScenarioDetails.SmallFile => "smallFile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DriverReadBenchmarkOperationInputScenarioDetails? ToEnum(string value)
        {
            return value switch
            {
                "largeFile" => DriverReadBenchmarkOperationInputScenarioDetails.LargeFile,
                "mediumFile" => DriverReadBenchmarkOperationInputScenarioDetails.MediumFile,
                "smallFile" => DriverReadBenchmarkOperationInputScenarioDetails.SmallFile,
                _ => null,
            };
        }
    }
}