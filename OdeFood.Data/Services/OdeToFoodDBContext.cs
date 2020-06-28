using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeFood.Data.Services
{
    public class OdeToFoodDBContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
