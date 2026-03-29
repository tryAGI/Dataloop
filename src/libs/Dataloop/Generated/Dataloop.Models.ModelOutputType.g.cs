#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ModelOutputType : global::System.IEquatable<ModelOutputType>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.AnnotationType? Value1 { get; init; }
#else
        public global::Dataloop.AnnotationType? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.ModelOutputTypeVariant2? Value2 { get; init; }
#else
        public global::Dataloop.ModelOutputTypeVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.AnnotationType? Value3 { get; init; }
#else
        public global::Dataloop.AnnotationType? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.ModelOutputTypeVariant4? Value4 { get; init; }
#else
        public global::Dataloop.ModelOutputTypeVariant4? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelOutputType(global::Dataloop.AnnotationType value) => new ModelOutputType((global::Dataloop.AnnotationType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.AnnotationType?(ModelOutputType @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ModelOutputType(global::Dataloop.AnnotationType? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelOutputType(global::Dataloop.ModelOutputTypeVariant2 value) => new ModelOutputType((global::Dataloop.ModelOutputTypeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.ModelOutputTypeVariant2?(ModelOutputType @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ModelOutputType(global::Dataloop.ModelOutputTypeVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelOutputType(global::Dataloop.ModelOutputTypeVariant4 value) => new ModelOutputType((global::Dataloop.ModelOutputTypeVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.ModelOutputTypeVariant4?(ModelOutputType @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public ModelOutputType(global::Dataloop.ModelOutputTypeVariant4? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ModelOutputType(
            global::Dataloop.AnnotationType? value1,
            global::Dataloop.ModelOutputTypeVariant2? value2,
            global::Dataloop.AnnotationType? value3,
            global::Dataloop.ModelOutputTypeVariant4? value4
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToValueString() ??
            Value2?.ToValueString() ??
            Value3?.ToValueString() ??
            Value4?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3 || IsValue4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dataloop.AnnotationType?, TResult>? value1 = null,
            global::System.Func<global::Dataloop.ModelOutputTypeVariant2?, TResult>? value2 = null,
            global::System.Func<global::Dataloop.AnnotationType?, TResult>? value3 = null,
            global::System.Func<global::Dataloop.ModelOutputTypeVariant4?, TResult>? value4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Dataloop.AnnotationType?>? value1 = null,
            global::System.Action<global::Dataloop.ModelOutputTypeVariant2?>? value2 = null,
            global::System.Action<global::Dataloop.AnnotationType?>? value3 = null,
            global::System.Action<global::Dataloop.ModelOutputTypeVariant4?>? value4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::Dataloop.AnnotationType),
                Value2,
                typeof(global::Dataloop.ModelOutputTypeVariant2),
                Value3,
                typeof(global::Dataloop.AnnotationType),
                Value4,
                typeof(global::Dataloop.ModelOutputTypeVariant4),
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
        public bool Equals(ModelOutputType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.AnnotationType?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.ModelOutputTypeVariant2?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.AnnotationType?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.ModelOutputTypeVariant4?>.Default.Equals(Value4, other.Value4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ModelOutputType obj1, ModelOutputType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ModelOutputType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ModelOutputType obj1, ModelOutputType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelOutputType o && Equals(o);
        }
    }
}
