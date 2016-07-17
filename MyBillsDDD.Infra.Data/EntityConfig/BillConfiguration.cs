using MyBillsDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MyBillsDDD.Infra.Data.EntityConfig
{
    public class BillConfiguration: EntityTypeConfiguration<Bill>
    {
        public void BillsConfiguration()
        {
            HasKey(c => c.Name);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
