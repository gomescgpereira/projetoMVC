using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GomesMVC.Models
{
    public class Cliente
    {  
        [Key]
        public int ClientId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public char Sexo { get; set; }
        public DateTime DataAmiv { get; set; }
    }
}