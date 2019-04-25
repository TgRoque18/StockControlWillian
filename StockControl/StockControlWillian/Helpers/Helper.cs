using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControlWillian.Helpers
{
    class Helper
    {
        public static string Erro()
        {
            return ("Unable to perform this action!");
        }

        public static string EPassword()
        {
            return ("User or Password is incorrect.");
        }
        public static string Password()
        {
            return ("Password and Conf. Password are not the same.");
        }
        public static string Email()
        {
            return ("Email and Conf. Email are not the same.");
        }

        public static string SBanco()
        {
            return ("Sorry! problems with the DataBase.");
        }

        public static string Help()
        {
            return ("Please call the suport: CelPhone (24) 99208-6339.");
        }

        public static string Welcome()
        {
            return ("Welcome to stock control!");
        }
        public static string Product()
        {
            return ("Product registered!");
        }
        public static string Stock()
        {
            return ("Action Completed!");
        }
        public static string Category()
        {
            return ("Category registered!");
        }
        public static string User()
        {
            return ("User registered!");
        }
    }
}