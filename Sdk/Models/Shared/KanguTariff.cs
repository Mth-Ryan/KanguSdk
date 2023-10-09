using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class KanguTariff
{
    [JsonPropertyName("valor")]
    public required double Valor { get; set; }

    [JsonPropertyName("descricao")]
    public required string Descricao { get; set; }

    [JsonPropertyName("faixa")]
    public required string Faixa { get; set; }
}
