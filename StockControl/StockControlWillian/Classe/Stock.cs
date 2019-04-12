using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControlWillian.Classe
{
    public class Stock
    {
        private int iD;

        private int quantity;

        private Product product;

        private bool active;

        public int ID
        {
            get => iD;
            set => iD = value;
        }

        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public bool Active
        {
            get => active;
            set => active = value;
        }
        internal Product Product
        {
            get => product;
            set => product = value;
        }
    }
}
