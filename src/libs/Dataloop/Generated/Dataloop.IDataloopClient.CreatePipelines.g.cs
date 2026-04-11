#nullable enable

namespace Dataloop
{
    public partial interface IDataloopClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Create a new pipeline.<br/>
        /// # <br/>
        /// # **prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # :param str name: pipeline name<br/>
        /// # :param str project_id: project id<br/>
        /// # :param dict pipeline_json: json containing the pipeline fields<br/>
        /// # :return: Pipeline object<br/>
        /// # :rtype: dtlpy.entities.pipeline.Pipeline<br/>
        /// # <br/>
        /// # <br/>
        /// # pipeline = project.pipelines.create(name='pipeline_name')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task CreatePipelinesAsync(
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}