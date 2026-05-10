#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CustomInstallation : global::System.IEquatable<CustomInstallation>
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.PickAPIDpkDependencies? PickAPIDpkDependencies { get; init; }
#else
        public global::Dataloop.PickAPIDpkDependencies? PickAPIDpkDependencies { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PickAPIDpkDependencies))]
#endif
        public bool IsPickAPIDpkDependencies => PickAPIDpkDependencies != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPickAPIDpkDependencies(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dataloop.PickAPIDpkDependencies? value)
        {
            value = PickAPIDpkDependencies;
            return IsPickAPIDpkDependencies;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.PickAPIDpkDependencies PickPickAPIDpkDependencies() => IsPickAPIDpkDependencies
            ? PickAPIDpkDependencies!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PickAPIDpkDependencies' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.CustomInstallationVariant2? CustomInstallationVariant2 { get; init; }
#else
        public global::Dataloop.CustomInstallationVariant2? CustomInstallationVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomInstallationVariant2))]
#endif
        public bool IsCustomInstallationVariant2 => CustomInstallationVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCustomInstallationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dataloop.CustomInstallationVariant2? value)
        {
            value = CustomInstallationVariant2;
            return IsCustomInstallationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.CustomInstallationVariant2 PickCustomInstallationVariant2() => IsCustomInstallationVariant2
            ? CustomInstallationVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomInstallationVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomInstallation(global::Dataloop.PickAPIDpkDependencies value) => new CustomInstallation((global::Dataloop.PickAPIDpkDependencies?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.PickAPIDpkDependencies?(CustomInstallation @this) => @this.PickAPIDpkDependencies;

        /// <summary>
        /// 
        /// </summary>
        public CustomInstallation(global::Dataloop.PickAPIDpkDependencies? value)
        {
            PickAPIDpkDependencies = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CustomInstallation FromPickAPIDpkDependencies(global::Dataloop.PickAPIDpkDependencies? value) => new CustomInstallation(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomInstallation(global::Dataloop.CustomInstallationVariant2 value) => new CustomInstallation((global::Dataloop.CustomInstallationVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.CustomInstallationVariant2?(CustomInstallation @this) => @this.CustomInstallationVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CustomInstallation(global::Dataloop.CustomInstallationVariant2? value)
        {
            CustomInstallationVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CustomInstallation FromCustomInstallationVariant2(global::Dataloop.CustomInstallationVariant2? value) => new CustomInstallation(value);

        /// <summary>
        /// 
        /// </summary>
        public CustomInstallation(
            global::Dataloop.PickAPIDpkDependencies? pickAPIDpkDependencies,
            global::Dataloop.CustomInstallationVariant2? customInstallationVariant2
            )
        {
            PickAPIDpkDependencies = pickAPIDpkDependencies;
            CustomInstallationVariant2 = customInstallationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomInstallationVariant2 as object ??
            PickAPIDpkDependencies as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PickAPIDpkDependencies?.ToString() ??
            CustomInstallationVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPickAPIDpkDependencies && IsCustomInstallationVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dataloop.PickAPIDpkDependencies, TResult>? pickAPIDpkDependencies = null,
            global::System.Func<global::Dataloop.CustomInstallationVariant2, TResult>? customInstallationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickAPIDpkDependencies && pickAPIDpkDependencies != null)
            {
                return pickAPIDpkDependencies(PickAPIDpkDependencies!);
            }
            else if (IsCustomInstallationVariant2 && customInstallationVariant2 != null)
            {
                return customInstallationVariant2(CustomInstallationVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Dataloop.PickAPIDpkDependencies>? pickAPIDpkDependencies = null,

            global::System.Action<global::Dataloop.CustomInstallationVariant2>? customInstallationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickAPIDpkDependencies)
            {
                pickAPIDpkDependencies?.Invoke(PickAPIDpkDependencies!);
            }
            else if (IsCustomInstallationVariant2)
            {
                customInstallationVariant2?.Invoke(CustomInstallationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Dataloop.PickAPIDpkDependencies>? pickAPIDpkDependencies = null,
            global::System.Action<global::Dataloop.CustomInstallationVariant2>? customInstallationVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickAPIDpkDependencies)
            {
                pickAPIDpkDependencies?.Invoke(PickAPIDpkDependencies!);
            }
            else if (IsCustomInstallationVariant2)
            {
                customInstallationVariant2?.Invoke(CustomInstallationVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PickAPIDpkDependencies,
                typeof(global::Dataloop.PickAPIDpkDependencies),
                CustomInstallationVariant2,
                typeof(global::Dataloop.CustomInstallationVariant2),
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
        public bool Equals(CustomInstallation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.PickAPIDpkDependencies?>.Default.Equals(PickAPIDpkDependencies, other.PickAPIDpkDependencies) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.CustomInstallationVariant2?>.Default.Equals(CustomInstallationVariant2, other.CustomInstallationVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CustomInstallation obj1, CustomInstallation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CustomInstallation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CustomInstallation obj1, CustomInstallation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CustomInstallation o && Equals(o);
        }
    }
}
