using DevExpress.XtraEditors;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
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
    public partial class FormHome : DevExpress.XtraEditors.XtraForm
    {
        

        #region Validation

        private Form activeForm = null;
        Button currentButton = new Button();
        GunaContextMenuStrip MenuTrip = new GunaContextMenuStrip();
        private Panel botttomBorder;
        #endregion

        #region Dữ liệu Home

        public FormHome()
        {
            InitializeComponent();
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            FormTongQuan demo = new FormTongQuan();
            openChildForm(demo);
        }

        #endregion

        #region Fuction xử lý hiệu ứng
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region Animation Button Taskbar


        // Button sản phẩm

        // Button Tài khoản
        private void btnAccount_Click(object sender, EventArgs e)
        {
            account.Show(btnAccount, -18, btnAccount.Height + 3);
        }


        // Button Cài đặt
        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            Settings.Show(btnCaiDat, btnCaiDat.Location.X - 200, btnCaiDat.Height + 3);
        }

        #endregion


        #region Animation Button Menutrip
        private void btnSanPhamItems_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSanPham());
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Đăng xuất","Bạn có muốn đăng xuất?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Hide();
                    FormDangNhap home = new FormDangNhap();
                    home.Closed += (s, args) => this.Close();
                    home.Show();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            FormTongQuan demo = new FormTongQuan();
            openChildForm(demo);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FormSanPham demo = new FormSanPham();
            openChildForm(demo);
        }

        #endregion


    }
}