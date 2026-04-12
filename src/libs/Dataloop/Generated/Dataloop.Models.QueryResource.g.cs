
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueryResource
    {
        /// <summary>
        /// 
        /// </summary>
        Annotations,
        /// <summary>
        /// 
        /// </summary>
        Apps,
        /// <summary>
        /// 
        /// </summary>
        Assignments,
        /// <summary>
        /// 
        /// </summary>
        Datasets,
        /// <summary>
        /// 
        /// </summary>
        Executions,
        /// <summary>
        /// 
        /// </summary>
        FeatureSets,
        /// <summary>
        /// 
        /// </summary>
        FeatureVectors,
        /// <summary>
        /// 
        /// </summary>
        Items,
        /// <summary>
        /// 
        /// </summary>
        Metrics,
        /// <summary>
        /// 
        /// </summary>
        Models,
        /// <summary>
        /// 
        /// </summary>
        Services,
        /// <summary>
        /// 
        /// </summary>
        Setting,
        /// <summary>
        /// 
        /// </summary>
        Settings,
        /// <summary>
        /// 
        /// </summary>
        Tasks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryResource value)
        {
            return value switch
            {
                QueryResource.Annotations => "annotations",
                QueryResource.Apps => "apps",
                QueryResource.Assignments => "assignments",
                QueryResource.Datasets => "datasets",
                QueryResource.Executions => "executions",
                QueryResource.FeatureSets => "feature_sets",
                QueryResource.FeatureVectors => "feature_vectors",
                QueryResource.Items => "items",
                QueryResource.Metrics => "metrics",
                QueryResource.Models => "models",
                QueryResource.Services => "services",
                QueryResource.Setting => "setting",
                QueryResource.Settings => "settings",
                QueryResource.Tasks => "tasks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryResource? ToEnum(string value)
        {
            return value switch
            {
                "annotations" => QueryResource.Annotations,
                "apps" => QueryResource.Apps,
                "assignments" => QueryResource.Assignments,
                "datasets" => QueryResource.Datasets,
                "executions" => QueryResource.Executions,
                "feature_sets" => QueryResource.FeatureSets,
                "feature_vectors" => QueryResource.FeatureVectors,
                "items" => QueryResource.Items,
                "metrics" => QueryResource.Metrics,
                "models" => QueryResource.Models,
                "services" => QueryResource.Services,
                "setting" => QueryResource.Setting,
                "settings" => QueryResource.Settings,
                "tasks" => QueryResource.Tasks,
                _ => null,
            };
        }
    }
}