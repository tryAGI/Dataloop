# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Dataloop SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Dataloop's annotation project management, dataset browsing, task tracking, and item inspection.

## Installation

```bash
dotnet add package Dataloop
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsListProjectsTool()` | `Dataloop_ListProjects` | List all annotation projects the user has access to |
| `AsListDatasetsTool()` | `Dataloop_ListDatasets` | List datasets with optional project filtering |
| `AsListTasksTool()` | `Dataloop_ListTasks` | Find annotation tasks with optional project and status filters |
| `AsGetItemTool()` | `Dataloop_GetItem` | Get details of a specific dataset item by ID |

## Usage

```csharp
using Dataloop;
using Microsoft.Extensions.AI;

var dataloopClient = new DataloopClient(
    apiKey: Environment.GetEnvironmentVariable("DATALOOP_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        dataloopClient.AsListProjectsTool(),
        dataloopClient.AsListDatasetsTool(),
        dataloopClient.AsListTasksTool(),
        dataloopClient.AsGetItemTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Show me all annotation projects and their datasets."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
