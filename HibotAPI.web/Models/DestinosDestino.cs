using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class DestinosDestino
    {
        public DestinosDestino()
        {
            ServiciosServicioDestinos = new HashSet<ServiciosServicio>();
            ServiciosServicioOrigens = new HashSet<ServiciosServicio>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Descripcion { get; set; }
        public int BarrioId { get; set; }
        public string? AK { get; set; }
        public int? TipoDestinoId { get; set; }
        public int? EstadoId { get; set; }
        public int? ClaseDestinoId { get; set; }
        public int? PasajeroId { get; set; }
        public string Latitude { get; set; } = null!;
        public string Longitude { get; set; } = null!;

        public virtual GeneralBarrio Barrio { get; set; } = null!;
        public virtual DestinosClasedestino? ClaseDestino { get; set; }
        public virtual DestinosEstado? Estado { get; set; }
        public virtual PasajerosPasajero? Pasajero { get; set; }
        public virtual DestinosTipodestino? TipoDestino { get; set; }
        public virtual ICollection<ServiciosServicio> ServiciosServicioDestinos { get; set; }
        public virtual ICollection<ServiciosServicio> ServiciosServicioOrigens { get; set; }
    }
}
