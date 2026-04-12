#nullable enable

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public sealed class ICompositionDatasetStateDatasetIndexDriverNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.ICompositionDatasetStateDatasetIndexDriver?>
    {
        /// <inheritdoc />
        public override global::Dataloop.ICompositionDatasetStateDatasetIndexDriver? Read(
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
                        return global::Dataloop.ICompositionDatasetStateDatasetIndexDriverExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dataloop.ICompositionDatasetStateDatasetIndexDriver)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dataloop.ICompositionDatasetStateDatasetIndexDriver?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.ICompositionDatasetStateDatasetIndexDriver? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Dataloop.ICompositionDatasetStateDatasetIndexDriverExtensions.ToValueString(value.Value));
            }
        }
    }
}
