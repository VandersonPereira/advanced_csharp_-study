namespace Estudo.ProdutosMarcas.Persistencia.EF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Estudo.ProdutosMarcas.Persistencia.EF.Context.EstudoProdutosMarcasDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Estudo.ProdutosMarcas.Persistencia.EF.Context.EstudoProdutosMarcasDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
