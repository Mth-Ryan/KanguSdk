using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class SimulateInput
{
    [JsonPropertyName("cepOrigem")]
    public required string CepOrigem { get; set; }

    [JsonPropertyName("cepDestino")]
    public required string CepDestino { get; set; }

    [JsonPropertyName("origem")]
    public required string Origem { get; set; }

    [JsonPropertyName("vlrMerc")]
    public required double VlrMerc { get; set; }

    [JsonPropertyName("pesoMerc")]
    public required double PresoMerc { get; set; }

    [JsonPropertyName("produtos")]
    public List<KanguProduct>? Produtos { get; set; }

    [JsonPropertyName("volumes")]
    public List<KanguVolume>? Volumes { get; set; }

    [JsonPropertyName("servicos")]
    public required List<string> Servicos { get; set; }
}
