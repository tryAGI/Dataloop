
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Dataloop
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Dictionary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Role), TypeInfoPropertyName = "Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReferenceType), TypeInfoPropertyName = "ReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EntityReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.EntityReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IAppDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OnResetAction), TypeInfoPropertyName = "OnResetAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceRuntime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Panel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IServiceAppConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceType), TypeInfoPropertyName = "ServiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CrashloopAction), TypeInfoPropertyName = "CrashloopAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CrashloopReason), TypeInfoPropertyName = "CrashloopReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Crashloop))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceModeType), TypeInfoPropertyName = "ServiceModeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComputeConsumptionMethod), TypeInfoPropertyName = "EComputeConsumptionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SystemRefs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.ServiceMetadataUser, global::Dataloop.Dictionary>), TypeInfoPropertyName = "AllOfServiceMetadataUserDictionary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceMetadataUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceMetadataMl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.ServiceMetadataSystem, global::Dataloop.SystemRefs, global::Dataloop.Dictionary>), TypeInfoPropertyName = "AllOfServiceMetadataSystemSystemRefsDictionary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceMetadataSystem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IServiceGeneralSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIService))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.Panel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ServiceIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AgentNotificationPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AgentNotificationPayloadAgentInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ECacheMode), TypeInfoPropertyName = "ECacheMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaaSCacheSize), TypeInfoPropertyName = "FaaSCacheSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaaSCacheType), TypeInfoPropertyName = "FaaSCacheType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICacheRunner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICacheOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICacheOptionsOrg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServicesPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIService>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIServicePatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceLogLevel), TypeInfoPropertyName = "ServiceLogLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceLogEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceLogsPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ServiceLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LogsListDirection), TypeInfoPropertyName = "LogsListDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LogQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReplicaStatus), TypeInfoPropertyName = "ReplicaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIReplicaStatusUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReplicaReason), TypeInfoPropertyName = "ReplicaReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceRuntimeStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIServiceStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ServiceRuntimeStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EDebugOptionsStatus), TypeInfoPropertyName = "EDebugOptionsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DebugSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReportType), TypeInfoPropertyName = "ReportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BaseReportMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.GetGlobalServicesRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetGlobalServicesRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.BaseReportMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RolloutServiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.GetGlobalServicesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetGlobalServicesResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.APIServiceStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIService, string>), TypeInfoPropertyName = "AnyOfAPIServiceString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceStreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetServiceIntegrationEnvResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.GetServiceIntegrationEnvResponseEnvItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetServiceIntegrationEnvResponseEnvItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Role?), TypeInfoPropertyName = "NullableRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReferenceType?), TypeInfoPropertyName = "NullableReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OnResetAction?), TypeInfoPropertyName = "NullableOnResetAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceType?), TypeInfoPropertyName = "NullableServiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CrashloopAction?), TypeInfoPropertyName = "NullableCrashloopAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CrashloopReason?), TypeInfoPropertyName = "NullableCrashloopReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceModeType?), TypeInfoPropertyName = "NullableServiceModeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComputeConsumptionMethod?), TypeInfoPropertyName = "NullableEComputeConsumptionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.ServiceMetadataUser, global::Dataloop.Dictionary>?), TypeInfoPropertyName = "NullableAllOfServiceMetadataUserDictionary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.ServiceMetadataSystem, global::Dataloop.SystemRefs, global::Dataloop.Dictionary>?), TypeInfoPropertyName = "NullableAllOfServiceMetadataSystemSystemRefsDictionary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ECacheMode?), TypeInfoPropertyName = "NullableECacheMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaaSCacheSize?), TypeInfoPropertyName = "NullableFaaSCacheSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaaSCacheType?), TypeInfoPropertyName = "NullableFaaSCacheType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceLogLevel?), TypeInfoPropertyName = "NullableServiceLogLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LogsListDirection?), TypeInfoPropertyName = "NullableLogsListDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReplicaStatus?), TypeInfoPropertyName = "NullableReplicaStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReplicaReason?), TypeInfoPropertyName = "NullableReplicaReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EDebugOptionsStatus?), TypeInfoPropertyName = "NullableEDebugOptionsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReportType?), TypeInfoPropertyName = "NullableReportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIService, string>?), TypeInfoPropertyName = "NullableAnyOfAPIServiceString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.EntityReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.Panel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ServiceIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIService>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ServiceLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ServiceRuntimeStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.GetGlobalServicesRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.BaseReportMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.GetGlobalServicesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.GetServiceIntegrationEnvResponseEnvItem>))]
    internal sealed partial class ServicesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ServicesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ServicesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ServicesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.ServiceMetadataUser, global::Dataloop.Dictionary>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.ServiceMetadataSystem, global::Dataloop.SystemRefs, global::Dataloop.Dictionary>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<object, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, object>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIService, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIService, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIService, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<object, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Dataloop.Role)

                    || typeToConvert == typeof(global::Dataloop.Role?)

                    || typeToConvert == typeof(global::Dataloop.ReferenceType)

                    || typeToConvert == typeof(global::Dataloop.ReferenceType?)

                    || typeToConvert == typeof(global::Dataloop.OnResetAction)

                    || typeToConvert == typeof(global::Dataloop.OnResetAction?)

                    || typeToConvert == typeof(global::Dataloop.ServiceType)

                    || typeToConvert == typeof(global::Dataloop.ServiceType?)

                    || typeToConvert == typeof(global::Dataloop.CrashloopAction)

                    || typeToConvert == typeof(global::Dataloop.CrashloopAction?)

                    || typeToConvert == typeof(global::Dataloop.CrashloopReason)

                    || typeToConvert == typeof(global::Dataloop.CrashloopReason?)

                    || typeToConvert == typeof(global::Dataloop.ServiceModeType)

                    || typeToConvert == typeof(global::Dataloop.ServiceModeType?)

                    || typeToConvert == typeof(global::Dataloop.EComputeConsumptionMethod)

                    || typeToConvert == typeof(global::Dataloop.EComputeConsumptionMethod?)

                    || typeToConvert == typeof(global::Dataloop.ECacheMode)

                    || typeToConvert == typeof(global::Dataloop.ECacheMode?)

                    || typeToConvert == typeof(global::Dataloop.FaaSCacheSize)

                    || typeToConvert == typeof(global::Dataloop.FaaSCacheSize?)

                    || typeToConvert == typeof(global::Dataloop.FaaSCacheType)

                    || typeToConvert == typeof(global::Dataloop.FaaSCacheType?)

                    || typeToConvert == typeof(global::Dataloop.ServiceLogLevel)

                    || typeToConvert == typeof(global::Dataloop.ServiceLogLevel?)

                    || typeToConvert == typeof(global::Dataloop.LogsListDirection)

                    || typeToConvert == typeof(global::Dataloop.LogsListDirection?)

                    || typeToConvert == typeof(global::Dataloop.ReplicaStatus)

                    || typeToConvert == typeof(global::Dataloop.ReplicaStatus?)

                    || typeToConvert == typeof(global::Dataloop.ReplicaReason)

                    || typeToConvert == typeof(global::Dataloop.ReplicaReason?)

                    || typeToConvert == typeof(global::Dataloop.EDebugOptionsStatus)

                    || typeToConvert == typeof(global::Dataloop.EDebugOptionsStatus?)

                    || typeToConvert == typeof(global::Dataloop.ReportType)

                    || typeToConvert == typeof(global::Dataloop.ReportType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Dataloop.Role))
                {
                    return new global::Dataloop.JsonConverters.RoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.Role?))
                {
                    return new global::Dataloop.JsonConverters.RoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReferenceType))
                {
                    return new global::Dataloop.JsonConverters.ReferenceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReferenceType?))
                {
                    return new global::Dataloop.JsonConverters.ReferenceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OnResetAction))
                {
                    return new global::Dataloop.JsonConverters.OnResetActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OnResetAction?))
                {
                    return new global::Dataloop.JsonConverters.OnResetActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ServiceType))
                {
                    return new global::Dataloop.JsonConverters.ServiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ServiceType?))
                {
                    return new global::Dataloop.JsonConverters.ServiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CrashloopAction))
                {
                    return new global::Dataloop.JsonConverters.CrashloopActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CrashloopAction?))
                {
                    return new global::Dataloop.JsonConverters.CrashloopActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CrashloopReason))
                {
                    return new global::Dataloop.JsonConverters.CrashloopReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CrashloopReason?))
                {
                    return new global::Dataloop.JsonConverters.CrashloopReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ServiceModeType))
                {
                    return new global::Dataloop.JsonConverters.ServiceModeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ServiceModeType?))
                {
                    return new global::Dataloop.JsonConverters.ServiceModeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EComputeConsumptionMethod))
                {
                    return new global::Dataloop.JsonConverters.EComputeConsumptionMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EComputeConsumptionMethod?))
                {
                    return new global::Dataloop.JsonConverters.EComputeConsumptionMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ECacheMode))
                {
                    return new global::Dataloop.JsonConverters.ECacheModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ECacheMode?))
                {
                    return new global::Dataloop.JsonConverters.ECacheModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FaaSCacheSize))
                {
                    return new global::Dataloop.JsonConverters.FaaSCacheSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FaaSCacheSize?))
                {
                    return new global::Dataloop.JsonConverters.FaaSCacheSizeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FaaSCacheType))
                {
                    return new global::Dataloop.JsonConverters.FaaSCacheTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FaaSCacheType?))
                {
                    return new global::Dataloop.JsonConverters.FaaSCacheTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ServiceLogLevel))
                {
                    return new global::Dataloop.JsonConverters.ServiceLogLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ServiceLogLevel?))
                {
                    return new global::Dataloop.JsonConverters.ServiceLogLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.LogsListDirection))
                {
                    return new global::Dataloop.JsonConverters.LogsListDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.LogsListDirection?))
                {
                    return new global::Dataloop.JsonConverters.LogsListDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReplicaStatus))
                {
                    return new global::Dataloop.JsonConverters.ReplicaStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReplicaStatus?))
                {
                    return new global::Dataloop.JsonConverters.ReplicaStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReplicaReason))
                {
                    return new global::Dataloop.JsonConverters.ReplicaReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReplicaReason?))
                {
                    return new global::Dataloop.JsonConverters.ReplicaReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EDebugOptionsStatus))
                {
                    return new global::Dataloop.JsonConverters.EDebugOptionsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EDebugOptionsStatus?))
                {
                    return new global::Dataloop.JsonConverters.EDebugOptionsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReportType))
                {
                    return new global::Dataloop.JsonConverters.ReportTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReportType?))
                {
                    return new global::Dataloop.JsonConverters.ReportTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ServicesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}