using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class KanguTag
{
    [JsonPropertyName("numero")]
    public required string Numero { get; set; }

    [JsonPropertyName("numeroTransp")]
    public required string NumeroTransp { get; set; }

    [JsonPropertyName("pdf")]
    public required string Pdf { get; set; }

    [JsonPropertyName("volume")]
    public required List<KanguVolumeWithItems> Volume { get; set; }
}
