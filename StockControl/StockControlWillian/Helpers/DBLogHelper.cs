using StockControlWillian.Classe;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControlWillian.Helpers
{
    class DBLogHelper
    {
        static string connectionString = "workstation id=STOCKCONTROLWILLIAM.mssql.somee.com;packet size=4096;user id=testeswilliam_SQLLogin_1;pwd=y3la73mf6i;data source=STOCKCONTROLWILLIAM.mssql.somee.com;persist security info=False;initial catalog=STOCKCONTROLWILLIAM";

        public static void Create(Log l)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                sqlConnect.Open();
                string sql = "INSERT INTO LOG(DESCRIPTION, ACTIVE, LOGTYPE) VALUES (@description, @active, @logtype)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@description", l.Description));
                cmd.Parameters.Add(new SqlParameter("@logtype", l.LogType));
                cmd.Parameters.Add(new SqlParameter("@active", l.Active));

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

        public static void Update(Log l)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                sqlConnect.Open();
                string sql = "UPDATE LOG SET DESCRIPTION = @description, ACTIVE = @active, LOGTYPE = @logtype WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@description", l.Description));
                cmd.Parameters.Add(new SqlParameter("@logtype", l.LogType));
                cmd.Parameters.Add(new SqlParameter("@active", l.Active));
                cmd.Parameters.Add(new SqlParameter("@id", l.ID));

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
