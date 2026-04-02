#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public class RecipeV2InputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.RecipeV2Input>
    {
        /// <inheritdoc />
        public override global::Dataloop.RecipeV2Input Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("ontology")) __score0++;
            if (__jsonProps.Contains("projectIds")) __score0++;
            if (__jsonProps.Contains("title")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("_id")) __score1++;
            if (__jsonProps.Contains("authz")) __score1++;
            if (__jsonProps.Contains("createdAt")) __score1++;
            if (__jsonProps.Contains("creator")) __score1++;
            if (__jsonProps.Contains("metadata")) __score1++;
            if (__jsonProps.Contains("ontology")) __score1++;
            if (__jsonProps.Contains("projectIds")) __score1++;
            if (__jsonProps.Contains("title")) __score1++;
            if (__jsonProps.Contains("toolsSettings")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("uiSettings")) __score1++;
            if (__jsonProps.Contains("updatedAt")) __score1++;
            if (__jsonProps.Contains("updatedBy")) __score1++;
            if (__jsonProps.Contains("v2")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntology? pickTitleOrProjectIdsOntology = default;
            global::Dataloop.PartialRecipeV2? partial = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        pickTitleOrProjectIdsOntology = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntology>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        partial = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.PartialRecipeV2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (pickTitleOrProjectIdsOntology == null && partial == null)
            {
                try
                {
                    pickTitleOrProjectIdsOntology = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntology>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    partial = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.PartialRecipeV2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Dataloop.RecipeV2Input(
                pickTitleOrProjectIdsOntology,

                partial
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.RecipeV2Input value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsPickTitleOrProjectIdsOntology)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTitleOrProjectIdsOntology, typeof(global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntology), options);
            }
            else if (value.IsPartial)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Partial, typeof(global::Dataloop.PartialRecipeV2), options);
            }
        }
    }
}