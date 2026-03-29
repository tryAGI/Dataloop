#nullable enable

namespace Dataloop
{
    public partial interface ISettingsClient
    {
        /// <summary>
        /// Update a setting<br/>
        /// Supply the unique id of the setting to update and an object describing which fields update
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>> UpdateSettingAsync(
            string id,

            global::Dataloop.AnyOf<global::Dataloop.PatchFeatureFlagRequest, global::Dataloop.PatchUserSettingRequest> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a setting<br/>
        /// Supply the unique id of the setting to update and an object describing which fields update
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>> UpdateSettingAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}