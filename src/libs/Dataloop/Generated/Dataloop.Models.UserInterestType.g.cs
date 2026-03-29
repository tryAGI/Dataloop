
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserInterestType
    {
        /// <summary>
        /// 
        /// </summary>
        AILeadership,
        /// <summary>
        /// 
        /// </summary>
        Annotation,
        /// <summary>
        /// 
        /// </summary>
        AnnotationManager,
        /// <summary>
        /// 
        /// </summary>
        DataEngineer,
        /// <summary>
        /// 
        /// </summary>
        DataManagement,
        /// <summary>
        /// 
        /// </summary>
        DataScience,
        /// <summary>
        /// 
        /// </summary>
        MlDeveloper,
        /// <summary>
        /// 
        /// </summary>
        Pipelines,
        /// <summary>
        /// 
        /// </summary>
        SoftwareDeveloper,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserInterestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserInterestType value)
        {
            return value switch
            {
                UserInterestType.AILeadership => "AILeadership",
                UserInterestType.Annotation => "annotation",
                UserInterestType.AnnotationManager => "annotationManager",
                UserInterestType.DataEngineer => "dataEngineer",
                UserInterestType.DataManagement => "dataManagement",
                UserInterestType.DataScience => "dataScience",
                UserInterestType.MlDeveloper => "mlDeveloper",
                UserInterestType.Pipelines => "pipelines",
                UserInterestType.SoftwareDeveloper => "softwareDeveloper",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserInterestType? ToEnum(string value)
        {
            return value switch
            {
                "AILeadership" => UserInterestType.AILeadership,
                "annotation" => UserInterestType.Annotation,
                "annotationManager" => UserInterestType.AnnotationManager,
                "dataEngineer" => UserInterestType.DataEngineer,
                "dataManagement" => UserInterestType.DataManagement,
                "dataScience" => UserInterestType.DataScience,
                "mlDeveloper" => UserInterestType.MlDeveloper,
                "pipelines" => UserInterestType.Pipelines,
                "softwareDeveloper" => UserInterestType.SoftwareDeveloper,
                _ => null,
            };
        }
    }
}