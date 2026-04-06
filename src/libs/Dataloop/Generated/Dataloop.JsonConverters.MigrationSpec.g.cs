#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public class MigrationSpecJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.MigrationSpec>
    {
        /// <inheritdoc />
        public override global::Dataloop.MigrationSpec Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

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
            if (__jsonProps.Contains("fix")) __score1++;
            if (__jsonProps.Contains("report")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Dataloop.Dictionary? dictionary = default;
            global::Dataloop.MigrationSpecVariant2? migrationSpecVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.Dictionary), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.Dictionary> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.Dictionary).Name}");
                        dictionary = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.MigrationSpecVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.MigrationSpecVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.MigrationSpecVariant2).Name}");
                        migrationSpecVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (dictionary == null && migrationSpecVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.Dictionary), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.Dictionary> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.Dictionary).Name}");
                    dictionary = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.MigrationSpecVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.MigrationSpecVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.MigrationSpecVariant2).Name}");
                    migrationSpecVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Dataloop.MigrationSpec(
                dictionary,

                migrationSpecVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.MigrationSpec value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDictionary)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.Dictionary), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.Dictionary?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.Dictionary).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dictionary!, typeInfo);
            }
            else if (value.IsMigrationSpecVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.MigrationSpecVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.MigrationSpecVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.MigrationSpecVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MigrationSpecVariant2!, typeInfo);
            }
        }
    }
}