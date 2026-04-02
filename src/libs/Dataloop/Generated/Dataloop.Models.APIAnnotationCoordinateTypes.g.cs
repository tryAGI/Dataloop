#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct APIAnnotationCoordinateTypes : global::System.IEquatable<APIAnnotationCoordinateTypes>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.Point? Point { get; init; }
#else
        public global::Dataloop.Point? Point { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Point))]
#endif
        public bool IsPoint => Point != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Dataloop.Point>? APIAnnotationCoordinateTypesVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Dataloop.Point>? APIAnnotationCoordinateTypesVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(APIAnnotationCoordinateTypesVariant2))]
#endif
        public bool IsAPIAnnotationCoordinateTypesVariant2 => APIAnnotationCoordinateTypesVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>? APIAnnotationCoordinateTypesVariant3 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>? APIAnnotationCoordinateTypesVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(APIAnnotationCoordinateTypesVariant3))]
#endif
        public bool IsAPIAnnotationCoordinateTypesVariant3 => APIAnnotationCoordinateTypesVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.APINoteAnnotationCoordinatesV1? NoteCoordinatesV1 { get; init; }
#else
        public global::Dataloop.APINoteAnnotationCoordinatesV1? NoteCoordinatesV1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NoteCoordinatesV1))]
#endif
        public bool IsNoteCoordinatesV1 => NoteCoordinatesV1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? APIAnnotationCoordinateTypesVariant5 { get; init; }
#else
        public string? APIAnnotationCoordinateTypesVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(APIAnnotationCoordinateTypesVariant5))]
#endif
        public bool IsAPIAnnotationCoordinateTypesVariant5 => APIAnnotationCoordinateTypesVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.PoseCoordinates? PoseCoordinates { get; init; }
#else
        public global::Dataloop.PoseCoordinates? PoseCoordinates { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PoseCoordinates))]
#endif
        public bool IsPoseCoordinates => PoseCoordinates != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>? PolygonCoordinatesV1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>? PolygonCoordinatesV1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PolygonCoordinatesV1))]
#endif
        public bool IsPolygonCoordinatesV1 => PolygonCoordinatesV1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>? PolylineCoordinatesV3 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>? PolylineCoordinatesV3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PolylineCoordinatesV3))]
#endif
        public bool IsPolylineCoordinatesV3 => PolylineCoordinatesV3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.EllipseCoordinatesV1? EllipseCoordinatesV1 { get; init; }
#else
        public global::Dataloop.EllipseCoordinatesV1? EllipseCoordinatesV1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EllipseCoordinatesV1))]
#endif
        public bool IsEllipseCoordinatesV1 => EllipseCoordinatesV1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.CubeCoordinatesV1? CubeCoordinatesV1 { get; init; }
#else
        public global::Dataloop.CubeCoordinatesV1? CubeCoordinatesV1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CubeCoordinatesV1))]
#endif
        public bool IsCubeCoordinatesV1 => CubeCoordinatesV1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<object>? BoxCoordinates { get; init; }
#else
        public global::System.Collections.Generic.IList<object>? BoxCoordinates { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BoxCoordinates))]
#endif
        public bool IsBoxCoordinates => BoxCoordinates != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.ItemDescriptionCoordinates? ItemDescriptionCoordinates { get; init; }
#else
        public global::Dataloop.ItemDescriptionCoordinates? ItemDescriptionCoordinates { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ItemDescriptionCoordinates))]
#endif
        public bool IsItemDescriptionCoordinates => ItemDescriptionCoordinates != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.IRefImageAnnotationsType? RefImageAnnotationsType { get; init; }
#else
        public global::Dataloop.IRefImageAnnotationsType? RefImageAnnotationsType { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RefImageAnnotationsType))]
#endif
        public bool IsRefImageAnnotationsType => RefImageAnnotationsType != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator APIAnnotationCoordinateTypes(global::Dataloop.Point value) => new APIAnnotationCoordinateTypes((global::Dataloop.Point?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.Point?(APIAnnotationCoordinateTypes @this) => @this.Point;

        /// <summary>
        /// 
        /// </summary>
        public APIAnnotationCoordinateTypes(global::Dataloop.Point? value)
        {
            Point = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator APIAnnotationCoordinateTypes(global::Dataloop.APINoteAnnotationCoordinatesV1 value) => new APIAnnotationCoordinateTypes((global::Dataloop.APINoteAnnotationCoordinatesV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.APINoteAnnotationCoordinatesV1?(APIAnnotationCoordinateTypes @this) => @this.NoteCoordinatesV1;

        /// <summary>
        /// 
        /// </summary>
        public APIAnnotationCoordinateTypes(global::Dataloop.APINoteAnnotationCoordinatesV1? value)
        {
            NoteCoordinatesV1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator APIAnnotationCoordinateTypes(string value) => new APIAnnotationCoordinateTypes((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(APIAnnotationCoordinateTypes @this) => @this.APIAnnotationCoordinateTypesVariant5;

        /// <summary>
        /// 
        /// </summary>
        public APIAnnotationCoordinateTypes(string? value)
        {
            APIAnnotationCoordinateTypesVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator APIAnnotationCoordinateTypes(global::Dataloop.PoseCoordinates value) => new APIAnnotationCoordinateTypes((global::Dataloop.PoseCoordinates?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.PoseCoordinates?(APIAnnotationCoordinateTypes @this) => @this.PoseCoordinates;

        /// <summary>
        /// 
        /// </summary>
        public APIAnnotationCoordinateTypes(global::Dataloop.PoseCoordinates? value)
        {
            PoseCoordinates = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator APIAnnotationCoordinateTypes(global::Dataloop.EllipseCoordinatesV1 value) => new APIAnnotationCoordinateTypes((global::Dataloop.EllipseCoordinatesV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.EllipseCoordinatesV1?(APIAnnotationCoordinateTypes @this) => @this.EllipseCoordinatesV1;

        /// <summary>
        /// 
        /// </summary>
        public APIAnnotationCoordinateTypes(global::Dataloop.EllipseCoordinatesV1? value)
        {
            EllipseCoordinatesV1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator APIAnnotationCoordinateTypes(global::Dataloop.CubeCoordinatesV1 value) => new APIAnnotationCoordinateTypes((global::Dataloop.CubeCoordinatesV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.CubeCoordinatesV1?(APIAnnotationCoordinateTypes @this) => @this.CubeCoordinatesV1;

        /// <summary>
        /// 
        /// </summary>
        public APIAnnotationCoordinateTypes(global::Dataloop.CubeCoordinatesV1? value)
        {
            CubeCoordinatesV1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator APIAnnotationCoordinateTypes(global::Dataloop.ItemDescriptionCoordinates value) => new APIAnnotationCoordinateTypes((global::Dataloop.ItemDescriptionCoordinates?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.ItemDescriptionCoordinates?(APIAnnotationCoordinateTypes @this) => @this.ItemDescriptionCoordinates;

        /// <summary>
        /// 
        /// </summary>
        public APIAnnotationCoordinateTypes(global::Dataloop.ItemDescriptionCoordinates? value)
        {
            ItemDescriptionCoordinates = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator APIAnnotationCoordinateTypes(global::Dataloop.IRefImageAnnotationsType value) => new APIAnnotationCoordinateTypes((global::Dataloop.IRefImageAnnotationsType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.IRefImageAnnotationsType?(APIAnnotationCoordinateTypes @this) => @this.RefImageAnnotationsType;

        /// <summary>
        /// 
        /// </summary>
        public APIAnnotationCoordinateTypes(global::Dataloop.IRefImageAnnotationsType? value)
        {
            RefImageAnnotationsType = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public APIAnnotationCoordinateTypes(
            global::Dataloop.Point? point,
            global::System.Collections.Generic.IList<global::Dataloop.Point>? aPIAnnotationCoordinateTypesVariant2,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>? aPIAnnotationCoordinateTypesVariant3,
            global::Dataloop.APINoteAnnotationCoordinatesV1? noteCoordinatesV1,
            string? aPIAnnotationCoordinateTypesVariant5,
            global::Dataloop.PoseCoordinates? poseCoordinates,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>? polygonCoordinatesV1,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>? polylineCoordinatesV3,
            global::Dataloop.EllipseCoordinatesV1? ellipseCoordinatesV1,
            global::Dataloop.CubeCoordinatesV1? cubeCoordinatesV1,
            global::System.Collections.Generic.IList<object>? boxCoordinates,
            global::Dataloop.ItemDescriptionCoordinates? itemDescriptionCoordinates,
            global::Dataloop.IRefImageAnnotationsType? refImageAnnotationsType
            )
        {
            Point = point;
            APIAnnotationCoordinateTypesVariant2 = aPIAnnotationCoordinateTypesVariant2;
            APIAnnotationCoordinateTypesVariant3 = aPIAnnotationCoordinateTypesVariant3;
            NoteCoordinatesV1 = noteCoordinatesV1;
            APIAnnotationCoordinateTypesVariant5 = aPIAnnotationCoordinateTypesVariant5;
            PoseCoordinates = poseCoordinates;
            PolygonCoordinatesV1 = polygonCoordinatesV1;
            PolylineCoordinatesV3 = polylineCoordinatesV3;
            EllipseCoordinatesV1 = ellipseCoordinatesV1;
            CubeCoordinatesV1 = cubeCoordinatesV1;
            BoxCoordinates = boxCoordinates;
            ItemDescriptionCoordinates = itemDescriptionCoordinates;
            RefImageAnnotationsType = refImageAnnotationsType;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RefImageAnnotationsType as object ??
            ItemDescriptionCoordinates as object ??
            BoxCoordinates as object ??
            CubeCoordinatesV1 as object ??
            EllipseCoordinatesV1 as object ??
            PolylineCoordinatesV3 as object ??
            PolygonCoordinatesV1 as object ??
            PoseCoordinates as object ??
            APIAnnotationCoordinateTypesVariant5 as object ??
            NoteCoordinatesV1 as object ??
            APIAnnotationCoordinateTypesVariant3 as object ??
            APIAnnotationCoordinateTypesVariant2 as object ??
            Point as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Point?.ToString() ??
            APIAnnotationCoordinateTypesVariant2?.ToString() ??
            APIAnnotationCoordinateTypesVariant3?.ToString() ??
            NoteCoordinatesV1?.ToString() ??
            APIAnnotationCoordinateTypesVariant5?.ToString() ??
            PoseCoordinates?.ToString() ??
            PolygonCoordinatesV1?.ToString() ??
            PolylineCoordinatesV3?.ToString() ??
            EllipseCoordinatesV1?.ToString() ??
            CubeCoordinatesV1?.ToString() ??
            BoxCoordinates?.ToString() ??
            ItemDescriptionCoordinates?.ToString() ??
            RefImageAnnotationsType?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPoint || IsAPIAnnotationCoordinateTypesVariant2 || IsAPIAnnotationCoordinateTypesVariant3 || IsNoteCoordinatesV1 || IsAPIAnnotationCoordinateTypesVariant5 || IsPoseCoordinates || IsPolygonCoordinatesV1 || IsPolylineCoordinatesV3 || IsEllipseCoordinatesV1 || IsCubeCoordinatesV1 || IsBoxCoordinates || IsItemDescriptionCoordinates || IsRefImageAnnotationsType;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dataloop.Point?, TResult>? point = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Dataloop.Point>?, TResult>? aPIAnnotationCoordinateTypesVariant2 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>?, TResult>? aPIAnnotationCoordinateTypesVariant3 = null,
            global::System.Func<global::Dataloop.APINoteAnnotationCoordinatesV1?, TResult>? noteCoordinatesV1 = null,
            global::System.Func<string?, TResult>? aPIAnnotationCoordinateTypesVariant5 = null,
            global::System.Func<global::Dataloop.PoseCoordinates?, TResult>? poseCoordinates = null,
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>?, TResult>? polygonCoordinatesV1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>?, TResult>? polylineCoordinatesV3 = null,
            global::System.Func<global::Dataloop.EllipseCoordinatesV1?, TResult>? ellipseCoordinatesV1 = null,
            global::System.Func<global::Dataloop.CubeCoordinatesV1?, TResult>? cubeCoordinatesV1 = null,
            global::System.Func<global::System.Collections.Generic.IList<object>?, TResult>? boxCoordinates = null,
            global::System.Func<global::Dataloop.ItemDescriptionCoordinates?, TResult>? itemDescriptionCoordinates = null,
            global::System.Func<global::Dataloop.IRefImageAnnotationsType?, TResult>? refImageAnnotationsType = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPoint && point != null)
            {
                return point(Point!);
            }
            else if (IsAPIAnnotationCoordinateTypesVariant2 && aPIAnnotationCoordinateTypesVariant2 != null)
            {
                return aPIAnnotationCoordinateTypesVariant2(APIAnnotationCoordinateTypesVariant2!);
            }
            else if (IsAPIAnnotationCoordinateTypesVariant3 && aPIAnnotationCoordinateTypesVariant3 != null)
            {
                return aPIAnnotationCoordinateTypesVariant3(APIAnnotationCoordinateTypesVariant3!);
            }
            else if (IsNoteCoordinatesV1 && noteCoordinatesV1 != null)
            {
                return noteCoordinatesV1(NoteCoordinatesV1!);
            }
            else if (IsAPIAnnotationCoordinateTypesVariant5 && aPIAnnotationCoordinateTypesVariant5 != null)
            {
                return aPIAnnotationCoordinateTypesVariant5(APIAnnotationCoordinateTypesVariant5!);
            }
            else if (IsPoseCoordinates && poseCoordinates != null)
            {
                return poseCoordinates(PoseCoordinates!);
            }
            else if (IsPolygonCoordinatesV1 && polygonCoordinatesV1 != null)
            {
                return polygonCoordinatesV1(PolygonCoordinatesV1!);
            }
            else if (IsPolylineCoordinatesV3 && polylineCoordinatesV3 != null)
            {
                return polylineCoordinatesV3(PolylineCoordinatesV3!);
            }
            else if (IsEllipseCoordinatesV1 && ellipseCoordinatesV1 != null)
            {
                return ellipseCoordinatesV1(EllipseCoordinatesV1!);
            }
            else if (IsCubeCoordinatesV1 && cubeCoordinatesV1 != null)
            {
                return cubeCoordinatesV1(CubeCoordinatesV1!);
            }
            else if (IsBoxCoordinates && boxCoordinates != null)
            {
                return boxCoordinates(BoxCoordinates!);
            }
            else if (IsItemDescriptionCoordinates && itemDescriptionCoordinates != null)
            {
                return itemDescriptionCoordinates(ItemDescriptionCoordinates!);
            }
            else if (IsRefImageAnnotationsType && refImageAnnotationsType != null)
            {
                return refImageAnnotationsType(RefImageAnnotationsType!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Dataloop.Point?>? point = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Dataloop.Point>?>? aPIAnnotationCoordinateTypesVariant2 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>?>? aPIAnnotationCoordinateTypesVariant3 = null,
            global::System.Action<global::Dataloop.APINoteAnnotationCoordinatesV1?>? noteCoordinatesV1 = null,
            global::System.Action<string?>? aPIAnnotationCoordinateTypesVariant5 = null,
            global::System.Action<global::Dataloop.PoseCoordinates?>? poseCoordinates = null,
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>?>? polygonCoordinatesV1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>?>? polylineCoordinatesV3 = null,
            global::System.Action<global::Dataloop.EllipseCoordinatesV1?>? ellipseCoordinatesV1 = null,
            global::System.Action<global::Dataloop.CubeCoordinatesV1?>? cubeCoordinatesV1 = null,
            global::System.Action<global::System.Collections.Generic.IList<object>?>? boxCoordinates = null,
            global::System.Action<global::Dataloop.ItemDescriptionCoordinates?>? itemDescriptionCoordinates = null,
            global::System.Action<global::Dataloop.IRefImageAnnotationsType?>? refImageAnnotationsType = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPoint)
            {
                point?.Invoke(Point!);
            }
            else if (IsAPIAnnotationCoordinateTypesVariant2)
            {
                aPIAnnotationCoordinateTypesVariant2?.Invoke(APIAnnotationCoordinateTypesVariant2!);
            }
            else if (IsAPIAnnotationCoordinateTypesVariant3)
            {
                aPIAnnotationCoordinateTypesVariant3?.Invoke(APIAnnotationCoordinateTypesVariant3!);
            }
            else if (IsNoteCoordinatesV1)
            {
                noteCoordinatesV1?.Invoke(NoteCoordinatesV1!);
            }
            else if (IsAPIAnnotationCoordinateTypesVariant5)
            {
                aPIAnnotationCoordinateTypesVariant5?.Invoke(APIAnnotationCoordinateTypesVariant5!);
            }
            else if (IsPoseCoordinates)
            {
                poseCoordinates?.Invoke(PoseCoordinates!);
            }
            else if (IsPolygonCoordinatesV1)
            {
                polygonCoordinatesV1?.Invoke(PolygonCoordinatesV1!);
            }
            else if (IsPolylineCoordinatesV3)
            {
                polylineCoordinatesV3?.Invoke(PolylineCoordinatesV3!);
            }
            else if (IsEllipseCoordinatesV1)
            {
                ellipseCoordinatesV1?.Invoke(EllipseCoordinatesV1!);
            }
            else if (IsCubeCoordinatesV1)
            {
                cubeCoordinatesV1?.Invoke(CubeCoordinatesV1!);
            }
            else if (IsBoxCoordinates)
            {
                boxCoordinates?.Invoke(BoxCoordinates!);
            }
            else if (IsItemDescriptionCoordinates)
            {
                itemDescriptionCoordinates?.Invoke(ItemDescriptionCoordinates!);
            }
            else if (IsRefImageAnnotationsType)
            {
                refImageAnnotationsType?.Invoke(RefImageAnnotationsType!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Point,
                typeof(global::Dataloop.Point),
                APIAnnotationCoordinateTypesVariant2,
                typeof(global::System.Collections.Generic.IList<global::Dataloop.Point>),
                APIAnnotationCoordinateTypesVariant3,
                typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>),
                NoteCoordinatesV1,
                typeof(global::Dataloop.APINoteAnnotationCoordinatesV1),
                APIAnnotationCoordinateTypesVariant5,
                typeof(string),
                PoseCoordinates,
                typeof(global::Dataloop.PoseCoordinates),
                PolygonCoordinatesV1,
                typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>),
                PolylineCoordinatesV3,
                typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>),
                EllipseCoordinatesV1,
                typeof(global::Dataloop.EllipseCoordinatesV1),
                CubeCoordinatesV1,
                typeof(global::Dataloop.CubeCoordinatesV1),
                BoxCoordinates,
                typeof(global::System.Collections.Generic.IList<object>),
                ItemDescriptionCoordinates,
                typeof(global::Dataloop.ItemDescriptionCoordinates),
                RefImageAnnotationsType,
                typeof(global::Dataloop.IRefImageAnnotationsType),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(APIAnnotationCoordinateTypes other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.Point?>.Default.Equals(Point, other.Point) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Dataloop.Point>?>.Default.Equals(APIAnnotationCoordinateTypesVariant2, other.APIAnnotationCoordinateTypesVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>?>.Default.Equals(APIAnnotationCoordinateTypesVariant3, other.APIAnnotationCoordinateTypesVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.APINoteAnnotationCoordinatesV1?>.Default.Equals(NoteCoordinatesV1, other.NoteCoordinatesV1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(APIAnnotationCoordinateTypesVariant5, other.APIAnnotationCoordinateTypesVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.PoseCoordinates?>.Default.Equals(PoseCoordinates, other.PoseCoordinates) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>?>.Default.Equals(PolygonCoordinatesV1, other.PolygonCoordinatesV1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Dataloop.Point>>?>.Default.Equals(PolylineCoordinatesV3, other.PolylineCoordinatesV3) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.EllipseCoordinatesV1?>.Default.Equals(EllipseCoordinatesV1, other.EllipseCoordinatesV1) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.CubeCoordinatesV1?>.Default.Equals(CubeCoordinatesV1, other.CubeCoordinatesV1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<object>?>.Default.Equals(BoxCoordinates, other.BoxCoordinates) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.ItemDescriptionCoordinates?>.Default.Equals(ItemDescriptionCoordinates, other.ItemDescriptionCoordinates) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.IRefImageAnnotationsType?>.Default.Equals(RefImageAnnotationsType, other.RefImageAnnotationsType) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(APIAnnotationCoordinateTypes obj1, APIAnnotationCoordinateTypes obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<APIAnnotationCoordinateTypes>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(APIAnnotationCoordinateTypes obj1, APIAnnotationCoordinateTypes obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is APIAnnotationCoordinateTypes o && Equals(o);
        }
    }
}
