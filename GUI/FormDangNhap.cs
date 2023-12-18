using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuanli_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormHome home = new FormHome();
                home.Closed += (s, args) => this.Close();
                home.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*
        private void btnBanhang_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormBanHang banhang = new FormBanHang();
                banhang.Closed += (s, args) => this.Close();
                banhang.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int i = 0;
        private void picEyes_Click(object sender, EventArgs e)
        {
            if(txtPass.PasswordChar == '●')
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '●';
            }
        }


        private void btnRecovery_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormKhoiPhucPass home = new FormKhoiPhucPass();
                home.Closed += (s, args) => this.Close();
                home.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBanhang_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormBanHang home = new FormBanHang();
                home.Closed += (s, args) => this.Close();
                home.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
