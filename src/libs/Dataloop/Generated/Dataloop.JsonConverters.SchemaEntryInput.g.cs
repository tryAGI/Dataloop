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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Dataloop.SchemaEntryInputVariant1? schemaEntryInputVariant1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.SchemaEntryInputVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.SchemaEntryInputVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.SchemaEntryInputVariant1).Name}");
                schemaEntryInputVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>? schemaEntryInputVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>).Name}");
                schemaEntryInputVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsSchemaEntryInputVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.SchemaEntryInputVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.SchemaEntryInputVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.SchemaEntryInputVariant1).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.SchemaEntryInputVariant1!, typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsSchemaEntryInputVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.SchemaEntryInputVariant2!.Value, typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}