
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComputeConsumptionMethod), TypeInfoPropertyName = "EComputeConsumptionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaaSCacheSize), TypeInfoPropertyName = "FaaSCacheSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaaSCacheType), TypeInfoPropertyName = "FaaSCacheType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IComputeContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DataloopPodType), TypeInfoPropertyName = "DataloopPodType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverToleration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverTolerationConditions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DriverCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverNodeSelector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DriverNodeSelectorConditions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CacheRunner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputeMetadata), TypeInfoPropertyName = "ComputeMetadata2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputeMetadataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputeMetadataVariant2ServeAgentGateway), TypeInfoPropertyName = "ComputeMetadataVariant2ServeAgentGateway2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DriverNodeSelector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DriverToleration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DataloopPodType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComputeType), TypeInfoPropertyName = "EComputeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComputeStatus), TypeInfoPropertyName = "EComputeStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EClusterProvider), TypeInfoPropertyName = "EClusterProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Toleration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.INodePoolDeploymentResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.INodePoolDeploymentResourcesRequests))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.INodePoolDeploymentResourcesLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.INodePool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.Toleration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComputePlugin), TypeInfoPropertyName = "EComputePlugin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IExternalMonitoringConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IHpaControllerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EStorageType), TypeInfoPropertyName = "EStorageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IStorageDriverConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IComputeNfsPluginConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.KubernetesServiceType), TypeInfoPropertyName = "KubernetesServiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputePluginResourceManifests2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputePluginResourceManifestsSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputePluginResourceManifestsSpecResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputePluginSpec), TypeInfoPropertyName = "ComputePluginSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputePluginSpecVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IComputePlugin))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.IExternalMonitoringConfig, global::Dataloop.IHpaControllerConfig, global::Dataloop.Dictionary, global::Dataloop.IStorageDriverConfig, global::Dataloop.IComputeNfsPluginConfig>), TypeInfoPropertyName = "AnyOfIExternalMonitoringConfigIHpaControllerConfigDictionaryIStorageDriverConfigIComputeNfsPluginConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IComputeAuthentication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IComputeAuthenticationIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterVolume))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterVolumePersistentVolumeClaim))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterVolumeHostPath))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterVolumeConfigMap))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IClusterVolumeConfigMapItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterVolumeConfigMapItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterVolumeSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IClusterVolumeSecretItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterVolumeSecretItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterVolumeNfs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDeploymentSecurityContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterEnvironmentVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterEnvironmentVariableValueFrom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterEnvironmentVariableValueFromConfigMapKeyRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterEnvironmentVariableValueFromSecretKeyRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClusterEnvironmentVariableValueFromFieldRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IComputeRegistry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDeploymentConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IClusterVolume>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IClusterEnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDeploymentConfigurationDefaultResources))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDeploymentConfigurationDefaultResourcesLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IDeploymentConfigurationDefaultResourcesRequests))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IRunAiConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IComputeCluster))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.INodePool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IComputePlugin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IComputeSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICompute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.IComputeContext>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ICompute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialICompute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.PartialICompute, global::Dataloop.UpdateComputeRequest2>), TypeInfoPropertyName = "AllOfPartialIComputeUpdateComputeRequest22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateComputeRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, object>), TypeInfoPropertyName = "AnyOfAPICommandObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComputeConsumptionMethod?), TypeInfoPropertyName = "NullableEComputeConsumptionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaaSCacheSize?), TypeInfoPropertyName = "NullableFaaSCacheSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaaSCacheType?), TypeInfoPropertyName = "NullableFaaSCacheType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DataloopPodType?), TypeInfoPropertyName = "NullableDataloopPodType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputeMetadata?), TypeInfoPropertyName = "NullableComputeMetadata2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputeMetadataVariant2ServeAgentGateway?), TypeInfoPropertyName = "NullableComputeMetadataVariant2ServeAgentGateway2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComputeType?), TypeInfoPropertyName = "NullableEComputeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComputeStatus?), TypeInfoPropertyName = "NullableEComputeStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EClusterProvider?), TypeInfoPropertyName = "NullableEClusterProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComputePlugin?), TypeInfoPropertyName = "NullableEComputePlugin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EStorageType?), TypeInfoPropertyName = "NullableEStorageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.KubernetesServiceType?), TypeInfoPropertyName = "NullableKubernetesServiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ComputePluginSpec?), TypeInfoPropertyName = "NullableComputePluginSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.IExternalMonitoringConfig, global::Dataloop.IHpaControllerConfig, global::Dataloop.Dictionary, global::Dataloop.IStorageDriverConfig, global::Dataloop.IComputeNfsPluginConfig>?), TypeInfoPropertyName = "NullableAnyOfIExternalMonitoringConfigIHpaControllerConfigDictionaryIStorageDriverConfigIComputeNfsPluginConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.PartialICompute, global::Dataloop.UpdateComputeRequest2>?), TypeInfoPropertyName = "NullableAllOfPartialIComputeUpdateComputeRequest22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, object>?), TypeInfoPropertyName = "NullableAnyOfAPICommandObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DriverCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DriverNodeSelector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DriverToleration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DataloopPodType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.Toleration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IStorage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IClusterVolumeConfigMapItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IClusterVolumeSecretItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IClusterVolume>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IClusterEnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.INodePool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IComputePlugin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.IComputeContext>))]
    internal sealed partial class ComputeSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ComputeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ComputeSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ComputeSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Dataloop.JsonConverters.ComputeMetadataJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.ComputePluginSpecJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
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
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.IExternalMonitoringConfig, global::Dataloop.IHpaControllerConfig, global::Dataloop.Dictionary, global::Dataloop.IStorageDriverConfig, global::Dataloop.IComputeNfsPluginConfig>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.PartialICompute, global::Dataloop.UpdateComputeRequest2>());
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
                    typeToConvert == typeof(global::Dataloop.EComputeConsumptionMethod)

                    || typeToConvert == typeof(global::Dataloop.EComputeConsumptionMethod?)

                    || typeToConvert == typeof(global::Dataloop.FaaSCacheSize)

                    || typeToConvert == typeof(global::Dataloop.FaaSCacheSize?)

                    || typeToConvert == typeof(global::Dataloop.FaaSCacheType)

                    || typeToConvert == typeof(global::Dataloop.FaaSCacheType?)

                    || typeToConvert == typeof(global::Dataloop.DataloopPodType)

                    || typeToConvert == typeof(global::Dataloop.DataloopPodType?)

                    || typeToConvert == typeof(global::Dataloop.ComputeMetadataVariant2ServeAgentGateway)

                    || typeToConvert == typeof(global::Dataloop.ComputeMetadataVariant2ServeAgentGateway?)

                    || typeToConvert == typeof(global::Dataloop.EComputeType)

                    || typeToConvert == typeof(global::Dataloop.EComputeType?)

                    || typeToConvert == typeof(global::Dataloop.EComputeStatus)

                    || typeToConvert == typeof(global::Dataloop.EComputeStatus?)

                    || typeToConvert == typeof(global::Dataloop.EClusterProvider)

                    || typeToConvert == typeof(global::Dataloop.EClusterProvider?)

                    || typeToConvert == typeof(global::Dataloop.EComputePlugin)

                    || typeToConvert == typeof(global::Dataloop.EComputePlugin?)

                    || typeToConvert == typeof(global::Dataloop.EStorageType)

                    || typeToConvert == typeof(global::Dataloop.EStorageType?)

                    || typeToConvert == typeof(global::Dataloop.KubernetesServiceType)

                    || typeToConvert == typeof(global::Dataloop.KubernetesServiceType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Dataloop.EComputeConsumptionMethod))
                {
                    return new global::Dataloop.JsonConverters.EComputeConsumptionMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EComputeConsumptionMethod?))
                {
                    return new global::Dataloop.JsonConverters.EComputeConsumptionMethodNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Dataloop.DataloopPodType))
                {
                    return new global::Dataloop.JsonConverters.DataloopPodTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DataloopPodType?))
                {
                    return new global::Dataloop.JsonConverters.DataloopPodTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ComputeMetadataVariant2ServeAgentGateway))
                {
                    return new global::Dataloop.JsonConverters.ComputeMetadataVariant2ServeAgentGatewayJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ComputeMetadataVariant2ServeAgentGateway?))
                {
                    return new global::Dataloop.JsonConverters.ComputeMetadataVariant2ServeAgentGatewayNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EComputeType))
                {
                    return new global::Dataloop.JsonConverters.EComputeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EComputeType?))
                {
                    return new global::Dataloop.JsonConverters.EComputeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EComputeStatus))
                {
                    return new global::Dataloop.JsonConverters.EComputeStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EComputeStatus?))
                {
                    return new global::Dataloop.JsonConverters.EComputeStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EClusterProvider))
                {
                    return new global::Dataloop.JsonConverters.EClusterProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EClusterProvider?))
                {
                    return new global::Dataloop.JsonConverters.EClusterProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EComputePlugin))
                {
                    return new global::Dataloop.JsonConverters.EComputePluginJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EComputePlugin?))
                {
                    return new global::Dataloop.JsonConverters.EComputePluginNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EStorageType))
                {
                    return new global::Dataloop.JsonConverters.EStorageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EStorageType?))
                {
                    return new global::Dataloop.JsonConverters.EStorageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.KubernetesServiceType))
                {
                    return new global::Dataloop.JsonConverters.KubernetesServiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.KubernetesServiceType?))
                {
                    return new global::Dataloop.JsonConverters.KubernetesServiceTypeNullableJsonConverter();
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
                    0 => new ComputeSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}