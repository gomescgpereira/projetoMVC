using Gomes.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gomes.Repository.Fake
{
   
    public class DadosFake
    {
        public List<Cliente> Clientes;

        public DadosFake()
        {
            Clientes = new List<Cliente>();
        }
        public IEnumerable<Cliente> Get()
        {
            this.Clientes.Add(new Cliente("Carlos Eduardo", "Rua Botucatu, 56", "20510-010", 'M', System.DateTime.Now));
            this.Clientes.Add(new Cliente("Jorge Eduardo", "Rua Principal, 526", "20520-020", 'M', System.DateTime.Now));
            this.Clientes.Add(new Cliente("Tereza Albuquerque", "Rua Teodoro Silva, 126", "20510-030", 'F', System.DateTime.Now));
            this.Clientes.Add(new Cliente("Maria Albertina", "Rua Jorge Amado, 176", "20520-020", 'F', System.DateTime.Now));

            return Clientes;
        }

        public void Add()
        {
            this.Clientes.Add(new Cliente("Paulo", "Rua Goiania, 26", "20710-010", 'M', System.DateTime.Now));
        }

        public void Save()
        {
        }
        
    }
}
