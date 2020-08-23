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
    public partial class ViewSoldMedicine : Form
    {
        Login l;
        SaleMedicineRepo sr;
        public ViewSoldMedicine(Login l)
        {
            this.l = l;
            sr = new SaleMedicineRepo();
            InitializeComponent();
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

        private void ViewSoldMedicine_Method(object sender, EventArgs e)
        {
            List<SaleMedicine> listOfMdc = sr.viewSoldMedicine();
            ViewSoldMdcndataGridView.DataSource = listOfMdc;
        }

        private void CrossBack_Method(object sender, EventArgs e)
        {
            ManagerForm m = new ManagerForm(l);
            this.Visible = false;
            m.Visible = true;
        }


    }
}
