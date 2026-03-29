#nullable enable

namespace Dataloop
{
    public partial interface IItemAnnotationsClient
    {
        /// <summary>
        /// Create an annotation for an item
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Dataloop.ApiException"></exception>
        /// <remarks>
        /// annotations = item.annotations.upload(annotations='builder')<br/>
        /// # <br/>
        /// # Upload a new annotation/annotations. You must first create the annotation using the annotation *builder* method.<br/>
        /// # <br/>
        /// # **Prerequisites**: Any user can upload annotations.<br/>
        /// # <br/>
        /// # :param List[dtlpy.entities.annotation.Annotation] or dtlpy.entities.annotation.Annotation annotations: list or<br/>
        /// # single annotation of type Annotation<br/>
        /// # :return: list of annotation objects<br/>
        /// # :rtype: entities.AnnotationCollection<br/>
        /// # <br/>
        /// # 
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIAnnotation, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotation>>> CreateAnnotationsAsync(
            string itemId,

            global::Dataloop.AnyOf<global::Dataloop.APIAnnotationRequest, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotationRequest>> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an annotation for an item
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Dataloop.AnyOf<global::Dataloop.APIAnnotation, global::System.Collections.Generic.IList<global::Dataloop.APIAnnotation>>> CreateAnnotationsAsync(
            string itemId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}