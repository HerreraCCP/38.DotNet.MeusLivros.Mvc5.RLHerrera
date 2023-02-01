using RLHerrera.AspNet.Infra.Data.Context;
using System.Data.Entity.Migrations;

namespace RLHerrera.AspNet.Infra.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MeuDbContext>
    {
        public Configuration() => AutomaticMigrationsEnabled = true;
    }
}