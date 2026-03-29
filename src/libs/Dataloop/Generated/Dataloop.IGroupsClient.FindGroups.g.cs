#nullable enable

namespace Dataloop
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Get all groups a user is a member of
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIGroup>> FindGroupsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}