using System;
using System.Collections.Generic;

namespace prueba_intento2.Models;

public partial class Vacante
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string Cargo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Empresa { get; set; } = null!;

    public int Salario { get; set; }

    public int? CiudadanoId { get; set; }

    public virtual Ciudadano? Ciudadano { get; set; }
}
