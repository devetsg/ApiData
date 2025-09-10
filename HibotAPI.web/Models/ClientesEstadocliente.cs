using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ClientesEstadocliente
    {
        public ClientesEstadocliente()
        {
            ClientesClientes = new HashSet<ClientesCliente>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<ClientesCliente> ClientesClientes { get; set; }
    }
}
