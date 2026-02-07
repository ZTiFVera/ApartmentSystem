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

       
        public DbSet<ApartmentSystem.Models.ContactInfo> ContactInfo { get; set; } = default!;
        public DbSet<ApartmentSystem.Models.Registration> Registration { get; set; } = default!;
    }
}
