using Gomes.Domain.Entity;
using Gomes.Domain.Interfaces.Repository;
using Gomes.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gomes.Domain.Service
{
    public class ClienteService: ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository) 
        {
            _clienteRepository = clienteRepository;
        }

    }
}
