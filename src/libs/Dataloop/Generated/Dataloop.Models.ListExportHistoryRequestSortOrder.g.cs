
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListExportHistoryRequestSortOrder
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
    public static class ListExportHistoryRequestSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListExportHistoryRequestSortOrder value)
        {
            return value switch
            {
                ListExportHistoryRequestSortOrder.Asc => "ASC",
                ListExportHistoryRequestSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListExportHistoryRequestSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => ListExportHistoryRequestSortOrder.Asc,
                "DESC" => ListExportHistoryRequestSortOrder.Desc,
                _ => null,
            };
        }
    }
}