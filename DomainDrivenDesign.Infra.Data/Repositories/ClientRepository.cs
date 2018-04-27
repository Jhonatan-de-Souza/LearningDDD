using DomainDrivenDesign.Domain.Entities;
using DomainDrivenDesign.Domain.Interfaces;
using DomainDrivenDesign.Domain.Interfaces.Repositories;

namespace DomainDrivenDesign.Infra.Data.Repositories
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {

    }
}
