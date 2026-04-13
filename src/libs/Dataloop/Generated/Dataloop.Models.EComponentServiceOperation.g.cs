
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum EComponentServiceOperation
    {
        /// <summary>
        /// 
        /// </summary>
        Install,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EComponentServiceOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EComponentServiceOperation value)
        {
            return value switch
            {
                EComponentServiceOperation.Install => "install",
                EComponentServiceOperation.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EComponentServiceOperation? ToEnum(string value)
        {
            return value switch
            {
                "install" => EComponentServiceOperation.Install,
                "none" => EComponentServiceOperation.None,
                _ => null,
            };
        }
    }
}