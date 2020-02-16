using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CVR.Models;

namespace CVR.Data
{
    public class CVRContext : DbContext
    {
        public CVRContext (DbContextOptions<CVRContext> options)
            : base(options)
        {
        }

        public DbSet<CVR.Models.CvrEntry> CvrEntry { get; set; }
    }
}
