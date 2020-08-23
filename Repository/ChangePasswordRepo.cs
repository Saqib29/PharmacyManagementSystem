using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Repository;
using System.Data.SqlClient;

namespace Repository
{
    
    public class ChangePasswordRepo
    {
        Login l;
        DatabaseConnectionClass dcc;
        public ChangePasswordRepo(Login l)
        {
            this.l = l;
            dcc = new DatabaseConnectionClass();
        }

        public bool Save_Password(Login l, string pass)
        {
            string query = "UPDATE Login SET Password = '"+ pass +"' WHERE Id = '"+ l.Id +"'";

            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch(Exception ex)
            {
                dcc.CloseConnection();
                return false;
            }
        }
    }
}
