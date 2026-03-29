
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// determines status of S2 sync for this dataset
    /// </summary>
    public enum DatasetSyncStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetSyncStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetSyncStatus value)
        {
            return value switch
            {
                DatasetSyncStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetSyncStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => DatasetSyncStatus.Failed,
                _ => null,
            };
        }
    }
}