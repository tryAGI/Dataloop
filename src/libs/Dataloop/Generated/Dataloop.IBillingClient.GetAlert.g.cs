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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAlert> GetAlertAsync(
            string account,
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}