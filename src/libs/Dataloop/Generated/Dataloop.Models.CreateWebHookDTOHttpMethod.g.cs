
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWebHookDTOHttpMethod
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
    public static class CreateWebHookDTOHttpMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWebHookDTOHttpMethod value)
        {
            return value switch
            {
                CreateWebHookDTOHttpMethod.Get => "GET",
                CreateWebHookDTOHttpMethod.Post => "POST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWebHookDTOHttpMethod? ToEnum(string value)
        {
            return value switch
            {
                "GET" => CreateWebHookDTOHttpMethod.Get,
                "POST" => CreateWebHookDTOHttpMethod.Post,
                _ => null,
            };
        }
    }
}