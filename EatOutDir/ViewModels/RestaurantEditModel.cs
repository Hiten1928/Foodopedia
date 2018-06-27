using System;
using System.ComponentModel.DataAnnotations;
using OdeToFood.models;

namespace OdeToFood.ViewModels
{
    public class RestaurantEditModel
    {
        public RestaurantEditModel()
        {
        }

        [Required,MaxLength(80) ]
        public string Name
        {
            get;
            set;
        }

        public CuisineType Cuisine
        {
            get;
            set;
        }
    }
}
