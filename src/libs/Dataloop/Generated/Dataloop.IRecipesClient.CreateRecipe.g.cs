#nullable enable

namespace Dataloop
{
    public partial interface IRecipesClient
    {
        /// <summary>
        /// Create a new Recipe
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Create a new Recipe.<br/>
        /// # Note: If the param ontology_ids is None, an ontology will be created first.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # :param str project_ids: project ids<br/>
        /// # :param str or list ontology_ids: ontology ids<br/>
        /// # :param labels: labels<br/>
        /// # :param str recipe_name: recipe name<br/>
        /// # :param attributes: attributes<br/>
        /// # :param str annotation_instruction_file: file path or url of the recipe instruction<br/>
        /// # :return: Recipe entity<br/>
        /// # :rtype: dtlpy.entities.recipe.Recipe<br/>
        /// # <br/>
        /// # <br/>
        /// # dataset.recipes.create(recipe_name='My Recipe', labels=labels))<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>> CreateRecipeAsync(

            global::Dataloop.AnyOf<global::Dataloop.RecipeV2Input?, global::Dataloop.RecipeInput?> request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new Recipe
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>> CreateRecipeAsync(
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}