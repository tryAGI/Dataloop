
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum PodType
    {
        /// <summary>
        /// 
        /// </summary>
        GpuA1004g,
        /// <summary>
        /// 
        /// </summary>
        GpuA1004gM,
        /// <summary>
        /// 
        /// </summary>
        GpuA100M,
        /// <summary>
        /// 
        /// </summary>
        GpuA100S,
        /// <summary>
        /// 
        /// </summary>
        GpuK80M,
        /// <summary>
        /// 
        /// </summary>
        GpuK80S,
        /// <summary>
        /// 
        /// </summary>
        GpuT4,
        /// <summary>
        /// 
        /// </summary>
        GpuT4M,
        /// <summary>
        /// 
        /// </summary>
        HighmemL,
        /// <summary>
        /// 
        /// </summary>
        HighmemM,
        /// <summary>
        /// 
        /// </summary>
        HighmemS,
        /// <summary>
        /// 
        /// </summary>
        HighmemXs,
        /// <summary>
        /// 
        /// </summary>
        RegularL,
        /// <summary>
        /// 
        /// </summary>
        RegularM,
        /// <summary>
        /// 
        /// </summary>
        RegularS,
        /// <summary>
        /// 
        /// </summary>
        RegularXs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PodTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PodType value)
        {
            return value switch
            {
                PodType.GpuA1004g => "gpu-a100-4g",
                PodType.GpuA1004gM => "gpu-a100-4g-m",
                PodType.GpuA100M => "gpu-a100-m",
                PodType.GpuA100S => "gpu-a100-s",
                PodType.GpuK80M => "gpu-k80-m",
                PodType.GpuK80S => "gpu-k80-s",
                PodType.GpuT4 => "gpu-t4",
                PodType.GpuT4M => "gpu-t4-m",
                PodType.HighmemL => "highmem-l",
                PodType.HighmemM => "highmem-m",
                PodType.HighmemS => "highmem-s",
                PodType.HighmemXs => "highmem-xs",
                PodType.RegularL => "regular-l",
                PodType.RegularM => "regular-m",
                PodType.RegularS => "regular-s",
                PodType.RegularXs => "regular-xs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PodType? ToEnum(string value)
        {
            return value switch
            {
                "gpu-a100-4g" => PodType.GpuA1004g,
                "gpu-a100-4g-m" => PodType.GpuA1004gM,
                "gpu-a100-m" => PodType.GpuA100M,
                "gpu-a100-s" => PodType.GpuA100S,
                "gpu-k80-m" => PodType.GpuK80M,
                "gpu-k80-s" => PodType.GpuK80S,
                "gpu-t4" => PodType.GpuT4,
                "gpu-t4-m" => PodType.GpuT4M,
                "highmem-l" => PodType.HighmemL,
                "highmem-m" => PodType.HighmemM,
                "highmem-s" => PodType.HighmemS,
                "highmem-xs" => PodType.HighmemXs,
                "regular-l" => PodType.RegularL,
                "regular-m" => PodType.RegularM,
                "regular-s" => PodType.RegularS,
                "regular-xs" => PodType.RegularXs,
                _ => null,
            };
        }
    }
}