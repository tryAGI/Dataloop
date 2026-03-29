
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum GeneratedDatasetTypes
    {
        /// <summary>
        /// 
        /// </summary>
        x100kBench,
        /// <summary>
        /// 
        /// </summary>
        M1,
        /// <summary>
        /// 
        /// </summary>
        M10,
        /// <summary>
        /// 
        /// </summary>
        M1NoComp,
        /// <summary>
        /// 
        /// </summary>
        M2,
        /// <summary>
        /// 
        /// </summary>
        M25,
        /// <summary>
        /// 
        /// </summary>
        M25ProductionDist,
        /// <summary>
        /// 
        /// </summary>
        M4,
        /// <summary>
        /// 
        /// </summary>
        M5ProductionDist,
        /// <summary>
        /// 
        /// </summary>
        M6,
        /// <summary>
        /// 
        /// </summary>
        BigJSON1,
        /// <summary>
        /// 
        /// </summary>
        BigJSON2,
        /// <summary>
        /// 
        /// </summary>
        ManyKeys1,
        /// <summary>
        /// 
        /// </summary>
        ManyKeys2,
        /// <summary>
        /// 
        /// </summary>
        ManyKeys3,
        /// <summary>
        /// 
        /// </summary>
        Simple1,
        /// <summary>
        /// 
        /// </summary>
        Simple2,
        /// <summary>
        /// 
        /// </summary>
        Simple3,
        /// <summary>
        /// 
        /// </summary>
        Simple4,
        /// <summary>
        /// 
        /// </summary>
        Simple5,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeneratedDatasetTypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratedDatasetTypes value)
        {
            return value switch
            {
                GeneratedDatasetTypes.x100kBench => "100K-bench",
                GeneratedDatasetTypes.M1 => "M_1",
                GeneratedDatasetTypes.M10 => "M_10",
                GeneratedDatasetTypes.M1NoComp => "M_1_NO_COMP",
                GeneratedDatasetTypes.M2 => "M_2",
                GeneratedDatasetTypes.M25 => "M_25",
                GeneratedDatasetTypes.M25ProductionDist => "M_25_PRODUCTION_DIST",
                GeneratedDatasetTypes.M4 => "M_4",
                GeneratedDatasetTypes.M5ProductionDist => "M_5_PRODUCTION_DIST",
                GeneratedDatasetTypes.M6 => "M_6",
                GeneratedDatasetTypes.BigJSON1 => "bigJSON1",
                GeneratedDatasetTypes.BigJSON2 => "bigJSON2",
                GeneratedDatasetTypes.ManyKeys1 => "manyKeys1",
                GeneratedDatasetTypes.ManyKeys2 => "manyKeys2",
                GeneratedDatasetTypes.ManyKeys3 => "manyKeys3",
                GeneratedDatasetTypes.Simple1 => "simple1",
                GeneratedDatasetTypes.Simple2 => "simple2",
                GeneratedDatasetTypes.Simple3 => "simple3",
                GeneratedDatasetTypes.Simple4 => "simple4",
                GeneratedDatasetTypes.Simple5 => "simple5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratedDatasetTypes? ToEnum(string value)
        {
            return value switch
            {
                "100K-bench" => GeneratedDatasetTypes.x100kBench,
                "M_1" => GeneratedDatasetTypes.M1,
                "M_10" => GeneratedDatasetTypes.M10,
                "M_1_NO_COMP" => GeneratedDatasetTypes.M1NoComp,
                "M_2" => GeneratedDatasetTypes.M2,
                "M_25" => GeneratedDatasetTypes.M25,
                "M_25_PRODUCTION_DIST" => GeneratedDatasetTypes.M25ProductionDist,
                "M_4" => GeneratedDatasetTypes.M4,
                "M_5_PRODUCTION_DIST" => GeneratedDatasetTypes.M5ProductionDist,
                "M_6" => GeneratedDatasetTypes.M6,
                "bigJSON1" => GeneratedDatasetTypes.BigJSON1,
                "bigJSON2" => GeneratedDatasetTypes.BigJSON2,
                "manyKeys1" => GeneratedDatasetTypes.ManyKeys1,
                "manyKeys2" => GeneratedDatasetTypes.ManyKeys2,
                "manyKeys3" => GeneratedDatasetTypes.ManyKeys3,
                "simple1" => GeneratedDatasetTypes.Simple1,
                "simple2" => GeneratedDatasetTypes.Simple2,
                "simple3" => GeneratedDatasetTypes.Simple3,
                "simple4" => GeneratedDatasetTypes.Simple4,
                "simple5" => GeneratedDatasetTypes.Simple5,
                _ => null,
            };
        }
    }
}