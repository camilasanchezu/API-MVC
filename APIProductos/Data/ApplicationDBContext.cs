using APIProductos.Models;
using Microsoft.EntityFrameworkCore;

namespace APIProductos.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(
            DbContextOptions<ApplicationDBContext> options ) : base( options ) { }
        
        public DbSet<Producto> Producto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Creando un producto
            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    IdProducto=1,
                    Nombre = "Scaled and Icy",
                    Descripcion="Album Musical: ALternativo",
                    Cantidad=12
                },

                new Producto
                {
                    IdProducto = 2,
                    Nombre = "1989",
                    Descripcion = "Album Musical: Pop",
                    Cantidad = 2
                },
                new Producto
                {
                    IdProducto = 3,
                    Nombre = "CALM",
                    Descripcion = "Album Musical: Pop",
                    Cantidad = 2
                }


                );
        }
    }
}
