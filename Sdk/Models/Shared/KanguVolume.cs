using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class KanguVolume
{
    [JsonPropertyName("peso")]
    public required double Peso { get; set; }

    [JsonPropertyName("altura")]
    public required uint Altura { get; set; }

    [JsonPropertyName("largura")]
    public required uint Largura { get; set; }

    [JsonPropertyName("comprimento")]
    public required uint Comprimento { get; set; }

    [JsonPropertyName("tipo")]
    public required string Tipo { get; set; } = "C";

    [JsonPropertyName("valor")]
    public required double Valor { get; set; }

    [JsonPropertyName("quantidate")]
    public required uint Quantidade { get; set; }
}
