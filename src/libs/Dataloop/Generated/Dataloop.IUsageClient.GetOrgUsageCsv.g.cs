#nullable enable

namespace Dataloop
{
    public partial interface IUsageClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task GetOrgUsageCsvAsync(
            string id,
            string startDate,
            string endDate,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}