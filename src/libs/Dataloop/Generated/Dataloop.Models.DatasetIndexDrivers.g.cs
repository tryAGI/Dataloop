
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum DatasetIndexDrivers
    {
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
    public static class DatasetIndexDriversExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetIndexDrivers value)
        {
            return value switch
            {
                DatasetIndexDrivers.Mongo => "mongo",
                DatasetIndexDrivers.Sql => "sql",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetIndexDrivers? ToEnum(string value)
        {
            return value switch
            {
                "mongo" => DatasetIndexDrivers.Mongo,
                "sql" => DatasetIndexDrivers.Sql,
                _ => null,
            };
        }
    }
}