
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum MetricGroup
    {
        /// <summary>
        /// 
        /// </summary>
        AnnotationToolStudios,
        /// <summary>
        /// 
        /// </summary>
        CustomerCare,
        /// <summary>
        /// 
        /// </summary>
        CustomerSupport,
        /// <summary>
        /// 
        /// </summary>
        DataQaTools,
        /// <summary>
        /// 
        /// </summary>
        DataManagement,
        /// <summary>
        /// 
        /// </summary>
        DataPipelines,
        /// <summary>
        /// 
        /// </summary>
        EnterpriseFeatures,
        /// <summary>
        /// 
        /// </summary>
        General,
        /// <summary>
        /// 
        /// </summary>
        WorkforceManagement,
        /// <summary>
        /// 
        /// </summary>
        Automation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetricGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetricGroup value)
        {
            return value switch
            {
                MetricGroup.AnnotationToolStudios => "Annotation tool studios",
                MetricGroup.CustomerCare => "Customer care",
                MetricGroup.CustomerSupport => "Customer support",
                MetricGroup.DataQaTools => "Data QA tools",
                MetricGroup.DataManagement => "Data management",
                MetricGroup.DataPipelines => "Data pipelines",
                MetricGroup.EnterpriseFeatures => "Enterprise features",
                MetricGroup.General => "General",
                MetricGroup.WorkforceManagement => "Workforce management",
                MetricGroup.Automation => "automation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetricGroup? ToEnum(string value)
        {
            return value switch
            {
                "Annotation tool studios" => MetricGroup.AnnotationToolStudios,
                "Customer care" => MetricGroup.CustomerCare,
                "Customer support" => MetricGroup.CustomerSupport,
                "Data QA tools" => MetricGroup.DataQaTools,
                "Data management" => MetricGroup.DataManagement,
                "Data pipelines" => MetricGroup.DataPipelines,
                "Enterprise features" => MetricGroup.EnterpriseFeatures,
                "General" => MetricGroup.General,
                "Workforce management" => MetricGroup.WorkforceManagement,
                "automation" => MetricGroup.Automation,
                _ => null,
            };
        }
    }
}