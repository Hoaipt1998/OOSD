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
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }
        private void load()
        {
            tbTK.Text = GiaoDienChinh.tk;
            tbMK.Text = GiaoDienChinh.mk;
            tbTK.Enabled = false;
            tbMK.Enabled = false;
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            load();
        }

        private void buttonDoiMK_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMatKhau dk = new DoiMatKhau();
            dk.ShowDialog();
            this.Close();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienChinh gd = new GiaoDienChinh();
            gd.ShowDialog();
            this.Close();
        }
    }
}
