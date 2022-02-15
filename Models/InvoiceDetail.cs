using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebManager.Models
{
    public class InvoiceDetail
    {
        public Guid InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }
        public Guid EatingId { get; set; }
        public virtual Eating Eating { get; set; }
        public int? STT { get; set; }
        public DateTime DateValue { get; set; }

        public int Quantily { get; set; }
    }
}
