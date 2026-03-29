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
            global::System.Func<global::Dataloop.IDpkComponentPanel?, TResult>? panel = null,
            global::System.Func<global::Dataloop.IDpkComponentModel?, TResult>? model = null,
            global::System.Func<global::Dataloop.IDpkComponentModule?, TResult>? module = null,
            global::System.Func<global::Dataloop.IDpkComponentTrigger?, TResult>? trigger = null,
            global::System.Func<global::Dataloop.IDpkComponentService?, TResult>? service = null,
            global::System.Func<global::Dataloop.IDpkComponentToolbars?, TResult>? toolbars = null,
            global::System.Func<global::Dataloop.IDpkChannel?, TResult>? channel = null,
            global::System.Func<global::Dataloop.IDpkComputeConfigs?, TResult>? computeConfigs = null,
            global::System.Func<global::Dataloop.IDpkPipelineNode?, TResult>? pipelineNode = null,
            global::System.Func<global::Dataloop.IDpkPipelineTemplate?, TResult>? pipelineTemplate = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPanel && panel != null)
            {
                return panel(Panel!);
            }
            else if (IsModel && model != null)
            {
                return model(Model!);
            }
            else if (IsModule && module != null)
            {
                return module(Module!);
            }
            else if (IsTrigger && trigger != null)
            {
                return trigger(Trigger!);
            }
            else if (IsService && service != null)
            {
                return service(Service!);
            }
            else if (IsToolbars && toolbars != null)
            {
                return toolbars(Toolbars!);
            }
            else if (IsChannel && channel != null)
            {
                return channel(Channel!);
            }
            else if (IsComputeConfigs && computeConfigs != null)
            {
                return computeConfigs(ComputeConfigs!);
            }
            else if (IsPipelineNode && pipelineNode != null)
            {
                return pipelineNode(PipelineNode!);
            }
            else if (IsPipelineTemplate && pipelineTemplate != null)
            {
                return pipelineTemplate(PipelineTemplate!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Dataloop.IDpkComponentPanel?>? panel = null,
            global::System.Action<global::Dataloop.IDpkComponentModel?>? model = null,
            global::System.Action<global::Dataloop.IDpkComponentModule?>? module = null,
            global::System.Action<global::Dataloop.IDpkComponentTrigger?>? trigger = null,
            global::System.Action<global::Dataloop.IDpkComponentService?>? service = null,
            global::System.Action<global::Dataloop.IDpkComponentToolbars?>? toolbars = null,
            global::System.Action<global::Dataloop.IDpkChannel?>? channel = null,
            global::System.Action<global::Dataloop.IDpkComputeConfigs?>? computeConfigs = null,
            global::System.Action<global::Dataloop.IDpkPipelineNode?>? pipelineNode = null,
            global::System.Action<global::Dataloop.IDpkPipelineTemplate?>? pipelineTemplate = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPanel)
            {
                panel?.Invoke(Panel!);
            }
            else if (IsModel)
            {
                model?.Invoke(Model!);
            }
            else if (IsModule)
            {
                module?.Invoke(Module!);
            }
            else if (IsTrigger)
            {
                trigger?.Invoke(Trigger!);
            }
            else if (IsService)
            {
                service?.Invoke(Service!);
            }
            else if (IsToolbars)
            {
                toolbars?.Invoke(Toolbars!);
            }
            else if (IsChannel)
            {
                channel?.Invoke(Channel!);
            }
            else if (IsComputeConfigs)
            {
                computeConfigs?.Invoke(ComputeConfigs!);
            }
            else if (IsPipelineNode)
            {
                pipelineNode?.Invoke(PipelineNode!);
            }
            else if (IsPipelineTemplate)
            {
                pipelineTemplate?.Invoke(PipelineTemplate!);
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
