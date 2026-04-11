
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum DpkDatasetOntologyType
    {
        /// <summary>
        /// 
        /// </summary>
        Import,
        /// <summary>
        /// 
        /// </summary>
        Installed,
        /// <summary>
        /// 
        /// </summary>
        Platform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DpkDatasetOntologyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DpkDatasetOntologyType value)
        {
            return value switch
            {
                DpkDatasetOntologyType.Import => "import",
                DpkDatasetOntologyType.Installed => "installed",
                DpkDatasetOntologyType.Platform => "platform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DpkDatasetOntologyType? ToEnum(string value)
        {
            return value switch
            {
                "import" => DpkDatasetOntologyType.Import,
                "installed" => DpkDatasetOntologyType.Installed,
                "platform" => DpkDatasetOntologyType.Platform,
                _ => null,
            };
        }
    }
}