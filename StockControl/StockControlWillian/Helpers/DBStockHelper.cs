using StockControlWillian.Classe;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControlWillian.Helpers
{
    class DBStockHelper
    {
        static string connectionString = "workstation id=STOCKCONTROLWILLIAM.mssql.somee.com;packet size=4096;user id=testeswilliam_SQLLogin_1;pwd=y3la73mf6i;data source=STOCKCONTROLWILLIAM.mssql.somee.com;persist security info=False;initial catalog=STOCKCONTROLWILLIAM";

        public static void Create(Stock s)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                sqlConnect.Open();
                string sql = "INSERT INTO STOCK(PRODUCT, ACTIVE, QUANTITY) VALUES (@product, @active, @quantity)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@product", s.Product));
                cmd.Parameters.Add(new SqlParameter("@quantity", s.Quantity));
                cmd.Parameters.Add(new SqlParameter("@active", s.Active));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        public static void Update(Stock s)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                sqlConnect.Open();
                string sql = "UPDATE STOCK SET PRODUCT = @product, ACTIVE = @active, QUANTITY = @quantity  WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", s.Product));
                cmd.Parameters.Add(new SqlParameter("@quantity", s.Quantity));
                cmd.Parameters.Add(new SqlParameter("@active", s.Active));
                cmd.Parameters.Add(new SqlParameter("@id", s.ID));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                sqlConnect.Close();
            }
        }
    }
}
