#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public class SchemaEntryInputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.SchemaEntryInput>
    {
        /// <inheritdoc />
        public override global::Dataloop.SchemaEntryInput Read(
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
            if (__jsonProps.Contains("key")) __score0++;
            if (__jsonProps.Contains("skipUpdate")) __score0++;
            var __score1 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Dataloop.SchemaEntryInputVariant1? schemaEntryInputVariant1 = default;
            global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>? schemaEntryInputVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        schemaEntryInputVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.SchemaEntryInputVariant1>(__rawJson, options);
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
                        schemaEntryInputVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (schemaEntryInputVariant1 == null && schemaEntryInputVariant2 == null)
            {
                try
                {
                    schemaEntryInputVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.SchemaEntryInputVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    schemaEntryInputVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Dataloop.SchemaEntryInput(
                schemaEntryInputVariant1,

                schemaEntryInputVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.SchemaEntryInput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSchemaEntryInputVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SchemaEntryInputVariant1, typeof(global::Dataloop.SchemaEntryInputVariant1), options);
            }
            else if (value.IsSchemaEntryInputVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SchemaEntryInputVariant2, typeof(global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>), options);
            }
        }
    }
}