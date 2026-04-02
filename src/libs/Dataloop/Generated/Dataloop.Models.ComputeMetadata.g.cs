#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ComputeMetadata : global::System.IEquatable<ComputeMetadata>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.Dictionary? Dictionary { get; init; }
#else
        public global::Dataloop.Dictionary? Dictionary { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dictionary))]
#endif
        public bool IsDictionary => Dictionary != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.ComputeMetadataVariant2? ComputeMetadataVariant2 { get; init; }
#else
        public global::Dataloop.ComputeMetadataVariant2? ComputeMetadataVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputeMetadataVariant2))]
#endif
        public bool IsComputeMetadataVariant2 => ComputeMetadataVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputeMetadata(global::Dataloop.Dictionary value) => new ComputeMetadata((global::Dataloop.Dictionary?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.Dictionary?(ComputeMetadata @this) => @this.Dictionary;

        /// <summary>
        /// 
        /// </summary>
        public ComputeMetadata(global::Dataloop.Dictionary? value)
        {
            Dictionary = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputeMetadata(global::Dataloop.ComputeMetadataVariant2 value) => new ComputeMetadata((global::Dataloop.ComputeMetadataVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.ComputeMetadataVariant2?(ComputeMetadata @this) => @this.ComputeMetadataVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ComputeMetadata(global::Dataloop.ComputeMetadataVariant2? value)
        {
            ComputeMetadataVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ComputeMetadata(
            global::Dataloop.Dictionary? dictionary,
            global::Dataloop.ComputeMetadataVariant2? computeMetadataVariant2
            )
        {
            Dictionary = dictionary;
            ComputeMetadataVariant2 = computeMetadataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ComputeMetadataVariant2 as object ??
            Dictionary as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Dictionary?.ToString() ??
            ComputeMetadataVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDictionary && IsComputeMetadataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dataloop.Dictionary?, TResult>? dictionary = null,
            global::System.Func<global::Dataloop.ComputeMetadataVariant2?, TResult>? computeMetadataVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDictionary && dictionary != null)
            {
                return dictionary(Dictionary!);
            }
            else if (IsComputeMetadataVariant2 && computeMetadataVariant2 != null)
            {
                return computeMetadataVariant2(ComputeMetadataVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Dataloop.Dictionary?>? dictionary = null,
            global::System.Action<global::Dataloop.ComputeMetadataVariant2?>? computeMetadataVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDictionary)
            {
                dictionary?.Invoke(Dictionary!);
            }
            else if (IsComputeMetadataVariant2)
            {
                computeMetadataVariant2?.Invoke(ComputeMetadataVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Dictionary,
                typeof(global::Dataloop.Dictionary),
                ComputeMetadataVariant2,
                typeof(global::Dataloop.ComputeMetadataVariant2),
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
        public bool Equals(ComputeMetadata other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.Dictionary?>.Default.Equals(Dictionary, other.Dictionary) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.ComputeMetadataVariant2?>.Default.Equals(ComputeMetadataVariant2, other.ComputeMetadataVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ComputeMetadata obj1, ComputeMetadata obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ComputeMetadata>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ComputeMetadata obj1, ComputeMetadata obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ComputeMetadata o && Equals(o);
        }
    }
}
