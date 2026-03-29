#nullable enable

namespace Dataloop
{
    public partial interface IServicesClient
    {
        /// <summary>
        /// Receive a list of reports.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task ReceiveReportsAsync(
            string id,

            global::System.Collections.Generic.IList<global::Dataloop.BaseReportMessage> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}