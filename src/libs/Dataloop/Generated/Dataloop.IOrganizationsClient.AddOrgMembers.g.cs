#nullable enable

namespace Dataloop
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Add a new member to an organization
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Add members to your organization. Read about members and groups `here &lt;https://dataloop.ai/docs/org-members-groups&gt;`_.<br/>
        /// # <br/>
        /// # **Prerequisities**: To add members to an organization, you must be an *owner* in that organization.<br/>
        /// # <br/>
        /// # You must provide at least ONE of the following params: organization, organization_name, or organization_id.<br/>
        /// # <br/>
        /// # :param str email: the member's email<br/>
        /// # :param str role: MemberOrgRole.ADMIN, MemberOrgRole.OWNER, MemberOrgRole.MEMBER, MemberOrgRole.WORKER<br/>
        /// # :param str organization_id: Organization id<br/>
        /// # :param str organization_name: Organization name<br/>
        /// # :param entities.Organization organization: Organization object<br/>
        /// # :return: True if successful or error if unsuccessful<br/>
        /// # :rtype: bool<br/>
        /// # <br/>
        /// # <br/>
        /// # success = dl.organizations.add_member(email='user@domain.com',<br/>
        /// # organization_id='organization_id',<br/>
        /// # role=dl.MemberOrgRole.MEMBER)<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIOrgUser>> AddOrgMembersAsync(
            string orgId,

            global::Dataloop.AddOrgMembersRequest request,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a new member to an organization
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="role"></param>
        /// <param name="emails"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIOrgUser>> AddOrgMembersAsync(
            string orgId,
            global::Dataloop.OrgRole role,
            global::System.Collections.Generic.IList<string> emails,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}