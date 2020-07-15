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
    public partial class DangNhap : Form
    {
        BLnhanvien nv = new BLnhanvien();
        public static int h=0;
        public static string m = "";
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu tc = new TrangChu();
            tc.ShowDialog();
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            GiaoDienChinh.mk = tbMK.Text;
            GiaoDienChinh.tk = tbTK.Text;
            h = nv.Dangnhap(tbTK.Text, tbMK.Text,ref m);
            if (h != 0)
            {
                GiaoDienChinh gdc = new GiaoDienChinh();

                gdc.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Đăng nhập thất thất BẠI");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
