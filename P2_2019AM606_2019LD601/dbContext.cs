using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace P2_2019AM606_2019LD601
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {

        }

        /*public DbSet<CasosReportados> regiones { get; set; }
        public DbSet<Departamentos> departamentos { get; set; }
        public DbSet<Generos> registros { get; set; }*/
    }
}
