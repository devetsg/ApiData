using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class NoveltyRegistronovedad
    {
        public NoveltyRegistronovedad()
        {
            NoveltyMessages = new HashSet<NoveltyMessage>();
        }

        public int Id { get; set; }
        public int ConductorId { get; set; }
        public int EstadoNovedadId { get; set; }
        public int NovedadId { get; set; }
        public int? OperarioId { get; set; }
        public int ServicioId { get; set; }
        public int? EstadoLeidoId { get; set; }
        public int? EstadoCerradoId { get; set; }
        public DateTime Date { get; set; }
        public bool EstadoLeidoApp { get; set; }

        public virtual AuthUser Conductor { get; set; } = null!;
        public virtual NoveltyEstadoscerrado? EstadoCerrado { get; set; }
        public virtual NoveltyEstadoleido? EstadoLeido { get; set; }
        public virtual NoveltyEstadonovedad EstadoNovedad { get; set; } = null!;
        public virtual NoveltyNovedad Novedad { get; set; } = null!;
        public virtual AuthUser? Operario { get; set; }
        public virtual ServiciosServicio Servicio { get; set; } = null!;
        public virtual ICollection<NoveltyMessage> NoveltyMessages { get; set; }
    }
}
