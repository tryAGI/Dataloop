
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReferenceQueryOperation
    {
        /// <summary>
        /// 
        /// </summary>
        Create,
        /// <summary>
        /// 
        /// </summary>
        Delete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReferenceQueryOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReferenceQueryOperation value)
        {
            return value switch
            {
                ReferenceQueryOperation.Create => "create",
                ReferenceQueryOperation.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReferenceQueryOperation? ToEnum(string value)
        {
            return value switch
            {
                "create" => ReferenceQueryOperation.Create,
                "delete" => ReferenceQueryOperation.Delete,
                _ => null,
            };
        }
    }
}