using System.Text.Json.Serialization;

namespace Kangu.Sdk.Models;

public class KanguUser
{
    [JsonPropertyName("nome")]
    public required string Nome { get; set; }

    [JsonPropertyName("cnpjCpf")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CnpjCpf { get; set; }

    [JsonPropertyName("endereco")]
    public required KanguAddress Endereco { get; set; }

    [JsonPropertyName("contato")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Contato { get; set; }

    [JsonPropertyName("email")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Email { get; set; }

    [JsonPropertyName("telefone")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Telefone { get; set; }

    [JsonPropertyName("celular")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Celular { get; set; }
}
