using CRUD_MVC.Models;

namespace CRUD_MVC.Services
{
    public interface IAPIServices
    {
        public Task<List<Producto>> GetProducts();
        public Task<Producto> GetProduct(int id);
        public Task<Producto> PUTProducto(int IdProducto, Producto producto);
        public Task<Producto> POSTProducto(Producto producto);
        public Task DeleteProducto(int id);
    }
}
