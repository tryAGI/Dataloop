#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ModelOutputType : global::System.IEquatable<ModelOutputType>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.AnnotationType? Annotation1 { get; init; }
#else
        public global::Dataloop.AnnotationType? Annotation1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Annotation1))]
#endif
        public bool IsAnnotation1 => Annotation1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.ModelOutputTypeVariant2? ModelOutputTypeVariant2 { get; init; }
#else
        public global::Dataloop.ModelOutputTypeVariant2? ModelOutputTypeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelOutputTypeVariant2))]
#endif
        public bool IsModelOutputTypeVariant2 => ModelOutputTypeVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.AnnotationType? Annotation2 { get; init; }
#else
        public global::Dataloop.AnnotationType? Annotation2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Annotation2))]
#endif
        public bool IsAnnotation2 => Annotation2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.ModelOutputTypeVariant4? ModelOutputTypeVariant4 { get; init; }
#else
        public global::Dataloop.ModelOutputTypeVariant4? ModelOutputTypeVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelOutputTypeVariant4))]
#endif
        public bool IsModelOutputTypeVariant4 => ModelOutputTypeVariant4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelOutputType(global::Dataloop.AnnotationType value) => new ModelOutputType((global::Dataloop.AnnotationType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.AnnotationType?(ModelOutputType @this) => @this.Annotation1;

        /// <summary>
        /// 
        /// </summary>
        public ModelOutputType(global::Dataloop.AnnotationType? value)
        {
            Annotation1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelOutputType(global::Dataloop.ModelOutputTypeVariant2 value) => new ModelOutputType((global::Dataloop.ModelOutputTypeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.ModelOutputTypeVariant2?(ModelOutputType @this) => @this.ModelOutputTypeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ModelOutputType(global::Dataloop.ModelOutputTypeVariant2? value)
        {
            ModelOutputTypeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelOutputType(global::Dataloop.ModelOutputTypeVariant4 value) => new ModelOutputType((global::Dataloop.ModelOutputTypeVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.ModelOutputTypeVariant4?(ModelOutputType @this) => @this.ModelOutputTypeVariant4;

        /// <summary>
        /// 
        /// </summary>
        public ModelOutputType(global::Dataloop.ModelOutputTypeVariant4? value)
        {
            ModelOutputTypeVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ModelOutputType(
            global::Dataloop.AnnotationType? annotation1,
            global::Dataloop.ModelOutputTypeVariant2? modelOutputTypeVariant2,
            global::Dataloop.AnnotationType? annotation2,
            global::Dataloop.ModelOutputTypeVariant4? modelOutputTypeVariant4
            )
        {
            Annotation1 = annotation1;
            ModelOutputTypeVariant2 = modelOutputTypeVariant2;
            Annotation2 = annotation2;
            ModelOutputTypeVariant4 = modelOutputTypeVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ModelOutputTypeVariant4 as object ??
            Annotation2 as object ??
            ModelOutputTypeVariant2 as object ??
            Annotation1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Annotation1?.ToValueString() ??
            ModelOutputTypeVariant2?.ToValueString() ??
            Annotation2?.ToValueString() ??
            ModelOutputTypeVariant4?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnnotation1 || IsModelOutputTypeVariant2 || IsAnnotation2 || IsModelOutputTypeVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dataloop.AnnotationType?, TResult>? annotation1 = null,
            global::System.Func<global::Dataloop.ModelOutputTypeVariant2?, TResult>? modelOutputTypeVariant2 = null,
            global::System.Func<global::Dataloop.AnnotationType?, TResult>? annotation2 = null,
            global::System.Func<global::Dataloop.ModelOutputTypeVariant4?, TResult>? modelOutputTypeVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnnotation1 && annotation1 != null)
            {
                return annotation1(Annotation1!);
            }
            else if (IsModelOutputTypeVariant2 && modelOutputTypeVariant2 != null)
            {
                return modelOutputTypeVariant2(ModelOutputTypeVariant2!);
            }
            else if (IsAnnotation2 && annotation2 != null)
            {
                return annotation2(Annotation2!);
            }
            else if (IsModelOutputTypeVariant4 && modelOutputTypeVariant4 != null)
            {
                return modelOutputTypeVariant4(ModelOutputTypeVariant4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Dataloop.AnnotationType?>? annotation1 = null,
            global::System.Action<global::Dataloop.ModelOutputTypeVariant2?>? modelOutputTypeVariant2 = null,
            global::System.Action<global::Dataloop.AnnotationType?>? annotation2 = null,
            global::System.Action<global::Dataloop.ModelOutputTypeVariant4?>? modelOutputTypeVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnnotation1)
            {
                annotation1?.Invoke(Annotation1!);
            }
            else if (IsModelOutputTypeVariant2)
            {
                modelOutputTypeVariant2?.Invoke(ModelOutputTypeVariant2!);
            }
            else if (IsAnnotation2)
            {
                annotation2?.Invoke(Annotation2!);
            }
            else if (IsModelOutputTypeVariant4)
            {
                modelOutputTypeVariant4?.Invoke(ModelOutputTypeVariant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Annotation1,
                typeof(global::Dataloop.AnnotationType),
                ModelOutputTypeVariant2,
                typeof(global::Dataloop.ModelOutputTypeVariant2),
                Annotation2,
                typeof(global::Dataloop.AnnotationType),
                ModelOutputTypeVariant4,
                typeof(global::Dataloop.ModelOutputTypeVariant4),
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
        public bool Equals(ModelOutputType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.AnnotationType?>.Default.Equals(Annotation1, other.Annotation1) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.ModelOutputTypeVariant2?>.Default.Equals(ModelOutputTypeVariant2, other.ModelOutputTypeVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.AnnotationType?>.Default.Equals(Annotation2, other.Annotation2) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.ModelOutputTypeVariant4?>.Default.Equals(ModelOutputTypeVariant4, other.ModelOutputTypeVariant4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ModelOutputType obj1, ModelOutputType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ModelOutputType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ModelOutputType obj1, ModelOutputType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelOutputType o && Equals(o);
        }
    }
}
