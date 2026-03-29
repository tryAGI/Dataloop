#nullable enable

namespace Dataloop
{
    public partial interface IPlansClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIBillableResource>> QueryBillingMetricsAsync(

            global::Dataloop.QueryBillingMetricsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="keys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIBillableResource>> QueryBillingMetricsAsync(
            global::System.Collections.Generic.IList<string> keys,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}