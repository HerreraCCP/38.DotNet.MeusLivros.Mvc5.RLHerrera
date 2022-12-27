using MeusLivros.Infra.Data.Context;
using System.Data.Entity.Migrations;

namespace MeusLivros.Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<BookDbContext>
    {
        public Configuration() => AutomaticMigrationsEnabled = true;
    }
}