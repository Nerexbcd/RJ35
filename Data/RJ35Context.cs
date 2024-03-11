using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RJ35.Models;

namespace RJ35.Data
{
    public class RJ35Context : DbContext
    {
        public RJ35Context (DbContextOptions<RJ35Context> options)
            : base(options)
        {
        }

        public DbSet<RJ35.Models.Cable> Cable { get; set; } = default!;
    }
}
