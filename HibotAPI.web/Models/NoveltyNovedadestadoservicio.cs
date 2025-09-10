using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class NoveltyNovedadestadoservicio
    {
        public int Id { get; set; }
        public int EstadoServicioId { get; set; }
        public int NovedadId { get; set; }

        public virtual ServiciosEstadoservicio EstadoServicio { get; set; } = null!;
        public virtual NoveltyNovedad Novedad { get; set; } = null!;
    }
}
