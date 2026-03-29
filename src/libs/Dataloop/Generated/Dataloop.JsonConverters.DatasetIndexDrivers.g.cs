#nullable enable

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public sealed class DatasetIndexDriversJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.DatasetIndexDrivers>
    {
        /// <inheritdoc />
        public override global::Dataloop.DatasetIndexDrivers Read(
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
                        return global::Dataloop.DatasetIndexDriversExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dataloop.DatasetIndexDrivers)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dataloop.DatasetIndexDrivers);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.DatasetIndexDrivers value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Dataloop.DatasetIndexDriversExtensions.ToValueString(value));
        }
    }
}
