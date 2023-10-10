using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class KanguVolumeWithItems
{
    [JsonPropertyName("itens")]
    public required List<KanguProduct> Itens { get; set; }
}
