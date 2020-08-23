namespace AppForms
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CrossBtn = new System.Windows.Forms.Button();
            this.ManagerPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.MngrAddressPnl = new System.Windows.Forms.Label();
            this.MngrPhnNmPnl = new System.Windows.Forms.Label();
            this.MngrAgePnl = new System.Windows.Forms.Label();
            this.MngrNamePnl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.ProfilePicBox = new System.Windows.Forms.PictureBox();
            this.BtnMngEmployee = new System.Windows.Forms.Button();
            this.BtnMngMedicine = new System.Windows.Forms.Button();
            this.BtnViewSoldMdcn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.ManagerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.CrossBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 46);
            this.panel1.TabIndex = 0;
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
            this.CrossBtn.Location = new System.Drawing.Point(1125, 0);
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
            this.ManagerPanel.Controls.Add(this.MngrAddressPnl);
            this.ManagerPanel.Controls.Add(this.MngrPhnNmPnl);
            this.ManagerPanel.Controls.Add(this.MngrAgePnl);
            this.ManagerPanel.Controls.Add(this.MngrNamePnl);
            this.ManagerPanel.Controls.Add(this.label2);
            this.ManagerPanel.Controls.Add(this.label4);
            this.ManagerPanel.Controls.Add(this.label3);
            this.ManagerPanel.Controls.Add(this.label1);
            this.ManagerPanel.Controls.Add(this.namelbl);
            this.ManagerPanel.Controls.Add(this.ProfilePicBox);
            this.ManagerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ManagerPanel.Location = new System.Drawing.Point(0, 46);
            this.ManagerPanel.Name = "ManagerPanel";
            this.ManagerPanel.Size = new System.Drawing.Size(301, 512);
            this.ManagerPanel.TabIndex = 1;
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
            this.label9.Location = new System.Drawing.Point(30, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 55);
            this.label9.TabIndex = 10;
            this.label9.Text = "Pharmacy Adress:  new Road, Gulshan, Dhaka © ";
            // 
            // MngrAddressPnl
            // 
            this.MngrAddressPnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngrAddressPnl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MngrAddressPnl.Location = new System.Drawing.Point(95, 336);
            this.MngrAddressPnl.Name = "MngrAddressPnl";
            this.MngrAddressPnl.Size = new System.Drawing.Size(203, 23);
            this.MngrAddressPnl.TabIndex = 9;
            // 
            // MngrPhnNmPnl
            // 
            this.MngrPhnNmPnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngrPhnNmPnl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MngrPhnNmPnl.Location = new System.Drawing.Point(95, 290);
            this.MngrPhnNmPnl.Name = "MngrPhnNmPnl";
            this.MngrPhnNmPnl.Size = new System.Drawing.Size(203, 23);
            this.MngrPhnNmPnl.TabIndex = 8;
            // 
            // MngrAgePnl
            // 
            this.MngrAgePnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngrAgePnl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MngrAgePnl.Location = new System.Drawing.Point(95, 244);
            this.MngrAgePnl.Name = "MngrAgePnl";
            this.MngrAgePnl.Size = new System.Drawing.Size(203, 23);
            this.MngrAgePnl.TabIndex = 7;
            // 
            // MngrNamePnl
            // 
            this.MngrNamePnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MngrNamePnl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MngrNamePnl.Location = new System.Drawing.Point(95, 198);
            this.MngrNamePnl.Name = "MngrNamePnl";
            this.MngrNamePnl.Size = new System.Drawing.Size(203, 23);
            this.MngrNamePnl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manager";
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
            // BtnMngEmployee
            // 
            this.BtnMngEmployee.BackColor = System.Drawing.Color.Green;
            this.BtnMngEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnMngEmployee.FlatAppearance.BorderSize = 0;
            this.BtnMngEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMngEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMngEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BtnMngEmployee.Location = new System.Drawing.Point(406, 215);
            this.BtnMngEmployee.Name = "BtnMngEmployee";
            this.BtnMngEmployee.Size = new System.Drawing.Size(190, 93);
            this.BtnMngEmployee.TabIndex = 11;
            this.BtnMngEmployee.Text = "Mange Employee";
            this.BtnMngEmployee.UseVisualStyleBackColor = false;
            this.BtnMngEmployee.Click += new System.EventHandler(this.ManageEmpBtnMethod);
            // 
            // BtnMngMedicine
            // 
            this.BtnMngMedicine.BackColor = System.Drawing.Color.Green;
            this.BtnMngMedicine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnMngMedicine.FlatAppearance.BorderSize = 0;
            this.BtnMngMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMngMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMngMedicine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BtnMngMedicine.Location = new System.Drawing.Point(621, 215);
            this.BtnMngMedicine.Name = "BtnMngMedicine";
            this.BtnMngMedicine.Size = new System.Drawing.Size(190, 93);
            this.BtnMngMedicine.TabIndex = 12;
            this.BtnMngMedicine.Text = "Manage Medicine";
            this.BtnMngMedicine.UseVisualStyleBackColor = false;
            this.BtnMngMedicine.Click += new System.EventHandler(this.ManageMdcnBtn);
            // 
            // BtnViewSoldMdcn
            // 
            this.BtnViewSoldMdcn.BackColor = System.Drawing.Color.Green;
            this.BtnViewSoldMdcn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnViewSoldMdcn.FlatAppearance.BorderSize = 0;
            this.BtnViewSoldMdcn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewSoldMdcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewSoldMdcn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BtnViewSoldMdcn.Location = new System.Drawing.Point(406, 336);
            this.BtnViewSoldMdcn.Name = "BtnViewSoldMdcn";
            this.BtnViewSoldMdcn.Size = new System.Drawing.Size(405, 54);
            this.BtnViewSoldMdcn.TabIndex = 14;
            this.BtnViewSoldMdcn.Text = "View Sold Medicine";
            this.BtnViewSoldMdcn.UseVisualStyleBackColor = false;
            this.BtnViewSoldMdcn.Click += new System.EventHandler(this.ViewSoldMdcnMethod);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Green;
            this.button4.Location = new System.Drawing.Point(998, 510);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 28);
            this.button4.TabIndex = 11;
            this.button4.Text = "Change Password";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.CnagePassMethod);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1185, 558);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnViewSoldMdcn);
            this.Controls.Add(this.BtnMngMedicine);
            this.Controls.Add(this.BtnMngEmployee);
            this.Controls.Add(this.ManagerPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Move_Method);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Move_Method);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Move_Method);
            this.panel1.ResumeLayout(false);
            this.ManagerPanel.ResumeLayout(false);
            this.ManagerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CrossBtn;
        private System.Windows.Forms.Panel ManagerPanel;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.PictureBox ProfilePicBox;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label MngrAddressPnl;
        private System.Windows.Forms.Label MngrPhnNmPnl;
        private System.Windows.Forms.Label MngrAgePnl;
        private System.Windows.Forms.Label MngrNamePnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMngEmployee;
        private System.Windows.Forms.Button BtnMngMedicine;
        private System.Windows.Forms.Button BtnViewSoldMdcn;
        private System.Windows.Forms.Button button4;
    }
}