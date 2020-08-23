namespace AppForms
{
    partial class ChangePassword
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
            this.CrossBtn = new System.Windows.Forms.Button();
            this.PrePaswrdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewPaswrdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmPaswrdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.CrossBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 46);
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
            this.CrossBtn.Location = new System.Drawing.Point(731, 0);
            this.CrossBtn.Name = "CrossBtn";
            this.CrossBtn.Size = new System.Drawing.Size(60, 46);
            this.CrossBtn.TabIndex = 0;
            this.CrossBtn.Text = "X";
            this.CrossBtn.UseVisualStyleBackColor = false;
            this.CrossBtn.Click += new System.EventHandler(this.CrossMethod_Event);
            // 
            // PrePaswrdTextBox
            // 
            this.PrePaswrdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.PrePaswrdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrePaswrdTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PrePaswrdTextBox.Location = new System.Drawing.Point(326, 130);
            this.PrePaswrdTextBox.Name = "PrePaswrdTextBox";
            this.PrePaswrdTextBox.Size = new System.Drawing.Size(206, 22);
            this.PrePaswrdTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(140, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Previous Password :";
            // 
            // NewPaswrdTextBox
            // 
            this.NewPaswrdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.NewPaswrdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewPaswrdTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NewPaswrdTextBox.Location = new System.Drawing.Point(326, 189);
            this.NewPaswrdTextBox.Name = "NewPaswrdTextBox";
            this.NewPaswrdTextBox.Size = new System.Drawing.Size(206, 22);
            this.NewPaswrdTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(140, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "New Password :";
            // 
            // ConfirmPaswrdTextBox
            // 
            this.ConfirmPaswrdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ConfirmPaswrdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmPaswrdTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ConfirmPaswrdTextBox.Location = new System.Drawing.Point(326, 258);
            this.ConfirmPaswrdTextBox.Name = "ConfirmPaswrdTextBox";
            this.ConfirmPaswrdTextBox.Size = new System.Drawing.Size(206, 22);
            this.ConfirmPaswrdTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(140, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Confirm Password :";
            // 
            // BtnSave
            // 
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.Green;
            this.BtnSave.Location = new System.Drawing.Point(326, 302);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(80, 27);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.Save_Password_Method);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.ConfirmPaswrdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewPaswrdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrePaswrdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.Opacity = 0.95D;
            this.Text = "ChangePassword";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Move_Method);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Move_Method);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Move_Method);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CrossBtn;
        private System.Windows.Forms.TextBox PrePaswrdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewPaswrdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ConfirmPaswrdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSave;
    }
}