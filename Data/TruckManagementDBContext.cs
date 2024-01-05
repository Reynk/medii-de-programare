using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TruckManagement.Models;

namespace TruckManagement.Data
{
    public class TruckManagementDBContext : DbContext
    {
        public TruckManagementDBContext (DbContextOptions<TruckManagementDBContext> options)
            : base(options)
        {
        }

        public DbSet<TruckManagement.Models.Delivery> Delivery { get; set; } = default!;

        public DbSet<TruckManagement.Models.Status>? Status { get; set; }
    }
}
