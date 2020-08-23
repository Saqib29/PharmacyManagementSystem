namespace AppForms
{
    partial class ManageEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CrossBtn = new System.Windows.Forms.Button();
            this.EmpployeeDataTableGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeDesignationLabel = new System.Windows.Forms.Label();
            this.EmpSalaryLabel = new System.Windows.Forms.Label();
            this.EmpPhnNumberLabel = new System.Windows.Forms.Label();
            this.EmpNameLabel = new System.Windows.Forms.Label();
            this.EmpIdLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpPhnNumberTB2 = new System.Windows.Forms.TextBox();
            this.EmpDesignationTB = new System.Windows.Forms.TextBox();
            this.EmpSalaryTB = new System.Windows.Forms.TextBox();
            this.EmpPhnNumberTB1 = new System.Windows.Forms.TextBox();
            this.EmpNameTB = new System.Windows.Forms.TextBox();
            this.EmpIdTB = new System.Windows.Forms.TextBox();
            this.EmpAddressTB = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.EmpSearchBox = new System.Windows.Forms.TextBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.ViewAllEmpBn = new System.Windows.Forms.Button();
            this.refreshdataBtn = new System.Windows.Forms.Button();
            this.EmpAgeTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpployeeDataTableGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CrossBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 46);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Move_Method);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Move_Method);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Move_Method);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Green;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(74, 46);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.CrossBack_Method);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(469, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manage Employee";
            // 
            // CrossBtn
            // 
            this.CrossBtn.BackColor = System.Drawing.Color.Green;
            this.CrossBtn.FlatAppearance.BorderSize = 0;
            this.CrossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrossBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrossBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CrossBtn.Location = new System.Drawing.Point(1134, 0);
            this.CrossBtn.Name = "CrossBtn";
            this.CrossBtn.Size = new System.Drawing.Size(60, 46);
            this.CrossBtn.TabIndex = 2;
            this.CrossBtn.Text = "X";
            this.CrossBtn.UseVisualStyleBackColor = false;
            this.CrossBtn.Click += new System.EventHandler(this.CrossBack_Method);
            // 
            // EmpployeeDataTableGridView
            // 
            this.EmpployeeDataTableGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmpployeeDataTableGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpployeeDataTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpployeeDataTableGridView.Location = new System.Drawing.Point(440, 96);
            this.EmpployeeDataTableGridView.Name = "EmpployeeDataTableGridView";
            this.EmpployeeDataTableGridView.RowHeadersWidth = 51;
            this.EmpployeeDataTableGridView.RowTemplate.Height = 24;
            this.EmpployeeDataTableGridView.Size = new System.Drawing.Size(755, 538);
            this.EmpployeeDataTableGridView.TabIndex = 1;
            this.EmpployeeDataTableGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpTableCellClick_Method);
            // 
            // EmployeeDesignationLabel
            // 
            this.EmployeeDesignationLabel.AutoSize = true;
            this.EmployeeDesignationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDesignationLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmployeeDesignationLabel.Location = new System.Drawing.Point(40, 365);
            this.EmployeeDesignationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeDesignationLabel.Name = "EmployeeDesignationLabel";
            this.EmployeeDesignationLabel.Size = new System.Drawing.Size(161, 17);
            this.EmployeeDesignationLabel.TabIndex = 9;
            this.EmployeeDesignationLabel.Text = "Employee Designation  :";
            // 
            // EmpSalaryLabel
            // 
            this.EmpSalaryLabel.AutoSize = true;
            this.EmpSalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpSalaryLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpSalaryLabel.Location = new System.Drawing.Point(40, 327);
            this.EmpSalaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpSalaryLabel.Name = "EmpSalaryLabel";
            this.EmpSalaryLabel.Size = new System.Drawing.Size(162, 17);
            this.EmpSalaryLabel.TabIndex = 8;
            this.EmpSalaryLabel.Text = "Employee Salary           :";
            // 
            // EmpPhnNumberLabel
            // 
            this.EmpPhnNumberLabel.AutoSize = true;
            this.EmpPhnNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPhnNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpPhnNumberLabel.Location = new System.Drawing.Point(40, 289);
            this.EmpPhnNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpPhnNumberLabel.Name = "EmpPhnNumberLabel";
            this.EmpPhnNumberLabel.Size = new System.Drawing.Size(165, 17);
            this.EmpPhnNumberLabel.TabIndex = 7;
            this.EmpPhnNumberLabel.Text = "Employee Phn Number : ";
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.AutoSize = true;
            this.EmpNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpNameLabel.Location = new System.Drawing.Point(40, 209);
            this.EmpNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(167, 17);
            this.EmpNameLabel.TabIndex = 6;
            this.EmpNameLabel.Text = "Employee Name            : ";
            // 
            // EmpIdLabel
            // 
            this.EmpIdLabel.AutoSize = true;
            this.EmpIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpIdLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpIdLabel.Location = new System.Drawing.Point(40, 171);
            this.EmpIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpIdLabel.Name = "EmpIdLabel";
            this.EmpIdLabel.Size = new System.Drawing.Size(167, 17);
            this.EmpIdLabel.TabIndex = 5;
            this.EmpIdLabel.Text = "Employee ID                  : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(40, 403);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Employee Address        :";
            // 
            // EmpPhnNumberTB2
            // 
            this.EmpPhnNumberTB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.EmpPhnNumberTB2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpPhnNumberTB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPhnNumberTB2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpPhnNumberTB2.Location = new System.Drawing.Point(290, 289);
            this.EmpPhnNumberTB2.Margin = new System.Windows.Forms.Padding(4);
            this.EmpPhnNumberTB2.Name = "EmpPhnNumberTB2";
            this.EmpPhnNumberTB2.Size = new System.Drawing.Size(139, 22);
            this.EmpPhnNumberTB2.TabIndex = 16;
            // 
            // EmpDesignationTB
            // 
            this.EmpDesignationTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.EmpDesignationTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpDesignationTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDesignationTB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpDesignationTB.Location = new System.Drawing.Point(236, 365);
            this.EmpDesignationTB.Margin = new System.Windows.Forms.Padding(4);
            this.EmpDesignationTB.Name = "EmpDesignationTB";
            this.EmpDesignationTB.Size = new System.Drawing.Size(193, 22);
            this.EmpDesignationTB.TabIndex = 15;
            // 
            // EmpSalaryTB
            // 
            this.EmpSalaryTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.EmpSalaryTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpSalaryTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpSalaryTB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpSalaryTB.Location = new System.Drawing.Point(236, 327);
            this.EmpSalaryTB.Margin = new System.Windows.Forms.Padding(4);
            this.EmpSalaryTB.Name = "EmpSalaryTB";
            this.EmpSalaryTB.Size = new System.Drawing.Size(193, 22);
            this.EmpSalaryTB.TabIndex = 14;
            // 
            // EmpPhnNumberTB1
            // 
            this.EmpPhnNumberTB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.EmpPhnNumberTB1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpPhnNumberTB1.Enabled = false;
            this.EmpPhnNumberTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPhnNumberTB1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpPhnNumberTB1.Location = new System.Drawing.Point(236, 289);
            this.EmpPhnNumberTB1.Margin = new System.Windows.Forms.Padding(4);
            this.EmpPhnNumberTB1.Name = "EmpPhnNumberTB1";
            this.EmpPhnNumberTB1.Size = new System.Drawing.Size(45, 22);
            this.EmpPhnNumberTB1.TabIndex = 13;
            this.EmpPhnNumberTB1.Text = "+880";
            // 
            // EmpNameTB
            // 
            this.EmpNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.EmpNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameTB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpNameTB.Location = new System.Drawing.Point(236, 209);
            this.EmpNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.EmpNameTB.Name = "EmpNameTB";
            this.EmpNameTB.Size = new System.Drawing.Size(193, 22);
            this.EmpNameTB.TabIndex = 12;
            // 
            // EmpIdTB
            // 
            this.EmpIdTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.EmpIdTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpIdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpIdTB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpIdTB.Location = new System.Drawing.Point(236, 171);
            this.EmpIdTB.Margin = new System.Windows.Forms.Padding(4);
            this.EmpIdTB.Name = "EmpIdTB";
            this.EmpIdTB.Size = new System.Drawing.Size(193, 22);
            this.EmpIdTB.TabIndex = 11;
            // 
            // EmpAddressTB
            // 
            this.EmpAddressTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.EmpAddressTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpAddressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpAddressTB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpAddressTB.Location = new System.Drawing.Point(236, 403);
            this.EmpAddressTB.Margin = new System.Windows.Forms.Padding(4);
            this.EmpAddressTB.Name = "EmpAddressTB";
            this.EmpAddressTB.Size = new System.Drawing.Size(193, 22);
            this.EmpAddressTB.TabIndex = 17;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.ForeColor = System.Drawing.Color.Green;
            this.SearchLabel.Location = new System.Drawing.Point(437, 640);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(131, 17);
            this.SearchLabel.TabIndex = 20;
            this.SearchLabel.Text = "Search Employee : ";
            // 
            // EmpSearchBox
            // 
            this.EmpSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.EmpSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpSearchBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpSearchBox.Location = new System.Drawing.Point(569, 638);
            this.EmpSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmpSearchBox.Name = "EmpSearchBox";
            this.EmpSearchBox.Size = new System.Drawing.Size(429, 22);
            this.EmpSearchBox.TabIndex = 19;
            this.EmpSearchBox.TextChanged += new System.EventHandler(this.SearchBar_Method);
            // 
            // loadBtn
            // 
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.ForeColor = System.Drawing.Color.Green;
            this.loadBtn.Location = new System.Drawing.Point(43, 538);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(85, 29);
            this.loadBtn.TabIndex = 25;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.Load_Btn_Method);
            // 
            // insertBtn
            // 
            this.insertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.ForeColor = System.Drawing.Color.Green;
            this.insertBtn.Location = new System.Drawing.Point(134, 538);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(85, 29);
            this.insertBtn.TabIndex = 26;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.InsertBtn_Method);
            // 
            // updateBtn
            // 
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.Green;
            this.updateBtn.Location = new System.Drawing.Point(225, 538);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(85, 29);
            this.updateBtn.TabIndex = 27;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.Update_Click_Method);
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Green;
            this.deleteBtn.Location = new System.Drawing.Point(316, 538);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(85, 29);
            this.deleteBtn.TabIndex = 28;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.Delete_Click_Method);
            // 
            // logoutBtn
            // 
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.Green;
            this.logoutBtn.Location = new System.Drawing.Point(1115, 53);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(80, 37);
            this.logoutBtn.TabIndex = 29;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logout_Btn_Click);
            // 
            // ViewAllEmpBn
            // 
            this.ViewAllEmpBn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewAllEmpBn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllEmpBn.ForeColor = System.Drawing.Color.Green;
            this.ViewAllEmpBn.Location = new System.Drawing.Point(285, 605);
            this.ViewAllEmpBn.Name = "ViewAllEmpBn";
            this.ViewAllEmpBn.Size = new System.Drawing.Size(149, 29);
            this.ViewAllEmpBn.TabIndex = 30;
            this.ViewAllEmpBn.Text = "View All Employee";
            this.ViewAllEmpBn.UseVisualStyleBackColor = true;
            this.ViewAllEmpBn.Click += new System.EventHandler(this.ViewAllEmployee_Method);
            // 
            // refreshdataBtn
            // 
            this.refreshdataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshdataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshdataBtn.ForeColor = System.Drawing.Color.Green;
            this.refreshdataBtn.Location = new System.Drawing.Point(43, 458);
            this.refreshdataBtn.Name = "refreshdataBtn";
            this.refreshdataBtn.Size = new System.Drawing.Size(149, 29);
            this.refreshdataBtn.TabIndex = 31;
            this.refreshdataBtn.Text = "Refresh Data";
            this.refreshdataBtn.UseVisualStyleBackColor = true;
            this.refreshdataBtn.Click += new System.EventHandler(this.Refresh_Btn_Click);
            // 
            // EmpAgeTB
            // 
            this.EmpAgeTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.EmpAgeTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpAgeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpAgeTB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpAgeTB.Location = new System.Drawing.Point(236, 249);
            this.EmpAgeTB.Margin = new System.Windows.Forms.Padding(4);
            this.EmpAgeTB.Name = "EmpAgeTB";
            this.EmpAgeTB.Size = new System.Drawing.Size(193, 22);
            this.EmpAgeTB.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(40, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Employee Age               : ";
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1199, 672);
            this.Controls.Add(this.EmpAgeTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.refreshdataBtn);
            this.Controls.Add(this.ViewAllEmpBn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.EmpSearchBox);
            this.Controls.Add(this.EmpAddressTB);
            this.Controls.Add(this.EmpPhnNumberTB2);
            this.Controls.Add(this.EmpDesignationTB);
            this.Controls.Add(this.EmpSalaryTB);
            this.Controls.Add(this.EmpPhnNumberTB1);
            this.Controls.Add(this.EmpNameTB);
            this.Controls.Add(this.EmpIdTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeDesignationLabel);
            this.Controls.Add(this.EmpSalaryLabel);
            this.Controls.Add(this.EmpPhnNumberLabel);
            this.Controls.Add(this.EmpNameLabel);
            this.Controls.Add(this.EmpIdLabel);
            this.Controls.Add(this.EmpployeeDataTableGridView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageEmployee";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Move_Method);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Move_Method);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Move_Method);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpployeeDataTableGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CrossBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView EmpployeeDataTableGridView;
        private System.Windows.Forms.Label EmployeeDesignationLabel;
        private System.Windows.Forms.Label EmpSalaryLabel;
        private System.Windows.Forms.Label EmpPhnNumberLabel;
        private System.Windows.Forms.Label EmpNameLabel;
        private System.Windows.Forms.Label EmpIdLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmpPhnNumberTB2;
        private System.Windows.Forms.TextBox EmpDesignationTB;
        private System.Windows.Forms.TextBox EmpSalaryTB;
        private System.Windows.Forms.TextBox EmpPhnNumberTB1;
        private System.Windows.Forms.TextBox EmpNameTB;
        private System.Windows.Forms.TextBox EmpIdTB;
        private System.Windows.Forms.TextBox EmpAddressTB;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox EmpSearchBox;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button ViewAllEmpBn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button refreshdataBtn;
        private System.Windows.Forms.TextBox EmpAgeTB;
        private System.Windows.Forms.Label label3;
    }
}