using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControlWillian.Classe
{
    class Product
    {
        private int iD;

        private string name;

        private double price;

        private Category categoria;

        private bool ativate;

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

        public bool Ativate
        {
            get => ativate;
            set => ativate = value;
        }
        internal Category Categoria
        {
            get => categoria;
            set => categoria = value;
        }
    }
}
