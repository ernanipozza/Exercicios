using ExerciciosM02S09.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ExerciciosM02S09.Controllers {
    [Route("api/tratamento")]
    [ApiController]
    public class TratamentoController : ControllerBase {

        /// <summary>
        /// Retorna tratamentos
        /// </summary>
        /// <returns>Retorna todos os tratamentos no banco.</returns>
        /// <response code="200">Retorno da lista de tratamentos.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Tratamento> Get() {
            var tratamentos = new List<Tratamento> {

            };
            return tratamentos;
        }

        /// <summary>
        /// Retorna um tratamento
        /// </summary>
        /// <param name="id">Representa o Id do Item</param>
        /// <returns>Retorna um tratamento específico.</returns>
        /// <response code="200">Retorno da lista de tratamentos.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Tratamento Get(int id) {
            var tratamentos = new List<Tratamento> {
            };
            var resultado = tratamentos.FirstOrDefault(x => x.Id == id);
            return resultado;
        }

        /// <summary>
        /// Insere um tratamento
        /// </summary>
        /// <response code="201">Tratamento inserido.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Post([FromBody] Tratamento tratamento) {
            var tratamentos = new List<Tratamento> {
            };
            tratamentos.Add(tratamento);
        }

        /// <summary>
        /// Edita um tratamento
        /// </summary>
        /// <param name="id">Representa o Id do Item</param>
        /// <returns>Edita um tratamento específico.</returns>
        /// <response code="200">Item editado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Put(int id, [FromBody] Tratamento tratamento) {
            var tratamentos = new List<Tratamento> {
            };
            var tratamentoAlterado = tratamentos
                .Where(x => x.Id == id)
                .Select(x => new Tratamento {
                    Id = x.Id,
                    DataInicio = x.DataInicio,
                    DataFinal = x.DataFinal,
                    Consulta = x.Consulta,
                    Exame = x.Exame,
                    Descricao = x.Descricao
                })
                .FirstOrDefault();
        }

        /// <summary>
        /// Deleta um tratamento
        /// </summary>
        /// <param name="id">Representa o Id do Item</param>
        /// <returns>Deleta um tratamento específico.</returns>
        /// <response code="200">Item deletado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Delete(int id) {
            var tratamentos = new List<Tratamento> {
            };
            tratamentos.RemoveAt(id);
        }
    }
}