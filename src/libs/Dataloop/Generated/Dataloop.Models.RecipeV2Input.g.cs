#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RecipeV2Input : global::System.IEquatable<RecipeV2Input>
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntology? PickTitleOrProjectIdsOntology { get; init; }
#else
        public global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntology? PickTitleOrProjectIdsOntology { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PickTitleOrProjectIdsOntology))]
#endif
        public bool IsPickTitleOrProjectIdsOntology => PickTitleOrProjectIdsOntology != null;

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.PartialRecipeV2? Partial { get; init; }
#else
        public global::Dataloop.PartialRecipeV2? Partial { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Partial))]
#endif
        public bool IsPartial => Partial != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecipeV2Input(global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntology value) => new RecipeV2Input((global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntology?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntology?(RecipeV2Input @this) => @this.PickTitleOrProjectIdsOntology;

        /// <summary>
        /// 
        /// </summary>
        public RecipeV2Input(global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntology? value)
        {
            PickTitleOrProjectIdsOntology = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecipeV2Input(global::Dataloop.PartialRecipeV2 value) => new RecipeV2Input((global::Dataloop.PartialRecipeV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.PartialRecipeV2?(RecipeV2Input @this) => @this.Partial;

        /// <summary>
        /// 
        /// </summary>
        public RecipeV2Input(global::Dataloop.PartialRecipeV2? value)
        {
            Partial = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RecipeV2Input(
            global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntology? pickTitleOrProjectIdsOntology,
            global::Dataloop.PartialRecipeV2? partial
            )
        {
            PickTitleOrProjectIdsOntology = pickTitleOrProjectIdsOntology;
            Partial = partial;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Partial as object ??
            PickTitleOrProjectIdsOntology as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PickTitleOrProjectIdsOntology?.ToString() ??
            Partial?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPickTitleOrProjectIdsOntology && IsPartial;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntology?, TResult>? pickTitleOrProjectIdsOntology = null,
            global::System.Func<global::Dataloop.PartialRecipeV2?, TResult>? partial = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickTitleOrProjectIdsOntology && pickTitleOrProjectIdsOntology != null)
            {
                return pickTitleOrProjectIdsOntology(PickTitleOrProjectIdsOntology!);
            }
            else if (IsPartial && partial != null)
            {
                return partial(Partial!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntology?>? pickTitleOrProjectIdsOntology = null,
            global::System.Action<global::Dataloop.PartialRecipeV2?>? partial = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPickTitleOrProjectIdsOntology)
            {
                pickTitleOrProjectIdsOntology?.Invoke(PickTitleOrProjectIdsOntology!);
            }
            else if (IsPartial)
            {
                partial?.Invoke(Partial!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PickTitleOrProjectIdsOntology,
                typeof(global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntology),
                Partial,
                typeof(global::Dataloop.PartialRecipeV2),
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
        public bool Equals(RecipeV2Input other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.PickRecipeV2TitleOrProjectIdsOrOntology?>.Default.Equals(PickTitleOrProjectIdsOntology, other.PickTitleOrProjectIdsOntology) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.PartialRecipeV2?>.Default.Equals(Partial, other.Partial) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RecipeV2Input obj1, RecipeV2Input obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RecipeV2Input>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RecipeV2Input obj1, RecipeV2Input obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RecipeV2Input o && Equals(o);
        }
    }
}
