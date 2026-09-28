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
        public bool TryPickOneByLatency(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dataloop.OneByOneLatencyBenchmarkMode? value)
        {
            value = OneByLatency;
            return IsOneByLatency;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Dataloop.OneByOneLatencyBenchmarkMode PickOneByLatency() => OneByLatency is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OneByLatency' but the value was {ToString()}.");

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
        public bool TryPickProfiling(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dataloop.ProfilingBenchmarkMode? value)
        {
            value = Profiling;
            return IsProfiling;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Dataloop.ProfilingBenchmarkMode PickProfiling() => Profiling is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Profiling' but the value was {ToString()}.");

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
        public bool TryPickConcurrency(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dataloop.ConcurrencyBenchmarkMode? value)
        {
            value = Concurrency;
            return IsConcurrency;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Dataloop.ConcurrencyBenchmarkMode PickConcurrency() => Concurrency is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Concurrency' but the value was {ToString()}.");
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
        public static BenchmarkMode FromOneByLatency(global::Dataloop.OneByOneLatencyBenchmarkMode? value) => new BenchmarkMode(value);

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
        public static BenchmarkMode FromProfiling(global::Dataloop.ProfilingBenchmarkMode? value) => new BenchmarkMode(value);

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
        public static BenchmarkMode FromConcurrency(global::Dataloop.ConcurrencyBenchmarkMode? value) => new BenchmarkMode(value);

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
            global::System.Func<global::Dataloop.OneByOneLatencyBenchmarkMode, TResult>? oneByLatency = null,
            global::System.Func<global::Dataloop.ProfilingBenchmarkMode, TResult>? profiling = null,
            global::System.Func<global::Dataloop.ConcurrencyBenchmarkMode, TResult>? concurrency = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OneByLatency is { } __value0 && oneByLatency != null)
            {
                return oneByLatency(__value0);
            }
            else if (Profiling is { } __value1 && profiling != null)
            {
                return profiling(__value1);
            }
            else if (Concurrency is { } __value2 && concurrency != null)
            {
                return concurrency(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Dataloop.OneByOneLatencyBenchmarkMode>? oneByLatency = null,

            global::System.Action<global::Dataloop.ProfilingBenchmarkMode>? profiling = null,

            global::System.Action<global::Dataloop.ConcurrencyBenchmarkMode>? concurrency = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OneByLatency is { } __value0)
            {
                oneByLatency?.Invoke(__value0);
            }
            else if (Profiling is { } __value1)
            {
                profiling?.Invoke(__value1);
            }
            else if (Concurrency is { } __value2)
            {
                concurrency?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Dataloop.OneByOneLatencyBenchmarkMode>? oneByLatency = null,
            global::System.Action<global::Dataloop.ProfilingBenchmarkMode>? profiling = null,
            global::System.Action<global::Dataloop.ConcurrencyBenchmarkMode>? concurrency = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OneByLatency is { } __value0)
            {
                oneByLatency?.Invoke(__value0);
            }
            else if (Profiling is { } __value1)
            {
                profiling?.Invoke(__value1);
            }
            else if (Concurrency is { } __value2)
            {
                concurrency?.Invoke(__value2);
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
