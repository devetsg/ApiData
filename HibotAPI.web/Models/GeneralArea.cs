using System;
using System.Collections.Generic;

namespace HibotAPI.web.Models
{
    public partial class GeneralArea
    {
        public GeneralArea()
        {
            NoveltyNovedads = new HashSet<NoveltyNovedad>();
            UsuariosUserareas = new HashSet<UsuariosUserarea>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public bool IsActive { get; set; }

        public virtual ICollection<NoveltyNovedad> NoveltyNovedads { get; set; }
        public virtual ICollection<UsuariosUserarea> UsuariosUserareas { get; set; }
    }
}
