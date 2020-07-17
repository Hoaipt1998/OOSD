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
    public partial class NhanVien : Form
    {
        BLnhanvien nv = new BLnhanvien();
        DataSet ds = null;
        public string err;
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            load();

        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNV.CurrentCell.RowIndex;
            tbID.Text = dgvNV.Rows[r].Cells[0].Value.ToString();
            tbTNV.Text = dgvNV.Rows[r].Cells[4].Value.ToString();
            tbDC.Text = dgvNV.Rows[r].Cells[5].Value.ToString();
            tbLTK.Text = dgvNV.Rows[r].Cells[3].Value.ToString();
            tbGT.Text = dgvNV.Rows[r].Cells[6].Value.ToString();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            tbID.Enabled = false;
            tbLTK.Enabled = false;
            tbDC.Enabled = false;
            tbGT.Enabled = false;
            tbTNV.Enabled = false;
            
            ds = new DataSet();
            ds.Clear();
            ds = nv.Laynhanvien();
            dgvNV.DataSource = ds.Tables[0];
            dgvNV.AutoResizeColumns();
        }

  
       
       
       
        private void buttonTiemKiemNV_Click(object sender, EventArgs e)
        {
            ds = nv.timnhanvien(tbTK.Text);
            dgvNV.DataSource = ds.Tables[0];
            dgvNV.AutoResizeColumns();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            tbID.Enabled = true;
            tbLTK.Enabled = true;
            tbDC.Enabled = true;
            tbGT.Enabled = true;
            tbTNV.Enabled = true;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn xóa nhân viên này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                bool h = nv.xoanhanvien(tbID.Text, ref err);
                if (h == false)
                {
                    MessageBox.Show("Bạn cần xóa những dữ liệu liên quan đến nhân viên này !!!");
                }
                load();
            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {

            nv.suanv(tbID.Text, tbLTK.Text, tbTNV.Text, tbDC.Text, tbGT.Text, ref err);
            load();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienChinh gd = new GiaoDienChinh();
            gd.ShowDialog();
            this.Close();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            load();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void eee_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
