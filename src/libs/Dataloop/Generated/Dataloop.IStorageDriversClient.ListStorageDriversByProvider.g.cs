#nullable enable

namespace Dataloop
{
    public partial interface IStorageDriversClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.RecordStringLabelStringdrivers3f3AAPIDriverConfigurationArraydriverId3f3Astring> ListStorageDriversByProviderAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}