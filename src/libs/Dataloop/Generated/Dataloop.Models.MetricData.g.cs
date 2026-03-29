#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MetricData : global::System.IEquatable<MetricData>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.LineData? Line { get; init; }
#else
        public global::Dataloop.LineData? Line { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Line))]
#endif
        public bool IsLine => Line != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.MatrixData? Matrix { get; init; }
#else
        public global::Dataloop.MatrixData? Matrix { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Matrix))]
#endif
        public bool IsMatrix => Matrix != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.SummaryData? Summary { get; init; }
#else
        public global::Dataloop.SummaryData? Summary { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Summary))]
#endif
        public bool IsSummary => Summary != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetricData(global::Dataloop.LineData value) => new MetricData((global::Dataloop.LineData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.LineData?(MetricData @this) => @this.Line;

        /// <summary>
        /// 
        /// </summary>
        public MetricData(global::Dataloop.LineData? value)
        {
            Line = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetricData(global::Dataloop.MatrixData value) => new MetricData((global::Dataloop.MatrixData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.MatrixData?(MetricData @this) => @this.Matrix;

        /// <summary>
        /// 
        /// </summary>
        public MetricData(global::Dataloop.MatrixData? value)
        {
            Matrix = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetricData(global::Dataloop.SummaryData value) => new MetricData((global::Dataloop.SummaryData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.SummaryData?(MetricData @this) => @this.Summary;

        /// <summary>
        /// 
        /// </summary>
        public MetricData(global::Dataloop.SummaryData? value)
        {
            Summary = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MetricData(
            global::Dataloop.LineData? line,
            global::Dataloop.MatrixData? matrix,
            global::Dataloop.SummaryData? summary
            )
        {
            Line = line;
            Matrix = matrix;
            Summary = summary;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Summary as object ??
            Matrix as object ??
            Line as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Line?.ToString() ??
            Matrix?.ToString() ??
            Summary?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLine || IsMatrix || IsSummary;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dataloop.LineData?, TResult>? line = null,
            global::System.Func<global::Dataloop.MatrixData?, TResult>? matrix = null,
            global::System.Func<global::Dataloop.SummaryData?, TResult>? summary = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLine && line != null)
            {
                return line(Line!);
            }
            else if (IsMatrix && matrix != null)
            {
                return matrix(Matrix!);
            }
            else if (IsSummary && summary != null)
            {
                return summary(Summary!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Dataloop.LineData?>? line = null,
            global::System.Action<global::Dataloop.MatrixData?>? matrix = null,
            global::System.Action<global::Dataloop.SummaryData?>? summary = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLine)
            {
                line?.Invoke(Line!);
            }
            else if (IsMatrix)
            {
                matrix?.Invoke(Matrix!);
            }
            else if (IsSummary)
            {
                summary?.Invoke(Summary!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Line,
                typeof(global::Dataloop.LineData),
                Matrix,
                typeof(global::Dataloop.MatrixData),
                Summary,
                typeof(global::Dataloop.SummaryData),
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
        public bool Equals(MetricData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.LineData?>.Default.Equals(Line, other.Line) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.MatrixData?>.Default.Equals(Matrix, other.Matrix) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.SummaryData?>.Default.Equals(Summary, other.Summary) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MetricData obj1, MetricData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MetricData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MetricData obj1, MetricData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MetricData o && Equals(o);
        }
    }
}
