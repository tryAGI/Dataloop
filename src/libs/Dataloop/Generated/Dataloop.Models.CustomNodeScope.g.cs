
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomNodeScope
    {
        /// <summary>
        /// 
        /// </summary>
        Global,
        /// <summary>
        /// 
        /// </summary>
        Node,
        /// <summary>
        /// 
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomNodeScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomNodeScope value)
        {
            return value switch
            {
                CustomNodeScope.Global => "global",
                CustomNodeScope.Node => "node",
                CustomNodeScope.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomNodeScope? ToEnum(string value)
        {
            return value switch
            {
                "global" => CustomNodeScope.Global,
                "node" => CustomNodeScope.Node,
                "project" => CustomNodeScope.Project,
                _ => null,
            };
        }
    }
}