#nullable enable

namespace Dataloop
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.DBBillingAccount> CreateBillingAccountAsync(

            global::Dataloop.PartialBillingAccount request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="companyName"></param>
        /// <param name="companyPhone"></param>
        /// <param name="billingContact"></param>
        /// <param name="accountId"></param>
        /// <param name="recipients"></param>
        /// <param name="address"></param>
        /// <param name="taxData"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.DBBillingAccount> CreateBillingAccountAsync(
            string accountId,
            global::Dataloop.Address address,
            string? companyName = default,
            string? companyPhone = default,
            string? billingContact = default,
            global::System.Collections.Generic.IList<string>? recipients = default,
            global::Dataloop.PartialBillingAccountTaxData? taxData = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}