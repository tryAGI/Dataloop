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
            var __score1 = 0;
            if (__jsonProps.Contains("settingName")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Dataloop.MigrationSpec? migrationSpec = default;
            global::Dataloop.RemoveSettingTraceMigrationSpecVariant2? removeSettingTraceMigrationSpecVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        migrationSpec = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.MigrationSpec>(__rawJson, options);
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
                        removeSettingTraceMigrationSpecVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.RemoveSettingTraceMigrationSpecVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (migrationSpec == null && removeSettingTraceMigrationSpecVariant2 == null)
            {
                try
                {
                    migrationSpec = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.MigrationSpec>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    removeSettingTraceMigrationSpecVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.RemoveSettingTraceMigrationSpecVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
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

            if (value.IsMigrationSpec)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MigrationSpec, typeof(global::Dataloop.MigrationSpec), options);
            }
            else if (value.IsRemoveSettingTraceMigrationSpecVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RemoveSettingTraceMigrationSpecVariant2, typeof(global::Dataloop.RemoveSettingTraceMigrationSpecVariant2), options);
            }
        }
    }
}