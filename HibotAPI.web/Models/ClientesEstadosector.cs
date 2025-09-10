using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ClientesEstadosector
    {
        public ClientesEstadosector()
        {
            ClientesSectors = new HashSet<ClientesSector>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<ClientesSector> ClientesSectors { get; set; }
    }
}
