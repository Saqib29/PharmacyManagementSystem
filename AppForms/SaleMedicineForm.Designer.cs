namespace AppForms
{
    partial class SaleMedicineForm
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
            this.allMdcnGridView = new System.Windows.Forms.DataGridView();
            this.AddtoCharGridDataView = new System.Windows.Forms.DataGridView();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.MdcnSearchBox = new System.Windows.Forms.TextBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.quantityTB = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allMdcnGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddtoCharGridDataView)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1399, 46);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Move_Method);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Move_Method);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Move_Method);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(641, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sale Medicine";
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
            this.backBtn.Size = new System.Drawing.Size(70, 46);
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
            this.CrossBtn.Location = new System.Drawing.Point(1339, 0);
            this.CrossBtn.Name = "CrossBtn";
            this.CrossBtn.Size = new System.Drawing.Size(60, 46);
            this.CrossBtn.TabIndex = 1;
            this.CrossBtn.Text = "X";
            this.CrossBtn.UseVisualStyleBackColor = false;
            this.CrossBtn.Click += new System.EventHandler(this.CrossBack_Method);
            // 
            // allMdcnGridView
            // 
            this.allMdcnGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.allMdcnGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allMdcnGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allMdcnGridView.Location = new System.Drawing.Point(12, 98);
            this.allMdcnGridView.Name = "allMdcnGridView";
            this.allMdcnGridView.RowHeadersWidth = 51;
            this.allMdcnGridView.RowTemplate.Height = 24;
            this.allMdcnGridView.Size = new System.Drawing.Size(689, 575);
            this.allMdcnGridView.TabIndex = 3;
            this.allMdcnGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_Data_Click_Method);
            // 
            // AddtoCharGridDataView
            // 
            this.AddtoCharGridDataView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddtoCharGridDataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddtoCharGridDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddtoCharGridDataView.Location = new System.Drawing.Point(707, 98);
            this.AddtoCharGridDataView.Name = "AddtoCharGridDataView";
            this.AddtoCharGridDataView.RowHeadersWidth = 51;
            this.AddtoCharGridDataView.RowTemplate.Height = 24;
            this.AddtoCharGridDataView.Size = new System.Drawing.Size(680, 575);
            this.AddtoCharGridDataView.TabIndex = 4;
            this.AddtoCharGridDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_Click_SoldTable_Method);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.ForeColor = System.Drawing.Color.Green;
            this.SearchLabel.Location = new System.Drawing.Point(24, 741);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(121, 17);
            this.SearchLabel.TabIndex = 42;
            this.SearchLabel.Text = "Search Medicine: ";
            // 
            // MdcnSearchBox
            // 
            this.MdcnSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.MdcnSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MdcnSearchBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MdcnSearchBox.Location = new System.Drawing.Point(150, 739);
            this.MdcnSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.MdcnSearchBox.Name = "MdcnSearchBox";
            this.MdcnSearchBox.Size = new System.Drawing.Size(412, 22);
            this.MdcnSearchBox.TabIndex = 41;
            this.MdcnSearchBox.TextChanged += new System.EventHandler(this.MdcnSearchedBox_Method);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.ForeColor = System.Drawing.Color.Green;
            this.BtnConfirm.Location = new System.Drawing.Point(707, 695);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(108, 29);
            this.BtnConfirm.TabIndex = 43;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.CnfrmForsale_Method);
            // 
            // logoutBtn
            // 
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.Green;
            this.logoutBtn.Location = new System.Drawing.Point(1312, 52);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 40);
            this.logoutBtn.TabIndex = 44;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.Logout_Method);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(24, 702);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Quantity   : ";
            // 
            // quantityTB
            // 
            this.quantityTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.quantityTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityTB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.quantityTB.Location = new System.Drawing.Point(150, 700);
            this.quantityTB.Margin = new System.Windows.Forms.Padding(4);
            this.quantityTB.Name = "quantityTB";
            this.quantityTB.Size = new System.Drawing.Size(148, 22);
            this.quantityTB.TabIndex = 47;
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Green;
            this.cancelBtn.Location = new System.Drawing.Point(834, 695);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(108, 29);
            this.cancelBtn.TabIndex = 49;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click_Method);
            // 
            // SaleMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1399, 790);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantityTB);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.MdcnSearchBox);
            this.Controls.Add(this.AddtoCharGridDataView);
            this.Controls.Add(this.allMdcnGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleMedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleMedicine";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Move_Method);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Move_Method);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Move_Method);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allMdcnGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddtoCharGridDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button CrossBtn;
        private System.Windows.Forms.DataGridView allMdcnGridView;
        private System.Windows.Forms.DataGridView AddtoCharGridDataView;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox MdcnSearchBox;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantityTB;
        private System.Windows.Forms.Button cancelBtn;
    }
}