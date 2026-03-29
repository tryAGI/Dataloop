
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueryTestCases
    {
        /// <summary>
        /// 
        /// </summary>
        FiveTermsJoinOneTerm,
        /// <summary>
        /// 
        /// </summary>
        FiveTermsJoinThreeTerms,
        /// <summary>
        /// 
        /// </summary>
        FiveTermsJoinTwoTerms,
        /// <summary>
        /// 
        /// </summary>
        BaseLine,
        /// <summary>
        /// 
        /// </summary>
        FiveTermSortingOneIndexedField,
        /// <summary>
        /// 
        /// </summary>
        FiveTerms,
        /// <summary>
        /// 
        /// </summary>
        OneTerm,
        /// <summary>
        /// 
        /// </summary>
        OneTermSortingOneCustomField,
        /// <summary>
        /// 
        /// </summary>
        OneTermSortingOneIndexedField,
        /// <summary>
        /// 
        /// </summary>
        OneTermSortingThreeCustomFields,
        /// <summary>
        /// 
        /// </summary>
        OneTermSortingTwoCustomFields,
        /// <summary>
        /// 
        /// </summary>
        TenTerms,
        /// <summary>
        /// 
        /// </summary>
        TwentyTerms,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryTestCasesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryTestCases value)
        {
            return value switch
            {
                QueryTestCases.FiveTermsJoinOneTerm => "FiveTermsJoinOneTerm",
                QueryTestCases.FiveTermsJoinThreeTerms => "FiveTermsJoinThreeTerms",
                QueryTestCases.FiveTermsJoinTwoTerms => "FiveTermsJoinTwoTerms",
                QueryTestCases.BaseLine => "baseLine",
                QueryTestCases.FiveTermSortingOneIndexedField => "fiveTermSortingOneIndexedField",
                QueryTestCases.FiveTerms => "fiveTerms",
                QueryTestCases.OneTerm => "oneTerm",
                QueryTestCases.OneTermSortingOneCustomField => "oneTermSortingOneCustomField",
                QueryTestCases.OneTermSortingOneIndexedField => "oneTermSortingOneIndexedField",
                QueryTestCases.OneTermSortingThreeCustomFields => "oneTermSortingThreeCustomFields",
                QueryTestCases.OneTermSortingTwoCustomFields => "oneTermSortingTwoCustomFields",
                QueryTestCases.TenTerms => "tenTerms",
                QueryTestCases.TwentyTerms => "twentyTerms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryTestCases? ToEnum(string value)
        {
            return value switch
            {
                "FiveTermsJoinOneTerm" => QueryTestCases.FiveTermsJoinOneTerm,
                "FiveTermsJoinThreeTerms" => QueryTestCases.FiveTermsJoinThreeTerms,
                "FiveTermsJoinTwoTerms" => QueryTestCases.FiveTermsJoinTwoTerms,
                "baseLine" => QueryTestCases.BaseLine,
                "fiveTermSortingOneIndexedField" => QueryTestCases.FiveTermSortingOneIndexedField,
                "fiveTerms" => QueryTestCases.FiveTerms,
                "oneTerm" => QueryTestCases.OneTerm,
                "oneTermSortingOneCustomField" => QueryTestCases.OneTermSortingOneCustomField,
                "oneTermSortingOneIndexedField" => QueryTestCases.OneTermSortingOneIndexedField,
                "oneTermSortingThreeCustomFields" => QueryTestCases.OneTermSortingThreeCustomFields,
                "oneTermSortingTwoCustomFields" => QueryTestCases.OneTermSortingTwoCustomFields,
                "tenTerms" => QueryTestCases.TenTerms,
                "twentyTerms" => QueryTestCases.TwentyTerms,
                _ => null,
            };
        }
    }
}