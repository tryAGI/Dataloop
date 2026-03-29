namespace Dataloop.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static DataloopClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("DATALOOP_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("DATALOOP_API_KEY environment variable is not found.");

        var client = new DataloopClient(apiKey);
        
        return client;
    }
}
