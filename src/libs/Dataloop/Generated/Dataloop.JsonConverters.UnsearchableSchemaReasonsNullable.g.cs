#nullable enable

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public sealed class UnsearchableSchemaReasonsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.UnsearchableSchemaReasons?>
    {
        /// <inheritdoc />
        public override global::Dataloop.UnsearchableSchemaReasons? Read(
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
                        return global::Dataloop.UnsearchableSchemaReasonsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dataloop.UnsearchableSchemaReasons)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dataloop.UnsearchableSchemaReasons?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.UnsearchableSchemaReasons? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Dataloop.UnsearchableSchemaReasonsExtensions.ToValueString(value.Value));
            }
        }
    }
}
