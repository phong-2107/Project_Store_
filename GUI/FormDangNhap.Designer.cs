namespace GUI
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.btnQuanli = new Guna.UI.WinForms.GunaButton();
            this.txtID = new Guna.UI.WinForms.GunaTextBox();
            this.btnBanhang = new Guna.UI.WinForms.GunaButton();
            this.txtPass = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecovery = new System.Windows.Forms.Label();
            this.CbRemember = new Guna.UI.WinForms.GunaCheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.pnError = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnEye = new Guna.UI.WinForms.GunaCircleButton();
            this.pnError.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuanli
            // 
            this.btnQuanli.AnimationHoverSpeed = 0.07F;
            this.btnQuanli.AnimationSpeed = 0.03F;
            this.btnQuanli.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanli.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.btnQuanli.BorderColor = System.Drawing.Color.Black;
            this.btnQuanli.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnQuanli.FocusedColor = System.Drawing.Color.Empty;
            this.btnQuanli.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanli.ForeColor = System.Drawing.Color.White;
            this.btnQuanli.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanli.Image")));
            this.btnQuanli.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnQuanli.ImageSize = new System.Drawing.Size(30, 30);
            this.btnQuanli.Location = new System.Drawing.Point(54, 300);
            this.btnQuanli.Name = "btnQuanli";
            this.btnQuanli.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(195)))));
            this.btnQuanli.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnQuanli.OnHoverForeColor = System.Drawing.Color.White;
            this.btnQuanli.OnHoverImage = null;
            this.btnQuanli.OnPressedColor = System.Drawing.Color.Black;
            this.btnQuanli.Radius = 3;
            this.btnQuanli.Size = new System.Drawing.Size(145, 50);
            this.btnQuanli.TabIndex = 6;
            this.btnQuanli.Text = "Quản lí";
            this.btnQuanli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnQuanli.Click += new System.EventHandler(this.btnQuanli_Click);
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
            this.txtID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtID.Location = new System.Drawing.Point(54, 129);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.Radius = 3;
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(296, 40);
            this.txtID.TabIndex = 9;
            // 
            // btnBanhang
            // 
            this.btnBanhang.AnimationHoverSpeed = 0.07F;
            this.btnBanhang.AnimationSpeed = 0.03F;
            this.btnBanhang.BackColor = System.Drawing.Color.Transparent;
            this.btnBanhang.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            this.btnBanhang.BorderColor = System.Drawing.Color.Black;
            this.btnBanhang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBanhang.FocusedColor = System.Drawing.Color.Empty;
            this.btnBanhang.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanhang.ForeColor = System.Drawing.Color.White;
            this.btnBanhang.Image = ((System.Drawing.Image)(resources.GetObject("btnBanhang.Image")));
            this.btnBanhang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBanhang.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBanhang.Location = new System.Drawing.Point(205, 300);
            this.btnBanhang.Name = "btnBanhang";
            this.btnBanhang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(50)))));
            this.btnBanhang.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnBanhang.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBanhang.OnHoverImage = null;
            this.btnBanhang.OnPressedColor = System.Drawing.Color.Black;
            this.btnBanhang.Radius = 3;
            this.btnBanhang.Size = new System.Drawing.Size(145, 50);
            this.btnBanhang.TabIndex = 7;
            this.btnBanhang.Text = "Bán hàng";
            this.btnBanhang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBanhang.Click += new System.EventHandler(this.btnBanhang_Click);
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
            this.txtPass.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPass.Location = new System.Drawing.Point(54, 207);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.Radius = 3;
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(296, 40);
            this.txtPass.TabIndex = 10;
            this.txtPass.Click += new System.EventHandler(this.txtPass_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(36)))), ((int)(((byte)(61)))));
            this.label6.Location = new System.Drawing.Point(49, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Log in now!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(36)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(64, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(36)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(62, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Password";
            // 
            // btnRecovery
            // 
            this.btnRecovery.AutoSize = true;
            this.btnRecovery.BackColor = System.Drawing.Color.Transparent;
            this.btnRecovery.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecovery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(36)))), ((int)(((byte)(61)))));
            this.btnRecovery.Location = new System.Drawing.Point(245, 187);
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.Size = new System.Drawing.Size(105, 16);
            this.btnRecovery.TabIndex = 18;
            this.btnRecovery.Text = "Forgot Password";
            this.btnRecovery.Click += new System.EventHandler(this.btnRecovery_Click);
            // 
            // CbRemember
            // 
            this.CbRemember.BaseColor = System.Drawing.Color.White;
            this.CbRemember.CheckedOffColor = System.Drawing.Color.Gray;
            this.CbRemember.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.CbRemember.FillColor = System.Drawing.Color.White;
            this.CbRemember.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbRemember.Location = new System.Drawing.Point(67, 258);
            this.CbRemember.Name = "CbRemember";
            this.CbRemember.Size = new System.Drawing.Size(141, 20);
            this.CbRemember.TabIndex = 19;
            this.CbRemember.Text = "Ghi nhớ tài khoản này";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(368, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 20;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.pnError.Location = new System.Drawing.Point(54, 70);
            this.pnError.Name = "pnError";
            this.pnError.Size = new System.Drawing.Size(296, 36);
            this.pnError.TabIndex = 21;
            // 
            // btnEye
            // 
            this.btnEye.AnimationHoverSpeed = 0.07F;
            this.btnEye.AnimationSpeed = 0.03F;
            this.btnEye.BackColor = System.Drawing.Color.Transparent;
            this.btnEye.BaseColor = System.Drawing.Color.Transparent;
            this.btnEye.BorderColor = System.Drawing.Color.Transparent;
            this.btnEye.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEye.FocusedColor = System.Drawing.Color.Empty;
            this.btnEye.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEye.ForeColor = System.Drawing.Color.White;
            this.btnEye.Image = ((System.Drawing.Image)(resources.GetObject("btnEye.Image")));
            this.btnEye.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEye.Location = new System.Drawing.Point(320, 217);
            this.btnEye.Name = "btnEye";
            this.btnEye.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnEye.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnEye.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btnEye.OnHoverImage = null;
            this.btnEye.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnEye.Size = new System.Drawing.Size(20, 20);
            this.btnEye.TabIndex = 22;
            this.btnEye.Click += new System.EventHandler(this.picEyes_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.btnEye);
            this.Controls.Add(this.pnError);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.CbRemember);
            this.Controls.Add(this.btnRecovery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnBanhang);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnQuanli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.pnError.ResumeLayout(false);
            this.pnError.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnQuanli;
        private Guna.UI.WinForms.GunaTextBox txtID;
        private Guna.UI.WinForms.GunaButton btnBanhang;
        private Guna.UI.WinForms.GunaTextBox txtPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btnRecovery;
        private Guna.UI.WinForms.GunaCheckBox CbRemember;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbError;
        private Guna.UI.WinForms.GunaElipsePanel pnError;
        private Guna.UI.WinForms.GunaCircleButton btnEye;
    }
}