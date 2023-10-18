using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1_MVC_2023C2.Models;

namespace WebApplication1_MVC_2023C2.Context
{
    public class EscuelaDatabaseContext : DbContext
    {
        public EscuelaDatabaseContext(DbContextOptions<EscuelaDatabaseContext> options) : base(options)
        {
        }
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
