using MyBillsDDD.Domain.Entities;
using MyBillsDDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBillsDDD.Infra.Data
{
    public class UnitOfWork
    {
        //private MyBillsDDDContext context = new MyBillsDDDContext();
        // private RepositoryBase<Bill> billRepository;
        private readonly IMyBillsDDDContext _myBillsDDDContext;
        private bool disposed = false;

        public UnitOfWork(IMyBillsDDDContext myBillsDDDContext)
        {
            _myBillsDDDContext = myBillsDDDContext;
        }

        //public RepositoryBase<Bill> BillRepository
        //{
        //    get
        //    {
        //        if(this.billRepository == null)
        //        {
        //            this.billRepository = new RepositoryBase<Bill>(context);
        //        }
        //        return billRepository;
        //    }
        //}

        //public void Commit()
        //{
        //    if (disposed)
        //    {
        //        throw new ObjectDisposedException(this.GetType().FullName);
        //    }

        //    _myBillsDDDContext.SaveChanges();
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}

        //public virtual void Dispose(bool disposing)
        //{
        //    if (!this.disposed)
        //    {
        //        if (disposing)
        //        {
        //            _myBillsDDDContext.Dispose();
        //        }
        //    }
        //    this.disposed = true;
        //}



    }
}
