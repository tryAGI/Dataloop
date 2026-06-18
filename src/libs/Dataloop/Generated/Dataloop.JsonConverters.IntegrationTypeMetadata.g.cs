#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public class IntegrationTypeMetadataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.IntegrationTypeMetadata>
    {
        /// <inheritdoc />
        public override global::Dataloop.IntegrationTypeMetadata Read(
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
            if (__jsonProps.Contains("provider")) __score0++;
            if (__jsonProps.Contains("ref")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("endpoint")) __score1++;
            if (__jsonProps.Contains("region")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Dataloop.IKeyValueMetadata? iKeyValue = default;
            global::Dataloop.IS3ApiMetadata? iS3Api = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IKeyValueMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IKeyValueMetadata> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IKeyValueMetadata).Name}");
                        iKeyValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IS3ApiMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IS3ApiMetadata> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IS3ApiMetadata).Name}");
                        iS3Api = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (iKeyValue == null && iS3Api == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IKeyValueMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IKeyValueMetadata> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IKeyValueMetadata).Name}");
                    iKeyValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (iKeyValue == null && iS3Api == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IS3ApiMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IS3ApiMetadata> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IS3ApiMetadata).Name}");
                    iS3Api = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Dataloop.IntegrationTypeMetadata(
                iKeyValue,

                iS3Api
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.IntegrationTypeMetadata value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsIKeyValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IKeyValueMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IKeyValueMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IKeyValueMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IKeyValue!, typeInfo);
            }
            else if (value.IsIS3Api)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IS3ApiMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IS3ApiMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IS3ApiMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IS3Api!, typeInfo);
            }
        }
    }
}