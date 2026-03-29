#nullable enable

namespace Dataloop
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Get pipeline by id.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// pipeline = project.pipelines.get(pipeline_id='pipeline_id')<br/>
        /// # <br/>
        /// # Get Pipeline object to use in your code.<br/>
        /// # <br/>
        /// # **prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # You must provide at least ONE of the following params: pipeline_name, pipeline_id.<br/>
        /// # <br/>
        /// # :param str pipeline_id: pipeline id<br/>
        /// # :param str pipeline_name: pipeline name<br/>
        /// # :param fetch: optional - fetch entity from platform, default taken from cookie<br/>
        /// # :return: Pipeline object<br/>
        /// # :rtype: dtlpy.entities.pipeline.Pipeline<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIPipeline> GetAsync(
            string pipelineId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}