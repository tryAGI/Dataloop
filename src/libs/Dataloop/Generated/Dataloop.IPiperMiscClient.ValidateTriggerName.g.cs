#nullable enable

namespace Dataloop
{
    public partial interface IPiperMiscClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> ValidateTriggerNameAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}