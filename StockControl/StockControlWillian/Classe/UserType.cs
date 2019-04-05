using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControlWillian.Classe
{
    class UserType
    {
        private int iD;

        private string name;

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

        public bool Active
        {
            get => active;
            set => active = value;
        }
    }
}
