#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Dataloop
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IDpkComponentElementSpec : global::System.IEquatable<IDpkComponentElementSpec>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.IDpkComponentPanel? Panel { get; init; }
#else
        public global::Dataloop.IDpkComponentPanel? Panel { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Panel))]
#endif
        public bool IsPanel => Panel != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPanel(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dataloop.IDpkComponentPanel? value)
        {
            value = Panel;
            return IsPanel;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Dataloop.IDpkComponentPanel PickPanel() => Panel is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Panel' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.IDpkComponentModel? Model { get; init; }
#else
        public global::Dataloop.IDpkComponentModel? Model { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Model))]
#endif
        public bool IsModel => Model != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModel(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dataloop.IDpkComponentModel? value)
        {
            value = Model;
            return IsModel;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Dataloop.IDpkComponentModel PickModel() => Model is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Model' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.IDpkComponentModule? Module { get; init; }
#else
        public global::Dataloop.IDpkComponentModule? Module { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Module))]
#endif
        public bool IsModule => Module != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModule(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dataloop.IDpkComponentModule? value)
        {
            value = Module;
            return IsModule;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Dataloop.IDpkComponentModule PickModule() => Module is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Module' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.IDpkComponentTrigger? Trigger { get; init; }
#else
        public global::Dataloop.IDpkComponentTrigger? Trigger { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Trigger))]
#endif
        public bool IsTrigger => Trigger != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTrigger(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dataloop.IDpkComponentTrigger? value)
        {
            value = Trigger;
            return IsTrigger;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Dataloop.IDpkComponentTrigger PickTrigger() => Trigger is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Trigger' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.IDpkComponentService? Service { get; init; }
#else
        public global::Dataloop.IDpkComponentService? Service { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Service))]
#endif
        public bool IsService => Service != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickService(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dataloop.IDpkComponentService? value)
        {
            value = Service;
            return IsService;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Dataloop.IDpkComponentService PickService() => Service is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Service' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.IDpkComponentToolbars? Toolbars { get; init; }
#else
        public global::Dataloop.IDpkComponentToolbars? Toolbars { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Toolbars))]
#endif
        public bool IsToolbars => Toolbars != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolbars(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dataloop.IDpkComponentToolbars? value)
        {
            value = Toolbars;
            return IsToolbars;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Dataloop.IDpkComponentToolbars PickToolbars() => Toolbars is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Toolbars' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.IDpkChannel? Channel { get; init; }
#else
        public global::Dataloop.IDpkChannel? Channel { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Channel))]
#endif
        public bool IsChannel => Channel != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChannel(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dataloop.IDpkChannel? value)
        {
            value = Channel;
            return IsChannel;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Dataloop.IDpkChannel PickChannel() => Channel is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Channel' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.IDpkComputeConfigs? ComputeConfigs { get; init; }
#else
        public global::Dataloop.IDpkComputeConfigs? ComputeConfigs { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputeConfigs))]
#endif
        public bool IsComputeConfigs => ComputeConfigs != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputeConfigs(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dataloop.IDpkComputeConfigs? value)
        {
            value = ComputeConfigs;
            return IsComputeConfigs;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Dataloop.IDpkComputeConfigs PickComputeConfigs() => ComputeConfigs is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputeConfigs' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.IDpkPipelineNode? PipelineNode { get; init; }
#else
        public global::Dataloop.IDpkPipelineNode? PipelineNode { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PipelineNode))]
#endif
        public bool IsPipelineNode => PipelineNode != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPipelineNode(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dataloop.IDpkPipelineNode? value)
        {
            value = PipelineNode;
            return IsPipelineNode;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Dataloop.IDpkPipelineNode PickPipelineNode() => PipelineNode is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PipelineNode' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Dataloop.IDpkPipelineTemplate? PipelineTemplate { get; init; }
#else
        public global::Dataloop.IDpkPipelineTemplate? PipelineTemplate { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PipelineTemplate))]
#endif
        public bool IsPipelineTemplate => PipelineTemplate != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPipelineTemplate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Dataloop.IDpkPipelineTemplate? value)
        {
            value = PipelineTemplate;
            return IsPipelineTemplate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Dataloop.IDpkPipelineTemplate PickPipelineTemplate() => PipelineTemplate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PipelineTemplate' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IDpkComponentElementSpec(global::Dataloop.IDpkComponentPanel value) => new IDpkComponentElementSpec((global::Dataloop.IDpkComponentPanel?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Dataloop.IDpkComponentPanel?(IDpkComponentElementSpec @this) => @this.Panel;

        /// <summary>
        ///
        /// </summary>
        public IDpkComponentElementSpec(global::Dataloop.IDpkComponentPanel? value)
        {
            Panel = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IDpkComponentElementSpec FromPanel(global::Dataloop.IDpkComponentPanel? value) => new IDpkComponentElementSpec(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IDpkComponentElementSpec(global::Dataloop.IDpkComponentModel value) => new IDpkComponentElementSpec((global::Dataloop.IDpkComponentModel?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Dataloop.IDpkComponentModel?(IDpkComponentElementSpec @this) => @this.Model;

        /// <summary>
        ///
        /// </summary>
        public IDpkComponentElementSpec(global::Dataloop.IDpkComponentModel? value)
        {
            Model = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IDpkComponentElementSpec FromModel(global::Dataloop.IDpkComponentModel? value) => new IDpkComponentElementSpec(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IDpkComponentElementSpec(global::Dataloop.IDpkComponentModule value) => new IDpkComponentElementSpec((global::Dataloop.IDpkComponentModule?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Dataloop.IDpkComponentModule?(IDpkComponentElementSpec @this) => @this.Module;

        /// <summary>
        ///
        /// </summary>
        public IDpkComponentElementSpec(global::Dataloop.IDpkComponentModule? value)
        {
            Module = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IDpkComponentElementSpec FromModule(global::Dataloop.IDpkComponentModule? value) => new IDpkComponentElementSpec(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IDpkComponentElementSpec(global::Dataloop.IDpkComponentTrigger value) => new IDpkComponentElementSpec((global::Dataloop.IDpkComponentTrigger?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Dataloop.IDpkComponentTrigger?(IDpkComponentElementSpec @this) => @this.Trigger;

        /// <summary>
        ///
        /// </summary>
        public IDpkComponentElementSpec(global::Dataloop.IDpkComponentTrigger? value)
        {
            Trigger = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IDpkComponentElementSpec FromTrigger(global::Dataloop.IDpkComponentTrigger? value) => new IDpkComponentElementSpec(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IDpkComponentElementSpec(global::Dataloop.IDpkComponentService value) => new IDpkComponentElementSpec((global::Dataloop.IDpkComponentService?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Dataloop.IDpkComponentService?(IDpkComponentElementSpec @this) => @this.Service;

        /// <summary>
        ///
        /// </summary>
        public IDpkComponentElementSpec(global::Dataloop.IDpkComponentService? value)
        {
            Service = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IDpkComponentElementSpec FromService(global::Dataloop.IDpkComponentService? value) => new IDpkComponentElementSpec(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IDpkComponentElementSpec(global::Dataloop.IDpkComponentToolbars value) => new IDpkComponentElementSpec((global::Dataloop.IDpkComponentToolbars?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Dataloop.IDpkComponentToolbars?(IDpkComponentElementSpec @this) => @this.Toolbars;

        /// <summary>
        ///
        /// </summary>
        public IDpkComponentElementSpec(global::Dataloop.IDpkComponentToolbars? value)
        {
            Toolbars = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IDpkComponentElementSpec FromToolbars(global::Dataloop.IDpkComponentToolbars? value) => new IDpkComponentElementSpec(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IDpkComponentElementSpec(global::Dataloop.IDpkChannel value) => new IDpkComponentElementSpec((global::Dataloop.IDpkChannel?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Dataloop.IDpkChannel?(IDpkComponentElementSpec @this) => @this.Channel;

        /// <summary>
        ///
        /// </summary>
        public IDpkComponentElementSpec(global::Dataloop.IDpkChannel? value)
        {
            Channel = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IDpkComponentElementSpec FromChannel(global::Dataloop.IDpkChannel? value) => new IDpkComponentElementSpec(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IDpkComponentElementSpec(global::Dataloop.IDpkComputeConfigs value) => new IDpkComponentElementSpec((global::Dataloop.IDpkComputeConfigs?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Dataloop.IDpkComputeConfigs?(IDpkComponentElementSpec @this) => @this.ComputeConfigs;

        /// <summary>
        ///
        /// </summary>
        public IDpkComponentElementSpec(global::Dataloop.IDpkComputeConfigs? value)
        {
            ComputeConfigs = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IDpkComponentElementSpec FromComputeConfigs(global::Dataloop.IDpkComputeConfigs? value) => new IDpkComponentElementSpec(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IDpkComponentElementSpec(global::Dataloop.IDpkPipelineNode value) => new IDpkComponentElementSpec((global::Dataloop.IDpkPipelineNode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Dataloop.IDpkPipelineNode?(IDpkComponentElementSpec @this) => @this.PipelineNode;

        /// <summary>
        ///
        /// </summary>
        public IDpkComponentElementSpec(global::Dataloop.IDpkPipelineNode? value)
        {
            PipelineNode = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IDpkComponentElementSpec FromPipelineNode(global::Dataloop.IDpkPipelineNode? value) => new IDpkComponentElementSpec(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IDpkComponentElementSpec(global::Dataloop.IDpkPipelineTemplate value) => new IDpkComponentElementSpec((global::Dataloop.IDpkPipelineTemplate?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Dataloop.IDpkPipelineTemplate?(IDpkComponentElementSpec @this) => @this.PipelineTemplate;

        /// <summary>
        ///
        /// </summary>
        public IDpkComponentElementSpec(global::Dataloop.IDpkPipelineTemplate? value)
        {
            PipelineTemplate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IDpkComponentElementSpec FromPipelineTemplate(global::Dataloop.IDpkPipelineTemplate? value) => new IDpkComponentElementSpec(value);

        /// <summary>
        ///
        /// </summary>
        public IDpkComponentElementSpec(
            global::Dataloop.IDpkComponentPanel? panel,
            global::Dataloop.IDpkComponentModel? model,
            global::Dataloop.IDpkComponentModule? module,
            global::Dataloop.IDpkComponentTrigger? trigger,
            global::Dataloop.IDpkComponentService? service,
            global::Dataloop.IDpkComponentToolbars? toolbars,
            global::Dataloop.IDpkChannel? channel,
            global::Dataloop.IDpkComputeConfigs? computeConfigs,
            global::Dataloop.IDpkPipelineNode? pipelineNode,
            global::Dataloop.IDpkPipelineTemplate? pipelineTemplate
            )
        {
            Panel = panel;
            Model = model;
            Module = module;
            Trigger = trigger;
            Service = service;
            Toolbars = toolbars;
            Channel = channel;
            ComputeConfigs = computeConfigs;
            PipelineNode = pipelineNode;
            PipelineTemplate = pipelineTemplate;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PipelineTemplate as object ??
            PipelineNode as object ??
            ComputeConfigs as object ??
            Channel as object ??
            Toolbars as object ??
            Service as object ??
            Trigger as object ??
            Module as object ??
            Model as object ??
            Panel as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Panel?.ToString() ??
            Model?.ToString() ??
            Module?.ToString() ??
            Trigger?.ToString() ??
            Service?.ToString() ??
            Toolbars?.ToString() ??
            Channel?.ToString() ??
            ComputeConfigs?.ToString() ??
            PipelineNode?.ToString() ??
            PipelineTemplate?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPanel || IsModel || IsModule || IsTrigger || IsService || IsToolbars || IsChannel || IsComputeConfigs || IsPipelineNode || IsPipelineTemplate;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Dataloop.IDpkComponentPanel, TResult>? panel = null,
            global::System.Func<global::Dataloop.IDpkComponentModel, TResult>? model = null,
            global::System.Func<global::Dataloop.IDpkComponentModule, TResult>? module = null,
            global::System.Func<global::Dataloop.IDpkComponentTrigger, TResult>? trigger = null,
            global::System.Func<global::Dataloop.IDpkComponentService, TResult>? service = null,
            global::System.Func<global::Dataloop.IDpkComponentToolbars, TResult>? toolbars = null,
            global::System.Func<global::Dataloop.IDpkChannel, TResult>? channel = null,
            global::System.Func<global::Dataloop.IDpkComputeConfigs, TResult>? computeConfigs = null,
            global::System.Func<global::Dataloop.IDpkPipelineNode, TResult>? pipelineNode = null,
            global::System.Func<global::Dataloop.IDpkPipelineTemplate, TResult>? pipelineTemplate = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Panel is { } __value0 && panel != null)
            {
                return panel(__value0);
            }
            else if (Model is { } __value1 && model != null)
            {
                return model(__value1);
            }
            else if (Module is { } __value2 && module != null)
            {
                return module(__value2);
            }
            else if (Trigger is { } __value3 && trigger != null)
            {
                return trigger(__value3);
            }
            else if (Service is { } __value4 && service != null)
            {
                return service(__value4);
            }
            else if (Toolbars is { } __value5 && toolbars != null)
            {
                return toolbars(__value5);
            }
            else if (Channel is { } __value6 && channel != null)
            {
                return channel(__value6);
            }
            else if (ComputeConfigs is { } __value7 && computeConfigs != null)
            {
                return computeConfigs(__value7);
            }
            else if (PipelineNode is { } __value8 && pipelineNode != null)
            {
                return pipelineNode(__value8);
            }
            else if (PipelineTemplate is { } __value9 && pipelineTemplate != null)
            {
                return pipelineTemplate(__value9);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Dataloop.IDpkComponentPanel>? panel = null,

            global::System.Action<global::Dataloop.IDpkComponentModel>? model = null,

            global::System.Action<global::Dataloop.IDpkComponentModule>? module = null,

            global::System.Action<global::Dataloop.IDpkComponentTrigger>? trigger = null,

            global::System.Action<global::Dataloop.IDpkComponentService>? service = null,

            global::System.Action<global::Dataloop.IDpkComponentToolbars>? toolbars = null,

            global::System.Action<global::Dataloop.IDpkChannel>? channel = null,

            global::System.Action<global::Dataloop.IDpkComputeConfigs>? computeConfigs = null,

            global::System.Action<global::Dataloop.IDpkPipelineNode>? pipelineNode = null,

            global::System.Action<global::Dataloop.IDpkPipelineTemplate>? pipelineTemplate = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Panel is { } __value0)
            {
                panel?.Invoke(__value0);
            }
            else if (Model is { } __value1)
            {
                model?.Invoke(__value1);
            }
            else if (Module is { } __value2)
            {
                module?.Invoke(__value2);
            }
            else if (Trigger is { } __value3)
            {
                trigger?.Invoke(__value3);
            }
            else if (Service is { } __value4)
            {
                service?.Invoke(__value4);
            }
            else if (Toolbars is { } __value5)
            {
                toolbars?.Invoke(__value5);
            }
            else if (Channel is { } __value6)
            {
                channel?.Invoke(__value6);
            }
            else if (ComputeConfigs is { } __value7)
            {
                computeConfigs?.Invoke(__value7);
            }
            else if (PipelineNode is { } __value8)
            {
                pipelineNode?.Invoke(__value8);
            }
            else if (PipelineTemplate is { } __value9)
            {
                pipelineTemplate?.Invoke(__value9);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Dataloop.IDpkComponentPanel>? panel = null,
            global::System.Action<global::Dataloop.IDpkComponentModel>? model = null,
            global::System.Action<global::Dataloop.IDpkComponentModule>? module = null,
            global::System.Action<global::Dataloop.IDpkComponentTrigger>? trigger = null,
            global::System.Action<global::Dataloop.IDpkComponentService>? service = null,
            global::System.Action<global::Dataloop.IDpkComponentToolbars>? toolbars = null,
            global::System.Action<global::Dataloop.IDpkChannel>? channel = null,
            global::System.Action<global::Dataloop.IDpkComputeConfigs>? computeConfigs = null,
            global::System.Action<global::Dataloop.IDpkPipelineNode>? pipelineNode = null,
            global::System.Action<global::Dataloop.IDpkPipelineTemplate>? pipelineTemplate = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Panel is { } __value0)
            {
                panel?.Invoke(__value0);
            }
            else if (Model is { } __value1)
            {
                model?.Invoke(__value1);
            }
            else if (Module is { } __value2)
            {
                module?.Invoke(__value2);
            }
            else if (Trigger is { } __value3)
            {
                trigger?.Invoke(__value3);
            }
            else if (Service is { } __value4)
            {
                service?.Invoke(__value4);
            }
            else if (Toolbars is { } __value5)
            {
                toolbars?.Invoke(__value5);
            }
            else if (Channel is { } __value6)
            {
                channel?.Invoke(__value6);
            }
            else if (ComputeConfigs is { } __value7)
            {
                computeConfigs?.Invoke(__value7);
            }
            else if (PipelineNode is { } __value8)
            {
                pipelineNode?.Invoke(__value8);
            }
            else if (PipelineTemplate is { } __value9)
            {
                pipelineTemplate?.Invoke(__value9);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Panel,
                typeof(global::Dataloop.IDpkComponentPanel),
                Model,
                typeof(global::Dataloop.IDpkComponentModel),
                Module,
                typeof(global::Dataloop.IDpkComponentModule),
                Trigger,
                typeof(global::Dataloop.IDpkComponentTrigger),
                Service,
                typeof(global::Dataloop.IDpkComponentService),
                Toolbars,
                typeof(global::Dataloop.IDpkComponentToolbars),
                Channel,
                typeof(global::Dataloop.IDpkChannel),
                ComputeConfigs,
                typeof(global::Dataloop.IDpkComputeConfigs),
                PipelineNode,
                typeof(global::Dataloop.IDpkPipelineNode),
                PipelineTemplate,
                typeof(global::Dataloop.IDpkPipelineTemplate),
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
        public bool Equals(IDpkComponentElementSpec other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.IDpkComponentPanel?>.Default.Equals(Panel, other.Panel) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.IDpkComponentModel?>.Default.Equals(Model, other.Model) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.IDpkComponentModule?>.Default.Equals(Module, other.Module) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.IDpkComponentTrigger?>.Default.Equals(Trigger, other.Trigger) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.IDpkComponentService?>.Default.Equals(Service, other.Service) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.IDpkComponentToolbars?>.Default.Equals(Toolbars, other.Toolbars) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.IDpkChannel?>.Default.Equals(Channel, other.Channel) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.IDpkComputeConfigs?>.Default.Equals(ComputeConfigs, other.ComputeConfigs) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.IDpkPipelineNode?>.Default.Equals(PipelineNode, other.PipelineNode) &&
                global::System.Collections.Generic.EqualityComparer<global::Dataloop.IDpkPipelineTemplate?>.Default.Equals(PipelineTemplate, other.PipelineTemplate)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IDpkComponentElementSpec obj1, IDpkComponentElementSpec obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IDpkComponentElementSpec>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IDpkComponentElementSpec obj1, IDpkComponentElementSpec obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IDpkComponentElementSpec o && Equals(o);
        }
    }
}
