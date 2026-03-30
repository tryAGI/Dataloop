#nullable enable

namespace Dataloop
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Remove a member from an organization
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="memberId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Delete member from the Organization.<br/>
        /// # <br/>
        /// # **Prerequisites**: Must be an organization *owner* to delete members.<br/>
        /// # <br/>
        /// # You must provide at least ONE of the following params: organization_id, organization_name, organization.<br/>
        /// # <br/>
        /// # :param str user_id: user id<br/>
        /// # :param str organization_id: Organization id<br/>
        /// # :param str organization_name: Organization name<br/>
        /// # :param entities.Organization organization: Organization object<br/>
        /// # :param bool sure: Are you sure you want to delete?<br/>
        /// # :param bool really: Really really sure?<br/>
        /// # :return: True if success and error if not<br/>
        /// # :rtype: bool<br/>
        /// # <br/>
        /// # <br/>
        /// # success = dl.organizations.delete_member(user_id='user_id',<br/>
        /// # organization_id='organization_id',<br/>
        /// # sure=True,<br/>
        /// # really=True)<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task RemoveOrgMemberAsync(
            string orgId,
            string memberId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}