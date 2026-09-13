
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RequestSource), TypeInfoPropertyName = "RequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Role), TypeInfoPropertyName = "Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<double?, string>), TypeInfoPropertyName = "AnyOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReferenceType), TypeInfoPropertyName = "ReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EntityReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.EntityReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IAppDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionStatusReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionStatusName), TypeInfoPropertyName = "ExecutionStatusName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemStatusEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemStatusEventStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionEventContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResourceType), TypeInfoPropertyName = "ResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ExecutionStatusReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionHook))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageResourceType), TypeInfoPropertyName = "PackageResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionHookValueFrom), TypeInfoPropertyName = "ExecutionHookValueFrom2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionHookType), TypeInfoPropertyName = "ExecutionHookType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageIO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageIOIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UiBindingResource), TypeInfoPropertyName = "UiBindingResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UiBindingPanel), TypeInfoPropertyName = "UiBindingPanel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DisplayScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionPostActionType), TypeInfoPropertyName = "ExecutionPostActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionPostAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DLFunctionDefaultInputSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DLFunctionInputOptionsSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DLFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.PackageIO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DisplayScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DLFunctionDefaultInputSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DLFunctionInputOptionsSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IPipelineExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIExecutionSyncReplyTo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UiSlot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.ActivitiesDescriptor2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ActivitiesDescriptor2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.ActivitiesDescriptorFunctions2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ActivitiesDescriptorFunctions2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIExecution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RequestSource?), TypeInfoPropertyName = "NullableRequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Role?), TypeInfoPropertyName = "NullableRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<double?, string>?), TypeInfoPropertyName = "NullableAnyOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReferenceType?), TypeInfoPropertyName = "NullableReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionStatusName?), TypeInfoPropertyName = "NullableExecutionStatusName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResourceType?), TypeInfoPropertyName = "NullableResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OnResetAction?), TypeInfoPropertyName = "NullableOnResetAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceType?), TypeInfoPropertyName = "NullableServiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CrashloopAction?), TypeInfoPropertyName = "NullableCrashloopAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CrashloopReason?), TypeInfoPropertyName = "NullableCrashloopReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceModeType?), TypeInfoPropertyName = "NullableServiceModeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EComputeConsumptionMethod?), TypeInfoPropertyName = "NullableEComputeConsumptionMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.ServiceMetadataUser, global::Dataloop.Dictionary>?), TypeInfoPropertyName = "NullableAllOfServiceMetadataUserDictionary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.ServiceMetadataSystem, global::Dataloop.SystemRefs, global::Dataloop.Dictionary>?), TypeInfoPropertyName = "NullableAllOfServiceMetadataSystemSystemRefsDictionary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PackageResourceType?), TypeInfoPropertyName = "NullablePackageResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionHookValueFrom?), TypeInfoPropertyName = "NullableExecutionHookValueFrom2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionHookType?), TypeInfoPropertyName = "NullableExecutionHookType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UiBindingResource?), TypeInfoPropertyName = "NullableUiBindingResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UiBindingPanel?), TypeInfoPropertyName = "NullableUiBindingPanel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ExecutionPostActionType?), TypeInfoPropertyName = "NullableExecutionPostActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.EntityReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ExecutionStatusReport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.Panel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ServiceIntegration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PackageIO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DisplayScope>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DLFunctionDefaultInputSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DLFunctionInputOptionsSpec>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIExecution>))]
    internal sealed partial class ActivitiesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ActivitiesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ActivitiesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ActivitiesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIService, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIService, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIService, string>());
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
                    typeToConvert == typeof(global::Dataloop.RequestSource)

                    || typeToConvert == typeof(global::Dataloop.RequestSource?)

                    || typeToConvert == typeof(global::Dataloop.Role)

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

                    || typeToConvert == typeof(global::Dataloop.PackageResourceType)

                    || typeToConvert == typeof(global::Dataloop.PackageResourceType?)

                    || typeToConvert == typeof(global::Dataloop.ExecutionHookValueFrom)

                    || typeToConvert == typeof(global::Dataloop.ExecutionHookValueFrom?)

                    || typeToConvert == typeof(global::Dataloop.ExecutionHookType)

                    || typeToConvert == typeof(global::Dataloop.ExecutionHookType?)

                    || typeToConvert == typeof(global::Dataloop.UiBindingResource)

                    || typeToConvert == typeof(global::Dataloop.UiBindingResource?)

                    || typeToConvert == typeof(global::Dataloop.UiBindingPanel)

                    || typeToConvert == typeof(global::Dataloop.UiBindingPanel?)

                    || typeToConvert == typeof(global::Dataloop.ExecutionPostActionType)

                    || typeToConvert == typeof(global::Dataloop.ExecutionPostActionType?)

                    || typeToConvert == typeof(global::Dataloop.ExecutionStatusName)

                    || typeToConvert == typeof(global::Dataloop.ExecutionStatusName?)

                    || typeToConvert == typeof(global::Dataloop.ResourceType)

                    || typeToConvert == typeof(global::Dataloop.ResourceType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Dataloop.RequestSource))
                {
                    return new global::Dataloop.JsonConverters.RequestSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.RequestSource?))
                {
                    return new global::Dataloop.JsonConverters.RequestSourceNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Dataloop.PackageResourceType))
                {
                    return new global::Dataloop.JsonConverters.PackageResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PackageResourceType?))
                {
                    return new global::Dataloop.JsonConverters.PackageResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionHookValueFrom))
                {
                    return new global::Dataloop.JsonConverters.ExecutionHookValueFromJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionHookValueFrom?))
                {
                    return new global::Dataloop.JsonConverters.ExecutionHookValueFromNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionHookType))
                {
                    return new global::Dataloop.JsonConverters.ExecutionHookTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionHookType?))
                {
                    return new global::Dataloop.JsonConverters.ExecutionHookTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.UiBindingResource))
                {
                    return new global::Dataloop.JsonConverters.UiBindingResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.UiBindingResource?))
                {
                    return new global::Dataloop.JsonConverters.UiBindingResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.UiBindingPanel))
                {
                    return new global::Dataloop.JsonConverters.UiBindingPanelJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.UiBindingPanel?))
                {
                    return new global::Dataloop.JsonConverters.UiBindingPanelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionPostActionType))
                {
                    return new global::Dataloop.JsonConverters.ExecutionPostActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionPostActionType?))
                {
                    return new global::Dataloop.JsonConverters.ExecutionPostActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionStatusName))
                {
                    return new global::Dataloop.JsonConverters.ExecutionStatusNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ExecutionStatusName?))
                {
                    return new global::Dataloop.JsonConverters.ExecutionStatusNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ResourceType))
                {
                    return new global::Dataloop.JsonConverters.ResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ResourceType?))
                {
                    return new global::Dataloop.JsonConverters.ResourceTypeNullableJsonConverter();
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
                    0 => new ActivitiesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}