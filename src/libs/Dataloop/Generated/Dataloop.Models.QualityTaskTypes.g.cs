
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum QualityTaskTypes
    {
        /// <summary>
        /// 
        /// </summary>
        Consensus,
        /// <summary>
        /// 
        /// </summary>
        Honeypot,
        /// <summary>
        /// 
        /// </summary>
        Qualification,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QualityTaskTypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityTaskTypes value)
        {
            return value switch
            {
                QualityTaskTypes.Consensus => "consensus",
                QualityTaskTypes.Honeypot => "honeypot",
                QualityTaskTypes.Qualification => "qualification",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityTaskTypes? ToEnum(string value)
        {
            return value switch
            {
                "consensus" => QualityTaskTypes.Consensus,
                "honeypot" => QualityTaskTypes.Honeypot,
                "qualification" => QualityTaskTypes.Qualification,
                _ => null,
            };
        }
    }
}