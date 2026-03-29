
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum SchemaMode
    {
        /// <summary>
        /// 
        /// </summary>
        Inference,
        /// <summary>
        /// 
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SchemaModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemaMode value)
        {
            return value switch
            {
                SchemaMode.Inference => "inference",
                SchemaMode.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SchemaMode? ToEnum(string value)
        {
            return value switch
            {
                "inference" => SchemaMode.Inference,
                "manual" => SchemaMode.Manual,
                _ => null,
            };
        }
    }
}