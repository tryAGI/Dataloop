#nullable enable

namespace Dataloop
{
    public partial interface IDataloopClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Validate a pipeline configuration.<br/>
        /// # <br/>
        /// # **prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # :param dict pipeline_json: pipeline configuration as JSON dictionary<br/>
        /// # :return: Validation result<br/>
        /// # :rtype: dict<br/>
        /// # <br/>
        /// # <br/>
        /// # validation_result = project.pipelines.validate(pipeline_json={'name': 'my_pipeline', 'nodes': []})<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task CreatePipelinesValidateAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}