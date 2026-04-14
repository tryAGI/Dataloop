
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobStatusEnum value)
        {
            return value switch
            {
                JobStatusEnum.Created => "created",
                JobStatusEnum.Failure => "failure",
                JobStatusEnum.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "created" => JobStatusEnum.Created,
                "failure" => JobStatusEnum.Failure,
                "success" => JobStatusEnum.Success,
                _ => null,
            };
        }
    }
}