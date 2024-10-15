using Microsoft.EntityFrameworkCore;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Context
{
    public class ClinicaContext:DbContext
    {

        public DbSet<Medico> Medicos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = Room1-TR; Initial Catalog = ClinicaDB; " +
                "encrypt=true;" +
                " trustservercertificate=true; Integrated Security = true");
            
            base.OnConfiguring(optionsBuilder);
        }
    }
}
