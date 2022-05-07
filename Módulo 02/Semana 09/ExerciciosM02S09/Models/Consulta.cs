using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosM02S09.Models {
    public class Consulta {

        [Required(ErrorMessage = "Informação obrigatória")]
        [Range(1, 999999)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informação obrigatória")]
        [DataType(DataType.Date)]
        public DateTime DataConsulta { get; set; }

        [Required(ErrorMessage = "Informação obrigatória")]
        public Animal Animal { get; set; }

        [Required(ErrorMessage = "Informação obrigatória")]
        public Veterinario Veterinario { get; set; }
    }
}
