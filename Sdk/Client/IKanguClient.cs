using Kangu.Sdk.Models;

namespace Kangu.Sdk;

public interface IKanguClient
{
    Task<KanguResult<List<SimulateOutput>>> Simulate(SimulateInput input);
    Task<KanguResult<SubmitOutput>> Submit(SubmitInput input);
    Task<KanguResult<TrackingOutput>> Track(string code);
}
