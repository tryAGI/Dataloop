#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public class ComputePluginSpecJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.ComputePluginSpec>
    {
        /// <inheritdoc />
        public override global::Dataloop.ComputePluginSpec Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2>? resourceManifests = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2>).Name}");
                resourceManifests = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::Dataloop.ComputePluginSpecVariant2? computePluginSpecVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.ComputePluginSpecVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.ComputePluginSpecVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.ComputePluginSpecVariant2).Name}");
                computePluginSpecVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Dataloop.ComputePluginSpec(
                resourceManifests,

                computePluginSpecVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.ComputePluginSpec value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsResourceManifests)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2>).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.ResourceManifests!, typeInfo);
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
            if (value.IsComputePluginSpecVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.ComputePluginSpecVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.ComputePluginSpecVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.ComputePluginSpecVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.ComputePluginSpecVariant2!, typeInfo);
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