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
    public partial class Sach : Form
    {
        string err = "";
        DataSet ds = null;
        DataTable dt = null;
        BLsach s = new BLsach();
        BLloaisach ls = new BLloaisach();
        BLke ke = new BLke();
        private bool them = false;
        private bool sua = false;
        public Sach()
        {
            InitializeComponent();
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            
           
            load();
        }
        private void load()
        {
            if(DangNhap.h==2)
            {
                buttonSua.Enabled = false;
                buttonXoa.Enabled = false;
                buttonThem.Enabled = false;
                Luu.Enabled = false;
            }
            tbID.Enabled = false;
            tbTS.Enabled = false;
            comboBoxLoaiSach.Enabled = false;
            tbSL.Enabled = false;
            comboBoxKeSach.Enabled = false;
            ds = s.Laysach();
            dgvS.DataSource = ds.Tables[0];
            dgvS.AutoResizeColumns();
            comboBoxLoaiSach.DataSource = ls.Layloaisach().Tables[0];
            comboBoxLoaiSach.DisplayMember = "maloaisach";
            comboBoxLoaiSach.ValueMember = "maloaisach";
            comboBoxLoaiSach.SelectedItem = null;

            comboBoxKeSach.DataSource = ke.Layke().Tables[0];
            comboBoxKeSach.DisplayMember = "make";
            comboBoxKeSach.ValueMember = "make";
            comboBoxKeSach.SelectedItem = null;
        }

        private void dgvS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvS.CurrentCell.RowIndex;
            tbID.Text = dgvS.Rows[r].Cells[0].Value.ToString();
            tbTS.Text = dgvS.Rows[r].Cells[1].Value.ToString();
            comboBoxLoaiSach.Text = dgvS.Rows[r].Cells[2].Value.ToString();
            tbSL.Text = dgvS.Rows[r].Cells[3].Value.ToString();
            comboBoxKeSach.Text = dgvS.Rows[r].Cells[4].Value.ToString();
        }

     

        private void buttonThem_Click(object sender, EventArgs e)
        {
            them = true;
            sua = false;
            tbID.Enabled = true;
            tbTS.Enabled = true;
            comboBoxLoaiSach.Enabled = true;
            tbSL.Enabled = true;
            comboBoxKeSach.Enabled = true;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            sua = true;
            them = false;
            tbTS.Enabled = true;
            comboBoxLoaiSach.Enabled = true;
            tbSL.Enabled = true;
            comboBoxKeSach.Enabled = true;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn xóa sách này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                bool h = s.xoasach(tbID.Text, ref err);
                if (h == false)
                {
                    MessageBox.Show("Bạn cần xóa những dữ liệu liên quan đến sách này !!!");
                }
                load();
            }
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                s.themsach(tbID.Text, tbTS.Text, comboBoxLoaiSach.Text, Convert.ToInt32(tbSL.Text), comboBoxKeSach.Text, ref err);
                them = false;
                load();
            }
            else if (sua)
            {
                s.suasach(tbID.Text, tbTS.Text, comboBoxLoaiSach.Text, Convert.ToInt32(tbSL.Text), comboBoxKeSach.Text, ref err);
                sua = false;
                load();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt = s.timkiem2(tbTK.Text);
            dgvS.DataSource = dt;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDienChinh gd = new GiaoDienChinh();
            gd.ShowDialog();
            this.Close();
        }

        private void comboBoxLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string MaLoaiSach = Convert.ToString(comboBoxLoaiSach.SelectedValue);
                DataTable table = new DataTable();
                table = ls.layloaisachId(MaLoaiSach).Tables[0];

            }
            catch
            {

            }
        }

        private void comboBoxKeSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string make = Convert.ToString(comboBoxKeSach.SelectedValue);
                DataTable table = new DataTable();
                table = ke.laykesach(make).Tables[0];

            }
            catch
            {

            }
        }
    }
}
