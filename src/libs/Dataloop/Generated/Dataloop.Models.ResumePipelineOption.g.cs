
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResumePipelineOption
    {
        /// <summary>
        /// 
        /// </summary>
        ResumeExistingCycles,
        /// <summary>
        /// 
        /// </summary>
        TerminateExistingCycles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResumePipelineOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResumePipelineOption value)
        {
            return value switch
            {
                ResumePipelineOption.ResumeExistingCycles => "resumeExistingCycles",
                ResumePipelineOption.TerminateExistingCycles => "terminateExistingCycles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResumePipelineOption? ToEnum(string value)
        {
            return value switch
            {
                "resumeExistingCycles" => ResumePipelineOption.ResumeExistingCycles,
                "terminateExistingCycles" => ResumePipelineOption.TerminateExistingCycles,
                _ => null,
            };
        }
    }
}