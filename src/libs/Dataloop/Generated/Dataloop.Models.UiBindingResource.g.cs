
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum UiBindingResource
    {
        /// <summary>
        /// 
        /// </summary>
        Annotation,
        /// <summary>
        /// 
        /// </summary>
        Assignment,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        DatasetQuery,
        /// <summary>
        /// 
        /// </summary>
        Item,
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        Task,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UiBindingResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UiBindingResource value)
        {
            return value switch
            {
                UiBindingResource.Annotation => "annotation",
                UiBindingResource.Assignment => "assignment",
                UiBindingResource.Dataset => "dataset",
                UiBindingResource.DatasetQuery => "datasetQuery",
                UiBindingResource.Item => "item",
                UiBindingResource.Project => "project",
                UiBindingResource.Task => "task",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UiBindingResource? ToEnum(string value)
        {
            return value switch
            {
                "annotation" => UiBindingResource.Annotation,
                "assignment" => UiBindingResource.Assignment,
                "dataset" => UiBindingResource.Dataset,
                "datasetQuery" => UiBindingResource.DatasetQuery,
                "item" => UiBindingResource.Item,
                "project" => UiBindingResource.Project,
                "task" => UiBindingResource.Task,
                _ => null,
            };
        }
    }
}