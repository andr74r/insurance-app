using InsuranceApp.Osago.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace InsuranceApp.Osago
{
    public class OsagoContext : DbContext
    {
        public DbSet<OsagoPolicy> OsagoPolicies { get; set; }

        public OsagoContext(DbContextOptions<OsagoContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
    }
}
