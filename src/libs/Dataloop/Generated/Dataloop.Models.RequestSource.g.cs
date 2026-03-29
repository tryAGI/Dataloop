
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestSource
    {
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        Sdk,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Ui,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestSource value)
        {
            return value switch
            {
                RequestSource.Other => "other",
                RequestSource.Sdk => "sdk",
                RequestSource.System => "system",
                RequestSource.Ui => "ui",
                RequestSource.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestSource? ToEnum(string value)
        {
            return value switch
            {
                "other" => RequestSource.Other,
                "sdk" => RequestSource.Sdk,
                "system" => RequestSource.System,
                "ui" => RequestSource.Ui,
                "unknown" => RequestSource.Unknown,
                _ => null,
            };
        }
    }
}