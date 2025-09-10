using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class NovedadesNovedad
    {
        public NovedadesNovedad()
        {
            ServiciosLogServices = new HashSet<ServiciosLogService>();
            ServiciosServicios = new HashSet<ServiciosServicio>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int? SubCategoriaId { get; set; }

        public virtual NovedadesSubcategorium? SubCategoria { get; set; }
        public virtual ICollection<ServiciosLogService> ServiciosLogServices { get; set; }
        public virtual ICollection<ServiciosServicio> ServiciosServicios { get; set; }
    }
}
