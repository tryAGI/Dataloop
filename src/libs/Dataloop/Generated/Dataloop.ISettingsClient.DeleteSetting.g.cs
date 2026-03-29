#nullable enable

namespace Dataloop
{
    public partial interface ISettingsClient
    {
        /// <summary>
        /// Delete a setting<br/>
        /// Supply the unique id of the setting to delete
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteSettingAsync(
            string id,

            global::Dataloop.DeleteSettingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a setting<br/>
        /// Supply the unique id of the setting to delete
        /// </summary>
        /// <param name="id"></param>
        /// <param name="force"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteSettingAsync(
            string id,
            bool? force = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}