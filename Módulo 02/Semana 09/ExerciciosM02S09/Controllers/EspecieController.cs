using ExerciciosM02S09.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ExerciciosM02S09.Controllers {
    [Route("api/especie")]
    [ApiController]
    public class EspecieController : ControllerBase {

        /// <summary>
        /// Retorna espécies.
        /// </summary>
        /// <returns>Retorna todos as espécies no banco.</returns>
        /// <response code="200">Retorno da lista de espécies.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Especie> Get() {
            var especies = new List<Especie> {
                new Especie {Id = 1, Nome = "Cachorro", Descricao = "Animal da família dos canídeos, tudo sem vergonha!"},
                new Especie {Id = 2, Nome = "Gato", Descricao = "Animal da família dos felídeos, tudo safado!"},
                new Especie {Id = 3, Nome = "Passarinho", Descricao = "LUGAR DE PASSARINHO É FORA DA GAIOLA!"},
                new Especie {Id = 4, Nome = "Peixe", Descricao = "LUGAR DE PEIXE É NO MAR/RIO/LAGO/LAGOA!"},
                new Especie {Id = 5, Nome = "Vaca", Descricao = "Ué, também pode ser!"},
                new Especie {Id = 6, Nome = "Girafa", Descricao = "Eita preula"},
                new Especie {Id = 7, Nome = "Baleia", Descricao = "Tá de sacanagem??"}
            };
            return especies;
        }

        /// <summary>
        /// Retorna uma espécies
        /// </summary>
        /// <param name="id">Representa o Id do Item</param>
        /// <returns>Retorna uma espécie específica.</returns>
        /// <response code="200">Retorno da espécie.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Especie Get(int id) {
            var especies = new List<Especie> {
                new Especie {Id = 1, Nome = "Cachorro", Descricao = "Animal da família dos canídeos, tudo sem vergonha!"},
                new Especie {Id = 2, Nome = "Gato", Descricao = "Animal da família dos felídeos, tudo safado!"},
                new Especie {Id = 3, Nome = "Passarinho", Descricao = "LUGAR DE PASSARINHO É FORA DA GAIOLA!"},
                new Especie {Id = 4, Nome = "Peixe", Descricao = "LUGAR DE PEIXE É NO MAR/RIO/LAGO/LAGOA!"},
                new Especie {Id = 5, Nome = "Vaca", Descricao = "Ué, também pode ser!"},
                new Especie {Id = 6, Nome = "Girafa", Descricao = "Eita preula"},
                new Especie {Id = 7, Nome = "Baleia", Descricao = "Tá de sacanagem??"}
            };
            var resultado = especies.FirstOrDefault(x => x.Id == id);
            return resultado;
        }

        /// <summary>
        /// Insere uma espécie.
        /// </summary>
        /// <response code="201">Espécie inserido.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Post([FromBody] Especie especie) {
            var especies = new List<Especie> {
                new Especie {Id = 1, Nome = "Cachorro", Descricao = "Animal da família dos canídeos, tudo sem vergonha!"},
                new Especie {Id = 2, Nome = "Gato", Descricao = "Animal da família dos felídeos, tudo safado!"},
                new Especie {Id = 3, Nome = "Passarinho", Descricao = "LUGAR DE PASSARINHO É FORA DA GAIOLA!"},
                new Especie {Id = 4, Nome = "Peixe", Descricao = "LUGAR DE PEIXE É NO MAR/RIO/LAGO/LAGOA!"},
                new Especie {Id = 5, Nome = "Vaca", Descricao = "Ué, também pode ser!"},
                new Especie {Id = 6, Nome = "Girafa", Descricao = "Eita preula"},
                new Especie {Id = 7, Nome = "Baleia", Descricao = "Tá de sacanagem??"}
            };
            especies.Add(especie);
        }


        /// <summary>
        /// Edita uma espécie.
        /// </summary>
        /// <param name="id">Representa o Id do Item</param>
        /// <returns>Edita uma espécie específica.</returns>
        /// <response code="200">Item editado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Put(int id, [FromBody] Especie especie) {
            var especies = new List<Especie> {
                new Especie {Id = 1, Nome = "Cachorro", Descricao = "Animal da família dos canídeos, tudo sem vergonha!"},
                new Especie {Id = 2, Nome = "Gato", Descricao = "Animal da família dos felídeos, tudo safado!"},
                new Especie {Id = 3, Nome = "Passarinho", Descricao = "LUGAR DE PASSARINHO É FORA DA GAIOLA!"},
                new Especie {Id = 4, Nome = "Peixe", Descricao = "LUGAR DE PEIXE É NO MAR/RIO/LAGO/LAGOA!"},
                new Especie {Id = 5, Nome = "Vaca", Descricao = "Ué, também pode ser!"},
                new Especie {Id = 6, Nome = "Girafa", Descricao = "Eita preula"},
                new Especie {Id = 7, Nome = "Baleia", Descricao = "Tá de sacanagem??"}
            };
            var especieAlterada = especies
                .Where(x => x.Id == id)
                .Select(x => new Especie {
                    Id = x.Id,
                    Nome = x.Nome,
                    Descricao = x.Descricao
                })
                .FirstOrDefault();
        }

        /// <summary>
        /// Deleta uma espécie.
        /// </summary>
        /// <param name="id">Representa o Id do Item</param>
        /// <returns>Deleta uma espécie específico.</returns>
        /// <response code="200">Item deletado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Delete(int id) {
            var especies = new List<Especie> {
                new Especie {Id = 1, Nome = "Cachorro", Descricao = "Animal da família dos canídeos, tudo sem vergonha!"},
                new Especie {Id = 2, Nome = "Gato", Descricao = "Animal da família dos felídeos, tudo safado!"},
                new Especie {Id = 3, Nome = "Passarinho", Descricao = "LUGAR DE PASSARINHO É FORA DA GAIOLA!"},
                new Especie {Id = 4, Nome = "Peixe", Descricao = "LUGAR DE PEIXE É NO MAR/RIO/LAGO/LAGOA!"},
                new Especie {Id = 5, Nome = "Vaca", Descricao = "Ué, também pode ser!"},
                new Especie {Id = 6, Nome = "Girafa", Descricao = "Eita preula"},
                new Especie {Id = 7, Nome = "Baleia", Descricao = "Tá de sacanagem??"}
            };
            especies.RemoveAt(id);
        }
    }
}