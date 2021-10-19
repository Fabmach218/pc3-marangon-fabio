using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pc3_marangon_fabio.Models
{
    [Table("t_producto")]
    public class Producto
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string ImgUrl {get; set;}
        public string Desc {get; set;}
        public decimal Precio {get; set;}
        public int Celular {get; set;}
        public string LugarCompra {get; set;}
        public string NombreComprador {get; set;}
        public Categoria Categoria {get; set;}
        public DateTime Fecha {get; set;}

        public Producto(){
            Fecha = DateTime.Now;
        }
    }
}