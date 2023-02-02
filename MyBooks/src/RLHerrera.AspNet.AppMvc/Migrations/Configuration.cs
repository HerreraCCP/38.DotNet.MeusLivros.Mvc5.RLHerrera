using System.Data.Entity.Migrations;

namespace RLHerrera.AspNet.AppMvc.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<RLHerrera.AspNet.AppMvc.Models.ApplicationDbContext>
    {
        public Configuration() => AutomaticMigrationsEnabled = true;
    }
}