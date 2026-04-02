#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public class BenchmarkModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.BenchmarkMode>
    {
        /// <inheritdoc />
        public override global::Dataloop.BenchmarkMode Read(
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
            if (__jsonProps.Contains("count")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("concurrency")) __score2++;
            if (__jsonProps.Contains("total")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Dataloop.OneByOneLatencyBenchmarkMode? oneByLatency = default;
            global::Dataloop.ProfilingBenchmarkMode? profiling = default;
            global::Dataloop.ConcurrencyBenchmarkMode? concurrency = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        oneByLatency = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.OneByOneLatencyBenchmarkMode>(__rawJson, options);
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
                        profiling = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.ProfilingBenchmarkMode>(__rawJson, options);
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
                        concurrency = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.ConcurrencyBenchmarkMode>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (oneByLatency == null && profiling == null && concurrency == null)
            {
                try
                {
                    oneByLatency = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.OneByOneLatencyBenchmarkMode>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    profiling = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.ProfilingBenchmarkMode>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    concurrency = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.ConcurrencyBenchmarkMode>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Dataloop.BenchmarkMode(
                oneByLatency,

                profiling,

                concurrency
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.BenchmarkMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsOneByLatency)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OneByLatency, typeof(global::Dataloop.OneByOneLatencyBenchmarkMode), options);
            }
            else if (value.IsProfiling)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Profiling, typeof(global::Dataloop.ProfilingBenchmarkMode), options);
            }
            else if (value.IsConcurrency)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Concurrency, typeof(global::Dataloop.ConcurrencyBenchmarkMode), options);
            }
        }
    }
}