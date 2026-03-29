
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrgIndustry
    {
        /// <summary>
        /// 
        /// </summary>
        AerialImagery,
        /// <summary>
        /// 
        /// </summary>
        Agriculture,
        /// <summary>
        /// 
        /// </summary>
        Automotive,
        /// <summary>
        /// 
        /// </summary>
        Media,
        /// <summary>
        /// 
        /// </summary>
        Medical,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        Retail,
        /// <summary>
        /// 
        /// </summary>
        Sports,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgIndustryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgIndustry value)
        {
            return value switch
            {
                OrgIndustry.AerialImagery => "aerialImagery",
                OrgIndustry.Agriculture => "agriculture",
                OrgIndustry.Automotive => "automotive",
                OrgIndustry.Media => "media",
                OrgIndustry.Medical => "medical",
                OrgIndustry.Other => "other",
                OrgIndustry.Retail => "retail",
                OrgIndustry.Sports => "sports",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgIndustry? ToEnum(string value)
        {
            return value switch
            {
                "aerialImagery" => OrgIndustry.AerialImagery,
                "agriculture" => OrgIndustry.Agriculture,
                "automotive" => OrgIndustry.Automotive,
                "media" => OrgIndustry.Media,
                "medical" => OrgIndustry.Medical,
                "other" => OrgIndustry.Other,
                "retail" => OrgIndustry.Retail,
                "sports" => OrgIndustry.Sports,
                _ => null,
            };
        }
    }
}