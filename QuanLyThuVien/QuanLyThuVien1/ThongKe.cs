using QuanLyThuVien1.BS_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien1
{
    public partial class ThongKe : Form
    {
        BLphieumuon pm = new BLphieumuon();
        DataSet ds = null;
        public ThongKe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            DateTime dau = dtp1.Value;
            DateTime sau = dtp2.Value;
            string a = dau.ToString("yyyy-MM-dd");
            string b = sau.ToString("yyyy-MM-dd");
            ds = pm.thongke(a, b);
            dgvTK.DataSource = ds.Tables[0];
        }

        private void buttonTroLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienChinh gd = new GiaoDienChinh();
            this.Close();
            gd.ShowDialog();
        }
    }
}
