
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.JoinQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.JoinQueryOn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReferenceQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReferenceQueryOperation), TypeInfoPropertyName = "ReferenceQueryOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ReferenceQueryRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReferenceQueryRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngine), TypeInfoPropertyName = "PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IntersectQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OrderBy), TypeInfoPropertyName = "OrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SortQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.OrderBy?, global::Dataloop.SortQuery>), TypeInfoPropertyName = "AnyOfOrderBySortQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DQLResourceQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DQLResourceQueryQueryEngine), TypeInfoPropertyName = "DQLResourceQueryQueryEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DQLResourceQuerySign))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResourceItems), TypeInfoPropertyName = "QueryResourceItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResourceAnnotations), TypeInfoPropertyName = "QueryResourceAnnotations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResourceDatasets), TypeInfoPropertyName = "QueryResourceDatasets2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FilterQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FilterQueryContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?>), TypeInfoPropertyName = "AnyOfQueryResourceItemsQueryResourceAnnotationsQueryResourceDatasets2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Context))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DatasetContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AuthZBlockDatasetContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.DatasetContext>), TypeInfoPropertyName = "AllOfContextDatasetContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIFeatureSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPIFeatureSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIFeatureSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FeatureSetEntityType), TypeInfoPropertyName = "FeatureSetEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FeatureSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialFeatureSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>), TypeInfoPropertyName = "AllOfDQLResourceQueryFilterQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.FeatureSet, global::System.Collections.Generic.IList<global::Dataloop.FeatureSet>>), TypeInfoPropertyName = "AnyOfFeatureSetIListFeatureSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.FeatureSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResource?), TypeInfoPropertyName = "NullableQueryResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReferenceQueryOperation?), TypeInfoPropertyName = "NullableReferenceQueryOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngine?), TypeInfoPropertyName = "NullablePickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.OrderBy?), TypeInfoPropertyName = "NullableOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.OrderBy?, global::Dataloop.SortQuery>?), TypeInfoPropertyName = "NullableAnyOfOrderBySortQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DQLResourceQueryQueryEngine?), TypeInfoPropertyName = "NullableDQLResourceQueryQueryEngine2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResourceItems?), TypeInfoPropertyName = "NullableQueryResourceItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResourceAnnotations?), TypeInfoPropertyName = "NullableQueryResourceAnnotations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResourceDatasets?), TypeInfoPropertyName = "NullableQueryResourceDatasets2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?>?), TypeInfoPropertyName = "NullableAnyOfQueryResourceItemsQueryResourceAnnotationsQueryResourceDatasets2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.DatasetContext>?), TypeInfoPropertyName = "NullableAllOfContextDatasetContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FeatureSetEntityType?), TypeInfoPropertyName = "NullableFeatureSetEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>?), TypeInfoPropertyName = "NullableAllOfDQLResourceQueryFilterQuery2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.FeatureSet, global::System.Collections.Generic.IList<global::Dataloop.FeatureSet>>?), TypeInfoPropertyName = "NullableAnyOfFeatureSetIListFeatureSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ReferenceQueryRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIFeatureSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.FeatureSet, global::System.Collections.Generic.List<global::Dataloop.FeatureSet>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.FeatureSet>))]
    internal sealed partial class FeatureSetsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FeatureSetsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static FeatureSetsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private FeatureSetsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.OrderBy?, global::Dataloop.SortQuery>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.QueryResourceItems?, global::Dataloop.QueryResourceAnnotations?, global::Dataloop.QueryResourceDatasets?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.DatasetContext>());
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
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.FeatureSet, global::System.Collections.Generic.IList<global::Dataloop.FeatureSet>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.DQLResourceQuery, global::Dataloop.FilterQuery>());
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
                    typeToConvert == typeof(global::Dataloop.QueryResource)

                    || typeToConvert == typeof(global::Dataloop.QueryResource?)

                    || typeToConvert == typeof(global::Dataloop.ReferenceQueryOperation)

                    || typeToConvert == typeof(global::Dataloop.ReferenceQueryOperation?)

                    || typeToConvert == typeof(global::Dataloop.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngine)

                    || typeToConvert == typeof(global::Dataloop.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngine?)

                    || typeToConvert == typeof(global::Dataloop.OrderBy)

                    || typeToConvert == typeof(global::Dataloop.OrderBy?)

                    || typeToConvert == typeof(global::Dataloop.DQLResourceQueryQueryEngine)

                    || typeToConvert == typeof(global::Dataloop.DQLResourceQueryQueryEngine?)

                    || typeToConvert == typeof(global::Dataloop.QueryResourceItems)

                    || typeToConvert == typeof(global::Dataloop.QueryResourceItems?)

                    || typeToConvert == typeof(global::Dataloop.QueryResourceAnnotations)

                    || typeToConvert == typeof(global::Dataloop.QueryResourceAnnotations?)

                    || typeToConvert == typeof(global::Dataloop.QueryResourceDatasets)

                    || typeToConvert == typeof(global::Dataloop.QueryResourceDatasets?)

                    || typeToConvert == typeof(global::Dataloop.FeatureSetEntityType)

                    || typeToConvert == typeof(global::Dataloop.FeatureSetEntityType?);
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

                if (typeToConvert == typeof(global::Dataloop.ReferenceQueryOperation))
                {
                    return new global::Dataloop.JsonConverters.ReferenceQueryOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ReferenceQueryOperation?))
                {
                    return new global::Dataloop.JsonConverters.ReferenceQueryOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngine))
                {
                    return new global::Dataloop.JsonConverters.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngineJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngine?))
                {
                    return new global::Dataloop.JsonConverters.PickDQLQueryExcludeKeyofDQLQueryIntersectOrExceptOrLimitOrSortOrSelectQueryEngineNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OrderBy))
                {
                    return new global::Dataloop.JsonConverters.OrderByJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.OrderBy?))
                {
                    return new global::Dataloop.JsonConverters.OrderByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DQLResourceQueryQueryEngine))
                {
                    return new global::Dataloop.JsonConverters.DQLResourceQueryQueryEngineJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DQLResourceQueryQueryEngine?))
                {
                    return new global::Dataloop.JsonConverters.DQLResourceQueryQueryEngineNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QueryResourceItems))
                {
                    return new global::Dataloop.JsonConverters.QueryResourceItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QueryResourceItems?))
                {
                    return new global::Dataloop.JsonConverters.QueryResourceItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QueryResourceAnnotations))
                {
                    return new global::Dataloop.JsonConverters.QueryResourceAnnotationsJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QueryResourceAnnotations?))
                {
                    return new global::Dataloop.JsonConverters.QueryResourceAnnotationsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QueryResourceDatasets))
                {
                    return new global::Dataloop.JsonConverters.QueryResourceDatasetsJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QueryResourceDatasets?))
                {
                    return new global::Dataloop.JsonConverters.QueryResourceDatasetsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FeatureSetEntityType))
                {
                    return new global::Dataloop.JsonConverters.FeatureSetEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FeatureSetEntityType?))
                {
                    return new global::Dataloop.JsonConverters.FeatureSetEntityTypeNullableJsonConverter();
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
                    0 => new FeatureSetsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}