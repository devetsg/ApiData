using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class GeocodingsLocationdriver
    {
        public int DriverId { get; set; }
        public string Lat { get; set; } = null!;
        public string Lon { get; set; } = null!;
        public DateTime Modified { get; set; }

        public virtual ConductoresConductor Driver { get; set; } = null!;
    }
}
