using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebManager.Services.FoodServices;

namespace WebManager.Areas.Docs.Pages.Food
{
    public class AddModel : PageModel
    {
        private readonly FoodService _foodService;

        [BindProperty]
        public Input inputModel { get; set; }

        public AddModel(FoodService foodService)
        {
            _foodService = foodService;
        }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if(inputModel != null)
            {
                var itemFood = new Models.Food() 
                { 
                    Name = inputModel.Name,
                    Price = inputModel.Price,
                    Depreciation = inputModel.Depreciation
                
                };

                await _foodService.Add(itemFood);
                
              
            }
            
            return Page();
        }

        public class Input
        {
            [StringLength(50)]
            [Required]
            public string Name { get; set; }
            [Required]
            public double Price { get; set; }
            [Required]
            public int Depreciation { get; set; }
        }

        
    }
}
