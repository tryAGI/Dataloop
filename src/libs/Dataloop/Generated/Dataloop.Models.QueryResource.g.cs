
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
        Composition,
        /// <summary>
        /// 
        /// </summary>
        Compute,
        /// <summary>
        /// 
        /// </summary>
        Datasets,
        /// <summary>
        /// 
        /// </summary>
        Directory,
        /// <summary>
        /// 
        /// </summary>
        Dpks,
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
        Labels,
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
        Packages,
        /// <summary>
        /// 
        /// </summary>
        Pipeline,
        /// <summary>
        /// 
        /// </summary>
        PipelineState,
        /// <summary>
        /// 
        /// </summary>
        PipelineTemplate,
        /// <summary>
        /// 
        /// </summary>
        ResourceExecution,
        /// <summary>
        /// 
        /// </summary>
        ServiceDrivers,
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
        /// <summary>
        /// 
        /// </summary>
        Triggers,
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
                QueryResource.Composition => "composition",
                QueryResource.Compute => "compute",
                QueryResource.Datasets => "datasets",
                QueryResource.Directory => "directory",
                QueryResource.Dpks => "dpks",
                QueryResource.Executions => "executions",
                QueryResource.FeatureSets => "feature_sets",
                QueryResource.FeatureVectors => "feature_vectors",
                QueryResource.Items => "items",
                QueryResource.Labels => "labels",
                QueryResource.Metrics => "metrics",
                QueryResource.Models => "models",
                QueryResource.Packages => "packages",
                QueryResource.Pipeline => "pipeline",
                QueryResource.PipelineState => "pipelineState",
                QueryResource.PipelineTemplate => "pipelineTemplate",
                QueryResource.ResourceExecution => "resourceExecution",
                QueryResource.ServiceDrivers => "serviceDrivers",
                QueryResource.Services => "services",
                QueryResource.Setting => "setting",
                QueryResource.Settings => "settings",
                QueryResource.Tasks => "tasks",
                QueryResource.Triggers => "triggers",
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
                "composition" => QueryResource.Composition,
                "compute" => QueryResource.Compute,
                "datasets" => QueryResource.Datasets,
                "directory" => QueryResource.Directory,
                "dpks" => QueryResource.Dpks,
                "executions" => QueryResource.Executions,
                "feature_sets" => QueryResource.FeatureSets,
                "feature_vectors" => QueryResource.FeatureVectors,
                "items" => QueryResource.Items,
                "labels" => QueryResource.Labels,
                "metrics" => QueryResource.Metrics,
                "models" => QueryResource.Models,
                "packages" => QueryResource.Packages,
                "pipeline" => QueryResource.Pipeline,
                "pipelineState" => QueryResource.PipelineState,
                "pipelineTemplate" => QueryResource.PipelineTemplate,
                "resourceExecution" => QueryResource.ResourceExecution,
                "serviceDrivers" => QueryResource.ServiceDrivers,
                "services" => QueryResource.Services,
                "setting" => QueryResource.Setting,
                "settings" => QueryResource.Settings,
                "tasks" => QueryResource.Tasks,
                "triggers" => QueryResource.Triggers,
                _ => null,
            };
        }
    }
}