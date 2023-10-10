using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class KanguOrder
{
    [JsonPropertyName("tipo")]
    public required string Tipo { get; set; }

    [JsonPropertyName("numeroCli")]
    public string? NumeroCli { get; set; }

    [JsonPropertyName("vlrMerc")]
    public double? VlrMerc { get; set; }

    [JsonPropertyName("pesoMerc")]
    public double? pesoMerc { get; set; }
}
