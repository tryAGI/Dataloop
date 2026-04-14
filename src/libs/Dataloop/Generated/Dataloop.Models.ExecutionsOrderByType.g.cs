
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExecutionsOrderByType
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecutionsOrderByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionsOrderByType value)
        {
            return value switch
            {
                ExecutionsOrderByType.CreatedAt => "createdAt",
                ExecutionsOrderByType.UpdatedAt => "updatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionsOrderByType? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => ExecutionsOrderByType.CreatedAt,
                "updatedAt" => ExecutionsOrderByType.UpdatedAt,
                _ => null,
            };
        }
    }
}