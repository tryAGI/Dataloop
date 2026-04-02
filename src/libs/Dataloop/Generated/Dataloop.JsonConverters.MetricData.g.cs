#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public class MetricDataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.MetricData>
    {
        /// <inheritdoc />
        public override global::Dataloop.MetricData Read(
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
            if (__jsonProps.Contains("x")) __score0++;
            if (__jsonProps.Contains("y")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("matrix")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("summary")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Dataloop.LineData? line = default;
            global::Dataloop.MatrixData? matrix = default;
            global::Dataloop.SummaryData? summary = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        line = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.LineData>(__rawJson, options);
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
                        matrix = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.MatrixData>(__rawJson, options);
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
                        summary = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.SummaryData>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (line == null && matrix == null && summary == null)
            {
                try
                {
                    line = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.LineData>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    matrix = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.MatrixData>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    summary = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.SummaryData>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Dataloop.MetricData(
                line,

                matrix,

                summary
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.MetricData value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsLine)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Line, typeof(global::Dataloop.LineData), options);
            }
            else if (value.IsMatrix)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Matrix, typeof(global::Dataloop.MatrixData), options);
            }
            else if (value.IsSummary)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Summary, typeof(global::Dataloop.SummaryData), options);
            }
        }
    }
}