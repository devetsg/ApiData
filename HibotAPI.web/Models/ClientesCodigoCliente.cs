using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ClientesCodigoCliente
    {
        public ClientesCodigoCliente()
        {
            ServiciosServicios = new HashSet<ServiciosServicio>();
        }

        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Atributo { get; set; }
        public string? Descripcion { get; set; }
        public string? Mayor { get; set; }
        public string? Menor { get; set; }
        public string? Valor { get; set; }
        public int? ClienteId { get; set; }
        public string? Lote { get; set; }
        public int EstadoId { get; set; }

        public virtual ClientesCliente? Cliente { get; set; }
        public virtual ClientesEstadocodigo Estado { get; set; } = null!;
        public virtual ICollection<ServiciosServicio> ServiciosServicios { get; set; }
    }
}
