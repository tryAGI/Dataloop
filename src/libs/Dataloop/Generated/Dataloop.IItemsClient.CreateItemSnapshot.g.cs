#nullable enable

namespace Dataloop
{
    public partial interface IItemsClient
    {
        /// <summary>
        /// Create a new snapshot on an existing item<br/>
        /// Order is important - FILE MUST BE LAST FIELD OF THE FORM
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIDatasetFileItem> CreateItemSnapshotAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}