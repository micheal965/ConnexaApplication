using System;
using Connexa.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Connexa.API.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}

