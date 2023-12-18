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
    public partial class FormKhoiPhucPass : Form
    {
        public FormKhoiPhucPass()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormKhoiPhucPass_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormDangNhap home = new FormDangNhap();
                home.Closed += (s, args) => this.Close();
                home.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormDangNhap home = new FormDangNhap();
                home.Closed += (s, args) => this.Close();
                home.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(pnAdd.Visible == false)
            {
                pnAdd.Visible = true;
            }
            else
            {
                pnAdd.Visible = true;
            }
        }
    }
}
