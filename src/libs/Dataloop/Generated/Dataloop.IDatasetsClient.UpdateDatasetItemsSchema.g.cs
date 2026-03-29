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
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APICommand, string>> UpdateDatasetItemsSchemaAsync(
            string id,

            global::Dataloop.UpdateItemsSchemaInput request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="schemaKeys"></param>
        /// <param name="unsearchablePaths"></param>
        /// <param name="indexingOptions"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APICommand, string>> UpdateDatasetItemsSchemaAsync(
            string id,
            global::Dataloop.UpdateItemsSchemaInputSchemaKeys? schemaKeys = default,
            global::Dataloop.UpdateItemsSchemaInputUnsearchablePaths? unsearchablePaths = default,
            global::Dataloop.UpdateItemsSchemaInputIndexingOptions? indexingOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}