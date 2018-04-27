using System;
using System.Collections.Generic;
using DomainDrivenDesign.Application.Interface;
using DomainDrivenDesign.Domain.Interfaces.Services;

namespace DomainDrivenDesign.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {

        //Here the services will be working with the repositories,but without adding references
        // to the .Data Project here and that would break the DDD concepts, since the domain must be uncoupled from the 


        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        //The code above is the right way to use the repository inside of the services of a domain
        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}
