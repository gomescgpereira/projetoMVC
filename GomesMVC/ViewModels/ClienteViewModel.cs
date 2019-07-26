using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GomesMVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClientId { get; set; }
        [Required(ErrorMessage ="Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} Caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Preencha o campo Endereco")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Preencha o campo Cep")]
        public string Cep { get; set; }
        public char Sexo { get; set; }
        public DateTime DataAmiv { get; set; }
    }
}