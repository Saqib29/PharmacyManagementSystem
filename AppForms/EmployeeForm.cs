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
    public partial class EmployeeForm : Form
    {
        Login l;
        MedicineRepo mr;
        EmployeeRepo er;
        public EmployeeForm(Login l)
        {
            this.l = l;
            er = new EmployeeRepo();
            mr = new MedicineRepo();
            InitializeComponent();
            Employee_Info(l);

            List<Medicine> listOfMdc = mr.GetAllMedicine();
            MdcnDataGridView.DataSource = listOfMdc;

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
        private void SaleMdcnBtn(object sender, EventArgs e)
        {
            SaleMedicineForm smdcn = new SaleMedicineForm(l);
            this.Visible = false;
            smdcn.Visible = true;
        }
        private void CrossMethod_Event(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            this.Visible = false;
            l.Visible = true;
        }

        private void ViewMdcn_Method(object sender, EventArgs e)
        {
            List<Medicine> listOfMdc = mr.GetAllMedicine();
            MdcnDataGridView.DataSource = listOfMdc;
        }

        private void MdcnSearchBar_Method(object sender, EventArgs e)
        {
            List<Medicine> mdcnList = mr.GetAllMedicine();
            string keyword = MdcnSearchBox.Text.ToLower();

            List<Medicine> searchList = mdcnList.FindAll(x => (x.MadId.ToLower()).Contains(keyword) || (x.MadName.ToLower()).Contains(keyword) || (x.MadCompanyname.ToLower()).Contains(keyword) || (x.ManufacturingDate.ToLower()).Contains(keyword) || (x.Expiringdate.ToLower()).Contains(keyword) || (x.StockDate.ToLower()).Contains(keyword) || ((x.Price.ToString()).ToLower()).Contains(keyword));

            this.MdcnDataGridView.DataSource = searchList;
        }

        private void Employee_Info(Login l)
        {
            Employee emp = null;
            emp = er.GetEmployee(l.Id);

            this.EmpNamePnl.Text = emp.EmpName;
            this.EmpAgePnl.Text = (emp.EmpAge).ToString();
            this.EmpPhnNmPnl.Text = emp.EmpPhoneNum;
            this.EmpAddressPnl.Text = emp.EmpAddress;

        }
    }
}
