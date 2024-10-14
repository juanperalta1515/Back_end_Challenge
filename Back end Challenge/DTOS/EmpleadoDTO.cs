using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using Back_end_Challenge.Models;

namespace Back_end_Challenge.DTOS
{
    public class EmpleadoDTO
    {
        public int IdEmpleado { get; set; }
        public string? NombreCompleto { get; set; }
        public int? IdDepartamento { get; set; }
        public string? NombreDepartamento { get; set; }
        public int? Sueldo { get; set; }
        public virtual DateTime FechaContrato { get; set; }
        public virtual Departamento IdDepartamentoNavigation { get; set; }
    }
}
