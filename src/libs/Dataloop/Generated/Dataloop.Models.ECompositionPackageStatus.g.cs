
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ECompositionPackageStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Installed,
        /// <summary>
        /// 
        /// </summary>
        Placed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ECompositionPackageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ECompositionPackageStatus value)
        {
            return value switch
            {
                ECompositionPackageStatus.Deleted => "deleted",
                ECompositionPackageStatus.Failed => "failed",
                ECompositionPackageStatus.Installed => "installed",
                ECompositionPackageStatus.Placed => "placed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ECompositionPackageStatus? ToEnum(string value)
        {
            return value switch
            {
                "deleted" => ECompositionPackageStatus.Deleted,
                "failed" => ECompositionPackageStatus.Failed,
                "installed" => ECompositionPackageStatus.Installed,
                "placed" => ECompositionPackageStatus.Placed,
                _ => null,
            };
        }
    }
}