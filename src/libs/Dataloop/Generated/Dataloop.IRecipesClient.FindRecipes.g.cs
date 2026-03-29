#nullable enable

namespace Dataloop
{
    public partial interface IRecipesClient
    {
        /// <summary>
        /// Find recipes by query
        /// </summary>
        /// <param name="projects"></param>
        /// <param name="creator"></param>
        /// <param name="title"></param>
        /// <param name="ontologies"></param>
        /// <param name="pageOffset"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.CursorPageAPIRecipeV2OrAPIRecipe> FindRecipesAsync(
            global::System.Collections.Generic.IList<string>? projects = default,
            string? creator = default,
            string? title = default,
            global::System.Collections.Generic.IList<string>? ontologies = default,
            double? pageOffset = default,
            double? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}