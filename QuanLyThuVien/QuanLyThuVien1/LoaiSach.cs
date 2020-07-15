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
    public partial class LoaiSach : Form
    {
        BLloaisach ls = new BLloaisach();
        DataSet ds = null;
        public string err;
        private bool them = false;
        private bool sua = false;
        public LoaiSach()
        {
            InitializeComponent();
        }

        private void LoaiSach_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            tbID.Enabled = false;
            tbTLS.Enabled = false;
            ds = new DataSet();
            ds=ls.Layloaisach();
            dgvLS.DataSource = ds.Tables[0];
       }

        private void dgvLS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvLS.CurrentCell.RowIndex;
            tbID.Text = dgvLS.Rows[r].Cells[0].Value.ToString();
            tbTLS.Text = dgvLS.Rows[r].Cells[1].Value.ToString();
        }

      

      
        private void buttonTiemKiem_Click(object sender, EventArgs e)
        {
            ds = ls.timkiem(tbTK.Text);
            dgvLS.DataSource = ds.Tables[0];
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            them = true;
            sua = false;
            tbTLS.Enabled = true;
            tbID.Enabled = true;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            sua = true;
            them = false;
            tbTLS.Enabled = true;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn xóa loại sách này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                bool h = ls.xoaloaisach(tbID.Text, ref err);
                if (h == false)
                {
                    MessageBox.Show("Bạn cần xóa những dữ liệu liên quan đến loại sách này !!!");
                }
                load();
            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                ls.themloaisach(tbID.Text, tbTLS.Text, ref err);
                them = false;
                load();
            }
            else if (sua)
            {
                ls.sualoaisach(tbID.Text, tbTLS.Text, ref err);
                sua = false;
                load();
            }
            tbID.Enabled = false;
            tbTLS.Enabled = false;
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
