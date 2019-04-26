using StockControlWillian.Classe;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControlWillian.Helpers
{
    public class DBProductHelper
    {

        static string connectionString = "workstation id=STOCKCONTROLWILLIAM.mssql.somee.com;packet size=4096;user id=testeswilliam_SQLLogin_1;pwd=y3la73mf6i;data source=STOCKCONTROLWILLIAM.mssql.somee.com;persist security info=False;initial catalog=STOCKCONTROLWILLIAM";

        public static void Create(Product p)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                sqlConnect.Open();
                string sql = "INSERT INTO PRODUCT(NAME, ACTIVE, FK_CATEGORY) VALUES (@name, @active, @cat)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", p.Name));
                cmd.Parameters.Add(new SqlParameter("@active", p.Active));
                cmd.Parameters.Add(new SqlParameter("@cat", p.Categoria.ID));

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

        public static void Update(Product p)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                sqlConnect.Open();
                string sql = "UPDATE PRODUCT SET NAME = @name, ACTIVE = @active WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", p.Name));
                cmd.Parameters.Add(new SqlParameter("@active", p.Active));
                cmd.Parameters.Add(new SqlParameter("@id", p.ID));

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
