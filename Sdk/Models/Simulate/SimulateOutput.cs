using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class SimulateOutput : KanguOutput
{
    [JsonPropertyName("vlrFrete")]
    public required double VlrFrete { get; set; }

    [JsonPropertyName("prazoEnt")]
    public required uint PrazoEnt { get; set; }

    [JsonPropertyName("descricao")]
    public required string Descricao { get; set; }

    [JsonPropertyName("referencia")]
    public required string Referencia { get; set; }

    [JsonPropertyName("tarifas")]
    public required List<KanguTariff> Tarifas { get; set; }
}
