using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace pc3_marangon_fabio.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<pc3_marangon_fabio.Models.Producto> DataProductos { get; set; }
        public DbSet<pc3_marangon_fabio.Models.Categoria> DataCategorias { get; set; }

    }
}
