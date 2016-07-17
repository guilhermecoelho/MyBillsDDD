using MyBillsDDD.Domain.Entities;
using MyBillsDDD.Infra.Data.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System;

namespace MyBillsDDD.Infra.Data.Context
{
    public class MyBillsDDDContext : DbContext
    {
      

        public MyBillsDDDContext() : base("MyBill")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));


            modelBuilder.Configurations.Add(new BillConfiguration());


            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Bill> bill { get; set; }
    }
}
