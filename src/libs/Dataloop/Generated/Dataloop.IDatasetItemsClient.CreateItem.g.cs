#nullable enable

namespace Dataloop
{
    public partial interface IDatasetItemsClient
    {
        /// <summary>
        /// Create a new item in a dataset<br/>
        /// Order is important - FILE MUST BE LAST FIELD OF THE FORM
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="mode"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIDatasetFileItem, global::Dataloop.APIDatasetDirectoryItem>> CreateItemAsync(
            string datasetId,
            global::Dataloop.AddItemMode? mode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}