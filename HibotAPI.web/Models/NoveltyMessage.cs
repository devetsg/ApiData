using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class NoveltyMessage
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public DateTime Date { get; set; }
        public bool Flag { get; set; }
        public int TransmitterId { get; set; }
        public int? RegistroNovedadId { get; set; }
        public string? Image { get; set; }

        public virtual NoveltyRegistronovedad? RegistroNovedad { get; set; }
        public virtual AuthUser Transmitter { get; set; } = null!;
    }
}
