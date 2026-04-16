#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dataloop
{
    /// <summary>
    /// Monitoring plugin spec: Kubernetes manifest overrides plus optional Prometheus placement.<br/>
    /// `prometheusNodePoolName` must match an entry in cluster.nodePools; its nodeSelector/tolerations<br/>
    /// are applied to the Prometheus Deployment and override the pool marked isMonitoringConfiguration.
    /// </summary>
    public readonly partial struct ComputePluginSpec : global::System.IEquatable<ComputePluginSpec>
    {
        /// <summary>
        /// Per-resource overrides (key = metadata.name + kind, e.g. prometheusDeployment).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2>? ResourceManifests { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2>? ResourceManifests { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResourceManifests))]
#endif
        public bool IsResourceManifests => ResourceManifests != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.ComputePluginSpecVariant2? ComputePluginSpecVariant2 { get; init; }
#else
        public global::Dataloop.ComputePluginSpecVariant2? ComputePluginSpecVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputePluginSpecVariant2))]
#endif
        public bool IsComputePluginSpecVariant2 => ComputePluginSpecVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputePluginSpec(global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2> value) => new ComputePluginSpec((global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2>?(ComputePluginSpec @this) => @this.ResourceManifests;

        /// <summary>
        /// 
        /// </summary>
        public ComputePluginSpec(global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2>? value)
        {
            ResourceManifests = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ComputePluginSpec(global::Dataloop.ComputePluginSpecVariant2 value) => new ComputePluginSpec((global::Dataloop.ComputePluginSpecVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.ComputePluginSpecVariant2?(ComputePluginSpec @this) => @this.ComputePluginSpecVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ComputePluginSpec(global::Dataloop.ComputePluginSpecVariant2? value)
        {
            ComputePluginSpecVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ComputePluginSpec(
            global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2>? resourceManifests,
            global::Dataloop.ComputePluginSpecVariant2? computePluginSpecVariant2
            )
        {
            ResourceManifests = resourceManifests;
            ComputePluginSpecVariant2 = computePluginSpecVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ComputePluginSpecVariant2 as object ??
            ResourceManifests as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResourceManifests?.ToString() ??
            ComputePluginSpecVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResourceManifests && IsComputePluginSpecVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2>?, TResult>? resourceManifests = null,
            global::System.Func<global::Dataloop.ComputePluginSpecVariant2?, TResult>? computePluginSpecVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResourceManifests && resourceManifests != null)
            {
                return resourceManifests(ResourceManifests!);
            }
            else if (IsComputePluginSpecVariant2 && computePluginSpecVariant2 != null)
            {
                return computePluginSpecVariant2(ComputePluginSpecVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2>?>? resourceManifests = null,
            global::System.Action<global::Dataloop.ComputePluginSpecVariant2?>? computePluginSpecVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResourceManifests)
            {
                resourceManifests?.Invoke(ResourceManifests!);
            }
            else if (IsComputePluginSpecVariant2)
            {
                computePluginSpecVariant2?.Invoke(ComputePluginSpecVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResourceManifests,
                typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2>),
                ComputePluginSpecVariant2,
                typeof(global::Dataloop.ComputePluginSpecVariant2),
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
        public bool Equals(ComputePluginSpec other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::Dataloop.ComputePluginResourceManifests2>?>.Default.Equals(ResourceManifests, other.ResourceManifests) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.ComputePluginSpecVariant2?>.Default.Equals(ComputePluginSpecVariant2, other.ComputePluginSpecVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ComputePluginSpec obj1, ComputePluginSpec obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ComputePluginSpec>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ComputePluginSpec obj1, ComputePluginSpec obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ComputePluginSpec o && Equals(o);
        }
    }
}
