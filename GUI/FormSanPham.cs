using DevExpress.Charts.Sankey.Native;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class FormSanPham : Form
    {
        private const bool V = true;

        public FormSanPham()
        {
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            ThemMoi.Show(btnAddnew, 0, btnAddnew.Height);
        }


        //add a new row  
        //dgv.AddNewRow();  
        //set a new row cell value. The static GridControl.NewItemRowHandle field allows you to retrieve the added row  
        //gridView1.SetRowCellValue(GridControl.NewItemRowHandle, gridView1.Columns["Name"], "Please enter new value");  
private void dgvSanPham_Click(object sender, EventArgs e)
        {

        }

        private void gunaElipsePanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDFTime_Click(object sender, EventArgs e)
        {
            if(timePickerDf.Visible == true)
            {
                timePickerDf.Visible = false;
            }
            else
            {
                timePickerDf.Visible = true;
            }
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            Import.Show(btImport, 0, btImport.Height);
        }

        private void Search(string s)
        {
            /*
            Model1 context = new Model1();
            var listKHHD = context.KhachHangs.Where(p => p.HoatDong == 1).ToList();
            var listSeach = listKHHD.Where(x =>
                                    (x.MaKH.Trim().ToLower().Contains(textBox1.Text.Trim().ToLower()))
                                    || (x.TenKH.Trim().ToLower().Contains(textBox1.Text.Trim().ToLower()))
                                    || (x.DienThoai.Contains(textBox1.Text.Trim()))
                                    || (x.Email.Contains(textBox1.Text.Trim()))).ToList();
            */
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Find.Show(pnSearch, 0, pnSearch.Height);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }
    }
}
 