using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YummyRecipe.Models;

namespace YummyRecipe.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Home");
        }
        public ViewResult DisplayPage()
        {
            return View();
        }
        public ViewResult DataPage()
        {
            SampleRecipe sample = new SampleRecipe
                {
                  Name = "Oven_Scrambled_Egg",
                  Main_Ingredient = "Egg",
                  Durations = 35,
                  Category = "Breakfast",
                  Directions = "Preheat the oven to 350 degrees F (175 degrees C). Pour melted butter into a glass 9x13 inch baking dish.In a large bowl, whisk together eggs and salt until well blended.Gradually whisk in milk.Pour egg mixture into the baking dish.Bake uncovered for 10 minutes, then stir, and bake an additional 10 to 15 minutes, or until eggs are set.Serve immediately."
                };
            return View(sample);
        }
        public ViewResult InsertPage()
        {
            return View();
        }
        public ViewResult UserPage()
        {
            return View();
        }
    }
}