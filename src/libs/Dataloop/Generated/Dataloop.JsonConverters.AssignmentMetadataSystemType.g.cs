#nullable enable

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public sealed class AssignmentMetadataSystemTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.AssignmentMetadataSystemType>
    {
        /// <inheritdoc />
        public override global::Dataloop.AssignmentMetadataSystemType Read(
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
                        return global::Dataloop.AssignmentMetadataSystemTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dataloop.AssignmentMetadataSystemType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dataloop.AssignmentMetadataSystemType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.AssignmentMetadataSystemType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Dataloop.AssignmentMetadataSystemTypeExtensions.ToValueString(value));
        }
    }
}
