using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ConductoresContratacion
    {
        public ConductoresContratacion()
        {
            ConductoresConductors = new HashSet<ConductoresConductor>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<ConductoresConductor> ConductoresConductors { get; set; }
    }
}
