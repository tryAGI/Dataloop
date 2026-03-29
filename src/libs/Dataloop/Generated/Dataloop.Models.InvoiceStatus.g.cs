
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public enum InvoiceStatus
    {
        /// <summary>
        /// 
        /// </summary>
        FailedPayment,
        /// <summary>
        /// 
        /// </summary>
        Debt,
        /// <summary>
        /// 
        /// </summary>
        Paid,
        /// <summary>
        /// 
        /// </summary>
        PartiallyPaid,
        /// <summary>
        /// 
        /// </summary>
        Refunded,
        /// <summary>
        /// 
        /// </summary>
        Submitted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InvoiceStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InvoiceStatus value)
        {
            return value switch
            {
                InvoiceStatus.FailedPayment => "Failed Payment",
                InvoiceStatus.Debt => "debt",
                InvoiceStatus.Paid => "paid",
                InvoiceStatus.PartiallyPaid => "partiallyPaid",
                InvoiceStatus.Refunded => "refunded",
                InvoiceStatus.Submitted => "submitted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InvoiceStatus? ToEnum(string value)
        {
            return value switch
            {
                "Failed Payment" => InvoiceStatus.FailedPayment,
                "debt" => InvoiceStatus.Debt,
                "paid" => InvoiceStatus.Paid,
                "partiallyPaid" => InvoiceStatus.PartiallyPaid,
                "refunded" => InvoiceStatus.Refunded,
                "submitted" => InvoiceStatus.Submitted,
                _ => null,
            };
        }
    }
}