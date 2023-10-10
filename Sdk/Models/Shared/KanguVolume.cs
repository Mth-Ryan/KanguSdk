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
    public required string Tipo { get; set; }

    [JsonPropertyName("produto")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Produto { get; set; }

    [JsonPropertyName("ean")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Ean { get; set; }

    [JsonPropertyName("valor")]
    public required double Valor { get; set; }

    [JsonPropertyName("numeroCli")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NumeroCli { get; set; }

    [JsonPropertyName("quantidade")]
    public required uint Quantidade { get; set; }
}
