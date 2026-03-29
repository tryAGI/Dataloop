
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EllipseCoordinatesV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("center")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Point Center { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rx")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Rx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ry")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Ry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("angle")]
        public double? Angle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EllipseCoordinatesV1" /> class.
        /// </summary>
        /// <param name="center"></param>
        /// <param name="rx"></param>
        /// <param name="ry"></param>
        /// <param name="angle"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EllipseCoordinatesV1(
            global::Dataloop.Point center,
            double rx,
            double ry,
            double? angle)
        {
            this.Center = center ?? throw new global::System.ArgumentNullException(nameof(center));
            this.Rx = rx;
            this.Ry = ry;
            this.Angle = angle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EllipseCoordinatesV1" /> class.
        /// </summary>
        public EllipseCoordinatesV1()
        {
        }
    }
}