#nullable enable

namespace Dataloop
{
    public partial interface IServicesClient
    {
        /// <summary>
        /// Update Replica Status.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// status_json = package.services.status(service_id='service_id')<br/>
        /// # <br/>
        /// # Get service status.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*. You must have a package.<br/>
        /// # <br/>
        /// # You must provide at least ONE of the following params: service_id, service_name<br/>
        /// # <br/>
        /// # :param str service_name: service name<br/>
        /// # :param str service_id: service id<br/>
        /// # :return: status json<br/>
        /// # :rtype: dict<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIReplicaStatusUpdate> UpdateReplicaStatusAsync(
            string id,

            global::Dataloop.APIReplicaStatusUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Replica Status.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="replicaId"></param>
        /// <param name="status"></param>
        /// <param name="numRestarts"></param>
        /// <param name="uptime"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIReplicaStatusUpdate> UpdateReplicaStatusAsync(
            string id,
            string replicaId,
            global::Dataloop.ReplicaStatus status,
            double numRestarts,
            double uptime,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}