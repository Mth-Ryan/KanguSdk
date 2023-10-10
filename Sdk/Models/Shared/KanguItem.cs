using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class KanguItem
{
    [JsonPropertyName("produto")]
    public required string Produto { get; set; }

    [JsonPropertyName("peso")]
    public required string Peso { get; set; }

    [JsonPropertyName("altura")]
    public required string Altura { get; set; }

    [JsonPropertyName("largura")]
    public required string Largura { get; set; }

    [JsonPropertyName("comprimento")]
    public required string Comprimento { get; set; }

    [JsonPropertyName("tipo")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public required string Tipo { get; set; }

    [JsonPropertyName("valor")]
    public required double Valor { get; set; }

    [JsonPropertyName("quantidade")]
    public required uint Quantidade { get; set; }
}
