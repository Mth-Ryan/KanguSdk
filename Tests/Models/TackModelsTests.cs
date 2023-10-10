using System.Text.Json;
using Kangu.Sdk.Models;

namespace Kangu.Tests.Models;

public class TrackModelsTests
{
    [Fact]
    public void TackOutput_Should_Deserialize_To_Obj()
    {
        var inputSrc = @"
        {
          ""situacao"": {
            ""ocorrencia"": ""string"",
            ""data"": ""string"",
            ""observacao"": ""string"",
            ""recebedor"": ""string"",
            ""acao"": ""string""
          },
          ""historico"": [
            {
              ""ocorrencia"": ""string"",
              ""data"": ""string"",
              ""observacao"": ""string"",
              ""recebedor"": ""string"",
              ""acao"": ""string""
            }
          ],
          ""error"": {
            ""codigo"": ""string"",
            ""mensagem"": ""string""
          }
        }
        ";

        var expected = new TrackingOutput
        {
            Situacao = new KanguTrakingStatus
            {
                Ocorrencia = "string",
                Data = "string",
                Observacao = "string",
                Recebedor = "string",
                Acao = "string"
            },
            Historico = new List<KanguTrakingStatus>
            {
                new KanguTrakingStatus
                {
                    Ocorrencia = "string",
                    Data = "string",
                    Observacao = "string",
                    Recebedor = "string",
                    Acao = "string"
                }
            },
            Error = new KanguError
            {
                Codigo = "string",
                Mensagem = "string"
            }
        };

        var input = JsonSerializer.Deserialize<TrackingOutput>(inputSrc);

        input.Should().BeEquivalentTo(expected);
    }
}
