using Interfaces;
using Entidad;
using Persistencia;

namespace Actividad
{
    public class Actividad_Medico : ICRUD<Medico>
    {
        Persistir_Medico persistir_medico=new Persistir_Medico();

        public bool Create(Medico entidad)
        {
            return persistir_medico.Create(entidad);
        }

        public bool Delete(Medico entidad)
        {
            return persistir_medico.Delete(entidad);
        }

        public Medico? Read(object Id)
        {
            return persistir_medico.Read(Id);
        }

        public List<Medico> ReadAll()
        {
            return persistir_medico.ReadAll();
        }

        public bool Update(Medico entidad)
        {
            return persistir_medico.Update(entidad);
        }
    }
}
