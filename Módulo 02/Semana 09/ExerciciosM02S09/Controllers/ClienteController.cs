using ExerciciosM02S09.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ExerciciosM02S09.Controllers {
    [Route("api/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase {

        /// <summary>
        /// Retorna clientes.
        /// </summary>
        /// <returns>Retorna todos os clientes no banco.</returns>
        /// <response code="200">Retorno da lista de clientes.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Cliente> Get() {
            var clientes = new List<Cliente> {

            };
            return clientes;
        }

        /// <summary>
        /// Retorna um cliente.
        /// </summary>
        /// <param name="id">Representa o Id do Item</param>
        /// <returns>Retorna um cliente específico.</returns>
        /// <response code="200">Retorno do cliente.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Cliente Get(int id) {
            var clientes = new List<Cliente> {
            };
            var resultado = clientes.FirstOrDefault(x => x.Id == id);
            return resultado;
        }

        /// <summary>
        /// Insere um cliente.
        /// </summary>
        /// <response code="201">Cliente inserido.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Post([FromBody] Cliente cliente) {
            var clientes = new List<Cliente> {
            };
            clientes.Add(cliente);
        }

        /// <summary>
        /// Edita um cliente.
        /// </summary>
        /// <param name="id">Representa o Id do Item</param>
        /// <returns>Edita um cliente específico.</returns>
        /// <response code="200">Item editado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Put(int id, [FromBody] Cliente cliente) {
            var clientes = new List<Cliente> {
            };
            var clienteAlterado = clientes
                .Where(x => x.Id == id)
                .Select(x => new Cliente {
                    Id = x.Id,
                    Nome = x.Nome,
                    Endereco = x.Endereco,
                    Bairro = x.Bairro,
                    Cep = x.Cep,
                    Cidade = x.Cidade,
                    Estado = x.Estado,
                    Telefone = x.Telefone
                })
                .FirstOrDefault();
        }


        /// <summary>
        /// Deleta um cliente.
        /// </summary>
        /// <param name="id">Representa o Id do Item</param>
        /// <returns>Deleta um cliente específico.</returns>
        /// <response code="200">Item deletado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="500">Erro interno.</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Delete(int id) {
            var clientes = new List<Cliente> {
            };
            clientes.RemoveAt(id);
        }
    }
}