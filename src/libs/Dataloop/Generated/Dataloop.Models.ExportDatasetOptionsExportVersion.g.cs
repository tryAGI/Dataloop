
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// `V2` - exported items will have original extension in filename, `V1` - no original extension in filenames
    /// </summary>
    public enum ExportDatasetOptionsExportVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
        /// <summary>
        /// 
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportDatasetOptionsExportVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportDatasetOptionsExportVersion value)
        {
            return value switch
            {
                ExportDatasetOptionsExportVersion.V1 => "V1",
                ExportDatasetOptionsExportVersion.V2 => "V2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportDatasetOptionsExportVersion? ToEnum(string value)
        {
            return value switch
            {
                "V1" => ExportDatasetOptionsExportVersion.V1,
                "V2" => ExportDatasetOptionsExportVersion.V2,
                _ => null,
            };
        }
    }
}