namespace AppForms
{
    partial class ManageMedicine
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
            this.label2 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.CrossBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.MdcnSearchBox = new System.Windows.Forms.TextBox();
            this.MdcnDataTableGridView = new System.Windows.Forms.DataGridView();
            this.refreshdataBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.mdcnStckDateTB = new System.Windows.Forms.TextBox();
            this.mdcnExpDateTB = new System.Windows.Forms.TextBox();
            this.mdcnMnfctDateTB = new System.Windows.Forms.TextBox();
            this.mdcnNameTB = new System.Windows.Forms.TextBox();
            this.mdcnIdTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeDesignationLabel = new System.Windows.Forms.Label();
            this.EmpSalaryLabel = new System.Windows.Forms.Label();
            this.EmpNameLabel = new System.Windows.Forms.Label();
            this.EmpIdLabel = new System.Windows.Forms.Label();
            this.mdcnComTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mdcnqntityTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mdcnpriceTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MdcnDataTableGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.CrossBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1484, 46);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Move_Method);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Move_Method);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Move_Method);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(568, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Manage Medicine";
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
            this.backBtn.Size = new System.Drawing.Size(71, 46);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.CrossBack_Method);
            // 
            // CrossBtn
            // 
            this.CrossBtn.BackColor = System.Drawing.Color.Green;
            this.CrossBtn.FlatAppearance.BorderSize = 0;
            this.CrossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrossBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrossBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CrossBtn.Location = new System.Drawing.Point(1424, 0);
            this.CrossBtn.Name = "CrossBtn";
            this.CrossBtn.Size = new System.Drawing.Size(60, 46);
            this.CrossBtn.TabIndex = 1;
            this.CrossBtn.Text = "X";
            this.CrossBtn.UseVisualStyleBackColor = false;
            this.CrossBtn.Click += new System.EventHandler(this.CrossBack_Method);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(244, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 29);
            this.button1.TabIndex = 35;
            this.button1.Text = "View All Medicine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ViewMedicine_Method);
            // 
            // logoutBtn
            // 
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.Green;
            this.logoutBtn.Location = new System.Drawing.Point(1384, 52);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(88, 39);
            this.logoutBtn.TabIndex = 34;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.Logout_Btn_Click_Method);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.ForeColor = System.Drawing.Color.Green;
            this.SearchLabel.Location = new System.Drawing.Point(410, 690);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(121, 17);
            this.SearchLabel.TabIndex = 33;
            this.SearchLabel.Text = "Search Medicine: ";
            // 
            // MdcnSearchBox
            // 
            this.MdcnSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.MdcnSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MdcnSearchBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MdcnSearchBox.Location = new System.Drawing.Point(537, 689);
            this.MdcnSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.MdcnSearchBox.Name = "MdcnSearchBox";
            this.MdcnSearchBox.Size = new System.Drawing.Size(439, 22);
            this.MdcnSearchBox.TabIndex = 32;
            this.MdcnSearchBox.TextChanged += new System.EventHandler(this.SearchMedicine_Method);
            // 
            // MdcnDataTableGridView
            // 
            this.MdcnDataTableGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MdcnDataTableGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MdcnDataTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MdcnDataTableGridView.Location = new System.Drawing.Point(404, 97);
            this.MdcnDataTableGridView.Name = "MdcnDataTableGridView";
            this.MdcnDataTableGridView.RowHeadersWidth = 51;
            this.MdcnDataTableGridView.RowTemplate.Height = 24;
            this.MdcnDataTableGridView.Size = new System.Drawing.Size(1068, 585);
            this.MdcnDataTableGridView.TabIndex = 31;
            this.MdcnDataTableGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MdcnTableClick_Method);
            // 
            // refreshdataBtn
            // 
            this.refreshdataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshdataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshdataBtn.ForeColor = System.Drawing.Color.Green;
            this.refreshdataBtn.Location = new System.Drawing.Point(11, 447);
            this.refreshdataBtn.Name = "refreshdataBtn";
            this.refreshdataBtn.Size = new System.Drawing.Size(149, 29);
            this.refreshdataBtn.TabIndex = 53;
            this.refreshdataBtn.Text = "Refresh Data";
            this.refreshdataBtn.UseVisualStyleBackColor = true;
            this.refreshdataBtn.Click += new System.EventHandler(this.Refresh_Data_Method);
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Green;
            this.deleteBtn.Location = new System.Drawing.Point(308, 514);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(85, 29);
            this.deleteBtn.TabIndex = 52;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.Delete_Method);
            // 
            // updateBtn
            // 
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.Green;
            this.updateBtn.Location = new System.Drawing.Point(209, 514);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(85, 29);
            this.updateBtn.TabIndex = 51;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.Update_Method);
            // 
            // insertBtn
            // 
            this.insertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.ForeColor = System.Drawing.Color.Green;
            this.insertBtn.Location = new System.Drawing.Point(110, 514);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(85, 29);
            this.insertBtn.TabIndex = 50;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.Insert_Medicine_Method);
            // 
            // loadBtn
            // 
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.ForeColor = System.Drawing.Color.Green;
            this.loadBtn.Location = new System.Drawing.Point(11, 514);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(85, 29);
            this.loadBtn.TabIndex = 49;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            // 
            // mdcnStckDateTB
            // 
            this.mdcnStckDateTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.mdcnStckDateTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mdcnStckDateTB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mdcnStckDateTB.Location = new System.Drawing.Point(204, 322);
            this.mdcnStckDateTB.Margin = new System.Windows.Forms.Padding(4);
            this.mdcnStckDateTB.Name = "mdcnStckDateTB";
            this.mdcnStckDateTB.Size = new System.Drawing.Size(193, 22);
            this.mdcnStckDateTB.TabIndex = 48;
            // 
            // mdcnExpDateTB
            // 
            this.mdcnExpDateTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.mdcnExpDateTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mdcnExpDateTB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mdcnExpDateTB.Location = new System.Drawing.Point(204, 283);
            this.mdcnExpDateTB.Margin = new System.Windows.Forms.Padding(4);
            this.mdcnExpDateTB.Name = "mdcnExpDateTB";
            this.mdcnExpDateTB.Size = new System.Drawing.Size(193, 22);
            this.mdcnExpDateTB.TabIndex = 46;
            // 
            // mdcnMnfctDateTB
            // 
            this.mdcnMnfctDateTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.mdcnMnfctDateTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mdcnMnfctDateTB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mdcnMnfctDateTB.Location = new System.Drawing.Point(204, 244);
            this.mdcnMnfctDateTB.Margin = new System.Windows.Forms.Padding(4);
            this.mdcnMnfctDateTB.Name = "mdcnMnfctDateTB";
            this.mdcnMnfctDateTB.Size = new System.Drawing.Size(193, 22);
            this.mdcnMnfctDateTB.TabIndex = 45;
            // 
            // mdcnNameTB
            // 
            this.mdcnNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.mdcnNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mdcnNameTB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mdcnNameTB.Location = new System.Drawing.Point(204, 166);
            this.mdcnNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.mdcnNameTB.Name = "mdcnNameTB";
            this.mdcnNameTB.Size = new System.Drawing.Size(193, 22);
            this.mdcnNameTB.TabIndex = 43;
            // 
            // mdcnIdTB
            // 
            this.mdcnIdTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.mdcnIdTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mdcnIdTB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mdcnIdTB.Location = new System.Drawing.Point(204, 127);
            this.mdcnIdTB.Margin = new System.Windows.Forms.Padding(4);
            this.mdcnIdTB.Name = "mdcnIdTB";
            this.mdcnIdTB.Size = new System.Drawing.Size(193, 22);
            this.mdcnIdTB.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(8, 322);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Stock date                  :";
            // 
            // EmployeeDesignationLabel
            // 
            this.EmployeeDesignationLabel.AutoSize = true;
            this.EmployeeDesignationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDesignationLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmployeeDesignationLabel.Location = new System.Drawing.Point(8, 283);
            this.EmployeeDesignationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeDesignationLabel.Name = "EmployeeDesignationLabel";
            this.EmployeeDesignationLabel.Size = new System.Drawing.Size(153, 17);
            this.EmployeeDesignationLabel.TabIndex = 40;
            this.EmployeeDesignationLabel.Text = "Expired Date               :";
            // 
            // EmpSalaryLabel
            // 
            this.EmpSalaryLabel.AutoSize = true;
            this.EmpSalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpSalaryLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpSalaryLabel.Location = new System.Drawing.Point(8, 244);
            this.EmpSalaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpSalaryLabel.Name = "EmpSalaryLabel";
            this.EmpSalaryLabel.Size = new System.Drawing.Size(152, 17);
            this.EmpSalaryLabel.TabIndex = 39;
            this.EmpSalaryLabel.Text = "Manufacturing Date    :";
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.AutoSize = true;
            this.EmpNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpNameLabel.Location = new System.Drawing.Point(8, 166);
            this.EmpNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(157, 17);
            this.EmpNameLabel.TabIndex = 37;
            this.EmpNameLabel.Text = "Medicine Name           : ";
            // 
            // EmpIdLabel
            // 
            this.EmpIdLabel.AutoSize = true;
            this.EmpIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpIdLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpIdLabel.Location = new System.Drawing.Point(8, 127);
            this.EmpIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpIdLabel.Name = "EmpIdLabel";
            this.EmpIdLabel.Size = new System.Drawing.Size(157, 17);
            this.EmpIdLabel.TabIndex = 36;
            this.EmpIdLabel.Text = "Medicine ID                 : ";
            // 
            // mdcnComTB
            // 
            this.mdcnComTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.mdcnComTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mdcnComTB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mdcnComTB.Location = new System.Drawing.Point(204, 205);
            this.mdcnComTB.Margin = new System.Windows.Forms.Padding(4);
            this.mdcnComTB.Name = "mdcnComTB";
            this.mdcnComTB.Size = new System.Drawing.Size(193, 22);
            this.mdcnComTB.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(8, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Company Name          : ";
            // 
            // mdcnqntityTB
            // 
            this.mdcnqntityTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.mdcnqntityTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mdcnqntityTB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mdcnqntityTB.Location = new System.Drawing.Point(204, 361);
            this.mdcnqntityTB.Margin = new System.Windows.Forms.Padding(4);
            this.mdcnqntityTB.Name = "mdcnqntityTB";
            this.mdcnqntityTB.Size = new System.Drawing.Size(193, 22);
            this.mdcnqntityTB.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(8, 361);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Quantity                     :";
            // 
            // mdcnpriceTB
            // 
            this.mdcnpriceTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.mdcnpriceTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mdcnpriceTB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mdcnpriceTB.Location = new System.Drawing.Point(204, 400);
            this.mdcnpriceTB.Margin = new System.Windows.Forms.Padding(4);
            this.mdcnpriceTB.Name = "mdcnpriceTB";
            this.mdcnpriceTB.Size = new System.Drawing.Size(193, 22);
            this.mdcnpriceTB.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(8, 400);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Price                          :";
            // 
            // ManageMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1484, 727);
            this.Controls.Add(this.mdcnpriceTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mdcnqntityTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mdcnComTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.refreshdataBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.mdcnStckDateTB);
            this.Controls.Add(this.mdcnExpDateTB);
            this.Controls.Add(this.mdcnMnfctDateTB);
            this.Controls.Add(this.mdcnNameTB);
            this.Controls.Add(this.mdcnIdTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeDesignationLabel);
            this.Controls.Add(this.EmpSalaryLabel);
            this.Controls.Add(this.EmpNameLabel);
            this.Controls.Add(this.EmpIdLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.MdcnSearchBox);
            this.Controls.Add(this.MdcnDataTableGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageMedicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProduct";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Move_Method);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Move_Method);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Move_Method);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MdcnDataTableGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CrossBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox MdcnSearchBox;
        private System.Windows.Forms.DataGridView MdcnDataTableGridView;
        private System.Windows.Forms.Button refreshdataBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.TextBox mdcnStckDateTB;
        private System.Windows.Forms.TextBox mdcnExpDateTB;
        private System.Windows.Forms.TextBox mdcnMnfctDateTB;
        private System.Windows.Forms.TextBox mdcnNameTB;
        private System.Windows.Forms.TextBox mdcnIdTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EmployeeDesignationLabel;
        private System.Windows.Forms.Label EmpSalaryLabel;
        private System.Windows.Forms.Label EmpNameLabel;
        private System.Windows.Forms.Label EmpIdLabel;
        private System.Windows.Forms.TextBox mdcnComTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mdcnqntityTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mdcnpriceTB;
        private System.Windows.Forms.Label label5;
    }
}