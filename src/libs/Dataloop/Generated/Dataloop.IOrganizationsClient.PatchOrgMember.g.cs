#nullable enable

namespace Dataloop
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Change a member's role in an organization
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Update member role.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be an organization *owner* to update a member's role.<br/>
        /// # <br/>
        /// # You must provide at least ONE of the following params: organization, organization_name, or organization_id.<br/>
        /// # <br/>
        /// # :param str email: the member's email<br/>
        /// # :param str role: MemberOrgRole.ADMIN, MemberOrgRole.OWNER, MemberOrgRole.MEMBER, MemberOrgRole.WORKER<br/>
        /// # :param str organization_id: Organization id<br/>
        /// # :param str organization_name: Organization name<br/>
        /// # :param entities.Organization organization: Organization object<br/>
        /// # :return: json of the member fields<br/>
        /// # :rtype: dict<br/>
        /// # <br/>
        /// # <br/>
        /// # member_json = dl.organizations.update_member(email='user@domain.com',<br/>
        /// # organization_id='organization_id',<br/>
        /// # role=dl.MemberOrgRole.MEMBER)<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIUser>> PatchOrgMemberAsync(
            string orgId,

            global::Dataloop.PatchOrgMemberRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change a member's role in an organization
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="defaultProjectRole"></param>
        /// <param name="role"></param>
        /// <param name="email"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIUser>> PatchOrgMemberAsync(
            string orgId,
            global::Dataloop.OrgRole role,
            string email,
            global::Dataloop.Role? defaultProjectRole = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}