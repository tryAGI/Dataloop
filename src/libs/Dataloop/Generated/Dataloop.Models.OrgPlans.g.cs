
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrgPlans
    {
        /// <summary>
        /// 
        /// </summary>
        Freemium,
        /// <summary>
        /// 
        /// </summary>
        Premium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgPlansExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgPlans value)
        {
            return value switch
            {
                OrgPlans.Freemium => "freemium",
                OrgPlans.Premium => "premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgPlans? ToEnum(string value)
        {
            return value switch
            {
                "freemium" => OrgPlans.Freemium,
                "premium" => OrgPlans.Premium,
                _ => null,
            };
        }
    }
}