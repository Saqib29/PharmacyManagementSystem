using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Interfaces;
using System.Data.SqlClient;

namespace Repository
{
    
    public class LoginRepo : ILoginRepo
    {
        DatabaseConnectionClass dcc;

        public LoginRepo()
        {
            dcc = new DatabaseConnectionClass();
        }
        public bool InsertUser(Login l)
        {
            string query = "INSERT INTO Login values('"+l.Id+"', '"+l.Password+"', "+l.Role+")";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.StackTrace);
                return false;
            }
            finally
            {
                dcc.CloseConnection();
            }
        }

        public bool DeleteUser(Login l)
        {
            string query = "DELETE from Login WHERE Id = '" + l.Id + "'";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { dcc.CloseConnection(); }
        }
        public void UpdateUser(Login l)
        {
            // thank you don't need to update ID & password!
        }

        public Login GetUser(string id, string password)
        {
            Login l = null;
            string query = "SELECT * from Login WHERE Id = '" + id + "' AND Password ='" + password + "'";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                l = new Login();
                l.Id = sdr["Id"].ToString();
                l.Password = sdr["Password"].ToString();
                l.Role = Convert.ToInt32(sdr["Role"]);
            }
            dcc.CloseConnection();
            return l;
        }
    }
}
