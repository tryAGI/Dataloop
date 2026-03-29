#nullable enable

namespace Dataloop
{
    public partial interface ISettingsClient
    {
        /// <summary>
        /// Retrieves the details of a setting.<br/>
        /// Supply the unique setting ID to fetch it's details.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>> GetSettingAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}