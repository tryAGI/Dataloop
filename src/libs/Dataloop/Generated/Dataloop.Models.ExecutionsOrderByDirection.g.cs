
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExecutionsOrderByDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecutionsOrderByDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionsOrderByDirection value)
        {
            return value switch
            {
                ExecutionsOrderByDirection.Asc => "asc",
                ExecutionsOrderByDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionsOrderByDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ExecutionsOrderByDirection.Asc,
                "desc" => ExecutionsOrderByDirection.Desc,
                _ => null,
            };
        }
    }
}