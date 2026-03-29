#nullable enable

namespace Dataloop
{
    public partial interface ISettingsClient
    {
        /// <summary>
        /// Creates a new Setting.<br/>
        /// Supply the appropriate Create Request object for either Feature flag or User setting.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>> CreateSettingAsync(

            global::Dataloop.CreateSettingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new Setting.<br/>
        /// Supply the appropriate Create Request object for either Feature flag or User setting.
        /// </summary>
        /// <param name="defaultValue">
        /// the value that will be taken if no value was passed
        /// </param>
        /// <param name="name">
        /// the name of the setting
        /// </param>
        /// <param name="value">
        /// the value of the setting
        /// </param>
        /// <param name="valueType"></param>
        /// <param name="scope"></param>
        /// <param name="metadata"></param>
        /// <param name="settingType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIFeatureFlag, global::Dataloop.APIUserSetting>> CreateSettingAsync(
            string name,
            global::Dataloop.SettingsValueTypes valueType,
            global::Dataloop.SettingScope scope,
            global::Dataloop.SettingsTypes settingType,
            object? defaultValue = default,
            object? value = default,
            global::Dataloop.Dictionary? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}