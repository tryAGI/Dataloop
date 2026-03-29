#nullable enable

namespace Dataloop
{
    public partial interface IAnnotationsClient
    {
        /// <summary>
        /// Delete an Annotation from an item
        /// </summary>
        /// <param name="annotationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// is_deleted = item.annotations.delete(annotation_id='annotation_id')<br/>
        /// # <br/>
        /// # Remove an annotation from item.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must have an item that has been annotated. You must have the role of an *owner* or<br/>
        /// # *developer* or be assigned a task that includes that item as an *annotation manager* or *annotator*.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.annotation.Annotation annotation: Annotation object<br/>
        /// # :param str annotation_id: The id of the annotation<br/>
        /// # :param dtlpy.entities.filters.Filters filters: Filters entity or a dictionary containing filters parameters<br/>
        /// # :return: True/False<br/>
        /// # :rtype: bool<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task DeleteAnnotationAsync(
            string annotationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}