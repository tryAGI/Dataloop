
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelineType
    {
        /// <summary>
        /// 
        /// </summary>
        Regular,
        /// <summary>
        /// 
        /// </summary>
        Template,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineType value)
        {
            return value switch
            {
                PipelineType.Regular => "regular",
                PipelineType.Template => "template",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineType? ToEnum(string value)
        {
            return value switch
            {
                "regular" => PipelineType.Regular,
                "template" => PipelineType.Template,
                _ => null,
            };
        }
    }
}