using StockControlWillian.Classe;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static DataTable GetAll()
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            DataTable dt = new DataTable();
            try
            {
                sqlConnect.Open();
                string sql = "SELECT * FROM CATEGORY WHERE ACTIVE = @active";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@active", true));

                cmd.ExecuteNonQuery();

                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                sqlConnect.Close();
            }

            return dt;
        }

        public static List<Category> GetCategories()
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            List<Category> list = new List<Category>();
            try
            {
                sqlConnect.Open();
                string sql = "SELECT * FROM CATEGORY WHERE ACTIVE = @active";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@active", true));

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Category c = new Category();
                    c.ID = int.Parse(reader["ID"].ToString());
                    c.Name = reader["NAME"].ToString();
                    c.Active = bool.Parse(reader["ACTIVE"].ToString());
                    list.Add(c);
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                sqlConnect.Close();
            }

            return list;
        }

        public static Category GetCategoryByName(string categoryName)
        {
            Category c = new Category();
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                sqlConnect.Open();
                string sql = "SELECT * FROM CATEGORY WHERE ACTIVE = @active AND NAME = @name";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@active", true));
                cmd.Parameters.Add(new SqlParameter("@name", categoryName));

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    c.ID = int.Parse(reader["ID"].ToString());
                    c.Name = reader["NAME"].ToString();
                    c.Active = bool.Parse(reader["ACTIVE"].ToString());
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                sqlConnect.Close();
            }
            return c;
        }
    }
}
