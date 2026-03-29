
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cloning,
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Deployed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        PreTrained,
        /// <summary>
        /// 
        /// </summary>
        Trained,
        /// <summary>
        /// 
        /// </summary>
        Training,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelStatus value)
        {
            return value switch
            {
                ModelStatus.Cloning => "cloning",
                ModelStatus.Created => "created",
                ModelStatus.Deployed => "deployed",
                ModelStatus.Failed => "failed",
                ModelStatus.Pending => "pending",
                ModelStatus.PreTrained => "pre-trained",
                ModelStatus.Trained => "trained",
                ModelStatus.Training => "training",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "cloning" => ModelStatus.Cloning,
                "created" => ModelStatus.Created,
                "deployed" => ModelStatus.Deployed,
                "failed" => ModelStatus.Failed,
                "pending" => ModelStatus.Pending,
                "pre-trained" => ModelStatus.PreTrained,
                "trained" => ModelStatus.Trained,
                "training" => ModelStatus.Training,
                _ => null,
            };
        }
    }
}