
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateWebHookDTOHttpMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Get,
        /// <summary>
        /// 
        /// </summary>
        Post,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateWebHookDTOHttpMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateWebHookDTOHttpMethod value)
        {
            return value switch
            {
                UpdateWebHookDTOHttpMethod.Get => "GET",
                UpdateWebHookDTOHttpMethod.Post => "POST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateWebHookDTOHttpMethod? ToEnum(string value)
        {
            return value switch
            {
                "GET" => UpdateWebHookDTOHttpMethod.Get,
                "POST" => UpdateWebHookDTOHttpMethod.Post,
                _ => null,
            };
        }
    }
}