using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class SubmitInput
{
    [JsonPropertyName("gerarPdf")]
    public bool GerarPdf { get; set; }

    [JsonPropertyName("formatoPdf")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? FormatoPdf { get; set; }

    [JsonPropertyName("pedido")]
    public required KanguOrder Pedido { get; set; }

    [JsonPropertyName("origem")]
    public required string Origem { get; set; }

    [JsonPropertyName("remetente")]
    public required KanguUser Remetente { get; set; }

    [JsonPropertyName("destinatario")]
    public required KanguUser Destinatario { get; set; }

    [JsonPropertyName("produtos")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<KanguProduct>? Produtos { get; set; }

    [JsonPropertyName("volumes")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<KanguVolume>? Volumes { get; set; }

    [JsonPropertyName("servicos")]
    public required List<string> Servicos { get; set; }

    [JsonPropertyName("referencia")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Referencia { get; set; }

    [JsonPropertyName("pontoPostagem")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PontoPostagem { get; set; }

    [JsonPropertyName("pontoEntrega")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PontoEntrega { get; set; }

    [JsonPropertyName("transportadora")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Transportadora { get; set; }
}
