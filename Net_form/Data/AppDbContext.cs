using Microsoft.EntityFrameworkCore;
using PersonApi.Models;
using System;
using System.Collections.Generic;

namespace PersonApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Person> People { get; set; }
    }
}
