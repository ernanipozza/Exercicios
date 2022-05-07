using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosM02S09.Models {
    public class Cliente {

        [Required(ErrorMessage = "Informação obrigatória")]
        [Range(1, 999999)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informação obrigatória")]
        public string Nome { get; set; }
        public string Endereco { get; set; }

        [DisplayFormat(DataFormatString = "")]
        public string Bairro { get; set; }
        public string Cep { get; set; }

        [DisplayFormat(DataFormatString = "")]
        public string Cidade { get; set; }

        [Display(Name = "Irrelevante")]
        [StringLength(2, ErrorMessage = "Informe a sigla do estado com 2 letras.")]
        public string Estado { get; set; }
        
        [Required(ErrorMessage = "Informação obrigatória")]
        //[RegularExpression(@"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$",
         //ErrorMessage = "Characters are not allowed.")]
        public string Telefone { get; set; }
    }
}
