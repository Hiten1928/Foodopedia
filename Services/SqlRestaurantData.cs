 using System;
using System.Collections.Generic;
using System.Linq;
using OdeToFood.Data;
using OdeToFood.models;


namespace OdeToFood.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private OdeToFoodDbContext _context;

        public SqlRestaurantData(OdeToFoodDbContext context)
        {
            _context = context;
        }

        public Restaurant Add(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);

            //just for ease, but it needs to go in a special method for actual application perspectives
            _context.SaveChanges();

            return restaurant;
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurants.OrderBy(r => r.Name); 
        }

        public Restaurant Update(Restaurant updated_restaurant)
        {
            _context.Attach(updated_restaurant).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return updated_restaurant;
        }
    }
}
