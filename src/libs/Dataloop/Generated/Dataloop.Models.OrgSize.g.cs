
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrgSize
    {
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Small,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgSize value)
        {
            return value switch
            {
                OrgSize.Enterprise => "enterprise",
                OrgSize.Medium => "medium",
                OrgSize.Small => "small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgSize? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => OrgSize.Enterprise,
                "medium" => OrgSize.Medium,
                "small" => OrgSize.Small,
                _ => null,
            };
        }
    }
}