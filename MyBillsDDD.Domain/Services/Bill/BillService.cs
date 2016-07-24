using FluentValidation.Results;
using MyBillsDDD.Domain.Entities;
using MyBillsDDD.Domain.Repositories;
using MyBillsDDD.Domain.Validations;
using System;

namespace MyBillsDDD.Domain.Services
{
    public class BillService : ServiceBase<Bill>, IBillService
    {
        private readonly IBillRepository _billRepository;

        public BillService(IBillRepository billRepository) : base(billRepository)
        {
            this._billRepository = billRepository;
        }

        public ValidationResult Insert(Bill bill)
        {
            BillValidation billValidation = new BillValidation();

            ValidationResult validationResult = billValidation.Validate(bill);

            if (validationResult.IsValid)
            {
                _billRepository.Add(bill);
            }

            return validationResult;
        }

        public ValidationResult Update(Bill bill)
        {
            BillValidation billValidation = new BillValidation();

            ValidationResult validationResult = billValidation.Validate(bill);

            if (validationResult.IsValid)
            {
                _billRepository.Update(bill);
            }

            return validationResult;
        }

        public ValidationResult Delete(int id)
        {
            BillValidation billValidation = new BillValidation();

            Bill bill = _billRepository.GetById(id);

            ValidationResult validationResult = billValidation.Validate(bill);

            if (validationResult.IsValid)
            {
                _billRepository.Remove(bill);
            }

            return validationResult;
        }
    }
}
