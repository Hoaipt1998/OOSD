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
            comboBoxLoaiSach.DisplayMember = "tenloaisach";
            comboBoxLoaiSach.ValueMember = "maloaisach";
            comboBoxLoaiSach.SelectedItem = 1;

            comboBoxKeSach.DataSource = ke.Layke().Tables[0];
            comboBoxKeSach.DisplayMember = "tenke";
            comboBoxKeSach.ValueMember = "make";
            comboBoxKeSach.SelectedItem = 1;
            dgvS.Columns[1].Width = 250;
            dgvS.Columns[4].Width = 100;
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
            load();
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
            if (sua == true)
            {
                MessageBox.Show("Chọn rồi mà!!! Chọn hoài vậy !!!");
            }
            else
            {
                string maloaisach = comboBoxLoaiSach.Text;
                string make = comboBoxKeSach.Text;
                DataTable table = new DataTable();
                DataTable table1 = new DataTable();
                table = ls.layloaisachId(maloaisach).Tables[0];
                table1 = ke.laykesachID(make).Tables[0];
                if (tbID.Text == "" || table.Rows.Count < 1 || table1.Rows.Count < 1)
                {
                    MessageBox.Show("Bạn cần chọn sách muốn sửa để thực hiện thao tác này !!!");
                }
                else
                {


                    sua = true;
                    them = false;
                    tbTS.Enabled = true;
                    comboBoxLoaiSach.Enabled = true;
                    tbSL.Enabled = true;
                    comboBoxKeSach.Enabled = true;

                    table = ls.layloaisachId(maloaisach).Tables[0];
                    table1 = ke.laykesachID(make).Tables[0];
                    comboBoxLoaiSach.Text = table.Rows[0]["tenloaisach"].ToString();
                    comboBoxKeSach.Text = table1.Rows[0]["tenke"].ToString();
                }
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn xóa sách này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                bool h = BLsach.Instance.xoasach(tbID.Text, ref err);
                if (h == false)
                {
                    MessageBox.Show("Bạn cần xóa những dữ liệu liên quan đến sách này !!!");
                }
                load();
            }
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "" || tbTS.Text == "" || tbSL.Text == "" || comboBoxKeSach.ValueMember == null||  comboBoxLoaiSach.ValueMember == null)
            {
                MessageBox.Show("Error", "Thieu Thong TIn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (them)
                {
                    if (BLsach.Instance.themsach(tbID.Text, tbTS.Text, comboBoxLoaiSach.SelectedValue.ToString(), Convert.ToInt32(tbSL.Text), comboBoxKeSach.SelectedValue.ToString(), ref err))
                    {
                        MessageBox.Show("Done!", "Them Thanh Cong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        them = false;
                        load();
                    }
                    else { MessageBox.Show("Error", "Sai Định Dạng Nhập Vào", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else if (sua)
                {
                    BLsach.Instance.suasach(tbID.Text, tbTS.Text, comboBoxLoaiSach.SelectedValue.ToString(), Convert.ToInt32(tbSL.Text), comboBoxKeSach.SelectedValue.ToString(), ref err);
                    sua = false;
                    load();
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //dt = new DataTable();
            //dt = s.timkiem2(tbTK.Text);
            //dgvS.DataSource = dt;
            if (radioButtonTenSach.Checked)
            {
                BLsach.Instance.SetSearchAlgorithm(new SearchTenSach());
                DataTable tb = BLsach.Instance.timsach(tbTK.Text);
                dgvS.DataSource = tb;
            }
            else
            {
                if (radioButtonLoaiSach.Checked)
                {
                    BLsach.Instance.SetSearchAlgorithm(new SearchLoaiSach());
                    DataTable tb = BLsach.Instance.timsach(tbTK.Text);
                    dgvS.DataSource = tb;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn kiểu tìm kiếm!");
                }
            }
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
                table = ke.laykesachID(make).Tables[0];

            }
            catch
            {

            }
        }

        private void tbTK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
