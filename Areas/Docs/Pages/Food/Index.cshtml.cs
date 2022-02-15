using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebManager.Services.FoodServices;
using WebManager.Models;

namespace WebManager.Areas.Docs.Pages.Food
{
    public class IndexModel : PageModel
    {
        private readonly FoodService _foodService;
        public const int ITEMS_PER_PAGES = 7;

        [BindProperty(Name = "p", SupportsGet = true)]
        public int Currentpage { get; set; }
        public IEnumerable<Models.Food> foods { get; set; }
        public IndexModel (FoodService foodService)
        {
            _foodService = foodService;
        }
        public async Task OnGet()
        {

            foods = await _foodService.GetAll();
             foods =  foods.Skip((Currentpage - 1) * 5).Take(ITEMS_PER_PAGES);
            

        }
    }
}
