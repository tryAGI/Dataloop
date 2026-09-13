
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnnotationType), TypeInfoPropertyName = "AnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Point))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.NoteMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CoordinatesNote))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.NoteMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APINoteAnnotationCoordinatesV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PoseCoordinates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.Point>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.EllipseCoordinatesV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CubeCoordinatesV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemDescriptionCoordinates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RefAnnotationsRefType), TypeInfoPropertyName = "RefAnnotationsRefType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IBaseRefAnnotationCoordinates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IRefImageAnnotationsType), TypeInfoPropertyName = "IRefImageAnnotationsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAnnotationCoordinateTypes), TypeInfoPropertyName = "APIAnnotationCoordinateTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RequestSource), TypeInfoPropertyName = "RequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialAPIAnnotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAnnotationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<bool?, global::Dataloop.APIAnnotationEventDeleted?>), TypeInfoPropertyName = "AnyOfBooleanAPIAnnotationEventDeleted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAnnotationEventDeleted), TypeInfoPropertyName = "APIAnnotationEventDeleted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationEvent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnnotationType?), TypeInfoPropertyName = "NullableAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RefAnnotationsRefType?), TypeInfoPropertyName = "NullableRefAnnotationsRefType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IRefImageAnnotationsType?), TypeInfoPropertyName = "NullableIRefImageAnnotationsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAnnotationCoordinateTypes?), TypeInfoPropertyName = "NullableAPIAnnotationCoordinateTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RequestSource?), TypeInfoPropertyName = "NullableRequestSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<bool?, global::Dataloop.APIAnnotationEventDeleted?>?), TypeInfoPropertyName = "NullableAnyOfBooleanAPIAnnotationEventDeleted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAnnotationEventDeleted?), TypeInfoPropertyName = "NullableAPIAnnotationEventDeleted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.NoteMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Dataloop.Point>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.Point>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Dataloop.APIAnnotationEvent>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIAnnotationEvent>))]
    internal sealed partial class AnnotationLogsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationLogsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AnnotationLogsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AnnotationLogsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Dataloop.JsonConverters.IRefImageAnnotationsTypeJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.APIAnnotationCoordinateTypesJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<bool?, global::Dataloop.APIAnnotationEventDeleted?>());
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
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
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
                    typeToConvert == typeof(global::Dataloop.AnnotationType)

                    || typeToConvert == typeof(global::Dataloop.AnnotationType?)

                    || typeToConvert == typeof(global::Dataloop.RefAnnotationsRefType)

                    || typeToConvert == typeof(global::Dataloop.RefAnnotationsRefType?)

                    || typeToConvert == typeof(global::Dataloop.RequestSource)

                    || typeToConvert == typeof(global::Dataloop.RequestSource?)

                    || typeToConvert == typeof(global::Dataloop.APIAnnotationEventDeleted)

                    || typeToConvert == typeof(global::Dataloop.APIAnnotationEventDeleted?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Dataloop.AnnotationType))
                {
                    return new global::Dataloop.JsonConverters.AnnotationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AnnotationType?))
                {
                    return new global::Dataloop.JsonConverters.AnnotationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.RefAnnotationsRefType))
                {
                    return new global::Dataloop.JsonConverters.RefAnnotationsRefTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.RefAnnotationsRefType?))
                {
                    return new global::Dataloop.JsonConverters.RefAnnotationsRefTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.RequestSource))
                {
                    return new global::Dataloop.JsonConverters.RequestSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.RequestSource?))
                {
                    return new global::Dataloop.JsonConverters.RequestSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APIAnnotationEventDeleted))
                {
                    return new global::Dataloop.JsonConverters.APIAnnotationEventDeletedJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APIAnnotationEventDeleted?))
                {
                    return new global::Dataloop.JsonConverters.APIAnnotationEventDeletedNullableJsonConverter();
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
                    0 => new AnnotationLogsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}