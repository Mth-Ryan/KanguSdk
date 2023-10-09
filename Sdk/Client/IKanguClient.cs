using Kangu.Sdk.Models;

namespace Kangu.Sdk;

public interface IKanguClient
{
    Task<KanguResult<SimulateOutput>> Simulate(SimulateInput input);
}
