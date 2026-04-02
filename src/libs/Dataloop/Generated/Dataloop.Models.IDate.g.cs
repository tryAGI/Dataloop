#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IDate : global::System.IEquatable<IDate>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.DateTime? Time { get; init; }
#else
        public global::System.DateTime? Time { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Time))]
#endif
        public bool IsTime => Time != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? IDateVariant2 { get; init; }
#else
        public double? IDateVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IDateVariant2))]
#endif
        public bool IsIDateVariant2 => IDateVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? IDateVariant3 { get; init; }
#else
        public string? IDateVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IDateVariant3))]
#endif
        public bool IsIDateVariant3 => IDateVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IDate(global::System.DateTime value) => new IDate((global::System.DateTime?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.DateTime?(IDate @this) => @this.Time;

        /// <summary>
        /// 
        /// </summary>
        public IDate(global::System.DateTime? value)
        {
            Time = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IDate(double value) => new IDate((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(IDate @this) => @this.IDateVariant2;

        /// <summary>
        /// 
        /// </summary>
        public IDate(double? value)
        {
            IDateVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IDate(string value) => new IDate((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(IDate @this) => @this.IDateVariant3;

        /// <summary>
        /// 
        /// </summary>
        public IDate(string? value)
        {
            IDateVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IDate(
            global::System.DateTime? time,
            double? iDateVariant2,
            string? iDateVariant3
            )
        {
            Time = time;
            IDateVariant2 = iDateVariant2;
            IDateVariant3 = iDateVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            IDateVariant3 as object ??
            IDateVariant2 as object ??
            Time as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Time?.ToString() ??
            IDateVariant2?.ToString() ??
            IDateVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTime || IsIDateVariant2 || IsIDateVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.DateTime?, TResult>? time = null,
            global::System.Func<double?, TResult>? iDateVariant2 = null,
            global::System.Func<string?, TResult>? iDateVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTime && time != null)
            {
                return time(Time!);
            }
            else if (IsIDateVariant2 && iDateVariant2 != null)
            {
                return iDateVariant2(IDateVariant2!);
            }
            else if (IsIDateVariant3 && iDateVariant3 != null)
            {
                return iDateVariant3(IDateVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.DateTime?>? time = null,
            global::System.Action<double?>? iDateVariant2 = null,
            global::System.Action<string?>? iDateVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTime)
            {
                time?.Invoke(Time!);
            }
            else if (IsIDateVariant2)
            {
                iDateVariant2?.Invoke(IDateVariant2!);
            }
            else if (IsIDateVariant3)
            {
                iDateVariant3?.Invoke(IDateVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Time,
                typeof(global::System.DateTime),
                IDateVariant2,
                typeof(double),
                IDateVariant3,
                typeof(string),
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
        public bool Equals(IDate other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.DateTime?>.Default.Equals(Time, other.Time) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(IDateVariant2, other.IDateVariant2) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(IDateVariant3, other.IDateVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IDate obj1, IDate obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IDate>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IDate obj1, IDate obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IDate o && Equals(o);
        }
    }
}
