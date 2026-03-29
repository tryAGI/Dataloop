
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListExportHistoryRequestSortBy
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
    public static class ListExportHistoryRequestSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListExportHistoryRequestSortBy value)
        {
            return value switch
            {
                ListExportHistoryRequestSortBy.CreatedAt => "createdAt",
                ListExportHistoryRequestSortBy.UpdatedAt => "updatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListExportHistoryRequestSortBy? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => ListExportHistoryRequestSortBy.CreatedAt,
                "updatedAt" => ListExportHistoryRequestSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}