#nullable enable

namespace Dataloop
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="account"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAlert> UpdateAlertAsync(
            string account,
            string id,

            global::Dataloop.UpdateAlertRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="account"></param>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAlert> UpdateAlertAsync(
            string account,
            string id,
            global::Dataloop.AlertStatus status,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}