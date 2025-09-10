using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ConductoresOperative
    {
        public int UserId { get; set; }
        public int? EstadoId { get; set; }

        public virtual ConductoresEstadoconductor? Estado { get; set; }
        public virtual AuthUser User { get; set; } = null!;
    }
}
