using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pc3_marangon_fabio.Models;
using pc3_marangon_fabio.Data;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace pc3_marangon_fabio.Controllers
{
    public class ProductoController : Controller
    {
        
        private readonly ApplicationDbContext _context;

        public ProductoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            var fechaActual = DateTime.Now;
            var dia = fechaActual.DayOfYear - 5;
            
            var productos = _context.DataProductos.Include(c => c.Categoria).Where(p => p.Fecha.DayOfYear >= dia);
            return View(productos);
        }

        public IActionResult Crear()
        {

            var categorias = _context.DataCategorias.ToList();

            List<SelectListItem> items = categorias.ConvertAll(c => {

                return new SelectListItem(){

                    Text = c.Nombre,
                    Value = c.Id.ToString(),
                    Selected = false
                };
            });
          
            ViewBag.items = items;


            return View();
        }

        [HttpPost]
        public IActionResult Crear(Producto producto, int categoriaId){

            Categoria categoria = _context.DataCategorias.Find(categoriaId);
            producto.Categoria = categoria;
            _context.Add(producto);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        
    }
}