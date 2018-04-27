using System.Collections.Generic;
using System.Linq;
using DomainDrivenDesign.Domain.Entities;
using DomainDrivenDesign.Domain.Interfaces;
using DomainDrivenDesign.Domain.Interfaces.Repositories;

namespace DomainDrivenDesign.Infra.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> FindByName(string name)
        {
            return db.Products.Where(x => x.Name == name);
        }
    }
}

