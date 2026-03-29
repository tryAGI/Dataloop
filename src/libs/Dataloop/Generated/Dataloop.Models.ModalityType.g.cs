
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModalityType
    {
        /// <summary>
        /// 
        /// </summary>
        Overlay,
        /// <summary>
        /// 
        /// </summary>
        Preview,
        /// <summary>
        /// 
        /// </summary>
        Related,
        /// <summary>
        /// 
        /// </summary>
        Replace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModalityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModalityType value)
        {
            return value switch
            {
                ModalityType.Overlay => "overlay",
                ModalityType.Preview => "preview",
                ModalityType.Related => "related",
                ModalityType.Replace => "replace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModalityType? ToEnum(string value)
        {
            return value switch
            {
                "overlay" => ModalityType.Overlay,
                "preview" => ModalityType.Preview,
                "related" => ModalityType.Related,
                "replace" => ModalityType.Replace,
                _ => null,
            };
        }
    }
}