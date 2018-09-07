using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EstudosWebMvc.Models
{
    public class EstudosWebMvcContext : DbContext
    {
        public EstudosWebMvcContext (DbContextOptions<EstudosWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<EstudosWebMvc.Models.Departament> Departament { get; set; }
    }
}
