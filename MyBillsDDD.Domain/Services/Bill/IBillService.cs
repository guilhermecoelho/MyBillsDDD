using FluentValidation.Results;
using MyBillsDDD.Domain.Entities;

namespace MyBillsDDD.Domain.Services
{
    public interface IBillService : IServiceBase<Bill>
    {
        ValidationResult Insert(Bill bill);
        ValidationResult Update(Bill bill);
        ValidationResult Delete(int id);
    }
}
