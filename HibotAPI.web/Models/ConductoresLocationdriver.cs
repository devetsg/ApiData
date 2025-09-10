using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class ConductoresLocationdriver
    {
        public int Id { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public int DriverId { get; set; }
        public DateTime Load { get; set; }

        public virtual AuthUser Driver { get; set; } = null!;
    }
}
