using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class KanguTrakingStatus
{
    [JsonPropertyName("ocorrencia")]
    public required string Ocorrencia { get; set; }

    [JsonPropertyName("data")]
    public required string Data { get; set; }

    [JsonPropertyName("observacao")]
    public required string Observacao { get; set; }

    [JsonPropertyName("recebedor")]
    public required string Recebedor { get; set; }

    [JsonPropertyName("acao")]
    public required string Acao { get; set; }
}
