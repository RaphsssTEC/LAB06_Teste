using System;
using System.Collections.Generic;

namespace Clinica_LAB06.Models;

public partial class Consulta
{
    public int Codigo { get; set; }

    public DateTime Datahora { get; set; }

    public string StatusConsulta { get; set; } = null!;

    public int PacienteId { get; set; }

    public int MedicoId { get; set; }

    public virtual Medico Medico { get; set; } = null!;

    public virtual Paciente Paciente { get; set; } = null!;
}
