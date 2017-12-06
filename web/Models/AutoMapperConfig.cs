using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ef.Models.App;
using web.Models.AppViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace web.Models
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Component, ComponentViewModel>();
                cfg.CreateMap<Post, PostViewModel>();
                cfg.CreateMap<PostViewModel, Post>();
                cfg.CreateMap<Author, AuthorViewModel>();
                cfg.CreateMap<AuthorViewModel, Author>();
                cfg.CreateMap<Entity, EntityViewModel>();
                cfg.CreateMap<Author, SelectListItem>()
                    .ForMember(vm => vm.Text, m => m.MapFrom(a => a.FirstName + " " + a.LastName))
                    .ForMember(vm => vm.Value, m => m.MapFrom(a => a.Id))
                    .ForMember(vm => vm.Selected, op => op.Ignore())
                    .ForMember(vm => vm.Group, op => op.Ignore())
                    .ForMember(vm => vm.Disabled, op => op.Ignore());
            });
            //Mapper.Configuration.AssertConfigurationIsValid();
            Mapper.AssertConfigurationIsValid();
        }
    }

    public static class MapperHelper
    {
        public static TDest MapTo<TDest>(this object src)
        {
            return (TDest)Mapper.Map(src, src.GetType(), typeof(TDest));
        }
    }
}
