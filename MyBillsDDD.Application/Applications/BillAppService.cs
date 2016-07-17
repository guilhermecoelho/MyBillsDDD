using MyBillsDDD.Application.Interfaces;
using MyBillsDDD.Domain.Entities;
using MyBillsDDD.Domain.Services;

namespace MyBillsDDD.Application.Applications
{
    public class BillAppService : AppServiceBase<Bill>, IBillAppService
    {
        private readonly IBillService _billService;

        public BillAppService(IBillService billService) : base(billService)
        {
            this._billService = billService;
        }
    }
}
