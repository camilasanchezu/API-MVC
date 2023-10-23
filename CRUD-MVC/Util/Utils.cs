using CRUD_MVC.Models;

namespace CRUD_MVC.Util
{
    public class Utils
    {
        public static List<Producto> ListaProducto = new List<Producto>()
        {
            new Producto()
            {
                IdProducto = 1,
                Nombre = "Scaled and Icy",
                Descripcion = "Album Musical",
                Cantidad = 20
            },

            new Producto()
            {
                IdProducto = 2,
                Nombre = "1989",
                Descripcion = "Album Musical",
                Cantidad = 15
            },

            new Producto()
            {
                IdProducto = 3,
                Nombre = "CALM",
                Descripcion = "Album Musical",
                Cantidad = 2
            }
        };
    }
}
