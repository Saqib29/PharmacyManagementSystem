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
    public partial class LoginForm : Form
    {
        public LoginRepo lr;
        public LoginForm()
        {
            InitializeComponent();
            lr = new LoginRepo();
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

        private void BtnLogin(object sender, EventArgs e)
        {
            string id = UsrIdTextBox.Text;
            string password = PaswrdTextBox.Text;
            
            Login l = lr.GetUser(id, password);   
            
            if (l != null)
            {
                if(l.Role == 1)
                {
                    ManagerForm mn = new ManagerForm(l);
                    this.Visible = false;
                    mn.Visible = true;
                }
                else
                {
                    EmployeeForm mf = new EmployeeForm(l);
                    this.Visible = false;
                    mf.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Id or Password Invalid");
            }
        }

        private void CrossMethod_Event(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        
    }
}
