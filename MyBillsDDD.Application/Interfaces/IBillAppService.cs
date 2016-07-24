using FluentValidation.Results;
using MyBillsDDD.Domain.Entities;
using MyBillsDDD.Presentation.VM;

namespace MyBillsDDD.Application.Interfaces
{
    public interface IBillAppService: IAppServiceBase<Bill>
    {
        ValidationResult Insert(BillVM billVM);
        ValidationResult Update(BillVM billVM);
        ValidationResult Delete(int id);
    }
}
