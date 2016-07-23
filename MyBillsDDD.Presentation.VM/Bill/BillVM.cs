using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBillsDDD.Presentation.VM    
{
    public class BillVM
    {
        public int BillId { get; set; }
        public string Name { get; set; }
        public DateTime PayDay { get; set; }
        public bool AutoPay { get; set; }
        public bool Payed { get; set; }
    }
}
