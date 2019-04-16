using StockControlWillian.Classe;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControlWillian.Helpers
{
    class DBLogTypeHelper
    {
        static string connectionString = "workstation id=STOCKCONTROLWILLIAM.mssql.somee.com;packet size=4096;user id=testeswilliam_SQLLogin_1;pwd=y3la73mf6i;data source=STOCKCONTROLWILLIAM.mssql.somee.com;persist security info=False;initial catalog=STOCKCONTROLWILLIAM";

        public static void Create(LogType lt)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                sqlConnect.Open();
                string sql = "INSERT INTO LOG_TYPE(NAME, ACTIVE) VALUES (@name, @active)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", lt.Name));
                cmd.Parameters.Add(new SqlParameter("@active", lt.Active));

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

        public static void Update(LogType lt)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                sqlConnect.Open();
                string sql = "UPDATE LOG_TYPE SET NAME = @name, ACTIVE = @active WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", lt.Name));
                cmd.Parameters.Add(new SqlParameter("@active", lt.Active));
                cmd.Parameters.Add(new SqlParameter("@id", lt.ID));

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
