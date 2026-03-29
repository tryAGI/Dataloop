#nullable enable

namespace Dataloop
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get a names list of all existing datasets
        /// </summary>
        /// <param name="name"></param>
        /// <param name="creator"></param>
        /// <param name="recipe"></param>
        /// <param name="projects"></param>
        /// <param name="markForDeletion"></param>
        /// <param name="system">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// datasets = project.datasets.list(name='name')<br/>
        /// # <br/>
        /// # List all datasets.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be an *owner* or *developer* to use this method.<br/>
        /// # <br/>
        /// # :param str name: list by name<br/>
        /// # :param str creator: list by creator<br/>
        /// # :return: List of datasets<br/>
        /// # :rtype: list<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIDataset>> ListDatasetsAsync(
            string? name = default,
            string? creator = default,
            string? recipe = default,
            global::System.Collections.Generic.IList<string>? projects = default,
            bool? markForDeletion = default,
            bool? system = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}