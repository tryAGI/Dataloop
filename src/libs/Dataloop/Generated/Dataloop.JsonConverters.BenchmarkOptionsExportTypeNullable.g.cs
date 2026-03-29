#nullable enable

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public sealed class BenchmarkOptionsExportTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.BenchmarkOptionsExportType?>
    {
        /// <inheritdoc />
        public override global::Dataloop.BenchmarkOptionsExportType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Dataloop.BenchmarkOptionsExportTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dataloop.BenchmarkOptionsExportType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dataloop.BenchmarkOptionsExportType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.BenchmarkOptionsExportType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Dataloop.BenchmarkOptionsExportTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
