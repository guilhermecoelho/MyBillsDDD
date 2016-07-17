using MyBillsDDD.Domain.Entities;
using MyBillsDDD.Domain.Repositories;

namespace MyBillsDDD.Domain.Services
{
    public class BillService : ServiceBase<Bill>, IBillService
    {
        private readonly IBillRepository _billRepository;
       // private readonly IUnitOfWork 

        public BillService(IBillRepository billRepository): base(billRepository)
        {
            this._billRepository = billRepository;
        }
    }
}
