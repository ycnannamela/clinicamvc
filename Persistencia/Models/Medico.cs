using System;
using System.Collections.Generic;

namespace Persistencia.Models;

public partial class Medico
{
    public int Matricula { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public int Edad { get; set; }
}
