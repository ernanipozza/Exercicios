using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosM02S09.Models {
    public class Tratamento {

        [Required(ErrorMessage = "Informação obrigatória")]
        [Range(1, 999999)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informação obrigatória")]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "Informação obrigatória")]
        [DataType(DataType.Date)]
        public DateTime DataFinal { get; set; }

        [Required(ErrorMessage = "Informação obrigatória")]
        public Consulta Consulta { get; set; }

        [Required(ErrorMessage = "Informação obrigatória")]
        public Exame Exame { get; set; }

        [Required(ErrorMessage = "Informação obrigatória")]
        public string Descricao { get; set; }
    }
}
