using System;
using System.Collections.Generic;
using OdeToFood.models;

namespace OdeToFood.ViewModels
{
    public class HomeIndexViewModel
    {
        public HomeIndexViewModel()
        {
        }

        public IEnumerable<Restaurant> Restaurants
        {
            get;
            set;
        }

        public string CurrentMessage
        {
            get;
            set;
        }
    }
}
