#nullable enable

namespace Dataloop
{
    public partial interface IServicesMetricClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.IServiceScaler> GetServiceScalerAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}