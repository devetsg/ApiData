using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class TrayectosEstadotrayecto
    {
        public TrayectosEstadotrayecto()
        {
            TrayectosTrayectos = new HashSet<TrayectosTrayecto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<TrayectosTrayecto> TrayectosTrayectos { get; set; }
    }
}
