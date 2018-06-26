using System;
using System.Collections.Generic;
using OdeToFood.models;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        Restaurant Add(Restaurant restaurant);
    }
}
