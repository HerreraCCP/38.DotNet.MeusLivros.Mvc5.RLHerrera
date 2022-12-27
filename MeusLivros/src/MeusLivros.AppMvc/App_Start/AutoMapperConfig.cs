using AutoMapper;
using MeusLivros.AppMvc.ViewModels;
using MeusLivros.Business.Models.Products;
using MeusLivros.Business.Models.Providers;
using System;
using System.Linq;
using System.Reflection;

namespace MeusLivros.AppMvc.App_Start
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration GetMapperConfiguration()
        {
            var profiles = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => typeof(Profile).IsAssignableFrom(x));

            return new MapperConfiguration(cfg =>
            {
                foreach (var profile in profiles)
                {
                    cfg.AddProfile(Activator.CreateInstance(profile) as Profile);
                }
            });
        }

        public class AutoMapperProfile : Profile
        {
            public AutoMapperProfile()
            {
                CreateMap<Provider, ProviderViewModel>().ReverseMap();
                CreateMap<Address, AddressViewModel>().ReverseMap();
                CreateMap<Product, ProductViewModel>().ReverseMap();
            }
        }
    }
}