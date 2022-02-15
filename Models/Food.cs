using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebManager.Models
{
    public class Food
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        public double Price { get; set; }
        //khấu hao
        public int Depreciation { get; set; }

        public virtual ICollection<Eating> Eatings { get; set; }

        public virtual ICollection<Warehouse> Warehouses { get; set; }
    }
}
