using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using DomainDrivenDesign.Domain.Entities;
using DomainDrivenDesign.MVC.ViewModels;

namespace DomainDrivenDesign.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductViewModel, Product>();
            CreateMap<ClientViewModel, Client>();


        }
    }
}