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
            optionsBuilder.UseSqlServer("Server=tcp:servidor15octubre.database.windows.net,1433;Initial Catalog=clinicadb;Persist Security Info=False;"+
            "User ID=nimda;Password=0ctubr3.24;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            
            Console.WriteLine("Conexion OK ");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
