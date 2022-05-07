using ExerciciosM02S09.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ExerciciosM02S09.Controllers {
    [Route("api/exame")]
    [ApiController]
    public class ExameController : ControllerBase {

        /// <summary>
        /// Retorna exames.
        /// </summary>
        /// <returns>Retorna todos os exames no banco.</returns>
        /// <response code="200">Retorno da lista de exames.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Exame> Get() {
            var exames = new List<Exame> {

            };
            return exames;
        }

        /// <summary>
        /// Retorna um exame.
        /// </summary>
        /// <param name="id">Representa o Id do Item</param>
        /// <returns>Retorna um exame específico.</returns>
        /// <response code="200">Retorno do exame.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Exame Get(int id) {
            var exames = new List<Exame> {
            };
            var resultado = exames.FirstOrDefault(x => x.Id == id);
            return resultado;
        }

        /// <summary>
        /// Insere um exame.
        /// </summary>
        /// <response code="201">Exame inserido.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Post([FromBody] Exame exame) {
            var exames = new List<Exame> {
            };
            exames.Add(exame);
        }

        /// <summary>
        /// Edita um exame.
        /// </summary>
        /// <param name="id">Representa o Id do Item</param>
        /// <returns>Edita um exame específico.</returns>
        /// <response code="200">Item editado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Put(int id, [FromBody] Exame exame) {
            var exames = new List<Exame> {
            };
            var clienteAlterado = exames
                .Where(x => x.Id == id)
                .Select(x => new Exame {
                    Id = x.Id,
                    Descricao = x.Descricao,
                    Consulta = x.Consulta
                })
                .FirstOrDefault();
        }

        /// <summary>
        /// Deleta um exame.
        /// </summary>
        /// <param name="id">Representa o Id do Item</param>
        /// <returns>Deleta um exame específico.</returns>
        /// <response code="200">Item deletado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Delete(int id) {
            var exames = new List<Exame> {
            };
            exames.RemoveAt(id);
        }
    }
}