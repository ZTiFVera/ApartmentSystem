using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApartmentSystem.Models;

namespace ApartmentSystem.Data
{
    public class ApartmentSystemContext : DbContext
    {
        public ApartmentSystemContext (DbContextOptions<ApartmentSystemContext> options)
            : base(options)
        {
        }

        public DbSet<ApartmentSystem.Models.Product> Product { get; set; } = default!;
        public DbSet<ApartmentSystem.Models.User> User { get; set; } = default!;
    }
}
