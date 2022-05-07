using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosM02S09.Models {
    public class Especie {

        [Required(ErrorMessage = "Informação obrigatória")]
        [Range(1, 999999)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informação obrigatória")]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public Especie() {

        }
    }
}
