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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.OneByOneLatencyBenchmarkMode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.OneByOneLatencyBenchmarkMode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.OneByOneLatencyBenchmarkMode).Name}");
                        oneByLatency = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.ProfilingBenchmarkMode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.ProfilingBenchmarkMode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.ProfilingBenchmarkMode).Name}");
                        profiling = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.ConcurrencyBenchmarkMode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.ConcurrencyBenchmarkMode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.ConcurrencyBenchmarkMode).Name}");
                        concurrency = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.OneByOneLatencyBenchmarkMode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.OneByOneLatencyBenchmarkMode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.OneByOneLatencyBenchmarkMode).Name}");
                    oneByLatency = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.ProfilingBenchmarkMode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.ProfilingBenchmarkMode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.ProfilingBenchmarkMode).Name}");
                    profiling = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.ConcurrencyBenchmarkMode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.ConcurrencyBenchmarkMode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.ConcurrencyBenchmarkMode).Name}");
                    concurrency = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOneByLatency)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.OneByOneLatencyBenchmarkMode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.OneByOneLatencyBenchmarkMode?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.OneByOneLatencyBenchmarkMode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OneByLatency!, typeInfo);
            }
            else if (value.IsProfiling)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.ProfilingBenchmarkMode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.ProfilingBenchmarkMode?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.ProfilingBenchmarkMode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Profiling!, typeInfo);
            }
            else if (value.IsConcurrency)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.ConcurrencyBenchmarkMode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.ConcurrencyBenchmarkMode?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.ConcurrencyBenchmarkMode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Concurrency!, typeInfo);
            }
        }
    }
}