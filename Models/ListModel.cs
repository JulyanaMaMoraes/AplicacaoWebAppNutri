using System.Collections.Generic;

namespace Teste.Models
{
    public class ListModel<T>
    {
        public List<T> Items { get; set; }

        public ListModel(List<T> items)
        {
            Items = items;
        }

        public ListModel()
        {
            Items = new List<T>();
        }
    }
}

