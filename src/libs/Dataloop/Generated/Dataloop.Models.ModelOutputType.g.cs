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
        public global::Dataloop.AnnotationType? Annotation { get; init; }
#else
        public global::Dataloop.AnnotationType? Annotation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Annotation))]
#endif
        public bool IsAnnotation => Annotation != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.ModelOutputTypeEnum? Enum { get; init; }
#else
        public global::Dataloop.ModelOutputTypeEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelOutputType(global::Dataloop.AnnotationType value) => new ModelOutputType((global::Dataloop.AnnotationType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.AnnotationType?(ModelOutputType @this) => @this.Annotation;

        /// <summary>
        /// 
        /// </summary>
        public ModelOutputType(global::Dataloop.AnnotationType? value)
        {
            Annotation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelOutputType(global::Dataloop.ModelOutputTypeEnum value) => new ModelOutputType((global::Dataloop.ModelOutputTypeEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.ModelOutputTypeEnum?(ModelOutputType @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public ModelOutputType(global::Dataloop.ModelOutputTypeEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ModelOutputType(
            global::Dataloop.AnnotationType? annotation,
            global::Dataloop.ModelOutputTypeEnum? @enum
            )
        {
            Annotation = annotation;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            Annotation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Annotation?.ToValueString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnnotation || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dataloop.AnnotationType?, TResult>? annotation = null,
            global::System.Func<global::Dataloop.ModelOutputTypeEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnnotation && annotation != null)
            {
                return annotation(Annotation!);
            }
            else if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Dataloop.AnnotationType?>? annotation = null,
            global::System.Action<global::Dataloop.ModelOutputTypeEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnnotation)
            {
                annotation?.Invoke(Annotation!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Annotation,
                typeof(global::Dataloop.AnnotationType),
                Enum,
                typeof(global::Dataloop.ModelOutputTypeEnum),
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
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.AnnotationType?>.Default.Equals(Annotation, other.Annotation) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.ModelOutputTypeEnum?>.Default.Equals(Enum, other.Enum) 
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
