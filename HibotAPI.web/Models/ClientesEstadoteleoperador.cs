using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ClientesEstadoteleoperador
    {
        public ClientesEstadoteleoperador()
        {
            ClientesTeleoperadors = new HashSet<ClientesTeleoperador>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<ClientesTeleoperador> ClientesTeleoperadors { get; set; }
    }
}
