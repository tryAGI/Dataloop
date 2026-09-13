
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemSpecType), TypeInfoPropertyName = "ItemSpecType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RefType), TypeInfoPropertyName = "RefType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModalityType), TypeInfoPropertyName = "ModalityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIModality))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APISystemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APISystemMetadataSystem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetFileItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetFileItemType), TypeInfoPropertyName = "APIDatasetFileItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<bool?, global::Dataloop.APIDatasetFileItemAnnotated?>), TypeInfoPropertyName = "AnyOfBooleanAPIDatasetFileItemAnnotated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetFileItemAnnotated), TypeInfoPropertyName = "APIDatasetFileItemAnnotated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetDirectoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetDirectoryItemType), TypeInfoPropertyName = "APIDatasetDirectoryItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetDirectoryItemExport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::Dataloop.APIDatasetDirectoryItemExportZip>), TypeInfoPropertyName = "AnyOfStringAPIDatasetDirectoryItemExportZip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetDirectoryItemExportZip))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialAPIDatasetItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetItemCursor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIDatasetFileItem>, global::System.Collections.Generic.IList<global::Dataloop.APIDatasetDirectoryItem>>), TypeInfoPropertyName = "AnyOfIListAPIDatasetFileItemIListAPIDatasetDirectoryItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIDatasetFileItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIDatasetDirectoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Dictionary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetIndexDrivers), TypeInfoPropertyName = "DatasetIndexDrivers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CloneDatasetParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemCloneRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>), TypeInfoPropertyName = "AnyOfAPIDatasetFileItemAPIDatasetDirectoryItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemSpecType?), TypeInfoPropertyName = "NullableItemSpecType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RefType?), TypeInfoPropertyName = "NullableRefType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ModalityType?), TypeInfoPropertyName = "NullableModalityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetFileItemType?), TypeInfoPropertyName = "NullableAPIDatasetFileItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<bool?, global::Dataloop.APIDatasetFileItemAnnotated?>?), TypeInfoPropertyName = "NullableAnyOfBooleanAPIDatasetFileItemAnnotated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetFileItemAnnotated?), TypeInfoPropertyName = "NullableAPIDatasetFileItemAnnotated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIDatasetDirectoryItemType?), TypeInfoPropertyName = "NullableAPIDatasetDirectoryItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::Dataloop.APIDatasetDirectoryItemExportZip>?), TypeInfoPropertyName = "NullableAnyOfStringAPIDatasetDirectoryItemExportZip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.IList<global::Dataloop.APIDatasetFileItem>, global::System.Collections.Generic.IList<global::Dataloop.APIDatasetDirectoryItem>>?), TypeInfoPropertyName = "NullableAnyOfIListAPIDatasetFileItemIListAPIDatasetDirectoryItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetIndexDrivers?), TypeInfoPropertyName = "NullableDatasetIndexDrivers2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>?), TypeInfoPropertyName = "NullableAnyOfAPIDatasetFileItemAPIDatasetDirectoryItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::System.Collections.Generic.List<global::Dataloop.APIDatasetFileItem>, global::System.Collections.Generic.List<global::Dataloop.APIDatasetDirectoryItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIDatasetFileItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIDatasetDirectoryItem>))]
    internal sealed partial class ItemsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ItemsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ItemsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ItemsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<bool?, global::Dataloop.APIDatasetFileItemAnnotated?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::Dataloop.APIDatasetDirectoryItemExportZip>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Dataloop.APIDatasetFileItem>, global::System.Collections.Generic.IList<global::Dataloop.APIDatasetDirectoryItem>>());
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
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>());
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
                    typeToConvert == typeof(global::Dataloop.ItemSpecType)

                    || typeToConvert == typeof(global::Dataloop.ItemSpecType?)

                    || typeToConvert == typeof(global::Dataloop.RefType)

                    || typeToConvert == typeof(global::Dataloop.RefType?)

                    || typeToConvert == typeof(global::Dataloop.ModalityType)

                    || typeToConvert == typeof(global::Dataloop.ModalityType?)

                    || typeToConvert == typeof(global::Dataloop.APIDatasetFileItemType)

                    || typeToConvert == typeof(global::Dataloop.APIDatasetFileItemType?)

                    || typeToConvert == typeof(global::Dataloop.APIDatasetFileItemAnnotated)

                    || typeToConvert == typeof(global::Dataloop.APIDatasetFileItemAnnotated?)

                    || typeToConvert == typeof(global::Dataloop.APIDatasetDirectoryItemType)

                    || typeToConvert == typeof(global::Dataloop.APIDatasetDirectoryItemType?)

                    || typeToConvert == typeof(global::Dataloop.DatasetIndexDrivers)

                    || typeToConvert == typeof(global::Dataloop.DatasetIndexDrivers?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Dataloop.ItemSpecType))
                {
                    return new global::Dataloop.JsonConverters.ItemSpecTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ItemSpecType?))
                {
                    return new global::Dataloop.JsonConverters.ItemSpecTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.RefType))
                {
                    return new global::Dataloop.JsonConverters.RefTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.RefType?))
                {
                    return new global::Dataloop.JsonConverters.RefTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModalityType))
                {
                    return new global::Dataloop.JsonConverters.ModalityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ModalityType?))
                {
                    return new global::Dataloop.JsonConverters.ModalityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APIDatasetFileItemType))
                {
                    return new global::Dataloop.JsonConverters.APIDatasetFileItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APIDatasetFileItemType?))
                {
                    return new global::Dataloop.JsonConverters.APIDatasetFileItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APIDatasetFileItemAnnotated))
                {
                    return new global::Dataloop.JsonConverters.APIDatasetFileItemAnnotatedJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APIDatasetFileItemAnnotated?))
                {
                    return new global::Dataloop.JsonConverters.APIDatasetFileItemAnnotatedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APIDatasetDirectoryItemType))
                {
                    return new global::Dataloop.JsonConverters.APIDatasetDirectoryItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APIDatasetDirectoryItemType?))
                {
                    return new global::Dataloop.JsonConverters.APIDatasetDirectoryItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DatasetIndexDrivers))
                {
                    return new global::Dataloop.JsonConverters.DatasetIndexDriversJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DatasetIndexDrivers?))
                {
                    return new global::Dataloop.JsonConverters.DatasetIndexDriversNullableJsonConverter();
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
                    0 => new ItemsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}