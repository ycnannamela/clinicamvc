using Entidad;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Context;
namespace Persistencia
{
    public class Persistir_Medico : ICRUD<Medico>
    {
        ClinicaContext context= new Context.ClinicaContext();   

        public bool Create(Medico entidad)
        {
            bool estado=false;
            if (entidad!=null)
            {
                context.Medicos.Add(entidad);
                context.SaveChanges();
                estado = true;
            }
            return estado;
        }

        public bool Delete(Medico entidad)
        {
            Medico? medicoBuscardo = Read(entidad.Matricula);

            bool estado = false;
            if (medicoBuscardo != null)
            {
                context.Medicos.Remove(entidad);
                context.SaveChanges();
                estado = true;
            }

            return estado;
        }

        public Medico? Read(object Id)
        {
            return (from m in context.Medicos where m.Matricula == (int)Id select m).FirstOrDefault();
        }
        public List<Medico> ReadAll()
        {
            return context.Medicos.ToList();
        }

        public bool Update(Medico entidad)
        {
            Medico? medicoBuscardo = Read(entidad.Matricula);

            bool estado = false;
            if (medicoBuscardo != null)
            {
                medicoBuscardo = entidad;
                context.SaveChanges();
                estado = true;
            }

            return estado;
        }
    }
}
