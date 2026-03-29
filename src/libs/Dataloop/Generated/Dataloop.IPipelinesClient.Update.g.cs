#nullable enable

namespace Dataloop
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Update pipeline changes.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// pipeline = project.pipelines.update(pipeline='pipeline_entity')<br/>
        /// # <br/>
        /// # Update pipeline changes to platform.<br/>
        /// # <br/>
        /// # **prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.pipeline.Pipeline pipeline: pipeline entity<br/>
        /// # :return: Pipeline object<br/>
        /// # :rtype: dtlpy.entities.pipeline.Pipeline<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIPipeline> UpdateAsync(
            string pipelineId,

            global::Dataloop.IPostPipeline request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update pipeline changes.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="startNodes"></param>
        /// <param name="spec"></param>
        /// <param name="compositionId"></param>
        /// <param name="description"></param>
        /// <param name="preview"></param>
        /// <param name="nodes"></param>
        /// <param name="connections"></param>
        /// <param name="secrets">
        /// Array of integrations ids - each one will be added to the service deployment as an environment variable
        /// </param>
        /// <param name="variables"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIPipeline> UpdateAsync(
            string pipelineId,
            string name,
            string projectId,
            string description,
            string preview,
            global::System.Collections.Generic.IList<global::Dataloop.PipelineNodeDescriptor> nodes,
            global::System.Collections.Generic.IList<global::Dataloop.PipelineConnection> connections,
            global::System.Collections.Generic.IList<string> secrets,
            global::System.Collections.Generic.IList<global::Dataloop.IStartNode>? startNodes = default,
            object? spec = default,
            string? compositionId = default,
            global::System.Collections.Generic.IList<global::Dataloop.PipelineVariable>? variables = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}