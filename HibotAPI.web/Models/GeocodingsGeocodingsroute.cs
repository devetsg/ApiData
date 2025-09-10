using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class GeocodingsGeocodingsroute
    {
        public int ServiceId { get; set; }
        public string? Route { get; set; }

        public virtual ServiciosServicio Service { get; set; } = null!;
    }
}
