
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum BillingResourceKey
    {
        /// <summary>
        /// 
        /// </summary>
        AccessToCustomerSuccessRepresentationPool,
        /// <summary>
        /// 
        /// </summary>
        AdvancedAnalyticsHistory,
        /// <summary>
        /// 
        /// </summary>
        AiVideoTracker,
        /// <summary>
        /// 
        /// </summary>
        AnalyticsDashboard,
        /// <summary>
        /// 
        /// </summary>
        AnnotationToolHours,
        /// <summary>
        /// 
        /// </summary>
        ApiAccess,
        /// <summary>
        /// 
        /// </summary>
        ApiCalls,
        /// <summary>
        /// 
        /// </summary>
        AutoAnnotationTools,
        /// <summary>
        /// 
        /// </summary>
        ComputeBudget,
        /// <summary>
        /// 
        /// </summary>
        ComputeCpuHighmemL,
        /// <summary>
        /// 
        /// </summary>
        ComputeCpuHighmemM,
        /// <summary>
        /// 
        /// </summary>
        ComputeCpuHighmemS,
        /// <summary>
        /// 
        /// </summary>
        ComputeCpuHighmemXs,
        /// <summary>
        /// 
        /// </summary>
        ComputeCpuRegularL,
        /// <summary>
        /// 
        /// </summary>
        ComputeCpuRegularM,
        /// <summary>
        /// 
        /// </summary>
        ComputeCpuRegularS,
        /// <summary>
        /// 
        /// </summary>
        ComputeCpuRegularXs,
        /// <summary>
        /// 
        /// </summary>
        ComputeGpuA1004g,
        /// <summary>
        /// 
        /// </summary>
        ComputeGpuA1004gM,
        /// <summary>
        /// 
        /// </summary>
        ComputeGpuA100M,
        /// <summary>
        /// 
        /// </summary>
        ComputeGpuA100S,
        /// <summary>
        /// 
        /// </summary>
        ComputeGpuK80M,
        /// <summary>
        /// 
        /// </summary>
        ComputeGpuK80S,
        /// <summary>
        /// 
        /// </summary>
        ComputeGpuT4,
        /// <summary>
        /// 
        /// </summary>
        ComputeGpuT4M,
        /// <summary>
        /// 
        /// </summary>
        CustomProjectDashboard,
        /// <summary>
        /// 
        /// </summary>
        DataBugTracking,
        /// <summary>
        /// 
        /// </summary>
        DataPipelineFilters,
        /// <summary>
        /// 
        /// </summary>
        DataPoints,
        /// <summary>
        /// 
        /// </summary>
        DataVersioning,
        /// <summary>
        /// 
        /// </summary>
        DataVisualization,
        /// <summary>
        /// 
        /// </summary>
        DebugAndGuideViaTrackingSys,
        /// <summary>
        /// 
        /// </summary>
        DedicatedCustomerSuccess,
        /// <summary>
        /// 
        /// </summary>
        DefaultAnnotationStudios,
        /// <summary>
        /// 
        /// </summary>
        DeveloperSuccessAssistance,
        /// <summary>
        /// 
        /// </summary>
        EmailCustomerSupport,
        /// <summary>
        /// 
        /// </summary>
        EngineeringConsulting,
        /// <summary>
        /// 
        /// </summary>
        EnterpriseSupportSla,
        /// <summary>
        /// 
        /// </summary>
        Faas,
        /// <summary>
        /// 
        /// </summary>
        Faq,
        /// <summary>
        /// 
        /// </summary>
        HostedStorage,
        /// <summary>
        /// 
        /// </summary>
        HumanTasks,
        /// <summary>
        /// 
        /// </summary>
        IngestedDataPoints,
        /// <summary>
        /// 
        /// </summary>
        InstructionalVideoLibraryAccess,
        /// <summary>
        /// 
        /// </summary>
        IpWhitelist,
        /// <summary>
        /// 
        /// </summary>
        KnowledgeBase,
        /// <summary>
        /// 
        /// </summary>
        Lidar,
        /// <summary>
        /// 
        /// </summary>
        ManagedLabelingService,
        /// <summary>
        /// 
        /// </summary>
        MetadataSearch,
        /// <summary>
        /// 
        /// </summary>
        MfaIntegration,
        /// <summary>
        /// 
        /// </summary>
        MlModelAssistedAnnotation,
        /// <summary>
        /// 
        /// </summary>
        ModelManagement,
        /// <summary>
        /// 
        /// </summary>
        MonthlyCustomerSuccessCalls,
        /// <summary>
        /// 
        /// </summary>
        MultipleWorkforces,
        /// <summary>
        /// 
        /// </summary>
        OnDemandCalls,
        /// <summary>
        /// 
        /// </summary>
        OnDemandCustomerSuccessCalls,
        /// <summary>
        /// 
        /// </summary>
        OutputFormatConverters,
        /// <summary>
        /// 
        /// </summary>
        ProfessionalServices,
        /// <summary>
        /// 
        /// </summary>
        ProfessionalServicesCustomDevelopment,
        /// <summary>
        /// 
        /// </summary>
        ProfessionalServicesOrDeveloperSuccessLeadOnboarding,
        /// <summary>
        /// 
        /// </summary>
        QuarterlyCustomerSuccessCheckIn,
        /// <summary>
        /// 
        /// </summary>
        RoleAndGroupBasedAccessControl,
        /// <summary>
        /// 
        /// </summary>
        SdkAccess,
        /// <summary>
        /// 
        /// </summary>
        SsoIntegration,
        /// <summary>
        /// 
        /// </summary>
        StorageIntegration,
        /// <summary>
        /// 
        /// </summary>
        SystemCompute,
        /// <summary>
        /// 
        /// </summary>
        TicketBasedTroubleshooting,
        /// <summary>
        /// 
        /// </summary>
        UnlimitedSeats,
        /// <summary>
        /// 
        /// </summary>
        VpcDeployment,
        /// <summary>
        /// 
        /// </summary>
        WeeklyCustomerSuccessCalls,
        /// <summary>
        /// 
        /// </summary>
        WorkforceManagementTool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingResourceKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingResourceKey value)
        {
            return value switch
            {
                BillingResourceKey.AccessToCustomerSuccessRepresentationPool => "access-to-customer-success-representation-pool",
                BillingResourceKey.AdvancedAnalyticsHistory => "advanced-analytics-history",
                BillingResourceKey.AiVideoTracker => "ai-video-tracker",
                BillingResourceKey.AnalyticsDashboard => "analytics-dashboard",
                BillingResourceKey.AnnotationToolHours => "annotation-tool-hours",
                BillingResourceKey.ApiAccess => "api-access",
                BillingResourceKey.ApiCalls => "api-calls",
                BillingResourceKey.AutoAnnotationTools => "auto-annotation-tools",
                BillingResourceKey.ComputeBudget => "compute-budget",
                BillingResourceKey.ComputeCpuHighmemL => "compute-cpu-highmem-l",
                BillingResourceKey.ComputeCpuHighmemM => "compute-cpu-highmem-m",
                BillingResourceKey.ComputeCpuHighmemS => "compute-cpu-highmem-s",
                BillingResourceKey.ComputeCpuHighmemXs => "compute-cpu-highmem-xs",
                BillingResourceKey.ComputeCpuRegularL => "compute-cpu-regular-l",
                BillingResourceKey.ComputeCpuRegularM => "compute-cpu-regular-m",
                BillingResourceKey.ComputeCpuRegularS => "compute-cpu-regular-s",
                BillingResourceKey.ComputeCpuRegularXs => "compute-cpu-regular-xs",
                BillingResourceKey.ComputeGpuA1004g => "compute-gpu-a100-4g",
                BillingResourceKey.ComputeGpuA1004gM => "compute-gpu-a100-4g-m",
                BillingResourceKey.ComputeGpuA100M => "compute-gpu-a100-m",
                BillingResourceKey.ComputeGpuA100S => "compute-gpu-a100-s",
                BillingResourceKey.ComputeGpuK80M => "compute-gpu-k80-m",
                BillingResourceKey.ComputeGpuK80S => "compute-gpu-k80-s",
                BillingResourceKey.ComputeGpuT4 => "compute-gpu-t4",
                BillingResourceKey.ComputeGpuT4M => "compute-gpu-t4-m",
                BillingResourceKey.CustomProjectDashboard => "custom-project-dashboard",
                BillingResourceKey.DataBugTracking => "data-bug-tracking",
                BillingResourceKey.DataPipelineFilters => "data-pipeline-filters",
                BillingResourceKey.DataPoints => "data-points",
                BillingResourceKey.DataVersioning => "data-versioning",
                BillingResourceKey.DataVisualization => "data-visualization",
                BillingResourceKey.DebugAndGuideViaTrackingSys => "debug-and-guide-via-tracking-sys",
                BillingResourceKey.DedicatedCustomerSuccess => "dedicated-customer-success",
                BillingResourceKey.DefaultAnnotationStudios => "default-annotation-studios",
                BillingResourceKey.DeveloperSuccessAssistance => "developer-success-assistance",
                BillingResourceKey.EmailCustomerSupport => "email-customer-support",
                BillingResourceKey.EngineeringConsulting => "engineering-consulting",
                BillingResourceKey.EnterpriseSupportSla => "enterprise-support-sla",
                BillingResourceKey.Faas => "faas",
                BillingResourceKey.Faq => "faq",
                BillingResourceKey.HostedStorage => "hosted-storage",
                BillingResourceKey.HumanTasks => "human-tasks",
                BillingResourceKey.IngestedDataPoints => "ingested-data-points",
                BillingResourceKey.InstructionalVideoLibraryAccess => "instructional-video-library-access",
                BillingResourceKey.IpWhitelist => "ip-whitelist",
                BillingResourceKey.KnowledgeBase => "knowledge-base",
                BillingResourceKey.Lidar => "lidar",
                BillingResourceKey.ManagedLabelingService => "managed-labeling-service",
                BillingResourceKey.MetadataSearch => "metadata-search",
                BillingResourceKey.MfaIntegration => "mfa-integration",
                BillingResourceKey.MlModelAssistedAnnotation => "ml-model-assisted-annotation",
                BillingResourceKey.ModelManagement => "model-management",
                BillingResourceKey.MonthlyCustomerSuccessCalls => "monthly-customer-success-calls",
                BillingResourceKey.MultipleWorkforces => "multiple-workforces",
                BillingResourceKey.OnDemandCalls => "on-demand-calls",
                BillingResourceKey.OnDemandCustomerSuccessCalls => "on-demand-customer-success-calls",
                BillingResourceKey.OutputFormatConverters => "output-format-converters",
                BillingResourceKey.ProfessionalServices => "professional-services",
                BillingResourceKey.ProfessionalServicesCustomDevelopment => "professional-services-custom-development",
                BillingResourceKey.ProfessionalServicesOrDeveloperSuccessLeadOnboarding => "professional-services-or-developer-success-lead-onboarding",
                BillingResourceKey.QuarterlyCustomerSuccessCheckIn => "quarterly-customer-success-check-in",
                BillingResourceKey.RoleAndGroupBasedAccessControl => "role-and-group-based-access-control",
                BillingResourceKey.SdkAccess => "sdk-access",
                BillingResourceKey.SsoIntegration => "sso-integration",
                BillingResourceKey.StorageIntegration => "storage-integration",
                BillingResourceKey.SystemCompute => "system-compute",
                BillingResourceKey.TicketBasedTroubleshooting => "ticket-based-troubleshooting",
                BillingResourceKey.UnlimitedSeats => "unlimited-seats",
                BillingResourceKey.VpcDeployment => "vpc-deployment",
                BillingResourceKey.WeeklyCustomerSuccessCalls => "weekly-customer-success-calls",
                BillingResourceKey.WorkforceManagementTool => "workforce-management-tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingResourceKey? ToEnum(string value)
        {
            return value switch
            {
                "access-to-customer-success-representation-pool" => BillingResourceKey.AccessToCustomerSuccessRepresentationPool,
                "advanced-analytics-history" => BillingResourceKey.AdvancedAnalyticsHistory,
                "ai-video-tracker" => BillingResourceKey.AiVideoTracker,
                "analytics-dashboard" => BillingResourceKey.AnalyticsDashboard,
                "annotation-tool-hours" => BillingResourceKey.AnnotationToolHours,
                "api-access" => BillingResourceKey.ApiAccess,
                "api-calls" => BillingResourceKey.ApiCalls,
                "auto-annotation-tools" => BillingResourceKey.AutoAnnotationTools,
                "compute-budget" => BillingResourceKey.ComputeBudget,
                "compute-cpu-highmem-l" => BillingResourceKey.ComputeCpuHighmemL,
                "compute-cpu-highmem-m" => BillingResourceKey.ComputeCpuHighmemM,
                "compute-cpu-highmem-s" => BillingResourceKey.ComputeCpuHighmemS,
                "compute-cpu-highmem-xs" => BillingResourceKey.ComputeCpuHighmemXs,
                "compute-cpu-regular-l" => BillingResourceKey.ComputeCpuRegularL,
                "compute-cpu-regular-m" => BillingResourceKey.ComputeCpuRegularM,
                "compute-cpu-regular-s" => BillingResourceKey.ComputeCpuRegularS,
                "compute-cpu-regular-xs" => BillingResourceKey.ComputeCpuRegularXs,
                "compute-gpu-a100-4g" => BillingResourceKey.ComputeGpuA1004g,
                "compute-gpu-a100-4g-m" => BillingResourceKey.ComputeGpuA1004gM,
                "compute-gpu-a100-m" => BillingResourceKey.ComputeGpuA100M,
                "compute-gpu-a100-s" => BillingResourceKey.ComputeGpuA100S,
                "compute-gpu-k80-m" => BillingResourceKey.ComputeGpuK80M,
                "compute-gpu-k80-s" => BillingResourceKey.ComputeGpuK80S,
                "compute-gpu-t4" => BillingResourceKey.ComputeGpuT4,
                "compute-gpu-t4-m" => BillingResourceKey.ComputeGpuT4M,
                "custom-project-dashboard" => BillingResourceKey.CustomProjectDashboard,
                "data-bug-tracking" => BillingResourceKey.DataBugTracking,
                "data-pipeline-filters" => BillingResourceKey.DataPipelineFilters,
                "data-points" => BillingResourceKey.DataPoints,
                "data-versioning" => BillingResourceKey.DataVersioning,
                "data-visualization" => BillingResourceKey.DataVisualization,
                "debug-and-guide-via-tracking-sys" => BillingResourceKey.DebugAndGuideViaTrackingSys,
                "dedicated-customer-success" => BillingResourceKey.DedicatedCustomerSuccess,
                "default-annotation-studios" => BillingResourceKey.DefaultAnnotationStudios,
                "developer-success-assistance" => BillingResourceKey.DeveloperSuccessAssistance,
                "email-customer-support" => BillingResourceKey.EmailCustomerSupport,
                "engineering-consulting" => BillingResourceKey.EngineeringConsulting,
                "enterprise-support-sla" => BillingResourceKey.EnterpriseSupportSla,
                "faas" => BillingResourceKey.Faas,
                "faq" => BillingResourceKey.Faq,
                "hosted-storage" => BillingResourceKey.HostedStorage,
                "human-tasks" => BillingResourceKey.HumanTasks,
                "ingested-data-points" => BillingResourceKey.IngestedDataPoints,
                "instructional-video-library-access" => BillingResourceKey.InstructionalVideoLibraryAccess,
                "ip-whitelist" => BillingResourceKey.IpWhitelist,
                "knowledge-base" => BillingResourceKey.KnowledgeBase,
                "lidar" => BillingResourceKey.Lidar,
                "managed-labeling-service" => BillingResourceKey.ManagedLabelingService,
                "metadata-search" => BillingResourceKey.MetadataSearch,
                "mfa-integration" => BillingResourceKey.MfaIntegration,
                "ml-model-assisted-annotation" => BillingResourceKey.MlModelAssistedAnnotation,
                "model-management" => BillingResourceKey.ModelManagement,
                "monthly-customer-success-calls" => BillingResourceKey.MonthlyCustomerSuccessCalls,
                "multiple-workforces" => BillingResourceKey.MultipleWorkforces,
                "on-demand-calls" => BillingResourceKey.OnDemandCalls,
                "on-demand-customer-success-calls" => BillingResourceKey.OnDemandCustomerSuccessCalls,
                "output-format-converters" => BillingResourceKey.OutputFormatConverters,
                "professional-services" => BillingResourceKey.ProfessionalServices,
                "professional-services-custom-development" => BillingResourceKey.ProfessionalServicesCustomDevelopment,
                "professional-services-or-developer-success-lead-onboarding" => BillingResourceKey.ProfessionalServicesOrDeveloperSuccessLeadOnboarding,
                "quarterly-customer-success-check-in" => BillingResourceKey.QuarterlyCustomerSuccessCheckIn,
                "role-and-group-based-access-control" => BillingResourceKey.RoleAndGroupBasedAccessControl,
                "sdk-access" => BillingResourceKey.SdkAccess,
                "sso-integration" => BillingResourceKey.SsoIntegration,
                "storage-integration" => BillingResourceKey.StorageIntegration,
                "system-compute" => BillingResourceKey.SystemCompute,
                "ticket-based-troubleshooting" => BillingResourceKey.TicketBasedTroubleshooting,
                "unlimited-seats" => BillingResourceKey.UnlimitedSeats,
                "vpc-deployment" => BillingResourceKey.VpcDeployment,
                "weekly-customer-success-calls" => BillingResourceKey.WeeklyCustomerSuccessCalls,
                "workforce-management-tool" => BillingResourceKey.WorkforceManagementTool,
                _ => null,
            };
        }
    }
}