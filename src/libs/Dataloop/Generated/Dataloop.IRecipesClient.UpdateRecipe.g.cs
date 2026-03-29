#nullable enable

namespace Dataloop
{
    public partial interface IRecipesClient
    {
        /// <summary>
        /// Update an existing recipe
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// dataset.recipes.update(recipe='recipe_entity')<br/>
        /// # <br/>
        /// # Update recipe.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.recipe.Recipe recipe: Recipe object<br/>
        /// # :param bool system_metadata: True, if you want to change metadata system<br/>
        /// # :return: Recipe object<br/>
        /// # :rtype: dtlpy.entities.recipe.Recipe<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>> UpdateRecipeAsync(
            string id,

            global::Dataloop.AnyOf<global::Dataloop.PartialRecipePayloadV2, global::Dataloop.PartialRecipePayload> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an existing recipe
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIRecipeV2, global::Dataloop.APIRecipe>> UpdateRecipeAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}