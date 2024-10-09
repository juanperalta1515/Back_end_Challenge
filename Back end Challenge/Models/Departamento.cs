using System;
using System.Collections.Generic;
namespace Back_end_Challenge.Models
{
    public class Departamento
    {
      public  int? IdDepartamento{ get; set; }
       public string? Nombre { get; set; }
      public  DateTime FechaCreacion { get; set; }
        public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();
    }
}
