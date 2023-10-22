using System;
using System.Collections.Generic;

namespace APIProductos.Services
{
    public interface IMiServicioScoped
    {
        List<string> GetItems();
    }

    public class MiServicioScoped : IMiServicioScoped
    {
        private List<string> items;

        public MiServicioScoped()
        {
            items = new List<string>();
        }

        public List<string> GetItems()
        {
            return items;
        }

        public void AddItem(string item)
        {
            items.Add(item);
        }
    }
}

