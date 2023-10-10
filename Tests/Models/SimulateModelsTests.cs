using System.Text.Json;
using Kangu.Sdk.Models;
using Newtonsoft.Json.Linq;

namespace Kangu.Tests.Models;

public class SimulateModelsTests
{
    [Fact]
    public void SimulateInput_Should_Serialize_To_Correct_Json()
    {
        var expectedSrc = @"
        {
          ""cepOrigem"": ""string"",
          ""cepDestino"": ""string"",
          ""vlrMerc"": 0,
          ""pesoMerc"": 0,
          ""volumes"": [
            {
              ""peso"": 0,
              ""altura"": 0,
              ""largura"": 0,
              ""comprimento"": 0,
              ""tipo"": ""string"",
              ""valor"": 0,
              ""tipo"": ""string"",
              ""quantidade"": 0
            }
          ],
          ""produtos"": [
            {
              ""peso"": 0,
              ""altura"": 0,
              ""largura"": 0,
              ""comprimento"": 0,
              ""valor"": 0,
              ""quantidade"": 0,
              ""tipo"": ""string"",
              ""produto"": ""string""
            }
          ],
          ""servicos"": [
            ""string""
          ],
          ""ordernar"": ""string""
        }
        ";

        var inputObj = new SimulateInput
        {
            CepOrigem = "string",
            CepDestino = "string",
            VlrMerc = 0.0,
            PresoMerc = 0.0,
            Volumes = new List<KanguVolume>
            {
                new KanguVolume
                {
                    Peso = 0.0,
                    Altura = 0,
                    Largura = 0,
                    Comprimento = 0,
                    Valor = 0.0,
                    Quantidade = 0,
                    Tipo = "string",
                }
            },
            Produtos = new List<KanguProduct>
            {
                new KanguProduct
                {
                    Peso = 0.0,
                    Altura = 0,
                    Largura = 0,
                    Comprimento = 0,
                    Valor = 0.0,
                    Quantidade = 0,
                    Produto = "string",
                    Tipo = "string",
                }
            },
            Servicos = new List<string> { "string" },
            Ordenar = "string"
        };


        var inputSrc = JsonSerializer.Serialize(inputObj);

        var expected = JToken.Parse(expectedSrc);
        var input = JToken.Parse(inputSrc);

        input.Should().BeEquivalentTo(expected);
    }


    [Fact]
    public void SimulateInput_Should_Deserialize_To_Correct_Object()
    {
        var inputSrc = @"
        {
          ""cepOrigem"": ""string"",
          ""cepDestino"": ""string"",
          ""vlrMerc"": 0,
          ""pesoMerc"": 0,
          ""volumes"": [
            {
              ""peso"": 0,
              ""altura"": 0,
              ""largura"": 0,
              ""comprimento"": 0,
              ""tipo"": ""string"",
              ""valor"": 0,
              ""tipo"": ""string"",
              ""quantidade"": 0
            }
          ],
          ""produtos"": [
            {
              ""peso"": 0,
              ""altura"": 0,
              ""largura"": 0,
              ""comprimento"": 0,
              ""valor"": 0,
              ""quantidade"": 0,
              ""tipo"": ""string"",
              ""produto"": ""string""
            }
          ],
          ""servicos"": [
            ""string""
          ],
          ""ordernar"": ""string""
        }
        ";

        var expected = new SimulateInput
        {
            CepOrigem = "string",
            CepDestino = "string",
            VlrMerc = 0.0,
            PresoMerc = 0.0,
            Volumes = new List<KanguVolume>
            {
                new KanguVolume
                {
                    Peso = 0.0,
                    Altura = 0,
                    Largura = 0,
                    Comprimento = 0,
                    Valor = 0.0,
                    Quantidade = 0,
                    Tipo = "string",
                }
            },
            Produtos = new List<KanguProduct>
            {
                new KanguProduct
                {
                    Peso = 0.0,
                    Altura = 0,
                    Largura = 0,
                    Comprimento = 0,
                    Valor = 0.0,
                    Quantidade = 0,
                    Produto = "string",
                    Tipo = "string",
                }
            },
            Servicos = new List<string> { "string" },
            Ordenar = "string"
        };

        var input = JsonSerializer.Deserialize<SimulateInput>(inputSrc);
    
        input.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void SimulateOutput_Should_Deserialize_To_Correct_Object()
    {
        var inputSrc = @"
        {
          ""vlrFrete"": 0,
          ""prazoEnt"": 0,
          ""dtPrevEnt"": ""string"",
          ""tarifas"": [
            {
              ""valor"": 0,
              ""descricao"": ""string"",
              ""faixa"": ""string""
            }
          ],
          ""error"": {
            ""codigo"": ""string"",
            ""mensagem"": ""string""
          },
          ""descricao"": ""string"",
          ""referencia"": ""string""
        }
        ";

        var expected = new SimulateOutput
        {
            VlrFrete = 0.0,
            PrazoEnt = 0,
            DtPrevEnt = "string",
            Tarifas = new List<KanguTariff>
            {
                new KanguTariff
                {
                    Valor = 0.0,
                    Descricao = "string",
                    Faixa = "string"
                }
            },
            Error = new KanguError
            {
                Codigo = "string",
                Mensagem = "string"
            },
            Descricao = "string",
            Referencia = "string"
        };

        var input = JsonSerializer.Deserialize<SimulateOutput>(inputSrc);
    
        input.Should().BeEquivalentTo(expected);
    }
}
