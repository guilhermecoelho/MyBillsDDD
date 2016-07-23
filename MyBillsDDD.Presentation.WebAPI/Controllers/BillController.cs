﻿using AutoMapper;
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

        public BillController (IBillAppService billAppService)
        {
            this._billAppService = billAppService;
        }

        // GET: api/Bill
        public IEnumerable<Bill> Get()
        {
            var bills = _billAppService.GetAll();

           BillVM t = Mapper.Map<Bill, BillVM>(bills.FirstOrDefault());

            return bills;
        }

        // GET: api/Bill/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Bill
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Bill/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Bill/5
        public void Delete(int id)
        {
        }
    }
}
