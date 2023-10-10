using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class SimulateInput
{
    [JsonPropertyName("cepOrigem")]
    public required string CepOrigem { get; set; }

    [JsonPropertyName("cepDestino")]
    public required string CepDestino { get; set; }

    [JsonPropertyName("vlrMerc")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? VlrMerc { get; set; }

    [JsonPropertyName("pesoMerc")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? PresoMerc { get; set; }

    [JsonPropertyName("produtos")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<KanguProduct>? Produtos { get; set; }

    [JsonPropertyName("volumes")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<KanguVolume>? Volumes { get; set; }

    [JsonPropertyName("servicos")]
    public required List<string> Servicos { get; set; }

    [JsonPropertyName("ordernar")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Ordenar { get; set; }
}
