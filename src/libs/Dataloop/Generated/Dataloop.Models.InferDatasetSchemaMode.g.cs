
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum InferDatasetSchemaMode
    {
        /// <summary>
        /// 
        /// </summary>
        Report,
        /// <summary>
        /// 
        /// </summary>
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InferDatasetSchemaModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InferDatasetSchemaMode value)
        {
            return value switch
            {
                InferDatasetSchemaMode.Report => "report",
                InferDatasetSchemaMode.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InferDatasetSchemaMode? ToEnum(string value)
        {
            return value switch
            {
                "report" => InferDatasetSchemaMode.Report,
                "update" => InferDatasetSchemaMode.Update,
                _ => null,
            };
        }
    }
}