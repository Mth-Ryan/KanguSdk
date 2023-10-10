using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class SubmitInput
{
    [JsonPropertyName("gerarPdf")]
    public bool GerarPdf { get; set; } = false;

    [JsonPropertyName("formatoPdf")]
    public string? FormatoPdf { get; set; }

    [JsonPropertyName("pedido")]
    public required KanguOrder Pedido { get; set; }

    [JsonPropertyName("remetente")]
    public required KanguUser Remetente { get; set; }

    [JsonPropertyName("destinatario")]
    public required KanguUser Destinatario { get; set; }

    [JsonPropertyName("produtos")]
    public List<KanguProduct>? Produtos { get; set; }

    [JsonPropertyName("volumes")]
    public List<KanguVolume>? Volumes { get; set; }

    [JsonPropertyName("servicos")]
    public required List<string> Servicos { get; set; }

    [JsonPropertyName("referencia")]
    public string? Referencia { get; set; }

    [JsonPropertyName("pontoPostagem")]
    public string? PontoPostagem { get; set; }

    [JsonPropertyName("pontoEntrega")]
    public string? PontoEntrega { get; set; }

    [JsonPropertyName("transportadora")]
    public string? Transportadora { get; set; }
}
