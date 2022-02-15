using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebManager.Models
{
    public class Invoice
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime DateValue { get; set; }

        //Giảm giá %
        public int? Discount { get; set; }

        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
