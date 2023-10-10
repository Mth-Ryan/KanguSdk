using System.Net.Http.Json;
using Kangu.Sdk.Models;

namespace  Kangu.Sdk;

public class KanguClient : IKanguClient
{
    private readonly HttpClient _httpClient;

    public KanguClient(string token, string baseRoute = "https://portal.kangu.com.br/tms/transporte1")
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri(baseRoute);
        _httpClient.DefaultRequestHeaders.Add("token", token);
    }

    private async Task<KanguResult<Out>> MakeRequest<In, Out>(string route, HttpMethod method, In? input)
    {
        var request = new HttpRequestMessage(method, route);
        if (input is not null)
        {
            request.Content = JsonContent.Create(input);
        }
        using (var response = await _httpClient.SendAsync(request))
        {
            if (response.IsSuccessStatusCode)
            {
                var okContent = await response.Content.ReadFromJsonAsync<Out>();
                return KanguResult<Out>.Ok(okContent!);
            }

            var errContent = await response.Content.ReadFromJsonAsync<KanguRequestError>();
            return KanguResult<Out>.Err(errContent!);
        }
    }

    public async Task<KanguResult<List<SimulateOutput>>> Simulate(SimulateInput input)
    {
        return await MakeRequest<SimulateInput, List<SimulateOutput>>("/simular", HttpMethod.Post, input);
    }

    public async Task<KanguResult<SubmitOutput>> Submit(SubmitInput input)
    {
        return await MakeRequest<SubmitInput, SubmitOutput>("/solicitar", HttpMethod.Post, input);
    }

    public async Task<KanguResult<TrackingOutput>> Track(string code)
    {
        return await MakeRequest<NoBody, TrackingOutput>($"/rastrear/{code}", HttpMethod.Get, null);
    }

    public async Task<KanguResult<NoBody>> Cancel(string code)
    {
        return await MakeRequest<NoBody, NoBody>($"/cancelar/{code}", HttpMethod.Get, null);
    }
}
