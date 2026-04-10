#nullable enable

namespace Dataloop
{
    public partial interface IAnnotationsClient
    {
        /// <summary>
        /// Update an item's annotation
        /// </summary>
        /// <param name="annotationId"></param>
        /// <param name="system"></param>
        /// <param name="replace"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// # <br/>
        /// # Update an existing annotation. For example, you may change the annotation's label and then use the update method.<br/>
        /// # <br/>
        /// # **Prerequisites**: You must have an item that has been annotated. You must have the role of an *owner* or<br/>
        /// # *developer* or be assigned a task that includes that item as an *annotation manager* or *annotator*.<br/>
        /// # <br/>
        /// # :param dtlpy.entities.annotation.Annotation annotations: Annotation object<br/>
        /// # :param bool system_metadata: bool - True, if you want to change metadata system<br/>
        /// # <br/>
        /// # :return: True if successful or error if unsuccessful<br/>
        /// # :rtype: bool<br/>
        /// # <br/>
        /// # <br/>
        /// # annotations = item.annotations.update(annotation='annotation')<br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAnnotation> UpdateAnnotationAsync(
            string annotationId,

            global::Dataloop.UpdateAnnotationRequest request,
            bool? system = default,
            bool? replace = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an item's annotation
        /// </summary>
        /// <param name="annotationId"></param>
        /// <param name="system"></param>
        /// <param name="replace"></param>
        /// <param name="creator"></param>
        /// <param name="type"></param>
        /// <param name="label"></param>
        /// <param name="coordinates"></param>
        /// <param name="attributes"></param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.APIAnnotation> UpdateAnnotationAsync(
            string annotationId,
            string creator,
            global::Dataloop.AnnotationType type,
            string label,
            bool? system = default,
            bool? replace = default,
            object? coordinates = default,
            global::System.Collections.Generic.IList<string>? attributes = default,
            global::Dataloop.APIMetadata? metadata = default,
            global::Dataloop.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}