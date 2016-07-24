using AutoMapper;
using FluentValidation.Results;
using MyBillsDDD.Application.Interfaces;
using MyBillsDDD.Domain.Entities;
using MyBillsDDD.Presentation.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyBillsDDD.Presentation.WebAPI.Controllers
{
    public class BillController : ApiController
    {
        private readonly IBillAppService _billAppService;

        public BillController(IBillAppService billAppService)
        {
            this._billAppService = billAppService;
        }

        // GET: api/Bill
        public IEnumerable<BillVM> Get()
        {
            var bills = _billAppService.GetAll();

            IEnumerable<BillVM> billsVM = Mapper.Map<IEnumerable<Bill>, IEnumerable<BillVM>>(bills);

            return billsVM;
        }

        // GET: api/Bill/5
        public BillVM Get(int id)
        {
            var bill = _billAppService.GetById(id);

            BillVM billVM = Mapper.Map<Bill, BillVM>(bill);

            return billVM;
        }

        // POST: api/Bill
        public ValidationResult Post(BillVM billVM)
        {
            return _billAppService.Insert(billVM);
        }

        // PUT: api/Bill/5
        public ValidationResult Put(BillVM billVM)
        {
            return _billAppService.Update(billVM);
        }

        // DELETE: api/Bill/5
        public ValidationResult Delete(int id)
        {
            return _billAppService.Delete(id);
        }
    }
}
