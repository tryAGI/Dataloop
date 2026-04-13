
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReplicaReason
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        ContainerCannotRun,
        /// <summary>
        /// 
        /// </summary>
        ContainerCreating,
        /// <summary>
        /// 
        /// </summary>
        CrashLoopBackOff,
        /// <summary>
        /// 
        /// </summary>
        CreateContainerConfigError,
        /// <summary>
        /// 
        /// </summary>
        CreateContainerError,
        /// <summary>
        /// 
        /// </summary>
        DeadlineExceeded,
        /// <summary>
        /// 
        /// </summary>
        ErrImagePull,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Evicted,
        /// <summary>
        /// 
        /// </summary>
        ImagePullBackOff,
        /// <summary>
        /// 
        /// </summary>
        InvalidImageName,
        /// <summary>
        /// 
        /// </summary>
        NodeAffinity,
        /// <summary>
        /// 
        /// </summary>
        NodeLost,
        /// <summary>
        /// 
        /// </summary>
        OOMKilled,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Shutdown,
        /// <summary>
        /// 
        /// </summary>
        UnexpectedAdmissionError,
        /// <summary>
        /// 
        /// </summary>
        Unschedulable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReplicaReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReplicaReason value)
        {
            return value switch
            {
                ReplicaReason.Completed => "Completed",
                ReplicaReason.ContainerCannotRun => "ContainerCannotRun",
                ReplicaReason.ContainerCreating => "ContainerCreating",
                ReplicaReason.CrashLoopBackOff => "CrashLoopBackOff",
                ReplicaReason.CreateContainerConfigError => "CreateContainerConfigError",
                ReplicaReason.CreateContainerError => "CreateContainerError",
                ReplicaReason.DeadlineExceeded => "DeadlineExceeded",
                ReplicaReason.ErrImagePull => "ErrImagePull",
                ReplicaReason.Error => "Error",
                ReplicaReason.Evicted => "Evicted",
                ReplicaReason.ImagePullBackOff => "ImagePullBackOff",
                ReplicaReason.InvalidImageName => "InvalidImageName",
                ReplicaReason.NodeAffinity => "NodeAffinity",
                ReplicaReason.NodeLost => "NodeLost",
                ReplicaReason.OOMKilled => "OOMKilled",
                ReplicaReason.Pending => "Pending",
                ReplicaReason.Shutdown => "Shutdown",
                ReplicaReason.UnexpectedAdmissionError => "UnexpectedAdmissionError",
                ReplicaReason.Unschedulable => "Unschedulable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReplicaReason? ToEnum(string value)
        {
            return value switch
            {
                "Completed" => ReplicaReason.Completed,
                "ContainerCannotRun" => ReplicaReason.ContainerCannotRun,
                "ContainerCreating" => ReplicaReason.ContainerCreating,
                "CrashLoopBackOff" => ReplicaReason.CrashLoopBackOff,
                "CreateContainerConfigError" => ReplicaReason.CreateContainerConfigError,
                "CreateContainerError" => ReplicaReason.CreateContainerError,
                "DeadlineExceeded" => ReplicaReason.DeadlineExceeded,
                "ErrImagePull" => ReplicaReason.ErrImagePull,
                "Error" => ReplicaReason.Error,
                "Evicted" => ReplicaReason.Evicted,
                "ImagePullBackOff" => ReplicaReason.ImagePullBackOff,
                "InvalidImageName" => ReplicaReason.InvalidImageName,
                "NodeAffinity" => ReplicaReason.NodeAffinity,
                "NodeLost" => ReplicaReason.NodeLost,
                "OOMKilled" => ReplicaReason.OOMKilled,
                "Pending" => ReplicaReason.Pending,
                "Shutdown" => ReplicaReason.Shutdown,
                "UnexpectedAdmissionError" => ReplicaReason.UnexpectedAdmissionError,
                "Unschedulable" => ReplicaReason.Unschedulable,
                _ => null,
            };
        }
    }
}