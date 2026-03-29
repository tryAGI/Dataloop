#nullable enable

namespace Dataloop
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Create a new pipeline from a template.<br/>
        /// The server will create a new pipeline from a template and return the pipeline object.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ResolveTemplateAsync(
            string id,

            global::Dataloop.ResolveTemplateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new pipeline from a template.<br/>
        /// The server will create a new pipeline from a template and return the pipeline object.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="extend"></param>
        /// <param name="template"></param>
        /// <param name="templateId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ResolveTemplateAsync(
            string id,
            bool? extend = default,
            global::Dataloop.IPipeline? template = default,
            string? templateId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}