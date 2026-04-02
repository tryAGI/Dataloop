#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public class CustomInstallationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.CustomInstallation>
    {
        /// <inheritdoc />
        public override global::Dataloop.CustomInstallation Read(
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
            if (__jsonProps.Contains("dependencies")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("codebase")) __score1++;
            if (__jsonProps.Contains("components")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Dataloop.PickAPIDpkDependencies? pickAPIDpkDependencies = default;
            global::Dataloop.CustomInstallationVariant2? customInstallationVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        pickAPIDpkDependencies = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.PickAPIDpkDependencies>(__rawJson, options);
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
                        customInstallationVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.CustomInstallationVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (pickAPIDpkDependencies == null && customInstallationVariant2 == null)
            {
                try
                {
                    pickAPIDpkDependencies = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.PickAPIDpkDependencies>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    customInstallationVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.CustomInstallationVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Dataloop.CustomInstallation(
                pickAPIDpkDependencies,

                customInstallationVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.CustomInstallation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsPickAPIDpkDependencies)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAPIDpkDependencies, typeof(global::Dataloop.PickAPIDpkDependencies), options);
            }
            else if (value.IsCustomInstallationVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomInstallationVariant2, typeof(global::Dataloop.CustomInstallationVariant2), options);
            }
        }
    }
}