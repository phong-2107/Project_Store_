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
    public partial class FormTongQuan : Form
    {
        public FormTongQuan()
        {
            InitializeComponent();
        }

        private void FormTongQuan_Load(object sender, EventArgs e)
        {

        }

        

       
        private void FormTongQuan_SizeChanged(object sender, EventArgs e)
        {
            if(this.Size.Width <= 1345)
            {
                lbBanLe.Visible = false;
                lbDoanhthu.Visible = false;
                lbTonkho.Visible = false;
                LbDonHang.Visible = false;
                PriceDT.Location = new Point(20, 56);
            }
            else
            {
                lbBanLe.Visible = true;
                lbDoanhthu.Visible = true;
                lbTonkho.Visible = true;
                LbDonHang.Visible = true;
                PriceDT.Location = new Point(40, 56);
            }
        }

        private void gunaVProgressBar3_Click(object sender, EventArgs e)
        {

        }
    }
}
