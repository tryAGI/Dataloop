
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnnotationType
    {
        /// <summary>
        /// 
        /// </summary>
        Binary,
        /// <summary>
        /// 
        /// </summary>
        Box,
        /// <summary>
        /// 
        /// </summary>
        Class,
        /// <summary>
        /// 
        /// </summary>
        Comparison,
        /// <summary>
        /// 
        /// </summary>
        Cube,
        /// <summary>
        /// 
        /// </summary>
        Cube3d,
        /// <summary>
        /// 
        /// </summary>
        Ellipse,
        /// <summary>
        /// 
        /// </summary>
        Gis,
        /// <summary>
        /// 
        /// </summary>
        ItemDescription,
        /// <summary>
        /// 
        /// </summary>
        Line,
        /// <summary>
        /// 
        /// </summary>
        Note,
        /// <summary>
        /// 
        /// </summary>
        PdfText,
        /// <summary>
        /// 
        /// </summary>
        Point,
        /// <summary>
        /// 
        /// </summary>
        Polyline,
        /// <summary>
        /// 
        /// </summary>
        Polyline3d,
        /// <summary>
        /// 
        /// </summary>
        Pose,
        /// <summary>
        /// 
        /// </summary>
        Recording,
        /// <summary>
        /// 
        /// </summary>
        RefImage,
        /// <summary>
        /// 
        /// </summary>
        RefSemantic3d,
        /// <summary>
        /// 
        /// </summary>
        Segment,
        /// <summary>
        /// 
        /// </summary>
        Semantic3d,
        /// <summary>
        /// 
        /// </summary>
        Subtitle,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        TextMark,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationType value)
        {
            return value switch
            {
                AnnotationType.Binary => "binary",
                AnnotationType.Box => "box",
                AnnotationType.Class => "class",
                AnnotationType.Comparison => "comparison",
                AnnotationType.Cube => "cube",
                AnnotationType.Cube3d => "cube_3d",
                AnnotationType.Ellipse => "ellipse",
                AnnotationType.Gis => "gis",
                AnnotationType.ItemDescription => "item_description",
                AnnotationType.Line => "line",
                AnnotationType.Note => "note",
                AnnotationType.PdfText => "pdf_text",
                AnnotationType.Point => "point",
                AnnotationType.Polyline => "polyline",
                AnnotationType.Polyline3d => "polyline_3d",
                AnnotationType.Pose => "pose",
                AnnotationType.Recording => "recording",
                AnnotationType.RefImage => "ref_image",
                AnnotationType.RefSemantic3d => "ref_semantic_3d",
                AnnotationType.Segment => "segment",
                AnnotationType.Semantic3d => "semantic_3d",
                AnnotationType.Subtitle => "subtitle",
                AnnotationType.Text => "text",
                AnnotationType.TextMark => "text_mark",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationType? ToEnum(string value)
        {
            return value switch
            {
                "binary" => AnnotationType.Binary,
                "box" => AnnotationType.Box,
                "class" => AnnotationType.Class,
                "comparison" => AnnotationType.Comparison,
                "cube" => AnnotationType.Cube,
                "cube_3d" => AnnotationType.Cube3d,
                "ellipse" => AnnotationType.Ellipse,
                "gis" => AnnotationType.Gis,
                "item_description" => AnnotationType.ItemDescription,
                "line" => AnnotationType.Line,
                "note" => AnnotationType.Note,
                "pdf_text" => AnnotationType.PdfText,
                "point" => AnnotationType.Point,
                "polyline" => AnnotationType.Polyline,
                "polyline_3d" => AnnotationType.Polyline3d,
                "pose" => AnnotationType.Pose,
                "recording" => AnnotationType.Recording,
                "ref_image" => AnnotationType.RefImage,
                "ref_semantic_3d" => AnnotationType.RefSemantic3d,
                "segment" => AnnotationType.Segment,
                "semantic_3d" => AnnotationType.Semantic3d,
                "subtitle" => AnnotationType.Subtitle,
                "text" => AnnotationType.Text,
                "text_mark" => AnnotationType.TextMark,
                _ => null,
            };
        }
    }
}