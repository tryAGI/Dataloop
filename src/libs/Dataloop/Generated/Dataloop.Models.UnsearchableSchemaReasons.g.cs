
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnsearchableSchemaReasons
    {
        /// <summary>
        /// 
        /// </summary>
        Manual,
        /// <summary>
        /// 
        /// </summary>
        PathContainsArray,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnsearchableSchemaReasonsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnsearchableSchemaReasons value)
        {
            return value switch
            {
                UnsearchableSchemaReasons.Manual => "manual",
                UnsearchableSchemaReasons.PathContainsArray => "path contains array",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnsearchableSchemaReasons? ToEnum(string value)
        {
            return value switch
            {
                "manual" => UnsearchableSchemaReasons.Manual,
                "path contains array" => UnsearchableSchemaReasons.PathContainsArray,
                _ => null,
            };
        }
    }
}