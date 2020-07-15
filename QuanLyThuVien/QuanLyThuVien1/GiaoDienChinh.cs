using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien1
{
    public partial class GiaoDienChinh : Form
    {
        public static string mk;
        public static string tk;

        public GiaoDienChinh()
        {

        InitializeComponent();
        }
       
        private void GiaoDienChinh_Load(object sender, EventArgs e)
        {
            if(DangNhap.h==1)
            {
                taiKhoanToolStripMenuItem.Enabled=true;
                đôcGiaToolStripMenuItem.Enabled = true;
                kêSachToolStripMenuItem.Enabled = true;
                thôngKêToolStripMenuItem.Enabled = true;
                loaisachToolStripMenuItem.Enabled = true;
                nhânViênToolStripMenuItem.Enabled = true;
                phiêuMươnToolStripMenuItem.Enabled = true;
                sachToolStripMenuItem1.Enabled = true;
            }    
            else if(DangNhap.h==2)
            {
                taiKhoanToolStripMenuItem.Enabled = true;
                đôcGiaToolStripMenuItem.Enabled = true;
                kêSachToolStripMenuItem.Enabled = false;
                thôngKêToolStripMenuItem.Enabled = true;
                loaisachToolStripMenuItem.Enabled = false;
                nhânViênToolStripMenuItem.Enabled = false;
                phiêuMươnToolStripMenuItem.Enabled = true;
                sachToolStripMenuItem1.Enabled = true;
            }    
            else if(DangNhap.h==3)
            {
                taiKhoanToolStripMenuItem.Enabled = true;
                đôcGiaToolStripMenuItem.Enabled = false;
                kêSachToolStripMenuItem.Enabled = true;
                thôngKêToolStripMenuItem.Enabled = false;
                loaisachToolStripMenuItem.Enabled = true;
                nhânViênToolStripMenuItem.Enabled = false;
                phiêuMươnToolStripMenuItem.Enabled = false;
                sachToolStripMenuItem1.Enabled = true;
            }
        }

        private void btnLO_Click(object sender, EventArgs e)
        {
            
        }

        private void quanLySachToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loaisachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoaiSach s = new LoaiSach();
            s.ShowDialog();
            this.Close();
        }

        private void sachToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sach s = new Sach();
            s.ShowDialog();
            this.Close();
        }

        private void kêSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KeSach s = new KeSach();
            s.ShowDialog();
            this.Close();
        }

        private void đôcGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocGia s = new DocGia();
            s.ShowDialog();
            this.Close();
        }

        private void phiêuMươnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhieuMuon s = new PhieuMuon();
            s.ShowDialog();
            this.Close();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien s = new NhanVien();
            s.ShowDialog();
            this.Close();
        }

        private void thôngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKe s = new ThongKe();
            s.ShowDialog();
            this.Close();
        }

        private void taiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TaiKhoan s = new TaiKhoan();
            s.ShowDialog();
            this.Close();
        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap.h = 0;
            this.Hide();
            TrangChu gdc = new TrangChu();
            gdc.ShowDialog();
            this.Close();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
             this.Close();
        }
    }
}
