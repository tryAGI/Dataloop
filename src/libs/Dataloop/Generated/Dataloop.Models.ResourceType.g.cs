
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Accounts,
        /// <summary>
        /// 
        /// </summary>
        Annotations,
        /// <summary>
        /// 
        /// </summary>
        AnnotationsStatus,
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
        BillingResources,
        /// <summary>
        /// 
        /// </summary>
        Compositions,
        /// <summary>
        /// 
        /// </summary>
        Datasets,
        /// <summary>
        /// 
        /// </summary>
        Dpk,
        /// <summary>
        /// 
        /// </summary>
        Drivers,
        /// <summary>
        /// 
        /// </summary>
        Executions,
        /// <summary>
        /// 
        /// </summary>
        Groups,
        /// <summary>
        /// 
        /// </summary>
        Integrations,
        /// <summary>
        /// 
        /// </summary>
        Items,
        /// <summary>
        /// 
        /// </summary>
        ItemsStatus,
        /// <summary>
        /// 
        /// </summary>
        Models,
        /// <summary>
        /// 
        /// </summary>
        Ontologies,
        /// <summary>
        /// 
        /// </summary>
        Orgs,
        /// <summary>
        /// 
        /// </summary>
        Packages,
        /// <summary>
        /// 
        /// </summary>
        PipelineRun,
        /// <summary>
        /// 
        /// </summary>
        Pipelines,
        /// <summary>
        /// 
        /// </summary>
        ProjectGuests,
        /// <summary>
        /// 
        /// </summary>
        Projects,
        /// <summary>
        /// 
        /// </summary>
        Recipes,
        /// <summary>
        /// 
        /// </summary>
        Services,
        /// <summary>
        /// 
        /// </summary>
        Settings,
        /// <summary>
        /// 
        /// </summary>
        Subscriptions,
        /// <summary>
        /// 
        /// </summary>
        Tasks,
        /// <summary>
        /// 
        /// </summary>
        TriggerCmds,
        /// <summary>
        /// 
        /// </summary>
        Triggers,
        /// <summary>
        /// 
        /// </summary>
        Users,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResourceType value)
        {
            return value switch
            {
                ResourceType.Accounts => "accounts",
                ResourceType.Annotations => "annotations",
                ResourceType.AnnotationsStatus => "annotations.status",
                ResourceType.Apps => "apps",
                ResourceType.Assignments => "assignments",
                ResourceType.BillingResources => "billingResources",
                ResourceType.Compositions => "compositions",
                ResourceType.Datasets => "datasets",
                ResourceType.Dpk => "dpk",
                ResourceType.Drivers => "drivers",
                ResourceType.Executions => "executions",
                ResourceType.Groups => "groups",
                ResourceType.Integrations => "integrations",
                ResourceType.Items => "items",
                ResourceType.ItemsStatus => "items.status",
                ResourceType.Models => "models",
                ResourceType.Ontologies => "ontologies",
                ResourceType.Orgs => "orgs",
                ResourceType.Packages => "packages",
                ResourceType.PipelineRun => "pipeline.run",
                ResourceType.Pipelines => "pipelines",
                ResourceType.ProjectGuests => "projectGuests",
                ResourceType.Projects => "projects",
                ResourceType.Recipes => "recipes",
                ResourceType.Services => "services",
                ResourceType.Settings => "settings",
                ResourceType.Subscriptions => "subscriptions",
                ResourceType.Tasks => "tasks",
                ResourceType.TriggerCmds => "trigger_cmds",
                ResourceType.Triggers => "triggers",
                ResourceType.Users => "users",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResourceType? ToEnum(string value)
        {
            return value switch
            {
                "accounts" => ResourceType.Accounts,
                "annotations" => ResourceType.Annotations,
                "annotations.status" => ResourceType.AnnotationsStatus,
                "apps" => ResourceType.Apps,
                "assignments" => ResourceType.Assignments,
                "billingResources" => ResourceType.BillingResources,
                "compositions" => ResourceType.Compositions,
                "datasets" => ResourceType.Datasets,
                "dpk" => ResourceType.Dpk,
                "drivers" => ResourceType.Drivers,
                "executions" => ResourceType.Executions,
                "groups" => ResourceType.Groups,
                "integrations" => ResourceType.Integrations,
                "items" => ResourceType.Items,
                "items.status" => ResourceType.ItemsStatus,
                "models" => ResourceType.Models,
                "ontologies" => ResourceType.Ontologies,
                "orgs" => ResourceType.Orgs,
                "packages" => ResourceType.Packages,
                "pipeline.run" => ResourceType.PipelineRun,
                "pipelines" => ResourceType.Pipelines,
                "projectGuests" => ResourceType.ProjectGuests,
                "projects" => ResourceType.Projects,
                "recipes" => ResourceType.Recipes,
                "services" => ResourceType.Services,
                "settings" => ResourceType.Settings,
                "subscriptions" => ResourceType.Subscriptions,
                "tasks" => ResourceType.Tasks,
                "trigger_cmds" => ResourceType.TriggerCmds,
                "triggers" => ResourceType.Triggers,
                "users" => ResourceType.Users,
                _ => null,
            };
        }
    }
}