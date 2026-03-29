
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum AttributeType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        FreeText,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Options,
        /// <summary>
        /// 
        /// </summary>
        Range,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AttributeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AttributeType value)
        {
            return value switch
            {
                AttributeType.Boolean => "boolean",
                AttributeType.FreeText => "freeText",
                AttributeType.Number => "number",
                AttributeType.Options => "options",
                AttributeType.Range => "range",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AttributeType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => AttributeType.Boolean,
                "freeText" => AttributeType.FreeText,
                "number" => AttributeType.Number,
                "options" => AttributeType.Options,
                "range" => AttributeType.Range,
                _ => null,
            };
        }
    }
}