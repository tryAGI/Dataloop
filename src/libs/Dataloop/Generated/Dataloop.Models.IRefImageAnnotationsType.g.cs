#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IRefImageAnnotationsType : global::System.IEquatable<IRefImageAnnotationsType>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? IRefImageAnnotationsTypeVariant1 { get; init; }
#else
        public object? IRefImageAnnotationsTypeVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IRefImageAnnotationsTypeVariant1))]
#endif
        public bool IsIRefImageAnnotationsTypeVariant1 => IRefImageAnnotationsTypeVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.IBaseRefAnnotationCoordinates? BaseAnnotationCoordinates { get; init; }
#else
        public global::Dataloop.IBaseRefAnnotationCoordinates? BaseAnnotationCoordinates { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseAnnotationCoordinates))]
#endif
        public bool IsBaseAnnotationCoordinates => BaseAnnotationCoordinates != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IRefImageAnnotationsType(global::Dataloop.IBaseRefAnnotationCoordinates value) => new IRefImageAnnotationsType((global::Dataloop.IBaseRefAnnotationCoordinates?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.IBaseRefAnnotationCoordinates?(IRefImageAnnotationsType @this) => @this.BaseAnnotationCoordinates;

        /// <summary>
        /// 
        /// </summary>
        public IRefImageAnnotationsType(global::Dataloop.IBaseRefAnnotationCoordinates? value)
        {
            BaseAnnotationCoordinates = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IRefImageAnnotationsType(
            object? iRefImageAnnotationsTypeVariant1,
            global::Dataloop.IBaseRefAnnotationCoordinates? baseAnnotationCoordinates
            )
        {
            IRefImageAnnotationsTypeVariant1 = iRefImageAnnotationsTypeVariant1;
            BaseAnnotationCoordinates = baseAnnotationCoordinates;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BaseAnnotationCoordinates as object ??
            IRefImageAnnotationsTypeVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            IRefImageAnnotationsTypeVariant1?.ToString() ??
            BaseAnnotationCoordinates?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsIRefImageAnnotationsTypeVariant1 && IsBaseAnnotationCoordinates;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<object?, TResult>? iRefImageAnnotationsTypeVariant1 = null,
            global::System.Func<global::Dataloop.IBaseRefAnnotationCoordinates?, TResult>? baseAnnotationCoordinates = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIRefImageAnnotationsTypeVariant1 && iRefImageAnnotationsTypeVariant1 != null)
            {
                return iRefImageAnnotationsTypeVariant1(IRefImageAnnotationsTypeVariant1!);
            }
            else if (IsBaseAnnotationCoordinates && baseAnnotationCoordinates != null)
            {
                return baseAnnotationCoordinates(BaseAnnotationCoordinates!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<object?>? iRefImageAnnotationsTypeVariant1 = null,
            global::System.Action<global::Dataloop.IBaseRefAnnotationCoordinates?>? baseAnnotationCoordinates = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIRefImageAnnotationsTypeVariant1)
            {
                iRefImageAnnotationsTypeVariant1?.Invoke(IRefImageAnnotationsTypeVariant1!);
            }
            else if (IsBaseAnnotationCoordinates)
            {
                baseAnnotationCoordinates?.Invoke(BaseAnnotationCoordinates!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                IRefImageAnnotationsTypeVariant1,
                typeof(object),
                BaseAnnotationCoordinates,
                typeof(global::Dataloop.IBaseRefAnnotationCoordinates),
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
        public bool Equals(IRefImageAnnotationsType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(IRefImageAnnotationsTypeVariant1, other.IRefImageAnnotationsTypeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.IBaseRefAnnotationCoordinates?>.Default.Equals(BaseAnnotationCoordinates, other.BaseAnnotationCoordinates) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IRefImageAnnotationsType obj1, IRefImageAnnotationsType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IRefImageAnnotationsType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IRefImageAnnotationsType obj1, IRefImageAnnotationsType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IRefImageAnnotationsType o && Equals(o);
        }
    }
}
