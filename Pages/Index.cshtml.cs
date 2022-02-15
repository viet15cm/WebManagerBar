using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebManager.Pages
{
    public class IndexModel : PageModel
    {
        [FromQuery]
        [BindProperty(SupportsGet = true, Name = "P")]
        public string currentItem { get; set; }

        public void OnGet([FromQuery] int i)
        {
            
        }
        public IActionResult OnPost()
        {

            return Page();
        }
        public class MenuItem
        {
            public string Name { get; set; }

            public Func<string, string> CurrentUrl { get; set; }
        }
    }
}
