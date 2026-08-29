#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public class RemoveSettingTraceMigrationSpecJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.RemoveSettingTraceMigrationSpec>
    {
        /// <inheritdoc />
        public override global::Dataloop.RemoveSettingTraceMigrationSpec Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Dataloop.MigrationSpec? migrationSpec = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.MigrationSpec), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.MigrationSpec> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.MigrationSpec).Name}");
                migrationSpec = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Dataloop.RemoveSettingTraceMigrationSpecVariant2? removeSettingTraceMigrationSpecVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.RemoveSettingTraceMigrationSpecVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.RemoveSettingTraceMigrationSpecVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.RemoveSettingTraceMigrationSpecVariant2).Name}");
                removeSettingTraceMigrationSpecVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Dataloop.RemoveSettingTraceMigrationSpec(
                migrationSpec,

                removeSettingTraceMigrationSpecVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.RemoveSettingTraceMigrationSpec value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsMigrationSpec)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.MigrationSpec), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.MigrationSpec> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.MigrationSpec).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.MigrationSpec!.Value, typeInfo);
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
            if (value.IsRemoveSettingTraceMigrationSpecVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.RemoveSettingTraceMigrationSpecVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.RemoveSettingTraceMigrationSpecVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.RemoveSettingTraceMigrationSpecVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.RemoveSettingTraceMigrationSpecVariant2!, typeInfo);
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