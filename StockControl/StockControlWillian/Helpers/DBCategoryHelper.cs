using StockControlWillian.Classe;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControlWillian.Helpers
{
    public static class DBCategoryHelper
    {
        static string connectionString = "workstation id=STOCKCONTROLWILLIAM.mssql.somee.com;packet size=4096;user id=testeswilliam_SQLLogin_1;pwd=y3la73mf6i;data source=STOCKCONTROLWILLIAM.mssql.somee.com;persist security info=False;initial catalog=STOCKCONTROLWILLIAM";

        public static void Create(Category c)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                sqlConnect.Open();
                string sql = "INSERT INTO CATEGORY(NAME, ACTIVE) VALUES (@name, @active)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", c.Name));
                cmd.Parameters.Add(new SqlParameter("@active", c.Active));

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

        public static void Update(Category c)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                sqlConnect.Open();
                string sql = "UPDATE CATEGORY SET NAME = @name, ACTIVE = @active WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", c.Name));
                cmd.Parameters.Add(new SqlParameter("@active", c.Active));
                cmd.Parameters.Add(new SqlParameter("@id", c.ID));

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
