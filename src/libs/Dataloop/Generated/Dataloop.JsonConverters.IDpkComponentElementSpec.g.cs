#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Dataloop.JsonConverters
{
    /// <inheritdoc />
    public class IDpkComponentElementSpecJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Dataloop.IDpkComponentElementSpec>
    {
        /// <inheritdoc />
        public override global::Dataloop.IDpkComponentElementSpec Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("computeConfig")) __score0++;
            if (__jsonProps.Contains("conditions")) __score0++;
            if (__jsonProps.Contains("defaultSettings")) __score0++;
            if (__jsonProps.Contains("icon")) __score0++;
            if (__jsonProps.Contains("mandatory")) __score0++;
            if (__jsonProps.Contains("metadata")) __score0++;
            if (__jsonProps.Contains("minRole")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("path")) __score0++;
            if (__jsonProps.Contains("serveFromFilesystem")) __score0++;
            if (__jsonProps.Contains("supportedSlots")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("app")) __score1++;
            if (__jsonProps.Contains("artifacts")) __score1++;
            if (__jsonProps.Contains("computeConfigs")) __score1++;
            if (__jsonProps.Contains("configuration")) __score1++;
            if (__jsonProps.Contains("context")) __score1++;
            if (__jsonProps.Contains("datasetId")) __score1++;
            if (__jsonProps.Contains("description")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("inputType")) __score1++;
            if (__jsonProps.Contains("labels")) __score1++;
            if (__jsonProps.Contains("mandatory")) __score1++;
            if (__jsonProps.Contains("metadata")) __score1++;
            if (__jsonProps.Contains("moduleName")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("operationType")) __score1++;
            if (__jsonProps.Contains("outputType")) __score1++;
            if (__jsonProps.Contains("scope")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            if (__jsonProps.Contains("tags")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("className")) __score2++;
            if (__jsonProps.Contains("computeConfig")) __score2++;
            if (__jsonProps.Contains("config")) __score2++;
            if (__jsonProps.Contains("entryPoint")) __score2++;
            if (__jsonProps.Contains("functions")) __score2++;
            if (__jsonProps.Contains("initInputs")) __score2++;
            if (__jsonProps.Contains("integrations")) __score2++;
            if (__jsonProps.Contains("mandatory")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("serviceConfig")) __score2++;
            if (__jsonProps.Contains("versions")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("global")) __score3++;
            if (__jsonProps.Contains("mandatory")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("namespace")) __score3++;
            if (__jsonProps.Contains("operation")) __score3++;
            if (__jsonProps.Contains("scope")) __score3++;
            if (__jsonProps.Contains("spec")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("app")) __score4++;
            if (__jsonProps.Contains("botUserName")) __score4++;
            if (__jsonProps.Contains("computeConfig")) __score4++;
            if (__jsonProps.Contains("drainTime")) __score4++;
            if (__jsonProps.Contains("driverId")) __score4++;
            if (__jsonProps.Contains("executionTimeout")) __score4++;
            if (__jsonProps.Contains("initParams")) __score4++;
            if (__jsonProps.Contains("integrations")) __score4++;
            if (__jsonProps.Contains("mandatory")) __score4++;
            if (__jsonProps.Contains("maxAttempts")) __score4++;
            if (__jsonProps.Contains("metadata")) __score4++;
            if (__jsonProps.Contains("modelOperation")) __score4++;
            if (__jsonProps.Contains("moduleName")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("onReset")) __score4++;
            if (__jsonProps.Contains("operation")) __score4++;
            if (__jsonProps.Contains("panelNames")) __score4++;
            if (__jsonProps.Contains("runExecutionAsProcess")) __score4++;
            if (__jsonProps.Contains("runtime")) __score4++;
            if (__jsonProps.Contains("secrets")) __score4++;
            if (__jsonProps.Contains("useUserJwt")) __score4++;
            if (__jsonProps.Contains("versions")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("conditions")) __score5++;
            if (__jsonProps.Contains("displayName")) __score5++;
            if (__jsonProps.Contains("icon")) __score5++;
            if (__jsonProps.Contains("invoke")) __score5++;
            if (__jsonProps.Contains("location")) __score5++;
            if (__jsonProps.Contains("mandatory")) __score5++;
            if (__jsonProps.Contains("name")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("context")) __score6++;
            if (__jsonProps.Contains("description")) __score6++;
            if (__jsonProps.Contains("filters")) __score6++;
            if (__jsonProps.Contains("global")) __score6++;
            if (__jsonProps.Contains("icon")) __score6++;
            if (__jsonProps.Contains("mandatory")) __score6++;
            if (__jsonProps.Contains("metadata")) __score6++;
            if (__jsonProps.Contains("name")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("botUserName")) __score7++;
            if (__jsonProps.Contains("drainTime")) __score7++;
            if (__jsonProps.Contains("driverId")) __score7++;
            if (__jsonProps.Contains("executionTimeout")) __score7++;
            if (__jsonProps.Contains("integrations")) __score7++;
            if (__jsonProps.Contains("mandatory")) __score7++;
            if (__jsonProps.Contains("maxAttempts")) __score7++;
            if (__jsonProps.Contains("name")) __score7++;
            if (__jsonProps.Contains("onReset")) __score7++;
            if (__jsonProps.Contains("runExecutionAsProcess")) __score7++;
            if (__jsonProps.Contains("runtime")) __score7++;
            if (__jsonProps.Contains("useUserJwt")) __score7++;
            if (__jsonProps.Contains("versions")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("categories")) __score8++;
            if (__jsonProps.Contains("configuration")) __score8++;
            if (__jsonProps.Contains("description")) __score8++;
            if (__jsonProps.Contains("displayName")) __score8++;
            if (__jsonProps.Contains("icon")) __score8++;
            if (__jsonProps.Contains("invoke")) __score8++;
            if (__jsonProps.Contains("mandatory")) __score8++;
            if (__jsonProps.Contains("name")) __score8++;
            if (__jsonProps.Contains("panel")) __score8++;
            if (__jsonProps.Contains("scope")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("compositionId")) __score9++;
            if (__jsonProps.Contains("connections")) __score9++;
            if (__jsonProps.Contains("createdAt")) __score9++;
            if (__jsonProps.Contains("creator")) __score9++;
            if (__jsonProps.Contains("description")) __score9++;
            if (__jsonProps.Contains("id")) __score9++;
            if (__jsonProps.Contains("mandatory")) __score9++;
            if (__jsonProps.Contains("name")) __score9++;
            if (__jsonProps.Contains("nodes")) __score9++;
            if (__jsonProps.Contains("orgId")) __score9++;
            if (__jsonProps.Contains("preview")) __score9++;
            if (__jsonProps.Contains("projectId")) __score9++;
            if (__jsonProps.Contains("resetTimestamp")) __score9++;
            if (__jsonProps.Contains("settings")) __score9++;
            if (__jsonProps.Contains("startNodes")) __score9++;
            if (__jsonProps.Contains("status")) __score9++;
            if (__jsonProps.Contains("template")) __score9++;
            if (__jsonProps.Contains("templateKind")) __score9++;
            if (__jsonProps.Contains("updatedAt")) __score9++;
            if (__jsonProps.Contains("updatedBy")) __score9++;
            if (__jsonProps.Contains("url")) __score9++;
            if (__jsonProps.Contains("variables")) __score9++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }

            global::Dataloop.IDpkComponentPanel? panel = default;
            global::Dataloop.IDpkComponentModel? model = default;
            global::Dataloop.IDpkComponentModule? module = default;
            global::Dataloop.IDpkComponentTrigger? trigger = default;
            global::Dataloop.IDpkComponentService? service = default;
            global::Dataloop.IDpkComponentToolbars? toolbars = default;
            global::Dataloop.IDpkChannel? channel = default;
            global::Dataloop.IDpkComputeConfigs? computeConfigs = default;
            global::Dataloop.IDpkPipelineNode? pipelineNode = default;
            global::Dataloop.IDpkPipelineTemplate? pipelineTemplate = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkComponentPanel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkComponentPanel> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkComponentPanel).Name}");
                        panel = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkComponentModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkComponentModel> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkComponentModel).Name}");
                        model = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkComponentModule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkComponentModule> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkComponentModule).Name}");
                        module = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkComponentTrigger), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkComponentTrigger> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkComponentTrigger).Name}");
                        trigger = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkComponentService), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkComponentService> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkComponentService).Name}");
                        service = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkComponentToolbars), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkComponentToolbars> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkComponentToolbars).Name}");
                        toolbars = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkChannel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkChannel> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkChannel).Name}");
                        channel = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkComputeConfigs), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkComputeConfigs> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkComputeConfigs).Name}");
                        computeConfigs = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkPipelineNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkPipelineNode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkPipelineNode).Name}");
                        pipelineNode = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkPipelineTemplate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkPipelineTemplate> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkPipelineTemplate).Name}");
                        pipelineTemplate = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (panel == null && model == null && module == null && trigger == null && service == null && toolbars == null && channel == null && computeConfigs == null && pipelineNode == null && pipelineTemplate == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkComponentPanel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkComponentPanel> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkComponentPanel).Name}");
                    panel = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkComponentModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkComponentModel> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkComponentModel).Name}");
                    model = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkComponentModule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkComponentModule> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkComponentModule).Name}");
                    module = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkComponentTrigger), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkComponentTrigger> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkComponentTrigger).Name}");
                    trigger = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkComponentService), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkComponentService> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkComponentService).Name}");
                    service = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkComponentToolbars), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkComponentToolbars> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkComponentToolbars).Name}");
                    toolbars = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkChannel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkChannel> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkChannel).Name}");
                    channel = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkComputeConfigs), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkComputeConfigs> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkComputeConfigs).Name}");
                    computeConfigs = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkPipelineNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkPipelineNode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkPipelineNode).Name}");
                    pipelineNode = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkPipelineTemplate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkPipelineTemplate> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkPipelineTemplate).Name}");
                    pipelineTemplate = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Dataloop.IDpkComponentElementSpec(
                panel,

                model,

                module,

                trigger,

                service,

                toolbars,

                channel,

                computeConfigs,

                pipelineNode,

                pipelineTemplate
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Dataloop.IDpkComponentElementSpec value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPanel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkComponentPanel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkComponentPanel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkComponentPanel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Panel!, typeInfo);
            }
            else if (value.IsModel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkComponentModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkComponentModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkComponentModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Model!, typeInfo);
            }
            else if (value.IsModule)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkComponentModule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkComponentModule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkComponentModule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Module!, typeInfo);
            }
            else if (value.IsTrigger)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkComponentTrigger), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkComponentTrigger?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkComponentTrigger).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Trigger!, typeInfo);
            }
            else if (value.IsService)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkComponentService), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkComponentService?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkComponentService).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Service!, typeInfo);
            }
            else if (value.IsToolbars)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkComponentToolbars), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkComponentToolbars?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkComponentToolbars).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Toolbars!, typeInfo);
            }
            else if (value.IsChannel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkChannel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkChannel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkChannel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Channel!, typeInfo);
            }
            else if (value.IsComputeConfigs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkComputeConfigs), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkComputeConfigs?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkComputeConfigs).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputeConfigs!, typeInfo);
            }
            else if (value.IsPipelineNode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkPipelineNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkPipelineNode?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkPipelineNode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PipelineNode!, typeInfo);
            }
            else if (value.IsPipelineTemplate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Dataloop.IDpkPipelineTemplate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Dataloop.IDpkPipelineTemplate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Dataloop.IDpkPipelineTemplate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PipelineTemplate!, typeInfo);
            }
        }
    }
}