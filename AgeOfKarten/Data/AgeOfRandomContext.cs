using AgeOfKarten.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgeOfKarten.Data
{
    public class AgeOfRandomContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }

        public DbSet<Nation> Nations { get; set; }

        public DbSet<NationCard> NationCards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=database.db");
    }
}
