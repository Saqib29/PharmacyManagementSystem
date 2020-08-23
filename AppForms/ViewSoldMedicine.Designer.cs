namespace AppForms
{
    partial class ViewSoldMedicine
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
            this.ViewSoldMdcndataGridView = new System.Windows.Forms.DataGridView();
            this.BtnViewSoldMdcn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSoldMdcndataGridView)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1185, 46);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Move_Method);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Move_Method);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Move_Method);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(504, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "View Report";
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
            this.backBtn.Size = new System.Drawing.Size(75, 46);
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
            this.CrossBtn.Location = new System.Drawing.Point(1125, 0);
            this.CrossBtn.Name = "CrossBtn";
            this.CrossBtn.Size = new System.Drawing.Size(60, 46);
            this.CrossBtn.TabIndex = 1;
            this.CrossBtn.Text = "X";
            this.CrossBtn.UseVisualStyleBackColor = false;
            this.CrossBtn.Click += new System.EventHandler(this.CrossBack_Method);
            // 
            // ViewSoldMdcndataGridView
            // 
            this.ViewSoldMdcndataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ViewSoldMdcndataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewSoldMdcndataGridView.Location = new System.Drawing.Point(83, 65);
            this.ViewSoldMdcndataGridView.Name = "ViewSoldMdcndataGridView";
            this.ViewSoldMdcndataGridView.RowHeadersWidth = 51;
            this.ViewSoldMdcndataGridView.RowTemplate.Height = 24;
            this.ViewSoldMdcndataGridView.Size = new System.Drawing.Size(1048, 437);
            this.ViewSoldMdcndataGridView.TabIndex = 4;
            // 
            // BtnViewSoldMdcn
            // 
            this.BtnViewSoldMdcn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewSoldMdcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewSoldMdcn.ForeColor = System.Drawing.Color.Green;
            this.BtnViewSoldMdcn.Location = new System.Drawing.Point(83, 508);
            this.BtnViewSoldMdcn.Name = "BtnViewSoldMdcn";
            this.BtnViewSoldMdcn.Size = new System.Drawing.Size(193, 29);
            this.BtnViewSoldMdcn.TabIndex = 36;
            this.BtnViewSoldMdcn.Text = "View Sold Medicine";
            this.BtnViewSoldMdcn.UseVisualStyleBackColor = true;
            this.BtnViewSoldMdcn.Click += new System.EventHandler(this.ViewSoldMedicine_Method);
            // 
            // ViewSoldMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1185, 558);
            this.Controls.Add(this.BtnViewSoldMdcn);
            this.Controls.Add(this.ViewSoldMdcndataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewSoldMedicine";
            this.Opacity = 0.95D;
            this.Text = "ViewReport";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Move_Method);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Move_Method);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Move_Method);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSoldMdcndataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button CrossBtn;
        private System.Windows.Forms.DataGridView ViewSoldMdcndataGridView;
        private System.Windows.Forms.Button BtnViewSoldMdcn;
    }
}