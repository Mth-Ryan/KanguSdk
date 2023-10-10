using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class KanguProduct
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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Tipo { get; set; }

    [JsonPropertyName("valor")]
    public required double Valor { get; set; }

    [JsonPropertyName("produto")]
    public required string Produto { get; set; }

    [JsonPropertyName("quantidade")]
    public required uint Quantidade { get; set; }
}
