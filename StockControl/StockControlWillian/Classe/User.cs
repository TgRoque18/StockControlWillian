using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControlWillian.Classe
{
    class User
    {
        private int iD;

        private string name;

        private string password;

        private string email;

        private UserType userType;

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

        public string Password
        {
            get => password;
            set => password = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public bool Active
        {
            get => active;
            set => active = value;
        }
    }
}
