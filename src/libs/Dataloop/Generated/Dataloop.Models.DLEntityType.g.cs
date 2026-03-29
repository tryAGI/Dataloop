
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum DLEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        Account,
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
        Execution,
        /// <summary>
        /// 
        /// </summary>
        Group,
        /// <summary>
        /// 
        /// </summary>
        Item,
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Ontology,
        /// <summary>
        /// 
        /// </summary>
        Org,
        /// <summary>
        /// 
        /// </summary>
        Package,
        /// <summary>
        /// 
        /// </summary>
        Plan,
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        Qouta,
        /// <summary>
        /// 
        /// </summary>
        Recipe,
        /// <summary>
        /// 
        /// </summary>
        Service,
        /// <summary>
        /// 
        /// </summary>
        Subscription,
        /// <summary>
        /// 
        /// </summary>
        Task,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DLEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DLEntityType value)
        {
            return value switch
            {
                DLEntityType.Account => "account",
                DLEntityType.Annotation => "annotation",
                DLEntityType.Assignment => "assignment",
                DLEntityType.Dataset => "dataset",
                DLEntityType.Execution => "execution",
                DLEntityType.Group => "group",
                DLEntityType.Item => "item",
                DLEntityType.Member => "member",
                DLEntityType.Model => "model",
                DLEntityType.Ontology => "ontology",
                DLEntityType.Org => "org",
                DLEntityType.Package => "package",
                DLEntityType.Plan => "plan",
                DLEntityType.Project => "project",
                DLEntityType.Qouta => "qouta",
                DLEntityType.Recipe => "recipe",
                DLEntityType.Service => "service",
                DLEntityType.Subscription => "subscription",
                DLEntityType.Task => "task",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DLEntityType? ToEnum(string value)
        {
            return value switch
            {
                "account" => DLEntityType.Account,
                "annotation" => DLEntityType.Annotation,
                "assignment" => DLEntityType.Assignment,
                "dataset" => DLEntityType.Dataset,
                "execution" => DLEntityType.Execution,
                "group" => DLEntityType.Group,
                "item" => DLEntityType.Item,
                "member" => DLEntityType.Member,
                "model" => DLEntityType.Model,
                "ontology" => DLEntityType.Ontology,
                "org" => DLEntityType.Org,
                "package" => DLEntityType.Package,
                "plan" => DLEntityType.Plan,
                "project" => DLEntityType.Project,
                "qouta" => DLEntityType.Qouta,
                "recipe" => DLEntityType.Recipe,
                "service" => DLEntityType.Service,
                "subscription" => DLEntityType.Subscription,
                "task" => DLEntityType.Task,
                _ => null,
            };
        }
    }
}