namespace ASP.NETTest0001.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ASP.NETTest0001.Models.BarContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ASP.NETTest0001.Models.BarContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.ProductTypes.AddOrUpdate(x => x.ProductTypeID,
                new ProductType() { Title = "Bier" },
                new ProductType() { Title = "Longdrink" },
                new ProductType() { Title = "Shorty" }
            );
            context.Products.AddOrUpdate(x => x.ProductID,
                new Product() { Title = "Stiegel", ProductTypeID = 1 },
                new Product() { Title = "Wodka Bull", ProductTypeID = 2 },
                new Product() { Title = "B52", ProductTypeID = 3 }
            );
        }
    }
}
