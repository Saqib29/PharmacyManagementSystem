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
    public partial class ChangePassword : Form
    {
        Login l;
        ChangePasswordRepo cp;
        public ChangePassword(Login l)
        {
            this.l = l;
            InitializeComponent();
            cp = new ChangePasswordRepo(l);
        }
        int mouseX, mouseY;
        bool mouseDown;
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

        private void Save_Password_Method(object sender, EventArgs e)
        {
            string one = NewPaswrdTextBox.Text;
            string two = ConfirmPaswrdTextBox.Text;

            if(one.Equals(two))
            {
                if(cp.Save_Password(l, two))
                {
                    MessageBox.Show("Password Changed");
                }
                else
                {
                    MessageBox.Show("Password Not Changed!");
                }
            }
            else
            {
                MessageBox.Show("Password didn't matched!");
            }

            ManagerForm mn = new ManagerForm(l);
            this.Visible = false;
            mn.Visible = true;
        }

        private void CrossMethod_Event(object sender, EventArgs e)
        {
            ManagerForm mn = new ManagerForm(l);
            this.Visible = false;
            mn.Visible = true;
        }


    }
}
