using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Repository;

namespace AppForms
{
    public partial class SaleMedicineForm : Form
    {
        Login l;
        MedicineRepo mr;
        string quantity;
        SaleMedicineRepo sr;
        public SaleMedicineForm(Login l)
        {
            
            this.l = l;
            InitializeComponent();
            mr = new MedicineRepo();
            sr = new SaleMedicineRepo();
            List<Medicine> listOfMdc = mr.GetAllMedicine();
            allMdcnGridView.DataSource = listOfMdc;
        }
        int mouseX, mouseY;
        bool mouseDown = false;
        // methods only for form body & border and Cross Button .................
        private void MouseDown_Move_Method(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            mouseDown = true;
        }
        private void MouseMove_Move_Method(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }
        private void MouseUp_Move_Method(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Logout_Method(object sender, EventArgs e)
        {
            sr.cencelmethod();
            LoginForm l = new LoginForm();
            this.Visible = false;
            l.Visible = true;
        }

        private void MdcnSearchedBox_Method(object sender, EventArgs e)
        {
            List<Medicine> mdcnList = mr.GetAllMedicine();
            string keyword = MdcnSearchBox.Text.ToLower();

            List<Medicine> searchList = mdcnList.FindAll(x => (x.MadId.ToLower()).Contains(keyword) || (x.MadName.ToLower()).Contains(keyword) || (x.MadCompanyname.ToLower()).Contains(keyword) || (x.ManufacturingDate.ToLower()).Contains(keyword) || (x.Expiringdate.ToLower()).Contains(keyword) || (x.StockDate.ToLower()).Contains(keyword) || ((x.Price.ToString()).ToLower()).Contains(keyword));

            allMdcnGridView.DataSource = searchList;
        }

        private void Table_Data_Click_Method(object sender, DataGridViewCellEventArgs e)
        {
            Medicine m = new Medicine();
            
            if (false)
            {
                _ = MessageBox.Show("Not enough in Quantity");
            }
            else
            {
                m.MadId = allMdcnGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                m.MadName = allMdcnGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                m.MadCompanyname = allMdcnGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                m.ManufacturingDate = allMdcnGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                m.Expiringdate = allMdcnGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                m.StockDate = allMdcnGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                m.Price = Convert.ToDouble(allMdcnGridView.Rows[e.RowIndex].Cells[6].Value);
                m.Quantity = Convert.ToInt32(allMdcnGridView.Rows[e.RowIndex].Cells[7].Value);
                string g = this.quantityTB.Text;
                if (string.IsNullOrEmpty(g))
                {
                    MessageBox.Show("first input quantitty");
                    return;
                }
                else
                {
                    quantity = this.quantityTB.Text;
                }
                
                sr.addtoChart_Method(m, quantity);
                this.viewinChart_Method(sender, e);
            }
            
        }

        private void cell_Click_SoldTable_Method(object sender, DataGridViewCellEventArgs e)
        {
            SaleMedicine sm = new SaleMedicine();

            sm.MadId = AddtoCharGridDataView.Rows[e.RowIndex].Cells[0].Value.ToString();
            sm.MadName = AddtoCharGridDataView.Rows[e.RowIndex].Cells[1].Value.ToString();
            sm.MadCompanyname = AddtoCharGridDataView.Rows[e.RowIndex].Cells[2].Value.ToString();
            sm.ManufacturingDate = AddtoCharGridDataView.Rows[e.RowIndex].Cells[3].Value.ToString();
            sm.Expiringdate = AddtoCharGridDataView.Rows[e.RowIndex].Cells[4].Value.ToString();
            sm.StockDate = AddtoCharGridDataView.Rows[e.RowIndex].Cells[5].Value.ToString();
            sm.Quantity = Convert.ToInt32(AddtoCharGridDataView.Rows[e.RowIndex].Cells[6].Value);
            sm.Price = Convert.ToDouble(AddtoCharGridDataView.Rows[e.RowIndex].Cells[7].Value);
            sm.SaleDate = AddtoCharGridDataView.Rows[e.RowIndex].Cells[8].Value.ToString();

            sr.deletefromChart(sm);
            this.viewinChart_Method(sender, e);
        }

        private void CnfrmForsale_Method(object sender, EventArgs e)
        {
            if(sr.confirmMethod())
            {
                MessageBox.Show("Confirmed");
                List<Medicine> listOfMdc = mr.GetAllMedicine();
                allMdcnGridView.DataSource = listOfMdc;
            }
            else
            {
                MessageBox.Show("Not Confirmed");
            }

            sr.cencelmethod();
            EmployeeForm emf = new EmployeeForm(this.l);
            this.Visible = false;
            emf.Visible = true;
        }

        private void CancelBtn_Click_Method(object sender, EventArgs e)
        {
            sr.cencelmethod();
            EmployeeForm ef = new EmployeeForm(this.l);
            this.Visible = false;
            ef.Visible = true;
        }

        private void viewinChart_Method(object sender, EventArgs e)
        {
            List<SaleMedicine> lsitsoldMedicine = sr.getSoldMedicine();
            AddtoCharGridDataView.DataSource = lsitsoldMedicine;
        }

        private void CrossBack_Method(object sender, EventArgs e)
        {
            sr.cencelmethod();
            EmployeeForm Efrm = new EmployeeForm(l);
            this.Visible = false;
            Efrm.Visible = true;
        }
    }
}
