
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelineFromTemplateState
    {
        /// <summary>
        /// 
        /// </summary>
        Dirty,
        /// <summary>
        /// 
        /// </summary>
        Initial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelineFromTemplateStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelineFromTemplateState value)
        {
            return value switch
            {
                PipelineFromTemplateState.Dirty => "dirty",
                PipelineFromTemplateState.Initial => "initial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelineFromTemplateState? ToEnum(string value)
        {
            return value switch
            {
                "dirty" => PipelineFromTemplateState.Dirty,
                "initial" => PipelineFromTemplateState.Initial,
                _ => null,
            };
        }
    }
}