
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum EComponentElementType
    {
        /// <summary>
        /// 
        /// </summary>
        Channel,
        /// <summary>
        /// 
        /// </summary>
        ComputeConfig,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Module,
        /// <summary>
        /// 
        /// </summary>
        Panel,
        /// <summary>
        /// 
        /// </summary>
        PipelineNode,
        /// <summary>
        /// 
        /// </summary>
        PipelineTemplate,
        /// <summary>
        /// 
        /// </summary>
        Service,
        /// <summary>
        /// 
        /// </summary>
        Toolbar,
        /// <summary>
        /// 
        /// </summary>
        Trigger,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EComponentElementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EComponentElementType value)
        {
            return value switch
            {
                EComponentElementType.Channel => "channel",
                EComponentElementType.ComputeConfig => "computeConfig",
                EComponentElementType.Model => "model",
                EComponentElementType.Module => "module",
                EComponentElementType.Panel => "panel",
                EComponentElementType.PipelineNode => "pipelineNode",
                EComponentElementType.PipelineTemplate => "pipelineTemplate",
                EComponentElementType.Service => "service",
                EComponentElementType.Toolbar => "toolbar",
                EComponentElementType.Trigger => "trigger",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EComponentElementType? ToEnum(string value)
        {
            return value switch
            {
                "channel" => EComponentElementType.Channel,
                "computeConfig" => EComponentElementType.ComputeConfig,
                "model" => EComponentElementType.Model,
                "module" => EComponentElementType.Module,
                "panel" => EComponentElementType.Panel,
                "pipelineNode" => EComponentElementType.PipelineNode,
                "pipelineTemplate" => EComponentElementType.PipelineTemplate,
                "service" => EComponentElementType.Service,
                "toolbar" => EComponentElementType.Toolbar,
                "trigger" => EComponentElementType.Trigger,
                _ => null,
            };
        }
    }
}