#nullable enable

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public sealed class ECompositionPackageStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.ECompositionPackageStatus>
    {
        /// <inheritdoc />
        public override global::Dataloop.ECompositionPackageStatus Read(
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
                        return global::Dataloop.ECompositionPackageStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Dataloop.ECompositionPackageStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Dataloop.ECompositionPackageStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.ECompositionPackageStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Dataloop.ECompositionPackageStatusExtensions.ToValueString(value));
        }
    }
}
