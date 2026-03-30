#nullable enable

namespace Dataloop
{
    public partial interface IAnnotationsClient
    {
        /// <summary>
        /// Get annotation by id
        /// </summary>
        /// <param name="annotationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Get a single annotation.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must have an item that has been annotated. You must have the role of an *owner* or<br/>
        /// # *developer* or be assigned a task that includes that item as an *annotation manager* or *annotator*.<br/>
        /// # <br/>
        /// # :param str annotation_id: The id of the annotation<br/>
        /// # :return: Annotation object or None<br/>
        /// # :return: Annotation object or None<br/>
        /// # :rtype: dtlpy.entities.annotation.Annotation<br/>
        /// # <br/>
        /// # <br/>
        /// # annotation = item.annotations.get(annotation_id='annotation_id')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAnnotation> GetAnnotationAsync(
            string annotationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}