using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class KanguUser
{
    [JsonPropertyName("nome")]
    public required string Nome { get; set; }

    [JsonPropertyName("cnpjCpf")]
    public string? CnpjCpf { get; set; }

    [JsonPropertyName("contato")]
    public string? Contato { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }

    [JsonPropertyName("telefone")]
    public string? Telefone { get; set; }

    [JsonPropertyName("celular")]
    public string? Celular { get; set; }
}
