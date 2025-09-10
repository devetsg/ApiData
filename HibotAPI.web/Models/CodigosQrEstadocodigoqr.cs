using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class CodigosQrEstadocodigoqr
    {
        public CodigosQrEstadocodigoqr()
        {
            CodigosQrCodigosqrs = new HashSet<CodigosQrCodigosqr>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<CodigosQrCodigosqr> CodigosQrCodigosqrs { get; set; }
    }
}
