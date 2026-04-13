#nullable enable

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public sealed class EDpkScopeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.EDpkScope?>
    {
        /// <inheritdoc />
        public override global::Dataloop.EDpkScope? Read(
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
                        return global::Dataloop.EDpkScopeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dataloop.EDpkScope)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dataloop.EDpkScope?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.EDpkScope? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Dataloop.EDpkScopeExtensions.ToValueString(value.Value));
            }
        }
    }
}
