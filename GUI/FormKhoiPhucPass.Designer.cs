namespace GUI
{
    partial class FormKhoiPhucPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhoiPhucPass));
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new Guna.UI.WinForms.GunaTextBox();
            this.btnSend = new Guna.UI.WinForms.GunaButton();
            this.lbError = new System.Windows.Forms.Label();
            this.pnError = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnAdd = new Guna.UI.WinForms.GunaPanel();
            this.btnRecovery = new Guna.UI.WinForms.GunaButton();
            this.CbRemember = new Guna.UI.WinForms.GunaCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picEyes = new Guna.UI.WinForms.GunaPictureBox();
            this.txtPass = new Guna.UI.WinForms.GunaTextBox();
            this.pnError.SuspendLayout();
            this.pnAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEyes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(340, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 32;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(36)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(45, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Phone or email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(36)))), ((int)(((byte)(61)))));
            this.label6.Location = new System.Drawing.Point(30, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "Password recovery";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Transparent;
            this.txtID.BaseColor = System.Drawing.Color.White;
            this.txtID.BorderColor = System.Drawing.Color.Silver;
            this.txtID.BorderSize = 1;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.FocusedBaseColor = System.Drawing.SystemColors.Window;
            this.txtID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(120)))), ((int)(((byte)(254)))));
            this.txtID.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtID.Location = new System.Drawing.Point(35, 151);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.Radius = 3;
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(226, 35);
            this.txtID.TabIndex = 24;
            // 
            // btnSend
            // 
            this.btnSend.AnimationHoverSpeed = 0.07F;
            this.btnSend.AnimationSpeed = 0.03F;
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnSend.BorderColor = System.Drawing.Color.Black;
            this.btnSend.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSend.FocusedColor = System.Drawing.Color.Empty;
            this.btnSend.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Image = null;
            this.btnSend.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSend.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSend.Location = new System.Drawing.Point(267, 151);
            this.btnSend.Name = "btnSend";
            this.btnSend.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(195)))));
            this.btnSend.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSend.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSend.OnHoverImage = null;
            this.btnSend.OnPressedColor = System.Drawing.Color.Black;
            this.btnSend.Radius = 3;
            this.btnSend.Size = new System.Drawing.Size(64, 35);
            this.btnSend.TabIndex = 22;
            this.btnSend.Text = "Send";
            this.btnSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.BackColor = System.Drawing.Color.Transparent;
            this.lbError.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(36)))), ((int)(((byte)(61)))));
            this.lbError.Location = new System.Drawing.Point(10, 10);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 16);
            this.lbError.TabIndex = 22;
            // 
            // pnError
            // 
            this.pnError.BackColor = System.Drawing.Color.Transparent;
            this.pnError.BaseColor = System.Drawing.Color.White;
            this.pnError.Controls.Add(this.lbError);
            this.pnError.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnError.Location = new System.Drawing.Point(35, 92);
            this.pnError.Name = "pnError";
            this.pnError.Size = new System.Drawing.Size(296, 36);
            this.pnError.TabIndex = 33;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(20, 20);
            this.btnReturn.TabIndex = 35;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnAdd
            // 
            this.pnAdd.Controls.Add(this.btnRecovery);
            this.pnAdd.Controls.Add(this.CbRemember);
            this.pnAdd.Controls.Add(this.label4);
            this.pnAdd.Controls.Add(this.label2);
            this.pnAdd.Controls.Add(this.picEyes);
            this.pnAdd.Controls.Add(this.txtPass);
            this.pnAdd.Location = new System.Drawing.Point(0, 192);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(370, 129);
            this.pnAdd.TabIndex = 36;
            this.pnAdd.Visible = false;
            // 
            // btnRecovery
            // 
            this.btnRecovery.AnimationHoverSpeed = 0.07F;
            this.btnRecovery.AnimationSpeed = 0.03F;
            this.btnRecovery.BackColor = System.Drawing.Color.Transparent;
            this.btnRecovery.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnRecovery.BorderColor = System.Drawing.Color.Black;
            this.btnRecovery.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRecovery.FocusedColor = System.Drawing.Color.Empty;
            this.btnRecovery.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecovery.ForeColor = System.Drawing.Color.White;
            this.btnRecovery.Image = null;
            this.btnRecovery.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRecovery.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRecovery.Location = new System.Drawing.Point(46, 90);
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(195)))));
            this.btnRecovery.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnRecovery.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRecovery.OnHoverImage = null;
            this.btnRecovery.OnPressedColor = System.Drawing.Color.Black;
            this.btnRecovery.Radius = 3;
            this.btnRecovery.Size = new System.Drawing.Size(276, 35);
            this.btnRecovery.TabIndex = 40;
            this.btnRecovery.Text = "Recovery";
            this.btnRecovery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CbRemember
            // 
            this.CbRemember.BaseColor = System.Drawing.Color.White;
            this.CbRemember.CheckedOffColor = System.Drawing.Color.Gray;
            this.CbRemember.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.CbRemember.FillColor = System.Drawing.Color.White;
            this.CbRemember.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRemember.Location = new System.Drawing.Point(35, 64);
            this.CbRemember.Name = "CbRemember";
            this.CbRemember.Size = new System.Drawing.Size(141, 20);
            this.CbRemember.TabIndex = 39;
            this.CbRemember.Text = "Ghi nhớ tài khoản này";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(36)))), ((int)(((byte)(61)))));
            this.label4.Location = new System.Drawing.Point(226, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(36)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(43, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "New password";
            // 
            // picEyes
            // 
            this.picEyes.BackColor = System.Drawing.Color.Transparent;
            this.picEyes.BaseColor = System.Drawing.Color.Transparent;
            this.picEyes.Image = ((System.Drawing.Image)(resources.GetObject("picEyes.Image")));
            this.picEyes.Location = new System.Drawing.Point(302, 30);
            this.picEyes.Name = "picEyes";
            this.picEyes.Size = new System.Drawing.Size(20, 20);
            this.picEyes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEyes.TabIndex = 36;
            this.picEyes.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.BaseColor = System.Drawing.Color.White;
            this.txtPass.BorderColor = System.Drawing.Color.Silver;
            this.txtPass.BorderSize = 1;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.FocusedBaseColor = System.Drawing.SystemColors.Window;
            this.txtPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(120)))), ((int)(((byte)(254)))));
            this.txtPass.FocusedForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPass.Location = new System.Drawing.Point(35, 23);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.Radius = 3;
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(296, 35);
            this.txtPass.TabIndex = 35;
            // 
            // FormKhoiPhucPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 350);
            this.Controls.Add(this.pnAdd);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.pnError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKhoiPhucPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKhoiPhucPass";
            this.Load += new System.EventHandler(this.FormKhoiPhucPass_Load);
            this.pnError.ResumeLayout(false);
            this.pnError.PerformLayout();
            this.pnAdd.ResumeLayout(false);
            this.pnAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEyes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox txtID;
        private Guna.UI.WinForms.GunaButton btnSend;
        private System.Windows.Forms.Label lbError;
        private Guna.UI.WinForms.GunaElipsePanel pnError;
        private System.Windows.Forms.Button btnReturn;
        private Guna.UI.WinForms.GunaPanel pnAdd;
        private Guna.UI.WinForms.GunaButton btnRecovery;
        private Guna.UI.WinForms.GunaCheckBox CbRemember;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaPictureBox picEyes;
        private Guna.UI.WinForms.GunaTextBox txtPass;
    }
}