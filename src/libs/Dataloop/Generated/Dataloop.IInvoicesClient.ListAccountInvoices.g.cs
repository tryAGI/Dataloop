#nullable enable

namespace Dataloop
{
    public partial interface IInvoicesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="account"></param>
        /// <param name="status"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.Invoice>> ListAccountInvoicesAsync(
            string account,
            string? status = default,
            string? fromDate = default,
            string? toDate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}