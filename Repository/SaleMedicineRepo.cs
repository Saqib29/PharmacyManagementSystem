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
    public class SaleMedicineRepo : IsaleMedicine
    {
        DatabaseConnectionClass dcc;
        
        string quantityOfMdcn;
        public List<Medicine> listToUpdateMedicin = new List<Medicine> ();
        
        string salequantitty;
        string salDate;
        public List<SaleMedicine> listToSale = new List<SaleMedicine> ();
        public SaleMedicineRepo()
        {
            dcc = new DatabaseConnectionClass();
            
        }

        public bool addtoChart_Method(Medicine m, string quantity)
        {
            SaleMedicine sl;
            DateTime d = new DateTime();
            
            
            int u = m.Quantity;
            int q = int.Parse(quantity);
            int k = u - q;
            
            quantityOfMdcn = k.ToString();
            string query = "INSERT into addToChart values('" + m.MadId + "', '" + m.MadName + "', '" + m.MadCompanyname + "', '" + m.ManufacturingDate + "', '" + m.Expiringdate + "', '" + m.StockDate + "', " + m.Price + " , " + quantity + ", '" + d + "')";

            sl = new SaleMedicine();
            sl.MadId = m.MadId;
            sl.MadName = m.MadName;
            sl.MadCompanyname = m.MadCompanyname;
            sl.ManufacturingDate = m.ManufacturingDate;
            sl.Expiringdate = m.Expiringdate;
            sl.StockDate = m.StockDate;
            sl.Price = m.Price;
            sl.Quantity = int.Parse(quantity);
            sl.SaleDate = d.ToString();

            listToSale.Add(sl);

            m.Quantity = k;
            listToUpdateMedicin.Add(m);
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

        public bool deletefromChart(SaleMedicine m)
        {
            string query = "DELETE from addToChart WHERE Id = '" + m.MadId + "'";
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

            var item = listToSale.Find(x => x.MadId == m.MadId);
            listToSale.Remove(item);

            var del = listToUpdateMedicin.Find(x => x.MadId == m.MadId);
            listToUpdateMedicin.Remove(del);
        }
        public bool confirmMethod()
        {
            string query = "DELETE FROM addToChart";
            foreach (Medicine m in listToUpdateMedicin)
            {
                dcc.ConnectWithDB();
                string qForMedicine = "UPDATE Medicine SET  Name='" + m.MadName + "', [Company Name]= '" + m.MadCompanyname + "', [Manufcturing Date]= '" + m.ManufacturingDate + "', [Expired date]= '" + m.Expiringdate + "', [Stock date]= '" + m.StockDate + "', Price= " + m.Price + ", Quantity= " + m.Quantity + " WHERE Id = '" + m.MadId + "'";
                int o = dcc.ExecuteSQL(qForMedicine);
                dcc.CloseConnection();
            }
            foreach (SaleMedicine i in listToSale)
            {
                dcc.ConnectWithDB();
                string qForSoldTable = "INSERT into SoldMedicine values('" + i.MadId + "', '" + i.MadName + "', '" + i.MadCompanyname + "', '" + i.ManufacturingDate + "', '" + i.Expiringdate + "', '" + i.StockDate + "', " + i.Price + " , " + i.Quantity + ", '" + i.SaleDate + "')";
                int p = dcc.ExecuteSQL(qForSoldTable);
                dcc.CloseConnection();
            }

            //string UpqueeryFrSoldTable = "UPDATE SoldMedicine SET Name = '" + mg.MadName + "', Company Name = '" + mg.MadCompanyname + "', Manufcturing Date = '" + mg.ManufacturingDate + "', Expired date = '" + mg.Expiringdate + "', Stock date '" + mg.StockDate + "', Price = '" + mg.Price + "' , Quantity = '" + salequantitty + "', Sold date = '"+ salDate + "' , WHERE Id = '" + mg.MadId + "'";
            try
            {
                
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                
                listToSale.Clear();
                listToUpdateMedicin.Clear();
                return true;
            }
            catch (Exception ex)
            {
                dcc.CloseConnection();
                listToSale.Clear();
                listToUpdateMedicin.Clear();
                return false;
            }
            finally { dcc.CloseConnection(); }


        }

        public List<SaleMedicine> getSoldMedicine()
        {
            List <SaleMedicine> soldMDCNList = new List<SaleMedicine>();
            string query = "SELECT * from addToChart";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while(sdr.Read())
            {
                SaleMedicine md = new SaleMedicine();
                md.MadId = sdr["Id"].ToString();
                md.MadName = sdr["Name"].ToString();
                md.MadCompanyname = sdr["Company Name"].ToString();
                md.ManufacturingDate = sdr["Manufcturing Date"].ToString();
                md.Expiringdate = sdr["Expired date"].ToString();
                md.StockDate = sdr["Stock date"].ToString();
                md.Price = Convert.ToDouble(sdr["Price"].ToString());
                md.Quantity = Convert.ToInt32(sdr["Quantity"]);
                md.SaleDate = sdr["sale Date"].ToString();
                soldMDCNList.Add(md);
            }
            dcc.CloseConnection();
            return soldMDCNList;
        }

        public void cencelmethod()
        {
            string query = "DELETE FROM addToChart";
            if(listToSale != null)
            {
                listToSale.Clear();
            }
            if(listToUpdateMedicin != null)
            {
                listToUpdateMedicin.Clear();
            }
            
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
            }
            catch (Exception ex)
            {
                dcc.CloseConnection();
            }
            finally { dcc.CloseConnection(); }
        }

        public List<SaleMedicine> viewSoldMedicine()
        {
            List<SaleMedicine> soldMDCNList = new List<SaleMedicine>();
            string query = "SELECT * from SoldMedicine";

            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                SaleMedicine md = new SaleMedicine();
                md.MadId = sdr["Id"].ToString();
                md.MadName = sdr["Name"].ToString();
                md.MadCompanyname = sdr["Company Name"].ToString();
                md.ManufacturingDate = sdr["Manufcturing Date"].ToString();
                md.Expiringdate = sdr["Expired date"].ToString();
                md.StockDate = sdr["Stock date"].ToString();
                md.Price = Convert.ToDouble(sdr["Price"].ToString());
                md.Quantity = Convert.ToInt32(sdr["Quantity"]);
                md.SaleDate = sdr["Sold date"].ToString();
                soldMDCNList.Add(md);
            }
            dcc.CloseConnection();
            return soldMDCNList;
        }
    }
}
