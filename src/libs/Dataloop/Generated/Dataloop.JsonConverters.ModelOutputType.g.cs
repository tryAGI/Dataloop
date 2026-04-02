#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public class ModelOutputTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.ModelOutputType>
    {
        /// <inheritdoc />
        public override global::Dataloop.ModelOutputType Read(
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
            var __score2 = 0;
            var __score3 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Dataloop.AnnotationType? annotation1 = default;
            global::Dataloop.ModelOutputTypeVariant2? modelOutputTypeVariant2 = default;
            global::Dataloop.AnnotationType? annotation2 = default;
            global::Dataloop.ModelOutputTypeVariant4? modelOutputTypeVariant4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        annotation1 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.AnnotationType>(__rawJson, options);
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

                        modelOutputTypeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.ModelOutputTypeVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 2)
                {
                    try
                    {

                        annotation2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.AnnotationType>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 3)
                {
                    try
                    {

                        modelOutputTypeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.ModelOutputTypeVariant4>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (annotation1 == null && modelOutputTypeVariant2 == null && annotation2 == null && modelOutputTypeVariant4 == null)
            {
                try
                {

                    annotation1 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.AnnotationType>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    modelOutputTypeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.ModelOutputTypeVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    annotation2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.AnnotationType>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    modelOutputTypeVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.ModelOutputTypeVariant4>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Dataloop.ModelOutputType(
                annotation1,

                modelOutputTypeVariant2,

                annotation2,

                modelOutputTypeVariant4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.ModelOutputType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsAnnotation1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Annotation1, typeof(global::Dataloop.AnnotationType), options);
            }
            else if (value.IsModelOutputTypeVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelOutputTypeVariant2, typeof(global::Dataloop.ModelOutputTypeVariant2), options);
            }
            else if (value.IsAnnotation2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Annotation2, typeof(global::Dataloop.AnnotationType), options);
            }
            else if (value.IsModelOutputTypeVariant4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelOutputTypeVariant4, typeof(global::Dataloop.ModelOutputTypeVariant4), options);
            }
        }
    }
}