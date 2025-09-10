using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ClientesSector
    {
        public ClientesSector()
        {
            ClientesClientes = new HashSet<ClientesCliente>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int EstadoId { get; set; }

        public virtual ClientesEstadosector Estado { get; set; } = null!;
        public virtual ICollection<ClientesCliente> ClientesClientes { get; set; }
    }
}
