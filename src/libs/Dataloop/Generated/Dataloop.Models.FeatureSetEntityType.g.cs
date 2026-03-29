
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeatureSetEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        Annotation,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Item,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeatureSetEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeatureSetEntityType value)
        {
            return value switch
            {
                FeatureSetEntityType.Annotation => "annotation",
                FeatureSetEntityType.Dataset => "dataset",
                FeatureSetEntityType.Item => "item",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeatureSetEntityType? ToEnum(string value)
        {
            return value switch
            {
                "annotation" => FeatureSetEntityType.Annotation,
                "dataset" => FeatureSetEntityType.Dataset,
                "item" => FeatureSetEntityType.Item,
                _ => null,
            };
        }
    }
}