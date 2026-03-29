#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace Dataloop;

public static class DataloopClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that lists all projects the authenticated user has access to.
    /// </summary>
    public static AIFunction AsListProjectsTool(this DataloopClient client)
    {
        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var projects = await client.Projects.GetMyProjectsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return projects.Select(p => new
                {
                    p.Id,
                    p.Name,
                    p.Creator,
                    p.CreatedAt,
                }).ToArray();
            },
            name: "Dataloop_ListProjects",
            description: "List all Dataloop AI annotation projects the authenticated user has access to.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists datasets, optionally filtered by project IDs.
    /// </summary>
    public static AIFunction AsListDatasetsTool(this DataloopClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Optional comma-separated project IDs to filter datasets by")] string? projectIds,
                   CancellationToken cancellationToken) =>
            {
                var projects = projectIds?.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                    .ToList();

                var datasets = await client.Datasets.ListDatasetsAsync(
                    projects: projects,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return datasets.Select(d => new
                {
                    d.Id,
                    d.Name,
                    d.Creator,
                    d.ItemsCount,
                    d.CreatedAt,
                }).ToArray();
            },
            name: "Dataloop_ListDatasets",
            description: "List Dataloop AI datasets, optionally filtered by project IDs.");
    }

    /// <summary>
    /// Creates an AIFunction tool that finds annotation tasks with optional filters.
    /// </summary>
    public static AIFunction AsListTasksTool(this DataloopClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Optional comma-separated project IDs to filter tasks by")] string? projectIds,
                   [Description("Optional task status filter (e.g., 'open', 'completed')")] string? status,
                   CancellationToken cancellationToken) =>
            {
                var projects = projectIds?.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                    .ToList();

                var result = await client.Tasks.FindTasksAsync(
                    projects: projects,
                    status: status,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return result;
            },
            name: "Dataloop_ListTasks",
            description: "Find Dataloop AI annotation tasks with optional project and status filters.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets details of a specific item by ID.
    /// </summary>
    public static AIFunction AsGetItemTool(this DataloopClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The item ID to retrieve details for")] string itemId,
                   CancellationToken cancellationToken) =>
            {
                var item = await client.Items.GetItemAsync(
                    id: itemId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return item;
            },
            name: "Dataloop_GetItem",
            description: "Get details of a specific Dataloop AI dataset item by its ID, including metadata and annotations info.");
    }
}
