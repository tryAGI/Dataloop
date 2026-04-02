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
                        panel = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IDpkComponentPanel>(__rawJson, options);
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
                        model = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IDpkComponentModel>(__rawJson, options);
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
                        module = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IDpkComponentModule>(__rawJson, options);
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
                        trigger = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IDpkComponentTrigger>(__rawJson, options);
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
                        service = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IDpkComponentService>(__rawJson, options);
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
                        toolbars = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IDpkComponentToolbars>(__rawJson, options);
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
                        channel = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IDpkChannel>(__rawJson, options);
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
                        computeConfigs = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IDpkComputeConfigs>(__rawJson, options);
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
                        pipelineNode = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IDpkPipelineNode>(__rawJson, options);
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
                        pipelineTemplate = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IDpkPipelineTemplate>(__rawJson, options);
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
                    panel = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IDpkComponentPanel>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    model = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IDpkComponentModel>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    module = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IDpkComponentModule>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    trigger = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IDpkComponentTrigger>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    service = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IDpkComponentService>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    toolbars = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IDpkComponentToolbars>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    channel = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IDpkChannel>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    computeConfigs = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IDpkComputeConfigs>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    pipelineNode = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IDpkPipelineNode>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    pipelineTemplate = global::System.Text.Json.JsonSerializer.Deserialize<global::Dataloop.IDpkPipelineTemplate>(__rawJson, options);
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

            if (value.IsPanel)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Panel, typeof(global::Dataloop.IDpkComponentPanel), options);
            }
            else if (value.IsModel)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Model, typeof(global::Dataloop.IDpkComponentModel), options);
            }
            else if (value.IsModule)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Module, typeof(global::Dataloop.IDpkComponentModule), options);
            }
            else if (value.IsTrigger)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Trigger, typeof(global::Dataloop.IDpkComponentTrigger), options);
            }
            else if (value.IsService)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Service, typeof(global::Dataloop.IDpkComponentService), options);
            }
            else if (value.IsToolbars)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Toolbars, typeof(global::Dataloop.IDpkComponentToolbars), options);
            }
            else if (value.IsChannel)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Channel, typeof(global::Dataloop.IDpkChannel), options);
            }
            else if (value.IsComputeConfigs)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputeConfigs, typeof(global::Dataloop.IDpkComputeConfigs), options);
            }
            else if (value.IsPipelineNode)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PipelineNode, typeof(global::Dataloop.IDpkPipelineNode), options);
            }
            else if (value.IsPipelineTemplate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PipelineTemplate, typeof(global::Dataloop.IDpkPipelineTemplate), options);
            }
        }
    }
}