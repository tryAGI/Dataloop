#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BenchmarkMode : global::System.IEquatable<BenchmarkMode>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.OneByOneLatencyBenchmarkMode? OneByLatency { get; init; }
#else
        public global::Dataloop.OneByOneLatencyBenchmarkMode? OneByLatency { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OneByLatency))]
#endif
        public bool IsOneByLatency => OneByLatency != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.ProfilingBenchmarkMode? Profiling { get; init; }
#else
        public global::Dataloop.ProfilingBenchmarkMode? Profiling { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Profiling))]
#endif
        public bool IsProfiling => Profiling != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.ConcurrencyBenchmarkMode? Concurrency { get; init; }
#else
        public global::Dataloop.ConcurrencyBenchmarkMode? Concurrency { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Concurrency))]
#endif
        public bool IsConcurrency => Concurrency != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BenchmarkMode(global::Dataloop.OneByOneLatencyBenchmarkMode value) => new BenchmarkMode((global::Dataloop.OneByOneLatencyBenchmarkMode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.OneByOneLatencyBenchmarkMode?(BenchmarkMode @this) => @this.OneByLatency;

        /// <summary>
        /// 
        /// </summary>
        public BenchmarkMode(global::Dataloop.OneByOneLatencyBenchmarkMode? value)
        {
            OneByLatency = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BenchmarkMode(global::Dataloop.ProfilingBenchmarkMode value) => new BenchmarkMode((global::Dataloop.ProfilingBenchmarkMode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.ProfilingBenchmarkMode?(BenchmarkMode @this) => @this.Profiling;

        /// <summary>
        /// 
        /// </summary>
        public BenchmarkMode(global::Dataloop.ProfilingBenchmarkMode? value)
        {
            Profiling = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BenchmarkMode(global::Dataloop.ConcurrencyBenchmarkMode value) => new BenchmarkMode((global::Dataloop.ConcurrencyBenchmarkMode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.ConcurrencyBenchmarkMode?(BenchmarkMode @this) => @this.Concurrency;

        /// <summary>
        /// 
        /// </summary>
        public BenchmarkMode(global::Dataloop.ConcurrencyBenchmarkMode? value)
        {
            Concurrency = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BenchmarkMode(
            global::Dataloop.OneByOneLatencyBenchmarkMode? oneByLatency,
            global::Dataloop.ProfilingBenchmarkMode? profiling,
            global::Dataloop.ConcurrencyBenchmarkMode? concurrency
            )
        {
            OneByLatency = oneByLatency;
            Profiling = profiling;
            Concurrency = concurrency;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Concurrency as object ??
            Profiling as object ??
            OneByLatency as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OneByLatency?.ToString() ??
            Profiling?.ToString() ??
            Concurrency?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOneByLatency || IsProfiling || IsConcurrency;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dataloop.OneByOneLatencyBenchmarkMode?, TResult>? oneByLatency = null,
            global::System.Func<global::Dataloop.ProfilingBenchmarkMode?, TResult>? profiling = null,
            global::System.Func<global::Dataloop.ConcurrencyBenchmarkMode?, TResult>? concurrency = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOneByLatency && oneByLatency != null)
            {
                return oneByLatency(OneByLatency!);
            }
            else if (IsProfiling && profiling != null)
            {
                return profiling(Profiling!);
            }
            else if (IsConcurrency && concurrency != null)
            {
                return concurrency(Concurrency!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Dataloop.OneByOneLatencyBenchmarkMode?>? oneByLatency = null,
            global::System.Action<global::Dataloop.ProfilingBenchmarkMode?>? profiling = null,
            global::System.Action<global::Dataloop.ConcurrencyBenchmarkMode?>? concurrency = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOneByLatency)
            {
                oneByLatency?.Invoke(OneByLatency!);
            }
            else if (IsProfiling)
            {
                profiling?.Invoke(Profiling!);
            }
            else if (IsConcurrency)
            {
                concurrency?.Invoke(Concurrency!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OneByLatency,
                typeof(global::Dataloop.OneByOneLatencyBenchmarkMode),
                Profiling,
                typeof(global::Dataloop.ProfilingBenchmarkMode),
                Concurrency,
                typeof(global::Dataloop.ConcurrencyBenchmarkMode),
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
        public bool Equals(BenchmarkMode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.OneByOneLatencyBenchmarkMode?>.Default.Equals(OneByLatency, other.OneByLatency) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.ProfilingBenchmarkMode?>.Default.Equals(Profiling, other.Profiling) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.ConcurrencyBenchmarkMode?>.Default.Equals(Concurrency, other.Concurrency) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BenchmarkMode obj1, BenchmarkMode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BenchmarkMode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BenchmarkMode obj1, BenchmarkMode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BenchmarkMode o && Equals(o);
        }
    }
}
