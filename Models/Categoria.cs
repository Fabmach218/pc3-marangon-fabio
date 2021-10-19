using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace pc3_marangon_fabio.Models
{
    [Table("t_categoria")]
    public class Categoria
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public ICollection<Producto> ListaProductos { get; set; }
    }
}