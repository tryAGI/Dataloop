#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dataloop
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IntegrationTypeMetadata : global::System.IEquatable<IntegrationTypeMetadata>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.IKeyValueMetadata? IKeyValue { get; init; }
#else
        public global::Dataloop.IKeyValueMetadata? IKeyValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IKeyValue))]
#endif
        public bool IsIKeyValue => IKeyValue != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIKeyValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dataloop.IKeyValueMetadata? value)
        {
            value = IKeyValue;
            return IsIKeyValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IKeyValueMetadata PickIKeyValue() => IsIKeyValue
            ? IKeyValue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'IKeyValue' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.IS3ApiMetadata? IS3Api { get; init; }
#else
        public global::Dataloop.IS3ApiMetadata? IS3Api { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IS3Api))]
#endif
        public bool IsIS3Api => IS3Api != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIS3Api(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dataloop.IS3ApiMetadata? value)
        {
            value = IS3Api;
            return IsIS3Api;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Dataloop.IS3ApiMetadata PickIS3Api() => IsIS3Api
            ? IS3Api!
            : throw new global::System.InvalidOperationException($"Expected union variant 'IS3Api' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IntegrationTypeMetadata(global::Dataloop.IKeyValueMetadata value) => new IntegrationTypeMetadata((global::Dataloop.IKeyValueMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.IKeyValueMetadata?(IntegrationTypeMetadata @this) => @this.IKeyValue;

        /// <summary>
        /// 
        /// </summary>
        public IntegrationTypeMetadata(global::Dataloop.IKeyValueMetadata? value)
        {
            IKeyValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IntegrationTypeMetadata FromIKeyValue(global::Dataloop.IKeyValueMetadata? value) => new IntegrationTypeMetadata(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IntegrationTypeMetadata(global::Dataloop.IS3ApiMetadata value) => new IntegrationTypeMetadata((global::Dataloop.IS3ApiMetadata?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Dataloop.IS3ApiMetadata?(IntegrationTypeMetadata @this) => @this.IS3Api;

        /// <summary>
        /// 
        /// </summary>
        public IntegrationTypeMetadata(global::Dataloop.IS3ApiMetadata? value)
        {
            IS3Api = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IntegrationTypeMetadata FromIS3Api(global::Dataloop.IS3ApiMetadata? value) => new IntegrationTypeMetadata(value);

        /// <summary>
        /// 
        /// </summary>
        public IntegrationTypeMetadata(
            global::Dataloop.IKeyValueMetadata? iKeyValue,
            global::Dataloop.IS3ApiMetadata? iS3Api
            )
        {
            IKeyValue = iKeyValue;
            IS3Api = iS3Api;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            IS3Api as object ??
            IKeyValue as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            IKeyValue?.ToString() ??
            IS3Api?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsIKeyValue || IsIS3Api;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dataloop.IKeyValueMetadata, TResult>? iKeyValue = null,
            global::System.Func<global::Dataloop.IS3ApiMetadata, TResult>? iS3Api = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIKeyValue && iKeyValue != null)
            {
                return iKeyValue(IKeyValue!);
            }
            else if (IsIS3Api && iS3Api != null)
            {
                return iS3Api(IS3Api!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Dataloop.IKeyValueMetadata>? iKeyValue = null,

            global::System.Action<global::Dataloop.IS3ApiMetadata>? iS3Api = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIKeyValue)
            {
                iKeyValue?.Invoke(IKeyValue!);
            }
            else if (IsIS3Api)
            {
                iS3Api?.Invoke(IS3Api!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Dataloop.IKeyValueMetadata>? iKeyValue = null,
            global::System.Action<global::Dataloop.IS3ApiMetadata>? iS3Api = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsIKeyValue)
            {
                iKeyValue?.Invoke(IKeyValue!);
            }
            else if (IsIS3Api)
            {
                iS3Api?.Invoke(IS3Api!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                IKeyValue,
                typeof(global::Dataloop.IKeyValueMetadata),
                IS3Api,
                typeof(global::Dataloop.IS3ApiMetadata),
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
        public bool Equals(IntegrationTypeMetadata other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.IKeyValueMetadata?>.Default.Equals(IKeyValue, other.IKeyValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.IS3ApiMetadata?>.Default.Equals(IS3Api, other.IS3Api) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IntegrationTypeMetadata obj1, IntegrationTypeMetadata obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IntegrationTypeMetadata>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IntegrationTypeMetadata obj1, IntegrationTypeMetadata obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IntegrationTypeMetadata o && Equals(o);
        }
    }
}
