using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PANCHI_PROYECTO1.Models;

namespace PANCHI_PROYECTO1.Data
{
    public class PANCHI_PROYECTO1Context : DbContext
    {
        public PANCHI_PROYECTO1Context (DbContextOptions<PANCHI_PROYECTO1Context> options)
            : base(options)
        {
        }

        public DbSet<PANCHI_PROYECTO1.Models.SPanchi> SPanchi { get; set; } = default!;
        public DbSet<PANCHI_PROYECTO1.Models.Celular> Celular { get; set; } = default!;
    }
}
