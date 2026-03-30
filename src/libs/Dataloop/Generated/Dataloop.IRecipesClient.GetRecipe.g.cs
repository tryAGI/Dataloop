#nullable enable

namespace Dataloop
{
    public partial interface IRecipesClient
    {
        /// <summary>
        /// Get a specific recipe
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Get a Recipe object to use in your code.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # :param str recipe_id: recipe id<br/>
        /// # :return: Recipe object<br/>
        /// # :rtype: dtlpy.entities.recipe.Recipe<br/>
        /// # <br/>
        /// # <br/>
        /// # dataset.recipes.get(recipe_id='recipe_id')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>> GetRecipeAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}