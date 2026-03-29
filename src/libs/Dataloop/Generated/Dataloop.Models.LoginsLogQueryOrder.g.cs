
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum LoginsLogQueryOrder
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
    public static class LoginsLogQueryOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LoginsLogQueryOrder value)
        {
            return value switch
            {
                LoginsLogQueryOrder.Asc => "ASC",
                LoginsLogQueryOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LoginsLogQueryOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => LoginsLogQueryOrder.Asc,
                "DESC" => LoginsLogQueryOrder.Desc,
                _ => null,
            };
        }
    }
}