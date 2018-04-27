using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainDrivenDesign.Domain.Entities;
using DomainDrivenDesign.Domain.Interfaces.Repositories;
using DomainDrivenDesign.Domain.Interfaces.Services;

namespace DomainDrivenDesign.Domain.Services
{
    public class ProductRepository : ServiceBase<Product>, IProductService
    {
        public ProductRepository(IRepositoryBase<Product> repository) : base(repository)
        {
        }

        public IEnumerable<Product> FindByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
