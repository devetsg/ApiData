using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ServiciosEventosLog
    {
        public ServiciosEventosLog()
        {
            ServiciosLogServicios = new HashSet<ServiciosLogServicio>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<ServiciosLogServicio> ServiciosLogServicios { get; set; }
    }
}
