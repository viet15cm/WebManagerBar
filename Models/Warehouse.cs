using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebManager.Models
{
    public class Warehouse
    {
        [Key]
        public Guid Id { get; set; }
        public int Quantily { get; set; }

        public DateTime DateValue { get; set; }

        public Guid FoodId { get; set; }

        public virtual Food Food { get; set; }
    }
}
