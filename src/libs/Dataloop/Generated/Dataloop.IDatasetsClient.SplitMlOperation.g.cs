#nullable enable

namespace Dataloop
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Split dataset items into ML subsets.<br/>
        /// # <br/>
        /// # :param str dataset_id: The ID of the dataset.<br/>
        /// # :param dict items_query: Query to select items.<br/>
        /// # :param dict ml_split_list: Dictionary with 'train', 'validation', 'test' keys and integer percentages.<br/>
        /// # :return: True if the split operation was successful.<br/>
        /// # :rtype: bool<br/>
        /// # :raises: PlatformException on failure and ValueError if percentages do not sum to 100 or invalid keys/values.<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> SplitMlOperationAsync(
            string id,

            global::Dataloop.SplitMlOperationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mLSplitList">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="itemsQuery"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APICommand> SplitMlOperationAsync(
            string id,
            global::Dataloop.RecordMLSplitListKeysNumber mLSplitList,
            global::Dataloop.DQLResourceQuery itemsQuery,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}