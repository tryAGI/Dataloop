#nullable enable

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public sealed class ComputeMetadataVariant2ServeAgentGatewayNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.ComputeMetadataVariant2ServeAgentGateway?>
    {
        /// <inheritdoc />
        public override global::Dataloop.ComputeMetadataVariant2ServeAgentGateway? Read(
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
                        return global::Dataloop.ComputeMetadataVariant2ServeAgentGatewayExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dataloop.ComputeMetadataVariant2ServeAgentGateway)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dataloop.ComputeMetadataVariant2ServeAgentGateway?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.ComputeMetadataVariant2ServeAgentGateway? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Dataloop.ComputeMetadataVariant2ServeAgentGatewayExtensions.ToValueString(value.Value));
            }
        }
    }
}
