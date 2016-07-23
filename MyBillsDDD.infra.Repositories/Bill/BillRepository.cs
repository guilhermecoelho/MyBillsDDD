using MyBillsDDD.Domain.Entities;
using MyBillsDDD.Domain.Repositories;

namespace MyBillsDDD.infra.Repositories
{
    public class BillRepository : RepositoryBase<Bill>, IBillRepository
    {
    }
}
