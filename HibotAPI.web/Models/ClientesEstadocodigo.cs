using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ClientesEstadocodigo
    {
        public ClientesEstadocodigo()
        {
            ClientesCodigoClientes = new HashSet<ClientesCodigoCliente>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<ClientesCodigoCliente> ClientesCodigoClientes { get; set; }
    }
}
