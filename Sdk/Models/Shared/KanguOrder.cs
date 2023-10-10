using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class KanguOrder
{
    [JsonPropertyName("tipo")]
    public required string Tipo { get; set; }

    [JsonPropertyName("numero")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Numero { get; set; }

    [JsonPropertyName("serie")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Serie { get; set; }

    [JsonPropertyName("chave")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Chave { get; set; }

    [JsonPropertyName("chaveCTe")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ChaveCTe { get; set; }

    [JsonPropertyName("xml")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Xml { get; set; }

    [JsonPropertyName("numeroCli")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NumeroCli { get; set; }

    [JsonPropertyName("vlrMerc")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? VlrMerc { get; set; }

    [JsonPropertyName("pesoMerc")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? PesoMerc { get; set; }
}
