using Soenneker.Tests.HostedUnit;

namespace Soenneker.Figma.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class FigmaOpenApiClientRunnerTests : HostedUnitTest
{
    public FigmaOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
