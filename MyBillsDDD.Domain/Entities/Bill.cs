using System;

namespace MyBillsDDD.Domain.Entities
{
    public class Bill
    {
        public int BillId { get; set; }
        public string Name { get; set; }
        public DateTime PayDay { get; set; }
        public Boolean AutoPay { get; set; }
        public Boolean Payed { get; set; }
    }
}
