using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ServiciosSeguimiento
    {
        public ServiciosSeguimiento()
        {
            ServiciosServicios = new HashSet<ServiciosServicio>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<ServiciosServicio> ServiciosServicios { get; set; }
    }
}
