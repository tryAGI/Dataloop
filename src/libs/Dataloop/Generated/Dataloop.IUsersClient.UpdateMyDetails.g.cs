#nullable enable

namespace Dataloop
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIUser> UpdateMyDetailsAsync(

            global::Dataloop.UpdateMyDetailsPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cookieApproval"></param>
        /// <param name="interest"></param>
        /// <param name="timezone"></param>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIUser> UpdateMyDetailsAsync(
            double? cookieApproval = default,
            global::Dataloop.UserInterestType? interest = default,
            string? timezone = default,
            string? lastName = default,
            string? firstName = default,
            string? org = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}