using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ConductoresEstadoHorario
    {
        public ConductoresEstadoHorario()
        {
            ConductoresHorarios = new HashSet<ConductoresHorario>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<ConductoresHorario> ConductoresHorarios { get; set; }
    }
}
