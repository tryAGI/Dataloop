#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AppMetadata : global::System.IEquatable<AppMetadata>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.EntityReferenceMetadata? EntityReference { get; init; }
#else
        public global::Dataloop.EntityReferenceMetadata? EntityReference { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EntityReference))]
#endif
        public bool IsEntityReference => EntityReference != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.AppMetadataVariant2? AppMetadataVariant2 { get; init; }
#else
        public global::Dataloop.AppMetadataVariant2? AppMetadataVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppMetadataVariant2))]
#endif
        public bool IsAppMetadataVariant2 => AppMetadataVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AppMetadata(global::Dataloop.EntityReferenceMetadata value) => new AppMetadata((global::Dataloop.EntityReferenceMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.EntityReferenceMetadata?(AppMetadata @this) => @this.EntityReference;

        /// <summary>
        /// 
        /// </summary>
        public AppMetadata(global::Dataloop.EntityReferenceMetadata? value)
        {
            EntityReference = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AppMetadata(global::Dataloop.AppMetadataVariant2 value) => new AppMetadata((global::Dataloop.AppMetadataVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.AppMetadataVariant2?(AppMetadata @this) => @this.AppMetadataVariant2;

        /// <summary>
        /// 
        /// </summary>
        public AppMetadata(global::Dataloop.AppMetadataVariant2? value)
        {
            AppMetadataVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AppMetadata(
            global::Dataloop.EntityReferenceMetadata? entityReference,
            global::Dataloop.AppMetadataVariant2? appMetadataVariant2
            )
        {
            EntityReference = entityReference;
            AppMetadataVariant2 = appMetadataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AppMetadataVariant2 as object ??
            EntityReference as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EntityReference?.ToString() ??
            AppMetadataVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEntityReference && IsAppMetadataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dataloop.EntityReferenceMetadata?, TResult>? entityReference = null,
            global::System.Func<global::Dataloop.AppMetadataVariant2?, TResult>? appMetadataVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEntityReference && entityReference != null)
            {
                return entityReference(EntityReference!);
            }
            else if (IsAppMetadataVariant2 && appMetadataVariant2 != null)
            {
                return appMetadataVariant2(AppMetadataVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Dataloop.EntityReferenceMetadata?>? entityReference = null,
            global::System.Action<global::Dataloop.AppMetadataVariant2?>? appMetadataVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEntityReference)
            {
                entityReference?.Invoke(EntityReference!);
            }
            else if (IsAppMetadataVariant2)
            {
                appMetadataVariant2?.Invoke(AppMetadataVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EntityReference,
                typeof(global::Dataloop.EntityReferenceMetadata),
                AppMetadataVariant2,
                typeof(global::Dataloop.AppMetadataVariant2),
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
        public bool Equals(AppMetadata other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.EntityReferenceMetadata?>.Default.Equals(EntityReference, other.EntityReference) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.AppMetadataVariant2?>.Default.Equals(AppMetadataVariant2, other.AppMetadataVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AppMetadata obj1, AppMetadata obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AppMetadata>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AppMetadata obj1, AppMetadata obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AppMetadata o && Equals(o);
        }
    }
}
