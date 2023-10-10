using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class TrackingOutput : KanguOutput
{
    [JsonPropertyName("situacao")]
    public required KanguTrakingStatus Situacao { get; set; }

    [JsonPropertyName("historico")]
    public required List<KanguTrakingStatus> Historico { get; set; }
}
