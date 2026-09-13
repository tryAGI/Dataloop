
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemRefOperation), TypeInfoPropertyName = "ItemRefOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Context))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AssignmentStatus), TypeInfoPropertyName = "AssignmentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAssignmentRemoveItemsProcess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAssignmentRedistributeProcess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialAssignmentPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAssignmentCursor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ReassignAssignmentPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AssignmentWorkload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RedistributeAssignmentPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.AssignmentWorkload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.BatchAssignmentPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AssignmentStatusPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AssignmentMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Dictionary, global::Dataloop.AssignmentMetadataSystem>), TypeInfoPropertyName = "AllOfDictionaryAssignmentMetadataSystem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AssignmentMetadataSystem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AssignmentMetadataSystemType), TypeInfoPropertyName = "AssignmentMetadataSystemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskType), TypeInfoPropertyName = "TaskType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AssignmentContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AuthZBlockAssignmentContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.AssignmentContext>), TypeInfoPropertyName = "AllOfContextAssignmentContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialAssignmentRedistributeProcess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialAssignmentRemoveItemsProcess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SetItemStatusBulkTaskRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.SetItemStatusBulkAssignmentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetAssignmentFieldsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>), TypeInfoPropertyName = "AnyOfAPICommandIListAPIAssignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.APIAssignment>), TypeInfoPropertyName = "AnyOfAPICommandAPIAssignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemRefOperation?), TypeInfoPropertyName = "NullableItemRefOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AssignmentStatus?), TypeInfoPropertyName = "NullableAssignmentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Dictionary, global::Dataloop.AssignmentMetadataSystem>?), TypeInfoPropertyName = "NullableAllOfDictionaryAssignmentMetadataSystem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AssignmentMetadataSystemType?), TypeInfoPropertyName = "NullableAssignmentMetadataSystemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskType?), TypeInfoPropertyName = "NullableTaskType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.AssignmentContext>?), TypeInfoPropertyName = "NullableAllOfContextAssignmentContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>?), TypeInfoPropertyName = "NullableAnyOfAPICommandIListAPIAssignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.APIAssignment>?), TypeInfoPropertyName = "NullableAnyOfAPICommandAPIAssignment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AssignmentWorkload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, global::System.Collections.Generic.List<global::Dataloop.APIAssignment>>))]
    internal sealed partial class AssignmentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssignmentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AssignmentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AssignmentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Dictionary, global::Dataloop.AssignmentMetadataSystem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.AssignmentContext>());
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
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::Dataloop.APIAssignment>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::Dataloop.APIAssignment>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::System.Collections.Generic.IList<global::Dataloop.APIAssignment>>());
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
                    typeToConvert == typeof(global::Dataloop.ItemRefOperation)

                    || typeToConvert == typeof(global::Dataloop.ItemRefOperation?)

                    || typeToConvert == typeof(global::Dataloop.AssignmentStatus)

                    || typeToConvert == typeof(global::Dataloop.AssignmentStatus?)

                    || typeToConvert == typeof(global::Dataloop.AssignmentMetadataSystemType)

                    || typeToConvert == typeof(global::Dataloop.AssignmentMetadataSystemType?)

                    || typeToConvert == typeof(global::Dataloop.TaskType)

                    || typeToConvert == typeof(global::Dataloop.TaskType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Dataloop.ItemRefOperation))
                {
                    return new global::Dataloop.JsonConverters.ItemRefOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ItemRefOperation?))
                {
                    return new global::Dataloop.JsonConverters.ItemRefOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AssignmentStatus))
                {
                    return new global::Dataloop.JsonConverters.AssignmentStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AssignmentStatus?))
                {
                    return new global::Dataloop.JsonConverters.AssignmentStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AssignmentMetadataSystemType))
                {
                    return new global::Dataloop.JsonConverters.AssignmentMetadataSystemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AssignmentMetadataSystemType?))
                {
                    return new global::Dataloop.JsonConverters.AssignmentMetadataSystemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TaskType))
                {
                    return new global::Dataloop.JsonConverters.TaskTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TaskType?))
                {
                    return new global::Dataloop.JsonConverters.TaskTypeNullableJsonConverter();
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
                    0 => new AssignmentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}