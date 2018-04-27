using System.Collections.Generic;
using DomainDrivenDesign.Domain.Entities;

namespace DomainDrivenDesign.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IEnumerable<Product> FindByName(string name);
    }
}
