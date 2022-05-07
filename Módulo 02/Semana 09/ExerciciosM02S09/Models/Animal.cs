using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosM02S09.Models {
    public class Animal {
        
        [Required(ErrorMessage = "Informação obrigatória")]
        [Range(1, 999999)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informação obrigatória")]
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Informação obrigatória")]
        public Especie Especie { get; set; }

        [Required(ErrorMessage = "Informação obrigatória")]
        public Cliente Tutor { get; set; }
    }
}
