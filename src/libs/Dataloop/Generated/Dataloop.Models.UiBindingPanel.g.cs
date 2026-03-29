
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum UiBindingPanel
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Browser,
        /// <summary>
        /// 
        /// </summary>
        Studio,
        /// <summary>
        /// 
        /// </summary>
        Table,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UiBindingPanelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UiBindingPanel value)
        {
            return value switch
            {
                UiBindingPanel.All => "all",
                UiBindingPanel.Browser => "browser",
                UiBindingPanel.Studio => "studio",
                UiBindingPanel.Table => "table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UiBindingPanel? ToEnum(string value)
        {
            return value switch
            {
                "all" => UiBindingPanel.All,
                "browser" => UiBindingPanel.Browser,
                "studio" => UiBindingPanel.Studio,
                "table" => UiBindingPanel.Table,
                _ => null,
            };
        }
    }
}