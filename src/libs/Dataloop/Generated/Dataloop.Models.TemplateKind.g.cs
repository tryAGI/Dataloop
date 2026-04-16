
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum TemplateKind
    {
        /// <summary>
        /// 
        /// </summary>
        Global,
        /// <summary>
        /// 
        /// </summary>
        Org,
        /// <summary>
        /// 
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplateKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateKind value)
        {
            return value switch
            {
                TemplateKind.Global => "global",
                TemplateKind.Org => "org",
                TemplateKind.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateKind? ToEnum(string value)
        {
            return value switch
            {
                "global" => TemplateKind.Global,
                "org" => TemplateKind.Org,
                "project" => TemplateKind.Project,
                _ => null,
            };
        }
    }
}