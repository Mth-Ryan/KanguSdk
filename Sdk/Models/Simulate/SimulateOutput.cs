using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class SimulateOutput : KanguOutput
{
    [JsonPropertyName("vlrFrete")]
    public required double VlrFrete { get; set; }

    [JsonPropertyName("prazoEnt")]
    public required uint PrazoEnt { get; set; }

    [JsonPropertyName("dtPrevEnt")]
    public required string DtPrevEnt { get; set; }

    [JsonPropertyName("dtPrevEntMin")]
    public required string DtPrevEntMin { get; set; }

    [JsonPropertyName("tarifas")]
    public required List<KanguTariff> Tarifas { get; set; }

    [JsonPropertyName("idSimulacao")]
    public required int IdSimulacao { get; set; }

    [JsonPropertyName("idTransp")]
    public required int IdTransp { get; set; }

    [JsonPropertyName("cnpjTransp")]
    public required string CnpjTransp { get; set; }

    [JsonPropertyName("idTranspResp")]
    public required int IdTranspResp { get; set; }

    [JsonPropertyName("cnpjTranspResp")]
    public required string CnpjTranspResp { get; set; }

    [JsonPropertyName("alertas")]
    public required List<string> Alertas { get; set; }

    [JsonPropertyName("nf_obrig")]
    public required string NfObrig { get; set; }

    [JsonPropertyName("url_logo")]
    public required string UrlLogo { get; set; }

    [JsonPropertyName("transp_nome")]
    public required string TranspNome { get; set; }

    [JsonPropertyName("descricao")]
    public required string Descricao { get; set; }

    [JsonPropertyName("servico")]
    public required string Servico { get; set; }

    [JsonPropertyName("referencia")]
    public required string Referencia { get; set; }
}
