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
    public class MedicineRepo : IMedicineRepo
    {
        DatabaseConnectionClass dcc;
        public MedicineRepo()
        {
            dcc = new DatabaseConnectionClass();
        }
        public bool InsertMedicine(Medicine md)
        {
            string query = "INSERT into Medicine values('" + md.MadId + "', '" + md.MadName + "', '" + md.MadCompanyname + "', '" + md.ManufacturingDate + "', '" + md.Expiringdate + "', '" + md.StockDate + "', " + md.Price + " , " + md.Quantity + ")";

            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            finally { dcc.CloseConnection(); }
        }
        
        public bool UpdateMedicine(Medicine md)
        {
            string query = "UPDATE Medicine SET  Name='"+md.MadName+"', [Company Name]= '"+md.MadCompanyname+"', [Manufcturing Date]= '"+md.ManufacturingDate+"', [Expired date]= '"+md.Expiringdate+"', [Stock date]= '"+md.StockDate+"', Price= "+md.Price+", Quantity= "+ md.Quantity +" WHERE Id = '"+ md.MadId +"'";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp)
            {
                dcc.CloseConnection();
                return false;
            }
            finally { dcc.CloseConnection(); }
        }
        public bool DeleteMedicine(Medicine md)
        {
            string query = "DELETE from Medicine WHERE Id = '"+ md.MadId +"'";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                dcc.CloseConnection();
                return false;
            }
            finally { dcc.CloseConnection(); }
        }
        public Medicine GetMedicine(string med)
        {
            Medicine md = null;
            string query = "SELECT * from Medicine WHERE Id = '"+ med +"'";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            
                while (sdr.Read())
                {
                    md = new Medicine();
                    md.MadId = sdr["Id"].ToString();
                    md.MadName = sdr["Name"].ToString();
                    md.MadCompanyname = sdr["Company Name"].ToString();
                    md.ManufacturingDate = sdr["Manufcturing Date"].ToString();
                    md.Expiringdate = sdr["Expired date"].ToString();
                    md.StockDate = sdr["Stock date"].ToString();
                    md.Price = Convert.ToDouble(sdr["Price"].ToString());
                    md.Quantity = Convert.ToInt32(sdr["Quantity"]);

                }
                dcc.CloseConnection();
                return md;
            
        }
        public List<Medicine> GetAllMedicine()
        {
            List<Medicine> listOfMdcn = new List<Medicine>();
            string query = "SELECT * FROM Medicine";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while(sdr.Read())
            {
                Medicine md = new Medicine();
                md.MadId = sdr["Id"].ToString();
                md.MadName = sdr["Name"].ToString();
                md.MadCompanyname = sdr["Company Name"].ToString();
                md.ManufacturingDate = sdr["Manufcturing Date"].ToString();
                md.Expiringdate = sdr["Expired date"].ToString();
                md.StockDate = sdr["Stock date"].ToString();
                md.Price = Convert.ToDouble(sdr["Price"].ToString());
                md.Quantity = Convert.ToInt32(sdr["Quantity"]);

                listOfMdcn.Add(md);
            }
            dcc.CloseConnection();

            return listOfMdcn;
        }

    }
}
