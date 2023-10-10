using System.Text.Json;
using Kangu.Sdk.Models;
using Newtonsoft.Json.Linq;

namespace Kangu.Tests.Models;

public class SubmitModelsTests
{
    [Fact]
    public void SubmitInput_Should_Serialize_To_Json()
    {
        var expectedSrc = @"
        {
          ""gerarPdf"": true,
          ""formatoPdf"": ""string"",
          ""pedido"": {
            ""tipo"": ""string"",
            ""numero"": ""string"",
            ""serie"": ""string"",
            ""chave"": ""string"",
            ""chaveCTe"": ""string"",
            ""xml"": ""string"",
            ""numeroCli"": ""string"",
            ""vlrMerc"": 0,
            ""pesoMerc"": 0
          },
          ""remetente"": {
            ""nome"": ""string"",
            ""cnpjCpf"": ""string"",
            ""endereco"": {
              ""logradouro"": ""string"",
              ""numero"": ""string"",
              ""complemento"": ""string"",
              ""bairro"": ""string"",
              ""cep"": ""string"",
              ""cidade"": ""string"",
              ""uf"": ""string""
            },
            ""contato"": ""string"",
            ""email"": ""string"",
            ""telefone"": ""string"",
            ""celular"": ""string""
          },
          ""destinatario"": {
            ""nome"": ""string"",
            ""cnpjCpf"": ""string"",
            ""endereco"": {
              ""logradouro"": ""string"",
              ""numero"": ""string"",
              ""complemento"": ""string"",
              ""bairro"": ""string"",
              ""cep"": ""string"",
              ""cidade"": ""string"",
              ""uf"": ""string""
            },
            ""contato"": ""string"",
            ""email"": ""string"",
            ""telefone"": ""string"",
            ""celular"": ""string""
          },
          ""volumes"": [
            {
              ""peso"": 0,
              ""altura"": 0,
              ""largura"": 0,
              ""comprimento"": 0,
              ""tipo"": ""string"",
              ""produto"": ""string"",
              ""ean"": ""string"",
              ""valor"": 0,
              ""quantidade"": 0,
              ""numeroCli"": ""string""
            }
          ],
          ""produtos"": [
            {
              ""peso"": 0,
              ""altura"": 0,
              ""largura"": 0,
              ""comprimento"": 0,
              ""produto"": ""string"",
              ""valor"": 0,
              ""quantidade"": 0
            }
          ],
          ""pontoPostagem"": ""string"",
          ""pontoEntrega"": ""string"",
          ""transportadora"": ""string"",
          ""referencia"": ""string"",
          ""servicos"": [
            ""string""
          ]
        }
        ";

        var inputObj = new SubmitInput
        {
            GerarPdf = true,
            FormatoPdf = "string",
            Pedido = new KanguOrder
            {
                Tipo = "string",
                Numero = "string",
                Serie = "string",
                Chave = "string",
                ChaveCTe = "string",
                Xml = "string",
                NumeroCli = "string",
                VlrMerc = 0.0,
                PesoMerc  = 0.0
            },
            Remetente = new KanguUser
            {
                Nome = "string",
                CnpjCpf = "string",
                Endereco = new KanguAddress
                {
                    Logradouro = "string",
                    Numero = "string",
                    Complemento = "string",
                    Bairro = "string",
                    Cep = "string",
                    Cidade = "string",
                    Uf = "string"
                },
                Contato = "string",
                Email = "string",
                Telefone = "string",
                Celular = "string"
            },
            Destinatario = new KanguUser
            {
                Nome = "string",
                CnpjCpf = "string",
                Endereco = new KanguAddress
                {
                    Logradouro = "string",
                    Numero = "string",
                    Complemento = "string",
                    Bairro = "string",
                    Cep = "string",
                    Cidade = "string",
                    Uf = "string"
                },
                Contato = "string",
                Email = "string",
                Telefone = "string",
                Celular = "string"
            },
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
                    Ean = "string",
                    Produto = "string",
                    NumeroCli = "string"
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
                }
            },
            PontoEntrega = "string",
            PontoPostagem = "string",
            Transportadora = "string",
            Referencia = "string",
            Servicos = new List<string> { "string" },
        };

        var inputSrc = JsonSerializer.Serialize(inputObj);
        var input = JToken.Parse(inputSrc);
        var expected = JToken.Parse(expectedSrc);

        input.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void SubmitInput_Should_Deserialize_To_Obj()
    {
        var inputSrc = @"
        {
          ""gerarPdf"": true,
          ""formatoPdf"": ""string"",
          ""pedido"": {
            ""tipo"": ""string"",
            ""numero"": ""string"",
            ""serie"": ""string"",
            ""chave"": ""string"",
            ""chaveCTe"": ""string"",
            ""xml"": ""string"",
            ""numeroCli"": ""string"",
            ""vlrMerc"": 0,
            ""pesoMerc"": 0
          },
          ""remetente"": {
            ""nome"": ""string"",
            ""cnpjCpf"": ""string"",
            ""endereco"": {
              ""logradouro"": ""string"",
              ""numero"": ""string"",
              ""complemento"": ""string"",
              ""bairro"": ""string"",
              ""cep"": ""string"",
              ""cidade"": ""string"",
              ""uf"": ""string""
            },
            ""contato"": ""string"",
            ""email"": ""string"",
            ""telefone"": ""string"",
            ""celular"": ""string""
          },
          ""destinatario"": {
            ""nome"": ""string"",
            ""cnpjCpf"": ""string"",
            ""endereco"": {
              ""logradouro"": ""string"",
              ""numero"": ""string"",
              ""complemento"": ""string"",
              ""bairro"": ""string"",
              ""cep"": ""string"",
              ""cidade"": ""string"",
              ""uf"": ""string""
            },
            ""contato"": ""string"",
            ""email"": ""string"",
            ""telefone"": ""string"",
            ""celular"": ""string""
          },
          ""volumes"": [
            {
              ""peso"": 0,
              ""altura"": 0,
              ""largura"": 0,
              ""comprimento"": 0,
              ""tipo"": ""string"",
              ""produto"": ""string"",
              ""ean"": ""string"",
              ""valor"": 0,
              ""quantidade"": 0,
              ""numeroCli"": ""string""
            }
          ],
          ""produtos"": [
            {
              ""peso"": 0,
              ""altura"": 0,
              ""largura"": 0,
              ""comprimento"": 0,
              ""produto"": ""string"",
              ""valor"": 0,
              ""quantidade"": 0
            }
          ],
          ""pontoPostagem"": ""string"",
          ""pontoEntrega"": ""string"",
          ""transportadora"": ""string"",
          ""referencia"": ""string"",
          ""servicos"": [
            ""string""
          ]
        }
        ";

        var expected = new SubmitInput
        {
            GerarPdf = true,
            FormatoPdf = "string",
            Pedido = new KanguOrder
            {
                Tipo = "string",
                Numero = "string",
                Serie = "string",
                Chave = "string",
                ChaveCTe = "string",
                Xml = "string",
                NumeroCli = "string",
                VlrMerc = 0.0,
                PesoMerc  = 0.0
            },
            Remetente = new KanguUser
            {
                Nome = "string",
                CnpjCpf = "string",
                Endereco = new KanguAddress
                {
                    Logradouro = "string",
                    Numero = "string",
                    Complemento = "string",
                    Bairro = "string",
                    Cep = "string",
                    Cidade = "string",
                    Uf = "string"
                },
                Contato = "string",
                Email = "string",
                Telefone = "string",
                Celular = "string"
            },
            Destinatario = new KanguUser
            {
                Nome = "string",
                CnpjCpf = "string",
                Endereco = new KanguAddress
                {
                    Logradouro = "string",
                    Numero = "string",
                    Complemento = "string",
                    Bairro = "string",
                    Cep = "string",
                    Cidade = "string",
                    Uf = "string"
                },
                Contato = "string",
                Email = "string",
                Telefone = "string",
                Celular = "string"
            },
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
                    Ean = "string",
                    Produto = "string",
                    NumeroCli = "string"
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
                }
            },
            PontoEntrega = "string",
            PontoPostagem = "string",
            Transportadora = "string",
            Referencia = "string",
            Servicos = new List<string> { "string" },
        };

        
        var input = JsonSerializer.Deserialize<SubmitInput>(inputSrc);

        input.Should().BeEquivalentTo(expected);
    }


    [Fact]
    public void SubmitOutput_Should_Deserialize_To_Obj()
    {
        var inputSrc = @"
        {
          ""codigo"": ""string"",
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
          ""etiquetas"": [
            {
              ""numero"": ""string"",
              ""numeroTransp"": ""string"",
              ""pdf"": ""string"",
              ""volume"": [
                {
                  ""peso"": ""string"",
                  ""altura"": ""string"",
                  ""largura"": ""string"",
                  ""comprimento"": ""string"",
                  ""tipo"": ""string"",
                  ""valor"": 0,
                  ""quantidade"": 0,
                  ""itens"": [
                    {
                      ""produto"": ""string"",
                      ""peso"": ""string"",
                      ""altura"": ""string"",
                      ""largura"": ""string"",
                      ""comprimento"": ""string"",
                      ""tipo"": ""string"",
                      ""valor"": 0,
                      ""quantidade"": 0
                    }
                  ]
                }
              ]
            }
          ],
          ""error"": {
            ""codigo"": ""string"",
            ""mensagem"": ""string""
          }
        }
        ";

        var expected = new SubmitOutput
        {
            Codigo = "string",
            VlrFrete = 0.0,
            PrazoEnt = 0.0,
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
            Etiquetas = new List<KanguTag>
            {
                new KanguTag
                {
                    Numero = "string",
                    NumeroTransp = "string",
                    Pdf = "string",
                    Volume = new List<KanguVolumeWithItems>
                    {
                        new KanguVolumeWithItems
                        {
                            Peso = "string",
                            Altura = "string",
                            Largura = "string",
                            Comprimento = "string",
                            Tipo = "string",
                            Valor = 0.0,
                            Quantidade = 0,
                            Itens = new List<KanguItem>
                            {
                                new KanguItem
                                {
                                    Produto = "string",
                                    Peso = "string",
                                    Altura = "string",
                                    Largura = "string",
                                    Comprimento = "string",
                                    Tipo = "string",
                                    Valor = 0.0,
                                    Quantidade = 0,
                                }
                            }
                        }
                    }
                }
            },
            Error = new KanguError
            {
                Codigo = "string",
                Mensagem = "string"
            }
        };

        
        var input = JsonSerializer.Deserialize<SubmitOutput>(inputSrc);

        input.Should().BeEquivalentTo(expected);
    }
}
