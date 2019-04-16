using StockControlWillian.Classe;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControlWillian.Helpers
{
    class DBUserHelper
    {
        static string connectionString = "workstation id=STOCKCONTROLWILLIAM.mssql.somee.com;packet size=4096;user id=testeswilliam_SQLLogin_1;pwd=y3la73mf6i;data source=STOCKCONTROLWILLIAM.mssql.somee.com;persist security info=False;initial catalog=STOCKCONTROLWILLIAM";

        public static void Create(User u)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                sqlConnect.Open();
                string sql = "INSERT INTO USER(NAME, ACTIVE, PASSWORD, EMAIL) VALUES (@name, @active, @password, @email)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", u.Name));
                cmd.Parameters.Add(new SqlParameter("@password", u.Password));
                cmd.Parameters.Add(new SqlParameter("@email", u.Email));
                cmd.Parameters.Add(new SqlParameter("@active", u.Active));

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

        public static void Update(User u)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                sqlConnect.Open();
                string sql = "UPDATE USER SET NAME = @name, PASSWORD = @password, EMAIL = @email, ACTIVE = @active WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", u.Name));
                cmd.Parameters.Add(new SqlParameter("@password", u.Password));
                cmd.Parameters.Add(new SqlParameter("@email", u.Email));
                cmd.Parameters.Add(new SqlParameter("@active", u.Active));
                cmd.Parameters.Add(new SqlParameter("@id", u.ID));

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
