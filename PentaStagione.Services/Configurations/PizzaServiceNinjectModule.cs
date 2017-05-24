using Ninject;
using Ninject.Modules;
using PentaStagione.Domain.Repository;
using PentaStagione.Repository;
using PentaStagione.Repository.Configurations;
using PentaStagione.Repository.Contracts.ReadModel;
using PentaStagione.Repository.ReadModel;

namespace PentaStagione.Services.Configurations
{
    public class PizzaServiceNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Kernel?.Load(new DatabaseNinjectModule());
            Bind<IPizzaReadRepository>().To<PizzaReadRepository>();
            Bind<IPizzaRepository>().To<PizzaRepository>();

            Bind<IPizzaIngredientReadRepository>().To<PizzaIngredientReadRepository>();
        }
    }
}
