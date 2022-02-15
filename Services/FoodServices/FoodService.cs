using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebManager.DbContextlayer;
using WebManager.Models;

namespace WebManager.Services.FoodServices
{
    public class FoodService
    {
        private UserContext _context { get; }
        public ICollection<Food> listsFood { get; set; }
        public FoodService(UserContext context)
        {
            _context = context;
        }



        public async Task<ICollection<Food>> GetAll()
        {
         
            try
            {
                var task = new Task<ICollection<Food>>(()=>{

                    listsFood = new List<Food>();
                    for (int i = 0; i < 50; i++)
                    {
                        listsFood.Add(new Food() { Id = new Guid(), Name = "Food" + i, Price = i, Depreciation = i });
                    }

                    return listsFood;

                });

                task.Start();

                return await task;
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task Add(Food food)
        {
            
            try
            {
                if (food != null)
                {
                    await _context.foods.AddAsync(food);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        } 



    }
}
