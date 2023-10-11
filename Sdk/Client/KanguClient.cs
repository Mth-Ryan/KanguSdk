using System.Text;
using System.Text.Json;
using Kangu.Sdk.Models;

namespace  Kangu.Sdk;

public class KanguClient : IKanguClient
{
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl;
    private readonly Func<HttpRequestMessage, HttpClient, Task>? _requestInterceptor;
    private readonly Func<HttpResponseMessage, HttpClient, Task>? _responseInterceptor;

    public KanguClient(
        string token,
        string baseRoute = "https://portal.kangu.com.br/tms/transporte",
        Func<HttpRequestMessage, HttpClient, Task>? requestInterceptor = null,
        Func<HttpResponseMessage, HttpClient, Task>? responseInterceptor = null)
    {
        _httpClient = new HttpClient();
        _baseUrl = baseRoute;
        _httpClient.DefaultRequestHeaders.Add("token", token);
        _requestInterceptor = requestInterceptor;
        _responseInterceptor = responseInterceptor;
    }

    private async Task<KanguResult<Out>> MakeRequest<In, Out>(string route, HttpMethod method, In? input)
    {
        var request = new HttpRequestMessage(method, _baseUrl + route);
        if (input is not null)
        {
            var body = JsonSerializer.Serialize(input);
            request.Content = new StringContent(body, Encoding.UTF8, "application/json");
        }

        if (_requestInterceptor is not null)
        {
            await _requestInterceptor(request, _httpClient);
        }

        using (var response = await _httpClient.SendAsync(request))
        {
            if (_responseInterceptor is not null)
            {
                await _responseInterceptor(response, _httpClient);
            }

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    var okBody = await response.Content.ReadAsStringAsync();
                    var okContent = JsonSerializer.Deserialize<Out>(okBody);
                    return KanguResult<Out>.Ok(okContent!);
                }
                catch (JsonException e)
                {
                    throw e;

                    var expBody = await response.Content.ReadAsStringAsync();
                    var expContent = JsonSerializer.Deserialize<KanguRequestError>(expBody);
                    return KanguResult<Out>.Err(expContent!);
                }
            }

            var errBody = await response.Content.ReadAsStringAsync();
            var errContent = JsonSerializer.Deserialize<KanguRequestError>(errBody);
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
