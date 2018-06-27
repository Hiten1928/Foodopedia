using System;
using System.Collections.Generic;
using System.Linq;
using OdeToFood.models;

namespace OdeToFood.Services
{
    //public class InMemoryRestaurantData : IRestaurantData
    //{
    //    public InMemoryRestaurantData()
    //    {
    //        _restaurants = new List<Restaurant>{
    //            new Restaurant{Id =1, Name = "Crossraods"},
    //        new Restaurant { Id = 2, Name = "Brick City" },
    //        new Restaurant { Id = 3, Name = "Corner Store" }
    //        };
    //    }

    //    public IEnumerable<Restaurant> GetAll(){
    //        return _restaurants.OrderBy(r => r.Name);
    //    }

    //    public Restaurant Get(int id)
    //    {
    //        return _restaurants.FirstOrDefault(r => r.Id == id);
    //    }

    //    public Restaurant Add(Restaurant restaurant)
    //    {
    //        restaurant.Id = _restaurants.Max(r => r.Id) + 1;
    //        _restaurants.Add(restaurant);
    //        return restaurant;
    //    }

    //    public Restaurant Update(Restaurant updated_restaurant)
    //    {
    //        _context
    //    }

    //    List<Restaurant> _restaurants;

    //}
}
