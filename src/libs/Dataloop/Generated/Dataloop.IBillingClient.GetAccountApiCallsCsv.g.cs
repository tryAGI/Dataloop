#nullable enable

namespace Dataloop
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="monthly"></param>
        /// <param name="skipSumming"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task GetAccountApiCallsCsvAsync(
            string id,
            string startDate,
            string endDate,
            string? monthly = default,
            string? skipSumming = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}