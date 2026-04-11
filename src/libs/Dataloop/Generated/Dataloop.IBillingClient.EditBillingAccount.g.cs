#nullable enable

namespace Dataloop
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.DBBillingAccount> EditBillingAccountAsync(
            string id,

            global::Dataloop.PartialBillingAccount request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="companyName"></param>
        /// <param name="companyPhone"></param>
        /// <param name="billingContact"></param>
        /// <param name="accountId"></param>
        /// <param name="recipients"></param>
        /// <param name="address"></param>
        /// <param name="taxData"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.DBBillingAccount> EditBillingAccountAsync(
            string id,
            string accountId,
            global::Dataloop.Address address,
            string? companyName = default,
            string? companyPhone = default,
            string? billingContact = default,
            global::System.Collections.Generic.IList<string>? recipients = default,
            global::Dataloop.PartialBillingAccountTaxData? taxData = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}