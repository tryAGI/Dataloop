#nullable enable

namespace Dataloop
{
    public partial interface IPlansClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.Plan>> ListAllPlansAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}