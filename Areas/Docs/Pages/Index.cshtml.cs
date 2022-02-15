using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebManager.Areas.Docs.Pages
{
    public class IndexModel : PageModel
    {
        public IActionResult  OnGet()
        {
            return RedirectToPage("/Food/index");
        }
    }
}
