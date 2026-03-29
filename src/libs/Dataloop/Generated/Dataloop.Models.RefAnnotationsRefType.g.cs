
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum RefAnnotationsRefType
    {
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RefAnnotationsRefTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RefAnnotationsRefType value)
        {
            return value switch
            {
                RefAnnotationsRefType.Id => "id",
                RefAnnotationsRefType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RefAnnotationsRefType? ToEnum(string value)
        {
            return value switch
            {
                "id" => RefAnnotationsRefType.Id,
                "url" => RefAnnotationsRefType.Url,
                _ => null,
            };
        }
    }
}