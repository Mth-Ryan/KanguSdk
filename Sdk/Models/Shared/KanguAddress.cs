using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class KanguAddress
{
    [JsonPropertyName("logradouro")]
    public required string Logradouro { get; set; }

    [JsonPropertyName("complemento")]
    public required string Complemento { get; set; }

    [JsonPropertyName("numero")]
    public required string Numero { get; set; }

    [JsonPropertyName("bairro")]
    public required string Bairro { get; set; }

    [JsonPropertyName("cidade")]
    public required string Cidade { get; set; }

    [JsonPropertyName("uf")]
    public required string Uf { get; set; }

    [JsonPropertyName("cep")]
    public required string Cep { get; set; }
}
