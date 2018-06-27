using System;
using Microsoft.EntityFrameworkCore;
using OdeToFood.models;

namespace OdeToFood.Data
{
    public class OdeToFoodDbContext : DbContext
    {
        

        public OdeToFoodDbContext(DbContextOptions options) 
            : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants
        {
            get;
            set;
        }
    }
}
