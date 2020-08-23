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
    
    public partial class ManageMedicine : Form
    {
        Login l;
        MedicineRepo mr;

        public ManageMedicine(Login l)
        {
            this.l = l;
            InitializeComponent();
            mr = new MedicineRepo();

            List<Medicine> listOfMdc = mr.GetAllMedicine();
            MdcnDataTableGridView.DataSource = listOfMdc;

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

        private void Logout_Btn_Click_Method(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            this.Visible = false;
            lg.Visible = true;
        }

        private void ViewMedicine_Method(object sender, EventArgs e)
        {
            List<Medicine> listOfMdc = mr.GetAllMedicine();
            MdcnDataTableGridView.DataSource = listOfMdc;
        }

        private void Insert_Medicine_Method(object sender, EventArgs e)
        {
            Medicine m = new Medicine();

            try
            {
                m.MadId = this.mdcnIdTB.Text;
                m.MadName = this.mdcnNameTB.Text;
                m.MadCompanyname = this.mdcnComTB.Text;
                m.ManufacturingDate = this.mdcnMnfctDateTB.Text;
                m.Expiringdate = this.mdcnExpDateTB.Text;
                m.StockDate = this.mdcnStckDateTB.Text;
                m.Quantity = Convert.ToInt32(this.mdcnqntityTB.Text);
                m.Price = Convert.ToDouble(this.mdcnpriceTB.Text);

                if (mr.InsertMedicine(m))
                {
                    MessageBox.Show("Medicine "+ m.MadName +" Inserted");
                }
                else
                {
                    MessageBox.Show("Didn't inserted!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Data");
            }
            finally
            {
                this.ViewMedicine_Method(sender, e);
            }

            this.refreshdataBtn.Enabled = true;
        }

        private void Update_Method(object sender, EventArgs e)
        {
            Medicine m = new Medicine();

            m.MadId = this.mdcnIdTB.Text;
            m.MadName = this.mdcnNameTB.Text;
            m.MadCompanyname = this.mdcnComTB.Text;
            m.ManufacturingDate = this.mdcnMnfctDateTB.Text;
            m.Expiringdate = this.mdcnExpDateTB.Text;
            m.StockDate = this.mdcnStckDateTB.Text;
            m.Quantity = Convert.ToInt32(this.mdcnqntityTB.Text);
            m.Price = Convert.ToDouble(this.mdcnpriceTB.Text);


            if (mr.UpdateMedicine(m))
            {
                MessageBox.Show("Updated");
                this.Refresh_Data_Method(sender, e);
                this.ViewMedicine_Method(sender, e);
            }
            else
            {
                MessageBox.Show("Didn't Updated");
            }

            this.ViewMedicine_Method(sender, e);
        }

        private void Delete_Method(object sender, EventArgs e)
        {
            Medicine m = new Medicine();

            m.MadId = this.mdcnIdTB.Text;

            if(mr.DeleteMedicine(m))
            {
                MessageBox.Show("Deleted");
                this.Refresh_Data_Method(sender, e);
                this.ViewMedicine_Method(sender, e);
            }
            else
            {
                MessageBox.Show("Can't Delete");
            }

            this.ViewMedicine_Method(sender, e);
        }

        private void SearchMedicine_Method(object sender, EventArgs e)
        {
            List<Medicine> mdcnList = mr.GetAllMedicine();
            string keyword = MdcnSearchBox.Text.ToLower();

            List<Medicine> seachList = mdcnList.FindAll(x=> (x.MadId.ToLower()).Contains(keyword) || (x.MadName.ToLower()).Contains(keyword) || (x.MadCompanyname.ToLower()).Contains(keyword) || (x.ManufacturingDate.ToLower()).Contains(keyword) || (x.Expiringdate.ToLower()).Contains(keyword) || (x.StockDate.ToLower()).Contains(keyword) || ((x.Price.ToString()).ToLower()).Contains(keyword));

            this.MdcnDataTableGridView.DataSource = seachList;

        }

        private void MdcnTableClick_Method(object sender, DataGridViewCellEventArgs e)
        {
            this.mdcnIdTB.Text = MdcnDataTableGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.mdcnNameTB.Text = MdcnDataTableGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.mdcnComTB.Text = MdcnDataTableGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.mdcnMnfctDateTB.Text = MdcnDataTableGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.mdcnExpDateTB.Text = MdcnDataTableGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.mdcnStckDateTB.Text = MdcnDataTableGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            this.mdcnqntityTB.Text = MdcnDataTableGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            this.mdcnpriceTB.Text = MdcnDataTableGridView.Rows[e.RowIndex].Cells[7].Value.ToString();

            this.refreshdataBtn.Enabled = true;
            this.updateBtn.Enabled = true;
            this.deleteBtn.Enabled = true;
            this.loadBtn.Enabled = false;
            this.insertBtn.Enabled = false;

            this.mdcnIdTB.Enabled = false;
        }

        private void Refresh_Data_Method(object sender, EventArgs e)
        {
            this.mdcnIdTB.Text = "";
            this.mdcnNameTB.Text = "";
            this.mdcnComTB.Text = "";
            this.mdcnMnfctDateTB.Text = "";
            this.mdcnExpDateTB.Text = "";
            this.mdcnStckDateTB.Text = "";
            this.mdcnqntityTB.Text = "";
            this.mdcnpriceTB.Text = "";

            this.loadBtn.Enabled = true;
            this.insertBtn.Enabled = true;
            this.refreshdataBtn.Enabled = false;
            this.updateBtn.Enabled = false;
            this.deleteBtn.Enabled = false;

            this.mdcnIdTB.Enabled = true;
        }

        private void CrossBack_Method(object sender, EventArgs e)
        {
            ManagerForm m = new ManagerForm(l);
            this.Visible = false;
            m.Visible = true;
        }
    }
}
