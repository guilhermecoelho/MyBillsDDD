using AutoMapper;
using FluentValidation.Results;
using MyBillsDDD.Application.Interfaces;
using MyBillsDDD.Domain.Entities;
using MyBillsDDD.Domain.Services;
using MyBillsDDD.Presentation.VM;

namespace MyBillsDDD.Application.Applications
{
    public class BillAppService : AppServiceBase<Bill>, IBillAppService
    {
        private readonly IBillService _billService;

        public BillAppService(IBillService billService) : base(billService)
        {
            this._billService = billService;
        }

        public ValidationResult Insert(BillVM billVM)
        {
            Bill bill = Mapper.Map<BillVM, Bill>(billVM);

            return _billService.Insert(bill);
        }

        public ValidationResult Update(BillVM billVM)
        {
            Bill bill = Mapper.Map<BillVM, Bill>(billVM);

            return _billService.Update(bill);
        }

        public ValidationResult Delete(int id)
        {
            return _billService.Delete(id);
        }
    }
}
