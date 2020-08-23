namespace AppForms
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CrossBtn = new System.Windows.Forms.Button();
            this.ManagerPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.EmpAddressPnl = new System.Windows.Forms.Label();
            this.EmpPhnNmPnl = new System.Windows.Forms.Label();
            this.EmpAgePnl = new System.Windows.Forms.Label();
            this.EmpNamePnl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.ProfilePicBox = new System.Windows.Forms.PictureBox();
            this.MdcnDataGridView = new System.Windows.Forms.DataGridView();
            this.ViewAllMdcnBtn = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.MdcnSearchBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.ManagerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MdcnDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.CrossBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1431, 46);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Move_Method);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Move_Method);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Move_Method);
            // 
            // CrossBtn
            // 
            this.CrossBtn.BackColor = System.Drawing.Color.Green;
            this.CrossBtn.FlatAppearance.BorderSize = 0;
            this.CrossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrossBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrossBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CrossBtn.Location = new System.Drawing.Point(1371, 0);
            this.CrossBtn.Name = "CrossBtn";
            this.CrossBtn.Size = new System.Drawing.Size(60, 46);
            this.CrossBtn.TabIndex = 1;
            this.CrossBtn.Text = "X";
            this.CrossBtn.UseVisualStyleBackColor = false;
            this.CrossBtn.Click += new System.EventHandler(this.CrossMethod_Event);
            // 
            // ManagerPanel
            // 
            this.ManagerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ManagerPanel.Controls.Add(this.logoutBtn);
            this.ManagerPanel.Controls.Add(this.label9);
            this.ManagerPanel.Controls.Add(this.EmpAddressPnl);
            this.ManagerPanel.Controls.Add(this.EmpPhnNmPnl);
            this.ManagerPanel.Controls.Add(this.EmpAgePnl);
            this.ManagerPanel.Controls.Add(this.EmpNamePnl);
            this.ManagerPanel.Controls.Add(this.label2);
            this.ManagerPanel.Controls.Add(this.label4);
            this.ManagerPanel.Controls.Add(this.label3);
            this.ManagerPanel.Controls.Add(this.label1);
            this.ManagerPanel.Controls.Add(this.namelbl);
            this.ManagerPanel.Controls.Add(this.ProfilePicBox);
            this.ManagerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ManagerPanel.Location = new System.Drawing.Point(0, 46);
            this.ManagerPanel.Name = "ManagerPanel";
            this.ManagerPanel.Size = new System.Drawing.Size(301, 583);
            this.ManagerPanel.TabIndex = 2;
            // 
            // logoutBtn
            // 
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.Green;
            this.logoutBtn.Location = new System.Drawing.Point(146, 127);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(87, 40);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.CrossMethod_Event);
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(20, 510);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 55);
            this.label9.TabIndex = 10;
            this.label9.Text = "Pharmacy Adress:  new Road, Gulshan, Dhaka © ";
            // 
            // EmpAddressPnl
            // 
            this.EmpAddressPnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpAddressPnl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmpAddressPnl.Location = new System.Drawing.Point(95, 336);
            this.EmpAddressPnl.Name = "EmpAddressPnl";
            this.EmpAddressPnl.Size = new System.Drawing.Size(203, 23);
            this.EmpAddressPnl.TabIndex = 9;
            this.EmpAddressPnl.Text = "Gulshan, Dhaka";
            // 
            // EmpPhnNmPnl
            // 
            this.EmpPhnNmPnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPhnNmPnl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmpPhnNmPnl.Location = new System.Drawing.Point(95, 290);
            this.EmpPhnNmPnl.Name = "EmpPhnNmPnl";
            this.EmpPhnNmPnl.Size = new System.Drawing.Size(203, 23);
            this.EmpPhnNmPnl.TabIndex = 8;
            this.EmpPhnNmPnl.Text = "0153336665";
            // 
            // EmpAgePnl
            // 
            this.EmpAgePnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpAgePnl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmpAgePnl.Location = new System.Drawing.Point(95, 244);
            this.EmpAgePnl.Name = "EmpAgePnl";
            this.EmpAgePnl.Size = new System.Drawing.Size(203, 23);
            this.EmpAgePnl.TabIndex = 7;
            this.EmpAgePnl.Text = "23";
            // 
            // EmpNamePnl
            // 
            this.EmpNamePnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNamePnl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmpNamePnl.Location = new System.Drawing.Point(95, 198);
            this.EmpNamePnl.Name = "EmpNamePnl";
            this.EmpNamePnl.Size = new System.Drawing.Size(203, 23);
            this.EmpNamePnl.TabIndex = 2;
            this.EmpNamePnl.Text = "Employee name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(20, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(20, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(20, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Age:";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.namelbl.Location = new System.Drawing.Point(20, 198);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(52, 18);
            this.namelbl.TabIndex = 2;
            this.namelbl.Text = "Name:";
            // 
            // ProfilePicBox
            // 
            this.ProfilePicBox.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePicBox.Image")));
            this.ProfilePicBox.Location = new System.Drawing.Point(23, 70);
            this.ProfilePicBox.Name = "ProfilePicBox";
            this.ProfilePicBox.Size = new System.Drawing.Size(105, 97);
            this.ProfilePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicBox.TabIndex = 2;
            this.ProfilePicBox.TabStop = false;
            // 
            // MdcnDataGridView
            // 
            this.MdcnDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MdcnDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MdcnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MdcnDataGridView.Location = new System.Drawing.Point(304, 52);
            this.MdcnDataGridView.Name = "MdcnDataGridView";
            this.MdcnDataGridView.RowHeadersWidth = 51;
            this.MdcnDataGridView.RowTemplate.Height = 24;
            this.MdcnDataGridView.Size = new System.Drawing.Size(1115, 495);
            this.MdcnDataGridView.TabIndex = 3;
            // 
            // ViewAllMdcnBtn
            // 
            this.ViewAllMdcnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewAllMdcnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllMdcnBtn.ForeColor = System.Drawing.Color.Green;
            this.ViewAllMdcnBtn.Location = new System.Drawing.Point(307, 590);
            this.ViewAllMdcnBtn.Name = "ViewAllMdcnBtn";
            this.ViewAllMdcnBtn.Size = new System.Drawing.Size(185, 29);
            this.ViewAllMdcnBtn.TabIndex = 38;
            this.ViewAllMdcnBtn.Text = "View All Medicine";
            this.ViewAllMdcnBtn.UseVisualStyleBackColor = true;
            this.ViewAllMdcnBtn.Click += new System.EventHandler(this.ViewMdcn_Method);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.ForeColor = System.Drawing.Color.Green;
            this.SearchLabel.Location = new System.Drawing.Point(308, 556);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(121, 17);
            this.SearchLabel.TabIndex = 37;
            this.SearchLabel.Text = "Search Medicine: ";
            // 
            // MdcnSearchBox
            // 
            this.MdcnSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.MdcnSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MdcnSearchBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MdcnSearchBox.Location = new System.Drawing.Point(434, 554);
            this.MdcnSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.MdcnSearchBox.Name = "MdcnSearchBox";
            this.MdcnSearchBox.Size = new System.Drawing.Size(439, 22);
            this.MdcnSearchBox.TabIndex = 36;
            this.MdcnSearchBox.TextChanged += new System.EventHandler(this.MdcnSearchBar_Method);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(521, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 29);
            this.button1.TabIndex = 39;
            this.button1.Text = "Sale Medicine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaleMdcnBtn);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1431, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewAllMdcnBtn);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.MdcnSearchBox);
            this.Controls.Add(this.MdcnDataGridView);
            this.Controls.Add(this.ManagerPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Move_Method);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Move_Method);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Move_Method);
            this.panel1.ResumeLayout(false);
            this.ManagerPanel.ResumeLayout(false);
            this.ManagerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MdcnDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CrossBtn;
        private System.Windows.Forms.Panel ManagerPanel;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label EmpAddressPnl;
        private System.Windows.Forms.Label EmpPhnNmPnl;
        private System.Windows.Forms.Label EmpAgePnl;
        private System.Windows.Forms.Label EmpNamePnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.PictureBox ProfilePicBox;
        private System.Windows.Forms.DataGridView MdcnDataGridView;
        private System.Windows.Forms.Button ViewAllMdcnBtn;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox MdcnSearchBox;
        private System.Windows.Forms.Button button1;
    }
}