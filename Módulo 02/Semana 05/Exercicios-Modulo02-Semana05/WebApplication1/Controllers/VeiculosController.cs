using LocadoraVeiculos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase {
        [HttpGet]

        public List<Veiculos> Get() {
            var listaVeiculos = new List<Veiculos>();
            var corsa = new Carro("MGS-2574", "GM Corsa", 5, "Álcool", 89457.75M);
            var cgTitan = new Motocicleta("AIG-2872", "Honda CG Titan", 2, "Gasolina", 29744.12M);
            var atego = new Caminhao("POS-9974", "Mercedes Atego", 2, "Diesel", 194473.25M, 6500);
            var tiida = new Carro("MOP-1233", "Nissan Tiida", 5, "Flex", 69222.00M);
            var intruder = new Motocicleta("GAW-9872", "Suzuki Intruder", 2, "Gasolina", 2544.12M);
            var stralis = new Caminhao("TGB-4369", "Iveco Stralis", 3, "Diesel", 322547.25M, 30000);

            listaVeiculos.Add(corsa);
            listaVeiculos.Add(cgTitan);
            listaVeiculos.Add(atego);
            listaVeiculos.Add(tiida);
            listaVeiculos.Add(intruder);
            listaVeiculos.Add(stralis);

            return listaVeiculos;
        }
    }
}
