using System.ComponentModel.DataAnnotations;

namespace Entidad
{
    public class Medico
    {
        [Key]
        public int Matricula { get; set; }
        [MaxLength(50)]
        public string? Nombre { get; set; }
        [MaxLength(100)]
        public string? Apellido { get; set; }

        public int Edad {  get; set; }
    }
}
