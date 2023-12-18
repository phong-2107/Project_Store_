using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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
    public partial class FormBanHang : DevExpress.XtraEditors.XtraForm
    {
        public FormBanHang()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu.Show(btnMenu, btnMenu.Location.X - 210, btnMenu.Height);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (FormThemKhachHang uu = new FormThemKhachHang())
                {
                    formBackground.StartPosition = FormStartPosition.CenterScreen;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Width = this.Width;
                    formBackground.Height = this.Height;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Normal;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    formBackground.Owner = uu;
                    uu.ShowDialog();

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

      
    }
}