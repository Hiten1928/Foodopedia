using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.models;
using OdeToFood.Services;

namespace OdeToFood.Pages
{
    public class IndexModel : PageModel
    {
        private IRestaurantData _restaurantdata;

        public IEnumerable<Restaurant> _restaurant { get; set; }

        public IndexModel(IRestaurantData restaurant)
        {
            _restaurantdata = restaurant;
        }

        public void OnGet()
        {
            _restaurant = _restaurantdata.GetAll();
        }
    }
}