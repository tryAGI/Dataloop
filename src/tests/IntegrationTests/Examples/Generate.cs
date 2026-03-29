/*
order: 10
title: List Projects
slug: list-projects

Basic example showing how to create a client and list annotation projects.
*/

namespace Dataloop.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListProjects()
    {
        //// Create an authenticated Dataloop client
        using var client = GetAuthenticatedClient();

        //// List all projects accessible by the authenticated user
        var projects = await client.Projects.GetMyProjectsAsync();

        projects.Should().NotBeNull();
    }
}
