#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RemoveSettingTraceMigrationSpec : global::System.IEquatable<RemoveSettingTraceMigrationSpec>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.MigrationSpec? MigrationSpec { get; init; }
#else
        public global::Dataloop.MigrationSpec? MigrationSpec { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MigrationSpec))]
#endif
        public bool IsMigrationSpec => MigrationSpec != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.RemoveSettingTraceMigrationSpecVariant2? RemoveSettingTraceMigrationSpecVariant2 { get; init; }
#else
        public global::Dataloop.RemoveSettingTraceMigrationSpecVariant2? RemoveSettingTraceMigrationSpecVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RemoveSettingTraceMigrationSpecVariant2))]
#endif
        public bool IsRemoveSettingTraceMigrationSpecVariant2 => RemoveSettingTraceMigrationSpecVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RemoveSettingTraceMigrationSpec(global::Dataloop.MigrationSpec value) => new RemoveSettingTraceMigrationSpec((global::Dataloop.MigrationSpec?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.MigrationSpec?(RemoveSettingTraceMigrationSpec @this) => @this.MigrationSpec;

        /// <summary>
        /// 
        /// </summary>
        public RemoveSettingTraceMigrationSpec(global::Dataloop.MigrationSpec? value)
        {
            MigrationSpec = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RemoveSettingTraceMigrationSpec(global::Dataloop.RemoveSettingTraceMigrationSpecVariant2 value) => new RemoveSettingTraceMigrationSpec((global::Dataloop.RemoveSettingTraceMigrationSpecVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.RemoveSettingTraceMigrationSpecVariant2?(RemoveSettingTraceMigrationSpec @this) => @this.RemoveSettingTraceMigrationSpecVariant2;

        /// <summary>
        /// 
        /// </summary>
        public RemoveSettingTraceMigrationSpec(global::Dataloop.RemoveSettingTraceMigrationSpecVariant2? value)
        {
            RemoveSettingTraceMigrationSpecVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RemoveSettingTraceMigrationSpec(
            global::Dataloop.MigrationSpec? migrationSpec,
            global::Dataloop.RemoveSettingTraceMigrationSpecVariant2? removeSettingTraceMigrationSpecVariant2
            )
        {
            MigrationSpec = migrationSpec;
            RemoveSettingTraceMigrationSpecVariant2 = removeSettingTraceMigrationSpecVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RemoveSettingTraceMigrationSpecVariant2 as object ??
            MigrationSpec as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MigrationSpec?.ToString() ??
            RemoveSettingTraceMigrationSpecVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMigrationSpec && IsRemoveSettingTraceMigrationSpecVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dataloop.MigrationSpec?, TResult>? migrationSpec = null,
            global::System.Func<global::Dataloop.RemoveSettingTraceMigrationSpecVariant2?, TResult>? removeSettingTraceMigrationSpecVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMigrationSpec && migrationSpec != null)
            {
                return migrationSpec(MigrationSpec!);
            }
            else if (IsRemoveSettingTraceMigrationSpecVariant2 && removeSettingTraceMigrationSpecVariant2 != null)
            {
                return removeSettingTraceMigrationSpecVariant2(RemoveSettingTraceMigrationSpecVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Dataloop.MigrationSpec?>? migrationSpec = null,
            global::System.Action<global::Dataloop.RemoveSettingTraceMigrationSpecVariant2?>? removeSettingTraceMigrationSpecVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMigrationSpec)
            {
                migrationSpec?.Invoke(MigrationSpec!);
            }
            else if (IsRemoveSettingTraceMigrationSpecVariant2)
            {
                removeSettingTraceMigrationSpecVariant2?.Invoke(RemoveSettingTraceMigrationSpecVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MigrationSpec,
                typeof(global::Dataloop.MigrationSpec),
                RemoveSettingTraceMigrationSpecVariant2,
                typeof(global::Dataloop.RemoveSettingTraceMigrationSpecVariant2),
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
        public bool Equals(RemoveSettingTraceMigrationSpec other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.MigrationSpec?>.Default.Equals(MigrationSpec, other.MigrationSpec) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.RemoveSettingTraceMigrationSpecVariant2?>.Default.Equals(RemoveSettingTraceMigrationSpecVariant2, other.RemoveSettingTraceMigrationSpecVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RemoveSettingTraceMigrationSpec obj1, RemoveSettingTraceMigrationSpec obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RemoveSettingTraceMigrationSpec>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RemoveSettingTraceMigrationSpec obj1, RemoveSettingTraceMigrationSpec obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RemoveSettingTraceMigrationSpec o && Equals(o);
        }
    }
}
