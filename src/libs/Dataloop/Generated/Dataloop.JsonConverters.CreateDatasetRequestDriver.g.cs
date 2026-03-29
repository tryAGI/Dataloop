#nullable enable

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateDatasetRequestDriverJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.CreateDatasetRequestDriver>
    {
        /// <inheritdoc />
        public override global::Dataloop.CreateDatasetRequestDriver Read(
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
                        return global::Dataloop.CreateDatasetRequestDriverExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dataloop.CreateDatasetRequestDriver)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dataloop.CreateDatasetRequestDriver);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.CreateDatasetRequestDriver value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Dataloop.CreateDatasetRequestDriverExtensions.ToValueString(value));
        }
    }
}
