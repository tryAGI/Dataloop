/*
order: 20
title: MEAI Tools
slug: meai-tools

Example showing how to use Dataloop AIFunction tools with any Microsoft.Extensions.AI IChatClient.
*/

using Microsoft.Extensions.AI;

namespace Dataloop.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_MeaiTools()
    {
        //// Create an authenticated Dataloop client
        using var client = GetAuthenticatedClient();

        //// Create AIFunction tools for use with any IChatClient
        var listProjectsTool = client.AsListProjectsTool();
        var listDatasetsTool = client.AsListDatasetsTool();
        var listTasksTool = client.AsListTasksTool();
        var getItemTool = client.AsGetItemTool();

        //// Verify tools are created with correct metadata
        listProjectsTool.Name.Should().Be("Dataloop_ListProjects");
        listDatasetsTool.Name.Should().Be("Dataloop_ListDatasets");
        listTasksTool.Name.Should().Be("Dataloop_ListTasks");
        getItemTool.Name.Should().Be("Dataloop_GetItem");

        //// These tools can be passed to any IChatClient for function calling:
        //// var response = await chatClient.GetResponseAsync(
        ////     "List my Dataloop projects",
        ////     new() { Tools = [listProjectsTool, listDatasetsTool] });
    }
}
