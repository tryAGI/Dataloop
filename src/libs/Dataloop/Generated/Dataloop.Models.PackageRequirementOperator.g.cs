
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackageRequirementOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PackageRequirementOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackageRequirementOperator value)
        {
            return value switch
            {
                PackageRequirementOperator.Lt => "<",
                PackageRequirementOperator.Lte => "<=",
                PackageRequirementOperator.Eq => "==",
                PackageRequirementOperator.Gt => ">",
                PackageRequirementOperator.Gte => ">=",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackageRequirementOperator? ToEnum(string value)
        {
            return value switch
            {
                "<" => PackageRequirementOperator.Lt,
                "<=" => PackageRequirementOperator.Lte,
                "==" => PackageRequirementOperator.Eq,
                ">" => PackageRequirementOperator.Gt,
                ">=" => PackageRequirementOperator.Gte,
                _ => null,
            };
        }
    }
}