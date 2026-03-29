#nullable enable

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public sealed class DriverReadBenchmarkOperationInputScenarioDetailsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.DriverReadBenchmarkOperationInputScenarioDetails>
    {
        /// <inheritdoc />
        public override global::Dataloop.DriverReadBenchmarkOperationInputScenarioDetails Read(
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
                        return global::Dataloop.DriverReadBenchmarkOperationInputScenarioDetailsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dataloop.DriverReadBenchmarkOperationInputScenarioDetails)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dataloop.DriverReadBenchmarkOperationInputScenarioDetails);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.DriverReadBenchmarkOperationInputScenarioDetails value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Dataloop.DriverReadBenchmarkOperationInputScenarioDetailsExtensions.ToValueString(value));
        }
    }
}
