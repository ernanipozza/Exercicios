using ExerciciosM02S09.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ExerciciosM02S09.Controllers {
    [Route("api/consulta")]
    [ApiController]
    public class ConsultaController : ControllerBase {

        /// <summary>
        /// Retorna consultas.
        /// </summary>
        /// <returns>Retorna todas as consultas no banco.</returns>
        /// <response code="200">Retorno da lista de consultas.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Consulta> Get() {
            var consultas = new List<Consulta> {

            };
            return consultas;
        }

        /// <summary>
        /// Retorna uma consulta.
        /// </summary>
        /// <param name="id">Representa o Id do Item</param>
        /// <returns>Retorna uma consulta específica.</returns>
        /// <response code="200">Retorno da consulta.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Consulta Get(int id) {
            var consultas = new List<Consulta> {
            };
            var resultado = consultas.FirstOrDefault(x => x.Id == id);
            return resultado;
        }

        /// <summary>
        /// Insere uma consulta.
        /// </summary>
        /// <response code="201">Consulta inserido.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Post([FromBody] Consulta consulta) {
            var consultas = new List<Consulta> {
            };
            consultas.Add(consulta);
        }

        /// <summary>
        /// Edita uma consulta.
        /// </summary>
        /// <param name="id">Representa o Id do Item</param>
        /// <returns>Edita uma Consulta específica.</returns>
        /// <response code="200">Item editado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Put(int id, [FromBody] Consulta consulta) {
            var consultas = new List<Consulta> {
            };
            var ConsultaAlterada = consultas
                .Where(x => x.Id == id)
                .Select(x => new Consulta {
                    Id = x.Id,
                    DataConsulta = x.DataConsulta,
                    Animal = x.Animal,
                    Veterinario = x.Veterinario
                })
                .FirstOrDefault();
        }

        /// <summary>
        /// Deleta uma consulta.
        /// </summary>
        /// <param name="id">Representa o Id do Item</param>
        /// <returns>Deleta uma consulta específica.</returns>
        /// <response code="200">Item deletado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Delete(int id) {
            var consultas = new List<Consulta> {
            };
            consultas.RemoveAt(id);
        }
    }
}