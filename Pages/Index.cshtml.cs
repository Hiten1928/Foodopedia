using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.models;
using OdeToFood.Services;
using OdeToFood.ViewModels;

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
            //var model = new HomeIndexViewModel();
            //model.Restaurants = _restaurantdata.GetAll();
            //_restaurant = model.Restaurants;

            _restaurant = _restaurantdata.GetAll();
            
        }
    }
}