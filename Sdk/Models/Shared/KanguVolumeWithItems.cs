using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class KanguVolumeWithItems
{
    [JsonPropertyName("peso")]
    public required string Peso { get; set; }

    [JsonPropertyName("altura")]
    public required string Altura { get; set; }

    [JsonPropertyName("largura")]
    public required string Largura { get; set; }

    [JsonPropertyName("comprimento")]
    public required string Comprimento { get; set; }

    [JsonPropertyName("tipo")]
    public required string Tipo { get; set; }

    [JsonPropertyName("valor")]
    public required double Valor { get; set; }

    [JsonPropertyName("quantidade")]
    public required uint Quantidade { get; set; }

    [JsonPropertyName("itens")]
    public required List<KanguItem> Itens { get; set; }
}
