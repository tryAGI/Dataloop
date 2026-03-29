#nullable enable

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public sealed class SetTaskRefsBenchmarkInputOperationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.SetTaskRefsBenchmarkInputOperation>
    {
        /// <inheritdoc />
        public override global::Dataloop.SetTaskRefsBenchmarkInputOperation Read(
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
                        return global::Dataloop.SetTaskRefsBenchmarkInputOperationExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dataloop.SetTaskRefsBenchmarkInputOperation)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dataloop.SetTaskRefsBenchmarkInputOperation);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.SetTaskRefsBenchmarkInputOperation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Dataloop.SetTaskRefsBenchmarkInputOperationExtensions.ToValueString(value));
        }
    }
}
