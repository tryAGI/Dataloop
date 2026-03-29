
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum EventResourceType
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
    public static class EventResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventResourceType value)
        {
            return value switch
            {
                EventResourceType.Accounts => "accounts",
                EventResourceType.Annotations => "annotations",
                EventResourceType.AnnotationsStatus => "annotations.status",
                EventResourceType.Apps => "apps",
                EventResourceType.Assignments => "assignments",
                EventResourceType.BillingResources => "billingResources",
                EventResourceType.Compositions => "compositions",
                EventResourceType.Datasets => "datasets",
                EventResourceType.Dpk => "dpk",
                EventResourceType.Drivers => "drivers",
                EventResourceType.Executions => "executions",
                EventResourceType.Groups => "groups",
                EventResourceType.Integrations => "integrations",
                EventResourceType.Items => "items",
                EventResourceType.ItemsStatus => "items.status",
                EventResourceType.Models => "models",
                EventResourceType.Ontologies => "ontologies",
                EventResourceType.Orgs => "orgs",
                EventResourceType.Packages => "packages",
                EventResourceType.PipelineRun => "pipeline.run",
                EventResourceType.Pipelines => "pipelines",
                EventResourceType.ProjectGuests => "projectGuests",
                EventResourceType.Projects => "projects",
                EventResourceType.Recipes => "recipes",
                EventResourceType.Services => "services",
                EventResourceType.Settings => "settings",
                EventResourceType.Subscriptions => "subscriptions",
                EventResourceType.Tasks => "tasks",
                EventResourceType.TriggerCmds => "trigger_cmds",
                EventResourceType.Triggers => "triggers",
                EventResourceType.Users => "users",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventResourceType? ToEnum(string value)
        {
            return value switch
            {
                "accounts" => EventResourceType.Accounts,
                "annotations" => EventResourceType.Annotations,
                "annotations.status" => EventResourceType.AnnotationsStatus,
                "apps" => EventResourceType.Apps,
                "assignments" => EventResourceType.Assignments,
                "billingResources" => EventResourceType.BillingResources,
                "compositions" => EventResourceType.Compositions,
                "datasets" => EventResourceType.Datasets,
                "dpk" => EventResourceType.Dpk,
                "drivers" => EventResourceType.Drivers,
                "executions" => EventResourceType.Executions,
                "groups" => EventResourceType.Groups,
                "integrations" => EventResourceType.Integrations,
                "items" => EventResourceType.Items,
                "items.status" => EventResourceType.ItemsStatus,
                "models" => EventResourceType.Models,
                "ontologies" => EventResourceType.Ontologies,
                "orgs" => EventResourceType.Orgs,
                "packages" => EventResourceType.Packages,
                "pipeline.run" => EventResourceType.PipelineRun,
                "pipelines" => EventResourceType.Pipelines,
                "projectGuests" => EventResourceType.ProjectGuests,
                "projects" => EventResourceType.Projects,
                "recipes" => EventResourceType.Recipes,
                "services" => EventResourceType.Services,
                "settings" => EventResourceType.Settings,
                "subscriptions" => EventResourceType.Subscriptions,
                "tasks" => EventResourceType.Tasks,
                "trigger_cmds" => EventResourceType.TriggerCmds,
                "triggers" => EventResourceType.Triggers,
                "users" => EventResourceType.Users,
                _ => null,
            };
        }
    }
}