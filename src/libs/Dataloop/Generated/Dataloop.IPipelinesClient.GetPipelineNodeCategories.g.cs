#nullable enable

namespace Dataloop
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.PipelineNodeCategory> GetPipelineNodeCategoriesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}