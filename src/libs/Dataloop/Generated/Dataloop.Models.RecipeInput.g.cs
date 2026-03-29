#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RecipeInput : global::System.IEquatable<RecipeInput>
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.PickRecipeTitleOrProjectIdsOrOntologyIds? PickTitleOrProjectIdsOntology { get; init; }
#else
        public global::Dataloop.PickRecipeTitleOrProjectIdsOrOntologyIds? PickTitleOrProjectIdsOntology { get; }
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
        public global::Dataloop.PartialRecipe? Partial { get; init; }
#else
        public global::Dataloop.PartialRecipe? Partial { get; }
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
        public static implicit operator RecipeInput(global::Dataloop.PickRecipeTitleOrProjectIdsOrOntologyIds value) => new RecipeInput((global::Dataloop.PickRecipeTitleOrProjectIdsOrOntologyIds?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.PickRecipeTitleOrProjectIdsOrOntologyIds?(RecipeInput @this) => @this.PickTitleOrProjectIdsOntology;

        /// <summary>
        /// 
        /// </summary>
        public RecipeInput(global::Dataloop.PickRecipeTitleOrProjectIdsOrOntologyIds? value)
        {
            PickTitleOrProjectIdsOntology = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecipeInput(global::Dataloop.PartialRecipe value) => new RecipeInput((global::Dataloop.PartialRecipe?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.PartialRecipe?(RecipeInput @this) => @this.Partial;

        /// <summary>
        /// 
        /// </summary>
        public RecipeInput(global::Dataloop.PartialRecipe? value)
        {
            Partial = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RecipeInput(
            global::Dataloop.PickRecipeTitleOrProjectIdsOrOntologyIds? pickTitleOrProjectIdsOntology,
            global::Dataloop.PartialRecipe? partial
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
            global::System.Func<global::Dataloop.PickRecipeTitleOrProjectIdsOrOntologyIds?, TResult>? pickTitleOrProjectIdsOntology = null,
            global::System.Func<global::Dataloop.PartialRecipe?, TResult>? partial = null,
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
            global::System.Action<global::Dataloop.PickRecipeTitleOrProjectIdsOrOntologyIds?>? pickTitleOrProjectIdsOntology = null,
            global::System.Action<global::Dataloop.PartialRecipe?>? partial = null,
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
                typeof(global::Dataloop.PickRecipeTitleOrProjectIdsOrOntologyIds),
                Partial,
                typeof(global::Dataloop.PartialRecipe),
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
        public bool Equals(RecipeInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.PickRecipeTitleOrProjectIdsOrOntologyIds?>.Default.Equals(PickTitleOrProjectIdsOntology, other.PickTitleOrProjectIdsOntology) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.PartialRecipe?>.Default.Equals(Partial, other.Partial) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RecipeInput obj1, RecipeInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RecipeInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RecipeInput obj1, RecipeInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RecipeInput o && Equals(o);
        }
    }
}
