using System;
using System.Collections.Generic;

namespace prueba_intento2.Models;

public partial class Ciudadano
{
    public int Id { get; set; }

    public string? Cedula { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Correo { get; set; }

    public DateTime FechaNacimiento { get; set; }

    public string? Profesion { get; set; }

    public int AspiracionSalarial { get; set; }

    public int TipoDocumento { get; set; }

    public virtual ICollection<Vacante> Vacantes { get; } = new List<Vacante>();
}
