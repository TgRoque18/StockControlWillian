using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControlWillian.Classe
{
    public class Product
    {
        private int iD;

        private string name;

        private double price;

        private Category categoria;

        private bool active;

        public int ID
        {
            get => iD;
            set => iD = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }

        public bool Active
        {
            get => active;
            set => active = value;
        }
        internal Category Categoria
        {
            get => categoria;
            set => categoria = value;
        }
    }
}
