using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class SubmitOutput : KanguOutput
{
    [JsonPropertyName("codigo")]
    public required string Codigo { get; set; }

    [JsonPropertyName("vlrFrete")]
    public required double VlrFrete { get; set; }

    [JsonPropertyName("prazoEnt")]
    public required double PrazoEnt { get; set; }

    [JsonPropertyName("dtPrevEnt")]
    public required string DtPrevEnt { get; set; }

    [JsonPropertyName("tarifas")]
    public required List<KanguTariff> Tarifas { get; set; }

    [JsonPropertyName("etiquestas")]
    public required List<KanguTag> Etiquestas { get; set; }
}