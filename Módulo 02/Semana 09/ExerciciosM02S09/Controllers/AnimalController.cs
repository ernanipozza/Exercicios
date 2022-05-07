using ExerciciosM02S09.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ExerciciosM02S09.Controllers {
    [Route("api/animal")]
    [ApiController]
    public class AnimalController : ControllerBase {

        /// <summary>
        /// Retorna animais.
        /// </summary>
        /// <returns>Retorna todos os animais no banco.</returns>
        /// <response code="200">Retorno da lista de animais.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Animal> Get() {
            var animais = new List<Animal> {
               
            };
            return animais;
        }

        /// <summary>
        /// Retorna um animal.
        /// </summary>
        /// <param name="id">Representa o Id do Item</param>
        /// <returns>Retorna um animal específico.</returns>
        /// <response code="200">Retorno do animais.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Animal Get(int id) {
            var animais = new List<Animal> {
            };
            var resultado = animais.FirstOrDefault(x => x.Id == id);
            return resultado;
        }

        /// <summary>
        /// Insere um animal.
        /// </summary>
        /// <response code="201">Animal inserido.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Post([FromBody] Animal animal) {
            var animais = new List<Animal> {
            };
            animais.Add(animal);
        }

        /// <summary>
        /// Edita um animal.
        /// </summary>
        /// <param name="id">Representa o Id do Item</param>
        /// <returns>Edita um animal específico.</returns>
        /// <response code="200">Item editado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Put(int id, [FromBody] Animal animal) {
            var animais = new List<Animal> {
            };
            var animalAlterado = animais
                .Where(x => x.Id == id)
                .Select(x => new Animal {
                    Id = x.Id,
                    Nome = x.Nome,
                    Idade = x.Idade,
                    Sexo = x.Sexo,
                    Especie = x.Especie,
                    Tutor = x.Tutor
                })
                .FirstOrDefault();
        }

        /// <summary>
        /// Deleta um animal.
        /// </summary>
        /// <param name="id">Representa o Id do Item</param>
        /// <returns>Deleta um animal específico.</returns>
        /// <response code="200">Item deletado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Delete(int id) {
            var animais = new List<Animal> {
            };
            animais.RemoveAt(id);
        }
    }
}