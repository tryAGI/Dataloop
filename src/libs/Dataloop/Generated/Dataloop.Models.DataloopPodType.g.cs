
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum DataloopPodType
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
        GpuA100S,
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
    public static class DataloopPodTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataloopPodType value)
        {
            return value switch
            {
                DataloopPodType.GpuA1004g => "gpu-a100-4g",
                DataloopPodType.GpuA1004gM => "gpu-a100-4g-m",
                DataloopPodType.GpuA100S => "gpu-a100-s",
                DataloopPodType.GpuT4 => "gpu-t4",
                DataloopPodType.GpuT4M => "gpu-t4-m",
                DataloopPodType.HighmemL => "highmem-l",
                DataloopPodType.HighmemM => "highmem-m",
                DataloopPodType.HighmemS => "highmem-s",
                DataloopPodType.HighmemXs => "highmem-xs",
                DataloopPodType.RegularL => "regular-l",
                DataloopPodType.RegularM => "regular-m",
                DataloopPodType.RegularS => "regular-s",
                DataloopPodType.RegularXs => "regular-xs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataloopPodType? ToEnum(string value)
        {
            return value switch
            {
                "gpu-a100-4g" => DataloopPodType.GpuA1004g,
                "gpu-a100-4g-m" => DataloopPodType.GpuA1004gM,
                "gpu-a100-s" => DataloopPodType.GpuA100S,
                "gpu-t4" => DataloopPodType.GpuT4,
                "gpu-t4-m" => DataloopPodType.GpuT4M,
                "highmem-l" => DataloopPodType.HighmemL,
                "highmem-m" => DataloopPodType.HighmemM,
                "highmem-s" => DataloopPodType.HighmemS,
                "highmem-xs" => DataloopPodType.HighmemXs,
                "regular-l" => DataloopPodType.RegularL,
                "regular-m" => DataloopPodType.RegularM,
                "regular-s" => DataloopPodType.RegularS,
                "regular-xs" => DataloopPodType.RegularXs,
                _ => null,
            };
        }
    }
}