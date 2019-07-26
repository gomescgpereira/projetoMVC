using System;
using System.Collections.Generic;
using System.Text;

namespace Gomes.Domain.Entity
{
    public class Cliente
    {
        public Cliente(string nome, string endereco, string cep, char sexo, DateTime dataAmiv)
        {
            Nome = nome;
            Endereco = endereco;
            Cep = cep;
            Sexo = sexo;
            DataAniv = dataAmiv;
        }

        public int ClientId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public char Sexo { get; set; }
        public DateTime DataAniv { get; set; }
    }
}

