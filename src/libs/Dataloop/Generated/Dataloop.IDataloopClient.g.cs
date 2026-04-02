
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// # Drive your AI to production with end-to-end data management, automation pipelines and a quality-first data labeling platform.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IDataloopClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Dataloop.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public APIKeysClient APIKeys { get; }

        /// <summary>
        /// 
        /// </summary>
        public AccountsClient Accounts { get; }

        /// <summary>
        /// 
        /// </summary>
        public ActivitiesClient Activities { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnnotationLogsClient AnnotationLogs { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnnotationTasksClient AnnotationTasks { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsClient Annotations { get; }

        /// <summary>
        /// 
        /// </summary>
        public AppsClient Apps { get; }

        /// <summary>
        /// 
        /// </summary>
        public AssignmentsClient Assignments { get; }

        /// <summary>
        /// 
        /// </summary>
        public AuditClient Audit { get; }

        /// <summary>
        /// 
        /// </summary>
        public BillingClient Billing { get; }

        /// <summary>
        /// 
        /// </summary>
        public CompositionsClient Compositions { get; }

        /// <summary>
        /// 
        /// </summary>
        public ComputeClient Compute { get; }

        /// <summary>
        /// 
        /// </summary>
        public DatasetItemAnnotationsClient DatasetItemAnnotations { get; }

        /// <summary>
        /// 
        /// </summary>
        public DatasetItemsClient DatasetItems { get; }

        /// <summary>
        /// 
        /// </summary>
        public DatasetStorageClient DatasetStorage { get; }

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets { get; }

        /// <summary>
        /// 
        /// </summary>
        public DpkClient Dpk { get; }

        /// <summary>
        /// 
        /// </summary>
        public ExecutionsClient Executions { get; }

        /// <summary>
        /// 
        /// </summary>
        public FeatureSetsClient FeatureSets { get; }

        /// <summary>
        /// 
        /// </summary>
        public FeatureVectorsClient FeatureVectors { get; }

        /// <summary>
        /// 
        /// </summary>
        public GroupsClient Groups { get; }

        /// <summary>
        /// 
        /// </summary>
        public GuestsClient Guests { get; }

        /// <summary>
        /// 
        /// </summary>
        public InstanceCatalogClient InstanceCatalog { get; }

        /// <summary>
        /// 
        /// </summary>
        public IntegrationsClient Integrations { get; }

        /// <summary>
        /// 
        /// </summary>
        public InvoicesClient Invoices { get; }

        /// <summary>
        /// 
        /// </summary>
        public ItemAnnotationsClient ItemAnnotations { get; }

        /// <summary>
        /// 
        /// </summary>
        public ItemsClient Items { get; }

        /// <summary>
        /// 
        /// </summary>
        public LabelsClient Labels { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModelMetricsClient ModelMetrics { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// 
        /// </summary>
        public OntologiesClient Ontologies { get; }

        /// <summary>
        /// 
        /// </summary>
        public OrgIntegrationsClient OrgIntegrations { get; }

        /// <summary>
        /// 
        /// </summary>
        public OrganizationsClient Organizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public PackagesClient Packages { get; }

        /// <summary>
        /// 
        /// </summary>
        public PipelinesClient Pipelines { get; }

        /// <summary>
        /// 
        /// </summary>
        public PipelinesQueryClient PipelinesQuery { get; }

        /// <summary>
        /// 
        /// </summary>
        public PipelinesTemplatesClient PipelinesTemplates { get; }

        /// <summary>
        /// 
        /// </summary>
        public PiperMiscClient PiperMisc { get; }

        /// <summary>
        /// 
        /// </summary>
        public PlansClient Plans { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects { get; }

        /// <summary>
        /// 
        /// </summary>
        public QueryClient Query { get; }

        /// <summary>
        /// 
        /// </summary>
        public RecipesClient Recipes { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScoresClient Scores { get; }

        /// <summary>
        /// 
        /// </summary>
        public ServiceDriversClient ServiceDrivers { get; }

        /// <summary>
        /// 
        /// </summary>
        public ServicesClient Services { get; }

        /// <summary>
        /// 
        /// </summary>
        public ServicesMetricClient ServicesMetric { get; }

        /// <summary>
        /// 
        /// </summary>
        public SettingsClient Settings { get; }

        /// <summary>
        /// 
        /// </summary>
        public StorageDriversClient StorageDrivers { get; }

        /// <summary>
        /// 
        /// </summary>
        public StructuresClient Structures { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionsClient Subscriptions { get; }

        /// <summary>
        /// 
        /// </summary>
        public TasksClient Tasks { get; }

        /// <summary>
        /// 
        /// </summary>
        public TriggerResourceInformationClient TriggerResourceInformation { get; }

        /// <summary>
        /// 
        /// </summary>
        public TriggersClient Triggers { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsageClient Usage { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        /// 
        /// </summary>
        public VersionClient Version { get; }

        /// <summary>
        /// 
        /// </summary>
        public WebHooksClient WebHooks { get; }

    }
}