using Kangu.Sdk.Models;

namespace Kangu.Sdk;

public interface IKanguClient
{
    Task<KanguResult<List<SimulateOutput>>> Simulate(SimulateInput input);
}
