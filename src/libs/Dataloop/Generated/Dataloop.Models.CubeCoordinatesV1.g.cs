
#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CubeCoordinatesV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("front_bl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Point FrontBl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("front_br")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Point FrontBr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("front_tl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Point FrontTl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("front_tr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Point FrontTr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("back_bl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Point BackBl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("back_br")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Point BackBr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("back_tl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Point BackTl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("back_tr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Dataloop.Point BackTr { get; set; }

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
        /// Initializes a new instance of the <see cref="CubeCoordinatesV1" /> class.
        /// </summary>
        /// <param name="frontBl"></param>
        /// <param name="frontBr"></param>
        /// <param name="frontTl"></param>
        /// <param name="frontTr"></param>
        /// <param name="backBl"></param>
        /// <param name="backBr"></param>
        /// <param name="backTl"></param>
        /// <param name="backTr"></param>
        /// <param name="angle"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CubeCoordinatesV1(
            global::Dataloop.Point frontBl,
            global::Dataloop.Point frontBr,
            global::Dataloop.Point frontTl,
            global::Dataloop.Point frontTr,
            global::Dataloop.Point backBl,
            global::Dataloop.Point backBr,
            global::Dataloop.Point backTl,
            global::Dataloop.Point backTr,
            double? angle)
        {
            this.FrontBl = frontBl ?? throw new global::System.ArgumentNullException(nameof(frontBl));
            this.FrontBr = frontBr ?? throw new global::System.ArgumentNullException(nameof(frontBr));
            this.FrontTl = frontTl ?? throw new global::System.ArgumentNullException(nameof(frontTl));
            this.FrontTr = frontTr ?? throw new global::System.ArgumentNullException(nameof(frontTr));
            this.BackBl = backBl ?? throw new global::System.ArgumentNullException(nameof(backBl));
            this.BackBr = backBr ?? throw new global::System.ArgumentNullException(nameof(backBr));
            this.BackTl = backTl ?? throw new global::System.ArgumentNullException(nameof(backTl));
            this.BackTr = backTr ?? throw new global::System.ArgumentNullException(nameof(backTr));
            this.Angle = angle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CubeCoordinatesV1" /> class.
        /// </summary>
        public CubeCoordinatesV1()
        {
        }
    }
}