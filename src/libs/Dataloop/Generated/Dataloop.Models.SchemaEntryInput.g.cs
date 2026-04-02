#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SchemaEntryInput : global::System.IEquatable<SchemaEntryInput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.SchemaEntryInputVariant1? SchemaEntryInputVariant1 { get; init; }
#else
        public global::Dataloop.SchemaEntryInputVariant1? SchemaEntryInputVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SchemaEntryInputVariant1))]
#endif
        public bool IsSchemaEntryInputVariant1 => SchemaEntryInputVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>? SchemaEntryInputVariant2 { get; init; }
#else
        public global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>? SchemaEntryInputVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SchemaEntryInputVariant2))]
#endif
        public bool IsSchemaEntryInputVariant2 => SchemaEntryInputVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SchemaEntryInput(global::Dataloop.SchemaEntryInputVariant1 value) => new SchemaEntryInput((global::Dataloop.SchemaEntryInputVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.SchemaEntryInputVariant1?(SchemaEntryInput @this) => @this.SchemaEntryInputVariant1;

        /// <summary>
        /// 
        /// </summary>
        public SchemaEntryInput(global::Dataloop.SchemaEntryInputVariant1? value)
        {
            SchemaEntryInputVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SchemaEntryInput(global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2> value) => new SchemaEntryInput((global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>?(SchemaEntryInput @this) => @this.SchemaEntryInputVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SchemaEntryInput(global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>? value)
        {
            SchemaEntryInputVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SchemaEntryInput(
            global::Dataloop.SchemaEntryInputVariant1? schemaEntryInputVariant1,
            global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>? schemaEntryInputVariant2
            )
        {
            SchemaEntryInputVariant1 = schemaEntryInputVariant1;
            SchemaEntryInputVariant2 = schemaEntryInputVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SchemaEntryInputVariant2 as object ??
            SchemaEntryInputVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SchemaEntryInputVariant1?.ToString() ??
            SchemaEntryInputVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSchemaEntryInputVariant1 && IsSchemaEntryInputVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dataloop.SchemaEntryInputVariant1?, TResult>? schemaEntryInputVariant1 = null,
            global::System.Func<global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>?, TResult>? schemaEntryInputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSchemaEntryInputVariant1 && schemaEntryInputVariant1 != null)
            {
                return schemaEntryInputVariant1(SchemaEntryInputVariant1!);
            }
            else if (IsSchemaEntryInputVariant2 && schemaEntryInputVariant2 != null)
            {
                return schemaEntryInputVariant2(SchemaEntryInputVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Dataloop.SchemaEntryInputVariant1?>? schemaEntryInputVariant1 = null,
            global::System.Action<global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>?>? schemaEntryInputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSchemaEntryInputVariant1)
            {
                schemaEntryInputVariant1?.Invoke(SchemaEntryInputVariant1!);
            }
            else if (IsSchemaEntryInputVariant2)
            {
                schemaEntryInputVariant2?.Invoke(SchemaEntryInputVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SchemaEntryInputVariant1,
                typeof(global::Dataloop.SchemaEntryInputVariant1),
                SchemaEntryInputVariant2,
                typeof(global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>),
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
        public bool Equals(SchemaEntryInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.SchemaEntryInputVariant1?>.Default.Equals(SchemaEntryInputVariant1, other.SchemaEntryInputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.AnyOf<global::Dataloop.SchemaEntryInputVariant2Variant1, global::Dataloop.SchemaEntryInputVariant2Variant2>?>.Default.Equals(SchemaEntryInputVariant2, other.SchemaEntryInputVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SchemaEntryInput obj1, SchemaEntryInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SchemaEntryInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SchemaEntryInput obj1, SchemaEntryInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SchemaEntryInput o && Equals(o);
        }
    }
}
