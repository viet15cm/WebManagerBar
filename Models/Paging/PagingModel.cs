using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebManager.Models.Paging
{
    public class PagingModel
    {
        public int CurrentPages { get; set; }

        public int CountPages { get; set; }

        public Func<int? , string> GenerateUrl { get; set; }
    }
}
