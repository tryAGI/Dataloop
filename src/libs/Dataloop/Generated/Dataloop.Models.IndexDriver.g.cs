
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum IndexDriver
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
    public static class IndexDriverExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IndexDriver value)
        {
            return value switch
            {
                IndexDriver.V1 => "v1",
                IndexDriver.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IndexDriver? ToEnum(string value)
        {
            return value switch
            {
                "v1" => IndexDriver.V1,
                "v2" => IndexDriver.V2,
                _ => null,
            };
        }
    }
}