
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ECacheMode
    {
        /// <summary>
        /// 
        /// </summary>
        Apply,
        /// <summary>
        /// 
        /// </summary>
        ApplyFilestore,
        /// <summary>
        /// 
        /// </summary>
        Destroy,
        /// <summary>
        /// 
        /// </summary>
        Get,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ECacheModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ECacheMode value)
        {
            return value switch
            {
                ECacheMode.Apply => "apply",
                ECacheMode.ApplyFilestore => "apply-filestore",
                ECacheMode.Destroy => "destroy",
                ECacheMode.Get => "get",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ECacheMode? ToEnum(string value)
        {
            return value switch
            {
                "apply" => ECacheMode.Apply,
                "apply-filestore" => ECacheMode.ApplyFilestore,
                "destroy" => ECacheMode.Destroy,
                "get" => ECacheMode.Get,
                _ => null,
            };
        }
    }
}