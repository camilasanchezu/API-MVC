using CRUD_MVC.Models;
using CRUD_MVC.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CRUD_MVC.Controllers
{
    public class ProductoController : Controller
    {
        // GET: ProductoController
        public IActionResult Index()
        {
            return View(Utils.ListaProducto);
        }

        // GET: ProductoController/Details/5
        public IActionResult Details(int IdProducto)
        {
            Producto producto = Utils.ListaProducto.Find(x => x.IdProducto == IdProducto);
            if (producto != null)
            {
                return View(producto);
            }
            return RedirectToAction("Index");
        }

        // GET: ProductoController/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Producto producto)
        {
            int id = Utils.ListaProducto.Count() + 1;
            producto.IdProducto = id;
            Utils.ListaProducto.Add(producto);
            return RedirectToAction("Index");
        }

        // GET: ProductoController/Edit/5
        public IActionResult Edit(int IdProducto)
        {
            Producto producto = Utils.ListaProducto.Find(x => x.IdProducto == IdProducto);
            if (producto != null)
            {
                return View(producto);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Producto nuevo)
        {
            Producto antiguo = Utils.ListaProducto.Find(x => x.IdProducto == nuevo.IdProducto);
            if (antiguo != null)
            {
                antiguo.Nombre = nuevo.Nombre;
                antiguo.Descripcion = nuevo.Descripcion;
                antiguo.Cantidad = nuevo.Cantidad;
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        // GET: ProductoController/Delete/5
        public IActionResult Delete(int IdProducto)
        {
            Producto producto = Utils.ListaProducto.Find(x => x.IdProducto == IdProducto);
            if (producto != null)
            {
                Utils.ListaProducto.Remove(producto);
            }
            return RedirectToAction("Index");
        }
    }
}
