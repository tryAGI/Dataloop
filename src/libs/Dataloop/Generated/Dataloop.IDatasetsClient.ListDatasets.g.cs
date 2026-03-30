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