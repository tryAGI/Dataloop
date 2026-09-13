
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Dataloop
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AlertTier), TypeInfoPropertyName = "AlertTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceType), TypeInfoPropertyName = "ServiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UIHours))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICallResourceDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICallSourceDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Dataloop.APICallResourceDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APICallDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.StorageModificationSourceDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.StorageModificationDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.StorageDatasetDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.StorageDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.StorageDatasetDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PodType), TypeInfoPropertyName = "PodType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaasUsageServiceInstanceDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaasGlobalServiceDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FaasUsageDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.FaasUsageServiceInstanceDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.FaasGlobalServiceDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ItemsCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.IngestedDatapointsDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIUsageEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.Address))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaxType), TypeInfoPropertyName = "TaxType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaxData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DBBillingAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialBillingAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PartialBillingAccountTaxData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DBPaymentDriverConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DBPaymentDriverConfigurationType), TypeInfoPropertyName = "DBPaymentDriverConfigurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.CreditCard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PaymentMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AlertStatus), TypeInfoPropertyName = "AlertStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.APIAlert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FieldSort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FieldSortField), TypeInfoPropertyName = "FieldSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FieldSortDirection), TypeInfoPropertyName = "FieldSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.UpdateAlertRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ListAccountAlertsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIUsageEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.APIAlert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.DBPaymentDriverConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Dataloop.PaymentMethod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AlertTier?), TypeInfoPropertyName = "NullableAlertTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.ServiceType?), TypeInfoPropertyName = "NullableServiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.PodType?), TypeInfoPropertyName = "NullablePodType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.TaxType?), TypeInfoPropertyName = "NullableTaxType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.DBPaymentDriverConfigurationType?), TypeInfoPropertyName = "NullableDBPaymentDriverConfigurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AlertStatus?), TypeInfoPropertyName = "NullableAlertStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FieldSortField?), TypeInfoPropertyName = "NullableFieldSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.FieldSortDirection?), TypeInfoPropertyName = "NullableFieldSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Dataloop.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.StorageDatasetDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.FaasUsageServiceInstanceDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.FaasGlobalServiceDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIUsageEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.APIAlert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.DBPaymentDriverConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Dataloop.PaymentMethod>))]
    internal sealed partial class BillingSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BillingSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BillingSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<double?, global::System.Collections.Generic.Dictionary<string, double>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.AnyOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Dataloop.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Dataloop.AlertTier)

                    || typeToConvert == typeof(global::Dataloop.AlertTier?)

                    || typeToConvert == typeof(global::Dataloop.ServiceType)

                    || typeToConvert == typeof(global::Dataloop.ServiceType?)

                    || typeToConvert == typeof(global::Dataloop.PodType)

                    || typeToConvert == typeof(global::Dataloop.PodType?)

                    || typeToConvert == typeof(global::Dataloop.TaxType)

                    || typeToConvert == typeof(global::Dataloop.TaxType?)

                    || typeToConvert == typeof(global::Dataloop.DBPaymentDriverConfigurationType)

                    || typeToConvert == typeof(global::Dataloop.DBPaymentDriverConfigurationType?)

                    || typeToConvert == typeof(global::Dataloop.AlertStatus)

                    || typeToConvert == typeof(global::Dataloop.AlertStatus?)

                    || typeToConvert == typeof(global::Dataloop.FieldSortField)

                    || typeToConvert == typeof(global::Dataloop.FieldSortField?)

                    || typeToConvert == typeof(global::Dataloop.FieldSortDirection)

                    || typeToConvert == typeof(global::Dataloop.FieldSortDirection?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Dataloop.AlertTier))
                {
                    return new global::Dataloop.JsonConverters.AlertTierJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AlertTier?))
                {
                    return new global::Dataloop.JsonConverters.AlertTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ServiceType))
                {
                    return new global::Dataloop.JsonConverters.ServiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.ServiceType?))
                {
                    return new global::Dataloop.JsonConverters.ServiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PodType))
                {
                    return new global::Dataloop.JsonConverters.PodTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.PodType?))
                {
                    return new global::Dataloop.JsonConverters.PodTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TaxType))
                {
                    return new global::Dataloop.JsonConverters.TaxTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.TaxType?))
                {
                    return new global::Dataloop.JsonConverters.TaxTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DBPaymentDriverConfigurationType))
                {
                    return new global::Dataloop.JsonConverters.DBPaymentDriverConfigurationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.DBPaymentDriverConfigurationType?))
                {
                    return new global::Dataloop.JsonConverters.DBPaymentDriverConfigurationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AlertStatus))
                {
                    return new global::Dataloop.JsonConverters.AlertStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.AlertStatus?))
                {
                    return new global::Dataloop.JsonConverters.AlertStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FieldSortField))
                {
                    return new global::Dataloop.JsonConverters.FieldSortFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FieldSortField?))
                {
                    return new global::Dataloop.JsonConverters.FieldSortFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FieldSortDirection))
                {
                    return new global::Dataloop.JsonConverters.FieldSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Dataloop.FieldSortDirection?))
                {
                    return new global::Dataloop.JsonConverters.FieldSortDirectionNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new BillingSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}