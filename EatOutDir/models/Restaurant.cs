﻿using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;


namespace OdeToFood.models
{
    public class Restaurant
    {
        
        public int Id
        {
            get;
            set;
        }

        [Display(Name = "Restaurant Name")]
        [Required, MaxLength(80)]
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
