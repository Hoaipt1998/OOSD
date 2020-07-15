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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát chương trình?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form dn = new DangNhap();
            dn.ShowDialog();
            this.Close();
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            Form nq = new NoiQuy();
            nq.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form tk = new TimKiem();
            tk.ShowDialog();
        }
    }
}
