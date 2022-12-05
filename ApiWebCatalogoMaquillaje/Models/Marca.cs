using System;
using System.Collections.Generic;

namespace ApiWebCatalogoMaquillaje.Models
{
    public partial class Marca
    {
        public Marca()
        {
            Productos = new HashSet<Producto>();
        }

        public int Id { get; set; }
        public string? Marca1 { get; set; }
        public DateTime? FechaCambio { get; set; }
        public string? UsrIng { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
