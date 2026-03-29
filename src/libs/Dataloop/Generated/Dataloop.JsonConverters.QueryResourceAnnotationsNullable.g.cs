#nullable enable

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public sealed class QueryResourceAnnotationsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.QueryResourceAnnotations?>
    {
        /// <inheritdoc />
        public override global::Dataloop.QueryResourceAnnotations? Read(
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
                        return global::Dataloop.QueryResourceAnnotationsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dataloop.QueryResourceAnnotations)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dataloop.QueryResourceAnnotations?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.QueryResourceAnnotations? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Dataloop.QueryResourceAnnotationsExtensions.ToValueString(value.Value));
            }
        }
    }
}
