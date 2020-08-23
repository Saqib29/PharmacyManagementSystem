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
    public partial class ManageEmployee : Form
    {
        Login l;
        EmployeeRepo er;
        LoginRepo lr;
        public ManageEmployee(Login l)
        {
            this.l = l;
            InitializeComponent();
            lr = new LoginRepo();
            er = new EmployeeRepo();

            List<Employee> emplist = er.GetAllEmployees();
            this.EmpployeeDataTableGridView.DataSource = emplist;
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

        private void InsertBtn_Method(object sender, EventArgs e)
        {
            Login l = new Login();
            Employee emp = new Employee();
            int p = new Random().Next(99999999) + 10000000;


            try
            {
                l.Id = this.EmpIdTB.Text;
                l.Password = p + "";


                emp.EmpId = this.EmpIdTB.Text;
                emp.EmpName = this.EmpNameTB.Text;
                emp.EmpPhoneNum = this.EmpPhnNumberTB1.Text + this.EmpPhnNumberTB2.Text;
                emp.EmpAge = Convert.ToInt32(this.EmpAgeTB.Text);
                emp.EmpSalary = Convert.ToInt32(this.EmpSalaryTB.Text);
                emp.EmpDesignation = this.EmpDesignationTB.Text;
                emp.EmpAddress = this.EmpAddressTB.Text;

                if ((emp.EmpDesignation.ToLower()).Equals("manager"))
                {
                    l.Role = 1;
                }
                else
                {
                    l.Role = 0;
                }
                if (lr.InsertUser(l))
                {
                    if (er.InsertEmployee(emp))
                    {
                        MessageBox.Show("Emplyee Added. Id = " + l.Id + " & Password = " + l.Password + "");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Can not Add Id: " + l.Id + "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalied Data!");
            }
            finally
            {
                this.ViewAllEmployee_Method(sender, e);
            }
        }

        private void Refresh_Btn_Click(object sender, EventArgs e)
        {
            this.EmpIdTB.Text = "";
            this.EmpNameTB.Text = "";
            this.EmpPhnNumberTB2.Text = "";
            this.EmpAgeTB.Text = "";
            this.EmpSalaryTB.Text = "";
            this.EmpDesignationTB.Text = "";
            this.EmpAddressTB.Text = "";


            this.refreshdataBtn.Enabled = false;
            this.loadBtn.Enabled = true;
            this.updateBtn.Enabled = false;
            this.insertBtn.Enabled = true;
            this.deleteBtn.Enabled = false;

            this.EmpIdTB.Enabled = true;
        }

        private void Update_Click_Method(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            emp.EmpId = this.EmpIdTB.Text;
            emp.EmpName = this.EmpNameTB.Text;
            emp.EmpAge = int.Parse(this.EmpAgeTB.Text);
            emp.EmpPhoneNum = this.EmpPhnNumberTB1.Text + this.EmpPhnNumberTB2.Text;
            emp.EmpSalary = Convert.ToDouble(this.EmpSalaryTB.Text);
            emp.EmpDesignation = this.EmpDesignationTB.Text;
            emp.EmpAddress = this.EmpAddressTB.Text;

            if(er.UpdateEmployee(emp))
            {
                MessageBox.Show("Updaded");
                this.Refresh_Btn_Click(sender, e);
                this.ViewAllEmployee_Method(sender, e);
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
        }

        private void Delete_Click_Method(object sender, EventArgs e)
        {
            Login l = new Login();
            Employee emp = new Employee();
            l.Id = this.EmpIdTB.Text;
            emp.EmpId = this.EmpIdTB.Text;
            
            if (lr.DeleteUser(l))
            {
                if (er.DeleteEmployee(emp))
                {
                    MessageBox.Show("Deleted User");
                    this.Refresh_Btn_Click(sender, e);
                    this.ViewAllEmployee_Method(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Can't Delete");
            }
        }

        private void ViewAllEmployee_Method(object sender, EventArgs e)
        {
            List<Employee> emplist = er.GetAllEmployees();
            this.EmpployeeDataTableGridView.DataSource = emplist;
        }

        private void SearchBar_Method(object sender, EventArgs e)
        {
            List<Employee> listOfemployee = er.GetAllEmployees();
            string keyword = EmpSearchBox.Text.ToLower();
            List<Employee> searchList = listOfemployee.FindAll(x => ((x.EmpId.ToLower()).Contains(keyword)) || ((x.EmpName.ToLower()).Contains(keyword)) || ((x.EmpPhoneNum.ToLower()).Contains(keyword)) | (((x.EmpAge.ToString()).ToLower()).Contains(keyword)) || (((x.EmpSalary.ToString()).ToLower()).Contains(keyword)) || ((x.EmpDesignation.ToLower()).Contains(keyword)) || ((x.EmpAddress.ToLower()).Contains(keyword)));

            EmpployeeDataTableGridView.DataSource = searchList;
        }

        private void logout_Btn_Click(object sender, EventArgs e)
        {
            LoginForm lo = new LoginForm();
            this.Visible = false;
            lo.Visible = true;
        }
        private void EmpTableCellClick_Method(object sender, DataGridViewCellEventArgs e)
        {
            this.EmpIdTB.Text = EmpployeeDataTableGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.EmpNameTB.Text = EmpployeeDataTableGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.EmpAgeTB.Text = EmpployeeDataTableGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.EmpPhnNumberTB2.Text = (EmpployeeDataTableGridView.Rows[e.RowIndex].Cells[3].Value.ToString()).Substring(4);
            this.EmpSalaryTB.Text = EmpployeeDataTableGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.EmpDesignationTB.Text = EmpployeeDataTableGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            this.EmpAddressTB.Text = EmpployeeDataTableGridView.Rows[e.RowIndex].Cells[6].Value.ToString();


            this.refreshdataBtn.Enabled = true;
            this.loadBtn.Enabled = false;
            this.updateBtn.Enabled = true;
            this.deleteBtn.Enabled = true;
            this.insertBtn.Enabled = false;

            this.EmpIdTB.Enabled = false;
        }

        private void Load_Btn_Method(object sender, EventArgs e)
        {
            string empId = this.EmpIdTB.Text;
            Employee emp = er.GetEmployee(empId);

            if(emp == null)
            {
                this.Refresh_Btn_Click(sender, e);
            }
            else
            {
                this.EmpNameTB.Text = emp.EmpName;
                this.EmpAgeTB.Text = emp.EmpAge + "";
                this.EmpPhnNumberTB2.Text = emp.EmpPhoneNum.Substring(4);
                this.EmpSalaryTB.Text = emp.EmpSalary + "";
                this.EmpDesignationTB.Text = emp.EmpDesignation;
                this.EmpAddressTB.Text = emp.EmpAddress;

                this.insertBtn.Enabled = false;
                this.loadBtn.Enabled = false;
                this.updateBtn.Enabled = true;
                this.deleteBtn.Enabled = true;
                this.refreshdataBtn.Enabled = true;

                this.EmpIdTB.Enabled = false;
            }
        }

        private void CrossBack_Method(object sender, EventArgs e)
        {
            ManagerForm m = new ManagerForm(l);
            this.Visible = false;
            m.Visible = true;
        }
    }
}
