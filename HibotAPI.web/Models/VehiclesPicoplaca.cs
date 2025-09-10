using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class VehiclesPicoplaca
    {
        public int Id { get; set; }
        public DateOnly Fecha { get; set; }
        public int Digito1 { get; set; }
        public int Digito2 { get; set; }
        public int MunicipioId { get; set; }

        public virtual GeneralCiudad Municipio { get; set; } = null!;
    }
}
