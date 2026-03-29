#nullable enable

namespace Dataloop
{
    public partial interface IOntologiesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAttributeSection> CreateAttributeSectionAsync(
            string id,

            global::Dataloop.CreateAttributePayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <param name="scope"></param>
        /// <param name="values"></param>
        /// <param name="range"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAttributeSection> CreateAttributeSectionAsync(
            string id,
            string key,
            string type,
            global::Dataloop.CreateAttributePayloadScope? scope = default,
            global::System.Collections.Generic.IList<string>? values = default,
            object? range = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}