using ExerciciosM02S09.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ExerciciosM02S09.Controllers {
    [Route("api/veterinario")]
    [ApiController]
    public class VeterinarioController : ControllerBase {

        /// <summary>
        /// Retorna veterinários.
        /// </summary>
        /// <returns>Retorna todos os veterinários no banco.</returns>
        /// <response code="200">Retorno da lista de animais.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Veterinario> Get() {
            var veterinarios = new List<Veterinario> {

            };
            return veterinarios;
        }

        /// <summary>
        /// Retorna um veterinario.
        /// </summary>
        /// <param name="id">Representa o Id do Item</param>
        /// <returns>Retorna um Veterinario específico.</returns>
        /// <response code="200">Retorno do veterinário.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Veterinario Get(int id) {
            var veterinarios = new List<Veterinario> {
            };
            var resultado = veterinarios.FirstOrDefault(x => x.Id == id);
            return resultado;
        }

        /// <summary>
        /// Insere um veterinário.
        /// </summary>
        /// <response code="201">Veterinário inserido.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Post([FromBody] Veterinario veterinario) {
            var veterinarios = new List<Veterinario> {
            };
            veterinarios.Add(veterinario);
        }

        /// <summary>
        /// Edita um veterinário.
        /// </summary>
        /// <param name="id">Representa o Id do Item</param>
        /// <returns>Edita um veterinário específico.</returns>
        /// <response code="200">Item editado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Put(int id, [FromBody] Veterinario veterinario) {
            var veterinarios = new List<Veterinario> {
            };
            var veterinarioAlterado = veterinarios
                .Where(x => x.Id == id)
                .Select(x => new Veterinario {
                    Id = x.Id,
                    Nome = x.Nome,
                    Endereco = x.Endereco,
                    Telefone = x.Telefone
                })
                .FirstOrDefault();
        }

        /// <summary>
        /// Deleta um veterinário.
        /// </summary>
        /// <param name="id">Representa o Id do Item</param>
        /// <returns>Deleta um veterinário específico.</returns>
        /// <response code="200">Item deletado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Delete(int id) {
            var veterinarios = new List<Veterinario> {
            };
            veterinarios.RemoveAt(id);
        }
    }
}