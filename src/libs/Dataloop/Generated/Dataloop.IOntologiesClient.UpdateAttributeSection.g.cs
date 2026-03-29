#nullable enable

namespace Dataloop
{
    public partial interface IOntologiesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="attributeId"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAttributeSection> UpdateAttributeSectionAsync(
            string attributeId,
            string id,

            global::Dataloop.APIUpdateAttributePayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="attributeId"></param>
        /// <param name="id"></param>
        /// <param name="key"></param>
        /// <param name="scope"></param>
        /// <param name="values"></param>
        /// <param name="range"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAttributeSection> UpdateAttributeSectionAsync(
            string attributeId,
            string id,
            string? key = default,
            global::Dataloop.APIUpdateAttributePayloadScope? scope = default,
            global::System.Collections.Generic.IList<string>? values = default,
            object? range = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}