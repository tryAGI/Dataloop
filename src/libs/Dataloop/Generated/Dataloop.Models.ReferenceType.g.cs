
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReferenceType
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        Dpk,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Pipeline,
        /// <summary>
        /// 
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReferenceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReferenceType value)
        {
            return value switch
            {
                ReferenceType.App => "app",
                ReferenceType.Dpk => "dpk",
                ReferenceType.Model => "model",
                ReferenceType.Pipeline => "pipeline",
                ReferenceType.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReferenceType? ToEnum(string value)
        {
            return value switch
            {
                "app" => ReferenceType.App,
                "dpk" => ReferenceType.Dpk,
                "model" => ReferenceType.Model,
                "pipeline" => ReferenceType.Pipeline,
                "service" => ReferenceType.Service,
                _ => null,
            };
        }
    }
}