#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MigrationSpec : global::System.IEquatable<MigrationSpec>
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
        public global::Dataloop.MigrationSpecVariant2? MigrationSpecVariant2 { get; init; }
#else
        public global::Dataloop.MigrationSpecVariant2? MigrationSpecVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MigrationSpecVariant2))]
#endif
        public bool IsMigrationSpecVariant2 => MigrationSpecVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MigrationSpec(global::Dataloop.Dictionary value) => new MigrationSpec((global::Dataloop.Dictionary?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.Dictionary?(MigrationSpec @this) => @this.Dictionary;

        /// <summary>
        /// 
        /// </summary>
        public MigrationSpec(global::Dataloop.Dictionary? value)
        {
            Dictionary = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MigrationSpec(global::Dataloop.MigrationSpecVariant2 value) => new MigrationSpec((global::Dataloop.MigrationSpecVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.MigrationSpecVariant2?(MigrationSpec @this) => @this.MigrationSpecVariant2;

        /// <summary>
        /// 
        /// </summary>
        public MigrationSpec(global::Dataloop.MigrationSpecVariant2? value)
        {
            MigrationSpecVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MigrationSpec(
            global::Dataloop.Dictionary? dictionary,
            global::Dataloop.MigrationSpecVariant2? migrationSpecVariant2
            )
        {
            Dictionary = dictionary;
            MigrationSpecVariant2 = migrationSpecVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MigrationSpecVariant2 as object ??
            Dictionary as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Dictionary?.ToString() ??
            MigrationSpecVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDictionary && IsMigrationSpecVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dataloop.Dictionary?, TResult>? dictionary = null,
            global::System.Func<global::Dataloop.MigrationSpecVariant2?, TResult>? migrationSpecVariant2 = null,
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
            else if (IsMigrationSpecVariant2 && migrationSpecVariant2 != null)
            {
                return migrationSpecVariant2(MigrationSpecVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Dataloop.Dictionary?>? dictionary = null,
            global::System.Action<global::Dataloop.MigrationSpecVariant2?>? migrationSpecVariant2 = null,
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
            else if (IsMigrationSpecVariant2)
            {
                migrationSpecVariant2?.Invoke(MigrationSpecVariant2!);
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
                MigrationSpecVariant2,
                typeof(global::Dataloop.MigrationSpecVariant2),
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
        public bool Equals(MigrationSpec other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.Dictionary?>.Default.Equals(Dictionary, other.Dictionary) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.MigrationSpecVariant2?>.Default.Equals(MigrationSpecVariant2, other.MigrationSpecVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MigrationSpec obj1, MigrationSpec obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MigrationSpec>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MigrationSpec obj1, MigrationSpec obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MigrationSpec o && Equals(o);
        }
    }
}
