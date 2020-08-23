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
    public partial class ManagerForm : Form
    {
        Login l;
        EmployeeRepo er;
        public ManagerForm(Login l)
        {
            this.l = l;
            er = new EmployeeRepo();
            InitializeComponent();
            ManagerInfo(l);

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
        private void CrossMethod_Event(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            this.Visible = false;
            l.Visible = true;
        }
        private void ManageEmpBtnMethod(object sender, EventArgs e)
        {
            ManageEmployee Memp = new ManageEmployee(l);
            this.Visible = false;
            Memp.Visible = true;
        }
        private void ManageMdcnBtn(object sender, EventArgs e)
        {
            ManageMedicine Mmdcn = new ManageMedicine(l);
            this.Visible = false;
            Mmdcn.Visible = true;
        }
        private void CnagePassMethod(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword(l);
            this.Visible = false;
            cp.Visible = true;
        }
        private void ViewSoldMdcnMethod(object sender, EventArgs e)
        {
            ViewSoldMedicine vr = new ViewSoldMedicine(l);
            this.Visible = false;
            vr.Visible = true;
        }

        private void ManagerInfo(Login l)
        {
            Employee empl = null;
            empl = new Employee();
            string id = l.Id;
            empl = er.GetEmployee(id);

            

            this.MngrNamePnl.Text = empl.EmpName;
            this.MngrAgePnl.Text = (empl.EmpAge).ToString();
            this.MngrPhnNmPnl.Text = empl.EmpPhoneNum;
            this.MngrAddressPnl.Text = empl.EmpAddress;

        }


    }
}
