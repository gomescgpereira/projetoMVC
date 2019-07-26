using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Gomes.Domain.Entity;
using GomesMVC.ViewModels;

namespace GomesMVC.AutoMapper
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel,Cliente>();
        }


    }
}