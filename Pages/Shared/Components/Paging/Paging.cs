using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebManager.Services.FoodServices;

namespace WebManager.Pages.Shared.Components.Paging
{
    public class Paging : ViewComponent
    {
        public const int ITEMS_PER_PAGES = 7;
        private FoodService _foodService { get; }

        public Paging(FoodService foodService)
        {
            _foodService = foodService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int currentPages)
        {
            await _foodService.GetAll();
            
            var totalArticle = _foodService.listsFood.Count;

            var conutPages = (int)Math.Ceiling((double )totalArticle/ ITEMS_PER_PAGES);

            if (currentPages < 1)
            {
                currentPages = 1;
            }
            if(currentPages > conutPages)
            {
                currentPages = conutPages;
            }

            var pagingModel = new WebManager.Models.Paging.PagingModel()
            {

                CurrentPages = currentPages,
                CountPages = conutPages,
                GenerateUrl = (int? p) => "?p=" + p


            };
            return View(pagingModel);
        }
    }
}
