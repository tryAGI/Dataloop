
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum Currency
    {
        /// <summary>
        /// 
        /// </summary>
        Eur,
        /// <summary>
        /// 
        /// </summary>
        Nis,
        /// <summary>
        /// 
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Currency value)
        {
            return value switch
            {
                Currency.Eur => "EUR",
                Currency.Nis => "NIS",
                Currency.Usd => "USD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Currency? ToEnum(string value)
        {
            return value switch
            {
                "EUR" => Currency.Eur,
                "NIS" => Currency.Nis,
                "USD" => Currency.Usd,
                _ => null,
            };
        }
    }
}