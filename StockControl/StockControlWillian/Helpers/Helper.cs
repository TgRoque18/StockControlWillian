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
            return ("Não foi possivel realizar esta ação!");
        }

        public static string EPassword()
        {
            return ("User or Password is incorrect.");
        }

        public static string SBanco()
        {
            return ("Não foi possivel realizar esta ação por que ainda não tem banco de dados.");
        }

        public static string Help()
        {
            return ("Please call the suport: CelPhone (24) 99208-6339.");
        }
    }
}
