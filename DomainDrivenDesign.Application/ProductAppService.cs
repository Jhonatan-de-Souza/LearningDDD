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
    public class ProductAppService : AppServiceBase<Product>, IProductAppService
    {
        private readonly IProductService _productService;

        public ProductAppService(IProductService productService)
        : base(productService)
        {
            _productService = productService;
        }

        public IEnumerable<Product> FindByName(string name)
        {
            return _productService.FindByName(name);
        }
    }
}
