using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainDrivenDesign.Application.Interface;
using DomainDrivenDesign.Domain.Entities;
using DomainDrivenDesign.Domain.Interfaces.Services;

namespace DomainDrivenDesign.Application
{
    public class ClientAppService : AppServiceBase<Client>, IClientAppService
    {
        private readonly IClientService _clientService;

        public ClientAppService(IClientService clientService)
        : base(clientService)
        {
            _clientService = clientService;
        }


        public IEnumerable<Client> GetSpecialClients()
        {
            return _clientService.GetSpecialClients(_clientService.GetAll());
        }
    }
}
