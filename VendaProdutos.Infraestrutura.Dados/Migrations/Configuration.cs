using System.Data.Entity.Migrations;

namespace VendaProdutos.Infraestrutura.Dados.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<Contexto.VendaProdutoContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Contexto.VendaProdutoContexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
