#nullable enable

namespace Dataloop
{
    public partial interface IInvoicesClient
    {
        /// <summary>
        /// Retrieves the details of an invoice.<br/>
        /// Supply the unique invoice ID to fetch its details.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.Invoice> GetInvoiceAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}