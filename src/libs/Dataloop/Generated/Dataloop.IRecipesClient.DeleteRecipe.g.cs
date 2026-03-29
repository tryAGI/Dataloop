#nullable enable

namespace Dataloop
{
    public partial interface IRecipesClient
    {
        /// <summary>
        /// Delete a recipe
        /// </summary>
        /// <param name="id"></param>
        /// <param name="force"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// dataset.recipes.delete(recipe_id='recipe_id')<br/>
        /// # <br/>
        /// # Delete recipe from platform.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be in the role of an *owner* or *developer*.<br/>
        /// # <br/>
        /// # :param str recipe_id: recipe id<br/>
        /// # :param bool force: force delete recipe<br/>
        /// # :return: True if success<br/>
        /// # :rtype: bool<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task DeleteRecipeAsync(
            string id,
            bool? force = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}