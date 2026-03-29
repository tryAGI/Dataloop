#nullable enable

namespace Dataloop
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Download a zip archive containing all annotations in the specified dataset<br/>
        /// Directory structure is preserved in the zip archive<br/>
        /// Each item will be represented by a json file containing it's annotations
        /// </summary>
        /// <param name="id"></param>
        /// <param name="directory"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task GetDatasetAnnotationsZipAsync(
            string id,
            string? directory = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}