using AutoMapper;
using Gomes.Domain.Entity;
using GomesMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GomesMVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
        }

    }
}