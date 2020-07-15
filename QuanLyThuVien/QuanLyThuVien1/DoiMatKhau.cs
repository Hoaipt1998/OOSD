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
    public partial class DoiMatKhau : Form
    {
        BLnhanvien nv=new BLnhanvien();
        DataSet ds = null;
        string err;
        public DoiMatKhau()
        {
            InitializeComponent();
        }

       

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            TaiKhoan gd = new TaiKhoan();
            gd.ShowDialog();
            this.Close();
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            if (tbMK.Text != tbRMK.Text)
            {
                MessageBox.Show("Mật khẩu xác thực không khớp, vui lòng nhập lại!!!");
            }
            else
            {
                bool loi = nv.doimatkhau(tbMK.Text, DangNhap.m, ref err);
                if (loi)
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
                else MessageBox.Show("Đổi mật khẩu thất bại, xin hãy thử lại");
            }
        }
    }
}
