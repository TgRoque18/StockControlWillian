using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControlWillian.Classe
{
    public class Log
    {
        private int iD;

        private string description;

        private LogType logType;

        private bool active;

        public int ID
        {
            get => iD;
            set => iD = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public bool Active
        {
            get => active;
            set => active = value;
        }
    }
}
