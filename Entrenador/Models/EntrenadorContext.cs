using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVCCRUD.Models
{
    public class EntrenadorContext:DbContext
    {
         public EntrenadorContext(DbContextOptions<EntrenadorContext> options):base(options)
        {
        }

        public DbSet<Entrenador> Diego { get; set; }
        
    }
}