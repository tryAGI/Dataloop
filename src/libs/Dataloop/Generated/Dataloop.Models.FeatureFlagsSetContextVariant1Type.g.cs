
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeatureFlagsSetContextVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Org,
        /// <summary>
        /// 
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeatureFlagsSetContextVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeatureFlagsSetContextVariant1Type value)
        {
            return value switch
            {
                FeatureFlagsSetContextVariant1Type.Org => "org",
                FeatureFlagsSetContextVariant1Type.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeatureFlagsSetContextVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "org" => FeatureFlagsSetContextVariant1Type.Org,
                "project" => FeatureFlagsSetContextVariant1Type.Project,
                _ => null,
            };
        }
    }
}