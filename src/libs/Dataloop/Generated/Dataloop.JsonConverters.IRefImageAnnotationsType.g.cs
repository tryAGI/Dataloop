#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public class IRefImageAnnotationsTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.IRefImageAnnotationsType>
    {
        /// <inheritdoc />
        public override global::Dataloop.IRefImageAnnotationsType Read(
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
            if (__jsonProps.Contains("mimetype")) __score1++;
            if (__jsonProps.Contains("ref")) __score1++;
            if (__jsonProps.Contains("refType")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            object? iRefImageAnnotationsTypeVariant1 = default;
            global::Dataloop.IBaseRefAnnotationCoordinates? baseAnnotationCoordinates = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        iRefImageAnnotationsTypeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
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
                        baseAnnotationCoordinates = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IBaseRefAnnotationCoordinates>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (iRefImageAnnotationsTypeVariant1 == null && baseAnnotationCoordinates == null)
            {
                try
                {
                    iRefImageAnnotationsTypeVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    baseAnnotationCoordinates = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IBaseRefAnnotationCoordinates>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Dataloop.IRefImageAnnotationsType(
                iRefImageAnnotationsTypeVariant1,

                baseAnnotationCoordinates
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.IRefImageAnnotationsType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsIRefImageAnnotationsTypeVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IRefImageAnnotationsTypeVariant1, typeof(object), options);
            }
            else if (value.IsBaseAnnotationCoordinates)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseAnnotationCoordinates, typeof(global::Dataloop.IBaseRefAnnotationCoordinates), options);
            }
        }
    }
}