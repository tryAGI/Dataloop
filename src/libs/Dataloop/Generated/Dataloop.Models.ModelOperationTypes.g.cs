
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelOperationTypes
    {
        /// <summary>
        /// 
        /// </summary>
        Deploy,
        /// <summary>
        /// 
        /// </summary>
        Embed,
        /// <summary>
        /// 
        /// </summary>
        Evaluate,
        /// <summary>
        /// 
        /// </summary>
        Predict,
        /// <summary>
        /// 
        /// </summary>
        Train,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelOperationTypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelOperationTypes value)
        {
            return value switch
            {
                ModelOperationTypes.Deploy => "deploy",
                ModelOperationTypes.Embed => "embed",
                ModelOperationTypes.Evaluate => "evaluate",
                ModelOperationTypes.Predict => "predict",
                ModelOperationTypes.Train => "train",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelOperationTypes? ToEnum(string value)
        {
            return value switch
            {
                "deploy" => ModelOperationTypes.Deploy,
                "embed" => ModelOperationTypes.Embed,
                "evaluate" => ModelOperationTypes.Evaluate,
                "predict" => ModelOperationTypes.Predict,
                "train" => ModelOperationTypes.Train,
                _ => null,
            };
        }
    }
}