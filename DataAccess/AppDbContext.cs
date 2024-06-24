using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextSeeker.Models;

namespace TextSeeker.DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<Video> Video { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = "data.db";
            Console.WriteLine($"Database path: {Path.GetFullPath(path)}");
            optionsBuilder.UseSqlite($"Data Source={path}").LogTo(Console.WriteLine, LogLevel.Information); ;
        }

    }
}
