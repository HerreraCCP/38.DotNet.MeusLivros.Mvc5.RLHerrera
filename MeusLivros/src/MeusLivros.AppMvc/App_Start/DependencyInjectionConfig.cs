using MeusLivros.Business.Core.Notifications;
using MeusLivros.Business.Models.Products;
using MeusLivros.Business.Models.Products.Services;
using MeusLivros.Business.Models.Providers;
using MeusLivros.Business.Models.Providers.Services;
using MeusLivros.Infra.Data.Context;
using MeusLivros.Infra.Data.Repository;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System.Reflection;
using System.Web.Mvc;

namespace MeusLivros.AppMvc.App_Start
{
    public class DependencyInjectionConfig
    {
        public static void RegisterDIContainer()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

        private static void InitializeContainer(Container container)
        {
            container.Register<BookDbContext>(Lifestyle.Scoped);
            container.Register<IProductRepository, ProductRepository>(Lifestyle.Scoped);
            container.Register<IProductService, ProductService>(Lifestyle.Scoped);
            container.Register<IProviderRepository, ProviderRepository>(Lifestyle.Scoped);
            container.Register<IAddressRepository, AddressRepository>(Lifestyle.Scoped);
            container.Register<IProviderService, ProviderService>(Lifestyle.Scoped);
            container.Register<INotifier, Notifier>(Lifestyle.Scoped);

            container.RegisterSingleton(() => AutoMapperConfig.GetMapperConfiguration().CreateMapper(container.GetInstance));
        }
    }
}