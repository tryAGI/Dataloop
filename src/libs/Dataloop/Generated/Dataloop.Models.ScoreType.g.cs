
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScoreType
    {
        /// <summary>
        /// 
        /// </summary>
        AnnotationAttribute,
        /// <summary>
        /// 
        /// </summary>
        AnnotationIou,
        /// <summary>
        /// 
        /// </summary>
        AnnotationLabel,
        /// <summary>
        /// 
        /// </summary>
        AnnotationOverall,
        /// <summary>
        /// 
        /// </summary>
        ItemOverall,
        /// <summary>
        /// 
        /// </summary>
        LabelConfusion,
        /// <summary>
        /// 
        /// </summary>
        UserConfusion,
        /// <summary>
        /// 
        /// </summary>
        UserOverall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreType value)
        {
            return value switch
            {
                ScoreType.AnnotationAttribute => "annotation_attribute",
                ScoreType.AnnotationIou => "annotation_iou",
                ScoreType.AnnotationLabel => "annotation_label",
                ScoreType.AnnotationOverall => "annotation_overall",
                ScoreType.ItemOverall => "item_overall",
                ScoreType.LabelConfusion => "label_confusion",
                ScoreType.UserConfusion => "user_confusion",
                ScoreType.UserOverall => "user_overall",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreType? ToEnum(string value)
        {
            return value switch
            {
                "annotation_attribute" => ScoreType.AnnotationAttribute,
                "annotation_iou" => ScoreType.AnnotationIou,
                "annotation_label" => ScoreType.AnnotationLabel,
                "annotation_overall" => ScoreType.AnnotationOverall,
                "item_overall" => ScoreType.ItemOverall,
                "label_confusion" => ScoreType.LabelConfusion,
                "user_confusion" => ScoreType.UserConfusion,
                "user_overall" => ScoreType.UserOverall,
                _ => null,
            };
        }
    }
}