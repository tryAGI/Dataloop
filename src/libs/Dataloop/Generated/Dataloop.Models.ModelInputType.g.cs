
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelInputType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelInputType value)
        {
            return value switch
            {
                ModelInputType.Audio => "audio",
                ModelInputType.Image => "image",
                ModelInputType.Text => "text",
                ModelInputType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelInputType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => ModelInputType.Audio,
                "image" => ModelInputType.Image,
                "text" => ModelInputType.Text,
                "video" => ModelInputType.Video,
                _ => null,
            };
        }
    }
}