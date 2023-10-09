using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class SimulateInput
{
    [JsonPropertyName("cepOrigem")]
    public required string CepOrigem { get; set; }

    [JsonPropertyName("cepDestino")]
    public required string CepDestino { get; set; }

    [JsonPropertyName("destinos")]
    public required List<KanguProduct> Produtos { get; set; }

    [JsonPropertyName("servicos")]
    public required List<string> Servicos { get; set; }
}
