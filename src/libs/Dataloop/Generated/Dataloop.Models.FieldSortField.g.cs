
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum FieldSortField
    {
        /// <summary>
        /// 
        /// </summary>
        Date,
        /// <summary>
        /// 
        /// </summary>
        Id,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FieldSortFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FieldSortField value)
        {
            return value switch
            {
                FieldSortField.Date => "date",
                FieldSortField.Id => "id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FieldSortField? ToEnum(string value)
        {
            return value switch
            {
                "date" => FieldSortField.Date,
                "id" => FieldSortField.Id,
                _ => null,
            };
        }
    }
}