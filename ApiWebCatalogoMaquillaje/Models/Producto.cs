using System;
using System.Collections.Generic;

namespace ApiWebCatalogoMaquillaje.Models
{
    public partial class Producto
    {
        public int Id { get; set; }
        public string? Producto1 { get; set; }
        public decimal? Precio { get; set; }
        public DateTime? FechaCambio { get; set; }
        public byte[]? Imagen { get; set; }
        public int? IdMarca { get; set; }

        public virtual Marca? IdMarcaNavigation { get; set; }
    }
}
