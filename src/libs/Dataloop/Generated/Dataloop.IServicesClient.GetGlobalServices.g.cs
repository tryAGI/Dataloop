#nullable enable

namespace Dataloop
{
    public partial interface IServicesClient
    {
        /// <summary>
        /// Get all global services<br/>
        /// by using list of projectId and service name<br/>
        /// Example: [{ projectId: 'my-project-id', name: 'my-service-name' },<br/>
        ///               { projectId: 'my-project-id2', name: 'my-service-name2' }, ... ]<br/>
        ///  the server will search in the db for the service with the name my-service-name belonging to the project 'my-project-id<br/>
        ///  also the service with the name my-service-name2 belonging to the project 'my-project-id2<br/>
        ///  and so on...
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.GetGlobalServicesResponseItem>> GetGlobalServicesAsync(

            global::System.Collections.Generic.IList<global::Dataloop.GetGlobalServicesRequestItem> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}