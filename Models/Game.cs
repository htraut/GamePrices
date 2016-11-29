using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GamePrices.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public Uri URL { get; set; }  
    }

    public class GameDBContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}