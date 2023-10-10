using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class KanguProduct
{
    [JsonPropertyName("peso")]
    public required double Peso { get; set; }

    [JsonPropertyName("altura")]
    public required double Altura { get; set; }

    [JsonPropertyName("largura")]
    public required double Largura { get; set; }

    [JsonPropertyName("comprimento")]
    public required double Comprimento { get; set; }

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
