
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum FieldSortDirection
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
    public static class FieldSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FieldSortDirection value)
        {
            return value switch
            {
                FieldSortDirection.Asc => "asc",
                FieldSortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FieldSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => FieldSortDirection.Asc,
                "desc" => FieldSortDirection.Desc,
                _ => null,
            };
        }
    }
}