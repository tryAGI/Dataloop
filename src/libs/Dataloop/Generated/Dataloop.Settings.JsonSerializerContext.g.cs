
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResource), TypeInfoPropertyName = "QueryResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnnotationType), TypeInfoPropertyName = "AnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Role), TypeInfoPropertyName = "Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OrgRole), TypeInfoPropertyName = "OrgRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EntityScopeLevel), TypeInfoPropertyName = "EntityScopeLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelStatus), TypeInfoPropertyName = "ModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModelConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<double?, string>), TypeInfoPropertyName = "AnyOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelInputType), TypeInfoPropertyName = "ModelInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOutputType), TypeInfoPropertyName = "ModelOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOutputTypeVariant2), TypeInfoPropertyName = "ModelOutputTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOutputTypeVariant4), TypeInfoPropertyName = "ModelOutputTypeVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ArtifactType), TypeInfoPropertyName = "ArtifactType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemArtifact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LocalArtifact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EntityContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOperationMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModelMetadataSubsets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModelMetadataAnnotationsSubsets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReferenceType), TypeInfoPropertyName = "ReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EntityReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.NodeMlType), TypeInfoPropertyName = "NodeMlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModelMetadataSystem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.EntityReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModelMetadataSystemMlType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModelMetadataSystemCloneCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModelMetadataSystemEmbedDatasets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModelMetadataSystemReloadServices))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModelMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IAppDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelStatusLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>), TypeInfoPropertyName = "AnyOfItemArtifactLocalArtifact2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ModelStatusLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPISetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOperationTypes), TypeInfoPropertyName = "ModelOperationTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingsValueTypes), TypeInfoPropertyName = "SettingsValueTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PlatformEntityType), TypeInfoPropertyName = "PlatformEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.PlatformEntityType?, global::Dataloop.SettingScopeType?>), TypeInfoPropertyName = "AnyOfPlatformEntityTypeSettingScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingScopeType), TypeInfoPropertyName = "SettingScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::Dataloop.SettingScopeId?>), TypeInfoPropertyName = "AnyOfStringSettingScopeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingScopeId), TypeInfoPropertyName = "SettingScopeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.SettingScopeRole?>), TypeInfoPropertyName = "AnyOfRoleOrgRoleSettingScopeRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingScopeRole), TypeInfoPropertyName = "SettingScopeRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingsTypes), TypeInfoPropertyName = "SettingsTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIFeatureFlag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingsSectionNames), TypeInfoPropertyName = "SettingsSectionNames2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIUserSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IUserContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ResolverPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreateSettingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialSettingScope))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.PlatformEntityType?, global::Dataloop.PartialSettingScopeType?>), TypeInfoPropertyName = "AnyOfPlatformEntityTypePartialSettingScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialSettingScopeType), TypeInfoPropertyName = "PartialSettingScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::Dataloop.PartialSettingScopeId?>), TypeInfoPropertyName = "AnyOfStringPartialSettingScopeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialSettingScopeId), TypeInfoPropertyName = "PartialSettingScopeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.PartialSettingScopeRole?>), TypeInfoPropertyName = "AnyOfRoleOrgRolePartialSettingScopeRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialSettingScopeRole), TypeInfoPropertyName = "PartialSettingScopeRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PatchFeatureFlagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PatchUserSettingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.ResolverPayload, global::Dataloop.IUserContext>), TypeInfoPropertyName = "AnyOfResolverPayloadIUserContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.PatchFeatureFlagRequest, global::Dataloop.PatchUserSettingRequest>), TypeInfoPropertyName = "AnyOfPatchFeatureFlagRequestPatchUserSettingRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DeleteSettingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>), TypeInfoPropertyName = "AnyOfAPIFeatureFlagAPIUserSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResource?), TypeInfoPropertyName = "NullableQueryResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnnotationType?), TypeInfoPropertyName = "NullableAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Role?), TypeInfoPropertyName = "NullableRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OrgRole?), TypeInfoPropertyName = "NullableOrgRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EntityScopeLevel?), TypeInfoPropertyName = "NullableEntityScopeLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelStatus?), TypeInfoPropertyName = "NullableModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<double?, string>?), TypeInfoPropertyName = "NullableAnyOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelInputType?), TypeInfoPropertyName = "NullableModelInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOutputType?), TypeInfoPropertyName = "NullableModelOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOutputTypeVariant2?), TypeInfoPropertyName = "NullableModelOutputTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOutputTypeVariant4?), TypeInfoPropertyName = "NullableModelOutputTypeVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ArtifactType?), TypeInfoPropertyName = "NullableArtifactType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReferenceType?), TypeInfoPropertyName = "NullableReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.NodeMlType?), TypeInfoPropertyName = "NullableNodeMlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>?), TypeInfoPropertyName = "NullableAnyOfItemArtifactLocalArtifact2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModelOperationTypes?), TypeInfoPropertyName = "NullableModelOperationTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingsValueTypes?), TypeInfoPropertyName = "NullableSettingsValueTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PlatformEntityType?), TypeInfoPropertyName = "NullablePlatformEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.PlatformEntityType?, global::Dataloop.SettingScopeType?>?), TypeInfoPropertyName = "NullableAnyOfPlatformEntityTypeSettingScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingScopeType?), TypeInfoPropertyName = "NullableSettingScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::Dataloop.SettingScopeId?>?), TypeInfoPropertyName = "NullableAnyOfStringSettingScopeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingScopeId?), TypeInfoPropertyName = "NullableSettingScopeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.SettingScopeRole?>?), TypeInfoPropertyName = "NullableAnyOfRoleOrgRoleSettingScopeRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingScopeRole?), TypeInfoPropertyName = "NullableSettingScopeRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingsTypes?), TypeInfoPropertyName = "NullableSettingsTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SettingsSectionNames?), TypeInfoPropertyName = "NullableSettingsSectionNames2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.PlatformEntityType?, global::Dataloop.PartialSettingScopeType?>?), TypeInfoPropertyName = "NullableAnyOfPlatformEntityTypePartialSettingScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialSettingScopeType?), TypeInfoPropertyName = "NullablePartialSettingScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::Dataloop.PartialSettingScopeId?>?), TypeInfoPropertyName = "NullableAnyOfStringPartialSettingScopeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialSettingScopeId?), TypeInfoPropertyName = "NullablePartialSettingScopeId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.PartialSettingScopeRole?>?), TypeInfoPropertyName = "NullableAnyOfRoleOrgRolePartialSettingScopeRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialSettingScopeRole?), TypeInfoPropertyName = "NullablePartialSettingScopeRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.ResolverPayload, global::Dataloop.IUserContext>?), TypeInfoPropertyName = "NullableAnyOfResolverPayloadIUserContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.PatchFeatureFlagRequest, global::Dataloop.PatchUserSettingRequest>?), TypeInfoPropertyName = "NullableAnyOfPatchFeatureFlagRequestPatchUserSettingRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>?), TypeInfoPropertyName = "NullableAnyOfAPIFeatureFlagAPIUserSetting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.EntityReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ModelStatusLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>>))]
    internal sealed partial class SettingsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SettingsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SettingsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SettingsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Dataloop.JsonConverters.ModelOutputTypeJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.Role?, global::Dataloop.OrgRole?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.OrgRole?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ItemArtifact, global::Dataloop.LocalArtifact>());
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
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PlatformEntityType?, global::Dataloop.SettingScopeType?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::Dataloop.SettingScopeId?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.SettingScopeRole?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PlatformEntityType?, global::Dataloop.PartialSettingScopeType?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::Dataloop.PartialSettingScopeId?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.Role?, global::Dataloop.OrgRole?, global::Dataloop.PartialSettingScopeRole?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIUserSetting, global::Dataloop.APIFeatureFlag>());
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
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.ResolverPayload, global::Dataloop.IUserContext>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PatchFeatureFlagRequest, global::Dataloop.PatchUserSettingRequest>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>());
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
                    typeToConvert == typeof(global::Dataloop.QueryResource)

                    || typeToConvert == typeof(global::Dataloop.QueryResource?)

                    || typeToConvert == typeof(global::Dataloop.AnnotationType)

                    || typeToConvert == typeof(global::Dataloop.AnnotationType?)

                    || typeToConvert == typeof(global::Dataloop.Role)

                    || typeToConvert == typeof(global::Dataloop.Role?)

                    || typeToConvert == typeof(global::Dataloop.OrgRole)

                    || typeToConvert == typeof(global::Dataloop.OrgRole?)

                    || typeToConvert == typeof(global::Dataloop.EntityScopeLevel)

                    || typeToConvert == typeof(global::Dataloop.EntityScopeLevel?)

                    || typeToConvert == typeof(global::Dataloop.ModelStatus)

                    || typeToConvert == typeof(global::Dataloop.ModelStatus?)

                    || typeToConvert == typeof(global::Dataloop.ModelInputType)

                    || typeToConvert == typeof(global::Dataloop.ModelInputType?)

                    || typeToConvert == typeof(global::Dataloop.ModelOutputTypeVariant2)

                    || typeToConvert == typeof(global::Dataloop.ModelOutputTypeVariant2?)

                    || typeToConvert == typeof(global::Dataloop.ModelOutputTypeVariant4)

                    || typeToConvert == typeof(global::Dataloop.ModelOutputTypeVariant4?)

                    || typeToConvert == typeof(global::Dataloop.ArtifactType)

                    || typeToConvert == typeof(global::Dataloop.ArtifactType?)

                    || typeToConvert == typeof(global::Dataloop.ReferenceType)

                    || typeToConvert == typeof(global::Dataloop.ReferenceType?)

                    || typeToConvert == typeof(global::Dataloop.NodeMlType)

                    || typeToConvert == typeof(global::Dataloop.NodeMlType?)

                    || typeToConvert == typeof(global::Dataloop.ModelOperationTypes)

                    || typeToConvert == typeof(global::Dataloop.ModelOperationTypes?)

                    || typeToConvert == typeof(global::Dataloop.SettingsValueTypes)

                    || typeToConvert == typeof(global::Dataloop.SettingsValueTypes?)

                    || typeToConvert == typeof(global::Dataloop.PlatformEntityType)

                    || typeToConvert == typeof(global::Dataloop.PlatformEntityType?)

                    || typeToConvert == typeof(global::Dataloop.SettingScopeType)

                    || typeToConvert == typeof(global::Dataloop.SettingScopeType?)

                    || typeToConvert == typeof(global::Dataloop.SettingScopeId)

                    || typeToConvert == typeof(global::Dataloop.SettingScopeId?)

                    || typeToConvert == typeof(global::Dataloop.SettingScopeRole)

                    || typeToConvert == typeof(global::Dataloop.SettingScopeRole?)

                    || typeToConvert == typeof(global::Dataloop.SettingsTypes)

                    || typeToConvert == typeof(global::Dataloop.SettingsTypes?)

                    || typeToConvert == typeof(global::Dataloop.SettingsSectionNames)

                    || typeToConvert == typeof(global::Dataloop.SettingsSectionNames?)

                    || typeToConvert == typeof(global::Dataloop.PartialSettingScopeType)

                    || typeToConvert == typeof(global::Dataloop.PartialSettingScopeType?)

                    || typeToConvert == typeof(global::Dataloop.PartialSettingScopeId)

                    || typeToConvert == typeof(global::Dataloop.PartialSettingScopeId?)

                    || typeToConvert == typeof(global::Dataloop.PartialSettingScopeRole)

                    || typeToConvert == typeof(global::Dataloop.PartialSettingScopeRole?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Dataloop.QueryResource))
                {
                    return new global::Dataloop.JsonConverters.QueryResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QueryResource?))
                {
                    return new global::Dataloop.JsonConverters.QueryResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AnnotationType))
                {
                    return new global::Dataloop.JsonConverters.AnnotationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AnnotationType?))
                {
                    return new global::Dataloop.JsonConverters.AnnotationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.Role))
                {
                    return new global::Dataloop.JsonConverters.RoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.Role?))
                {
                    return new global::Dataloop.JsonConverters.RoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OrgRole))
                {
                    return new global::Dataloop.JsonConverters.OrgRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OrgRole?))
                {
                    return new global::Dataloop.JsonConverters.OrgRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EntityScopeLevel))
                {
                    return new global::Dataloop.JsonConverters.EntityScopeLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.EntityScopeLevel?))
                {
                    return new global::Dataloop.JsonConverters.EntityScopeLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelStatus))
                {
                    return new global::Dataloop.JsonConverters.ModelStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelStatus?))
                {
                    return new global::Dataloop.JsonConverters.ModelStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelInputType))
                {
                    return new global::Dataloop.JsonConverters.ModelInputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelInputType?))
                {
                    return new global::Dataloop.JsonConverters.ModelInputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelOutputTypeVariant2))
                {
                    return new global::Dataloop.JsonConverters.ModelOutputTypeVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelOutputTypeVariant2?))
                {
                    return new global::Dataloop.JsonConverters.ModelOutputTypeVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelOutputTypeVariant4))
                {
                    return new global::Dataloop.JsonConverters.ModelOutputTypeVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelOutputTypeVariant4?))
                {
                    return new global::Dataloop.JsonConverters.ModelOutputTypeVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ArtifactType))
                {
                    return new global::Dataloop.JsonConverters.ArtifactTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ArtifactType?))
                {
                    return new global::Dataloop.JsonConverters.ArtifactTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReferenceType))
                {
                    return new global::Dataloop.JsonConverters.ReferenceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReferenceType?))
                {
                    return new global::Dataloop.JsonConverters.ReferenceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.NodeMlType))
                {
                    return new global::Dataloop.JsonConverters.NodeMlTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.NodeMlType?))
                {
                    return new global::Dataloop.JsonConverters.NodeMlTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelOperationTypes))
                {
                    return new global::Dataloop.JsonConverters.ModelOperationTypesJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModelOperationTypes?))
                {
                    return new global::Dataloop.JsonConverters.ModelOperationTypesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingsValueTypes))
                {
                    return new global::Dataloop.JsonConverters.SettingsValueTypesJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingsValueTypes?))
                {
                    return new global::Dataloop.JsonConverters.SettingsValueTypesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PlatformEntityType))
                {
                    return new global::Dataloop.JsonConverters.PlatformEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PlatformEntityType?))
                {
                    return new global::Dataloop.JsonConverters.PlatformEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingScopeType))
                {
                    return new global::Dataloop.JsonConverters.SettingScopeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingScopeType?))
                {
                    return new global::Dataloop.JsonConverters.SettingScopeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingScopeId))
                {
                    return new global::Dataloop.JsonConverters.SettingScopeIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingScopeId?))
                {
                    return new global::Dataloop.JsonConverters.SettingScopeIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingScopeRole))
                {
                    return new global::Dataloop.JsonConverters.SettingScopeRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingScopeRole?))
                {
                    return new global::Dataloop.JsonConverters.SettingScopeRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingsTypes))
                {
                    return new global::Dataloop.JsonConverters.SettingsTypesJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingsTypes?))
                {
                    return new global::Dataloop.JsonConverters.SettingsTypesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingsSectionNames))
                {
                    return new global::Dataloop.JsonConverters.SettingsSectionNamesJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.SettingsSectionNames?))
                {
                    return new global::Dataloop.JsonConverters.SettingsSectionNamesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PartialSettingScopeType))
                {
                    return new global::Dataloop.JsonConverters.PartialSettingScopeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PartialSettingScopeType?))
                {
                    return new global::Dataloop.JsonConverters.PartialSettingScopeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PartialSettingScopeId))
                {
                    return new global::Dataloop.JsonConverters.PartialSettingScopeIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PartialSettingScopeId?))
                {
                    return new global::Dataloop.JsonConverters.PartialSettingScopeIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PartialSettingScopeRole))
                {
                    return new global::Dataloop.JsonConverters.PartialSettingScopeRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PartialSettingScopeRole?))
                {
                    return new global::Dataloop.JsonConverters.PartialSettingScopeRoleNullableJsonConverter();
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
                    0 => new SettingsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}