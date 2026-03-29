#nullable enable

namespace Dataloop
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Get all organization members
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// list_members = dl.organizations.list_members(organization='organization-entity',<br/>
        /// role=dl.MemberOrgRole.MEMBER)<br/>
        /// # <br/>
        /// # List all organization members.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must be an organization *owner* to use this method.<br/>
        /// # <br/>
        /// # You must provide at least ONE of the following params: organization_id, organization_name, or organization.<br/>
        /// # <br/>
        /// # :param entities.Organization organization: Organization object<br/>
        /// # :param str organization_id: Organization id<br/>
        /// # :param str organization_name: Organization name<br/>
        /// # :param entities.MemberOrgRole role: MemberOrgRole.ADMIN, MemberOrgRole.OWNER, MemberOrgRole.MEMBER, MemberOrgRole.WORKER<br/>
        /// # :return: projects list<br/>
        /// # :rtype: list<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Dataloop.APIUser>> GetOrgMembersAsync(
            string orgId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}