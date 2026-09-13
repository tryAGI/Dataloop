
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnnotationType), TypeInfoPropertyName = "AnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Context))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APILabelScopeV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIToolOptionsV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecipeType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIRecipeV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIRecipeV2Ontology))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.APIToolOptionsV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIRecipe))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LabelScopeV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntology))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntologyOntology))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ToolOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Metadata2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecipeV2Context))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AuthZBlockRecipeV2Context))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.RecipeV2Context>), TypeInfoPropertyName = "AllOfContextRecipeV2Context2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialRecipeV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialRecipeV2Ontology))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.ToolOptions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecipeV2Input), TypeInfoPropertyName = "RecipeV2Input2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PickRecipeTitleOrProjectIdsOrOntologyIds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InstructionAction), TypeInfoPropertyName = "InstructionAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InstructionScope), TypeInfoPropertyName = "InstructionScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ToolInstruction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.ToolInstructionOptions, global::Dataloop.Dictionary>), TypeInfoPropertyName = "AllOfToolInstructionOptionsDictionary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ToolInstructionOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.GoodExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.ToolInstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Example))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CustomAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.CustomActionTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CustomActionTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CustomActionControls), TypeInfoPropertyName = "CustomActionControls2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecipeContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AuthZBlockRecipeContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.RecipeContext>), TypeInfoPropertyName = "AllOfContextRecipeContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialRecipe))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialRecipeExamples))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.Example>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.GoodExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.CustomAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecipeInput), TypeInfoPropertyName = "RecipeInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IClientLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.LabelTree))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.LabelTree>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CloneRecipePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialRecipePayloadV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIInstruction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIGoodExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIInstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIBadExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICustomAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APICustomActionTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICustomActionTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICustomActionControls), TypeInfoPropertyName = "APICustomActionControls2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialRecipePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialRecipePayloadExamples))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIBadExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIGoodExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APICustomAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CursorPageAPIRecipeV2OrAPIRecipe))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.AnyOf<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>), TypeInfoPropertyName = "AnyOfAPIRecipeV2APIRecipe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.RecipeV2Input?, global::Dataloop.RecipeInput?>), TypeInfoPropertyName = "AnyOfRecipeV2InputRecipeInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.PartialRecipePayloadV2, global::Dataloop.PartialRecipePayload>), TypeInfoPropertyName = "AnyOfPartialRecipePayloadV2PartialRecipePayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnnotationType?), TypeInfoPropertyName = "NullableAnnotationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.RecipeV2Context>?), TypeInfoPropertyName = "NullableAllOfContextRecipeV2Context2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecipeV2Input?), TypeInfoPropertyName = "NullableRecipeV2Input2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InstructionAction?), TypeInfoPropertyName = "NullableInstructionAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.InstructionScope?), TypeInfoPropertyName = "NullableInstructionScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.ToolInstructionOptions, global::Dataloop.Dictionary>?), TypeInfoPropertyName = "NullableAllOfToolInstructionOptionsDictionary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CustomActionControls?), TypeInfoPropertyName = "NullableCustomActionControls2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AllOf<global::Dataloop.Context, global::Dataloop.RecipeContext>?), TypeInfoPropertyName = "NullableAllOfContextRecipeContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.RecipeInput?), TypeInfoPropertyName = "NullableRecipeInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICustomActionControls?), TypeInfoPropertyName = "NullableAPICustomActionControls2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>?), TypeInfoPropertyName = "NullableAnyOfAPIRecipeV2APIRecipe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.RecipeV2Input?, global::Dataloop.RecipeInput?>?), TypeInfoPropertyName = "NullableAnyOfRecipeV2InputRecipeInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<global::Dataloop.PartialRecipePayloadV2, global::Dataloop.PartialRecipePayload>?), TypeInfoPropertyName = "NullableAnyOfPartialRecipePayloadV2PartialRecipePayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.ToolInstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.CustomActionTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.Example>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.GoodExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.CustomAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.LabelTree>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIInstruction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APICustomActionTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIBadExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIGoodExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APICustomAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.AnyOf<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>>))]
    internal sealed partial class RecipesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RecipesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RecipesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RecipesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Dataloop.JsonConverters.RecipeV2InputJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.RecipeInputJsonConverter());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.RecipeV2Context>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.ToolInstructionOptions, global::Dataloop.Dictionary>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AllOfJsonConverter<global::Dataloop.Context, global::Dataloop.RecipeContext>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>());
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
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.RecipeV2Input?, global::Dataloop.RecipeInput?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.PartialRecipePayloadV2, global::Dataloop.PartialRecipePayload>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>());
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

                    || typeToConvert == typeof(global::Dataloop.InstructionAction)

                    || typeToConvert == typeof(global::Dataloop.InstructionAction?)

                    || typeToConvert == typeof(global::Dataloop.InstructionScope)

                    || typeToConvert == typeof(global::Dataloop.InstructionScope?)

                    || typeToConvert == typeof(global::Dataloop.CustomActionControls)

                    || typeToConvert == typeof(global::Dataloop.CustomActionControls?)

                    || typeToConvert == typeof(global::Dataloop.APICustomActionControls)

                    || typeToConvert == typeof(global::Dataloop.APICustomActionControls?);
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

                if (typeToConvert == typeof(global::Dataloop.InstructionAction))
                {
                    return new global::Dataloop.JsonConverters.InstructionActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.InstructionAction?))
                {
                    return new global::Dataloop.JsonConverters.InstructionActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.InstructionScope))
                {
                    return new global::Dataloop.JsonConverters.InstructionScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.InstructionScope?))
                {
                    return new global::Dataloop.JsonConverters.InstructionScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CustomActionControls))
                {
                    return new global::Dataloop.JsonConverters.CustomActionControlsJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.CustomActionControls?))
                {
                    return new global::Dataloop.JsonConverters.CustomActionControlsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APICustomActionControls))
                {
                    return new global::Dataloop.JsonConverters.APICustomActionControlsJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.APICustomActionControls?))
                {
                    return new global::Dataloop.JsonConverters.APICustomActionControlsNullableJsonConverter();
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
                    0 => new RecipesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}