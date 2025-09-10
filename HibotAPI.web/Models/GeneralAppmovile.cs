using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class GeneralAppmovile
    {
        public int Id { get; set; }
        public string Version { get; set; } = null!;
        public bool TasWebValidation { get; set; }
        public int TimeDelayStartService { get; set; }
        public DateTime Modified { get; set; }
        public int NumberOfServicesDownload { get; set; }
    }
}
