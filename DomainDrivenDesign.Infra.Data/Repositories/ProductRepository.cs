using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainDrivenDesign.Domain.Entities;
using DomainDrivenDesign.Domain.Interfaces;

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

