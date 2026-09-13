
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResource), TypeInfoPropertyName = "QueryResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskType), TypeInfoPropertyName = "TaskType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APITaskSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APISpawnTaskSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskStatus), TypeInfoPropertyName = "TaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Description))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APITask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>), TypeInfoPropertyName = "AnyOfAPITaskSpecAPISpawnTaskSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskWorkload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryFilterContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QualityTaskTypes), TypeInfoPropertyName = "QualityTaskTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InstructionsDocumentMode), TypeInfoPropertyName = "InstructionsDocumentMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialTaskInstructionsDocumentDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Dictionary, global::Dataloop.TaskMetadataSystem>), TypeInfoPropertyName = "AllOfDictionaryTaskMetadataSystem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskMetadataSystem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.TaskWorkload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickDescriptionContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskPayloadCheckIfExist))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AddToTaskPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RemoveFromTaskPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialTaskPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskContributorsAction), TypeInfoPropertyName = "TaskContributorsAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateContributorsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APITaskCursor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APITask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskRelativeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskQueueDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DeleteTaskPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAny))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APITaskCounters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.WorkflowsCounters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetProjectsActiveCountersRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GetCountersForProjectRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>), TypeInfoPropertyName = "AnyOfAPITaskAPICommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<object, global::Dataloop.APICommand>), TypeInfoPropertyName = "AnyOfObjectAPICommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.TaskRelativeInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.APITask>), TypeInfoPropertyName = "AnyOfAPICommandAPITask2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QueryResource?), TypeInfoPropertyName = "NullableQueryResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskType?), TypeInfoPropertyName = "NullableTaskType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskStatus?), TypeInfoPropertyName = "NullableTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>?), TypeInfoPropertyName = "NullableAnyOfAPITaskSpecAPISpawnTaskSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.QualityTaskTypes?), TypeInfoPropertyName = "NullableQualityTaskTypes2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InstructionsDocumentMode?), TypeInfoPropertyName = "NullableInstructionsDocumentMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Dictionary, global::Dataloop.TaskMetadataSystem>?), TypeInfoPropertyName = "NullableAllOfDictionaryTaskMetadataSystem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaskContributorsAction?), TypeInfoPropertyName = "NullableTaskContributorsAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APITask, global::Dataloop.APICommand>?), TypeInfoPropertyName = "NullableAnyOfAPITaskAPICommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<object, global::Dataloop.APICommand>?), TypeInfoPropertyName = "NullableAnyOfObjectAPICommand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APICommand, global::Dataloop.APITask>?), TypeInfoPropertyName = "NullableAnyOfAPICommandAPITask2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.TaskWorkload>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APITask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.TaskRelativeInput>))]
    internal sealed partial class TasksSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TasksSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TasksSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TasksSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Dictionary, global::Dataloop.TaskMetadataSystem>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITaskSpec, global::Dataloop.APISpawnTaskSpec>());
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
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITask, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<object, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITask, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::Dataloop.APITask>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, object>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITask, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<object, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APITask, global::Dataloop.APICommand>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APICommand, global::Dataloop.APITask>());
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

                    || typeToConvert == typeof(global::Dataloop.TaskType)

                    || typeToConvert == typeof(global::Dataloop.TaskType?)

                    || typeToConvert == typeof(global::Dataloop.TaskStatus)

                    || typeToConvert == typeof(global::Dataloop.TaskStatus?)

                    || typeToConvert == typeof(global::Dataloop.QualityTaskTypes)

                    || typeToConvert == typeof(global::Dataloop.QualityTaskTypes?)

                    || typeToConvert == typeof(global::Dataloop.InstructionsDocumentMode)

                    || typeToConvert == typeof(global::Dataloop.InstructionsDocumentMode?)

                    || typeToConvert == typeof(global::Dataloop.TaskContributorsAction)

                    || typeToConvert == typeof(global::Dataloop.TaskContributorsAction?);
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

                if (typeToConvert == typeof(global::Dataloop.TaskType))
                {
                    return new global::Dataloop.JsonConverters.TaskTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TaskType?))
                {
                    return new global::Dataloop.JsonConverters.TaskTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TaskStatus))
                {
                    return new global::Dataloop.JsonConverters.TaskStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TaskStatus?))
                {
                    return new global::Dataloop.JsonConverters.TaskStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QualityTaskTypes))
                {
                    return new global::Dataloop.JsonConverters.QualityTaskTypesJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.QualityTaskTypes?))
                {
                    return new global::Dataloop.JsonConverters.QualityTaskTypesNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.InstructionsDocumentMode))
                {
                    return new global::Dataloop.JsonConverters.InstructionsDocumentModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.InstructionsDocumentMode?))
                {
                    return new global::Dataloop.JsonConverters.InstructionsDocumentModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TaskContributorsAction))
                {
                    return new global::Dataloop.JsonConverters.TaskContributorsActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TaskContributorsAction?))
                {
                    return new global::Dataloop.JsonConverters.TaskContributorsActionNullableJsonConverter();
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
                    0 => new TasksSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}