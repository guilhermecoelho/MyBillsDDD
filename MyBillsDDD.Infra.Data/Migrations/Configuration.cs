namespace MyBillsDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;


    internal sealed class Configuration : DbMigrationsConfiguration<MyBillsDDD.Infra.Data.Context.MyBillsDDDContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyBillsDDD.Infra.Data.Context.MyBillsDDDContext context)
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
            context.bill.Add(new Domain.Entities.Bill
            {
                Name = "first",
                AutoPay = true,
                Payed = false,
                PayDay = DateTime.Now
            });
        }
    }
}
