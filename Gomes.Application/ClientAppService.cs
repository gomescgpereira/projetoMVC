using Gomes.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Gomes.Application.Interface;
using Gomes.Domain.Interfaces;
using Gomes.Domain.Interfaces.Repository;
using Gomes.Domain.Interfaces.Service;

namespace Gomes.Application
{
    public class ClientAppService : AppServiceBase<Cliente>, IClienteApplicationService
    {
        private readonly IClienteService _clientService;

        public ClientAppService(IClienteService clientService)
        : base(clientService)  
        {
            _clientService = clientService;
        }
    }
    
}
