
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum AllowedTypes
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AllowedTypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AllowedTypes value)
        {
            return value switch
            {
                AllowedTypes.Boolean => "boolean",
                AllowedTypes.Number => "number",
                AllowedTypes.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AllowedTypes? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => AllowedTypes.Boolean,
                "number" => AllowedTypes.Number,
                "string" => AllowedTypes.String,
                _ => null,
            };
        }
    }
}